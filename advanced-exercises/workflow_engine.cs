using System;
namespace AdvancedExercises
{
    public interface WorkFlow
    {
        void Execute();
    }
    public class ActivityA : WorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Runing activity A");
        }
    }
    public class ActivityB : WorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Runing activity B");
        }
    }
    public class WorkFlowEngine
    {
        public void Run(WorkFlow workFlow)
        {
            workFlow.Execute();

        }

    }

    public class MainProgram
    {

        static void Main(string[] args)
        {
            var a = new ActivityA();
            var b = new ActivityB();
            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(a);
            workFlowEngine.Run(b);

        }
    }
}