```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
Intel Core i5-10210U CPU 1.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
| Method                          | Mean     | Error    | StdDev   | Gen0    | Allocated |
|-------------------------------- |---------:|---------:|---------:|--------:|----------:|
| ConcatStringsUsingStringBuilder | 40.52 μs | 1.948 μs | 5.463 μs | 47.6074 | 147.05 KB |
| ConcatStringsUsingGenericList   | 30.58 μs | 0.537 μs | 0.448 μs | 30.4565 |  93.42 KB |
