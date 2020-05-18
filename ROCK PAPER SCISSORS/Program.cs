using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS
{
	class Program
	{
		static void Main(string[] args)
		{

			String inputPlayer, inputCPU;
			int randomInt;
			int scorePlayer = 0;
			int scoreCPU = 0;

			while (scorePlayer < 3 && scoreCPU <3 )
			{

				Console.Write("Choose between ROCK, PAPER, SCISSORS:	");
				inputPlayer = Console.ReadLine();

				Random rnd = new Random();

				randomInt = rnd.Next(1, 4);

				switch (randomInt)
				{
					case 1:
						inputCPU = "ROCK";
						Console.WriteLine("Computer choses ROCK");
						if (inputPlayer == "ROCK")
						{
							Console.WriteLine("DRAW!!");
						}
						else if (inputPlayer == "PAPER")
						{
							Console.WriteLine("PLAYER WINS!");
							scorePlayer++;
						}
						else if (inputPlayer == "SCISSORS")
						{
							Console.WriteLine("CPU WINS :/");
							scoreCPU++;
						}
						break;

					case 2:
						inputCPU = "PAPER";
						Console.WriteLine("Computer choses PAPER");
						if (inputPlayer == "PAPER")
						{
							Console.WriteLine("DRAW!!");
						}
						else if (inputPlayer == "SCISSORS")
						{
							Console.WriteLine("PLAYER WINS!");
							scorePlayer++;
						}
						else if (inputPlayer == "ROCK")
						{
							Console.WriteLine("CPU WINS :/");
							scoreCPU++;
						}
						break;

					case 3:
						inputCPU = "SCISSORS";
						Console.WriteLine("Computer choses SCISSORS");
						if (inputPlayer == "SCISSORS")
						{
							Console.WriteLine("DRAW!!");
						}
						else if (inputPlayer == "ROCK")
						{
							Console.WriteLine("PLAYER WINS!");
							scorePlayer++;
						}
						else if (inputPlayer == "PAPER")
						{
							Console.WriteLine("CPU WINS :/");
							scoreCPU++;
						}
						break;

					default:
						break;
				}
			}


			if (scorePlayer == 3)
			{
				Console.WriteLine("Player won!");
			}
			else if (scoreCPU == 3)
			{
				Console.WriteLine("CPU won!");
			}
			else
			{

			}
			Console.WriteLine("Do you want to play again?");



			Console.ReadLine();

		}
	}
}
