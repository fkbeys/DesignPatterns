namespace _03_Factory.Models
{
    public class BlogFactory : WebFactory
    {
        public override void CreateWebPage()
        {
            var blog = new Blog();
            blog.CreateWebPage();
        }
    }
}
