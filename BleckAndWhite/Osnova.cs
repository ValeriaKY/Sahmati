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
        int i = 0;
        int Z = 0;
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
            i = 0;
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
            } while (i != 1);//==
        }
        private void Pehuia_i()
        {
            int j = 0;
            do
            {
                mKey = Console.ReadKey(true);
                int add,x_p,y_p;
                 if (x == 0 && y == 6 || x == 2 && y == 6 || x == 4 && y == 6 || x == 6 && y == 6 || x == 8 && y == 6 || x == 10 && y == 6 || x == 12 && y == 6 || x == 14 && y == 6)
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
                }
                 else
                 {
                     add = 1;
                 }
                if (Proverka_AI(AI_x, AI_y, AI_reserve) == true)
                {
                    if (((AI_reserve + AI_y) % 2) != 0)
                    { Console.BackgroundColor = ConsoleColor.Black; }
                    else
                    { Console.BackgroundColor = ConsoleColor.White; }
                    mass[AI_y, AI_reserve] = "  ";
                    Console.SetCursorPosition(AI_x, AI_y);
                    Console.Write(mass[AI_y, AI_reserve]);
                    AI_y += add;
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
            } while (mKey.Key != ConsoleKey.Enter) ;

                 else
                 {
                     if ((((x - Z) + y) % 2) != 0)
                     { Console.BackgroundColor = ConsoleColor.Black; }
                     else
                     { Console.BackgroundColor = ConsoleColor.White; }
                     mass[y, (x - Z)] = "  ";
                     Console.SetCursorPosition(x, y);
                     Console.Write(mass[y, (x - Z)]);
                     y--;
                     Console.SetCursorPosition(x, y);
                     mass[y, (x - Z)] = "\u2659 ";
                     if ((((x - Z) + y) % 2) == 0)
                     {
                         Console.BackgroundColor = ConsoleColor.White;
                         Console.Write(mass[y, (x - Z)]);
                     }
                     else
                     {
                         Console.BackgroundColor = ConsoleColor.Black;
                         Console.Write(mass[y, (x - Z)]);
                     }
                 }
            
        }
        private void Kanina_i()
        {
            int lineHorse, columHorse, linePos, columPos;//lineHorse-строка columHorse2-столбец
            lineHorse = y;
            columHorse = x;
            int Z_old = Z;
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
                        i++;
                    }
                }
            } while (i == 0);
        }
        private void Slon_i()
        {
            int lineelEphant, columelEphant, linePos, columPos;//lineelEphant-строка columelEphant2-столбец

            lineelEphant = y;
            columelEphant = x;
            int Z_old = Z;
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
                linePos = y;
                columPos = x;
                if (Proverka_i() == true)
                {
                    if (Math.Abs(lineelEphant - linePos) == Math.Abs((columelEphant - Z_old) - (columPos - Z)))
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
                        i++;
                    }
                }
            } while (i == 0);
        }
        private void Ladia_i()
        {
            int lineRook, columRook, linePos, columPos;//lineRook-строка columRook2-столбец
            lineRook = y;
            columRook = x;
            int Z_old = Z;
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
                linePos = y;
                columPos = x;
                if (Proverka_i() == true)
                {
                    if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z) == 0))
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
                        i++;
                    }
                }
            } while (i == 0);
        }
        private void COVID_19()
        {
            int lineQueen, columQueen, linePos, columPos;//lineQueen-строка columQueen2-столбец
            lineQueen = y;
            columQueen = x;
            int Z_old = Z;
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
                linePos = y;
                columPos = x;
                if (Proverka_i() == true)
                {
                    if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z))
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
                        i++;
                    }
                }
            } while (i != 1);
        }
        private void COVID_20()
        {
            int line, colum;
            int lineKing, columKing, linePos, columPos;//lineKing-строка columKing-столбец
            lineKing = y;
            columKing = x;
            int Z_old = Z;
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
                        i++;
                    }
                }
            } while (i == 0);
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
                int AI_x = rand.Next(0, 8);
                int AI_y = rand.Next(0, 8);
                int AI_reserve = AI_x;
                 if (mass[AI_y, AI_x] == "\u265F ")//Пешка
                 {
                     AI_x = AI_x * 2;
                     Pehuia_AI(AI_x, AI_y,AI_reserve);
                     i++;
                 }
                 else if (mass[AI_y, AI_x] == "\u265e ")//конь
                {
                    AI_x = AI_x * 2;
                    Kanina_AI(AI_x, AI_y, AI_reserve);
                    i++;
                }
                 else if (mass[AI_y, AI_x] == "\u265d ")//Слон
                 {
                    AI_x = AI_x * 2;
                    Slon_AI(AI_x, AI_y, AI_reserve);
                     i++;
                 }
                 else if (mass[AI_y, AI_x] == "\u265c ")//Ладья
                 {
                    AI_x = AI_x * 2;
                    Ladia_AI(AI_x, AI_y, AI_reserve);
                     i++;
                 }
                 else if (mass[AI_y, AI_x] == "\u265b ")//Королева
                 {
                    AI_x = AI_x * 2;
                    COVID_19_AI(AI_x, AI_y, AI_reserve);
                     i++;
                 }
                 else if (mass[AI_y, AI_x] == "\u265a ")//Король
                 {
                    AI_x = AI_x * 2;
                    COVID_20_AI(AI_x, AI_y, AI_reserve);
                    i++;
                 }
            }
            while (i != 1);
        }
        private void Pehuia_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int add;
            if (AI_x == 0 && AI_y == 1 || AI_x == 2 && AI_y == 1 || AI_x == 4 && AI_y == 1 || AI_x == 6 && AI_y == 1 || AI_x == 8 && AI_y == 1 || AI_x == 10 && AI_y == 1 || AI_x == 12 && AI_y == 1 || AI_x == 14 && AI_y == 1)
            {
                add = rand.Next(1, 3);
            }
            else
            {
                add = 1;
            }
            if (Proverka_AI(AI_x, AI_y, AI_reserve) == true)
            {
                if (((AI_reserve + AI_y) % 2) != 0)
                { Console.BackgroundColor = ConsoleColor.Black; }
                else
                { Console.BackgroundColor = ConsoleColor.White; }
                mass[AI_y, AI_reserve] = "  ";
                Console.SetCursorPosition(AI_x, AI_y);
                Console.Write(mass[AI_y, AI_reserve]);
                AI_y += add;
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
        private void Kanina_AI(int AI_x, int AI_y, int AI_reserve)
        {
            int lineHorse, columHorse, linePos, columPos;//lineHorse-строка columHorse2-столбец
            lineHorse = AI_y;
            columHorse = AI_x;
            int Z_old = AI_reserve;
            int i = 0;
            int Z_New;
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
            do
            {
                AI_x = rand.Next(0, 8);
                AI_y = rand.Next(0, 8);
                AI_reserve = AI_x;
                AI_x = AI_x * 2;
                linePos = AI_y;
                columPos = AI_x;
                Z_New = AI_reserve;
                if (Proverka_AI(AI_x,AI_y,AI_reserve) == true)
                {
                    if (Math.Abs(lineelEphant - linePos) == Math.Abs((columelEphant - Z_old) - (columPos - Z_New)))
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
                    if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z) == 0))
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
                    if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z))
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
                if(beck == 1)
                {
                    break;
                }
            }
            Z_OLD = X;
            X = X * 2;
            if (Vacsina(X,Y,Z_OLD)==true)
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Конец игры вы проиграли");
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
            if (Vacsina(X,Y,Z_OLD) == true)
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Конец игры вы победили");
            }
        }
        private bool Vacsina(int AI_x, int AI_y, int AI_reserve)
        {
            bool Game = false;
            if (Game == false)
            {
                if (mass[AI_x, AI_y] == "\u2654 ")
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
                                    ;
                                    break;//Пешка
                                case "\u2658 ":
                                    int lineHorse, columHorse, linePos, columPos;//lineHorse-строка columHorse2-столбец
                                    lineHorse = g;//y
                                    int Z_old = i;
                                    columHorse = i * 2;//x
                                    int Z_New;
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
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
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
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
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z) == 0))
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
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z))
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
                }
                else if (mass[AI_x, AI_y] == "\u265a")
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
                                    ; break;//Пешка
                                case "\u265b ":
                                    int lineQueen, columQueen, linePos, columPos, Z_old, Z_New;//lineHorse-строка columHorse2-столбец
                                    lineQueen = g;//y
                                    columQueen = i * 2;//x
                                    Z_old = i;
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((Math.Abs(lineQueen - linePos) == Math.Abs((columQueen - Z_old) - (columPos - Z))) || (lineQueen == linePos) || (columQueen - Z_old == columPos - Z))
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
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
                                            columPos = 0;
                                            Z_New = 0;
                                        }
                                        if ((lineRook - linePos == 0) || ((columRook - Z_old) - (columPos - Z) == 0))
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
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
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
                                    for (int p = 0; i < 8; i++)
                                    {
                                        if (p == 0 && block_1 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y - 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 1 && block_2 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 2 && block_3 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 3 && block_4 == true)
                                        {
                                            AI_reserve = AI_x + 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x + 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 4 && block_5 == true)
                                        {
                                            AI_reserve = AI_x;
                                            linePos = AI_y + 1;
                                            AI_x = AI_x * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 5 && block_6 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y + 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 6 && block_7 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else if (p == 7 && block_8 == true)
                                        {
                                            AI_reserve = AI_x - 1;
                                            linePos = AI_y - 1;
                                            AI_x = (AI_x - 1) * 2;
                                            columPos = AI_x;
                                            Z_New = AI_reserve;
                                        }
                                        else
                                        {
                                            AI_reserve = 0;
                                            linePos = 0;
                                            AI_x = 0;
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
                }
            }
            return Game;
        }
    }
} 