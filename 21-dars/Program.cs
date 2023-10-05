#region Robocontest: 0431
//int[] inputs = Console.ReadLine()
//                      .Split()
//                      .Select(x => int.Parse(x))
//                      .ToArray();
//int P = inputs[0];
//int D = inputs[1];
//int M = inputs[2];
//int S = inputs[3];
//int count = 0;

//while (true)
//{
//    if (S >= P)
//    {
//        S -= P;
//        count++;
//    }
//    else
//    {
//        break;
//    }
//    if (P - D >= M)
//    {
//        P -= D;
//    }
//    else
//    {
//        P = M;
//    }
//}

//Console.WriteLine(count);
#endregion


using System.Linq;

List<int> sonlar = new() { 5, 6, 7, 8, 9, 10, 6, 7, 8, 9, 10, 1, 1, 2, 3, 4 };
List<int> sonlar2 = new(){ 1, 2, 1, 45, 3, 4, 32, 2, 1, 5, 91, 56, 45 };
List<string> str = new()
{
    "Ali",
    "Vali",
    "Soli",
    "G'ani"
};

#region - All == AND &&
//bool sonlarMusbat =  sonlar.All(i => i > 0);
//Console.WriteLine(sonlarMusbat);


//bool res = str.All(ism => ism.Contains('i'));
//Console.WriteLine(res);
#endregion

#region - Any == OR ||
//bool res = sonlar.Any();// if (sonlar.Count != 0)
//bool res2 = sonlar.Any(x => x > 8);
//Console.WriteLine(res2);
#endregion

#region - Contains
//var res = sonlar.Contains(15);
//Console.WriteLine(res);
#endregion

#region - Min/Max
//int min = sonlar.Min();
//Console.WriteLine(min);
//int max = sonlar.Max();
//Console.WriteLine(max);
#endregion

#region - Distinct // bir xil elementlarni chopish
//foreach (int i in sonlar2.Distinct())
//{
//    Console.WriteLine(i);
//}
#endregion

#region - Except: A to'plamdan B to'plamni ayiradi va bir xillari chopiladi🪓
//var res = sonlar.Except(sonlar2);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

#region - Intersect: A va B to'plamda mavjud elementlarni qaytaradi va bir xillari chopiladi🪓
//var res = sonlar.Intersect(sonlar2);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

#region - Union: A va B birlashtiradi va bir xillari chopiladi🪓
//var res = sonlar2.Union(sonlar);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

#region - Take(n) - to'plam boshidan n ta element oladi
//var res = sonlar2.Take(5);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

#region - TakeWhile(n) - to'plam boshidan qaysidir shart yolg'on bo'lguncha oladi
//var res = sonlar2.TakeWhile(i => i < 10);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

#region - TakeLast(n) - to'plam oxiridan n ta element oladi
//var res = sonlar2.TakeLast(5);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

#region - Skip(n) - to'plam boshidan n ta elementni tashlab ketadi
//var res = sonlar2.Skip(3);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

#region - SkipWhile(n) - to'plam boshidan qaysidir shart yolg'on bo'lguncha tashlab ketadi
//var res = sonlar2.SkipWhile(i => i < 10);
//foreach (int i in res)
//{
//    Console.WriteLine(i);
//}
#endregion

//pagination example
//int pageSize = 5;
//int pageNumber = int.Parse(Console.ReadLine());
//var res = sonlar.Skip((pageNumber - 1) * pageSize).Take(pageSize);
//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}

/*ElementAt
//indekslash
var item = sonlar.ElementAt(0);
sonlar[0] = 0;
Console.WriteLine(item);
*/

/*First and FirstOrDefault

//birinchi kelgan elementni qaytaradi yoki exception uzatadi
//var firstItem = sonlar.First(i => i % 11 == 0);


//birinchi kelgan elementni yoki default qiymatni qaytaradi
//var firstItem = sonlar.FirstOrDefault(i => i % 11 == 0);
//Console.WriteLine(firstItem);
*/

/*Last and LastOrDefault

//oxirgi kelgan elementni qaytaradi yoki exception uzatadi
//var lastItem = sonlar.Last(i => i % 2 == 0);


//oxirgi kelgan elementni yoki default qiymatni qaytaradi
var lastItem = sonlar.LastOrDefault(i => i % 11 == 0);
Console.WriteLine(lastItem);
 */

/*Single and SingleOrDefault
int[] numbers = { 1, 5, 3 };
//var res = numbers.Single(i => i % 2 == 0);
//Console.WriteLine(res);

var res = numbers.SingleOrDefault(i => i % 2 == 0);
Console.WriteLine(res);
*/