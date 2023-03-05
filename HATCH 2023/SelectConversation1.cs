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
using System.IO;

namespace HATCH_2023
{
    public partial class SelectConversation1 : Form
    {
        public SelectConversation1()
        {
            InitializeComponent();

            SQLiteConnection sql_conn = Program.CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sql_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT Title FROM Documents WHERE 1 = 1;";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    selectTXT.Items.Add(sqlite_datareader.GetString(i));
                }
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectTXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTXT.Text = selectTXT.SelectedIndex.ToString();
        }

        private void selectBTN_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql_conn = Program.CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sql_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT location FROM Documents WHERE Title = '" + selectTXT.Text + "';";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            string path = sqlite_datareader.GetString(0);

            //Read file to byte array

            FileStream stream = File.OpenRead(path);
            byte[] fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            stream.Close();

            //Begins the process of writing the byte array back to a file

            using (Stream file = File.OpenWrite(@"C:\\Users\\amcge\\Downloads\\Check.docx"))
            {
                file.Write(fileBytes, 0, fileBytes.Length);
            }
        }
    }
}
