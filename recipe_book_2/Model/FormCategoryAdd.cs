using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_book_2.Model
{
    public partial class FormCategoryAdd : SampleAdd
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id ==0) //insert
            {
                qry = "Insert into Category (categoryName) Values(@Name)";
            }
            else //update
            {
                qry = "Update Category Set categoryName = @Name where categoryId = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textName.Text);

            if(MainClass.SQLite(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully!");
                id = 0;
                textName.Text = "";
                textName.Focus();
            }
        }
    }
}
