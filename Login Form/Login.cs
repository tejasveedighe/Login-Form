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
            string Output = "";

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
                MessageBox.Show("Login Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDetails showDetails = new ShowDetails();
                showDetails.Show();
                textBox_password.Clear();
                textBox_userEmail.Clear();
            }
            else
            {
                MessageBox.Show("Login Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_password.Clear();
                textBox_userEmail.Clear();
                textBox_userEmail.Focus();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_password.Clear();
            textBox_userEmail.Clear();
            textBox_userEmail.Focus();
        }
    }
}
