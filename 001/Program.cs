//
Console.WriteLine("Add rows");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add columns");
int columns = int.Parse(Console.ReadLine()!);

int [,] Array = GetArray (rows, columns);
PrintArray(Array);
Console.WriteLine();
ArrayPerebor(Array);
PrintArray(Array);

void ArrayPerebor(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int r = 0; r < array.GetLength(1) - 1; r++)
      {
        if (array[i, r] < array[i, r + 1])
        {
          int temp = array[i, r + 1];
          array[i, r + 1] = array[i, r];
          array[i, r] = temp;
        }
      }
    }
  }
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