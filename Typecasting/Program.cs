using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
	class Program
	{
		static void Main(string[] args)
		{
			// Type casting
			// There Are two type of casting 
			//	1.Implicit casting
			//    char to int to long to float to double

			//	2.Explicit casting
			//		


			//implicit 
			int x = 3;
			double y = x;
			float y1 = 'D';
			//int z = y;
			char a = 'a';
			int z = a;
			int z1 = 'B';

			Console.WriteLine(z1);


			//Explicit
			float z2 = (float) 3.5;
			double d = 3.5;
			//float varr = 3.55F;
			float varr = Convert.ToInt32(3.55);

			Console.WriteLine(d);

			Console.Read();
		}
	}
}
