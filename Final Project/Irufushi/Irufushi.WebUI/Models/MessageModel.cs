using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abstract.Entities;

namespace Irufushi.WebUI.Models
{
    public class MessageModel
    {
        public IEnumerable<Message> inputMessages { get; set; }
        public IEnumerable<Message> outputMessages { get; set; }
    }
}