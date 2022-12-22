Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task25": Task25(); break;
			case "Task29": Task29(); break;
			case "Task27": Task27(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Task25()
{
	Console.WriteLine("Task25");

	int numberA = ReadInt("first number (A)");
	int numberB = ReadInt("second number (B)");

	Console.WriteLine($"The power {numberB} of number {numberA} is {Pow(numberA, numberB)}");
}
int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int Pow(int firstNumber, int secondNumber)
{
	int result = 1;

	for (int i = 0; i < secondNumber; i++)
	{
		result *= firstNumber;
	}

	return result;
}

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Task29()
{
	Console.WriteLine("Task29");

	int[] array = GetArray(ReadInt("array length"));

	Console.WriteLine(ArrayToString(array));
}
int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"elemtn {i}");
	}

	return array;
}
string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}  ";
	}

	return result;
}
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Task27()
{
	Console.WriteLine("Task27");
	int N = ReadInt("number");
	Console.WriteLine($"Сумма цифр {N} = {SumNumbers(N)}");
}

Task27();

int SumNumbers(int N)

{   int Sum = 0;
	while (N > 0)
	{
		Sum += N % 10;
		N /=10;
	}
	return Sum;
}



