using System;
namespace HelloBasicCS.events
{
    public delegate void Notify();

    public class PlayWithEvents
    {
        public PlayWithEvents()
        {
        }

        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }

}
