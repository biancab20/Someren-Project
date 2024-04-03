namespace SomerenUI
{
    partial class CashRegister
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            backToMainAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backToMainAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            listViewStudents = new System.Windows.Forms.ListView();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            listViewDrinks = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader8 = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            CheckOut = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { backToMainAppToolStripMenuItem, backToMainAppToolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1351, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToMainAppToolStripMenuItem
            // 
            backToMainAppToolStripMenuItem.Name = "backToMainAppToolStripMenuItem";
            backToMainAppToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            backToMainAppToolStripMenuItem.Text = "Exit";
            backToMainAppToolStripMenuItem.Click += backToMainAppToolStripMenuItem_Click;
            // 
            // backToMainAppToolStripMenuItem1
            // 
            backToMainAppToolStripMenuItem1.Name = "backToMainAppToolStripMenuItem1";
            backToMainAppToolStripMenuItem1.Size = new System.Drawing.Size(170, 29);
            backToMainAppToolStripMenuItem1.Text = "Back To Main App";
            backToMainAppToolStripMenuItem1.Click += backToMainAppToolStripMenuItem1_Click;
            // 
            // listViewStudents
            // 
            listViewStudents.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            listViewStudents.CheckBoxes = true;
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader7, columnHeader5, columnHeader6 });
            listViewStudents.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listViewStudents.GridLines = true;
            listViewStudents.Location = new System.Drawing.Point(24, 103);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(590, 266);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            listViewStudents.ItemChecked += itemCheckStudents;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            columnHeader7.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Last Name";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "First Name";
            columnHeader6.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(256, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 36);
            label1.TabIndex = 2;
            label1.Text = "Students";
            // 
            // listViewDrinks
            // 
            listViewDrinks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            listViewDrinks.CheckBoxes = true;
            listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader8 });
            listViewDrinks.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            listViewDrinks.GridLines = true;
            listViewDrinks.Location = new System.Drawing.Point(621, 103);
            listViewDrinks.MultiSelect = false;
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(715, 266);
            listViewDrinks.TabIndex = 3;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            listViewDrinks.ItemChecked += itemCheckDrinks;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Drink Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Stock";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Non-/Alcoholic";
            columnHeader4.Width = 180;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Drink ID";
            columnHeader8.Width = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(941, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 36);
            label2.TabIndex = 4;
            label2.Text = "Drinks";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Red;
            button1.Location = new System.Drawing.Point(621, 391);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(178, 46);
            button1.TabIndex = 5;
            button1.Text = "Show Price";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Firebrick;
            label3.Location = new System.Drawing.Point(833, 408);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 29);
            label3.TabIndex = 6;
            label3.Text = "Price: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Firebrick;
            label4.Location = new System.Drawing.Point(961, 408);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 29);
            label4.TabIndex = 7;
            label4.Text = "0.00";
            // 
            // CheckOut
            // 
            CheckOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            CheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckOut.ForeColor = System.Drawing.Color.Red;
            CheckOut.Location = new System.Drawing.Point(285, 391);
            CheckOut.Name = "CheckOut";
            CheckOut.Size = new System.Drawing.Size(164, 44);
            CheckOut.TabIndex = 8;
            CheckOut.Text = "Check Out";
            CheckOut.UseVisualStyleBackColor = false;
            CheckOut.Click += CheckOut_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label5.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.OrangeRed;
            label5.Location = new System.Drawing.Point(479, 11);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(332, 83);
            label5.TabIndex = 9;
            label5.Text = "Cash Register";
            // 
            // CashRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1351, 468);
            Controls.Add(label5);
            Controls.Add(CheckOut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listViewDrinks);
            Controls.Add(label1);
            Controls.Add(listViewStudents);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CashRegister";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainAppToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem backToMainAppToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label5;
    }
}