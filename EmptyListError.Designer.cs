
namespace Dinner_Picker
{
    partial class EmptyListError
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
            this.ErrorText = new System.Windows.Forms.Label();
            this.Okay_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorText
            // 
            this.ErrorText.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.Location = new System.Drawing.Point(0, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(408, 100);
            this.ErrorText.TabIndex = 0;
            this.ErrorText.Text = "The List doesn\'t have any Food in it. \r\nPlease put something in there \r\nfirst bef" +
    "ore attempting to do operations. \r\nYou should know better. I am ashamed. \r\n\r\n";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Okay_Button
            // 
            this.Okay_Button.Location = new System.Drawing.Point(129, 94);
            this.Okay_Button.Name = "Okay_Button";
            this.Okay_Button.Size = new System.Drawing.Size(134, 23);
            this.Okay_Button.TabIndex = 1;
            this.Okay_Button.Text = "Okay I\'m sorry. Chill man.";
            this.Okay_Button.UseVisualStyleBackColor = true;
            this.Okay_Button.Click += new System.EventHandler(this.Okay_Button_Click);
            // 
            // EmptyListError
            // 
            this.AcceptButton = this.Okay_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 123);
            this.Controls.Add(this.Okay_Button);
            this.Controls.Add(this.ErrorText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmptyListError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmptyListError";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Button Okay_Button;
    }
}