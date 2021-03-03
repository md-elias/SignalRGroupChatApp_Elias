using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SignalRGroupChatApp_Elias.Models
{
    public class MeetingRoom
    {
        [Key]
        public int ConversationRoomID { get; set; }

        [ForeignKey("RoomChat")]
        public string RoomName { get; set; }

        [ForeignKey("UserRole")]
        public int UserRoleID { get; set; }
        public bool Allowed { get; set; }

        public virtual RoomChat RoomChat { get; set; }
        public virtual UserRole UserRole { get; set; }

        public MeetingRoom()
        {
            new RoomChat();
            new UserRole();
        }

        public MeetingRoom(string chatRoom, int userRoleId, bool allowed) : this()
        {
            RoomName = chatRoom;
            UserRoleID = userRoleId;
            Allowed = allowed;
        }
    }
}