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
    public struct Vector
    {
        internal double X;
        internal double Y;
        internal double Z;
        public Vector(params Double[] doubles) // Dette måde at gøre det på, lader os både tage imod arrays og 3 parametre som x,y,z. 
        {
            this.X = doubles[0];
            this.Y = doubles[1];
            this.Z = doubles[2];
        }
        public override string ToString() // ToString returnerer en string med vektorens koordinater.
        {
            return $"({X:0.##}; {Y:0.##}; {Z:0.##})"; // Vi afrunder de tre koordinater til 2 decimaler og returnerer det.
        }
        public Vector AddToVector(params Vector[] Vectors) // AddToVector lægger andre vektorer til vektoren.
        {
            Vector TempVector = new Vector(X, Y, Z); // En midlertidig vektor (med koordinaterne X,Y,Z), som vi vil anvende.

            for (int i = 0; i < Vectors.Length; i++) // Vi lægger de andre vektorer til TempVector.
            {
                TempVector.X += Vectors[i].X;
                TempVector.Y += Vectors[i].Y;
                TempVector.Z += Vectors[i].Z;
            }

            return TempVector; // Returnerer TempVector
        }
        // Metoden nedenunder bliver ikke brugt og AddToVector kan sådan set udføre dens funktion
        // (ved at sætte en minustegn foran koordinaterne)

        //public Vector SubtractFromVector(params Vector[] Vectors) // SubtractFromVector trækker andre vektorer fra vektoren.
        //{
        //    Vector TempVector = new Vector(X, Y, Z); // En midlertidig vektor (med koordinaterne X,Y,Z), som vi vil anvende.

        //    for (int i = 0; i < Vectors.Length; i++) // Vi subtraherer de andre vektorer fra TempVector.
        //    {
        //        TempVector.X -= Vectors[i].X;
        //        TempVector.Y -= Vectors[i].Y;
        //        TempVector.Z -= Vectors[i].Z;
        //    }

        //    return TempVector; // Returnerer TempVector
        //}

        public Vector Difference(Vector b)
        {
            // Trækker b fra vektoren og returnerer de absolutte værdier af koordinaterne.
            return new Vector(Math.Abs(X - b.X), Math.Abs(Y - b.Y), Math.Abs(Z - b.Z)); 
        }
        public Double Length()
        {
            // Returnerer længden af vektoren på 3. dimension.
            // Sætningen er udledt fra Pythagoras læresætning.
            return Math.Sqrt(X * X + Y * Y + Z * Z); 
        }
        public Double ScalarProduct(Vector b)
        {
            // Returnerer skalaproduktet mellem b og vektoren på 3. dimension.
            return X * b.X + Y * b.Y + Z * b.Z;
        }
        public Double Determinant3D(Vector b, Vector c)
        {
            // Returnerer determinanten af vektoren, vektor b og c.

            // Det skal være præcis 3 vektorer, når der er 3 dimensioner, da man kun kan tage determinanten af kvadratiske matrixer.
            // Dvs. 1x1, 2x2, 3x3, ... , nxn, hvor fx 3 vektorer kan opfattes som en 3x3 matrix.
            // Det er da en determinant til en 2x2 matrix skal returnere en areal, en 3x3 skal returernere en volume m.v.

            // Formlen er taget fra: https://www.mathsisfun.com/algebra/matrix-determinant.html
            return X * (b.Y * c.Z - b.Z * c.Y) - b.X * (Y * c.Z - Z * c.Y) + c.X * (Y * b.Z - Z * b.Y);
        }
        public Double Angle(Vector b, string TypeOfAngle)
        {
            // Følgende sætning er fra Mat B Htx bogen kapitel 5.6
            Vector TempVector = new Vector(X, Y, Z);
            double ratio = TempVector.ScalarProduct(b) / (TempVector.Length() * b.Length());
            // Hvor man så tager arccos af ratio for at finde vinklen mellem to vektorer.

            // Returnerer vinklen som enten radianer eller grader, afhængig af TypeOfAngle.
            if (TypeOfAngle == "Radians")
            {
                return Math.Acos(ratio);
            }
            else
            {
                return Math.Acos(ratio) * 180d / Math.PI;
            }
        }
        public Vector CrossProduct3D(Vector b)
        {
            // Returnerer krydsproduktet af to 3-dimensionelle vektorer. (vektoren og vektor b)

            // Formlen er taget fra: https://math.stackexchange.com/questions/1972640/matrix-multiplication-question-of-2-3x1-vectors
            return new Vector(Y * b.Z - Z * b.Y, -(X * b.Z - Z * b.X), X * b.Y - Y * b.X);
        }
        public Double Determinant2D(Vector b)
        {
            // Returnerer determinanten af vektoren og vektor b.

            // Formlen er taget fra: https://www.mathsisfun.com/algebra/matrix-determinant.html
            return X*b.Y-Y*b.X;
        }
    }
        public partial class FormCalculator : Form
    {
        string WorkingVector="u"; // Det er vektoren, som programmen arbejder med.

        FormVectorListBox formVectorListBox; // Instanserer en ny FormVectorListBox.
        public FormCalculator()
        {
            InitializeComponent();

            // Åbner FormVectorListBox som default -- (jf. koden deri)
            // (Viser den efter FormCalculator er loaded.
            formVectorListBox = new FormVectorListBox(this);
       
        }

        private void tabControlVectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Et række en if-else statements, der ændrer WorkingVector afhængig af hvilken tab brugeren er på.
            if (tabControlVectors.SelectedIndex == 0)
            {
                WorkingVector = "u";
            }
            else
            {
                if (tabControlVectors.SelectedIndex == 1)
                {
                    WorkingVector = "v";
                }
                else
                {
                    if (tabControlVectors.SelectedIndex == 2)
                    {
                        WorkingVector = "w";
                    }
                }
            }
            UpdateWorkingVector(); // Kalder på en metode, der ændrer på nogle tekst på tekstbokse afhængig af WorkingVector.
        }
        private void UpdateWorkingVector()
        {
            buttonAdd.Text = $"Add {WorkingVector}";
            buttonSubstract.Text = $"Substract {WorkingVector}";
            buttonLength.Text = $"Length of {WorkingVector}";
        }

        private bool CheckDoubleInTextBox(TextBox textBoxSuspect) 
        {
            // Metode, der tjekker om der en double i en given tekstboks, hvor den returnerer true, hvis det er sandt,
            // og sender fejl-beskeder til brugeren (og farver teksten rød), hvis det er falsk.

            try
            {
                // Hvis der kun står en minustegn, vil den sætte en 0 bagefter
                // , så den betragtes stadig som en double og ikke vækker error-message.
                // Desuden er -01 = -1.

                if (textBoxSuspect.Text == "-") 
                {
                    textBoxSuspect.Text = "-0";
                }
                // Hvis det er et tomt felt, vil den tilføj en 0.
                if (textBoxSuspect.Text == "")
                {
                    textBoxSuspect.Text = "0";
                }

                // Hvis det ikke er en double, vil den forsøg at Parse textBoxSuspect,
                // hvilket enten vil "throw" en FormatException eller OverflowException.
                double number = double.Parse(textBoxSuspect.Text);

                return true;
            }
            catch (FormatException)
            {
                Color c = textBoxSuspect.ForeColor;
                textBoxSuspect.ForeColor = Color.Red;
                MessageBox.Show("Error! You have to enter a double depending on your prechosen locale in the operating system. (e.g. 1.000,0 or 1,000.1)", "Format Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSuspect.ForeColor = c;
                textBoxSuspect.Clear(); // Alternativ: textBoxInput.Text = "";
                textBoxSuspect.Focus(); // Brugervenligheds skyld.
                return false;
            }
            catch (OverflowException)
            {
                Color c = textBoxSuspect.ForeColor;
                textBoxSuspect.ForeColor = Color.Red;
                MessageBox.Show("Error! Number is too large for a double type.", "Overflow Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSuspect.ForeColor = c;
                textBoxSuspect.Clear(); // Alternativ: textBoxInput.Text = "";
                textBoxSuspect.Focus(); // Brugervenligheds skyld.
                return false;
            }
        }

        private void textBox_uX_Leave(object sender, EventArgs e) // En event, der bliver kaldt, når brugeren forlader tekstboksen.
        {
            CheckDoubleInTextBox(textBox_uX);
        }

        private void textBox_uY_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_uY);
        }

        private void textBox_uZ_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_uZ);
        }

        private void textBox_vX_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_vX);
        }

        private void textBox_vY_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_vY);
        }

        private void textBox_vZ_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_vZ);
        }

        private void textBox_wX_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_wX);
        }

        private void textBox_wY_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_wY);
        }

        private void textBox_wZ_Leave(object sender, EventArgs e)
        {
            CheckDoubleInTextBox(textBox_wZ);
        }

        private double[] GetCoordinatesOfVector(string a)
        {
            // Denne metode returnerer en double array med koordinaterne af vektoren "a" (beskrevet enten med et symbol eller tal)
            if (a == "u" || a == "0")
            {
                return new Double[] {double.Parse(textBox_uX.Text), double.Parse(textBox_uY.Text), double.Parse(textBox_uZ.Text) };
            }
            else
            {
                if (a == "v" || a == "1")
                {
                    return new Double[] { double.Parse(textBox_vX.Text), double.Parse(textBox_vY.Text), double.Parse(textBox_vZ.Text) };
                }
                else
                {
                    if (a == "w" || a == "2")
                    {
                        return new Double[] { double.Parse(textBox_wX.Text), double.Parse(textBox_wY.Text), double.Parse(textBox_wZ.Text) };
                    }
                    else
                    {
                        return new double[] { };
                    }
                }
            }
        }
        private void buttonLength_Click(object sender, EventArgs e)
        {
            comboBoxResultOptions.SelectedIndex = 3;
            // Svarende til "Length" item - grund til jeg bruger tal, er fordi jeg kan ændre navnet på de forskellige items.

            Vector TempVector = new Vector(GetCoordinatesOfVector(WorkingVector)); // En midlertidig vektor TempVector omdannes til WorkingVector.
            textBoxResult.Text = Math.Round(TempVector.Length(),2).ToString(); // Længden af TempVector printes ud til textBoxResult.
            // Math.Round(X,2) afrunder nummeret til to decimaler.
            
        }

        private void buttonDeterminant_Click(object sender, EventArgs e)
        {
            comboBoxResultOptions.SelectedIndex = 5;
            // Svarende til "Determinant" item

            Vector Temp_u = new Vector(GetCoordinatesOfVector("u"));
            Vector Temp_v = new Vector(GetCoordinatesOfVector("v"));
            Vector Temp_w = new Vector(GetCoordinatesOfVector("w"));

            textBoxResult.Text = Math.Abs(Math.Round(Temp_u.Determinant3D(Temp_v, Temp_w))).ToString(); // jf. metode DeterminantWith() under Struct Vector.
            // Math.Round(X,2) afrunder nummeret til to decimaler.
            // Math.Abs(X) finder den absolutte værdi af nummert.
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            // Sætter nogle defaultværdier fra starten af.
            comboBoxDifferenceVector1.SelectedIndex = 0;
            comboBoxDifferenceVector2.SelectedIndex = 1;

            comboBoxAngleVector1.SelectedIndex = 0;
            comboBoxAngleVector2.SelectedIndex = 1;

            comboBoxScalarProductVector1.SelectedIndex = 0;
            comboBoxScalarProductVector2.SelectedIndex = 1;

            comboBoxCrossProductVector1.SelectedIndex = 0;
            comboBoxCrossProductVector2.SelectedIndex = 1;

            comboBoxAltDeterminantVector1.SelectedIndex = 0;
            comboBoxAltDeterminantVector2.SelectedIndex = 1;

            // Viser formVectorListBox
            formVectorListBox.Show();
            formVectorListBox.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y); // Flytter den ved siden af FormCalculator
        }

        private void buttonDifference_Click(object sender, EventArgs e)
        {
            Vector temp_a = new Vector(GetCoordinatesOfVector(comboBoxDifferenceVector1.SelectedIndex.ToString())); // Sender i stedet en tal som string til metoden
            Vector temp_b = new Vector(GetCoordinatesOfVector(comboBoxDifferenceVector2.SelectedIndex.ToString()));

            comboBoxResultOptions.SelectedIndex = 1;
            // Svarende til "Difference" item

            textBoxResult.Text = temp_a.Difference(temp_b).ToString();
            // Finder Differencen mellem temp_a og temp_b
            // , hvor ToString() afrunder og skriver koordinaterne ud som en string.
        }

        private void buttonAngle_Click(object sender, EventArgs e)
        {
            Vector temp_a = new Vector(GetCoordinatesOfVector(comboBoxAngleVector1.SelectedIndex.ToString())); 
            Vector temp_b = new Vector(GetCoordinatesOfVector(comboBoxAngleVector2.SelectedIndex.ToString()));
            string TypeOfVector;

            if (radioButtonDegrees.Checked) // Dette tjekker om radioButtonDegrees er "checked" og justere TypeOfVector afhængig af det.
            {
                TypeOfVector = "Degrees";
            }
            else
            {
                TypeOfVector = "Radians";
            }

            comboBoxResultOptions.SelectedIndex = 2;
            // Svarende til "Angle" item

            textBoxResult.Text = Math.Round(temp_a.Angle(temp_b,TypeOfVector),2).ToString(); 
            // Finder vinklen mellem temp_a og temp_b
            // , hvor Math.Round() og ToString() afrunder og skriver koordinaterne ud som en string til textboksen.
        }

        private void buttonScalarProduct_Click(object sender, EventArgs e)
        {
            Vector temp_a = new Vector(GetCoordinatesOfVector(comboBoxScalarProductVector1.SelectedIndex.ToString())); 
            Vector temp_b = new Vector(GetCoordinatesOfVector(comboBoxScalarProductVector2.SelectedIndex.ToString()));

            comboBoxResultOptions.SelectedIndex = 4;
            // Svarende til "Scalar Product" item

            textBoxResult.Text = temp_a.ScalarProduct(temp_b).ToString();
            // Finder skalarproduktet mellem temp_a og temp_b
            // , hvor ToString() afrunder og skriver koordinaterne ud som en string.
        }

        private void buttonCrossProduct_Click(object sender, EventArgs e)
        {
            Vector temp_a = new Vector(GetCoordinatesOfVector(comboBoxCrossProductVector1.SelectedIndex.ToString()));
            Vector temp_b = new Vector(GetCoordinatesOfVector(comboBoxCrossProductVector2.SelectedIndex.ToString()));

            comboBoxResultOptions.SelectedIndex = 6;
            // Svarende til "Cross Product" item

            textBoxResult.Text = temp_a.CrossProduct3D(temp_b).ToString();
            // Finder krydsproduktet mellem temp_a og temp_b
            // , hvor ToString() afrunder og skriver koordinaterne ud som en string.
        }

        private void buttonAltDeterminant_Click(object sender, EventArgs e)
        {
            Vector temp_a = new Vector(GetCoordinatesOfVector(comboBoxAltDeterminantVector1.SelectedIndex.ToString()));
            Vector temp_b = new Vector(GetCoordinatesOfVector(comboBoxAltDeterminantVector2.SelectedIndex.ToString()));

            comboBoxResultOptions.SelectedIndex = 7;
            // Svarende til "AltDeterminant" item

            textBoxResult.Text = temp_a.Determinant2D(temp_b).ToString();
            // Finder determinanten af temp_a og temp_b
            // , hvor ToString() afrunder og skriver koordinaterne ud som en string.
        }

        private void checkBoxShowFormVec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowFormVec.Checked == true)
            {
                formVectorListBox.Show();
                formVectorListBox.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y); // Flytter den ved siden af FormCalculator

            }
            else
            {
                formVectorListBox.Hide();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formVectorListBox.vectors.Add(new Vector(GetCoordinatesOfVector(WorkingVector))); // Tilføjer WorkingVector til vectors.
            formVectorListBox.UpdateFormVectorList(); // Kalder på en metode, der opdaterer formVectorListBox.
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            double[] Temp_CoordinateArray = GetCoordinatesOfVector(WorkingVector); // Laver en midlertidig double array med koordinaterne

            // Konverterer koordinaterne til en vektor, hvor der er en minus tegn for koordinaterne, og tilføjer den til listen
            formVectorListBox.vectors.Add(new Vector(-Temp_CoordinateArray[0], -Temp_CoordinateArray[1], -Temp_CoordinateArray[2]));

            formVectorListBox.UpdateFormVectorList(); // Kalder på en metode, der opdaterer formVectorListBox.
        }

        private void radioButtonDegrees_CheckedChanged(object sender, EventArgs e)
        {
            buttonAngle.PerformClick(); // "Klikker" på buttonAngle - som kalder på button buttonAngle_Click()
        }

        private void comboBoxResultOptions_SelectionChangeCommitted(object sender, EventArgs e) 
        {
            // Denne metode bliver kaldt, når brugeren ændrer ved comboBoks'en
            // Vi vil referere til: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.combobox.selectionchangecommitted?redirectedfrom=MSDN&view=windowsdesktop-6.0

            // En lang række af if-else-statements, der udfører operationer ved at kalde buttonX_Click() svarende til SelectedIndex.
            if (comboBoxResultOptions.SelectedIndex == 1)
            {
                buttonDifference.PerformClick();
            }
            else
            {
                if (comboBoxResultOptions.SelectedIndex == 2)
                {
                    buttonAngle.PerformClick();
                }
                else
                {
                    if (comboBoxResultOptions.SelectedIndex == 3)
                    {
                        buttonLength.PerformClick();
                    }
                    else
                    {
                        if (comboBoxResultOptions.SelectedIndex == 4)
                        {
                            buttonScalarProduct.PerformClick();
                        }
                        else
                        {
                            if (comboBoxResultOptions.SelectedIndex == 5)
                            {
                                buttonDeterminant.PerformClick();
                            }
                            else
                            {
                                if (comboBoxResultOptions.SelectedIndex == 6)
                                {
                                    buttonCrossProduct.PerformClick();
                                }
                                else
                                {
                                    if (comboBoxResultOptions.SelectedIndex == 7)
                                    {
                                        buttonAltDeterminant.PerformClick();
                                    }
                                    else
                                    {
                                        if (comboBoxResultOptions.SelectedIndex == 0 && formVectorListBox.vectors.Count > 1)
                                        {
                                            comboBoxResultOptions.SelectedIndex = 0;
                                            // Svarende til "Resultant Vector" item.
                                            textBoxResult.Text = new Vector(0, 0, 0).AddToVector(formVectorListBox.vectors.ToArray()).ToString();
                                            // new Vector(0,0,0) laver en ny vektor.
                                            // Så adderer vi alle de vektorer på listen til vektoren. (det kan man godt, når man konverterer den til en array.)
                                            // Den ny vektor konventerer vi så til en string.
                                        }
                                        else // Hvis "Resultant Vector" er den eneste operation tilbage og der er for få elementer i listen.
                                        {
                                            textBoxResult.Text = "Add a vector to perform this operation.";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


    }
}
