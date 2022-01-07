
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1415 (20H2/October2020Update)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.402
  [Host]     : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  DefaultJob : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT


                            Method | IterationCount |        Mean |     Error |    StdDev | Rank |
---------------------------------- |--------------- |------------:|----------:|----------:|-----:|
 SqlWhereCountGetSmallPayloadAsync |              1 |    106.6 ms |   2.13 ms |   3.68 ms |    1 |
   DirectCountGetSmallPayloadAsync |              1 |    108.5 ms |   2.03 ms |   4.23 ms |    1 |
    WhereCountGetSmallPayloadAsync |              1 |    110.7 ms |   2.57 ms |   7.34 ms |    1 |
    WhereCountGetSmallPayloadAsync |            100 | 11,081.3 ms | 217.66 ms | 305.13 ms |    2 |
   DirectCountGetSmallPayloadAsync |            100 | 11,097.0 ms | 220.79 ms | 172.38 ms |    2 |
 SqlWhereCountGetSmallPayloadAsync |            100 | 11,348.2 ms | 183.22 ms | 295.87 ms |    2 |
