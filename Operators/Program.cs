using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 operator in c#
			 1.Arithematic operator 
			 2.Assignment operator
			 3.logic operator
			 4.Comparison opeators  
			*/

			//--------------------arithematic operator----------
		
			Console.WriteLine("-------Arithematic operator----------");

			int x = 8;
			int y = 10;

			Console.WriteLine("The value of a + b = " + (x + y));
			Console.WriteLine("The value of a - b = " + (x - y));
			Console.WriteLine("The value of a * b = " + (x * y));
			Console.WriteLine("The value of a / b = " + (x / y));
			
			

			//------------assignment operator----------------

			Console.WriteLine("-------Assignment operator----------");

			int a = 4;
			int b = a;
			b += 4;
			b -= 4;
			b *= 4;
			b /= 4;

			Console.WriteLine(b);

			//-----------------logical operator--------------------

			Console.WriteLine("-------Logical operator----------");

			Console.WriteLine(true && false);
			Console.WriteLine(true && true);
			Console.WriteLine(false && false);


			Console.WriteLine(true || false);
			Console.WriteLine(true || true);
			Console.WriteLine(false || false);

			Console.WriteLine(!false);
			Console.WriteLine(!true);

			//-------------------Comparision operator-----------------
			Console.WriteLine("-------Comparision operator----------");

			Console.WriteLine(324 > 555);
			Console.WriteLine(324 < 555);
			Console.WriteLine(324 >= 555);
			Console.WriteLine(324 <= 555);
			Console.WriteLine(324 != 555);
			Console.WriteLine(324 == 555);



			Console.Read();


		}
	}
}
