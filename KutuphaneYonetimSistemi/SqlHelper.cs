using System;
using System.Data;
using System.Data.SqlClient;

namespace KutuphaneOtomasyonu
{
    public class SqlHelper
    {
        // DİKKAT: 'Data Source=.' kısmındaki nokta (.) yerel sunucuyu temsil eder.
        // Eğer bağlanamazsan buraya kendi sunucu adını yaz (Örn: DESKTOP-XYZ\SQLEXPRESS)
        private static string connectionString = @"Data Source=.\SQLEXPRESS ;Initial Catalog=KutuphaneDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Ekleme, Silme, Güncelleme işlemleri için
        public static void ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Veri Çekme (Select) işlemleri için
        public static DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}