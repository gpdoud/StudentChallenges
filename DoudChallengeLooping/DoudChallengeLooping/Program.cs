using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoudChallengeLooping {

	class Program {

		static void Main(string[] args) {

			int[] scores = { 83, 41, 46, 72, 32, 55, 69, 43, 16, 9, 9, 77, 90, 34, 1 };

			int sumOfScores = 0;

			/*
			 * After this comment, write a looping statement of any kind you choose
			 * that adds up all these scores and stored the sum in the variable sumOfScores
			 */

			// write your code here. Don't forget to store the answer in sumOfScores variable.



			// Do not change any code after this line!

			if(sumOfScores == scores.Sum()) {
				Console.WriteLine($"Correct! Good Job!");
			} else {
				Console.WriteLine($"Incorrect. The correct sum is {scores.Sum()}. Try again.");
			}
			Console.Write("Press any key ...");
			Console.ReadKey();
		}
	}
}
