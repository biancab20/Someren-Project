namespace SomerenUI
{
    partial class ActivitySupervisorsForm
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
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backToMainAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            listViewSupervisors = new System.Windows.Forms.ListView();
            ID = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            listViewNotSupervising = new System.Windows.Forms.ListView();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            listViewActivities = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            addBt = new System.Windows.Forms.Button();
            removeBt = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Gold;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem, backToMainAppToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1107, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // backToMainAppToolStripMenuItem
            // 
            backToMainAppToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            backToMainAppToolStripMenuItem.Name = "backToMainAppToolStripMenuItem";
            backToMainAppToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            backToMainAppToolStripMenuItem.Text = "Back to Main App";
            backToMainAppToolStripMenuItem.Click += backToMainAppToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Firebrick;
            label1.Location = new System.Drawing.Point(38, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(365, 28);
            label1.TabIndex = 1;
            label1.Text = "Teachers Who Supervise The Activity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Firebrick;
            label2.Location = new System.Drawing.Point(474, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(147, 32);
            label2.TabIndex = 2;
            label2.Text = "Activity List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Firebrick;
            label3.Location = new System.Drawing.Point(703, 60);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(377, 28);
            label3.TabIndex = 3;
            label3.Text = "Teachers Not Supervising The Activity";
            // 
            // listViewSupervisors
            // 
            listViewSupervisors.BackColor = System.Drawing.Color.Cornsilk;
            listViewSupervisors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ID, columnHeader3, columnHeader4 });
            listViewSupervisors.ForeColor = System.Drawing.Color.Firebrick;
            listViewSupervisors.FullRowSelect = true;
            listViewSupervisors.Location = new System.Drawing.Point(38, 100);
            listViewSupervisors.Name = "listViewSupervisors";
            listViewSupervisors.Size = new System.Drawing.Size(365, 326);
            listViewSupervisors.TabIndex = 4;
            listViewSupervisors.UseCompatibleStateImageBehavior = false;
            listViewSupervisors.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "First Name";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 1;
            columnHeader4.Text = "Last Name";
            columnHeader4.Width = 130;
            // 
            // listViewNotSupervising
            // 
            listViewNotSupervising.BackColor = System.Drawing.Color.Cornsilk;
            listViewNotSupervising.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader2, columnHeader5, columnHeader6 });
            listViewNotSupervising.ForeColor = System.Drawing.Color.Firebrick;
            listViewNotSupervising.FullRowSelect = true;
            listViewNotSupervising.Location = new System.Drawing.Point(703, 100);
            listViewNotSupervising.Name = "listViewNotSupervising";
            listViewNotSupervising.Size = new System.Drawing.Size(377, 326);
            listViewNotSupervising.TabIndex = 5;
            listViewNotSupervising.UseCompatibleStateImageBehavior = false;
            listViewNotSupervising.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID";
            columnHeader2.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 2;
            columnHeader5.Text = "First Name";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 1;
            columnHeader6.Text = "Last Name";
            columnHeader6.Width = 130;
            // 
            // listViewActivities
            // 
            listViewActivities.BackColor = System.Drawing.Color.Cornsilk;
            listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
            listViewActivities.ForeColor = System.Drawing.Color.Firebrick;
            listViewActivities.FullRowSelect = true;
            listViewActivities.Location = new System.Drawing.Point(409, 100);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(288, 326);
            listViewActivities.TabIndex = 6;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.View = System.Windows.Forms.View.Details;
            listViewActivities.SelectedIndexChanged += listViewActivities_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Activity Name";
            columnHeader1.Width = 240;
            // 
            // addBt
            // 
            addBt.BackColor = System.Drawing.Color.Cornsilk;
            addBt.ForeColor = System.Drawing.Color.Firebrick;
            addBt.Location = new System.Drawing.Point(832, 451);
            addBt.Name = "addBt";
            addBt.Size = new System.Drawing.Size(139, 37);
            addBt.TabIndex = 7;
            addBt.Text = "ADD";
            addBt.UseVisualStyleBackColor = false;
            addBt.Click += addBt_Click;
            // 
            // removeBt
            // 
            removeBt.BackColor = System.Drawing.Color.Cornsilk;
            removeBt.ForeColor = System.Drawing.Color.Firebrick;
            removeBt.Location = new System.Drawing.Point(147, 451);
            removeBt.Name = "removeBt";
            removeBt.Size = new System.Drawing.Size(126, 37);
            removeBt.TabIndex = 8;
            removeBt.Text = "REMOVE";
            removeBt.UseVisualStyleBackColor = false;
            removeBt.Click += removeBt_Click;
            // 
            // ActivitySupervisorsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gold;
            ClientSize = new System.Drawing.Size(1107, 500);
            Controls.Add(removeBt);
            Controls.Add(addBt);
            Controls.Add(listViewActivities);
            Controls.Add(listViewNotSupervising);
            Controls.Add(listViewSupervisors);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ActivitySupervisorsForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ListViewActivities_ItemSelectionChanged1(object sender, System.Windows.Forms.ListViewItemSelectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ListViewActivities_ItemSelectionChanged(object sender, System.Windows.Forms.ListViewItemSelectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainAppToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewSupervisors;
        private System.Windows.Forms.ListView listViewNotSupervising;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button removeBt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}