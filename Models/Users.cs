using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class User

    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Stack { get; set; }

        [MinLength(20)]
        public string Comment { get; set; }

        // public User(string n, string l, string s, string c)

        // {
        //     Name = n;
        //     Location = l;
        //     Stack = s;
        //     Comment = c;
        // }

    }



}