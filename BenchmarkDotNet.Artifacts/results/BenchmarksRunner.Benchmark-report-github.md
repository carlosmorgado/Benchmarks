``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22000.1696/21H2/SunValley)
AMD Ryzen 9 3900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK=7.0.300-preview.23122.5
  [Host]     : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2
  Job-LAMIWF : .NET 6.0.14 (6.0.1423.7309), X64 RyuJIT AVX2

Runtime=.NET 6.0  Toolchain=net60  

```
|                                                             Method |                                                            logger |     Mean |   Error |  StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------------------------------------------- |------------------------------------------------------------------ |---------:|--------:|--------:|------:|--------:|----------:|------------:|
|                                                     LogInformation | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 242.3 μs | 3.91 μs | 4.02 μs |  1.00 |    0.00 |     144 B |        1.00 |
|                                         LogInformationWithTemplate | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 237.8 μs | 4.61 μs | 4.31 μs |  0.98 |    0.02 |     144 B |        1.00 |
|                                     LoggerMessageWithLogNewEventId | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 238.8 μs | 3.76 μs | 3.33 μs |  0.99 |    0.02 |     152 B |        1.06 |
|                                LoggerMessageWithLogExistingEventId | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 239.8 μs | 4.40 μs | 4.12 μs |  0.99 |    0.02 |     152 B |        1.06 |
|                     LoggerMessageWithLogExistingEventIdAndTemplate | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 241.6 μs | 2.85 μs | 2.66 μs |  1.00 |    0.02 |     152 B |        1.06 |
|                 LogInformationWithParametersAndStringInterpolation | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 244.5 μs | 4.32 μs | 3.83 μs |  1.01 |    0.03 |     224 B |        1.56 |
|                              LogInformationWithParametersAndString | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 244.2 μs | 2.40 μs | 2.25 μs |  1.01 |    0.02 |     400 B |        2.78 |
|                  LogInformationWithParametersAndStringWithTemplate | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 239.6 μs | 3.87 μs | 3.23 μs |  0.99 |    0.01 |     400 B |        2.78 |
|                 LoggerMessageWithParametersAndStringWithNewEventId | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 241.5 μs | 4.73 μs | 4.42 μs |  1.00 |    0.03 |     352 B |        2.44 |
|            LoggerMessageWithParametersAndStringWithExistingEventId | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 240.2 μs | 4.55 μs | 4.26 μs |  0.99 |    0.03 |     352 B |        2.44 |
| LoggerMessageWithParametersAndStringWithExistingEventIdAndTemplate | Microsoft.Extensions.Logging.Logger`1[BenchmarksRunner.Benchmark] | 239.7 μs | 3.85 μs | 3.42 μs |  0.99 |    0.03 |     352 B |        2.44 |
