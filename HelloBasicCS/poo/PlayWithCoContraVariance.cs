using System;
namespace HelloBasicCS.poo
{

    public delegate Small covarDel(Big mc);

    public class PlayWithCoContraVariance
    {
        private Small MethodSmallSmall(Small s)
        {
            Console.WriteLine("MethodSmallSmall typeInput="+s.GetType());
            return new Big();
        }

        private Big MethodBigBig(Big s)
        {
            Console.WriteLine("MethodBigBig typeInput=" + s.GetType());
            return new Big();
        }

        private Small MethodSmallBig(Big s)
        {
            Console.WriteLine("MethodSmallBig typeInput=" + s.GetType());
            return new Small();
        }



        public void Play()
        {
            covarDel del = MethodBigBig;
            del += MethodSmallBig;
            del += MethodSmallSmall;
            Console.WriteLine(del(new Bigger()));
        }
    }

    public class Small { }
    public class Big : Small { }
    public class Bigger : Big { }

}
