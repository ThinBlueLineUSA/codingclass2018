using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading;
///█ ■
namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 38;
            Console.WindowWidth = 135;

            int scoreadd;
            int time;
            
            int screenwidth = Console.WindowWidth;
            int screenheight = Console.WindowHeight;
            Console.ForegroundColor = ConsoleColor.Green;
            string startmenu = "Welcome to Snake!";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (startmenu.Length / 2), Console.WindowHeight / 2 - 6);
            Console.WriteLine(startmenu);
            string startit = "Select your difficulty level (1 - 3) and press Enter to start";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (startit.Length / 2), Console.WindowHeight / 2 - 5);
            Console.WriteLine(startit);
            string num1 = "1. Easy Peasy";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (num1.Length / 2), Console.WindowHeight / 2 - 4);
            Console.WriteLine(num1);
            string num2 = "2. Bout Medium";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (num2.Length / 2), Console.WindowHeight / 2 - 3);
            Console.WriteLine(num2);
            string num3 = "3. Kinda Tricky";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (num3.Length / 2), Console.WindowHeight / 2 - 2);
            Console.WriteLine(num3);
            string pressp = "Press 'P' at any time to pause the game,";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (pressp.Length / 2), Console.WindowHeight / 2);
            Console.WriteLine(pressp);
            string pressesc = "press 'esc' to close the window";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (pressesc.Length / 2), Console.WindowHeight / 2 + 1);
            Console.WriteLine(pressesc);
            int difflevel = int.Parse(Console.ReadLine());

            SoundPlayer music = new SoundPlayer
            {
                SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "DancingMidgets.wav"
            };
            music.PlayLooping();


			char again = 'y';
			do
			{
                if (difflevel == 1)
                {
                    scoreadd = 5;
                    time = 200;
                }
                else if (difflevel == 2)
                {
                    scoreadd = 5;
                    time = 125;
                }
                else if (difflevel == 3)
                {
                    scoreadd = 10;
                    time = 60;
                }
                Random rand = new Random();
				int score = 0;
				int gameover = 0;
				Head head = new Head
				{
					Xpos = screenwidth / 2 - 1,
					Ypos = screenheight / 2,
					Color = ConsoleColor.Green
				};
				string movement = "UP";
				List<int> xposbody = new List<int>();
				List<int> yposbody = new List<int>();
				int berryx = rand.Next(0 / 2, screenwidth / 2) * 2;
				int berryy = rand.Next(0 / 2, screenheight / 2) * 2;
				DateTime times = DateTime.Now;
				DateTime times2 = DateTime.Now;
				string buttonpressed = "no";
				DrawBorder(screenwidth, screenheight);

				while (true)
				{
					ClearConsole(screenwidth, screenheight);
					if (head.Xpos == screenwidth - 1 || head.Xpos == 0 || head.Ypos == screenheight - 1 || head.Ypos == 0)
					{
						gameover = 1;
					}
                
					Console.ForegroundColor = ConsoleColor.Green;
					if (berryx == head.Xpos && berryy == head.Ypos)
					{
						score += 5;
						/*SoundPlayer berryget = new SoundPlayer();
						berryget.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "berryget.wav";
						berryget.Play();*/
						//music.PlayLooping();
                    
						int tempx = rand.Next(1, ((screenwidth - 1) / 2));
						berryx = tempx * 2;
						int tempy = rand.Next(1, ((screenheight - 1) / 2));
						berryy = tempy * 2;
                    
					}
					for (int i = 0; i < xposbody.Count(); i++)
					{
						Console.SetCursorPosition(xposbody[i], yposbody[i]);
						Console.Write("■");
						if (xposbody[i] == head.Xpos && yposbody[i] == head.Ypos)
						{
							gameover = 1;
						}
					}
					if (gameover == 1)
					{
						break;
					}
					Console.SetCursorPosition(head.Xpos, head.Ypos);
					Console.ForegroundColor = head.Color;
					Console.Write("■");
					Console.SetCursorPosition(berryx, berryy);
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.Write("■");
					Console.CursorVisible = false;
					times = DateTime.Now;
					buttonpressed = "no";
					while (true)
					{
						times2 = DateTime.Now;
						if (times2.Subtract(times).TotalMilliseconds > 100) { break; }
						if (Console.KeyAvailable)
						{
							ConsoleKeyInfo key = Console.ReadKey(true);
                        
							if (key.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN" && buttonpressed == "no")
							{
								movement = "UP";
								buttonpressed = "yes";
							}
							if (key.Key.Equals(ConsoleKey.DownArrow) && movement != "UP" && buttonpressed == "no")
							{
								movement = "DOWN";
								buttonpressed = "yes";
							}
							if (key.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT" && buttonpressed == "no")
							{
								movement = "LEFT";
								buttonpressed = "yes";
							}
							if (key.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT" && buttonpressed == "no")
							{
								movement = "RIGHT";
								buttonpressed = "yes";
							}
							if (key.Key.Equals(ConsoleKey.Escape) && buttonpressed == "no")
							{
								goto Exit;
							}
							if (key.Key.Equals(ConsoleKey.P) && buttonpressed == "no")
							{
                                string pause = "Game paused, press 'p' to continue";
                                Console.SetCursorPosition((Console.WindowWidth / 2) - (pause.Length / 2), Console.WindowHeight / 2 - 3);
                                Console.WriteLine(pause);
                                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.P))
                                {
                                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                                        goto Exit;
                                }

                            }
                        }
					}
					xposbody.Add(head.Xpos);
					yposbody.Add(head.Ypos);
					switch (movement)
					{
						case "UP":
							head.Ypos--;
							break;
						case "DOWN":
							head.Ypos++;
							break;
						case "LEFT":
							head.Xpos -= 2;
							break;
						case "RIGHT":
							head.Xpos += 2;
							break;
					}
					if (xposbody.Count() > score)
					{
						xposbody.RemoveAt(0);
						yposbody.RemoveAt(0);
					}
				}
				string topline = "Game Over. Final Score: " + (score / 5);
				Console.SetCursorPosition((screenwidth / 2) - (topline.Length / 2), screenheight / 2 - 4);
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine(topline);
				string bottomline = "Play again? (y/n): ";
				Console.SetCursorPosition((screenwidth / 2) - (bottomline.Length / 2), screenheight / 2 - 3);
				Console.Write(bottomline);
				again = Convert.ToChar(Console.ReadLine());
				if (again == 'n')
				{
					break;
				}

				string doagain = "Press Enter";
				Console.SetCursorPosition((Console.WindowWidth / 2) - (doagain.Length / 2), Console.WindowHeight / 2 - 3);
				Console.WriteLine(doagain);
				int tempinput = int.Parse(Console.ReadLine());

			} while (again == 'y');
            Exit:
                { }
        }

        private static void ClearConsole(int screenwidth, int screenheight)
        {
            var blackLine = string.Join("", new byte[screenwidth - 2].Select(b => " ").ToArray());
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 1; i < screenheight - 1; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(blackLine);
            }
        }

        private static void DrawBorder(int screenwidth, int screenheight)
        {
            var horizontalBar = string.Join("", new byte[screenwidth].Select(b => "■").ToArray());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(0, 0);
            Console.Write(horizontalBar);
            Console.SetCursorPosition(0, screenheight - 1);
            Console.Write(horizontalBar);

            for (int i = 0; i < screenheight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("█");
                Console.SetCursorPosition(screenwidth - 1, i);
                Console.Write("█");
            }
        }

        class Head
        {
            public int Xpos { get; set; }
            public int Ypos { get; set; }
            public ConsoleColor Color { get; set; }
        }
        class Difficulty
        {
            public int Scoreadd { get; set; }
            public int Time { get; set; }
        }
    }
}