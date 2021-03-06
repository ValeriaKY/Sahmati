using System;
using System.Collections.Generic;
using System.Text;

namespace ZMEIKKA
{
    public class Osnova
    {
        public bool end = true;
        private string[,] mass = new string[,]
        {
            { "\u265c ","\u265e ","\u265d ", "\u265b ", "\u265a ", "\u265d ", "\u265e ", "\u265c " },
            { "\u265F ","\u265F ","\u265F ", "\u265F ", "\u265F ", "\u265F ", "\u265F ", "\u265F " },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " },
            { "\u2659 ", "\u2659 ","\u2659 ", "\u2659 ", "\u2659 ", "\u2659 ", "\u2659 ", "\u2659 " },
            { "\u2656 ", "\u2658 ","\u2657 ", "\u2655 ", "\u2654 ", "\u2657 ", "\u2658 ", "\u2656 " }

        };
        ConsoleKeyInfo mKey;
        private int x = 0, y = 0;
        int Z = 0;
        int G = 0;
        Random rand = new Random();
        public Osnova()
        {
            this.BandW();
        }
        private void BandW()
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(mass[i, j]);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(mass[i, j]);
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }
        public void Figura_vibor()
        {
            Console.SetCursorPosition(x, y);
            int i = 0;
            do
            {
                do
                {
                    mKey = Console.ReadKey(true);
                    switch (mKey.Key)
                    {
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x = x - 2;
                                Console.SetCursorPosition(x, y);
                                Z--;
                            }
                            break;
                        case ConsoleKey.S:
                            if (y < 7)
                            {
                                y++;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.D:
                            if (x < 7 * 2)
                            {
                                x = x + 2;
                                Console.SetCursorPosition(x, y);
                                Z++;
                            }
                            break;
                        default:
                            break;
                    }
                } while (mKey.Key != ConsoleKey.Enter);
                if (mass[y, (x - Z)] == "\u2659 ")//Пешка
                {
                    Pehuia_i();
                    i++;
                }
                else if (mass[y, (x - Z)] == "\u2658 ")//конь
                {
                    Kanina_i();
                    i++;
                }
                else if (mass[y, (x - Z)] == "\u2657 ")//Слон
                {
                    Slon_i();
                    i++;
                }
                else if (mass[y, (x - Z)] == "\u2656 ")//Ладья
                {
                    Ladia_i();
                    i++;
                }
                else if (mass[y, (x - Z)] == "\u2655 ")//Королева
                {
                    COVID_19();
                    i++;
                }
                else if (mass[y, (x - Z)] == "\u2654 ")//Король
                {
                    COVID_20();
                    i++;
                }
            } while (i != 1);
        }
        private void Pehuia_i()
        {
            int j = 0;
            
                int add_UD = 0, add_LD = 0, x_p = x - Z, y_p = y; int GG = 0; bool IO = false;
            do
            {
                do
                {
                    mKey = Console.ReadKey(true);
                    switch (mKey.Key)
                    {
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                                add_UD--;
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x = x - 2;
                                Console.SetCursorPosition(x, y);
                                Z--;
                                add_LD = add_LD - 1;
                            }
                            break;
                        case ConsoleKey.S:
                            if (y < 7)
                            {
                                y++;
                                Console.SetCursorPosition(x, y);
                                add_UD++;
                            }
                            break;
                        case ConsoleKey.D:
                            if (x < 7 * 2)
                            {
                                x = x + 2;
                                Console.SetCursorPosition(x, y);
                                Z++;
                                add_LD = add_LD + 1;
                            }
                            break;
                        default:
                            break;
                    }
                } while (mKey.Key != ConsoleKey.Enter);
                if (Proverka_i() == true)
                {

                    try
                    {
                        if (x_p - 1 == x - Z && y_p - 1 == y)
                        {
                            switch (mass[x_p - 1, y_p - 1])
                            {
                                case "\u265a ": IO = true; GG = 1; break;
                                case "\u265b ": IO = true; GG = 1; break;
                                case "\u265c ": IO = true; GG = 1; break;
                                case "\u265d ": IO = true; GG = 1; break;
                                case "\u265e ": IO = true; GG = 1; break;
                                case "\u265f ":; GG = 1; break;
                                default: GG = 2; break;
                            }
                        }
                    }
                    catch { }
                    finally
                    {
                        try
                        {
                            if (x_p + 1 == x - Z && y_p - 1 == y)
                            {
                                switch (mass[x_p + 1, y_p - 1])
                                {
                                    case "\u265a ": IO = true; GG = 1; break;
                                    case "\u265b ": IO = true; GG = 1; break;
                                    case "\u265c ": IO = true; GG = 1; break;
                                    case "\u265d ": IO = true; GG = 1; break;
                                    case "\u265e ": IO = true; GG = 1; break;
                                    case "\u265f ": IO = true; GG = 1; break;
                                    default: GG = 2; break;
                                }
                            }
                        }
                        catch { }
                        finally
                        {
                            if (IO)
                            {
                                j = 1;
                                if ((((x - Z - add_LD) + y - add_UD) % 2) != 0)
                                { Console.BackgroundColor = ConsoleColor.Black; }
                                else
                                { Console.BackgroundColor = ConsoleColor.White; }
                                mass[y - add_UD, x - Z - add_LD] = "  ";
                                Console.SetCursorPosition(x - add_LD * 2, y - add_UD);
                                Console.Write(mass[y - add_UD, x - Z - add_LD]);
                                Console.SetCursorPosition(x, y);
                                mass[y, x - Z] = "\u2659 ";
                                if ((((x - Z) + y) % 2) == 0)
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Write(mass[y, x - Z]);
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.Write(mass[y, x - Z]);
                                }
                            }
                        }
                        if ((x_p == 0 && y_p == 6 || x_p == 1 && y_p == 6 || x_p == 2 && y_p == 6 || x_p == 3 && y_p == 6 || x_p == 4 && y_p == 6 || x_p == 5 && y_p == 6 || x_p == 6 && y_p == 6 || x_p == 7 && y_p == 6) && GG == 0)
                        {
                            j = 1;

                            if ((((x - Z - add_LD) + y - add_UD) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            mass[y - add_UD, x - Z - add_LD] = "  ";
                            Console.SetCursorPosition(x - add_LD * 2, y - add_UD);
                            Console.Write(mass[y - add_UD, x - Z - add_LD]);
                            //y += add_UD;
                            Console.SetCursorPosition(x, y);
                            mass[y, x - Z] = "\u2659 ";
                            if ((((x - Z) + y) % 2) == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(mass[y, x - Z]);
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write(mass[y, x - Z]);
                            }
                        }
                        else if (add_UD == -1 && GG == 0)
                        {
                            j = 1;
                            if ((((x - Z - add_LD) + y - add_UD) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            mass[y - add_UD, x - Z - add_LD] = "  ";
                            Console.SetCursorPosition(x - add_LD * 2, y - add_UD);
                            Console.Write(mass[y - add_UD, x - Z - add_LD]);
                            // y += add_UD;
                            Console.SetCursorPosition(x, y);
                            mass[y, x - Z] = "\u2659 ";
                            if ((((x - Z) + y) % 2) == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(mass[y, x - Z]);
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write(mass[y, x - Z]);
                            }
                        }
                        if (y == 0)
                        {
                            Game_low();
                        }
                    }
                }
            } while (j != 1);
        }
        private void Kanina_i()
        {
            int lineHorse, columHorse, linePos, columPos;//lineHorse-строка columHorse2-столбец
            lineHorse = y;
            columHorse = x;
            int Z_old = Z;
            int j = 0;
            do
            {
                do
                {
                    mKey = Console.ReadKey(true);
                    switch (mKey.Key)
                    {
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x = x - 2;
                                Console.SetCursorPosition(x, y);
                                Z--;
                            }
                            break;
                        case ConsoleKey.S:
                            if (y < 7)
                            {
                                y++;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.D:
                            if (x < 7 * 2)
                            {
                                x = x + 2;
                                Console.SetCursorPosition(x, y);
                                Z++;
                            }
                            break;
                        default:
                            break;
                    }
                } while (mKey.Key != ConsoleKey.Enter);
                linePos = y;
                columPos = x;
                if (Proverka_i() == true)
                {
                    if (((Math.Abs(linePos - lineHorse) == 2) && (Math.Abs((columPos - Z) - (columHorse - Z_old)) == 1)) || ((Math.Abs(linePos - lineHorse) == 1) && (Math.Abs((columPos - Z) - (columHorse - Z_old)) == 2)))
                    {
                        mass[lineHorse, columHorse - Z_old] = "  ";
                        Console.SetCursorPosition(columHorse, lineHorse);
                        if ((((columHorse - Z_old) + lineHorse) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[lineHorse, columHorse - Z_old]);

                        mass[linePos, columPos - Z] = "\u2658 ";
                        Console.SetCursorPosition(columPos, linePos);
                        if ((((columPos - Z) + linePos) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[linePos, columPos - Z]);
                        j = 1;
                    }

                }
            } while (j != 1);
        }
        private void Slon_i()
        {
            int lineelEphant, columelEphant, linePos, columPos;//lineelEphant-строка columelEphant2-столбец

            lineelEphant = y;
            columelEphant = x;
            int Z_old = Z;
            int j = 0;
            do
            {
                do
                {
                    mKey = Console.ReadKey(true);
                    switch (mKey.Key)
                    {
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x = x - 2;
                                Console.SetCursorPosition(x, y);
                                Z--;
                            }
                            break;
                        case ConsoleKey.S:
                            if (y < 7)
                            {
                                y++;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.D:
                            if (x < 7 * 2)
                            {
                                x = x + 2;
                                Console.SetCursorPosition(x, y);
                                Z++;
                            }
                            break;
                        default:
                            break;
                    }
                } while (mKey.Key != ConsoleKey.Enter);
                linePos = y;
                columPos = x;
                if (Proverka_i() == true)
                {
                    if (Math.Abs(lineelEphant - linePos) == Math.Abs((columelEphant - Z_old) - (columPos - Z)))
                    {
                        if (Slon(Old_y: lineelEphant, Old_x: columelEphant, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z))//Поменять местави х и у
                        {
                            mass[lineelEphant, columelEphant - Z_old] = "  ";
                            Console.SetCursorPosition(columelEphant, lineelEphant);
                            if ((((columelEphant - Z_old) + lineelEphant) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[lineelEphant, columelEphant - Z_old]);

                            mass[linePos, columPos - Z] = "\u2657 ";
                            Console.SetCursorPosition(columPos, linePos);
                            if ((((columPos - Z) + linePos) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[linePos, columPos - Z]);
                            j=1;
                        }
                    }
                }
            } while (j!=1);
        }
        private void Ladia_i()
        {
            int lineRook, columRook, linePos, columPos;//lineRook-строка columRook2-столбец
            lineRook = y;
            columRook = x;
            int Z_old = Z;
            int j = 0;
            do
            {
                do
                {
                    mKey = Console.ReadKey(true);
                    switch (mKey.Key)
                    {
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x = x - 2;
                                Console.SetCursorPosition(x, y);
                                Z--;
                            }
                            break;
                        case ConsoleKey.S:
                            if (y < 7)
                            {
                                y++;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.D:
                            if (x < 7 * 2)
                            {
                                x = x + 2;
                                Console.SetCursorPosition(x, y);
                                Z++;
                            }
                            break;
                        default:
                            break;
                    }
                } while (mKey.Key != ConsoleKey.Enter);
                linePos = y;
                columPos = x;
                if (Proverka_i() == true)
                {
                    if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z) == 0))
                    {
                        if (Ladia(Old_y: lineRook, Old_x: columRook, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z))//Поменять местави х и у
                        {
                            mass[lineRook, columRook - Z_old] = "  ";
                            Console.SetCursorPosition(columRook, lineRook);
                            if ((((columRook - Z_old) + lineRook) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[lineRook, columRook - Z_old]);

                            mass[linePos, columPos - Z] = "\u2656 ";
                            Console.SetCursorPosition(columPos, linePos);
                            if ((((columPos - Z) + linePos) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[linePos, columPos - Z]);
                            j = 1;
                        }
                    }
                }
            } while (j != 1);
        }
        private void COVID_19()
        {
            int lineQueen, columQueen, linePos, columPos;//lineQueen-строка columQueen2-столбец
            lineQueen = y;
            columQueen = x;
            int Z_old = Z;
            int j = 0;
            do
            {
                do
                {
                    mKey = Console.ReadKey(true);
                    switch (mKey.Key)
                    {
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x = x - 2;
                                Console.SetCursorPosition(x, y);
                                Z--;
                            }
                            break;
                        case ConsoleKey.S:
                            if (y < 7)
                            {
                                y++;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.D:
                            if (x < 7 * 2)
                            {
                                x = x + 2;
                                Console.SetCursorPosition(x, y);
                                Z++;
                            }
                            break;
                        default:
                            break;
                    }
                } while (mKey.Key != ConsoleKey.Enter);
                linePos = y;
                columPos = x;
                if (Proverka_i() == true)
                {
                    if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z))
                    {
                        if (Slon(Old_y: lineQueen, Old_x: columQueen, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z) && Ladia(Old_y: lineQueen, Old_x: columQueen, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z))//Поменять местави х и у
                        {
                            mass[lineQueen, columQueen - Z_old] = "  ";
                            Console.SetCursorPosition(columQueen, lineQueen);
                            if ((((columQueen - Z_old) + lineQueen) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[lineQueen, columQueen - Z_old]);

                            mass[linePos, columPos - Z] = "\u2655 ";
                            Console.SetCursorPosition(columPos, linePos);
                            if ((((columPos - Z) + linePos) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[linePos, columPos - Z]);
                            j = 1;
                        }
                    }
                }
            } while (j!=1);
        }
        private void COVID_20()
        {
            int line, colum;
            int lineKing, columKing, linePos, columPos;//lineKing-строка columKing-столбец
            lineKing = y;
            columKing = x;
            int Z_old = Z;
            int j = 0;
            do
            {
                do
                {
                    mKey = Console.ReadKey(true);
                    switch (mKey.Key)
                    {
                        case ConsoleKey.W:
                            if (y > 0)
                            {
                                y--;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.A:
                            if (x > 0)
                            {
                                x = x - 2;
                                Console.SetCursorPosition(x, y);
                                Z--;
                            }
                            break;
                        case ConsoleKey.S:
                            if (y < 7)
                            {
                                y++;
                                Console.SetCursorPosition(x, y);
                            }
                            break;
                        case ConsoleKey.D:
                            if (x < 7 * 2)
                            {
                                x = x + 2;
                                Console.SetCursorPosition(x, y);
                                Z++;
                            }
                            break;
                        default:
                            break;
                    }
                } while (mKey.Key != ConsoleKey.Enter);
                linePos = y;
                columPos = x;
                if (Proverka_i() == true && Proverka_AI_COVID_20() == true)
                {
                    linePos = y;
                    columPos = x;
                    line = linePos - lineKing;
                    colum = columPos - columKing;
                    if (((Math.Abs(line) == 1) && (Math.Abs(colum) == 0)) || ((Math.Abs(line) == 1) && (Math.Abs(colum) == 1)) || ((Math.Abs(line) == 0) && (Math.Abs(colum) == 1)))
                    {
                        mass[lineKing, columKing - Z_old] = "  ";
                        Console.SetCursorPosition(columKing, lineKing);
                        if ((((columKing - Z_old) + lineKing) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[lineKing, columKing - Z_old]);

                        mass[linePos, columPos - Z] = "\u2654 ";
                        Console.SetCursorPosition(columPos, linePos);
                        if ((((columPos - Z) + linePos) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[linePos, columPos - Z]);
                        j = 1;
                    }
                }
            } while (j != 1);
        }
        private bool Proverka_AI_COVID_20()
        {
            bool Vilat = false;
            if (mass[y, (x - Z)] != "\u265a " && mass[y, (x - Z)] != "\u265b " && mass[y, (x - Z)] != "\u265c " && mass[y, (x - Z)] != "\u265d " && mass[y, (x - Z)] != "\u265e " && mass[y, (x - Z)] != "\u265F ")
            {
                Vilat = true;
            }
            return Vilat;
        }
        private bool Proverka_i()
        {
            bool Virsuta = false;
            if (mass[y, (x - Z)] != "\u2659 " && mass[y, (x - Z)] != "\u2658 " && mass[y, (x - Z)] != "\u2657 " && mass[y, (x - Z)] != "\u2656 " && mass[y, (x - Z)] != "\u2655 " && mass[y, (x - Z)] != "\u2654 ")
            {
                Virsuta = true;
            }
            return Virsuta;
        }
        public void AI_Figura_vibor()
        {
            int i = 0;
            do
            {
                G = 0;
                int AI_x = rand.Next(0, 8);
                int AI_y = rand.Next(0, 8);
                int AI_reserve = AI_x;
                if (mass[AI_y, AI_x] == "\u265F ")//Пешка
                {
                    AI_x = AI_x * 2;
                    Pehuia_AI(AI_x, AI_y, AI_reserve);
                    if (G == 0)
                        i++;
                    else
                        i = 0;
                }
                else if (mass[AI_y, AI_x] == "\u265e ")//конь
                {
                    AI_x = AI_x * 2;
                    Kanina_AI(AI_x, AI_y, AI_reserve);
                    if (G == 0)
                        i++;
                    else
                        i = 0;
                }
                else if (mass[AI_y, AI_x] == "\u265d ")//Слон
                {
                    AI_x = AI_x * 2;
                    Slon_AI(AI_x, AI_y, AI_reserve);
                    if (G == 0)
                        i++;
                    else
                        i = 0;
                }
                else if (mass[AI_y, AI_x] == "\u265c ")//Ладья
                {
                    AI_x = AI_x * 2;
                    Ladia_AI(AI_x, AI_y, AI_reserve);
                    if (G == 0)
                        i++;
                    else
                        i = 0;
                }
                else if (mass[AI_y, AI_x] == "\u265b ")//Королева
                {
                    AI_x = AI_x * 2;
                    COVID_19_AI(AI_x, AI_y, AI_reserve);
                    if (G == 0)
                        i++;
                    else
                        i = 0;
                }
                else if (mass[AI_y, AI_x] == "\u265a ")//Король
                {
                    AI_x = AI_x * 2;
                    COVID_20_AI(AI_x, AI_y, AI_reserve);
                    if (G == 0)
                        i++;
                    else
                        i = 0;
                }
            }
            while (i != 1);
        }
        private void Pehuia_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int add_UD = 0, add_LD = 0; int GG = 0;
            try
            {
                switch (mass[AI_y + 1, (AI_x - AI_reserve) + 1])
                {
                    case "\u2655 ": add_LD = 2; add_UD = 1; GG = 1; break;
                    case "\u2654 ": add_LD = 2; add_UD = 1; GG = 1; break;
                    case "\u2657 ": add_LD = 2; add_UD = 1; GG = 1; break;
                    case "\u2658 ": add_LD = 2; add_UD = 1; GG = 1; break;
                    case "\u2656 ": add_LD = 2; add_UD = 1; GG = 1; break;
                    case "\u2659 ": add_LD = 2; add_UD = 1; GG = 1; break;
                    default: GG = 0; break;
                }
            }
            catch { }
            finally
            {
                try
                {
                    switch (mass[AI_y + 1, AI_x - 1 - AI_reserve])
                    {
                        case "\u2655 ": add_LD = -2; add_UD = 1; GG = 1; break;
                        case "\u2654 ": add_LD = -2; add_UD = 1; GG = 1; break;
                        case "\u2657 ": add_LD = -2; add_UD = 1; GG = 1; break;
                        case "\u2658 ": add_LD = -2; add_UD = 1; GG = 1; break;
                        case "\u2656 ": add_LD = -2; add_UD = 1; GG = 1; break;
                        case "\u2659 ": add_LD = -2; add_UD = 1; GG = 1; break;
                        default: GG = 0; break;
                    }
                }
                catch { }
                finally
                {
                    if (GG == 0)
                    {
                        if (AI_x == 0 && AI_y == 1 || AI_x == 2 && AI_y == 1 || AI_x == 4 && AI_y == 1 || AI_x == 6 && AI_y == 1 || AI_x == 8 && AI_y == 1 || AI_x == 10 && AI_y == 1 || AI_x == 12 && AI_y == 1 || AI_x == 14 && AI_y == 1)
                        {
                            add_LD = 0;
                            add_UD = rand.Next(1, 3);GG = 2;
                        }
                        else
                        {
                            add_LD = 0;
                            add_UD = 1;GG = 2;
                        }
                    }
                }
                AI_x = AI_x + add_LD;
                AI_y = AI_y + add_UD;
                AI_reserve = AI_reserve + (add_LD / 2);
                if (Proverka_AI(AI_x, AI_y, AI_reserve) == true)
                {
                    if ((((AI_reserve - (add_LD / 2)) + AI_y-add_UD) % 2) != 0)
                    { Console.BackgroundColor = ConsoleColor.Black; }
                    else
                    { Console.BackgroundColor = ConsoleColor.White; }
                    mass[AI_y-add_UD, AI_reserve- (add_LD / 2)] = "  ";
                    Console.SetCursorPosition(AI_x-add_LD, AI_y-add_UD);
                    Console.Write(mass[AI_y-add_UD, AI_reserve- (add_LD / 2)]);
                    Console.SetCursorPosition(AI_x, AI_y);
                    mass[AI_y, AI_reserve] = "\u265F ";
                    if (((AI_reserve + AI_y) % 2) == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(mass[AI_y, AI_reserve]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(mass[AI_y, AI_reserve]);
                    }
                }
            }
            if(AI_y == 7)
            {
                Game_low(X:AI_x,Y:AI_y,z:AI_reserve);
            }
        }
        private void Kanina_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int lineHorse, columHorse, linePos, columPos;//lineHorse-строка columHorse2-столбец
            lineHorse = AI_y;
            columHorse = AI_x;
            int Z_old = AI_reserve;
            int i = 0;
            int Z_New;
            int next_day = 0;
            G = 0;
            do
            {
                AI_x = rand.Next(0, 8);
                AI_y = rand.Next(0, 8);
                AI_reserve = AI_x;
                AI_x = AI_x * 2;
                linePos = AI_y;
                columPos = AI_x;
                Z_New = AI_reserve;
                if (Proverka_AI(AI_x, AI_y, AI_reserve) == true)
                {
                    if (((Math.Abs(linePos - lineHorse) == 2) && (Math.Abs((columPos - Z_New) - (columHorse - Z_old)) == 1)) || ((Math.Abs(linePos - lineHorse) == 1) && (Math.Abs((columPos - Z_New) - (columHorse - Z_old)) == 2)))
                    {
                        mass[lineHorse, columHorse - Z_old] = "  ";
                        Console.SetCursorPosition(columHorse, lineHorse);
                        if ((((columHorse - Z_old) + lineHorse) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[lineHorse, columHorse - Z_old]);

                        mass[linePos, columPos - Z_New] = "\u265e ";
                        Console.SetCursorPosition(columPos, linePos);
                        if ((((columPos - Z_New) + linePos) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[linePos, columPos - Z_New]);
                        i++;
                    }
                }
                next_day++;
                if (next_day > 5)
                {
                    i = 1; G = 2;
                }
            } while (i == 0);


        }
        private void Slon_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int lineelEphant, columelEphant, linePos, columPos;//lineelEphant-строка columelEphant2-столбец
            lineelEphant = AI_y;
            columelEphant = AI_x;
            int Z_old = AI_reserve;
            int i = 0;
            int Z_New;
            G = 0;
            int next_day = 0;
            do
            {
                AI_x = rand.Next(0, 8);
                AI_y = rand.Next(0, 8);
                AI_reserve = AI_x;
                AI_x = AI_x * 2;
                linePos = AI_y;
                columPos = AI_x;
                Z_New = AI_reserve;
                if (Proverka_AI(AI_x, AI_y, AI_reserve) == true)
                {
                    if (Math.Abs(lineelEphant - linePos) == Math.Abs((columelEphant - Z_old) - (columPos - Z_New)))
                    {
                        if (Slon(Old_y: lineelEphant, Old_x: columelEphant, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z_New))//Поменять местави х и у
                        {
                            mass[lineelEphant, columelEphant - Z_old] = "  ";
                            Console.SetCursorPosition(columelEphant, lineelEphant);
                            if ((((columelEphant - Z_old) + lineelEphant) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[lineelEphant, columelEphant - Z_old]);

                            mass[linePos, columPos - Z_New] = "\u265d ";
                            Console.SetCursorPosition(columPos, linePos);
                            if ((((columPos - Z_New) + linePos) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[linePos, columPos - Z_New]);
                            i++;
                        }
                    }
                }
                next_day++;
                if (next_day > 5)
                {
                    i = 1; G = 2;
                }
            } while (i == 0);
        }
        private void Ladia_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int lineRook, columRook, linePos, columPos;//lineRook-строка columRook2-столбец
            lineRook = AI_y;
            columRook = AI_x;
            int Z_old = AI_reserve;
            int i = 0;
            int Z_New;
            int next_day = 0;
            G = 0;
            do
            {
                do
                {
                    AI_x = rand.Next(0, 8);
                    AI_y = rand.Next(0, 8);
                    AI_reserve = AI_x;
                    AI_x = AI_x * 2;
                    linePos = AI_y;
                    columPos = AI_x;
                    Z_New = AI_reserve;
                } while (lineRook - linePos == 0 && columRook - columPos == 0);
                if (Proverka_AI(AI_x, AI_y, AI_reserve) == true)
                {
                    if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z) == 0))
                    {
                        if (Ladia(Old_y: lineRook, Old_x: columRook, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z_New))//Поменять местави х и у
                        {
                            mass[lineRook, columRook - Z_old] = "  ";
                            Console.SetCursorPosition(columRook, lineRook);
                            if ((((columRook - Z_old) + lineRook) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[lineRook, columRook - Z_old]);

                            mass[linePos, columPos - Z_New] = "\u265c ";
                            Console.SetCursorPosition(columPos, linePos);
                            if ((((columPos - Z_New) + linePos) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[linePos, columPos - Z_New]);
                            i++;
                        }
                    }
                }
                next_day++;
                if (next_day > 5)
                {
                  i = 1; G = 2;
                }
            } while (i == 0);
        }
        private void COVID_19_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int lineQueen, columQueen, linePos, columPos;//lineQueen-строка columQueen2-столбец
            lineQueen = AI_y;
            columQueen = AI_x;
            int Z_old = AI_reserve;
            int i = 0;
            int Z_New;
            int next_day = 0;
            G = 0;
            do
            {
                AI_x = rand.Next(0, 8);
                AI_y = rand.Next(0, 8);
                AI_reserve = AI_x;
                AI_x = AI_x * 2;
                linePos = AI_y;
                columPos = AI_x;
                Z_New = AI_reserve;
                if (Proverka_AI(AI_x, AI_y, AI_reserve) == true)
                {
                    if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z_New))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z_New))
                    {
                        if (Slon(Old_y: lineQueen, Old_x: columQueen, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z_New) && Ladia(Old_y: lineQueen, Old_x: columQueen, Old_Z: Z_old, New_x: columPos, New_y: linePos, New_Z: Z_New))//Поменять местави х и у
                        {
                            mass[lineQueen, columQueen - Z_old] = "  ";
                            Console.SetCursorPosition(columQueen, lineQueen);
                            if ((((columQueen - Z_old) + lineQueen) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[lineQueen, columQueen - Z_old]);

                            mass[linePos, columPos - Z_New] = "\u265b ";
                            Console.SetCursorPosition(columPos, linePos);
                            if ((((columPos - Z_New) + linePos) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            Console.Write(mass[linePos, columPos - Z_New]);
                            i++;
                        }
                    }
                }
                next_day++;
                if (next_day > 5)
                {
                    i = 1; G = 2;
                }
            } while (i != 1);
        }
        private void COVID_20_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int line, colum;
            int lineKing, columKing, linePos, columPos;//lineKing-строка columKing-столбец
            lineKing = AI_y;
            columKing = AI_x;
            int Z_old = AI_reserve;
            int i = 0;
            int Z_New;
            int next_day = 0;
            G = 0;
            do
            {
                AI_x = rand.Next(0, 8);
                AI_y = rand.Next(0, 8);
                AI_reserve = AI_x;
                AI_x = AI_x * 2;
                linePos = AI_y;
                columPos = AI_x;
                Z_New = AI_reserve;
                if (Proverka_AI(AI_x, AI_y, AI_reserve) == true && Proverka_COVID_20(AI_x, AI_y, AI_reserve))
                {
                    line = linePos - lineKing;
                    colum = columPos - columKing;
                    if (((Math.Abs(line) == 1) && (Math.Abs(colum) == 0)) || ((Math.Abs(line) == 1) && (Math.Abs(colum) == 1)) || ((Math.Abs(line) == 0) && (Math.Abs(colum) == 1)))
                    {
                        mass[lineKing, columKing - Z_old] = "  ";
                        Console.SetCursorPosition(columKing, lineKing);
                        if ((((columKing - Z_old) + lineKing) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[lineKing, columKing - Z_old]);

                        mass[linePos, columPos - Z_New] = "\u265a ";
                        Console.SetCursorPosition(columPos, linePos);
                        if ((((columPos - Z_New) + linePos) % 2) != 0)
                        { Console.BackgroundColor = ConsoleColor.Black; }
                        else
                        { Console.BackgroundColor = ConsoleColor.White; }
                        Console.Write(mass[linePos, columPos - Z_New]);
                        i++;
                    }
                }
                next_day++;
                if (next_day > 5)
                {
                    i = 2; G = 2;
                }
            } while (i == 0);
        }
        private bool Proverka_AI(int AI_x, int AI_y, int AI_Z)
        {
            bool Vilat = false;
            if (mass[AI_y, (AI_x - AI_Z)] != "\u265a " && mass[AI_y, (AI_x - AI_Z)] != "\u265b " && mass[AI_y, (AI_x - AI_Z)] != "\u265c " && mass[AI_y, (AI_x - AI_Z)] != "\u265d " && mass[AI_y, (AI_x - AI_Z)] != "\u265e " && mass[AI_y, (AI_x - AI_Z)] != "\u265F ")
            {
                Vilat = true;
            }
            return Vilat;
        }
        private bool Proverka_COVID_20(int AI_x, int AI_y, int AI_Z)
        {
            bool Virsuta = false;
            if (mass[AI_y, (AI_x - AI_Z)] != "\u2659 " && mass[AI_y, (AI_x - AI_Z)] != "\u2658 " && mass[AI_y, (AI_x - AI_Z)] != "\u2657 " && mass[AI_y, (AI_x - AI_Z)] != "\u2656 " && mass[AI_y, (AI_x - AI_Z)] != "\u2655 " && mass[AI_y, (AI_x - AI_Z)] != "\u2654 ")
            {
                Virsuta = true;
            }
            return Virsuta;
        }
        public void Ender_mir()
        {
            int X = 0, Y = 0, Z_OLD = 0;
            for (int i = 0; i < 8; i++)
            {
                int beck = 0;
                for (int f = 0; f < 8; f++)
                {
                    if (mass[i, f] == "\u2654 ")
                    {
                        X = i;
                        Y = f;
                        beck = 1;
                        break;
                    }
                }
                if (beck == 1)
                {
                    break;
                }
            }
            Z_OLD = X;
            X = X * 2;
            if (Vacsina(X, Y, Z_OLD) == true)
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Конец игры вы проиграли");
                end = false;
            }
            for (int i = 0; i < 8; i++)
            {
                int beck = 0;
                for (int f = 0; f < 8; f++)
                {
                    if (mass[i, f] == "\u265a ")
                    {
                        X = i;
                        Y = f;
                        beck = 1;
                        break;
                    }
                }
                if (beck == 1)
                {
                    break;
                }
            }
            Z_OLD = X;
            X = X * 2;
            if (Vacsina(X, Y, Z_OLD) == true)
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Конец игры вы победили");
                end = false;
            }
        }
        private bool Vacsina(int AI_x, int AI_y, int AI_reserve)
        {
            bool Game = false;
            if (Game == false)
            {
                if (mass[AI_x - AI_reserve, AI_y] == "\u265a ")
                {
                    var block_1 = true;
                    var block_2 = true;
                    var block_3 = true;
                    var block_4 = true;
                    var block_5 = true;
                    var block_6 = true;
                    var block_7 = true;
                    var block_8 = true;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int g = 0; g < 8; g++)
                        {
                            switch (mass[i, g])
                            {
                                case "\u2659 ":
                                    for (int p = 0; p < 8; p++)
                                    {
                                        int long_x = i, long_y = g, long_z = 0;
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            long_y = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            long_x = AI_x;
                                            long_z = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            long_y = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            long_x = AI_x + 2;
                                            long_z = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            long_y = AI_y;
                                            //AI_x = (AI_x + 1) * 2;
                                            long_x = AI_x + 2;
                                            long_z = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            long_y = AI_y + 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            long_x = AI_x + 2;
                                            long_z = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            long_y = AI_y + 1;
                                            // AI_x = AI_x * 2;
                                            long_x = AI_x;
                                            long_z = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            // AI_reserve = AI_x - 1;
                                            long_y = AI_y + 1;
                                            // AI_x = (AI_x - 1) * 2;
                                            long_x = AI_x - 2;
                                            long_z = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            // AI_reserve = AI_x - 1;
                                            long_y = AI_y;
                                            // AI_x = (AI_x - 1) * 2;
                                            long_x = AI_x - 2;
                                            long_z = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            // AI_reserve = AI_x - 1;
                                            long_y = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            long_x = AI_x - 2;
                                            long_z = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            long_y = 0;
                                            long_x = 0;
                                            long_z = 0;
                                        }
                                        try
                                        {
                                            if (mass[long_x - long_z, long_y] == "\u2659 " || mass[long_x - long_z, long_y] == "\u2659 ")
                                            {
                                                if (p == 0)
                                                {
                                                    block_1 = false;
                                                }
                                                else if (p == 1)
                                                {
                                                    block_2 = false;
                                                }
                                                else if (p == 2)
                                                {
                                                    block_3 = false;
                                                }
                                                else if (p == 3)
                                                {
                                                    block_4 = false;
                                                }
                                                else if (p == 4)
                                                {
                                                    block_5 = false;
                                                }
                                                else if (p == 5)
                                                {
                                                    block_6 = false;
                                                }
                                                else if (p == 6)
                                                {
                                                    block_7 = false;
                                                }
                                                else if (p == 7)
                                                {
                                                    block_8 = false;
                                                }
                                            }
                                        }
                                        catch { }
                                    };
                                    break;//Пешка
                                case "\u2658 ":
                                    int lineHorse, columHorse, linePos, columPos;//lineHorse-строка columHorse2-столбец
                                    lineHorse = g;//y
                                    int Z_old = i;
                                    columHorse = i * 2;//x
                                    int Z_New;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }

                                        if (((Math.Abs(linePos - lineHorse) == 2) && (Math.Abs((columPos - Z_New) - (columHorse - Z_old)) == 1)) || ((Math.Abs(linePos - lineHorse) == 1) && (Math.Abs((columPos - Z_New) - (columHorse - Z_old)) == 2)))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    };
                                    break;//конь
                                case "\u2657 ":
                                    int lineelEphant, columelEphant;//lineHorse-строка columHorse2-столбец
                                    lineHorse = g;//y
                                    columHorse = i * 2;//x
                                    lineelEphant = g;
                                    columelEphant = i;
                                    Z_old = i;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if (Math.Abs(lineelEphant - linePos) == Math.Abs((columelEphant - Z_old) - (columPos - Z_New)))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    };
                                    break;//Слон
                                case "\u2656 ":
                                    int lineRook, columRook;//lineHorse-строка columHorse2-столбец
                                    lineRook = g;//y
                                    columRook = i * 2;//x
                                    Z_old = i;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z_New) == 0))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    }; break;//Ладья
                                case "\u2655 ":
                                    int lineQueen, columQueen;//lineHorse-строка columHorse2-столбец
                                    lineQueen = g;//y
                                    columQueen = i * 2;//x
                                    Z_old = i;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z_New))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z_New))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    }; break;//Королева
                            }
                        }
                    }
                    for (int p = 0; p < 8; p++)
                    {
                        int long_x = 0, long_y = 0, long_z = 0;
                        if (p == 0 && block_1 == true)
                        {
                            //AI_reserve = AI_x;
                            long_y = AI_y - 1;
                            //AI_x = AI_x * 2;
                            long_x = AI_x;
                            long_z = AI_reserve;
                        }
                        else if (p == 1 && block_2 == true)
                        {
                            //AI_reserve = AI_x + 1;
                            long_y = AI_y - 1;
                            //AI_x = (AI_x + 1) * 2;
                            long_x = AI_x + 2;
                            long_z = AI_reserve + 1;
                        }
                        else if (p == 2 && block_3 == true)
                        {
                            //AI_reserve = AI_x + 1;
                            long_y = AI_y;
                            //AI_x = (AI_x + 1) * 2;
                            long_x = AI_x + 2;
                            long_z = AI_reserve + 1;
                        }
                        else if (p == 3 && block_4 == true)
                        {
                            //AI_reserve = AI_x + 1;
                            long_y = AI_y + 1;
                            //AI_x = (AI_x + 1) * 2;
                            long_x = AI_x + 2;
                            long_z = AI_reserve + 1;
                        }
                        else if (p == 4 && block_5 == true)
                        {
                            //AI_reserve = AI_x;
                            long_y = AI_y + 1;
                            // AI_x = AI_x * 2;
                            long_x = AI_x;
                            long_z = AI_reserve;
                        }
                        else if (p == 5 && block_6 == true)
                        {
                            // AI_reserve = AI_x - 1;
                            long_y = AI_y + 1;
                            // AI_x = (AI_x - 1) * 2;
                            long_x = AI_x - 2;
                            long_z = AI_reserve - 1;
                        }
                        else if (p == 6 && block_7 == true)
                        {
                            // AI_reserve = AI_x - 1;
                            long_y = AI_y;
                            // AI_x = (AI_x - 1) * 2;
                            long_x = AI_x - 2;
                            long_z = AI_reserve - 1;
                        }
                        else if (p == 7 && block_8 == true)
                        {
                            // AI_reserve = AI_x - 1;
                            long_y = AI_y - 1;
                            //AI_x = (AI_x - 1) * 2;
                            long_x = AI_x - 2;
                            long_z = AI_reserve - 1;
                        }
                        else
                        {
                            long_y = AI_y;
                            long_x = AI_x;
                            long_z = AI_reserve;
                        }
                        try { if (mass[long_y,long_x - long_z]  == "  ") { } }
                        catch {
                            if (p == 0)
                            {
                                block_1 = false;
                            }
                            else if (p == 1)
                            {
                                block_2 = false;
                            }
                            else if (p == 2)
                            {
                                block_3 = false;
                            }
                            else if (p == 3)
                            {
                                block_4 = false;
                            }
                            else if (p == 4)
                            {
                                block_5 = false;
                            }
                            else if (p == 5)
                            {
                                block_6 = false;
                            }
                            else if (p == 6)
                            {
                                block_7 = false;
                            }
                            else if (p == 7)
                            {
                                block_8 = false;
                            }
                        }
                        finally { }
                    }
                    if(block_1 == false && block_2 == false && block_3 == false && block_4 == false && block_5 == false && block_6 == false && block_7 == false && block_8 == false) { Game = true; }
                }
                else if (mass[AI_x - AI_reserve, AI_y] == "\u2654 ")
                {
                    var block_1 = true;
                    var block_2 = true;
                    var block_3 = true;
                    var block_4 = true;
                    var block_5 = true;
                    var block_6 = true;
                    var block_7 = true;
                    var block_8 = true;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int g = 0; g < 8; g++)
                        {
                            switch (mass[i, g])
                            {
                                case "\u265F ":
                                    for (int p = 0; p < 8; p++)
                                    {
                                        int long_x = i, long_y = g, long_z = 0;
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            long_y = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            long_x = AI_x;
                                            long_z = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            long_y = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            long_x = AI_x + 2;
                                            long_z = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            long_y = AI_y;
                                            //AI_x = (AI_x + 1) * 2;
                                            long_x = AI_x + 2;
                                            long_z = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            long_y = AI_y + 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            long_x = AI_x + 2;
                                            long_z = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            long_y = AI_y + 1;
                                            // AI_x = AI_x * 2;
                                            long_x = AI_x;
                                            long_z = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            // AI_reserve = AI_x - 1;
                                            long_y = AI_y + 1;
                                            // AI_x = (AI_x - 1) * 2;
                                            long_x = AI_x - 2;
                                            long_z = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            // AI_reserve = AI_x - 1;
                                            long_y = AI_y;
                                            // AI_x = (AI_x - 1) * 2;
                                            long_x = AI_x - 2;
                                            long_z = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            // AI_reserve = AI_x - 1;
                                            long_y = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            long_x = AI_x - 2;
                                            long_z = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            long_y = 0;
                                            long_x = 0;
                                            long_z = 0;
                                        }
                                        try
                                        {
                                            if (mass[(long_x - long_z), long_y] == "\u265F " || mass[(long_x - long_z), long_y] == "\u265F ")
                                            {
                                                if (p == 0)
                                                {
                                                    block_1 = false;
                                                }
                                                else if (p == 1)
                                                {
                                                    block_2 = false;
                                                }
                                                else if (p == 2)
                                                {
                                                    block_3 = false;
                                                }
                                                else if (p == 3)
                                                {
                                                    block_4 = false;
                                                }
                                                else if (p == 4)
                                                {
                                                    block_5 = false;
                                                }
                                                else if (p == 5)
                                                {
                                                    block_6 = false;
                                                }
                                                else if (p == 6)
                                                {
                                                    block_7 = false;
                                                }
                                                else if (p == 7)
                                                {
                                                    block_8 = false;
                                                }
                                            }
                                        }
                                        catch { };
                                    }; ; break;//Пешка
                                case "\u265b ":
                                    int lineQueen, columQueen, linePos, columPos, Z_old, Z_New;//lineHorse-строка columHorse2-столбец
                                    lineQueen = g;//y
                                    columQueen = i * 2;//x
                                    Z_old = i;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z_New))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z_New))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    }; ; break;//Королева
                                case "\u265c ":
                                    int lineRook, columRook;//lineHorse-строка columHorse2-столбец
                                    lineRook = g;//y
                                    columRook = i * 2;//x
                                    Z_old = i;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z_New) == 0))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    }
                                   ; break;//Ладья
                                case "\u265d ":
                                    int lineelEphant, columelEphant;//lineHorse-строка columHorse2-столбец
                                    lineelEphant = g;
                                    columelEphant = i;
                                    Z_old = i;
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if (Math.Abs(lineelEphant - linePos) == Math.Abs((columelEphant - Z_old) - (columPos - Z_New)))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    }; break;//Слон
                                case "\u265e ":
                                    int lineHorse, columHorse; //lineHorse-строка columHorse2-столбец
                                    lineHorse = g;//y
                                    Z_old = i;
                                    columHorse = i * 2;//x
                                    for (int p = 0; p < 8; p++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            //AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            // AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            // AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x + 2;
                                            Z_New = AI_reserve + 1;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            //AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            //AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            //AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            //AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x - 2;
                                            Z_New = AI_reserve - 1;
                                        }
                                        else
                                        {
                                            linePos = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }

                                        if (((Math.Abs(linePos - lineHorse) == 2) && (Math.Abs((columPos - Z_New) - (columHorse - Z_old)) == 1)) || ((Math.Abs(linePos - lineHorse) == 1) && (Math.Abs((columPos - Z_New) - (columHorse - Z_old)) == 2)))
                                        {
                                            if (p == 0)
                                            {
                                                block_1 = false;
                                            }
                                            else if (p == 1)
                                            {
                                                block_2 = false;
                                            }
                                            else if (p == 2)
                                            {
                                                block_3 = false;
                                            }
                                            else if (p == 3)
                                            {
                                                block_4 = false;
                                            }
                                            else if (p == 4)
                                            {
                                                block_5 = false;
                                            }
                                            else if (p == 5)
                                            {
                                                block_6 = false;
                                            }
                                            else if (p == 6)
                                            {
                                                block_7 = false;
                                            }
                                            else if (p == 7)
                                            {
                                                block_8 = false;
                                            }

                                        }
                                    }; break;//конь
                            }
                        }
                    }
                    for (int p = 0; p < 8; p++)
                    {
                        int long_x = 0, long_y = 0, long_z = 0;
                        if (p == 0 && block_1 == true)
                        {
                            //AI_reserve = AI_x;
                            long_y = AI_y - 1;
                            //AI_x = AI_x * 2;
                            long_x = AI_x;
                            long_z = AI_reserve;
                        }
                        else if (p == 1 && block_2 == true)
                        {
                            //AI_reserve = AI_x + 1;
                            long_y = AI_y - 1;
                            //AI_x = (AI_x + 1) * 2;
                            long_x = AI_x + 2;
                            long_z = AI_reserve + 1;
                        }
                        else if (p == 2 && block_3 == true)
                        {
                            //AI_reserve = AI_x + 1;
                            long_y = AI_y;
                            //AI_x = (AI_x + 1) * 2;
                            long_x = AI_x + 2;
                            long_z = AI_reserve + 1;
                        }
                        else if (p == 3 && block_4 == true)
                        {
                            //AI_reserve = AI_x + 1;
                            long_y = AI_y + 1;
                            //AI_x = (AI_x + 1) * 2;
                            long_x = AI_x + 2;
                            long_z = AI_reserve + 1;
                        }
                        else if (p == 4 && block_5 == true)
                        {
                            //AI_reserve = AI_x;
                            long_y = AI_y + 1;
                            // AI_x = AI_x * 2;
                            long_x = AI_x;
                            long_z = AI_reserve;
                        }
                        else if (p == 5 && block_6 == true)
                        {
                            // AI_reserve = AI_x - 1;
                            long_y = AI_y + 1;
                            // AI_x = (AI_x - 1) * 2;
                            long_x = AI_x - 2;
                            long_z = AI_reserve - 1;
                        }
                        else if (p == 6 && block_7 == true)
                        {
                            // AI_reserve = AI_x - 1;
                            long_y = AI_y;
                            // AI_x = (AI_x - 1) * 2;
                            long_x = AI_x - 2;
                            long_z = AI_reserve - 1;
                        }
                        else if (p == 7 && block_8 == true)
                        {
                            // AI_reserve = AI_x - 1;
                            long_y = AI_y - 1;
                            //AI_x = (AI_x - 1) * 2;
                            long_x = AI_x - 2;
                            long_z = AI_reserve - 1;
                        }
                        else
                        {
                            long_y = AI_y;
                            long_x = AI_x;
                            long_z = AI_reserve;
                        }
                        try
                        {
                            if (mass[long_y, long_x - long_z] == "  ") { }}
                        catch
                        {
                            if (p == 0)
                            {
                                block_1 = false;
                            }
                            else if (p == 1)
                            {
                                block_2 = false;
                            }
                            else if (p == 2)
                            {
                                block_3 = false;
                            }
                            else if (p == 3)
                            {
                                block_4 = false;
                            }
                            else if (p == 4)
                            {
                                block_5 = false;
                            }
                            else if (p == 5)
                            {
                                block_6 = false;
                            }
                            else if (p == 6)
                            {
                                block_7 = false;
                            }
                            else if (p == 7)
                            {
                                block_8 = false;
                            }
                        }
                        finally { }
                    }
                 if (block_1 == false && block_2 == false && block_3 == false && block_4 == false && block_5 == false && block_6 == false && block_7 == false && block_8 == false) { Game = true; }
                }
               

            }
            return Game;
        }
        private bool Ladia (int Old_x, int Old_y,int Old_Z, int New_x, int New_y, int New_Z)
        {
            if (New_x - Old_x > 0)
            {
                int Neon_z = Old_Z;
                Neon_z++;
                for (int l = Old_x+2; l < New_x; l+=2)
                {
                    if (mass[l - Neon_z, Old_y] == "\u265a " || mass[l - Neon_z, Old_y] == "\u265b " || mass[l - Neon_z, Old_y] == "\u265c " || mass[l - Neon_z, Old_y] == "\u265d " || mass[l - Neon_z, Old_y] == "\u265e " || mass[l - Neon_z, Old_y] == "\u265f " || mass[l - Neon_z, Old_y] == "\u2654 " || mass[l - Neon_z, Old_y] == "\u2655 " || mass[l - Neon_z, Old_y] == "\u2656 " || mass[l - Neon_z, Old_y] == "\u2657 " || mass[l - Neon_z, Old_y] == "\u2658 " || mass[l - Neon_z, Old_y] == "\u2659 ")
                    {
                        return false;
                    }
                    Neon_z++;
                }
            }
            else if (New_x - Old_x < 0)
            {
                int Neon_z = Old_Z;
                Neon_z--;
                for (int l = Old_x - 2; l > New_x; l -= 2)
                {
                    if (mass[l - Neon_z, Old_y] == "\u265a " || mass[l - Neon_z, Old_y] == "\u265b " || mass[l - Neon_z, Old_y] == "\u265c " || mass[l - Neon_z, Old_y] == "\u265d " || mass[l - Neon_z, Old_y] == "\u265e " || mass[l - Neon_z, Old_y] == "\u265f " || mass[l - Neon_z, Old_y] == "\u2654 " || mass[l - Neon_z, Old_y] == "\u2655 " || mass[l - Neon_z, Old_y] == "\u2656 " || mass[l - Neon_z, Old_y] == "\u2657 " || mass[l - Neon_z, Old_y] == "\u2658 " || mass[l - Neon_z, Old_y] == "\u2659 ")
                    {
                        return false;
                    }
                    Neon_z--;
                }
            }
            if (New_y - Old_y > 0)
            {
                int Neon_z = Old_x - Old_Z;
                for (int l = Old_y + 1; l < New_y; l ++)
                {
                    
                    if (mass[Neon_z, l] == "\u2654 " || mass[Neon_z, l] == "\u2655 " || mass[Neon_z, l] == "\u2656 " || mass[Neon_z, l] == "\u2657 " || mass[Neon_z, l] == "\u2658 " || mass[Neon_z, l] == "\u2659 " || mass[Neon_z, l] == "\u265a " || mass[Neon_z, l] == "\u265b " || mass[Neon_z, l] == "\u265c " || mass[Neon_z, l] == "\u265d " || mass[Neon_z, l] == "\u265e " || mass[Neon_z, l] == "\u265f ")
                    {
                        return false;
                    }
                }
            }
            else if (New_y - Old_y < 0)
            {
                int Neon_z = Old_x - Old_Z;
                for (int l = Old_y - 1; l > New_y; l--)
                {
                    if (mass[Neon_z, l] == "\u265F " || mass[Neon_z, l] == "\u265a " || mass[Neon_z, l] == "\u265b " || mass[Neon_z, l] == "\u265c " || mass[Neon_z, l] == "\u265d " || mass[Neon_z, l] == "\u265e " || mass[Neon_z, l] == "\u2654 " || mass[Neon_z, l] == "\u2655 " || mass[Neon_z, l] == "\u2656 " || mass[Neon_z, l] == "\u2657 " || mass[Neon_z, l] == "\u2658 " || mass[Neon_z, l] == "\u2659 ")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool Slon (int Old_x, int Old_y, int Old_Z, int New_x, int New_y, int New_Z)
        {
            if (New_x - Old_x > 0 && New_y - Old_y <0)//Верх право
            {
                int Neon_z = Old_Z;
                Neon_z++;
                for (int l = Old_x + 2; l < New_x; l+=2)
                {
                    Old_y--;
                    if (mass[l - Neon_z, Old_y] == "\u2654 " || mass[l - Neon_z, Old_y] == "\u2655 " || mass[l - Neon_z, Old_y] == "\u2656 " || mass[l - Neon_z, Old_y] == "\u2657 " || mass[l - Neon_z, Old_y] == "\u2658 " || mass[l - Neon_z, Old_y] == "\u2659 " || mass[l - Neon_z, Old_y] == "\u265a " || mass[l - Neon_z, Old_y] == "\u265b " || mass[l - Neon_z, Old_y] == "\u265c " || mass[l - Neon_z, Old_y] == "\u265e " || mass[l - Neon_z, Old_y] == "\u265f ")
                    {
                        return false;
                    }
                }
                Neon_z++;
            }
            else if (New_x - Old_x < 0 && New_y - Old_y > 0)//Низ лево
            {
                int Neon_z = Old_Z;
                Neon_z--;
                for (int l = Old_x - 2; l < New_x; l -= 2)
                {
                    Old_y++;
                    if (mass[l - Neon_z, Old_y] == "\u2654 " || mass[l - Neon_z, Old_y] == "\u2655 " || mass[l - Neon_z, Old_y] == "\u2656 " || mass[l - Neon_z, Old_y] == "\u2657 " || mass[l - Neon_z, Old_y] == "\u2658 " || mass[l - Neon_z, Old_y] == "\u2659 " || mass[l - Neon_z, Old_y] == "\u265a " || mass[l - Neon_z, Old_y] == "\u265b " || mass[l - Neon_z, Old_y] == "\u265c " || mass[l - Neon_z, Old_y] == "\u265d " || mass[l - Neon_z, Old_y] == "\u265e " || mass[l - Neon_z, Old_y] == "\u265f ")                    {
                        return false;
                    }
                    Neon_z--;
                }
            }
            else if (New_x - Old_x > 0 && New_y - Old_y > 0)//Низ право
            {
                int Neon_z = Old_Z;
                for (int l = Old_x + 2; l < New_x; l += 2)
                {
                    Old_y++;
                    if (mass[l - Neon_z, Old_y] == "\u2654 " || mass[l - Neon_z, Old_y] == "\u2655 " || mass[l - Neon_z, Old_y] == "\u2656 " || mass[l - Neon_z, Old_y] == "\u2657 " || mass[l - Neon_z, Old_y] == "\u2658 " || mass[l - Neon_z, Old_y] == "\u2659 " || mass[l - Neon_z, Old_y] == "\u265a " || mass[l - Neon_z, Old_y] == "\u265b " || mass[l - Neon_z, Old_y] == "\u265c " || mass[l - Neon_z, Old_y] == "\u265d " || mass[l - Neon_z, Old_y] == "\u265e " || mass[l - Neon_z, Old_y] == "\u265f ")
                    {
                    
                            return false;
                    }
                }
                Neon_z++;
            }
            else if (New_x - Old_x < 0 && New_y - Old_y < 0)//Верх лево
            {
                int Neon_z = Old_Z;
                for (int l = Old_x - 2; l < New_x; l -= 2)
                {
                    Old_y--;
                    if (mass[l - Neon_z, Old_y] == "\u2654 " || mass[l - Neon_z, Old_y] == "\u2655 " || mass[l - Neon_z, Old_y] == "\u2656 " || mass[l - Neon_z, Old_y] == "\u2657 " || mass[l - Neon_z, Old_y] == "\u2658 " || mass[l - Neon_z, Old_y] == "\u2659 " || mass[l - Neon_z, Old_y] == "\u265a " || mass[l - Neon_z, Old_y] == "\u265b " || mass[l - Neon_z, Old_y] == "\u265c " || mass[l - Neon_z, Old_y] == "\u265d " || mass[l - Neon_z, Old_y] == "\u265e " || mass[l - Neon_z, Old_y] == "\u265f ")
                    {
                            return false;
                    }
                }
                Neon_z--;
            }
            return true;
        }
        public void Game_low()
        {
            int x_p = 0, y_p = 0;
            List<string> dead = new List<string>();
            int u2655 = 0, u2654 = 0, u2657 = 0, u2658 = 0, u2656 = 0, KBU = 0;
            bool a2655 = true,a2656 = true,a2657 = true,a2658 = true;
            int break1 = 0, break2 = 0,break3 = 0,break4 = 0;
            for (x_p = 0; x_p < 8; x_p++)
            {
                for (y_p = 0; y_p < 8; y_p++)
                {
                    switch (mass[x_p, y_p])
                    {
                        case "\u2655 ": u2655++; break;
                        case "\u2657 ": u2657++; break;
                        case "\u2658 ": u2658++; break;
                        case "\u2656 ": u2656++; break;
                    }
                }
            }
            if (u2655 == 1)
                a2655 = false;
            if (u2656 == 2)
                a2656 = false;
            if (u2657 == 2)
                a2657 = false;
            if (u2658 == 2)
                a2658 = false;
            int vibor = 1;
            do
            {
                vibor = rand.Next(1, 5);
                switch (vibor)
                {
                    case 1: if (a2655) { mass[y, x - Z] = "\u2655 "; Console.Write(mass[y, x - Z]); vibor = 0; } else { if (break1 == 0) { break1 = 1; KBU++; } }; break;
                    case 2: if (a2656) { mass[y, x - Z] = "\u2656 "; Console.Write(mass[y, x - Z]); vibor = 0; } else { if (break2 == 0) { break2 = 1; KBU++; } }; ; break;
                    case 3: if (a2657) { mass[y, x - Z] = "\u2657 "; Console.Write(mass[y, x - Z]); vibor = 0; } else { if (break3 == 0) { break3 = 1; KBU++; } }; ; break;
                    case 4: if (a2658) { mass[y, x - Z] = "\u2658 "; Console.Write(mass[y, x - Z]); vibor = 0; } else { if (break4 == 0) { break4 = 1; KBU++; } }; ; break;
                    default: break;
                }
            } while (vibor!= 0 && KBU < 4);
        }
        public void Game_low(int X,int Y, int z)
        {
            int x_p = 0, y_p = 0;
            List<string> dead = new List<string>();
            int u2655 = 0, u2654 = 0, u2657 = 0, u2658 = 0, u2656 = 0,KBU = 0;
            bool a2655 = true, a2656 = true, a2657 = true, a2658 = true;
            int break1 = 0, break2 = 0, break3 = 0, break4 = 0;
            for (x_p = 0; x_p < 8; x_p++)
            {
                for (y_p = 0; y_p < 8; y_p++)
                {
                    switch (mass[x_p, y_p])
                    {
                        case "\u265b ": u2654++; break;
                        case "\u265c ": u2657++; break;
                        case "\u265d ": u2658++; break;
                        case "\u265e ": u2656++; break;
                    }
                }
            }
            if (u2655 == 1)
                a2655 = false;
            if (u2656 == 2)
                a2656 = false;
            if (u2657 == 2)
                a2657 = false;
            if (u2658 == 2)
                a2658 = false;
            int vibor = 1;
            do
            {
                vibor = rand.Next(1, 5);
                switch (vibor)
                {
                    case 1: if (a2655) { mass[Y, X - z] = "\u265b "; Console.Write(mass[Y, X - z]); vibor = 0; } else { if (break1 == 0) { break1 = 1; KBU++; } }; break;
                    case 2: if (a2656) { mass[Y, X - z] = "\u265c "; Console.Write(mass[Y, X - z]); vibor = 0; } else { if (break2 == 0) { break2 = 1; KBU++; } }; break;
                    case 3: if (a2657) { mass[Y, X - z] = "\u265d "; Console.Write(mass[Y, X - z]); vibor = 0; } else { if (break3 == 0) { break3 = 1; KBU++; } }; break;
                    case 4: if (a2658) { mass[Y, X - z] = "\u265e "; Console.Write(mass[Y, X - z]); vibor = 0; } else { if (break4 == 0) { break4 = 1; KBU++; } }; break;
                    default: break;
                }
            } while (vibor != 0 && KBU < 4);
        }
    }
}
