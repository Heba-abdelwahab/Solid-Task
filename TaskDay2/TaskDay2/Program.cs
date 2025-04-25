using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Unity;
namespace TaskDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task1
            //Developer developer = new Developer();
            //TeamLead teamLead1 = new TeamLead();
            //Manager manager1 = new Manager();
            //Task taskForDev = new Task() {  Title = "Title task1" , Description = "description task1"};
            //Task taskForTeam = new Task() { Title = "Title task2", Description = "description task2" };
            //teamLead1.AssginTask(developer, taskForDev);
            //manager1.AssginTask(teamLead1, taskForTeam);

            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<Shopper>().ImplementedBy<Shopper>());
            container.Register(Component.For<ICreditCard>().ImplementedBy<VisaCard>());
            Shopper shoper = container.Resolve<Shopper>();
            ICreditCard creditCard = container.Resolve<ICreditCard>();
            shoper.Checkout(creditCard);

            UnityContainer container2 = new UnityContainer();
            container2.RegisterType<Shopper, Shopper>();
            container2.RegisterType<ICreditCard, VisaCard>();
            Shopper shoper2 = container2.Resolve<Shopper>();
            ICreditCard creditCard2 = container2.Resolve<ICreditCard>();
            shoper2.Checkout(creditCard2);

        }
    }
}
