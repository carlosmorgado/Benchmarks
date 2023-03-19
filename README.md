# Benchmarks

This repository contains a series of benchmarks.

You can learn more about the project from the project [Documentation](Documentation).

## Running

To run the project open a terminal in the root directory and run the following command.

`dotnet run -c Release -p .\{BenchmarkName} -f net5.0 -- --filter * --runtimes netcoreapp3.1 netcoreapp5.0 --exporters GitHub --memory --maxWidth 256`

If only one runtime is intended in `--runtimes` pass only the one intended.

The output can be fount in [BenchmarkDotNet.Artifacts](BenchmarkDotNet.Artifacts/results

## BenchmarkNames

 - StringBenchmarks


## Contributing

See [CONTRIBUTING.md](CONTRIBUTING.md) for information on contributing to this project.

This project has adopted the code of conduct defined by the [Contributor Covenant](http://contributor-covenant.org/) 
to clarify expected behavior in our community. For more information, see the [.NET Foundation Code of Conduct](http://www.dotnetfoundation.org/code-of-conduct).

## License

This project is licensed with the [MIT license](LICENSE).

## Related Projects

You should take a look at these related projects:

- [.NET Core](https://github.com/dotnet/core)
- [BenchmarkDotNet](https://benchmarkdotnet.org/)
