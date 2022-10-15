//
Console.Clear();
Console.WriteLine("Add rows");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add columns");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add izmerenie");
int izmerenie = int.Parse(Console.ReadLine()!);

int [,,] Array = GetArray (rows, columns, izmerenie);
PrintArray(Array);
count(Array);


void count (int[,,] Array )
  {
    for (int i = 0; i < Array.GetLength(0); i++)
    {
      for (int r = 0; r < Array.GetLength(1); r++)
      {
        for (int k = 0; k < Array.GetLength(2); k++)
        {
           for (int g = 0; g < Array.GetLength(2); g++)
           {
            Console.Write($"X({i}) Y({r}) ");
            Console.Write( $"Z({k})={Array[i,r,k]}; ");
            break;
           }
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }


   void PrintArray (int[,,] Array)
        {
           for (int i = 0; i < Array.GetLength(0); i++)
        {
              Console.Write("[");
            for (int y = 0; y < Array.GetLength(1); y++)
            {
              for (int k = 0; k < Array.GetLength(2); k++)
              {
                  Console.Write($"{Array[i,y,k]} ");
              }
        }  
        Console.WriteLine("]");
        }
        }

int [,,] GetArray (int stroki, int Stolb , int izmerenie)
    {
        int [,,] result = new int [stroki,Stolb,izmerenie];
        for (int i = 0; i < stroki; i++)
        {
        for (int j = 0; j < Stolb; j++)
        {
            for (int k = 0; k < izmerenie; k++)
            {
                result[i,j,k] = new Random().Next(10, 100); 
            }
        }
        }
        return result;
    }
