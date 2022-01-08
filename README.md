<br/>
<p align="center">
  <h3 align="center">Rocket-NET5-Benchmarking</h3>

  <p align="center">
    Console App used to benchmark my api endpoint.
    <br/>
    <br/>
  </p>
</p>



## Table Of Contents

- [Table Of Contents](#table-of-contents)
- [About The Project](#about-the-project)
  - [Example:](#example)
  - [Description](#description)
- [Built With](#built-with)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
- [Usage](#usage)
- [Authors](#authors)

## About The Project

### Example:

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1415 (20H2/October2020Update)
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.402
  [Host]     : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT
  DefaultJob : .NET 5.0.11 (5.0.1121.47308), X64 RyuJIT


```
|                                  Method | IterationCount |        Mean |     Error |      StdDev |      Median |
|---------------------------------------- |--------------- |------------:|----------:|------------:|------------:|
| SqlAndDistinctCountGetSmallPayloadAsync |              1 |    106.6 ms |   2.74 ms |     8.00 ms |    104.0 ms |
|            SqlCountGetSmallPayloadAsync |              1 |    107.6 ms |   2.15 ms |     4.09 ms |    107.2 ms |
|        HashSetCountGetSmallPayloadAsync |              1 |    116.1 ms |   3.19 ms |     9.16 ms |    114.5 ms |
|       DistinctCountGetSmallPayloadAsync |              1 |    118.6 ms |   3.38 ms |     9.75 ms |    116.1 ms |
|            SqlCountGetSmallPayloadAsync |            100 | 10,883.0 ms | 217.56 ms |   223.41 ms | 10,879.6 ms |
| SqlAndDistinctCountGetSmallPayloadAsync |            100 | 11,018.0 ms | 194.86 ms |   273.17 ms | 10,925.8 ms |
|        HashSetCountGetSmallPayloadAsync |            100 | 12,052.2 ms | 240.67 ms |   491.62 ms | 11,914.5 ms |
|       DistinctCountGetSmallPayloadAsync |            100 | 12,729.0 ms | 368.90 ms | 1,064.36 ms | 12,487.5 ms |

### Description

After having some timeout issue on our alexa skill, I decided to try to optimize our REST api. To do so I had to have a way to benchmark my new and old endpoint to see what is truly faster and not only rely on postman timing.

You can have access to the benchmark results in this folder. https://github.com/YenXm/Rocket-NET5-Benchmarking/blob/55d5738b22cc5d5ea2ff2665bf879f7a2b08ecc8/BenchmarkDotNet.Artifacts

## Built With

c#
.NET5 Console App
BenchmarkDotNet 

## Getting Started


### Prerequisites

They are already in the solution.

*[Dotnet](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

*BenchmarkDotNet

```sh
dotnet add package BenchmarkDotNet --version 0.13.1
```

*System.net.Http

```sh
dotnet add package System.Net.Http --version 4.3.4
```

## Usage

```sh
dotnet run -c release
```


## Authors

* **YenXm** - ** - [YenXm](https://github.com/YenXm) - **


