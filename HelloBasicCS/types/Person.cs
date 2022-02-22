using System;
namespace HelloBasicCS.types
{
    public partial class Person
    {
        private int Id { get; set; }
        private int Name { get; set; }
    }

    public partial class Person
    {
        public void WhoAmI()
        {
            Console.WriteLine("Im {0} , id {1}", Name, Id);
        }
    }
}
