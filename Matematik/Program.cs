using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,6);
            for (int i = 0; i < 10; i++)
            {
                dortIslem.Topla(i, i + 1);
            }
        }
    }
}
