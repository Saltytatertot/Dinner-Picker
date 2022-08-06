
namespace Dinner_Picker
{
    partial class SubmitConfirm
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
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmLabel.Location = new System.Drawing.Point(40, 12);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(298, 57);
            this.ConfirmLabel.TabIndex = 0;
            this.ConfirmLabel.Text = "Label";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(88, 76);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(177, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SubmitConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 110);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ConfirmLabel);
            this.Name = "SubmitConfirm";
            this.Text = "You picked dinner!";
            this.Load += new System.EventHandler(this.SubmitConfirm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Button OKButton;
    }
}