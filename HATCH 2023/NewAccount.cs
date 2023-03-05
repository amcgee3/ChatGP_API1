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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void welcomeIMG_Click(object sender, EventArgs e)
        {

        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            SQLiteCommand sqlite_cmd;
            SQLiteConnection sql_conn = Program.CreateConnection();
            sqlite_cmd = sql_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Users(username, password, first_name, last_name, account_type) VALUES ('" + userTXT.Text + "', '" + passwordTXT.Text + "', '" + firstTXT.Text + "', '" + lastTXT.Text + "', '" + typeTXT.Text + "' );";
            sqlite_cmd.ExecuteNonQuery();
            sql_conn.Close();
            MessageBox.Show("Account Created Successfully.");
            this.Close();
        }

        private void typeTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeTXT.Text = typeTXT.SelectedIndex.ToString();
        }
    }
    
}
