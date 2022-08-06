
namespace Dinner_Picker
{
    partial class EditForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Tag1Box = new System.Windows.Forms.TextBox();
            this.Tag2Box = new System.Windows.Forms.TextBox();
            this.Tag3Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tag1Label = new System.Windows.Forms.Label();
            this.Tag2Label = new System.Windows.Forms.Label();
            this.Tag3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of the Dinner Item";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(294, 219);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Tag1Box
            // 
            this.Tag1Box.Location = new System.Drawing.Point(32, 157);
            this.Tag1Box.Name = "Tag1Box";
            this.Tag1Box.Size = new System.Drawing.Size(100, 20);
            this.Tag1Box.TabIndex = 1;
            // 
            // Tag2Box
            // 
            this.Tag2Box.Location = new System.Drawing.Point(152, 157);
            this.Tag2Box.Name = "Tag2Box";
            this.Tag2Box.Size = new System.Drawing.Size(100, 20);
            this.Tag2Box.TabIndex = 2;
            // 
            // Tag3Box
            // 
            this.Tag3Box.Location = new System.Drawing.Point(269, 157);
            this.Tag3Box.Name = "Tag3Box";
            this.Tag3Box.Size = new System.Drawing.Size(100, 20);
            this.Tag3Box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dinner Item Tags";
            // 
            // Tag1Label
            // 
            this.Tag1Label.AutoSize = true;
            this.Tag1Label.Location = new System.Drawing.Point(69, 141);
            this.Tag1Label.Name = "Tag1Label";
            this.Tag1Label.Size = new System.Drawing.Size(35, 13);
            this.Tag1Label.TabIndex = 8;
            this.Tag1Label.Text = "Tag 1";
            // 
            // Tag2Label
            // 
            this.Tag2Label.AutoSize = true;
            this.Tag2Label.Location = new System.Drawing.Point(183, 141);
            this.Tag2Label.Name = "Tag2Label";
            this.Tag2Label.Size = new System.Drawing.Size(35, 13);
            this.Tag2Label.TabIndex = 9;
            this.Tag2Label.Text = "Tag 2";
            // 
            // Tag3Label
            // 
            this.Tag3Label.AutoSize = true;
            this.Tag3Label.Location = new System.Drawing.Point(303, 141);
            this.Tag3Label.Name = "Tag3Label";
            this.Tag3Label.Size = new System.Drawing.Size(35, 13);
            this.Tag3Label.TabIndex = 10;
            this.Tag3Label.Text = "Tag 3";
            // 
            // EditForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 257);
            this.Controls.Add(this.Tag3Label);
            this.Controls.Add(this.Tag2Label);
            this.Controls.Add(this.Tag1Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tag3Box);
            this.Controls.Add(this.Tag2Box);
            this.Controls.Add(this.Tag1Box);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "EditForm";
            this.Text = "Edit Food Item";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox Tag1Box;
        private System.Windows.Forms.TextBox Tag2Box;
        private System.Windows.Forms.TextBox Tag3Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tag1Label;
        private System.Windows.Forms.Label Tag2Label;
        private System.Windows.Forms.Label Tag3Label;
    }
}