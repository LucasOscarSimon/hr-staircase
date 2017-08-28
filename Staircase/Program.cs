using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            int totalNumberOfSteps = Convert.ToInt32(Console.ReadLine());
            var cont = 0;
            for (int stp = totalNumberOfSteps - 1; stp >= 0; stp--)
            {
                builder.Append(' ', stp);
                cont++;
                if (builder.Length == stp)
                    builder.Append('#',cont);
                else
                    builder.Append('#', cont);
                builder.AppendLine();
            }
            
            Console.Write(builder);
            Console.ReadLine();
        }
    }
}