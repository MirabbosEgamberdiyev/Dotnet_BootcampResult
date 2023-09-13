//int[] sonlar = new int[10];
//int[] toq_sonlar = { 1, 3, 5, 7, 9 };

//toq_sonlar[4] = 1;
//Console.WriteLine(toq_sonlar[4]);

//Console.Write("n = ");
//int n = int.Parse(Console.ReadLine());
//double[] sonlar = new double[n];
//for  (int i = 0; i < n; i++)
//{
//    Console.Write($"a[{i}] = ");
//    sonlar[i] = double.Parse(Console.ReadLine());
//}
//Console.Write("\nk = ");
//int k = int.Parse(Console.ReadLine());
//Console.Write("m = ");
//int m = int.Parse(Console.ReadLine());

//double sum = 0;
//int count = 0;
//for (; k <= m; k++)
//{
//    sum += sonlar[k];
//    count++;
//}

//Console.WriteLine($"\nNatija: {sum/count}");

//Console.Write("n = ");
//int n = int.Parse(Console.ReadLine());
//int[] sonlar = new int[n];
//int min = int.MaxValue;
//int max = int.MinValue;
//int min_index = 0;
//int max_index = 0;
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"a[{i}] = ");
//    sonlar[i] = int.Parse(Console.ReadLine());
//    if (sonlar[i] < min )
//    {
//        min = sonlar[i];
//        min_index = i;
//    }

//    if (sonlar[i] > max )
//    {
//        max = sonlar[i];
//        max_index = i;
//    }
//}
//int temp = sonlar[min_index];
//sonlar[min_index] = sonlar[max_index];
//sonlar[max_index] = temp;

//Console.WriteLine(string.Join(" ", sonlar));

//int[] numbers = { 1,2,5,7,8 };
//Console.WriteLine(numbers.Length);
//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers[^1]);


//foreach (var number in numbers)
//    Console.WriteLine(number);

//int[] toq_sonlar = { 71, 43, 51, 7, 9};
//int[] juft_sonlar = new int[5];
//Array.Copy(toq_sonlar, juft_sonlar, 4);
////Array.Clear(juft_sonlar);
//Array.Reverse(juft_sonlar);
////Array.Fill(juft_sonlar, 3);
//Array.Sort(juft_sonlar);
//Array.Resize(ref juft_sonlar, 10);

//Console.WriteLine(string.Join(" ", juft_sonlar));

//int[,] matrix = new int[8, 7];
//int[,] matrix2 =
//{
//    {1, 3, 6 },
//    {1, 4, 7 },
//    {1, 5, 8 },
//};

//Random random = new();

//for  (int i = 0; i < 8; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        matrix[i, j] = random.Next(10, 99);
//    }
//}

//for (int i = 0; i < 8; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        Console.Write(" " + matrix[i, j]);
//    }
//    Console.WriteLine();
//}


//double[][] mas = new double[4][];
//mas[0] = new double[14];
//mas[1] = new double[3];
//mas[2] = new double[2];
//mas[3] = new double[5];

//foreach(var mat in mas)
//{
//    Console.WriteLine(string.Join(" ", mat));
//    Console.WriteLine();
//}