//int i = 0;
//a1:
//if (i < 10)
//{
//    i++;
//    goto a1;
//}
//else
//{
//    Console.WriteLine(i);
//}

//string text =  Console.ReadLine();
//Console.WriteLine(text.TrimEnd());

//https://robocontest.uz/tasks/0991
//string son = Console.ReadLine();
//int juft_sum = 0;
//int toq_sum = 0;
//for  (int i = 0; i < son.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        juft_sum += int.Parse(son[i].ToString());
//    }
//    else
//    {
//        toq_sum += int.Parse(son[i].ToString());
//    }
//}
//string res = toq_sum == juft_sum ? "Yes" : "No";

//Console.WriteLine(res);

//https://robocontest.uz/tasks/1005
//string str = Console.ReadLine();
//int l = 0;
//int m_l = 0;

//foreach (char i in str)
//{
//    if (i == '1')
//    {
//        if (l > m_l)
//        {
//            m_l = l;
//        }
//        l = 0;
//    }
//    else
//    {
//        l++;
//    }
//}

//if (l > m_l)
//{
//    m_l = l;
//}

//Console.WriteLine(m_l);

//
//using System.Text;

//long K = long.Parse(Console.ReadLine());
//int N = int.Parse(Console.ReadLine());
//StringBuilder sb = new StringBuilder();
//for (long i = 1; i <= K; i++)
//{
//    sb.Append(i);
//}

//int count = sb.ToString().Split(N.ToString()).Length - 1;
//Console.WriteLine(count);

double[] input = Console.ReadLine().Split()
                                    .Select(i => double.Parse(i))
                                    .ToArray();
double pul = input[0];
double foiz = input[1];
double oy = input[2];
double natija = pul + pul * (foiz / 100) * oy;
Console.WriteLine((int)natija);

//https://robocontest.uz/tasks/0048
//int n = int.Parse(Console.ReadLine());
//int a = 1;
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1;  j <= i; j++)
//    {
//        Console.Write((a++) + " " );
//    }
//    Console.WriteLine();
//}