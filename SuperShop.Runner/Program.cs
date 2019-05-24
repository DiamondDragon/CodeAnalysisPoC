using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Disposable();
        }

        public static async void Test()
        {
            await Task.Yield();
        }

        public static void Test2(ref string value, out string value2)
        {
            value2 = "test";

            try
            {
                // do something
            }
            catch
            {
                int x = 0;
            }

        }
    }

    public class Disposable : IDisposable
    {
        public void Dispose()
        {
        }
    }
}
