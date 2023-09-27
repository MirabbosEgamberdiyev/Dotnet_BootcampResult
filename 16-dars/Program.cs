Console.WriteLine("Program started");
//Task.Run(Task1);
//Task.Run(Task2);
//Task.Run(Task3);

//var res = WriteSomeText();
//var task = WriteNumbers();
////numbers.ContinueWith(x => Console.WriteLine(x.Result));

////Console.WriteLine(numbers);

//IProgress<int> progress = 
//    new Progress<int>(i => Console.Write($"\r{i} %"));
//var res = SomeTask(progress);
CancellationTokenSource source = new CancellationTokenSource();
source.CancelAfter(5000);

try
{
    await WriteSomeText(source.Token);
}
catch (Exception)
{
    Console.WriteLine("Topshiriq bekor qilindi!");
}

Console.WriteLine("Navbatdagi buyruq");
Console.ReadLine();
////string input = Console.ReadLine();
//Console.WriteLine(input);


//HttpClient client = new HttpClient();
//var response = await client.GetStringAsync("https://translate.google.com/?hl=uz&sl=en&tl=uz&text=warm&op=translate");

//Console.WriteLine(response);




async Task SomeTask(IProgress<int> progress)
{
    for (int i = 1; i < 100; i++)
    {
        progress.Report(i);
        Thread.Sleep(100);
    }
}

void Task1()
{
    Console.WriteLine("Task1 started...");
    Thread.Sleep(7000);
    Console.WriteLine("\nTask1 Completed!");
}

void Task2()
{
    Console.WriteLine("Task2 started...");
    Thread.Sleep(6000);
    Console.WriteLine("\nTask2 Completed!");
}

void Task3()
{
    Console.WriteLine("Task3 started...");
    Thread.Sleep(5000);
    Console.WriteLine("\nTask3 Completed!");
}

async Task WriteSomeText(CancellationToken token)
{
    Console.WriteLine($"Yozish boshlandi: {DateTime.Now}");
    using var stream = new StreamWriter("Some.txt");
    for (int i = 0; i < 500000; i++)
    {
        token.ThrowIfCancellationRequested();
        await stream.WriteAsync("Hello" + i);
    }
    Console.WriteLine($"Tugadi: {DateTime.Now}");
}

async Task WriteNumbers()
{
    Console.WriteLine("Start");
    string res = "";
    for (int i = 1; i < 50000;  i++)
    {
        res += i;
    }
    using var stream = new StreamWriter("Some.txt");
    await stream.WriteAsync(res);
    Console.WriteLine("End");
}