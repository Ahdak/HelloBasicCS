using System;
namespace HelloBasicCS.poo
{
    public interface MyType
    {

    }

    public interface MySubType : MyType
    {

    }

    public class GenericWithConstraint<T> where T : MyType
    {
        public GenericWithConstraint()
        {
        }
    }

    public class GenericWithConstraintWithNew<T> where T : class, new()
    {
    }
}
