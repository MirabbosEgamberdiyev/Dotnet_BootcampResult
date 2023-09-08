//String

//matnlarni birlashtirish
/*string s1 = "Salom";
string s2 = " Dunyo!";
string plus = s1 + s2;
Console.WriteLine(plus);

string str_interp = $"{s1}{s2}";
Console.WriteLine(str_interp);

string str_c = string.Concat(s1, s2);
Console.WriteLine(str_c);

string str_join = string.Join("_", s1, s2);
Console.WriteLine(str_join);
*/

/*
// \'
string str = "O'zbekiston buyuk davlat!";
Console.WriteLine(str);

//\"
str = "\"O\u000Azbekiston\" buyuk davlat!";
Console.WriteLine(str);
str = "C\\User\\Desktop";
Console.WriteLine(str);
str = "Hello\nWorld!";
Console.WriteLine(str);
str = "Hello\tWorld!";
Console.WriteLine(str);

str = @"C\nUser\tDesktop";
Console.WriteLine(str);
*/

//interpolation
//int X = 2;
//int Y = 3;

//var pointMessage = $$$"""{The point {{{X}}}, {{{Y}}} is {{Math.Sqrt(X * X + Y * Y):F3}} from the origin}""";
//Console.WriteLine(pointMessage);

//int _int = 32;
//Console.WriteLine(_int);

//string multiline_str = $"""
//    <element attr="content">
//        <body>
//            Hello!
//        </body>
//    </element>
//    """;
//Console.WriteLine(multiline_str);

//string format
using System.Globalization;
using System.Text;

//int yosh = 24;
//string str = string.Format("Mening yoshim {0} {1}", yosh, " !");
//Console.WriteLine(str);

//decimal num = 34.535665465473m;
//str = string.Format("Format Decimal: {0:n6}", num);
//Console.WriteLine(str);
//int hour = 12;
//Console.WriteLine(hour.ToString("D4"));

//double money = 1_350_320_000;
//Console.WriteLine("Money: {0:n} ", money);

//double value = 5623345.6789;



////For Current Culture

//Console.WriteLine("\n--------- Displaying Currency in Current Culture ---------------\n");



//// By default, single letter C displays currency upto two decimal digits

//Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));



//// C2 displays currency upto two digits

//Console.WriteLine(value.ToString("C2", CultureInfo.CurrentCulture));



//// C3 displays currency upto three digits

//Console.WriteLine(value.ToString("C3", CultureInfo.CurrentCulture));



//// C4 displays currency upto four digits

//Console.WriteLine(value.ToString("C4", CultureInfo.CurrentCulture));



//// C5 displays currency upto five digits

//Console.WriteLine(value.ToString("C5", CultureInfo.CurrentCulture));



////For Japan

//Console.WriteLine("\n--------- Dispalying Currency for Japan ---------------\n");

//Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));



////For Denmark

//Console.WriteLine("\n--------- Dispalying Currency for Denmark ---------------\n");

//Console.WriteLine(value.ToString("C",

//      CultureInfo.CreateSpecificCulture("da-DK")));



////For India

//Console.WriteLine("\n--------- Dispalying Currency for India ---------------\n");

//Console.WriteLine(value.ToString("C",

//CultureInfo.CreateSpecificCulture("en-IN")));

//string str1 = "Hello";
//string str2 = "World";
//bool IsSame = str1.CompareTo(str2) == 0;
//Console.WriteLine(IsSame);
//string text = "BERILGAN, satrdagi, barcha, harflarni, kichik, harflarga o’zgartiradi";
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower());
//var words = text.Split("a");
//string path = @"C\user\Desktop";
//var directories = path.Split('\\');

//foreach (var word in words)
//    Console.WriteLine(word);

//string text = "BERILGAN, satrdagi, kichik, barcha, harflarni, kichik, bharflarga o’zgartiradi";
//Console.WriteLine(text.StartsWith("BER"));
//Console.WriteLine(text.EndsWith("BER"));
//Console.WriteLine(text.Contains("harf"));
//Console.WriteLine(text.IndexOf("a"));
//Console.WriteLine(text.LastIndexOf("a"));
//char[] chars = {'a', 'b'};
//Console.WriteLine(text.IndexOfAny(chars));

//Console.WriteLine(text.Substring(10));
//Console.WriteLine(text.Substring(10, 8));

//string name = null;
//bool IsEmpty = String.IsNullOrEmpty(name);
//Console.WriteLine(IsEmpty);
////output: True
///

/// robocontest 1013-savol
//string input = Console.ReadLine();
//Console.WriteLine(input.Replace("0", "").Length % 2 == 1 ? "YES" : "NO");