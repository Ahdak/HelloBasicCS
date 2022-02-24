using System;
namespace HelloBasicCS.events
{
    public class EventProcessing
    {
        public EventProcessing()
        {
        }

        public void Play()
        {
            PlayWithEvents playWithEvents = new PlayWithEvents();
            playWithEvents.ProcessCompleted += ConsumeEvent;
            playWithEvents.StartProcess();

            // Process Event
            WithEventHandler withEventHandler = new WithEventHandler();
            withEventHandler.ProcessCompleted += ConsumeEventHandler;
            // Data from event
            withEventHandler.ProcessCompletedTyped += ConsumeEventData;
            withEventHandler.ProcessCompletedTyped += SecondConsumeEventData;
            withEventHandler.ProcessCompletedCustomType += ConsumeCustomEvent;
            withEventHandler.StartProcess();

            // Different event publisher
            var withEventHandler1 = new WithEventHandler();
            var withEventHandler2 = new WithEventHandler();
            withEventHandler1.ProcessCompleted += ConsumeEventHandler;
            withEventHandler2.StartProcess(); // ConsumeEventHandler cannot see the event


        }

        private void ConsumeCustomEvent(object sender, ProcessEventArgs e)
        {
            Console.WriteLine($"Getting custom event data IsOK={e.IsOk} and Status={e.Status}");
        }

        private void ConsumeEventData(object sender, int e)
        {
            Console.WriteLine($"Getting data = {e} from sender = {sender}");
        }

        private void SecondConsumeEventData(object sender, int e)
        {
            Console.WriteLine($"Second - Getting data = {e} from sender = {sender}");
        }

        private void ConsumeEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Process Completed from sender {sender}!");
        }


        private void ConsumeEvent()
        {
            Console.WriteLine("Consume Event");
        }

    }
}
