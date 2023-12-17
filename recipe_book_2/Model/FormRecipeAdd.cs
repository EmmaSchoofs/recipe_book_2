using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_book_2.Model
{
    public partial class FormRecipeAdd : SampleAdd
    {
        public FormRecipeAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int categoryId = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormRecipeAdd_Load(object sender, EventArgs e)
        {
            //For cb fill
            string qry = "Select categoryId 'id', categoryName 'name' from Category ";

            MainClass.CBFill(qry, comboBoxCategory);

            if(categoryId > 0) //for update
            {
                comboBoxCategory.SelectedValue = categoryId;
            }

            if(id > 0)
            {
                ForUpdateLoadData();
            }

        }

        public void btnSave_Click_1(object sender, EventArgs e)
        {
            string qry = "";
             if(id == 0) //insert
            {
                qry = "Insert into Recipe Values (null, @categoryId, @Name, @preparationTime, @totalTime, @numberOfPerson, @ingredient, @requirement, @preparationMethod)";
            }
             else //update
            {
                qry = "Update Recipe Set categoryId = @categoryId, recipeName = @Name, preparationTime = @preparationTime, totalTime = @totalTime, numberOfPerson = @numberOfPerson, ingredient = @ingredient, requirement = @requirement, preparationMethod = @preparationMethod where recipeId = @id";

                qry = "Update Recipe Set categoryId = @categoryId, recipeName = @Name, preparationTime = @preparationTime, totalTime = @totalTime, numberOfPerson = @numberOfPerson, ingredient = @ingredient, requirement = @requirement, preparationMethod = @preparationMethod where recipeId = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@categoryId", Convert.ToInt32(comboBoxCategory.SelectedValue));
            ht.Add("@Name", textName.Text);
            ht.Add("@preparationTime", textPreparationTime.Text);
            ht.Add("@totalTime", textTotalTime.Text);
            ht.Add("@numberOfPerson", textNumberOfPersons.Text);
            ht.Add("@ingredient", textIngredients.Text);
            ht.Add("@requirement", textRequirements.Text);
            ht.Add("@preparationMethod", textPreparationMethod.Text);

            
            if(MainClass.SQLite(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfully!");
                categoryId = 0;
                textName.Text = "";
                textPreparationTime.Text = "";
                textTotalTime.Text = "";
                textNumberOfPersons.Text = "";
                textIngredients.Text = "";
                textRequirements.Text = "";
                textPreparationMethod.Text = "";
                comboBoxCategory.SelectedIndex = -1;
                textName.Focus();

            }
        }

        private void ForUpdateLoadData()
        {
            string qry = @"Select * From Recipe where recipeId = " + id + "";
            SQLiteCommand cmd = new SQLiteCommand(qry, MainClass.con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count> 0)
            {
                textName.Text = dt.Rows[0]["recipeName"].ToString();
                textPreparationTime.Text = dt.Rows[0]["preparationTime"].ToString();
                textTotalTime.Text = dt.Rows[0]["totalTime"].ToString();
                textNumberOfPersons.Text = dt.Rows[0]["numberOfPerson"].ToString();
                textIngredients.Text = dt.Rows[0]["ingredient"].ToString();
                textRequirements.Text = dt.Rows[0]["requirement"].ToString();
                textPreparationMethod.Text = dt.Rows[0]["preparationMethod"].ToString();
            }
        }
    }
}
