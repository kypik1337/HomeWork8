int n = 4;
int[,] Matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(Matrix);

void PrintArray (int[,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i++)
  {
    Console.Write("[");
    for (int j = 0; j < Array.GetLength(1); j++)
    {
      if (Array[i,j] / 10 <= 0)
      Console.Write($" {Array[i,j]} ");

      else Console.Write($"{Array[i,j]} ");
    }
     Console.WriteLine("]");
  }
}