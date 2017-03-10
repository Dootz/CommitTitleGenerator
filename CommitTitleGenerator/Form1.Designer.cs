namespace CommitTitleGenerator
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
            this.Submit_BT = new System.Windows.Forms.Button();
            this.Quest_CB = new System.Windows.Forms.CheckBox();
            this.NPC_CB = new System.Windows.Forms.CheckBox();
            this.GO_CB = new System.Windows.Forms.CheckBox();
            this.Instance_CB = new System.Windows.Forms.CheckBox();
            this.Other_CB = new System.Windows.Forms.CheckBox();
            this.Other_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Specifier_TB = new System.Windows.Forms.TextBox();
            this.Author_TB = new System.Windows.Forms.TextBox();
            this.Desc_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_BT = new System.Windows.Forms.Button();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Number_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit_BT
            // 
            this.Submit_BT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Submit_BT.Location = new System.Drawing.Point(340, 200);
            this.Submit_BT.Name = "Submit_BT";
            this.Submit_BT.Size = new System.Drawing.Size(75, 23);
            this.Submit_BT.TabIndex = 0;
            this.Submit_BT.Text = "Submit";
            this.Submit_BT.UseVisualStyleBackColor = false;
            this.Submit_BT.Click += new System.EventHandler(this.Submit_BT_Click);
            // 
            // Quest_CB
            // 
            this.Quest_CB.AutoSize = true;
            this.Quest_CB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quest_CB.Location = new System.Drawing.Point(12, 52);
            this.Quest_CB.Name = "Quest_CB";
            this.Quest_CB.Size = new System.Drawing.Size(54, 17);
            this.Quest_CB.TabIndex = 1;
            this.Quest_CB.Text = "Quest";
            this.Quest_CB.UseVisualStyleBackColor = false;
            this.Quest_CB.CheckedChanged += new System.EventHandler(this.Quest_CB_CheckedChanged);
            // 
            // NPC_CB
            // 
            this.NPC_CB.AutoSize = true;
            this.NPC_CB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NPC_CB.Location = new System.Drawing.Point(12, 75);
            this.NPC_CB.Name = "NPC_CB";
            this.NPC_CB.Size = new System.Drawing.Size(48, 17);
            this.NPC_CB.TabIndex = 1;
            this.NPC_CB.Text = "NPC";
            this.NPC_CB.UseVisualStyleBackColor = false;
            this.NPC_CB.CheckedChanged += new System.EventHandler(this.NPC_CB_CheckedChanged);
            // 
            // GO_CB
            // 
            this.GO_CB.AutoSize = true;
            this.GO_CB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GO_CB.Location = new System.Drawing.Point(12, 98);
            this.GO_CB.Name = "GO_CB";
            this.GO_CB.Size = new System.Drawing.Size(83, 17);
            this.GO_CB.TabIndex = 1;
            this.GO_CB.Text = "Gameobject";
            this.GO_CB.UseVisualStyleBackColor = false;
            this.GO_CB.CheckedChanged += new System.EventHandler(this.GO_CB_CheckedChanged);
            // 
            // Instance_CB
            // 
            this.Instance_CB.AutoSize = true;
            this.Instance_CB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Instance_CB.Location = new System.Drawing.Point(12, 121);
            this.Instance_CB.Name = "Instance_CB";
            this.Instance_CB.Size = new System.Drawing.Size(67, 17);
            this.Instance_CB.TabIndex = 2;
            this.Instance_CB.Text = "Instance";
            this.Instance_CB.UseVisualStyleBackColor = false;
            this.Instance_CB.CheckedChanged += new System.EventHandler(this.Instance_CB_CheckedChanged);
            // 
            // Other_CB
            // 
            this.Other_CB.AutoSize = true;
            this.Other_CB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Other_CB.Location = new System.Drawing.Point(12, 144);
            this.Other_CB.Name = "Other_CB";
            this.Other_CB.Size = new System.Drawing.Size(52, 17);
            this.Other_CB.TabIndex = 3;
            this.Other_CB.Text = "Other";
            this.Other_CB.UseVisualStyleBackColor = false;
            this.Other_CB.CheckedChanged += new System.EventHandler(this.Other_CB_CheckedChanged);
            // 
            // Other_TB
            // 
            this.Other_TB.Location = new System.Drawing.Point(12, 167);
            this.Other_TB.Name = "Other_TB";
            this.Other_TB.Size = new System.Drawing.Size(123, 20);
            this.Other_TB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(181, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Specifier";
            // 
            // Specifier_TB
            // 
            this.Specifier_TB.Location = new System.Drawing.Point(184, 49);
            this.Specifier_TB.Name = "Specifier_TB";
            this.Specifier_TB.Size = new System.Drawing.Size(100, 20);
            this.Specifier_TB.TabIndex = 7;
            // 
            // Author_TB
            // 
            this.Author_TB.Location = new System.Drawing.Point(315, 49);
            this.Author_TB.Name = "Author_TB";
            this.Author_TB.Size = new System.Drawing.Size(100, 20);
            this.Author_TB.TabIndex = 8;
            this.Author_TB.Text = "Dootz";
            // 
            // Desc_TB
            // 
            this.Desc_TB.Location = new System.Drawing.Point(184, 95);
            this.Desc_TB.Name = "Desc_TB";
            this.Desc_TB.Size = new System.Drawing.Size(231, 20);
            this.Desc_TB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(312, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(181, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // Save_BT
            // 
            this.Save_BT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Save_BT.Location = new System.Drawing.Point(249, 200);
            this.Save_BT.Name = "Save_BT";
            this.Save_BT.Size = new System.Drawing.Size(75, 23);
            this.Save_BT.TabIndex = 12;
            this.Save_BT.Text = "Save";
            this.Save_BT.UseVisualStyleBackColor = false;
            this.Save_BT.Click += new System.EventHandler(this.Save_BT_Click);
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(12, 229);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.Size = new System.Drawing.Size(403, 20);
            this.Result_TB.TabIndex = 13;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Result.Location = new System.Drawing.Point(12, 213);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 13);
            this.Result.TabIndex = 14;
            this.Result.Text = "Result";
            // 
            // Number_TB
            // 
            this.Number_TB.Location = new System.Drawing.Point(184, 167);
            this.Number_TB.Name = "Number_TB";
            this.Number_TB.Size = new System.Drawing.Size(100, 20);
            this.Number_TB.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(181, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bug number (optional)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Number_TB);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.Save_BT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Desc_TB);
            this.Controls.Add(this.Author_TB);
            this.Controls.Add(this.Specifier_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Other_TB);
            this.Controls.Add(this.Other_CB);
            this.Controls.Add(this.Instance_CB);
            this.Controls.Add(this.GO_CB);
            this.Controls.Add(this.NPC_CB);
            this.Controls.Add(this.Quest_CB);
            this.Controls.Add(this.Submit_BT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit_BT;
        private System.Windows.Forms.CheckBox Quest_CB;
        private System.Windows.Forms.CheckBox NPC_CB;
        private System.Windows.Forms.CheckBox GO_CB;
        private System.Windows.Forms.CheckBox Instance_CB;
        private System.Windows.Forms.CheckBox Other_CB;
        private System.Windows.Forms.TextBox Other_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Specifier_TB;
        private System.Windows.Forms.TextBox Author_TB;
        private System.Windows.Forms.TextBox Desc_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save_BT;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Number_TB;
        private System.Windows.Forms.Label label5;
    }
}

