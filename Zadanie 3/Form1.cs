namespace Zadanie_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Przycisk.Click += button1_Click;
            Przycisk.Click += button1_Click2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Przycisk.Text = DateTime.Now.ToString();
        }
        
   private void button1_Click2(object sender, EventArgs e)
        {
             colorDialog1.ShowDialog();
        }
        private Form1 GetForm1(Form1 form1)
        {
            return form1;
        }

        private void Form1_Click(object sender, EventArgs e, Form1 form1)
        {
          
         }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text=listBox1.SelectedItem.ToString();
        }
    }
}