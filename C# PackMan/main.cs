using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            void Printmenu()
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

            void PrintPlayer(int x, int y, int mapx, int mapy, char p)
            {
                Console.SetCursorPosition(x + mapx, y + mapy);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(p);
            }

            const int x_print = 5, y_print = 3;
            int pos_x_player = 28, pos_y_player = 5;

            Console.CursorVisible = false;
            string[] map = {
                " ██████████████████████████████████████████████████████ ",
                " ██                   ████████████                   ██ ",
                " ██   ████   ██████   ████████████   ██████   ████   ██ ",
                " ██   ████   ██████   ████████████   ██████   ████   ██ ",
                " ██                                                  ██ ",
                " ██                                                  ██ ",
                " ██   ███████                              ███████   ██ ",
                "                      ████    ████                      ",
                " ██                   ██        ██                   ██ ",
                "                      ████████████                      ",
                " ██   ███████                              ███████   ██ ",
                " ██                                                  ██ ",
                " ██   ████   ██████   ████████████   ██████   ████   ██ ",
                " ██   ████   ██████   ████████████   ██████   ████   ██ ",
                " ██                   ████████████                   ██ ",
                " ██████████████████████████████████████████████████████ "
            };

            const char player = 'c';
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

            ConsoleKey move;
            PrintPlayer(pos_x_player, pos_y_player, x_print, y_print, player);

            do
            {
                move = Console.ReadKey(true).Key;

                switch (move)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (map[pos_y_player - 1][pos_x_player] != '█')
                        {
                            Console.SetCursorPosition(pos_x_player + x_print, pos_y_player + y_print);
                            Console.Write(' ');
                            pos_y_player--;
                            PrintPlayer(pos_x_player, pos_y_player, x_print, y_print, player);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (map[pos_y_player + 1][pos_x_player] != '█' && (pos_y_player + 1 != 7 || (pos_x_player != 29 && pos_x_player != 26 && pos_x_player != 27 && pos_x_player != 28)))
                        {
                            Console.SetCursorPosition(pos_x_player + x_print, pos_y_player + y_print);
                            Console.Write(' ');
                            pos_y_player++;
                            PrintPlayer(pos_x_player, pos_y_player, x_print, y_print, player);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (map[pos_y_player][pos_x_player - 1] != '█')
                        {
                            Console.SetCursorPosition(pos_x_player + x_print, pos_y_player + y_print);
                            Console.Write(' ');
                            if (pos_x_player == 1)
                                pos_x_player = map[0].Length - 2;
                            else
                                pos_x_player--;
                            PrintPlayer(pos_x_player, pos_y_player, x_print, y_print, player);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (map[pos_y_player][pos_x_player + 1] != '█')
                        {
                            Console.SetCursorPosition(pos_x_player + x_print, pos_y_player + y_print);
                            Console.Write(' ');
                            if (pos_x_player == map[0].Length - 2)
                                pos_x_player = 1;
                            else
                                pos_x_player++;
                            PrintPlayer(pos_x_player, pos_y_player, x_print, y_print, player);
                        }
                        break;
                }

                Thread.Sleep(10);
            } while ((pos_x_player != m_pos[0, 0] && pos_y_player != m_pos[0, 1]) || (pos_x_player != m_pos[1, 0] && pos_y_player != m_pos[1, 1]) || (pos_x_player != m_pos[2, 0] && pos_y_player != m_pos[2, 1]));

            Console.ReadKey();
        }
    }
}
