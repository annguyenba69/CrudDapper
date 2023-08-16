using Dapper;
using MvcMovie.Models;
using MvcMovie.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcMovie.Service
{
    public class PostService : IPostRepository
    {
        public SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(constr);
        }

        public bool AddPost(Post post)
        {
            post.CreatedAt= DateTime.Now;
            var sql = "Insert into Posts (Alias,Content,Published,Title,Image,TopicId,CreatedAt) VALUES (@Alias,@Content,@Published,@Title,@Image,@TopicId,@CreatedAt)";
            try
            {
                connection();
                con.Open();
                var result = con.Execute(sql, post);
                if(result > 0)
                {
                    return true;
                }
                return false;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int id)
        {
            throw new NotImplementedException();
        }


    }
}