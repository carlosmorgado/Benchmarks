using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchmarksRunner
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        public IEnumerable<DbConnectionStringSource> Sources()
        {
            yield return new DbConnectionStringSource
            {
                Tag = "1",
                DbConnectionString = new StringBenchmarks.DbConnectionString
                {
                    ApplicationIntent = "ApplicationIntent",
                    ConnectTimeout = 1,
                    Port = 8080,
                    Database = "Database",
                    DbInstanceIdentifier = "DbInstanceIdentifier",
                    Encrypt = "Encrypt",
                    Engine = "Engine",
                    Host = "Host",
                    IntegratedSecurity = "IntegratedSecurity",
                    MultiSubnetFailover = "MultiSubnetFailover",
                    Password = "Password",
                    TrustServerCertificate = "TrustServerCertificate",
                    Username = "Username"
                }
            };
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Sources))]
        public string ToStringWithStringInterpolationAndConcat(DbConnectionStringSource source)
        {
            return source.DbConnectionString.ToStringWithStringInterpolationAndConcat();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Sources))]
        public string ToStringWithStringInterpolationAndConcatNoBoxing(DbConnectionStringSource source)
        {
            return source.DbConnectionString.ToStringWithStringInterpolationAndConcatNoBoxing();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Sources))]
        public string ToStringWithStringInterpolation(DbConnectionStringSource source)
        {
            return source.DbConnectionString.ToStringWithStringInterpolation();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Sources))]
        public string ToStringWithStringInterpolationNoBoxing(DbConnectionStringSource source)
        {
            return source.DbConnectionString.ToStringWithStringInterpolationNoBoxing();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Sources))]
        public string ToStringWithStringBuilder(DbConnectionStringSource source)
        {
            return source.DbConnectionString.ToStringWithStringBuilder();
        }
    }
}
