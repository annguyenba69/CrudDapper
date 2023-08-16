using Dapper;
using Microsoft.Extensions.Configuration;
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
    public class ProductService : IProductRepository
    {
        public SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(constr);
        }
        public void Add(Product product)
        {
            product.AddedOn = DateTime.Now;
            var sql = "Insert into Products (Name,Description,Barcode,Rate,AddedOn) VALUES (@Name,@Description,@Barcode,@Rate,@AddedOn)";
            try
            {
                connection();
                con.Open();
                var result = con.Execute(sql, product);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<Product> GetAll()
        {
            var sql = "SELECT * FROM Products";
            try
            {
                connection();
                con.Open();
                var result = con.Query<Product>(sql);
                return result.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public Product Get(int id) 
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            try
            {
                connection();
                con.Open();
                var result = con.QuerySingleOrDefault(sql, new {Id = id});
                return result;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}