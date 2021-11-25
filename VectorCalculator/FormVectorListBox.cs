using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorCalculator
{
    public partial class FormVectorListBox : Form
    {
        internal List<Vector> vectors = new List<Vector> { }; // Instanserer en ny internal vectorliste.

        // Metoden, som lader os denne from kommunikere med "main form" fra denne form, er taget fra:
        // https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
        // Eksempel 4 i linket.
        FormCalculator formCalculator1;
        public FormVectorListBox(FormCalculator f)
        {
            InitializeComponent();

            formCalculator1 = f;
        }

        private void FormVectorListBox_Load(object sender, EventArgs e)
        {
            // Default indstillinger

            buttonClear.Enabled = false;
            buttonRemoveSelected.Enabled = false;
            buttonResultantVector.Enabled = false;
        }
        internal void UpdateFormVectorList()
        {
            listBoxVectors.Items.Clear();
            for (int i = 0; i < vectors.Count; i++) // Tilføjer vektorerne fra listen til listbox som output.
            {
                listBoxVectors.Items.Add(vectors[i].ToString());
            }

            if (vectors.Count > 0) // Enable eller disable dem, afhængig af om der er flere end 0 elementer i vectors.
            {
                buttonClear.Enabled = true;
                buttonRemoveSelected.Enabled = true;
                buttonResultantVector.Enabled = true;

                formCalculator1.comboBoxResultOptions.SelectedItem = "Resultant Vector";
                formCalculator1.textBoxResult.Text = new Vector(0, 0, 0).AddToVector(vectors.ToArray()).ToString();
                // new Vector(0,0,0) laver en ny vektor.
                // Så adderer vi alle de vektorer på listen til vektoren. (det kan man godt, når man konverterer den til en array.)
                // Den ny vektor konventerer vi så til en string.
            }
            else
            {
                buttonResultantVector.Enabled = false;
                buttonClear.Enabled = false;
                buttonRemoveSelected.Enabled = false;
            }

            // Select den sidste element i listboksen, så der ikke opstår fejl, når man trykker på buttonRemoveSelected.
            listBoxVectors.SelectedIndex = listBoxVectors.Items.Count - 1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            vectors.Clear();
            UpdateFormVectorList();
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            vectors.RemoveAt(listBoxVectors.SelectedIndex);
            UpdateFormVectorList();
        }

        private void buttonResultingVector_Click(object sender, EventArgs e)
        {
            formCalculator1.comboBoxResultOptions.SelectedIndex = 0;
            // Svarende til "Resultant Vector" item.
            formCalculator1.textBoxResult.Text = new Vector(0, 0, 0).AddToVector(vectors.ToArray()).ToString();
            // new Vector(0,0,0) laver en ny vektor.
            // Så adderer vi alle de vektorer på listen til vektoren. (det kan man godt, når man konverterer den til en array.)
            // Den ny vektor konventerer vi så til en string.
        }
    }
}
