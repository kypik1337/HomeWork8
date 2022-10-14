//
Console.WriteLine("Add rows");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add columns");
int columns = int.Parse(Console.ReadLine()!);

int [,] Array = GetArray (rows, columns);
PrintArray(Array);
Console.WriteLine();
int MinSumLine = 0;
int SumLine = SummArray(Array,0);
for (int l = 0; l < Array.GetLength(0); l++)
{
    int PropSumLine = SummArray(Array,l);
    if (SumLine > PropSumLine)
        {
            SumLine = PropSumLine;
            MinSumLine = l;
        }
}
Console.WriteLine($"{MinSumLine+1} --> Rows");

int SummArray (int [,] Array, int k)
    {
        int Sline = Array [k,0];
        for (int g = 0; g < Array.GetLength(1); g++)
        {
         Sline += Array[k,g];   
        }
        return Sline;
    }



   void PrintArray (int[,] Array)
        {
           for (int i = 0; i < Array.GetLength(0); i++)
        {
              Console.Write("[");
            for (int y = 0; y < Array.GetLength(1); y++)
            {
                Console.Write($"{Array[i,y]} ");
        }  
        Console.WriteLine("]");
        }
        }

int [,] GetArray (int stroki, int Stolb)
    {
        int [,] result = new int [stroki,Stolb];
        for (int i = 0; i < stroki; i++)
        {
        for (int j = 0; j < Stolb; j++)
        {
            result[i,j] = new Random().Next(0, 10); 
        }
        }
        return result;
    }
