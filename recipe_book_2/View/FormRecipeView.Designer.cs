
namespace recipe_book_2.View
{
    partial class FormRecipeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpreparationmethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpreparationtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnumberofperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvrequirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvingredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(622, 94);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(618, 68);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(124, 41);
            this.label2.Text = "Recipes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvpreparationmethod,
            this.dgvid,
            this.dgvName,
            this.dgvpreparationtime,
            this.dgvtotaltime,
            this.dgvnumberofperson,
            this.dgvrequirement,
            this.dgvingredient,
            this.dgvcategoryid,
            this.dgvEdit,
            this.dgvdel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(36, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 368);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvpreparationmethod
            // 
            this.dgvpreparationmethod.HeaderText = "Preparation Method";
            this.dgvpreparationmethod.MinimumWidth = 6;
            this.dgvpreparationmethod.Name = "dgvpreparationmethod";
            this.dgvpreparationmethod.ReadOnly = true;
            this.dgvpreparationmethod.Width = 125;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            this.dgvid.Width = 125;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 125;
            // 
            // dgvpreparationtime
            // 
            this.dgvpreparationtime.HeaderText = "Preparation Time";
            this.dgvpreparationtime.MinimumWidth = 6;
            this.dgvpreparationtime.Name = "dgvpreparationtime";
            this.dgvpreparationtime.ReadOnly = true;
            this.dgvpreparationtime.Width = 125;
            // 
            // dgvtotaltime
            // 
            this.dgvtotaltime.HeaderText = "Total Time";
            this.dgvtotaltime.MinimumWidth = 6;
            this.dgvtotaltime.Name = "dgvtotaltime";
            this.dgvtotaltime.ReadOnly = true;
            this.dgvtotaltime.Width = 125;
            // 
            // dgvnumberofperson
            // 
            this.dgvnumberofperson.HeaderText = "Number Of Persons";
            this.dgvnumberofperson.MinimumWidth = 6;
            this.dgvnumberofperson.Name = "dgvnumberofperson";
            this.dgvnumberofperson.ReadOnly = true;
            this.dgvnumberofperson.Width = 125;
            // 
            // dgvrequirement
            // 
            this.dgvrequirement.HeaderText = "Requirement(s)";
            this.dgvrequirement.MinimumWidth = 6;
            this.dgvrequirement.Name = "dgvrequirement";
            this.dgvrequirement.ReadOnly = true;
            this.dgvrequirement.Width = 125;
            // 
            // dgvingredient
            // 
            this.dgvingredient.HeaderText = "Ingredient(s)";
            this.dgvingredient.MinimumWidth = 6;
            this.dgvingredient.Name = "dgvingredient";
            this.dgvingredient.ReadOnly = true;
            this.dgvingredient.Width = 125;
            // 
            // dgvcategoryid
            // 
            this.dgvcategoryid.HeaderText = "Category";
            this.dgvcategoryid.MinimumWidth = 6;
            this.dgvcategoryid.Name = "dgvcategoryid";
            this.dgvcategoryid.ReadOnly = true;
            this.dgvcategoryid.Width = 125;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 50F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::recipe_book_2.Properties.Resources.pen__1_;
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 50;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Width = 50;
            // 
            // dgvdel
            // 
            this.dgvdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvdel.FillWeight = 50F;
            this.dgvdel.HeaderText = "";
            this.dgvdel.Image = global::recipe_book_2.Properties.Resources.bin;
            this.dgvdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvdel.MinimumWidth = 50;
            this.dgvdel.Name = "dgvdel";
            this.dgvdel.ReadOnly = true;
            this.dgvdel.Width = 50;
            // 
            // FormRecipeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 530);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRecipeView";
            this.Text = "FormRecipeView";
            this.Load += new System.EventHandler(this.FormRecipeView_Load);
            this.Controls.SetChildIndex(this.textSearch, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpreparationmethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpreparationtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnumberofperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvrequirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvingredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcategoryid;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdel;
    }
}