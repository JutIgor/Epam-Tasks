using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.Entities;

namespace Abstract.Abstract
{
    public interface IUserPagesRepository
    {
        IQueryable<UserProfile> UserProfiles { get; }
        void SaveUser(UserProfile user);
        void SaveAboutUser(AboutUser about);
        void SaveContacts(Contacts contacts);
        void SaveLocation(Location location);
        UserProfile GetUser(int id);
        void SaveProfile(UserProfile user);
        void AddFriend(FriendShip friendship);
        void DeleteFriend(FriendShip friendship);
        List<UserProfile> GetFriends(int id);
        bool IsFriend(int idUser, int isFriend);
        IQueryable<UserProfile> SearchUsersFName(string firstName, string lastName,
            string country, string city, string skype);
    }
}
