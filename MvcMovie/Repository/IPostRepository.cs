using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Repository
{
    public interface IPostRepository
    {
        List<Post> GetAll();
        Post GetPost(int id);
        bool AddPost(Post post);
    }
}