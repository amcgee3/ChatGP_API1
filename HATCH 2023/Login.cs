using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HATCH_2023
{
    public partial class Login : Form
    {
        public int myreader = 0;
        public string myreader2 = "";
        public Login()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.ShowDialog();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql_conn = Program.CreateConnection();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sql_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT count(*) FROM Users WHERE username = '" + userTXT.Text + "' and password = '" + passwordTXT.Text + "' ;";

            myreader = Convert.ToInt32(sqlite_cmd.ExecuteScalar());
            sql_conn.Close();

            sql_conn = Program.CreateConnection();
            sqlite_cmd = sql_conn.CreateCommand();
            SQLiteDataReader sqlite_datareader;
            sqlite_cmd.CommandText = "SELECT account_type FROM Users WHERE password ='" + passwordTXT.Text + "'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            myreader2 = sqlite_datareader.GetString(0);
            sql_conn.Close();

            if (myreader != 0)
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
