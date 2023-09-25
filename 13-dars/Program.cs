#region leetcode daily problem
//public class Solution
//{
//    public bool IsSubsequence(string s, string t)
//    {
//        int a = s.Length;
//        int b = t.Length;
//        int j = 0;
//        int i;
//        for (i = 0; i < a && j < b; j++)
//        {
//            if (s[i] == t[j])
//            {
//                i++;
//            }
//        }
//        if (i == a)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}


////codeforces problem
//class Program
//{
//    static void Main()
//    {
//        string[] inputs = new string[10];
//        for (int i = 0; i < 10;  i++)
//        {
//            inputs[i] = Console.ReadLine();
//        }

//        byte score = 0;

//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                if (inputs[i][j] == 'x')
//                {
//                    score += GetCellScore(i, j);
//                }
//            }
//        }

//        Console.WriteLine(score);
//    }
//    static byte GetCellScore(int i, int j)
//    {
//        if (i == 0 || i == 9)
//        {
//            return 1;
//        }
//        if (i == 1 || i == 8)
//        {
//            if (j == 0 || j == 9)
//            {
//                return 1;
//            }
//            else
//            {
//                return 2;
//            }
//        }
//        if (i == 2 || i == 7)
//        {
//            if (j == 0 || j == 9)
//            {
//                return 1;
//            }
//            else if (j == 1 || j == 8)
//            {
//                return 2;
//            }
//            else
//            {
//                return 3;
//            }
//        }
//        if (i == 3 || i == 6)
//        {
//            if (j == 0 || j == 9)
//            {
//                return 1;
//            }
//            else if (j == 1 || j == 8)
//            {
//                return 2;
//            }
//            else if (j == 2 ||  j == 7)
//            {
//                return 3;
//            }
//            else
//            {
//                return 4;
//            }
//        }
//        if (i == 4 || i == 5)
//        {
//            if (j == 0 || j == 9)
//            {
//                return 1;
//            }
//            else if (j == 1 || j == 8)
//            {
//                return 2;
//            }
//            else if (j == 2 || j == 7)
//            {
//                return 3;
//            }
//            else if (j == 3 || j == 6)
//            {
//                return 4;
//            }
//            else
//            {
//                return 5;
//            }
//        }

//        return 0;
//    }

//}

#endregion


//int a = 3;
////boxing is implicit
//object b = a;

////unboxing is explicit
//int c = (int)b;

using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //if (args[0] == "ls")
        //{
        //    string path = Environment.CurrentDirectory;
        //    Console.WriteLine(path);
        //    string[] directories = Directory.GetDirectories(path);
        //    foreach (string d in directories)
        //        Console.WriteLine(d.Split('\\')[^1]);
        //    string[] files = Directory.GetFiles(path);
        //    foreach (string d in files)
        //        Console.WriteLine(d.Split('\\')[^1]);

        //}


        // List
        //List<string> langs = new List<string>();
        //langs.Add("C#");
        //langs.Add("C/C++");
        //langs.Add("Python");
        //langs.Add("Java");
        //langs.Add("Rust");
        //langs.Add("Pascal");
        //langs.Add("JavaScript");
        //int countOfElements = langs.Count;
        //Console.WriteLine(countOfElements);

        //foreach (string lang in langs)
        //{
        //    Console.WriteLine(lang);
        //}

        //List<string> langs2 = new List<string>();
        //langs2.Add("Pascal");
        //langs2.Add("JavaScript");
        //langs2.Add("Zig");
        //langs2.AddRange(langs);
        //string[] langs3 = { "Kotlin", "Dart", "Cython" };
        //langs2.AddRange(langs3);

        //var csharp = langs[0];
        //Console.WriteLine(csharp);

        //foreach (string lang in langs2)
        //{
        //    Console.WriteLine(lang);
        //}

        //langs2[0] = "Golang";
        //for (int i = 0; i < langs2.Count; i++)
        //{
        //    Console.WriteLine(langs2[i]);
        //}

        //langs2.ForEach(lang => Console.WriteLine(lang));


        //item bo'yicha
        //langs.Remove("C/C++");

        ////index bo'yicha
        //langs.RemoveAt(2);

        //langs.ForEach(lang => Console.WriteLine(lang));
        ////Console.WriteLine();

        ////indexdan boshlab count ni o'chirish
        //langs.RemoveRange(1, 3);
        ////langs.ForEach(lang => Console.WriteLine(lang));
        //Console.WriteLine();

        // shart bo'yicha o'chirish
        //langs.RemoveAll(i => i.Length > 4);
        //langs.ForEach(lang => Console.WriteLine(lang));

        Console.WriteLine();
        //listni tozalash
        //langs.Clear();

        //langs = langs.OrderBy(i => i.Length).ToList();
        ////Console.WriteLine(langs.Count);
        //langs.ForEach(lang => Console.WriteLine(lang));

        //ArrayList arrayList = new ArrayList();
        //arrayList.Add(12);
        //arrayList.Add("RAM EATER");
        //arrayList.Add(true);
        //arrayList.Add(2343.546354d);
        //arrayList.Add(langs);
        //foreach (var item in arrayList)
        //{
        //    if (item.GetType() == typeof(List<string>))
        //    {
        //        Console.WriteLine(string.Join(", ", ((List<string>)item)));  
        //    }
        //    else
        //        Console.WriteLine(item);
        //}


        //Dictionary<int, string> dic = new Dictionary<int, string>();
        //dic.Add(dic.Count, "C#");
        //dic.Add(dic.Count, "Java");
        //dic.Add(dic.Count, "Python");
        //foreach (var key in dic.Keys)
        //{
        //    Console.WriteLine($"{key}. {dic[key]}");
        //}

        //Dictionary<string, string> dict = new Dictionary<string, string>();
        //dict.Add("Csharp", "C#");
        //dict.Add("Java", "Java");
        //dict.Add("Payton", "Python");


        //dict["Java"] = "Javamas";

        //foreach (var key in dict.Keys)
        //{
        //    Console.WriteLine($"{key}. {dict[key]}");
        //}

        //int s = 4;
        //var hashCode = s.GetHashCode();

        //KeyValuePair<int, int> keyValue = new KeyValuePair<int, int>();

        //yangi bo'sh Stackni e'lon qilish
        //    Stack<int> sonlar = new Stack<int>();

        //    //Stackga yangi elementlarni qo'shish
        //    sonlar.Push(2);
        //    sonlar.Push(5);
        //    sonlar.Push(7);

        //    //Stackdagi elementlar soni:
        //    Console.WriteLine(sonlar.Count);  //3 

        //    //Stackdan oxirgi qo'shilgan element qiymatini pop() orqali olish
        //    int b = sonlar.Pop();  //7 ga teng element Stackdan chiqib ketdi
        //    Console.WriteLine("b=" + b);
        //    Console.WriteLine("Elementlar soni: " + sonlar.Count); //2

        //    //Stackdan oxirgi qo'shilgan element qiymatini peek() orqali olish
        //    int c = sonlar.Peek();  //Stackdagi elementlar soni o’zgarmadi
        //    Console.WriteLine("c=" + c);
        //    Console.WriteLine("Elementlar soni: " + sonlar.Count);

        //    Console.ReadKey();
        //}
        //yangi Queue e'lon qilish
        //var navbat = new Queue<int>();

        ////Queue ga yangi element qo'shish
        //navbat.Enqueue(2);
        //navbat.Enqueue(5);
        //navbat.Enqueue(8);
        //navbat.Enqueue(13);
        //navbat.Enqueue(21);

        ////Queue ning eng boshidagi elementni aniqlash
        //Console.WriteLine("Eng boshidagi element: " + navbat.Peek());

        ////Queuedan elementlarni chiqarib tashlash
        //Console.WriteLine(navbat.Dequeue() + " soni chiqarib yuborildi");
        //Console.WriteLine(navbat.Dequeue() + " soni chiqarib yuborildi");

        ////Queueda element borligini tekshirish
        //Console.WriteLine(navbat.Contains(13));

        //Console.Write("Queueda qolgan elementlar: ");
        //foreach (int a in navbat)
        //    Console.Write(a + " ");



        //Console.ReadKey();
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        Console.WriteLine(FindTheDifference(s, t));

    }

    static char FindTheDifference(string s, string t)
    {
        Dictionary<char, int> letters_s = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (letters_s.ContainsKey(c))
            {
                var letter = letters_s[c];
                letters_s[c]++;
            }
            else
            {
                letters_s.Add(c, 1);
            }
        }

        Dictionary<char, int> letters_t = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (letters_t.ContainsKey(c))
            {
                var letter = letters_t[c];
                letters_t[c]++;
            }
            else
            {
                letters_t.Add(c, 1);
            }
        }

        foreach (var ch in letters_t)
        {
            if (letters_s[ch.Key] != letters_t[ch.Key])
            {
                return ch.Key;
            }
        }

        return t.Except(s).First();
    }
}