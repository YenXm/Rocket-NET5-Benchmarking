
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1415 (20H2/October2020Update)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.402
  [Host]     : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  DefaultJob : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT


                                  Method | IterationCount |        Mean |     Error |      StdDev |      Median | Rank |
---------------------------------------- |--------------- |------------:|----------:|------------:|------------:|-----:|
 SqlAndDistinctCountGetSmallPayloadAsync |              1 |    106.6 ms |   2.74 ms |     8.00 ms |    104.0 ms |    1 |
            SqlCountGetSmallPayloadAsync |              1 |    107.6 ms |   2.15 ms |     4.09 ms |    107.2 ms |    1 |
        HashSetCountGetSmallPayloadAsync |              1 |    116.1 ms |   3.19 ms |     9.16 ms |    114.5 ms |    2 |
       DistinctCountGetSmallPayloadAsync |              1 |    118.6 ms |   3.38 ms |     9.75 ms |    116.1 ms |    2 |
            SqlCountGetSmallPayloadAsync |            100 | 10,883.0 ms | 217.56 ms |   223.41 ms | 10,879.6 ms |    3 |
 SqlAndDistinctCountGetSmallPayloadAsync |            100 | 11,018.0 ms | 194.86 ms |   273.17 ms | 10,925.8 ms |    3 |
        HashSetCountGetSmallPayloadAsync |            100 | 12,052.2 ms | 240.67 ms |   491.62 ms | 11,914.5 ms |    4 |
       DistinctCountGetSmallPayloadAsync |            100 | 12,729.0 ms | 368.90 ms | 1,064.36 ms | 12,487.5 ms |    5 |
