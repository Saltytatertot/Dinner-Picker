
namespace Dinner_Picker
{
    partial class Delete_Item
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.areYouSureDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(239, 82);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(76, 82);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 0;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // areYouSureDelete
            // 
            this.areYouSureDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.areYouSureDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areYouSureDelete.Location = new System.Drawing.Point(0, 0);
            this.areYouSureDelete.Name = "areYouSureDelete";
            this.areYouSureDelete.Size = new System.Drawing.Size(387, 48);
            this.areYouSureDelete.TabIndex = 2;
            this.areYouSureDelete.Text = "Are you sure you want to \r\ndelete ";
            this.areYouSureDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Delete_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 115);
            this.Controls.Add(this.areYouSureDelete);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Cancel_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Delete_Item";
            this.Text = "Delete Item";
            this.Load += new System.EventHandler(this.Delete_Item_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Label areYouSureDelete;
    }
}