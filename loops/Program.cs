using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//While 
			Console.WriteLine("--------------While Loop-----");
			int a = 0;
			while (a < 5)
			{
				Console.WriteLine(a+1);
				a++;
			
			}

			// Do While
			Console.WriteLine("--------------DO While -----");
			int b = 0;
			do{
				Console.WriteLine(b + 1);
				b++;
			} while (b < 5);

			//For loop
			Console.WriteLine("--------------For Loop -----");

			for (int i = 0; i <= 10; i++) 
			{
				if (i == 0)
				{
					continue;
				}
				Console.WriteLine(i);
			}
			
			//Break:     Break the loop forever
			//Continue:  leave the perticular iteration of loop 

			Console.ReadLine();
		}
	}
}
