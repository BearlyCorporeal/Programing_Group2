/*
 * Created by SharpDevelop.
 * User: 102570136
 * Date: 21/03/2019
 * Time: 3:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace repetion_task_part_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string strcounter;
			int counter;
			int counter2 = 0;
			int countercopy;
			strcounter = Console.ReadLine();
			countercopy = int.Parse(strcounter);
			counter = int.Parse(strcounter);

		
			while (counter >0){
				Console.Write("X");
				counter = counter -1;
			if (counter == 0){
				counter2 = counter2 + 1;
				counter = countercopy - counter2;
				Console.WriteLine();}
			}
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}