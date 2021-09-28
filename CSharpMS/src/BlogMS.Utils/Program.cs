using System;

namespace BlogMS.Utils
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //// Entity Framework 6
            //using models.blogdbcontext context = new models.blogdbcontext();


            //var blogs = context.blogs.tolist();


            //foreach (models.blog blogdata in blogs)
            //    console.writeline(blogdata.title + " " + blogdata.body + " " + blogdata.author);



            //// NHibernate

            //using (isession session = nhibernatesession.opensession())
            //{
            //    var blogslist = session.query<hbmmodel.blog>().tolist();

            //    foreach (hbmmodel.blog blogdata in blogslist)
            //        console.writeline(blogdata.title + " " + blogdata.body + " " + blogdata.author);

            //}


            //public actionresult addtocart(int id, int custid)
            //{
            //    using (isession session = nhibernatesession.opensession())
            //    {
            //        using (itransaction transaction = session.begintransaction())
            //        {
            //            var newcart = new cart();
            //            newcart.productid = id;
            //            newcart.customerid = custid;
            //            newcart.quantity = 1;
            //            session.save(newcart);
            //            transaction.commit();
            //        }
            //    }
            //    return redirecttoaction("index", new { id = custid });
            //}

        }
    }
}
