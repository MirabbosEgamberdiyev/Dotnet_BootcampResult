//izoh
/*
 bu
izoh
 
 */

string s = "Salom";
//Console.WriteLine(s.Length);
//Console.WriteLine(s[3]);


string ys = s + " Dunyo";
string ys1 = string.Join(" ", s, ys);
//Console.WriteLine("Salom\tDunyo\n!");
//Console.WriteLine("O\'zbekiston\\ \"");
string text = """
    string ys = s + " Dunyo";


    string ys1 = string.Join(" ", s, ys);
    Console.WriteLine("Salom\tDunyo\n!");
    Console.WriteLine("O\'zbekiston\\ \"");
    """;
//Console.WriteLine(text);

string Null = null;
string empty = string.Empty;
string empty2 = "";
//Console.WriteLine(Null == empty);
//Console.WriteLine(Null == empty2);
//Console.WriteLine(empty == empty2);

string interp = $"{s + ys}, {ys} : {3 + 4}";

//bo'laklarga bo'lish
text.Split();
//kesish
text.Substring(3, 6);
//almashtirish
text.Replace("Console", "System.Console");
string son1 = "12345";
string son2 = "12";
Console.WriteLine(son2.PadLeft(son1.Length, '0'));

int a = 1;
a++;
++a;
a--;
--a;
a += 10; // a = a + 10;
a -= 10;
a *= 10;
a /= 10;
a %= 10;

bool b1 = true;
bool b2 = false;

bool res = b1 && b2;
res = b1 || b2;
res = !b1;
res = b1 ^ b2;

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

bool result = n1 % 2 == 0 && n2 % 2 == 0 ||
              n1 % 2 == 1 && n2 % 2 == 1;
bool xor = !(n1 % 2 == 0 ^ n2 % 2 == 0);
Console.WriteLine(result == xor);

