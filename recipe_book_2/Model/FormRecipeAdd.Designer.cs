
namespace recipe_book_2.Model
{
    partial class FormRecipeAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPreparationTime = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelRequirements = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPreparationTime = new System.Windows.Forms.TextBox();
            this.textNumberOfPersons = new System.Windows.Forms.TextBox();
            this.textTotalTime = new System.Windows.Forms.TextBox();
            this.textRequirements = new System.Windows.Forms.TextBox();
            this.textIngredients = new System.Windows.Forms.TextBox();
            this.labelPreparationMethod = new System.Windows.Forms.Label();
            this.textPreparationMethod = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(850, 17);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(987, 76);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Size = new System.Drawing.Size(987, 71);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(242, 46);
            this.label1.Text = "Recipe Details";
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Invald cedentials";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(61, 109);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 23);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelPreparationTime
            // 
            this.labelPreparationTime.AutoSize = true;
            this.labelPreparationTime.Location = new System.Drawing.Point(288, 109);
            this.labelPreparationTime.Name = "labelPreparationTime";
            this.labelPreparationTime.Size = new System.Drawing.Size(138, 23);
            this.labelPreparationTime.TabIndex = 4;
            this.labelPreparationTime.Text = "Preparation time";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Location = new System.Drawing.Point(515, 109);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(85, 23);
            this.labelTotalTime.TabIndex = 5;
            this.labelTotalTime.Text = "Total time";
            this.labelTotalTime.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelRequirements
            // 
            this.labelRequirements.AutoSize = true;
            this.labelRequirements.Location = new System.Drawing.Point(61, 187);
            this.labelRequirements.Name = "labelRequirements";
            this.labelRequirements.Size = new System.Drawing.Size(115, 23);
            this.labelRequirements.TabIndex = 6;
            this.labelRequirements.Text = "Requirements";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(61, 374);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(90, 23);
            this.labelIngredients.TabIndex = 7;
            this.labelIngredients.Text = "Ingedients";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Number of Persons";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(65, 135);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(221, 30);
            this.textName.TabIndex = 11;
            // 
            // textPreparationTime
            // 
            this.textPreparationTime.Location = new System.Drawing.Point(292, 135);
            this.textPreparationTime.Name = "textPreparationTime";
            this.textPreparationTime.Size = new System.Drawing.Size(221, 30);
            this.textPreparationTime.TabIndex = 12;
            // 
            // textNumberOfPersons
            // 
            this.textNumberOfPersons.Location = new System.Drawing.Point(746, 135);
            this.textNumberOfPersons.Name = "textNumberOfPersons";
            this.textNumberOfPersons.Size = new System.Drawing.Size(221, 30);
            this.textNumberOfPersons.TabIndex = 13;
            // 
            // textTotalTime
            // 
            this.textTotalTime.Location = new System.Drawing.Point(519, 135);
            this.textTotalTime.Name = "textTotalTime";
            this.textTotalTime.Size = new System.Drawing.Size(221, 30);
            this.textTotalTime.TabIndex = 14;
            // 
            // textRequirements
            // 
            this.textRequirements.Location = new System.Drawing.Point(65, 213);
            this.textRequirements.Multiline = true;
            this.textRequirements.Name = "textRequirements";
            this.textRequirements.Size = new System.Drawing.Size(389, 151);
            this.textRequirements.TabIndex = 15;
            // 
            // textIngredients
            // 
            this.textIngredients.Location = new System.Drawing.Point(65, 400);
            this.textIngredients.Multiline = true;
            this.textIngredients.Name = "textIngredients";
            this.textIngredients.Size = new System.Drawing.Size(389, 160);
            this.textIngredients.TabIndex = 16;
            // 
            // labelPreparationMethod
            // 
            this.labelPreparationMethod.AutoSize = true;
            this.labelPreparationMethod.Location = new System.Drawing.Point(469, 187);
            this.labelPreparationMethod.Name = "labelPreparationMethod";
            this.labelPreparationMethod.Size = new System.Drawing.Size(164, 23);
            this.labelPreparationMethod.TabIndex = 17;
            this.labelPreparationMethod.Text = "Preparation method";
            // 
            // textPreparationMethod
            // 
            this.textPreparationMethod.Location = new System.Drawing.Point(473, 213);
            this.textPreparationMethod.Multiline = true;
            this.textPreparationMethod.Name = "textPreparationMethod";
            this.textPreparationMethod.Size = new System.Drawing.Size(494, 258);
            this.textPreparationMethod.TabIndex = 18;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(469, 504);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(79, 23);
            this.labelCategory.TabIndex = 19;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(473, 530);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(223, 31);
            this.comboBoxCategory.TabIndex = 21;
            // 
            // FormRecipeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 675);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textPreparationMethod);
            this.Controls.Add(this.labelPreparationMethod);
            this.Controls.Add(this.textIngredients);
            this.Controls.Add(this.textRequirements);
            this.Controls.Add(this.textTotalTime);
            this.Controls.Add(this.textNumberOfPersons);
            this.Controls.Add(this.textPreparationTime);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.labelRequirements);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelPreparationTime);
            this.Controls.Add(this.labelName);
            this.Name = "FormRecipeAdd";
            this.Text = "FormRecipeAdd";
            this.Load += new System.EventHandler(this.FormRecipeAdd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.labelPreparationTime, 0);
            this.Controls.SetChildIndex(this.labelTotalTime, 0);
            this.Controls.SetChildIndex(this.labelRequirements, 0);
            this.Controls.SetChildIndex(this.labelIngredients, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.Controls.SetChildIndex(this.textPreparationTime, 0);
            this.Controls.SetChildIndex(this.textNumberOfPersons, 0);
            this.Controls.SetChildIndex(this.textTotalTime, 0);
            this.Controls.SetChildIndex(this.textRequirements, 0);
            this.Controls.SetChildIndex(this.textIngredients, 0);
            this.Controls.SetChildIndex(this.labelPreparationMethod, 0);
            this.Controls.SetChildIndex(this.textPreparationMethod, 0);
            this.Controls.SetChildIndex(this.labelCategory, 0);
            this.Controls.SetChildIndex(this.comboBoxCategory, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPreparationTime;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelRequirements;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPreparationMethod;
        private System.Windows.Forms.Label labelCategory;
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.TextBox textPreparationTime;
        public System.Windows.Forms.TextBox textNumberOfPersons;
        public System.Windows.Forms.TextBox textTotalTime;
        public System.Windows.Forms.TextBox textRequirements;
        public System.Windows.Forms.TextBox textIngredients;
        public System.Windows.Forms.TextBox textPreparationMethod;
        public System.Windows.Forms.ComboBox comboBoxCategory;
    }
}