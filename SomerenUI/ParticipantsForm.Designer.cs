namespace SomerenUI
{
    partial class ParticipantsForm
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
            SPinactivity = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            Activitylist = new System.Windows.Forms.ListView();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SPnotinactivity = new System.Windows.Forms.ListView();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();
            // 
            // SPinactivity
            // 
            SPinactivity.BackColor = System.Drawing.Color.Bisque;
            SPinactivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            SPinactivity.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            SPinactivity.ForeColor = System.Drawing.Color.Maroon;
            SPinactivity.FullRowSelect = true;
            SPinactivity.Location = new System.Drawing.Point(11, 45);
            SPinactivity.Margin = new System.Windows.Forms.Padding(4);
            SPinactivity.Name = "SPinactivity";
            SPinactivity.Size = new System.Drawing.Size(449, 309);
            SPinactivity.TabIndex = 0;
            SPinactivity.UseCompatibleStateImageBehavior = false;
            SPinactivity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Last name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "First name";
            columnHeader3.Width = 150;
            // 
            // Activitylist
            // 
            Activitylist.BackColor = System.Drawing.Color.Bisque;
            Activitylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader7 });
            Activitylist.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            Activitylist.ForeColor = System.Drawing.Color.Maroon;
            Activitylist.FullRowSelect = true;
            Activitylist.Location = new System.Drawing.Point(468, 45);
            Activitylist.Margin = new System.Windows.Forms.Padding(4);
            Activitylist.Name = "Activitylist";
            Activitylist.Size = new System.Drawing.Size(348, 309);
            Activitylist.TabIndex = 1;
            Activitylist.UseCompatibleStateImageBehavior = false;
            Activitylist.View = System.Windows.Forms.View.Details;
            Activitylist.SelectedIndexChanged += Activitylist_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Activity name";
            columnHeader7.Width = 500;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.AliceBlue;
            button1.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Maroon;
            button1.Location = new System.Drawing.Point(343, 363);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 36);
            button1.TabIndex = 3;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.AliceBlue;
            button2.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Maroon;
            button2.Location = new System.Drawing.Point(824, 363);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(118, 36);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Maroon;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(356, 30);
            label1.TabIndex = 5;
            label1.Text = "Students participating in the activity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Maroon;
            label2.Location = new System.Drawing.Point(468, 11);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 30);
            label2.TabIndex = 6;
            label2.Text = "Activity list";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Maroon;
            label3.Location = new System.Drawing.Point(824, 11);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(394, 30);
            label3.TabIndex = 7;
            label3.Text = "Students not participating in the activity";
            // 
            // SPnotinactivity
            // 
            SPnotinactivity.BackColor = System.Drawing.Color.Bisque;
            SPnotinactivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            SPnotinactivity.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            SPnotinactivity.ForeColor = System.Drawing.Color.Maroon;
            SPnotinactivity.FullRowSelect = true;
            SPnotinactivity.Location = new System.Drawing.Point(824, 45);
            SPnotinactivity.Margin = new System.Windows.Forms.Padding(4);
            SPnotinactivity.Name = "SPnotinactivity";
            SPnotinactivity.Size = new System.Drawing.Size(495, 309);
            SPnotinactivity.TabIndex = 2;
            SPnotinactivity.UseCompatibleStateImageBehavior = false;
            SPnotinactivity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Last name";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "First name";
            columnHeader6.Width = 150;
            // 
            // ParticipantsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lavender;
            ClientSize = new System.Drawing.Size(1331, 406);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SPnotinactivity);
            Controls.Add(Activitylist);
            Controls.Add(SPinactivity);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ParticipantsForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView SPinactivity;
        private System.Windows.Forms.ListView Activitylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView SPnotinactivity;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}