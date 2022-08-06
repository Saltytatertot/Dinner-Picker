
namespace Dinner_Picker
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.GeneratedItems = new System.Windows.Forms.ListBox();
            this.FoodValues = new System.Windows.Forms.ListBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Random_Button = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenItem_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(125, 422);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 2;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // GeneratedItems
            // 
            this.GeneratedItems.FormattingEnabled = true;
            this.GeneratedItems.Location = new System.Drawing.Point(12, 12);
            this.GeneratedItems.Name = "GeneratedItems";
            this.GeneratedItems.Size = new System.Drawing.Size(188, 212);
            this.GeneratedItems.TabIndex = 3;
            this.GeneratedItems.SelectedIndexChanged += new System.EventHandler(this.Suggestion_SelectedIndexChanged);
            // 
            // FoodValues
            // 
            this.FoodValues.FormattingEnabled = true;
            this.FoodValues.Location = new System.Drawing.Point(206, 12);
            this.FoodValues.Name = "FoodValues";
            this.FoodValues.ScrollAlwaysVisible = true;
            this.FoodValues.Size = new System.Drawing.Size(225, 433);
            this.FoodValues.Sorted = true;
            this.FoodValues.TabIndex = 4;
            this.FoodValues.SelectedIndexChanged += new System.EventHandler(this.FoodValues_SelectedIndexChanged);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(12, 338);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit Item";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(125, 338);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete Item";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Random_Button
            // 
            this.Random_Button.Location = new System.Drawing.Point(66, 281);
            this.Random_Button.Name = "Random_Button";
            this.Random_Button.Size = new System.Drawing.Size(75, 23);
            this.Random_Button.TabIndex = 7;
            this.Random_Button.Text = "Random";
            this.Random_Button.UseVisualStyleBackColor = true;
            this.Random_Button.Click += new System.EventHandler(this.Random_Button_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AcceptsTab = true;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SearchBox.Location = new System.Drawing.Point(12, 472);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(419, 20);
            this.SearchBox.TabIndex = 8;
            this.SearchBox.Text = "Search...";
            this.SearchBox.AcceptsTabChanged += new System.EventHandler(this.SearchBox_AcceptsTabChanged);
            this.SearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchBox_MouseClick);
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(66, 230);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 9;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.AddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 508);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Random_Button);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.FoodValues);
            this.Controls.Add(this.GeneratedItems);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dinner Journal v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DinnerOperations_CLosing);
            this.Load += new System.EventHandler(this.DinnerOperations_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox GeneratedItems;
        public System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ListBox FoodValues;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Random_Button;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SelectButton;
    }
}

