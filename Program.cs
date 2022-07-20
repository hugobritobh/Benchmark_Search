using BenchmarkDotNet.Running;
using Common;

BenchmarkRunner.Run<BenchmarkSearchString>();

/*
 
num = 1000 

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1826 (21H1/May2021Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


|                 Method |         Mean |      Error |     StdDev | Allocated |
|----------------------- |-------------:|-----------:|-----------:|----------:|
|       ImmutArrayEquals |     8.649 ns |  0.2062 ns |  0.2752 ns |         - |
|        ImmutListEquals |    10.417 ns |  0.0701 ns |  0.0586 ns |         - |
|      ImmutSortedEquals |    10.474 ns |  0.0677 ns |  0.0633 ns |         - |
|             HashEquals |    10.516 ns |  0.1111 ns |  0.0985 ns |         - |
|             ListEquals |    10.542 ns |  0.0737 ns |  0.0690 ns |         - |
|           MemoryEquals |    12.198 ns |  0.0550 ns |  0.0515 ns |         - |
|           HashContains |    23.184 ns |  0.1890 ns |  0.1768 ns |         - |
|              ImmutHash |    47.463 ns |  0.3308 ns |  0.2933 ns |         - |
| MemorySpanBinarySearch |   613.435 ns |  4.5717 ns |  4.2764 ns |         - |
|            ImmutSorted |   629.101 ns |  3.4653 ns |  3.2415 ns |         - |
|               ImmutDic |   632.455 ns | 11.9824 ns | 12.8210 ns |         - |
|  ImmutListBinarySearch |   700.520 ns |  9.3610 ns |  8.7563 ns |         - |
|      MemorySpanIndexOf | 3,069.447 ns | 56.8375 ns | 44.3750 ns |         - |
|     ImmutArrayContains | 3,596.507 ns | 30.6399 ns | 28.6606 ns |         - |
|           ListContains | 3,764.300 ns | 34.6627 ns | 28.9449 ns |         - |
|      ImmutListContains | 8,969.920 ns | 58.4788 ns | 48.8325 ns |         - |


-----------------------------------------
num = 100000

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1826 (21H1/May2021Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


|                 Method |             Mean |          Error |         StdDev | Allocated |
|----------------------- |-----------------:|---------------:|---------------:|----------:|
|       ImmutArrayEquals |         8.814 ns |      0.1524 ns |      0.1272 ns |         - |
|        ImmutListEquals |        10.294 ns |      0.0710 ns |      0.0593 ns |         - |
|      ImmutSortedEquals |        10.461 ns |      0.1712 ns |      0.1429 ns |         - |
|             HashEquals |        10.710 ns |      0.0797 ns |      0.0707 ns |         - |
|             ListEquals |        11.002 ns |      0.2002 ns |      0.2806 ns |         - |
|           MemoryEquals |        12.479 ns |      0.0818 ns |      0.0639 ns |         - |
|           HashContains |        23.840 ns |      0.1843 ns |      0.1633 ns |         - |
|              ImmutHash |        63.876 ns |      0.1719 ns |      0.1435 ns |         - |
| MemorySpanBinarySearch |     1,183.218 ns |     10.9529 ns |     10.2453 ns |         - |
|            ImmutSorted |     1,214.298 ns |     18.5755 ns |     16.4667 ns |         - |
|               ImmutDic |     1,232.767 ns |      6.5507 ns |      5.8070 ns |         - |
|  ImmutListBinarySearch |     1,416.851 ns |     10.4123 ns |      9.2303 ns |         - |
|      MemorySpanIndexOf |   309,566.258 ns |  3,631.4166 ns |  3,396.8294 ns |         - |
|     ImmutArrayContains |   429,737.767 ns |  5,721.8307 ns |  4,777.9878 ns |         - |
|           ListContains |   434,542.913 ns |  4,676.9602 ns |  4,374.8315 ns |         - |
|      ImmutListContains | 1,205,374.596 ns | 13,344.1487 ns | 12,482.1250 ns |       1 B |

*/