using BlogMS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BlogMS.Repository
{
    public class BlogRepository
    {

        public IList<Blog> GetBlogsList(int? id)  // Read Operation of  C [R] E D
        {

            var blogList = new List<Blog>();

            string connStr = "server=localhost;database=BlogDB;trusted_connection=true";

            string query = "SELECT * FROM Blog";

            string cond = " WHERE id = @FirstColumn";

           
            using (SqlConnection conn = new SqlConnection(connStr))      // Simple ADO.NET Querying using Microsoft.Data.SqlClient
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                if(id == null)
                {
                    cmd.CommandText = query;
                }
                else
                {
                    cmd.CommandText = query + cond;
                    cmd.Parameters.Add(new SqlParameter("FirstColumn", id));
                }

                conn.Open();      // use the connection here  

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    DataTable table = new DataTable();

                    table.Load(reader);

                    reader.Close();

                    int i = 0;
                    while (i < table.Rows.Count)
                    {
                        var blog = new Blog();
                        blog.id = (int)table.Rows[i].ItemArray[0];
                        blog.title = (string)table.Rows[i].ItemArray[1];
                        blog.body = (string)table.Rows[i].ItemArray[2];
                        blog.author = (string)table.Rows[i].ItemArray[3];

                        blogList.Add(blog);
                        i++;
                    }
                }
            }

            return blogList;
        }


        public void DeleteBlog(int id)    // Delete Operation of  C R E [D]
        {

            string connStr = "server=localhost;database=BlogDB;trusted_connection=true";

            string query = "DELETE FROM Blog";

            string cond = " WHERE id = @FirstColumn";

            using (SqlConnection conn = new SqlConnection(connStr))      // Simple ADO.NET Querying using Microsoft.Data.SqlClient
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = query + cond;
                cmd.Parameters.Add(new SqlParameter("FirstColumn", id));

                conn.Open();      // use the connection here  

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Close();
                }
            }
        }


        public void AddBlog(Blog blog)  // Create Operation of  [C] R E D
        {
            string connStr = "server=localhost;database=BlogDB;trusted_connection=true";

            string query = "INSERT INTO Blog";

            string paramList = " (title, body, author) VALUES (@Title, @Body, @Author)";

            using (SqlConnection conn = new SqlConnection(connStr))      // Simple ADO.NET Querying using Microsoft.Data.SqlClient
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = query + paramList;
                cmd.Parameters.Add(new SqlParameter("Title", blog.title));
                cmd.Parameters.Add(new SqlParameter("Body", blog.body));
                cmd.Parameters.Add(new SqlParameter("Author", blog.author));

                conn.Open();      // use the connection here  

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Close();
                }
            }
        }


        //public void UpdateBlog(Blog blog)   // Edit/Update Operation of C R [E] D
    }
}
