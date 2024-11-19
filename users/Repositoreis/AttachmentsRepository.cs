using Microsoft.Data.SqlClient;
using System.Data;
using users.Repositoreis;

namespace users.Repositories
{
    public class AttachmentsRepository : IAttachmentsRepository
    {
        private readonly string _cnn;

        public AttachmentsRepository(IConfiguration configuration)
        {
            _cnn = configuration.GetConnectionString("DefaultConnection");
        }

        public DataTable CreateAttachment(string name, string path, string dateUplode)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_cnn))
            {
                using (SqlCommand command = new SqlCommand("Add_Attachments", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@a_name", name));
                    command.Parameters.Add(new SqlParameter("@a_path", path));
                    command.Parameters.Add(new SqlParameter("@a_dateUplode", dateUplode));

                    connection.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
