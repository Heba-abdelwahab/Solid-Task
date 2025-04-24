using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay2
{

    // 1.
    // a. Based on specifications, we need to create an interface and a TeamLead class to implement it.
    // b. Later another role like Manager, who assigns tasks to TeamLead and will not work on the tasks, is introduced into the system,
    // Apply needed refactoring to for better design and mention the current design smells

    //public Interface ILead
    //{  
    //    void CreateSubTask();  
    //    void AssginTask();  
    //    void WorkOnTask();
    //}
    //public class TeamLead : ILead
    //{
    //    public void AssignTask()
    //    {
    //        // create a task
    //        Task t = new Task() { Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop" };

    //        //Code to assign a task. 
    //        t.AssignTo(new Developer() { Name = "Developer1" });
    //    }
    //    public void CreateSubTask()
    //    {
    //        //Code to create a sub task  
    //    }
    //    public void WorkOnTask()
    //    {
    //        //Code to implement perform assigned task.  
    //    }
    //}


    public class Developer:IWorker
    {
        public Developer()
        {
        }

        public string Name { get; set; }

        public void DoTask()
        {
            Console.WriteLine("iam developer and work in task");
        }
    }
    public class Task:ITask
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public void AssignTo(IWorker worker)
        {
            Console.WriteLine("Assign to task");
        }
    }
    public interface ICreateSubTask
    {
        void CreateSubTask();
    }

    public interface IAssignTask
    {
        void AssginTask(IWorker w , ITask task);
    }
    public interface IWorkOnTask
    {
       void WorkOnTask();
    }

    public interface IWorker
    {
        void DoTask();
    }
    public interface ITask
    {
        void AssignTo(IWorker worker);
    }

    public class TeamLead : ICreateSubTask, IAssignTask, IWorkOnTask,IWorker
    {
        //public void AssginTask()
        //{
        //    // create a task
        //    Task t = new Task() { Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop" }; //1 Hidden dependency
        //    //Code to assign a task. 
        //    t.AssignTo(new Developer() { Name = "Developer1" }); //2 Hidden dependency
        //}
        public void AssginTask(IWorker w, ITask task)
        {
            task.AssignTo(w);   
        }
        public void CreateSubTask()
        {
            //Code to create a sub task  
        }
        public void WorkOnTask()
        {
            Console.WriteLine("I team lead am Work in task");
        }
        public void DoTask()
        {
            //Code to implement perform assigned task.  
        }
    }
    public class Manager : IAssignTask
    {
        public void AssginTask(IWorker w, ITask task)
        {
            task.AssignTo(w);
        }

    }


}
