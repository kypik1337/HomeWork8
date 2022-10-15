Console.Clear();
int rows = RandomNumbers("Введите число строк 1-й матрицы: ");
int columns = RandomNumbers("Введите число столбцов 1-й матрицы ");
int rows2 = RandomNumbers("Введите число строк 1-й матрицы: ");
int columns2 = RandomNumbers("Введите число столбцов 2-й матрицы: ");

int range = RandomNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] OneMatrix = new int[rows, columns];
CreateArray(OneMatrix);
Console.WriteLine($"Первая матрица:");
WriteArray(OneMatrix);

int[,] ToMatrix = new int[rows2, columns2];
CreateArray(ToMatrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(ToMatrix);

int[,] resultMatrix = new int[rows,columns2];

GoMatrix(OneMatrix, ToMatrix, resultMatrix);
Console.WriteLine($"Произведениe:=");
WriteArray(resultMatrix);

void GoMatrix(int[,] OneMatrix, int[,] ToMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < OneMatrix.GetLength(1); k++)
      {
        sum += OneMatrix[i,k] * ToMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int RandomNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine("]");
  }
}