﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Content { get;set; }
        public bool Published { get; set; }
        public string Title { get; set; }
        public string Image { get;set; }
        public DateTime CreatedAt { get; set; }
        public Topic Topic { get; set; }
    }
}