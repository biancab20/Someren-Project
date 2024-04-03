namespace SomerenUI
{
    partial class ModifyActivitiesForm
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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SaveModifications_btn = new System.Windows.Forms.Button();
            cancel_btn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(92, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(69, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(167, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(181, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(354, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(186, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(546, 102);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(161, 27);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(92, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 30);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(167, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 30);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(354, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(108, 30);
            label3.TabIndex = 6;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(546, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 30);
            label4.TabIndex = 7;
            label4.Text = "End Date";
            // 
            // SaveModifications_btn
            // 
            SaveModifications_btn.Location = new System.Drawing.Point(253, 166);
            SaveModifications_btn.Name = "SaveModifications_btn";
            SaveModifications_btn.Size = new System.Drawing.Size(118, 46);
            SaveModifications_btn.TabIndex = 8;
            SaveModifications_btn.Text = "Save";
            SaveModifications_btn.UseVisualStyleBackColor = true;
            SaveModifications_btn.Click += SaveModifications_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new System.Drawing.Point(422, 166);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new System.Drawing.Size(118, 46);
            cancel_btn.TabIndex = 9;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // ModifyActivitiesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(905, 260);
            Controls.Add(cancel_btn);
            Controls.Add(SaveModifications_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "ModifyActivitiesForm";
            Text = "ModifyActivitiesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveModifications_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}