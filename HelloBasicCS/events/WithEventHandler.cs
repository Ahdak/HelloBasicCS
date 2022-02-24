using System;
namespace HelloBasicCS.events
{

    public class WithEventHandler
    {
        // declaring an event using built-in EventHandler
        public event EventHandler ProcessCompleted;
        public event EventHandler<int> ProcessCompletedTyped;
        public event EventHandler<ProcessEventArgs> ProcessCompletedCustomType;

        public void StartProcess()
        {
            Console.WriteLine("Process Started With Event Handlers!");
            // some code here..
            OnProcessCompleted(EventArgs.Empty); //No event data
            ProcessCompletedTyped?.Invoke(this, 2) ;
            ProcessCompletedCustomType?.Invoke(this, new ProcessEventArgs { IsOk =true, Status= "OK" });
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }

    public class ProcessEventArgs : EventArgs
    {
        public bool IsOk { get; set; }
        public String Status { get; set; }
    }
}
