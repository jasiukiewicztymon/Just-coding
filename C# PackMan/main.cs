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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("Welcome to PacMan");
            Console.SetCursorPosition(27, 3);
            Console.WriteLine("Play\n\n");
            Console.SetCursorPosition(15, 4);
            Console.WriteLine("[ smash the space to play ]");
            ConsoleKeyInfo _key;
            do
            {
                _key = Console.ReadKey();
            } while (_key.Key != ConsoleKey.Spacebar);
        }

        public static void PrintPlayer(int x, int y, int mapx, int mapy, char p)
        {
            Console.SetCursorPosition(x + mapx, y + mapy);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(p);
        }

        class Th
        {
            public string[] Fmap;
            public int Fpos_y_player, Fpos_x_player, Fx_print, Fy_print;
            public char Fplayer;
            public int[,] Fm_pos;
            public char[] Fmonsters;
            bool open = true;
            public void PlayerMove()
            {
                ConsoleKey Fmove;

                do
                {
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
                                PrintPlayer(Fpos_x_player, Fpos_y_player, Fx_print, Fy_print, 'u');
                                Fplayer = 'u';
                            }
                            break;
                        case ConsoleKey.DownArrow:
                        case ConsoleKey.S:
                            if (Fmap[Fpos_y_player + 1][Fpos_x_player] != '█' && Fmap[Fpos_y_player + 1][Fpos_x_player] != '▒')
                            {
                                Console.SetCursorPosition(Fpos_x_player + Fx_print, Fpos_y_player + Fy_print);
                                Console.Write(' ');
                                Fpos_y_player++;
                                PrintPlayer(Fpos_x_player, Fpos_y_player, Fx_print, Fy_print, 'n');
                                Fplayer = 'n';
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
                                PrintPlayer(Fpos_x_player, Fpos_y_player, Fx_print, Fy_print, '>');
                                Fplayer = '>';
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
                                PrintPlayer(Fpos_x_player, Fpos_y_player, Fx_print, Fy_print, '<');
                                Fplayer = '<';
                            }
                            break;
                    }

                    Thread.Sleep(10);
                } while ((Fpos_x_player != Fm_pos[0, 0] && Fpos_y_player != Fm_pos[0, 1]) || (Fpos_x_player != Fm_pos[1, 0] && Fpos_y_player != Fm_pos[1, 1]) || (Fpos_x_player != Fm_pos[2, 0] && Fpos_y_player != Fm_pos[2, 1]) && Fmove != ConsoleKey.Escape);
            }
            public void EnemiesMove()
            {
                // sleep 100ms
            }
            public void ChangePackMan()
            {
                while (true)
                {
                    Thread.Sleep(200);
                    if (open)
                    {
                        PrintPlayer(Fpos_x_player, Fpos_y_player, Fx_print, Fy_print, 'o');
                        open = false;
                    }
                    else if (Fmap[Fpos_y_player][Fpos_x_player] != '█')
                    {
                        PrintPlayer(Fpos_x_player, Fpos_y_player, Fx_print, Fy_print, Fplayer);
                        open = true;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            const int x_print = 5, y_print = 3;
            int pos_x_player = 18, pos_y_player = 4;

            Console.CursorVisible = false;
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

            char[] monsters = { 'n' , 'n', 'n' };
            int[,] m_pos = { { 0, 0 }, { 0, 0 }, { 0, 0 } };

            Console.Clear();
            Printmenu();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

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

            Thread tPlayerMove = new Thread(new ThreadStart(t.PlayerMove));
            Thread tChange = new Thread(new ThreadStart(t.ChangePackMan));

            tPlayerMove.Start();
            tChange.Start();

            Console.ReadKey();
        }
    }
}
