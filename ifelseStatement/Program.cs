using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseStatement
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Enter Your Age ");
			string agestr = Console.ReadLine();
			int age = Convert.ToInt32(agestr);
			bool isbanned = false;


			if (age < 2 || isbanned)
			{
				Console.WriteLine("Your are kid now Or you are Banned");
			}
			else if (age < 10 || isbanned)
			{
				Console.WriteLine("Justcomplete your school Or you are Banned");
			}
			else if (age < 18 || isbanned)
			{
				Console.WriteLine("You are below 18 Or you are Banned");
			}
			else if (age < 75 || isbanned)
			{
				Console.WriteLine("you can drive Now");
			}
			else
			{
				Console.WriteLine("you cannot drive Or you are Banned");
			}



			Console.ReadLine();

		}
	}
}
