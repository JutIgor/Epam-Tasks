using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abstract.Abstract;
using Abstract.Entities;
using Irufushi.Domain.Concrete;
using Irufushi.WebUI.Models;
using WebMatrix.WebData;

namespace Irufushi.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPagesRepository _repository;
        //
        // GET: /User/

        public UserController(IUserPagesRepository userRepository)
        {
            _repository = userRepository;
        }

        [Authorize]
        public ActionResult Index(int? id)
        {
            if(id == null) id = WebSecurity.CurrentUserId;
            UserProfile user = new UserProfile();
            
            user = _repository.GetUser((int)id);

            if (id != WebSecurity.CurrentUserId)
            {
                ViewBag.Id = id;
                ViewBag.Button = true;
                if (_repository.IsFriend(WebSecurity.CurrentUserId, (int)id))
                    ViewBag.TypeButton = false;
                else ViewBag.TypeButton = true;
            }
            return View(user);
        }

        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null) id = WebSecurity.CurrentUserId;
            UserProfile user = new UserProfile();
            user = _repository.GetUser((int)id);
            return View(user);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Edit(UserProfile model, int? id)
        {
            if (id == null) id = WebSecurity.CurrentUserId;
            if (model.AboutUser.Id == 0) model.AboutUser.Id = (int)id;
            if(model.UserId == 0) model.UserId = (int)id;
            if(model.Contacts.Id == 0) model.Contacts.Id = (int)id;
            if (model.Location.Id == 0) model.Location.Id = (int)id;

            _repository.SaveProfile(model);

            return RedirectToAction("Index", "User", new { id = (int)id });
        }

        [Authorize]
        public ActionResult AddFriend(int id)
        {
            FriendShip friendship = new FriendShip();

            friendship.UserId = WebSecurity.CurrentUserId;
            friendship.FriendId = id;
            _repository.AddFriend(friendship);

            return RedirectToAction("Index", "User", new { id = id });
        }

        [Authorize]
        public ActionResult DeleteFriend(int id)
        {
            FriendShip friendship = new FriendShip();

            friendship.UserId = WebSecurity.CurrentUserId;
            friendship.FriendId = id;

            _repository.DeleteFriend(friendship);

            return RedirectToAction("Index", "User", new { id = id });
        }

        [Authorize]
        public ActionResult ShowFriends(int? id)
        {
            if(id == null) id = WebSecurity.CurrentUserId;

            UserModel viewModel = new UserModel
            {
                Users = _repository.GetFriends((int)id)
            };

            return View(viewModel);
        }

        [Authorize]
        public ActionResult ShowAllUsers()
        {
            List<UserProfile> userWM = _repository.UserProfiles.ToList();

            userWM.Remove(_repository.GetUser(WebSecurity.CurrentUserId));

            UserModel viewModel = new UserModel
            {
                Users = userWM
            };

            return View(viewModel);
        }
    }
}
