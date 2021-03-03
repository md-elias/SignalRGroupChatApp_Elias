using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SignalRGroupChatApp_Elias.Models
{
    public class Chating
    {
        [Key]
        public int ChatMessageID { get; set; }

        [ForeignKey("UserRole")]
        public int UserRoleID { get; set; }

        [Required(ErrorMessage ="please write your message")]
        public string Message { get; set; }
        public DateTime PostDateTime { get; set; }

        public virtual UserRole UserRole { get; set; }

        public Chating()
        {
            new UserRole();
        }

        public Chating(int userRoleId, string messge) : this()
        {
            UserRoleID = userRoleId;
            Message = messge;
            PostDateTime = DateTime.Now;
        }
    }
}