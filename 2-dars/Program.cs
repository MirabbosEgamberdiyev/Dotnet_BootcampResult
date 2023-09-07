//Console oynasiga ma'lumot chiqarish
//Console.Write("Hello, World!\n");
//Console.WriteLine("Hello, World!");


//Console.WriteLine(1234);
//Console.WriteLine(true);
//Console.WriteLine(1234.456456);
//Console.WriteLine('q');

//string text = Console.ReadLine();
//int number = int.Parse(text);
//int number2 = Convert.ToInt32(text);

//decimal a = 1;
//decimal b = 3;

//float res_float = a / b;
//double res_double = a / b;
//decimal  res_decimal = a / b;

//Console.WriteLine("Float bilan: " + res_float);
//Console.WriteLine("Double bilan: "+ res_double);
//Console.WriteLine("Decimal bilan: " + res_decimal);

//double n = 0.1;
//double m = 0.2;
//double c = m + n;
//Console.WriteLine(c);

//int billion = 1_000_000_000;
//Console.WriteLine(billion);

//// Decimal literal
////Allowed Digits: 0 to 9, _
//int a = 101; //No suffix is required

//// Hexa-Decimal Literal
////Allowed Digits: 0 to 9 and Character a to f
//int c = 0x11; //Prefix with 0x, and suffix with f

////Binary literal
////Allowed Digits: 0 to 1
//int d = 0b1001; // //Prefix with 0b

//Console.WriteLine($"Decimal Literal: {a}");
//Console.WriteLine($"Hexa-Decimal Literal: {c}");
//Console.WriteLine($"Binary Literal: {d}");

//double a = default;
//Console.WriteLine(a);

//begin 1
//Console.Write("Kvadratni tomoni a: ");
//int a = int.Parse(Console.ReadLine());
//int P = 4 * a;
//Console.WriteLine("Perimetr: P = " + P);

//begin 22
//Console.Write("A = ");
//int A = int.Parse(Console.ReadLine());
//Console.Write("B = ");
//int B = int.Parse(Console.ReadLine());

//1-usul
//int C = A;
//A = B;
//B = C;

//2-usul
//A = A + B;
//B = A - B;
//A = A - B;

//Console.WriteLine("A = {0}, {1}", A, 123);
//Console.WriteLine($"B = {B}");
//Console.WriteLine("33");

//int x = int.Parse(Console.ReadLine());
//int A = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//int kg = A / x;
//y = y * kg;
//Console.WriteLine(kg);
//Console.WriteLine(y);

int a = 512;
double b = Math.Sqrt(a);

//int n = int.Parse(Console.ReadLine());
//string[] inputs = Console.ReadLine().Split();
//long[] numbers = new long[n];
//for (int i = 0; i < n; i++)
//{
//    numbers[i] = long.Parse(inputs[i]);
//}

//long diff_min = long.MaxValue;
//for  (int i = 0; i < n - 1; i++)
//{
//    for (int j = i + 1; j < n; j++)
//    {
//        long diff = numbers[i] - numbers[j];
//        if (diff > 0 && diff < diff_min)
//        {
//            diff_min = diff;
//        }
//    }
//}

//Console.WriteLine(diff_min);