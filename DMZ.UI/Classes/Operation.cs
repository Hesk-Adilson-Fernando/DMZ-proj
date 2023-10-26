using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMZ.UI.Classes
{
    internal class Operation
    {
        public string ipconfig(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);
            string text = streamReader.ReadToEnd();
            streamReader.Close();
            return text;
        }

        public void Execute(string SQL)
        {
            //SqlConnection con = Main.GetDBConnection();
            //con.Open();
            //SqlCommand cmd = new SqlCommand(SQL, con);
            //cmd.ExecuteNonQuery();
        }
    }
}
