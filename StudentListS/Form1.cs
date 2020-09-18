using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace StudentListS
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Student List";

            this.LvStudent.View = View.Details;
            this.LvStudent.Columns.Add("Student_ID", 200, HorizontalAlignment.Left);
            this.LvStudent.Columns.Add("Name", 200, HorizontalAlignment.Left);
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:
            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;
            // create a new database connection:
            sqlite_conn = new SQLiteConnection(ConnectSQLite.GetConnect());

            try
            {
                // open the connection:
                sqlite_conn.Open();
                // create a new SQL command:
                sqlite_cmd = sqlite_conn.CreateCommand();
                /*
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "CREATE TABLE Student (student_id integer not null primary key, name varchar(50) not null);";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
                // Lets insert something into our new table:
                sqlite_cmd.CommandText = "INSERT INTO Student (name) VALUES ('Natanael Castillo');";
                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
                // ...and inserting another line:
                sqlite_cmd.CommandText = "INSERT INTO Student (name) VALUES ('Veronica Martinez');";
                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO Student (name) VALUES ('Denisse Lara');";
                sqlite_cmd.ExecuteNonQuery();
                // But how do we read something out of our table ?
                // First lets build a SQL-Query again:
                */
                sqlite_cmd.CommandText = "SELECT student_id, name FROM Student";
                // Now the SQLiteCommand object can give us a DataReader-Object:
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                int id;
                ListViewItem lvi = null;
                string[] colText = new string[2];
                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    colText[0] = sqlite_datareader.GetString(0);
                    id = Int32.Parse(colText[0]);
                    colText[1] = sqlite_datareader.GetString(1);
                    lvi = new ListViewItem(colText, 0, Color.Black, Color.White, this.Font);
                    lvi.Tag = id;
                    LvStudent.Items.Add(lvi);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
                this.Text = ex.Message;
            }
            finally
            {
                // We are ready, now lets cleanup and close our connection:
                sqlite_conn.Close();
            }
        }
    }
}
