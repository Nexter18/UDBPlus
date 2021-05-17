using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UDBPlus.ViewModel
{
    public class MessageViewModel
    {

        public int MessageId { get; set; }
        public string CName { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int MessageTypeId { get; set; }
    }
}