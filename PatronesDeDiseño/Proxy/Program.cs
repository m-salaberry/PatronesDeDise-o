namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRepository repo = new CustomerRepositoryProxy();

                Session.CanGetAll = true;
                Session.CanSave = true;

                Customer p1 = new Customer("customer 1");
                Customer p2 = new Customer("customer 2");

                repo.Save(p1);
                repo.Save(p2);

                foreach (var p in repo.GetAll())
                {
                    Console.WriteLine(p.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}