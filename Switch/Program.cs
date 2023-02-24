using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your Age ");
			String s = Console.ReadLine();
			int age = Convert.ToInt32(s);

			switch (age)
			{
				case 18:
					Console.WriteLine("You are kid now ");
					break;
				case 20:
					Console.WriteLine("You can drive ");
					break;
				case 75:
					Console.WriteLine("You are old guy ");
					break;
				default:
					Console.WriteLine("Alright you can enjoy");
					break;
			}

			Console.ReadLine();
		}
	}
}
