``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.867 (2004/?/20H1)
AMD Ryzen 9 3900X, 1 CPU, 24 logical and 12 physical cores
.NET Core SDK=5.0.201
  [Host]     : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT
  Job-BDGZRO : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  Job-BZEIXH : .NET Core 5.0.4 (CoreCLR 5.0.421.11614, CoreFX 5.0.421.11614), X64 RyuJIT


```
|                                           Method |        Job |       Runtime |     Toolchain | source |     Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------------------------------- |----------- |-------------- |-------------- |------- |---------:|---------:|---------:|------:|--------:|-------:|-------:|------:|----------:|
|         ToStringWithStringInterpolationAndConcat | Job-BDGZRO | .NET Core 3.1 | netcoreapp3.1 |      1 | 423.9 ns |  3.68 ns |  3.44 ns |  1.00 |    0.00 | 0.0849 |      - |     - |     712 B |
| ToStringWithStringInterpolationAndConcatNoBoxing | Job-BDGZRO | .NET Core 3.1 | netcoreapp3.1 |      1 | 208.2 ns |  3.34 ns |  2.79 ns |  0.49 |    0.01 | 0.0715 |      - |     - |     600 B |
|                  ToStringWithStringInterpolation | Job-BDGZRO | .NET Core 3.1 | netcoreapp3.1 |      1 | 780.7 ns |  6.72 ns |  6.29 ns |  1.84 |    0.03 | 0.0648 |      - |     - |     544 B |
|          ToStringWithStringInterpolationNoBoxing | Job-BDGZRO | .NET Core 3.1 | netcoreapp3.1 |      1 | 208.7 ns |  3.97 ns |  3.72 ns |  0.49 |    0.01 | 0.0715 |      - |     - |     600 B |
|                        ToStringWithStringBuilder | Job-BDGZRO | .NET Core 3.1 | netcoreapp3.1 |      1 | 347.9 ns |  4.96 ns |  4.40 ns |  0.82 |    0.01 | 0.1516 | 0.0005 |     - |    1272 B |
|         ToStringWithStringInterpolationAndConcat | Job-BZEIXH | .NET Core 5.0 | netcoreapp5.0 |      1 | 322.8 ns |  3.73 ns |  3.31 ns |  0.76 |    0.01 | 0.0849 |      - |     - |     712 B |
| ToStringWithStringInterpolationAndConcatNoBoxing | Job-BZEIXH | .NET Core 5.0 | netcoreapp5.0 |      1 | 183.6 ns |  2.50 ns |  2.34 ns |  0.43 |    0.01 | 0.0715 |      - |     - |     600 B |
|                  ToStringWithStringInterpolation | Job-BZEIXH | .NET Core 5.0 | netcoreapp5.0 |      1 | 595.0 ns | 10.87 ns | 10.17 ns |  1.40 |    0.03 | 0.0648 |      - |     - |     544 B |
|          ToStringWithStringInterpolationNoBoxing | Job-BZEIXH | .NET Core 5.0 | netcoreapp5.0 |      1 | 182.9 ns |  1.72 ns |  1.61 ns |  0.43 |    0.00 | 0.0715 |      - |     - |     600 B |
|                        ToStringWithStringBuilder | Job-BZEIXH | .NET Core 5.0 | netcoreapp5.0 |      1 | 334.6 ns |  6.69 ns |  9.80 ns |  0.79 |    0.03 | 0.1516 | 0.0005 |     - |    1272 B |
