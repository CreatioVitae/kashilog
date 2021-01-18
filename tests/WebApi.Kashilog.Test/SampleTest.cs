using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Xunit;

namespace WebApi.Kashilog.Test {
    public class SampleTest {
        [Fact]
        public void SampleTestCaseTrue() {
            var expect = true;

            Assert.True(expect);
        }

        [Fact]
        public void SampleTestCaseFalse() {
            var expect = false;

            Assert.False(expect);
        }
        [Fact]
        public void DatabaseConnectionTest() {
            int? count = null;
            try {
                var builder = new SqlConnectionStringBuilder {
                    // 本来は、appsettingで分離する。
                    DataSource = "host.docker.internal,15332",
                    UserID = "sa",
                    Password = "h0geFuga",
                    InitialCatalog = "KashiLogDB"
                };

                using (var connection = new SqlConnection(builder.ConnectionString)) {
                    connection.Open();
                    var sb = new StringBuilder();
                    sb.Append(@"SELECT COUNT(*) FROM kashi.MstProduct;");

                    using (var command = new SqlCommand(sb.ToString(), connection)) {
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                count = reader.GetInt32(0); ;
                            }

                            // Call Close when done reading.
                            reader.Close();

                        }
                    }
                }
            }
            catch (SqlException e) {
                Console.WriteLine(e.ToString());
            }
            Assert.Equal(0,count);
        }
    }
}
