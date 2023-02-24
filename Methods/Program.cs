using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	internal class Program
	{
		//static void greet()
		//{
		//	Console.WriteLine("My Name is :");
		//}

		static void greet(string n)
		{
			Console.WriteLine("My Name is :" + n);
		}


		static float avg(int a, int b , int c)
		{
			float sum = a+ b + c;
			//int avg = sum / 3;

			return sum/3;
		}

		static float avg(int a, int b)
		{
			float sum = a + b;
			//int avg = sum / 3;

			return sum / 2;
		}


		static void Main(string[] args)
		{

			greet("Imran chughtai");
			greet("Usman");

			Console.WriteLine("Avg of 3 number is : " + avg(2,3,4));
			Console.WriteLine("Avg of 3 number is : " + avg(6, 9, 10));

			Console.Write("Enter Fisrt variable ");
			string a1 = Console.ReadLine();
			Console.Write("Enter Second variable ");
			string b1 = Console.ReadLine();
			Console.Write("Enter Third variable ");
			string c1 = Console.ReadLine();

			int a = Convert.ToInt32(a1);
			int b = Convert.ToInt32(b1);
			int c = Convert.ToInt32(c1);

			Console.WriteLine("Avg of Three numer is = "+ avg(a,b,c));

			Console.WriteLine("Avg of Two numer is = " + avg(a, b));


			Console.ReadLine();
		}
	}
}
