using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

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

        [UIHint("StringList")]
        public List<string> Dislikes { get; set; }

        [Required]
        [UIHint("TagEditor")]
        public string DislikesInput { get; set; }

        [UIHint("WideDateTime")]
        public DateTime? DateOfBirth { get; set; }
    }
}