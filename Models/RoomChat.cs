using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SignalRGroupChatApp_Elias.Models
{
    public class RoomChat
    {
        [Key]
        public string RoomName { get; set; }

        [DataType(DataType.Date), Column(TypeName = "DATE")]
        public DateTime RoomCreationDate { get; set; }

        public virtual ICollection<MeetingRoom> MeetingRooms { get; set; }

        public RoomChat()
        {
            new HashSet<MeetingRoom>();
        }

        public RoomChat(string roomName, DateTime roomCreationDate) : this()
        {
            RoomName = roomName;
            RoomCreationDate = roomCreationDate;
        }
    }
}