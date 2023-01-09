namespace Zadanie_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Przycisk = new System.Windows.Forms.Button();
            this.kobieta = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Przycisk
            // 
            this.Przycisk.AccessibleDescription = " Przycisk";
            this.Przycisk.AccessibleName = "Przycisk";
            this.Przycisk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Przycisk.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Przycisk.Location = new System.Drawing.Point(221, 114);
            this.Przycisk.Name = "Przycisk";
            this.Przycisk.Size = new System.Drawing.Size(135, 88);
            this.Przycisk.TabIndex = 0;
            this.Przycisk.Text = "Przycisk";
            this.Przycisk.UseVisualStyleBackColor = false;
            this.Przycisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // kobieta
            // 
            this.kobieta.AutoSize = true;
            this.kobieta.Location = new System.Drawing.Point(28, 296);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(65, 19);
            this.kobieta.TabIndex = 1;
            this.kobieta.Text = "kobieta";
            this.kobieta.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Warszawa",
            "Kraków",
            "Szczecin"});
            this.checkedListBox1.Location = new System.Drawing.Point(607, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Warszawa",
            "Wrocław",
            "Gdańsk"});
            this.listBox1.Location = new System.Drawing.Point(55, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.kobieta);
            this.Controls.Add(this.Przycisk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Przycisk;
        private CheckBox kobieta;
        private CheckedListBox checkedListBox1;
        private ColorDialog colorDialog1;
        private Label label1;
        private ListBox listBox1;
    }
}