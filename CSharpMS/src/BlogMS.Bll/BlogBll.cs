using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogMS.Model;
using BlogMS.Repository;

namespace BlogMS.Bll
{
    public class BlogBll
    {

        private readonly BlogRepository _blogRepository = new BlogRepository();

        public IList<Blog> GetBlogsList(int? id)
        {

            return _blogRepository.GetBlogsList(id);
        }

        public void DeleteBlog(int id)
        {

            _blogRepository.DeleteBlog(id);
        }

        public void AddBlog(Blog blog)
        {

            _blogRepository.AddBlog(blog);
        }
    }
}



















//private readonly BlogRepository _blogRepository;

//public BlogBll(BlogRepository blogRepository)
//{
//    _blogRepository = blogRepository;
//}
