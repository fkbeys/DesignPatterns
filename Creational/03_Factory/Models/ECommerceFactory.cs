namespace _03_Factory.Models
{
    public class ECommerceFactory : WebFactory
    {
        public override void CreateWebPage()
        {
            var ecomm = new ECommerce();
            ecomm.CreateWebPage();
        }
    }
}
