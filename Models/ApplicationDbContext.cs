using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalRGroupChatApp_Elias.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DbCon")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RoomChat> RoomChats { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<Chating> Chatings { get; set; }
    }
}