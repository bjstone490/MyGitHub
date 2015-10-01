namespace CAZConsole
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
            this.textBox_Triggers = new System.Windows.Forms.TextBox();
            this.button_Init = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Done = new System.Windows.Forms.Button();
            this.button_UnSel = new System.Windows.Forms.Button();
            this.button_Browse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_New = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_NewMachine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Triggers
            // 
            this.textBox_Triggers.Location = new System.Drawing.Point(12, 12);
            this.textBox_Triggers.Name = "textBox_Triggers";
            this.textBox_Triggers.Size = new System.Drawing.Size(248, 20);
            this.textBox_Triggers.TabIndex = 2;
            this.textBox_Triggers.Text = "..\\..\\";
            this.textBox_Triggers.TextChanged += new System.EventHandler(this.textBox_Triggers_TextChanged);
            // 
            // button_Init
            // 
            this.button_Init.Location = new System.Drawing.Point(411, 12);
            this.button_Init.Name = "button_Init";
            this.button_Init.Size = new System.Drawing.Size(75, 23);
            this.button_Init.TabIndex = 1;
            this.button_Init.Text = "Init";
            this.button_Init.UseVisualStyleBackColor = true;
            this.button_Init.Click += new System.EventHandler(this.button_Init_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(384, 169);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(296, 12);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtension.TabIndex = 5;
            this.textBoxExtension.Text = "*_*";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(411, 68);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "Mark Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Done
            // 
            this.button_Done.Location = new System.Drawing.Point(411, 106);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(75, 23);
            this.button_Done.TabIndex = 7;
            this.button_Done.Text = "Mark Done";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // button_UnSel
            // 
            this.button_UnSel.Location = new System.Drawing.Point(411, 145);
            this.button_UnSel.Name = "button_UnSel";
            this.button_UnSel.Size = new System.Drawing.Size(75, 23);
            this.button_UnSel.TabIndex = 8;
            this.button_UnSel.Text = "UnSelect All";
            this.button_UnSel.UseVisualStyleBackColor = true;
            this.button_UnSel.Click += new System.EventHandler(this.button_UnSel_Click);
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(262, 12);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(28, 23);
            this.button_Browse.TabIndex = 9;
            this.button_Browse.Text = "...";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(411, 231);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 10;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 277);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(384, 122);
            this.textBox1.TabIndex = 4;
            // 
            // textBox_NewMachine
            // 
            this.textBox_NewMachine.Location = new System.Drawing.Point(12, 231);
            this.textBox_NewMachine.Name = "textBox_NewMachine";
            this.textBox_NewMachine.Size = new System.Drawing.Size(384, 20);
            this.textBox_NewMachine.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Use for copying text.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NewMachine);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.button_UnSel);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button_Init);
            this.Controls.Add(this.textBox_Triggers);
            this.Name = "Form1";
            this.Text = "CAZ Deploy Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Triggers;
        private System.Windows.Forms.Button button_Init;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button button_UnSel;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_NewMachine;
        private System.Windows.Forms.Label label2;
    }
}

