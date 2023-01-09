
using System.ComponentModel.DataAnnotations;
using Zadanie_3.Modele;

namespace Zadanie_3
{
    public partial class StudentDialog : Form
    {
        public Student Student { get; set; }
        public StudentDialog()
        {
            InitializeComponent();
        }

        private void anulujbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Student = new Student();
                Student.Imie = ImietextBox.Text;
                Student.Nazwisko = NazwiskoBox.Text;
                if (NumerIndeksutextBox.Text.ToString().Count() == 5)
                {
                    if (NumerIndeksutextBox.Text[0].ToString() == "S")
                    {
                        if (int.TryParse(NumerIndeksutextBox.Text.Substring(1), out _))
                        {
                            Student.IndexNumber = NumerIndeksutextBox.Text;

                        }
                        else
                        {
                            throw new ValidationException("Indeks powinien być numerem");
                        }
                    }
                    else
                    {
                        throw new ValidationException("Brak wyróżnika Indeksu S");
                    }


                }
                else
                {
                    throw new ValidationException("Błędny numer indeksu");
                }
                Student.Validate();

                Close();
            }
            catch (ValidationException Exp)
            {
                MessageBox.Show(this, Exp.Message, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

