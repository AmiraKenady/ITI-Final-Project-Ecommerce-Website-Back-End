﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class RoleCreateModel
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        [Display(Name = "Role Name")]
        public string Name { get; set; }
    }
}
