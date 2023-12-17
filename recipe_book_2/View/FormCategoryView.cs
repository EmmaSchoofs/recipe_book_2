using recipe_book_2.Model;
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

namespace recipe_book_2.View
{
    public partial class FormCategoryView : SampleView
    {
        public FormCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * From Category where categoryName like '%"+ textSearch.Text +"%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(qry, dataGridView1, lb);
        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAdd frm = new FormCategoryAdd();
            frm.ShowDialog();
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FormCategoryAdd frm = new FormCategoryAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.textName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from category where categoryId= " + id + "";
                Hashtable ht = new Hashtable();
                MainClass.SQLite(qry, ht);

                MessageBox.Show("Deleted succesfully!");
                GetData();
            }
        }
    }
}
