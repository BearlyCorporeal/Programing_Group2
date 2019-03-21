/*
 * Created by SharpDevelop.
 * User: 102570136
 * Date: 21/03/2019
 * Time: 4:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace repition_exercize_2 {
	class Program {
		public static void Main(string[] args) {
			int counter = 1;
			int counter2 = 0;
			
				while (counter > 0) {
					Console.Write("X");
					counter = counter - 1;
					if (counter == 0) {
						counter2 = counter2 + 1;
						counter = 1 + counter2;
						Console.WriteLine();
						if (counter == 6){
							counter = 0;
						}
					}
				}
			
			// TODO: Implement Functionality Here

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}