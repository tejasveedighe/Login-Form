using System.Data.SqlClient;
using System.Data;
namespace Login_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=SQL12-16-LATEST\SQL2016;Initial Catalog=SNW;Persist Security Info=True;User ID=nagesh;Password=Download@1");

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = textBox_userEmail.Text;
            string password = textBox_password.Text;

            SqlCommand command = new SqlCommand("SELECT * FROM LpUser where Email=@UserEmail and Password = @Password", conn);

            command.Parameters.AddWithValue("@UserEmail", username);
            command.Parameters.AddWithValue("@Password", password);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Open();
            int i = command.ExecuteNonQuery();
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                textBox_password.Clear();
                textBox_userEmail.Clear();
            }
            else
            {
                MessageBox.Show("Login Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_password.Clear();
                textBox_userEmail.Clear();
            }


        }
    }
}
