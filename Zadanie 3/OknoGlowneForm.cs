
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Dynamic;
using Zadanie_3.Modele;

namespace Zadanie_3
{
    public partial class OknoGlowneForm : Form
    {
        public List<Student> Studenci { get; set; } = new List<Student>();
        public OknoGlowneForm()
        {
            InitializeComponent();

            var s1 = new Student
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                IndexNumber = "S1234"
            };
            var s2 = new Student
            {
                Imie = "Basia",
                Nazwisko = "Frankowska",
                IndexNumber = "S2345"
            };

            Studenci.Add(s1);
            Studenci.Add(s2);

            StudenciDataGridView.DataSource = Studenci;
        }

        private void OknoGlowneForm_Load(object sender, EventArgs e)
        {

        }

        private void StudenciDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //fail fast
            if (StudenciDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var st = StudenciDataGridView.SelectedRows[0].DataBoundItem as Student;
            Imietextbox.Text = st.Imie;
            Nazwiskotextbox.Text = st.Nazwisko;
        }

        private void dodajbutton_Click(object sender, EventArgs e)
        {
            var dialog = new StudentDialog();
            dialog.ShowDialog();

            if (dialog.Student != null)
            {
                var nowyStudent = dialog.Student;
                foreach(var student in Studenci)
                {
                    if(student.IndexNumber == nowyStudent.IndexNumber)
                    {
                        MessageBox.Show(this, "Taki numer indeksu jest już na liście", "Duplikat indeksu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                Studenci.Add(nowyStudent);
                StudenciDataGridView.DataSource = null;
                StudenciDataGridView.DataSource = Studenci;


            }
        }

        private void usunbutton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Chcesz usunąć?",
                 "Ważne",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {//tu się zaczyna
                StudenciDataGridView.SuspendLayout();
                Studenci.RemoveAt(StudenciDataGridView.SelectedRows[0].Index);

                StudenciDataGridView.DataSource = null;
                StudenciDataGridView.DataSource = Studenci;
                StudenciDataGridView.ResumeLayout();
                StudenciDataGridView.Refresh();
            }
        }

        private void Edycja_button_Click(object sender, EventArgs e)
        {
            var dialog = new StudentDialog();
            var studencik = Studenci[StudenciDataGridView.SelectedRows[0].Index];
            dialog.ImietextBox.Text = studencik.Imie;
            dialog.NazwiskoBox.Text = studencik.Nazwisko;
            dialog.NumerIndeksutextBox.Text = studencik.IndexNumber;

            dialog.ShowDialog();
            Studenci.Remove(studencik);
            Studenci.Add(dialog.Student);

            StudenciDataGridView.DataSource = null;
            StudenciDataGridView.DataSource = Studenci;
        }
    }



}








