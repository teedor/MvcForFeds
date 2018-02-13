using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MvcForFeds.Models
{
    public class FedViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FavouriteThing { get; set; }

        [UIHint("Rating")]
        public int Rating { get; set; }

        public List<string> Dislikes { get; set; }

        [Required]
        [RegularExpression(pattern: "^[0-9a-zA-Z]+(,[0-9a-zA-Z]+)*$")]
        public string DislikesInput { get; set; }

        [UIHint("WideDateTime")]
        public DateTime? DateOfBirth { get; set; }
    }
}