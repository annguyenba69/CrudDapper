using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}