# Benchmark_Search
Qual estrutura de dados pesquisa mais rápido ? Which data structure searches faster?

.NET 6 - Windows

|                 Method |         Mean |      Error |     StdDev |       Median |  Gen 0 | Allocated |
|----------------------- |-------------:|-----------:|-----------:|-------------:|-------:|----------:|
|           HashContains |     23.29 ns |   0.490 ns |   0.409 ns |     23.08 ns |      - |         - |
|              ImmutHash |     46.14 ns |   0.843 ns |   0.704 ns |     45.88 ns |      - |         - |
| MemorySpanBinarySearch |    628.04 ns |   5.353 ns |   5.007 ns |    627.23 ns |      - |         - |
|               ImmutDic |    668.97 ns |  11.958 ns |  18.967 ns |    662.60 ns |      - |         - |
|  ImmutListBinarySearch |    689.02 ns |  10.970 ns |  12.633 ns |    686.23 ns |      - |         - |
|            ImmutSorted |    689.14 ns |   7.126 ns |   6.665 ns |    688.52 ns |      - |         - |
|      MemorySpanIndexOf |  3,247.42 ns | 110.774 ns | 316.045 ns |  3,095.50 ns |      - |         - |
|     ImmutArrayContains |  3,619.14 ns |  68.539 ns |  67.314 ns |  3,606.90 ns |      - |         - |
|           ListContains |  3,774.16 ns |  64.205 ns |  73.939 ns |  3,736.42 ns |      - |         - |
|      ImmutListContains |  8,866.64 ns |  71.787 ns |  67.150 ns |  8,837.80 ns |      - |         - |
|                ListAny |  9,678.05 ns | 145.869 ns | 136.446 ns |  9,625.16 ns | 0.0305 |     128 B |
|           ImmutListAny | 34,776.05 ns | 309.655 ns | 274.501 ns | 34,900.43 ns |      - |     160 B |
