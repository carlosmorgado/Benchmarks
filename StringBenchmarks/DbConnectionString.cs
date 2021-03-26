using System.Text;

namespace StringBenchmarks
{
    public class DbConnectionString
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string Engine { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string DbInstanceIdentifier { get; set; }
        public string Encrypt { get; set; }
        public string TrustServerCertificate { get; set; }
        public string IntegratedSecurity { get; set; }
        public string MultiSubnetFailover { get; set; }
        public string ApplicationIntent { get; set; }
        public int ConnectTimeout { get; set; }

        public string ToStringWithStringInterpolationAndConcat()
        {
            var connectionString = $"Server={this.Host};" +
                                   $"Port={this.Port};" +
                                   $"Database={this.Database};" +
                                   $"Integrated Security={this.IntegratedSecurity ?? "True"};" +
                                   $"User ID={this.Username};" +
                                   $"Password={this.Password};" +
                                   $"Timeout={(this.ConnectTimeout > 0 ? this.ConnectTimeout : 15)};" +
                                   $"SSL Mode={this.Encrypt ?? "Require"};" +
                                   $"Trust Server Certificate={this.TrustServerCertificate ?? "True"}" +
                                   //$"TrustServerCertificate={trustServerCertificate};" +
                                   //$"ApplicationIntent={applicationIntent};" +
                                   //$"MultiSubnetFailover={multiSubnetFailover}"
                                   "";

            return connectionString;
        }

        public string ToStringWithStringInterpolationAndConcatNoBoxing()
        {
            var connectionString = $"Server={this.Host};" +
                                   $"Port={this.Port.ToString()};" +
                                   $"Database={this.Database};" +
                                   $"Integrated Security={this.IntegratedSecurity ?? "True"};" +
                                   $"User ID={this.Username};" +
                                   $"Password={this.Password};" +
                                   $"Timeout={(this.ConnectTimeout > 0 ? this.ConnectTimeout.ToString() : "15")};" +
                                   $"SSL Mode={this.Encrypt ?? "Require"};" +
                                   $"Trust Server Certificate={this.TrustServerCertificate ?? "True"}";

            return connectionString;
        }

        public string ToStringWithStringInterpolation()
        {
            var connectionString = $"Server={this.Host};Port={this.Port};Database={this.Database};Integrated Security={this.IntegratedSecurity ?? "True"};User ID={this.Username};Password={this.Password};Timeout={(this.ConnectTimeout > 0 ? this.ConnectTimeout : 15)};SSL Mode={this.Encrypt ?? "Require"};Trust Server Certificate={this.TrustServerCertificate ?? "True"}";

            return connectionString;
        }

        public string ToStringWithStringInterpolationNoBoxing()
        {
            var connectionString = $"Server={this.Host};Port={this.Port.ToString()};Database={this.Database};Integrated Security={this.IntegratedSecurity ?? "True"};User ID={this.Username};Password={this.Password};Timeout={(this.ConnectTimeout > 0 ? this.ConnectTimeout.ToString() : "15")};SSL Mode={this.Encrypt ?? "Require"};Trust Server Certificate={this.TrustServerCertificate ?? "True"}";

            return connectionString;
        }

        public string ToStringWithStringBuilder()
        {
            var connectionString = new StringBuilder()
                .Append("Server=").Append(this.Host)
                .Append(";Port=").Append(this.Port)
                .Append(";Database=").Append(this.Database)
                .Append(";Integrated Security=").Append(this.IntegratedSecurity ?? "True")
                .Append(";User ID=").Append(this.Username)
                .Append(";Password=").Append(this.Password)
                .Append(";Timeout=").Append(this.ConnectTimeout > 0 ? this.ConnectTimeout : 15)
                .Append(";SSL Mode=").Append(this.Encrypt ?? "Require")
                .Append(";Trust Server Certificate=").Append(this.TrustServerCertificate ?? "True")
                .ToString();

            return connectionString;
        }
    }
}
