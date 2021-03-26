using StringBenchmarks;

namespace BenchmarksRunner
{
    public class DbConnectionStringSource
    {
        public DbConnectionString DbConnectionString { get; set; }

        public string Tag { get; set; }

        public override string ToString() => this.Tag;
    }
}
