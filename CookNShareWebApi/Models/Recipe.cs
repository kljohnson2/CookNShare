using System;
using System.Collections.Generic;

namespace CookNShareWebApi.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<string> Steps { get; set; }
    }
}