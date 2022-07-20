# Benchmark_Search
Qual estrutura de dados pesquisa mais rápido ? Which data structure searches faster?

.NET 6 - Windows

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1826 (21H1/May2021Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


|                 Method |         Mean |      Error |     StdDev |  Gen 0 | Allocated |
|----------------------- |-------------:|-----------:|-----------:|-------:|----------:|
|           HashContains |     23.01 ns |   0.141 ns |   0.132 ns |      - |         - |
|            DicContains |     23.99 ns |   0.418 ns |   0.326 ns |      - |         - |
|              ImmutHash |     46.21 ns |   0.548 ns |   0.486 ns |      - |         - |
|            ImmutSorted |    589.97 ns |   9.229 ns |   7.205 ns |      - |         - |
| ImmutSortedDicContains |    620.11 ns |   6.162 ns |   5.463 ns |      - |         - |
|  ImmutListBinarySearch |    661.63 ns |   3.305 ns |   2.930 ns |      - |         - |
| MemorySpanBinarySearch |    739.81 ns |  27.719 ns |  78.183 ns |      - |         - |
|      MemorySpanIndexOf |  3,046.30 ns |  22.449 ns |  19.901 ns |      - |         - |
|           ListContains |  3,601.54 ns |  32.839 ns |  27.422 ns |      - |         - |
|     ImmutArrayContains |  3,759.68 ns |  30.846 ns |  27.344 ns |      - |         - |
|      ImmutListContains |  8,975.55 ns | 113.464 ns | 100.583 ns |      - |         - |
|                ListAny |  9,493.77 ns | 127.848 ns | 113.334 ns | 0.0305 |     128 B |
|           ImmutListAny | 35,660.85 ns | 491.934 ns | 460.155 ns |      - |     160 B |
