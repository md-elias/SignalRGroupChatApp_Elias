﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SignalRGroupChatApp_Elias.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Display(Name = "Role Name")]
        public string Name { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public Role()
        {
            new HashSet<UserRole>();
        }

        public Role(string roleName) : this()
        {
            Name = roleName;
        }
    }
}