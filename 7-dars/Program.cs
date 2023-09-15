//int A = 6;
////int B = 2;
////int sum;
////Sum(A, B, out sum);
////Console.WriteLine(sum);
//int p1, p2;
//Pow(A,out p1,out p2);
//Console.WriteLine(p1 +"\n" + p2);


//void Pow(int A, out int P2, out int P3)
//{
//    P2 = A * A;
//    P3 = A * P2;
//}
//void Inc(ref int a)
//{
//    a = a + 1;
//}

void Sum(int number1, int number2, out int res)
{
    res = number1 + number2;
}

//void Print(int n)
//{
//    Console.WriteLine(n);
//    n = 10;
//}



////params 
//int MaxValue(params int[] numbers)
//{
//    return numbers.Max(x => x);
//}

//int Sum(params int[] numbers)
//{
//    int sum = 0;
//    foreach (var x in numbers)
//        sum += x;
//    return sum;
//}


//Console.WriteLine(MaxValue(1, 2, 3, 4));
//Console.WriteLine(MaxValue(new int[] {13, 2, 33}));
//Console.WriteLine(Sum(1, 2, 3, 4));

//int m = 9;

//{
//    int m1 = 9;
//    m = 0;
//    Console.WriteLine(m1);
//}

//m1 = 4;

//DateTime

//DateTime sana = DateTime.Now;
//Console.WriteLine(sana);
//Console.WriteLine(sana.ToShortDateString());

//DateTime birthDate = DateTime.Parse("09/06/2004");

//Console.WriteLine(sana.Year - birthDate.Year);
//Console.WriteLine(sana.AddDays(-30));

//DateOnly date =  new DateOnly(2023, 09, 14);

//const string ACCESS_TOKEN = "password";

//Guid Id =  Guid.NewGuid();
//Console.WriteLine(Id);

// Case 4
//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());

//string qiymati = string.Empty;
//qiymati = n switch
//{
//    6 => "olti",
//    7 => "yetti",
//    8 => "sakkiz",
//    9 => "to'qqiz",
//    10 => "o'n",
//    11 => "valet",
//    12 => "dama",
//    13 => "qirol",
//    14 => "tuz",
//};

//string turi = m switch
//{
//    1 => "qarg'a",
//    2 => "chillak",
//    3 => "g'ishtin",
//    4 => "toppon",
//};

//Console.WriteLine(qiymati + " " + turi);

// Series 8
int count =  0;
while (true)
{
    int n = int.Parse(Console.ReadLine());
    count++;
    if (n == 0)
    { break; }
}
Console.WriteLine(count);