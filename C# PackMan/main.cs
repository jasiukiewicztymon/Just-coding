using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


namespace PacMan
{
    class Program
    {
        public static void Printmenu()
        {
            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BufferHeight = Console.WindowHeight = 10;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("Welcome to PacMan");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(27, 3);
            Console.WriteLine("Play\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(15, 4);
            Console.WriteLine("[ SMASH THE SPACE TO PLAY ]");
            ConsoleKeyInfo _key;
            do
            {
                _key = Console.ReadKey(true);
            } while (_key.Key != ConsoleKey.Spacebar);
        }

        public static void PrintPlayer(int x, int y, int mapx, int mapy, char p)
        {
            Console.SetCursorPosition(x + mapx, y + mapy);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(p);
        }

        public class Th
        {
            public string[] Fmap;
            public int Fpos_y_player, Fpos_x_player, Fx_print, Fy_print;
            public char Fplayer;
            public int[,] Fm_pos;
            public char[] Fmonsters;
            bool open = true;

            // Effects
            bool OPMan = false;
            long points = 0;

            public void PlayerMove()
            {
                ConsoleKey Fmove = ConsoleKey.Q;
                bool b = false;

                int i = 0, j = 0;
                char oldPlayer = Fplayer;

                do
                {
                    Console.CursorVisible = false;
                    if (j < 30)
                        Fplayer = 'o';
                    else
                        Fplayer = oldPlayer;

                    if (j == 60)
                        j = 0;
                    j++;
                    PrintPlayer(Fpos_x_player, Fpos_y_player, Fx_print, Fy_print, Fplayer);
                    Thread.Sleep(10);

                    if (!Console.KeyAvailable)
                        continue;
                    
                    Fmove = Console.ReadKey(true).Key;

                    switch (Fmove)
                    {
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.W:
                            if (Fmap[Fpos_y_player - 1][Fpos_x_player] != '█')
                            {
                                Console.SetCursorPosition(Fpos_x_player + Fx_print, Fpos_y_player + Fy_print);
                                Console.Write(' ');
                                Fpos_y_player--;
                                oldPlayer = Fplayer = 'u';
                            }
                            break;
                        case ConsoleKey.DownArrow:
                        case ConsoleKey.S:
                            if (Fmap[Fpos_y_player + 1][Fpos_x_player] != '█' && Fmap[Fpos_y_player + 1][Fpos_x_player] != '▒')
                            {
                                Console.SetCursorPosition(Fpos_x_player + Fx_print, Fpos_y_player + Fy_print);
                                Console.Write(' ');
                                Fpos_y_player++;
                                oldPlayer = Fplayer = 'n';
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.A:
                            if (Fmap[Fpos_y_player][Fpos_x_player - 1] != '█')
                            {
                                Console.SetCursorPosition(Fpos_x_player + Fx_print, Fpos_y_player + Fy_print);
                                Console.Write(' ');
                                if (Fpos_x_player == 1)
                                    Fpos_x_player = Fmap[0].Length - 2;
                                else
                                    Fpos_x_player--;
                                oldPlayer = Fplayer = '>';
                            }
                            break;
                        case ConsoleKey.RightArrow:
                        case ConsoleKey.D:
                            if (Fmap[Fpos_y_player][Fpos_x_player + 1] != '█')
                            {
                                Console.SetCursorPosition(Fpos_x_player + Fx_print, Fpos_y_player + Fy_print);
                                Console.Write(' ');
                                if (Fpos_x_player == Fmap[0].Length - 2)
                                    Fpos_x_player = 1;
                                else
                                    Fpos_x_player++;
                                oldPlayer = Fplayer = '<';
                            }
                            break;
                    }
                } while ((Fpos_x_player != Fm_pos[0, 0] && Fpos_y_player != Fm_pos[0, 1]) || (Fpos_x_player != Fm_pos[1, 0] && Fpos_y_player != Fm_pos[1, 1]) || (Fpos_x_player != Fm_pos[2, 0] && Fpos_y_player != Fm_pos[2, 1]) && Fmove != ConsoleKey.Escape);
            }
            public void EnemiesMove()
            {
                // sleep 100ms
            }
            public void WriteParam()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print);
                Console.WriteLine($"Points: {points}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print + 1);
                Console.WriteLine($"OPMan: {OPMan}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print + 4);
                Console.WriteLine("Mouvements:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print + 6);
                Console.WriteLine("↑ W | Up arrow");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print + 7);
                Console.WriteLine("← A | Left arrow");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print + 8);
                Console.WriteLine("↓ S | Down arrow");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print + 9);
                Console.WriteLine("→ D | Right arrow");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(Fx_print + Fmap[0].Length + 4, Fy_print + 11);
                Console.WriteLine("Made by titi_2115");
            }
        }

        static void Main(string[] args)
        {
            int Width = Console.WindowWidth;
            int Height = Console.WindowHeight;
            const int x_print = 5, y_print = 3;
            int pos_x_player = 18, pos_y_player = 4;

            string[] map = {
                " ███████████████████████ ",
                " █          █          █ ",
                " █ ███ ████ █ ████ ███ █ ",
                " █ ███ ████ █ ████ ███ █ ",
                " █                     █ ",
                " █ ███ █ ███████ █ ███ █ ",
                " █     █ ███████ █     █ ",
                " █████ █    █    █ █████ ",
                " █████ ████ █ ████ █████ ",
                " █████ █         █ █████ ",
                " █████ █ ███▒███ █ █████ ",
                "         █     █         ",
                " █████ █ ███████ █ █████ ",
                " █████ █         █ █████ ",
                " █████ █ ███████ █ █████ ",
                " █████ █ ███████ █ █████ ",
                " █          █          █ ",
                " █ ███ ████ █ ████ ███ █ ",
                " █   █             █   █ ",
                " ███ █ █ ███████ █ █ ███ ",
                " █     █    █    █     █ ",
                " █ ████████ █ ████████ █ ",
                " █ ████████ █ ████████ █ ",
                " █                     █ ",
                " ███████████████████████ "
            };

            char player = 'c';
            const char point = 'ò';

            char[] monsters = { 'n', 'n', 'n' };
            int[,] m_pos = { { 0, 0 }, { 0, 0 }, { 0, 0 } };

            Console.Clear();
            Console.CursorVisible = false;
            Printmenu();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.BufferWidth = Console.WindowWidth = 60;
            Console.BufferHeight = Console.WindowHeight = 35;
            Console.CursorVisible = false;

            for (int i = 0; i < map.Length; i++)
            {
                Console.SetCursorPosition(x_print, y_print + i);
                Console.Write(map[i]);
            }

            PrintPlayer(pos_x_player, pos_y_player, x_print, y_print, player);

            Th t = new Th();
            t.Fmap = map;
            t.Fpos_y_player = pos_y_player;
            t.Fpos_x_player = pos_x_player;
            t.Fx_print = x_print;
            t.Fy_print = y_print;
            t.Fplayer = player;
            t.Fm_pos = m_pos;
            t.Fmonsters = monsters;

            Thread tParams = new Thread(new ThreadStart(t.WriteParam));

            tParams.Start();
            t.PlayerMove();

            Console.ReadKey(true);
        }
    }
}
