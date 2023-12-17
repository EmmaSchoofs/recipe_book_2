
namespace recipe_book_2.Model
{
    partial class FormCategoryAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(228, 17);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 17);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(357, 76);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Size = new System.Drawing.Size(357, 71);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Size = new System.Drawing.Size(240, 46);
            this.label1.Text = "Add Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(24, 147);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(288, 30);
            this.textName.TabIndex = 0;
            // 
            // FormCategoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 297);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Name = "FormCategoryAdd";
            this.Text = "FormCategoryAdd";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textName, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textName;
    }
}