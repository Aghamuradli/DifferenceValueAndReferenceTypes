using System;

namespace math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourProcess process = new FourProcess();
            process.Gather(4, 5);
            process.Gather(6, 7);
        }
    }
}
