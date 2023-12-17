using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using recipe_book_2.Model;

namespace recipe_book_2
{
    class MainClass
    {
        public static readonly string con_string = "Data Source= ../../Files/batabase_recipe_book_2.db;";
        public static SQLiteConnection con = new SQLiteConnection(con_string);

        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            string qry = @"Select * from user where username ='" + username + "' and password = '" + password + "' ";
            SQLiteCommand cmd = new SQLiteCommand(qry, con);
            using (DataTable dt = new DataTable())
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    USER = dt.Rows[0]["username"].ToString();
                }
            }
            return isValid;
        }

        //property for username

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        // method for crud operation

        public static int SQLite(string qry, Hashtable ht)
        {
            int res = 0;
            
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nQuery: " + qry);
                con.Close();
            }

            return res;
        }

        internal static void BlurBackground(FormRecipeAdd formRecipeAdd)
        {

        }

        //for loading data from database

        public static void LoadData(string qry , DataGridView gv, ListBox lb)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nQuery: " + qry);
                con.Close();
            }
        }

        //For cb fill

        public static void CBFill(string qry, ComboBox cb)
        {
            SQLiteCommand cmd = new SQLiteCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
