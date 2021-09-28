using BlogMS.Bll;
using BlogMS.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMS.WebApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogsController : ControllerBase
    {

        private readonly BlogBll _Blogbll = new BlogBll();


        [HttpGet]
        public IList<Blog> GetBlogsList(int? id)      //-Get : http://localhost:8000/blogs or http://localhost:8000/blogs?id= + id
        {

            return _Blogbll.GetBlogsList(id);
        }


        [HttpGet]
        [Route("{id}")]
        public Blog GetBlogOne(int id)                //-Get : http://localhost:8000/blogs/ + id
        {
            var blog = new Blog();
            return _Blogbll.GetBlogsList(id).Count > 0 ? _Blogbll.GetBlogsList(id)[0] : blog;
        }


        [HttpDelete]
        [Route("{id}")]
        public void DeleteBlog(int id)                //-Delete : http://localhost:8000/blogs/ + id
        {

            _Blogbll.DeleteBlog(id);
        }


        [HttpPost]
        public void AddBlog(Blog blog)                //-Post : http://localhost:8000/blogs
        {

            _Blogbll.AddBlog(blog);
        }

    }
}












#pragma warning disable S125 // Sections of code should not be commented out
// // // // // // { Details } // // // // // // 

// [1]
// private readonly BlogBll _Blogbll;

// public BlogsController(BlogBll blogbll)  //Not Working as default constructor not being called (why?)
// {                                        
//    _Blogbll = blogbll;                   //so not able to intialize instance of BlogBll class
// }

#pragma warning restore S125 // Sections of code should not be commented out


