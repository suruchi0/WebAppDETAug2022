﻿
using MVCDemo.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCDemo.Models
{
    public class Friend
    {
        [Required]
        public int FriendId { get; set; }

        [Required]
        public string FriendName { get; set; }
        public string Place { get; set; }

    }
}


