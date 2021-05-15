using System;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{


				Console.WriteLine("Введите максимальное число рандома");
				int n = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите кол-во элементов массива");
				int m = Convert.ToInt32(Console.ReadLine());
				int[] arr = new int[m];
				Random r = new Random();
				for (int i = 0; i < m; i++)
				{
					arr[i] = r.Next(0, n);
					Console.Write(arr[i] + " ");
				}
				for (int i = 0; i < arr.Length - 1; i++)
				{
					for (int j = i + 1; j < arr.Length; j++)
					{
						if (arr[i] > arr[j])
						{
							int d = arr[i];
							arr[i] = arr[j];
							arr[j] = d;
						}
					}
				}
				Console.Write("");
				Console.WriteLine("Вывод");
				for (int i = 0; i < arr.Length; i++)
				{
					Console.WriteLine(arr[i] + " ");
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.ReadKey();
		}
	}
}
