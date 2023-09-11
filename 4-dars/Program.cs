#region 1-qism
//bool logic = true;
//Console.WriteLine(logic);

//mantiqiy qo'shish - yoki (OR)
//bool b1 = true;
//bool b2 = false;

//bool res = b1 | b2;
//bool res2 = b1 || b2;
//Console.WriteLine(res);
//Console.WriteLine(res2);

//mantiqiy ko'paytirish - va (AND)
//bool b1 = true;
//bool b2 = false;

//bool res = b1 & b2;
//bool res2 = b1 && b2;
//Console.WriteLine(res);
//Console.WriteLine(res2);

////inkor - NOT (emas)
//Console.WriteLine(!b1);

//mantiqiy XOR
//bool b1 = true;
//bool b2 = false;

//bool res = b1 ^ b2;
//Console.WriteLine(res);


//Taqqoslash operatorlari
//int a = 2;
//int b = 3;
//// katta
//bool res = a > b;
//// kichik
//res = a < b;
//// katta yoki teng
//res = a >= b;
//// kichik yoki teng
//res = a <= b;
////teng
//res = a == b;
//// teng emas
//res = a != b;

#endregion

#region 2-qism

//Console.Write("a = ");
//int a = int.Parse(Console.ReadLine());
//if (a > 0)
//{
//    Console.WriteLine("a musbat son");
//}
//else if (a < 0)
//{
//    Console.WriteLine("a manfiy son");
//}
//else
//{
//    Console.WriteLine("a 0 ga teng");
//}

//Console.WriteLine("Dastur yakunlandi!");


//int year = int.Parse(Console.ReadLine());
//if (year % 4 == 0 && year % 100 != 0
//    || year % 400 == 0)
//{
//    Console.WriteLine("Kabisa yili");
//}
//else
//{
//    Console.WriteLine("Kabisa yili emas");
//}

//string[] input = Console.ReadLine().Split();

//int A = int.Parse(input[0]);
//int B = int.Parse(input[1]);
//int C = int.Parse(input[2]);

//int AC = (int)Math.Abs(A - C);
//int BC = (int)Math.Abs(B - C);

//if (AC < BC)
//{
//    Console.WriteLine("1-mushuk");
//}
//else if (AC > BC)
//{
//    Console.WriteLine("2-mushuk");
//}
//else
//{
//    Console.WriteLine("sichqon");
//}



//string[] input = Console.ReadLine().Split(":");
//DateTime date = new DateTime(  int.Parse(input[2]), 
//                               int.Parse(input[1]),
//                               int.Parse(input[0]));
// switch expression
//string result = date.DayOfWeek.ToString() switch
//{
//    "Monday" => "Dushanba",
//    "Tuesday" => "Seshanba",
//    "Wednesday" => "Chorshanba",
//    "Thursday" => "Payshanba",
//    "Friday" => "Juma",
//    "Saturday" => "Shanba",
//    "Sunday" => "Yakshanba",
//    _ => throw new NotImplementedException()
//};

//Console.WriteLine(result);

//switch statment
//switch (date.DayOfWeek.ToString())
//{
//    case "Monday":
//    case "monday":
//    case "MONDAY":
//        {
//            Console.WriteLine("Dushanba");
//        } break;

//    case "Tuesday":
//        {
//            Console.WriteLine("Seshanba");
//        }
//        break;
//    case "Wednesday":
//        {
//            Console.WriteLine("Chorshanba");
//        }
//        break;
//    case "Thursday":
//        {
//            Console.WriteLine("Payshanba");
//        }
//        break;
//    case "Friday":
//        {
//            Console.WriteLine("Juma");
//        }
//        break;
//    case "Saturday":
//        {
//            Console.WriteLine("Shanba");
//        }
//        break;
//    case "Sunday":
//        {
//            Console.WriteLine("Yakshanba");
//        }
//        break;
//    default: break;
//}

//int x = 1;
//int y = 2;

//x += y; //x = x + y;
//Console.WriteLine(x);

//// x = x + 1;
//Console.WriteLine("x++ = " + (x++));
//Console.WriteLine("x = " + x);

//// x = x + 1;
//Console.WriteLine("++x = " + (++x));
//Console.WriteLine("x = " + x);


//// x = x - 1;
//Console.WriteLine("x-- = " + (x--));
//Console.WriteLine("x = " + x);

//// x = x - 1;
//Console.WriteLine("--x = " + (--x));
//Console.WriteLine("x = " + x);

//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//}
//Console.WriteLine();
//do
//{
//    Console.WriteLine(i);
//    i--;
//} while (i > 0);

//for (int j = 0; j < 10; j++)
//{
//    Console.WriteLine(j);
//}

//while bilan infinity loop
//while (true)
//{
//    Console.WriteLine("Infinity");
//}

//do-while bilan infinity loop
//do
//{
//    Console.WriteLine("Infinity");
//} while (true);

//for bilan infinity loop
//for (;;) 
//{
//    Console.WriteLine("Infinity");
//}

//for (int i = 1; true; i++)
//{
//    if (i % 2 == 0)
//        continue;

//    if (i > 1001)
//        break;

//    Console.WriteLine(i);
//}

// robocontest Masala #0588
//int X = 0;
//int N = int.Parse(Console.ReadLine());
//for (int i = 1; i <= N; i++)
//{
//    string amal = Console.ReadLine();
//    switch (amal)
//    {
//        case "X++": X++; break;
//        case "++X": ++X; break;
//        case "X--": X--; break;
//        case "--X": --X; break;
//    };
//}

//Console.WriteLine(X);

//int n = int.Parse(Console.ReadLine());
//int k = int.Parse(Console.ReadLine());
//int butun_qism = 0;
//int qoldiq = 0;

//while (n >= k)
//{
//    n -= k;
//    butun_qism++;
//}
//qoldiq = n;

//Console.WriteLine($"{k * butun_qism + qoldiq}/{k} = {k}*{butun_qism} + {qoldiq}");



int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a < b)
{
    int count = 0;
    for (int i = b; i >= a; i--)
    {
        Console.WriteLine(i);
        count++;
    }
    Console.WriteLine(count);
}
else
{
    Console.WriteLine("Xatolik!");
}
#endregion