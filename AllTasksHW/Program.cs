
void Main()
{
    bool IsWork = true;
    while(IsWork)
    {
        System.Console.WriteLine("Введите номер задачи: ");
        string command = System.Console.ReadLine();
        
        switch (command)
        {
            case "54":
                Task54();
                break;
            case "56":
                Task56();
                break;
            case "58":
                Task58();
                break;
            case "exit":
                IsWork = false;
                break;
        }
    }
}


void Task54()
{
    int[,] Array = new int [4, 4];
    FillArray(Array);
    System.Console.WriteLine();
    ArrayLess(Array);
}


void Task56()
{
    int[,] Array = new int [4, 4];
    FillArray(Array);
    System.Console.WriteLine();
    int min = Firststring(Array);
    ArraySumm(Array, min);
}

void Task58()
{
    int[,] Array = new int [2, 2];
    int[,] Array1 = new int [2, 2];
    FillArray(Array);
    System.Console.WriteLine();
    FillArray(Array1);
    System.Console.WriteLine();
    SummArray(Array, Array1);
}


void FillArray(int[,] numbers)
{
    Random rnd = new Random();
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(1, 6);
            System.Console.Write($"{numbers[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


void ArrayLess(int[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            for(int f = j + 1; f < numbers.GetLength(1); f++)
            {
                if(numbers[i, j] < numbers[i, f])
                {
                    int temp = numbers[i, j];
                    numbers[i, j] = numbers[i, f];
                    numbers[i, f] = temp;
                }
            }
            System.Console.Write($"{numbers[i, j]} ");
        }
        System.Console.WriteLine();  
    } 
}

int Firststring(int[,] numbers)
{
    int summ = 0;
    for(int i = 0; i < 1; i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
           summ = summ + numbers[i, j];
        }
    }
    return summ;
}


void ArraySumm(int[,] numbers, int firststr)
{
    int min = firststr;
    int index = 0;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        int summ = 0;
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            summ = summ + numbers[i, j];
            System.Console.Write($"{numbers[i, j]} ");
        }
        System.Console.Write($"Сумма строки {i + 1}: {summ}");
        System.Console.WriteLine();
        if(summ < min)
        {
            min = summ;
            index = i;
        }
    }
    System.Console.WriteLine($"Минимальное значение в строке = {min}");
    System.Console.WriteLine($"Строка с минимальным значением = {index + 1}");
} 


void SummArray(int[,] numbers, int[,] numbers1)
{
    if(numbers.GetLength(0) == numbers1.GetLength(0) && numbers.GetLength(1) == numbers1.GetLength(1))
    {
        int [,] Array2 = new int [2, 2];
        for(int i = 0; i < Array2.GetLength(0); i++)
        {
            for(int j = 0; j < Array2.GetLength(1); j++)
            {
                for(int a = 0; a < Array2.GetLength(0); a++)
                {
                    Array2[i, j] = Array2[i, j] + numbers[i, a] * numbers1[a, j];
                }
                System.Console.Write($"{Array2[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }
    else
    {
        System.Console.WriteLine("Массивы имеют разное кол-во строк или столбцов");
    }
}


Main();

