namespace TaskDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            TeamLead teamLead1 = new TeamLead();
            Manager manager1 = new Manager();
            Task taskForDev = new Task() {  Title = "Title task1" , Description = "description task1"};
            Task taskForTeam = new Task() { Title = "Title task2", Description = "description task2" };
            teamLead1.AssginTask(developer, taskForDev);
            manager1.AssginTask(teamLead1, taskForTeam);
        }
    }
}
