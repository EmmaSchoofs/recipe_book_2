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
    public partial class FormRecipeView : SampleView
    {
        public FormRecipeView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select recipeId, recipeName, preparationTime, totalTime, numberOfPerson, ingredient, requirement, preparationMethod, r.categoryId, c.categoryName From Recipe r inner join Category c on c.categoryId = r.categoryId where recipeName like '%" + textSearch.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvpreparationtime);
            lb.Items.Add(dgvtotaltime);
            lb.Items.Add(dgvnumberofperson);
            lb.Items.Add(dgvingredient);
            lb.Items.Add(dgvrequirement);
            lb.Items.Add(dgvpreparationmethod);
            lb.Items.Add(dgvcategoryid);


            MainClass.LoadData(qry, dataGridView1, lb);
        }


        private void FormRecipeView_Load(object sender, EventArgs e)
        {
            GetData();

        }

        public  void textSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            FormRecipeAdd frm = new FormRecipeAdd();
            frm.ShowDialog();
            GetData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }
        public void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormRecipeAdd frm = new FormRecipeAdd();
            frm.ShowDialog();
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                FormRecipeAdd frm = new FormRecipeAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.textName.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.textPreparationTime.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvpreparationtime"].Value);
                frm.textTotalTime.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvtotaltime"].Value);
                frm.textNumberOfPersons.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvnumberofperson"].Value);
                frm.textIngredients.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvingredient"].Value);
                frm.textRequirements.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvrequirement"].Value);
                frm.textPreparationMethod.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvpreparationmethod"].Value);
                //frm.comboBoxCategory.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvcategory"].Value);
                frm.ShowDialog();
                GetData();
            }

            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                //confirm before delete
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from Recipe where recipeId= " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQLite(qry, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Deleted succesfully!");
                    GetData();
                }

            }
        }
    }
}
