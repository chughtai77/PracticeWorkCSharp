using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathoperator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Math is buitlin function 
			Console.WriteLine("FIND A MAX VALUE");
			Console.Write("Enter value of a = ");

			string a = Console.ReadLine();

			Console.Write("Enter value of b = ");

			string b = Console.ReadLine();

			int a1 = Convert.ToInt32(a);
			int b1 = Convert.ToInt32(b);

			int max = Math.Max(a1, b1);
			int min = Math.Min(a1, b1);

			Console.WriteLine("Max value is :" + max);
			Console.WriteLine("Min Value is :" + min);


			Console.WriteLine("Find square root ");
			Console.Write("Enter value : ");
			string x = Console.ReadLine();
			int x1= Convert.ToInt32(x);

			double sqr = Math.Sqrt(x1);
			Console.WriteLine("Square root of your value is : " + sqr);



			Console.Read();

		}
	}
}
