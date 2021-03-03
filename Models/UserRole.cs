using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SignalRGroupChatApp_Elias.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleID { get; set; }

        [ForeignKey("User")]
        public string UserName { get; set; }

        [ForeignKey("Role")]
        public int RoleID { get; set; }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

        public virtual ICollection<Connection> Connections { get; set; }
        public virtual ICollection<MeetingRoom> MeetingRooms { get; set; }
        public virtual ICollection<Chating> Chatings { get; set; }

        public UserRole()
        {
            new HashSet<Connection>();
            new HashSet<MeetingRoom>();
            new HashSet<Chating>();
        }

        public UserRole(string userName, int roleId) : this()
        {
            UserName = userName;
            RoleID = roleId;
        }
    }
}