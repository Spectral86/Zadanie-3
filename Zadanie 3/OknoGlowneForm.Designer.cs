namespace Zadanie_3
{
    partial class OknoGlowneForm
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
            this.StudenciDataGridView = new System.Windows.Forms.DataGridView();
            this.ImieCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usunbutton = new System.Windows.Forms.Button();
            this.dodajbutton = new System.Windows.Forms.Button();
            this.Nazwiskotextbox = new System.Windows.Forms.TextBox();
            this.Imietextbox = new System.Windows.Forms.TextBox();
            this.Nazwiskolabel = new System.Windows.Forms.Label();
            this.Imielabel = new System.Windows.Forms.Label();
            this.Edycja_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudenciDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudenciDataGridView
            // 
            this.StudenciDataGridView.AllowUserToAddRows = false;
            this.StudenciDataGridView.AllowUserToOrderColumns = true;
            this.StudenciDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudenciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudenciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImieCol1,
            this.NazwiskoCol,
            this.IndexCol});
            this.StudenciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudenciDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StudenciDataGridView.Name = "StudenciDataGridView";
            this.StudenciDataGridView.RowHeadersVisible = false;
            this.StudenciDataGridView.RowHeadersWidth = 62;
            this.StudenciDataGridView.RowTemplate.Height = 33;
            this.StudenciDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudenciDataGridView.Size = new System.Drawing.Size(766, 391);
            this.StudenciDataGridView.TabIndex = 1;
            this.StudenciDataGridView.SelectionChanged += new System.EventHandler(this.StudenciDataGridView_SelectionChanged);
            // 
            // ImieCol1
            // 
            this.ImieCol1.DataPropertyName = "Imie";
            this.ImieCol1.HeaderText = "Imię";
            this.ImieCol1.MinimumWidth = 8;
            this.ImieCol1.Name = "ImieCol1";
            this.ImieCol1.ReadOnly = true;
            // 
            // NazwiskoCol
            // 
            this.NazwiskoCol.DataPropertyName = "Nazwisko";
            this.NazwiskoCol.HeaderText = "Nazwisko";
            this.NazwiskoCol.MinimumWidth = 8;
            this.NazwiskoCol.Name = "NazwiskoCol";
            this.NazwiskoCol.ReadOnly = true;
            // 
            // IndexCol
            // 
            this.IndexCol.DataPropertyName = "IndexNumber";
            this.IndexCol.HeaderText = "Numer Indeksu";
            this.IndexCol.MinimumWidth = 8;
            this.IndexCol.Name = "IndexCol";
            this.IndexCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Edycja_button);
            this.panel1.Controls.Add(this.usunbutton);
            this.panel1.Controls.Add(this.dodajbutton);
            this.panel1.Controls.Add(this.Nazwiskotextbox);
            this.panel1.Controls.Add(this.Imietextbox);
            this.panel1.Controls.Add(this.Nazwiskolabel);
            this.panel1.Controls.Add(this.Imielabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 150);
            this.panel1.TabIndex = 2;
            // 
            // usunbutton
            // 
            this.usunbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usunbutton.Location = new System.Drawing.Point(471, 59);
            this.usunbutton.Name = "usunbutton";
            this.usunbutton.Size = new System.Drawing.Size(112, 34);
            this.usunbutton.TabIndex = 5;
            this.usunbutton.Text = "Usuń";
            this.usunbutton.UseVisualStyleBackColor = true;
            this.usunbutton.Click += new System.EventHandler(this.usunbutton_Click);
            // 
            // dodajbutton
            // 
            this.dodajbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajbutton.Location = new System.Drawing.Point(603, 55);
            this.dodajbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dodajbutton.Name = "dodajbutton";
            this.dodajbutton.Size = new System.Drawing.Size(107, 38);
            this.dodajbutton.TabIndex = 4;
            this.dodajbutton.Text = "Dodaj";
            this.dodajbutton.UseVisualStyleBackColor = true;
            this.dodajbutton.Click += new System.EventHandler(this.dodajbutton_Click);
            // 
            // Nazwiskotextbox
            // 
            this.Nazwiskotextbox.Enabled = false;
            this.Nazwiskotextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nazwiskotextbox.Location = new System.Drawing.Point(184, 77);
            this.Nazwiskotextbox.Name = "Nazwiskotextbox";
            this.Nazwiskotextbox.Size = new System.Drawing.Size(265, 39);
            this.Nazwiskotextbox.TabIndex = 3;
            // 
            // Imietextbox
            // 
            this.Imietextbox.Enabled = false;
            this.Imietextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Imietextbox.Location = new System.Drawing.Point(184, 18);
            this.Imietextbox.Name = "Imietextbox";
            this.Imietextbox.Size = new System.Drawing.Size(265, 39);
            this.Imietextbox.TabIndex = 2;
            // 
            // Nazwiskolabel
            // 
            this.Nazwiskolabel.AutoSize = true;
            this.Nazwiskolabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nazwiskolabel.Location = new System.Drawing.Point(21, 77);
            this.Nazwiskolabel.Name = "Nazwiskolabel";
            this.Nazwiskolabel.Size = new System.Drawing.Size(119, 32);
            this.Nazwiskolabel.TabIndex = 1;
            this.Nazwiskolabel.Text = "Nazwisko:";
            // 
            // Imielabel
            // 
            this.Imielabel.AutoSize = true;
            this.Imielabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Imielabel.Location = new System.Drawing.Point(21, 18);
            this.Imielabel.Name = "Imielabel";
            this.Imielabel.Size = new System.Drawing.Size(65, 32);
            this.Imielabel.TabIndex = 0;
            this.Imielabel.Text = "Imię:";
            // 
            // Edycja_button
            // 
            this.Edycja_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Edycja_button.Location = new System.Drawing.Point(475, 94);
            this.Edycja_button.Name = "Edycja_button";
            this.Edycja_button.Size = new System.Drawing.Size(108, 34);
            this.Edycja_button.TabIndex = 6;
            this.Edycja_button.Text = "Edycja";
            this.Edycja_button.UseVisualStyleBackColor = true;
            this.Edycja_button.Click += new System.EventHandler(this.Edycja_button_Click);
            // 
            // OknoGlowneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudenciDataGridView);
            this.MinimumSize = new System.Drawing.Size(788, 447);
            this.Name = "OknoGlowneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno Główne";
            this.Load += new System.EventHandler(this.OknoGlowneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudenciDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView StudenciDataGridView;
        private Panel panel1;
        private DataGridViewTextBoxColumn ImieCol1;
        private DataGridViewTextBoxColumn NazwiskoCol;
        private DataGridViewTextBoxColumn IndexCol;
        private TextBox Nazwiskotextbox;
        private TextBox Imietextbox;
        private Label Nazwiskolabel;
        private Label Imielabel;
        private Button dodajbutton;
        private Button usunbutton;
        private Button Edycja_button;
    }
}