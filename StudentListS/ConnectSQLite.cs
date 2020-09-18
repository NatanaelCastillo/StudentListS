using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Finisar.SQLite;

namespace StudentListS
{

    class ConnectSQLite
    {
        public static string GetConnect()
        {
            return "Data Source=student.db;Version=3;New=False;Compress=True;";
        }
    }
}
