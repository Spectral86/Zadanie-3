namespace Zadanie_3
{
    partial class StudentDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImietextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoBox = new System.Windows.Forms.TextBox();
            this.NumerIndeksutextBox = new System.Windows.Forms.TextBox();
            this.okbutton = new System.Windows.Forms.Button();
            this.anulujbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numer Indeksu";
            // 
            // ImietextBox
            // 
            this.ImietextBox.Location = new System.Drawing.Point(150, 33);
            this.ImietextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImietextBox.Name = "ImietextBox";
            this.ImietextBox.Size = new System.Drawing.Size(214, 31);
            this.ImietextBox.TabIndex = 3;
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Location = new System.Drawing.Point(150, 113);
            this.NazwiskoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(214, 31);
            this.NazwiskoBox.TabIndex = 4;
            // 
            // NumerIndeksutextBox
            // 
            this.NumerIndeksutextBox.Location = new System.Drawing.Point(150, 180);
            this.NumerIndeksutextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumerIndeksutextBox.Name = "NumerIndeksutextBox";
            this.NumerIndeksutextBox.Size = new System.Drawing.Size(214, 31);
            this.NumerIndeksutextBox.TabIndex = 5;
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(17, 383);
            this.okbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(107, 38);
            this.okbutton.TabIndex = 6;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // anulujbutton
            // 
            this.anulujbutton.Location = new System.Drawing.Point(216, 383);
            this.anulujbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anulujbutton.Name = "anulujbutton";
            this.anulujbutton.Size = new System.Drawing.Size(107, 38);
            this.anulujbutton.TabIndex = 7;
            this.anulujbutton.Text = "Anuluj";
            this.anulujbutton.UseVisualStyleBackColor = true;
            this.anulujbutton.Click += new System.EventHandler(this.anulujbutton_Click);
            // 
            // StudentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 485);
            this.Controls.Add(this.anulujbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.NumerIndeksutextBox);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.ImietextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button okbutton;
        private Button anulujbutton;
        public TextBox ImietextBox;
        public TextBox NazwiskoBox;
        public TextBox NumerIndeksutextBox;
    }
}