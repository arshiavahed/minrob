internal class Program
{
    //ARSHIA VAHED
    //Minroob project
    //-------------------------------------------------------------------
    //CODE:
    private static void Main(string[] args)
    {
        int x = 10;
        int[,] a = new int[x, x];
        int[,] b = new int[x, x];
        for (int i = 0; i < x; i++)    //fill the map and select bomb location
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("(Just 0 and 1)\n" + "Enter [" + i + "," + j + "] :");
                a[i, j] = Convert.ToInt16(Console.ReadLine());
                while (a[i, j] > 1)
                {
                    Console.Write("Error! Enter again:");
                    a[i, j] = Convert.ToInt16(Console.ReadLine());
                }
                Console.Clear();
            }
        }
        Console.WriteLine("Your game map is:");
        for (int i = 0; i < x; i++)     //show the map that client made
        {
            Console.Write("| ");
            for (int j = 0; j < x; j++)
            {
                Console.Write(a[i,j]+"  ");
            }
            Console.WriteLine("|");
        }
        for(int i = 0; i < x; i++)   //Calculate the location of the bombs
        {
            for(int j = 0; j < x; j++)
            {
                if(i==0 && j == 0)
                {
                    if (a[i,j+1]==1)
                    {
                        b[i, j]++;
                    }
                    if (a[i + 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if (i == 0 && j>0 && j<x-1)
                {
                    if (a[i + 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i, j + 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i, j - 1] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if(i==0 && j == x - 1)
                {
                    if (a[i, j - 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i + 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if(i>0 && i<x-1 && j == 0)
                {
                    if (a[i - 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i, j + 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i + 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if(i>0 && i<x-1 && j>0 && j < x - 1)
                {
                    if (a[i, j - 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i, j + 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i - 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i + 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if(i>0 && i<x-1 && j == x - 1)
                {
                    if (a[i, j - 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i - 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i + 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if(i==x-1 && j == 0)
                {
                    if (a[i - 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i, j + 1] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if(i==x-1 && j>0 && j < x - 1)
                {
                    if (a[i, j - 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i, j + 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i - 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                }
                if(i==x-1 && j == x - 1)
                {
                    if (a[i, j - 1] == 1)
                    {
                        b[i, j]++;
                    }
                    if (a[i - 1, j] == 1)
                    {
                        b[i, j]++;
                    }
                }
            }
        }    //End of calculate the location of the bombs
        Console.WriteLine("\n\n\nThe bomb location is :\n\n\n");
        for (int i = 0; i < x; i++)   //show found bombs
        {
            Console.Write("| ");
            for (int j = 0; j < x; j++)
            {
                Console.Write(b[i, j] + "  ");
            }
            Console.WriteLine("|");
        }
    }
}//END OF PROJECT