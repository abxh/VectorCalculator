namespace VectorCalculator
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.tabControlVectors = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_uX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_uY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_uZ = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_vX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_vY = new System.Windows.Forms.TextBox();
            this.textBox_vZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox_wZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_wY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_wX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDifferenceVector1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDifferenceVector2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxAngleVector2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAngleVector1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonAngle = new System.Windows.Forms.Button();
            this.buttonLength = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxScalarProductVector2 = new System.Windows.Forms.ComboBox();
            this.comboBoxScalarProductVector1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonScalarProduct = new System.Windows.Forms.Button();
            this.buttonDeterminant = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxCrossProductVector2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCrossProductVector1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonCrossProduct = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxResultOptions = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxAltDeterminantVector2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAltDeterminantVector1 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonAltDeterminant = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.radioButtonDegrees = new System.Windows.Forms.RadioButton();
            this.radioButtonRadians = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.checkBoxShowFormVec = new System.Windows.Forms.CheckBox();
            this.tabControlVectors.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "VectorCalculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "By Shamim Siddique - HCØ Ballerup";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(241, 78);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 23);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Add u";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Location = new System.Drawing.Point(241, 108);
            this.buttonSubstract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(123, 23);
            this.buttonSubstract.TabIndex = 24;
            this.buttonSubstract.Text = "Substract u";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // tabControlVectors
            // 
            this.tabControlVectors.Controls.Add(this.tabPage1);
            this.tabControlVectors.Controls.Add(this.tabPage2);
            this.tabControlVectors.Controls.Add(this.tabPage3);
            this.tabControlVectors.Location = new System.Drawing.Point(19, 54);
            this.tabControlVectors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlVectors.Name = "tabControlVectors";
            this.tabControlVectors.SelectedIndex = 0;
            this.tabControlVectors.Size = new System.Drawing.Size(216, 138);
            this.tabControlVectors.TabIndex = 25;
            this.tabControlVectors.SelectedIndexChanged += new System.EventHandler(this.tabControlVectors_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_uX);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_uY);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox_uZ);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(208, 109);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vector u";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_uX
            // 
            this.textBox_uX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_uX.Location = new System.Drawing.Point(39, 15);
            this.textBox_uX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_uX.Name = "textBox_uX";
            this.textBox_uX.Size = new System.Drawing.Size(129, 22);
            this.textBox_uX.TabIndex = 41;
            this.textBox_uX.Text = "0";
            this.textBox_uX.Leave += new System.EventHandler(this.textBox_uX_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Y:";
            // 
            // textBox_uY
            // 
            this.textBox_uY.Location = new System.Drawing.Point(39, 43);
            this.textBox_uY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_uY.Name = "textBox_uY";
            this.textBox_uY.Size = new System.Drawing.Size(129, 22);
            this.textBox_uY.TabIndex = 43;
            this.textBox_uY.Text = "0";
            this.textBox_uY.Leave += new System.EventHandler(this.textBox_uY_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Z:";
            // 
            // textBox_uZ
            // 
            this.textBox_uZ.Location = new System.Drawing.Point(39, 71);
            this.textBox_uZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_uZ.Name = "textBox_uZ";
            this.textBox_uZ.Size = new System.Drawing.Size(129, 22);
            this.textBox_uZ.TabIndex = 45;
            this.textBox_uZ.Text = "0";
            this.textBox_uZ.Leave += new System.EventHandler(this.textBox_uZ_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_vX);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_vY);
            this.tabPage2.Controls.Add(this.textBox_vZ);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(208, 109);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vector v";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_vX
            // 
            this.textBox_vX.Location = new System.Drawing.Point(39, 15);
            this.textBox_vX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_vX.Name = "textBox_vX";
            this.textBox_vX.Size = new System.Drawing.Size(129, 22);
            this.textBox_vX.TabIndex = 17;
            this.textBox_vX.Text = "0";
            this.textBox_vX.Leave += new System.EventHandler(this.textBox_vX_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "X:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Y:";
            // 
            // textBox_vY
            // 
            this.textBox_vY.Location = new System.Drawing.Point(39, 43);
            this.textBox_vY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_vY.Name = "textBox_vY";
            this.textBox_vY.Size = new System.Drawing.Size(129, 22);
            this.textBox_vY.TabIndex = 19;
            this.textBox_vY.Text = "0";
            this.textBox_vY.Leave += new System.EventHandler(this.textBox_vY_Leave);
            // 
            // textBox_vZ
            // 
            this.textBox_vZ.Location = new System.Drawing.Point(39, 71);
            this.textBox_vZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_vZ.Name = "textBox_vZ";
            this.textBox_vZ.Size = new System.Drawing.Size(129, 22);
            this.textBox_vZ.TabIndex = 21;
            this.textBox_vZ.Text = "0";
            this.textBox_vZ.Leave += new System.EventHandler(this.textBox_vZ_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Z:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_wZ);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.textBox_wY);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textBox_wX);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(208, 109);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vector w";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox_wZ
            // 
            this.textBox_wZ.Location = new System.Drawing.Point(39, 71);
            this.textBox_wZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_wZ.Name = "textBox_wZ";
            this.textBox_wZ.Size = new System.Drawing.Size(129, 22);
            this.textBox_wZ.TabIndex = 28;
            this.textBox_wZ.Text = "0";
            this.textBox_wZ.Leave += new System.EventHandler(this.textBox_wZ_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Z:";
            // 
            // textBox_wY
            // 
            this.textBox_wY.Location = new System.Drawing.Point(39, 43);
            this.textBox_wY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_wY.Name = "textBox_wY";
            this.textBox_wY.Size = new System.Drawing.Size(129, 22);
            this.textBox_wY.TabIndex = 26;
            this.textBox_wY.Text = "0";
            this.textBox_wY.Leave += new System.EventHandler(this.textBox_wY_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Y:";
            // 
            // textBox_wX
            // 
            this.textBox_wX.Location = new System.Drawing.Point(39, 15);
            this.textBox_wX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_wX.Name = "textBox_wX";
            this.textBox_wX.Size = new System.Drawing.Size(129, 22);
            this.textBox_wX.TabIndex = 24;
            this.textBox_wX.Text = "0";
            this.textBox_wX.Leave += new System.EventHandler(this.textBox_wX_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "X:";
            // 
            // buttonDifference
            // 
            this.buttonDifference.Location = new System.Drawing.Point(376, 79);
            this.buttonDifference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(123, 23);
            this.buttonDifference.TabIndex = 26;
            this.buttonDifference.Text = "Find Difference";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.buttonDifference_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "between";
            // 
            // comboBoxDifferenceVector1
            // 
            this.comboBoxDifferenceVector1.FormattingEnabled = true;
            this.comboBoxDifferenceVector1.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxDifferenceVector1.Location = new System.Drawing.Point(569, 78);
            this.comboBoxDifferenceVector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDifferenceVector1.Name = "comboBoxDifferenceVector1";
            this.comboBoxDifferenceVector1.Size = new System.Drawing.Size(44, 24);
            this.comboBoxDifferenceVector1.TabIndex = 28;
            // 
            // comboBoxDifferenceVector2
            // 
            this.comboBoxDifferenceVector2.FormattingEnabled = true;
            this.comboBoxDifferenceVector2.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxDifferenceVector2.Location = new System.Drawing.Point(641, 78);
            this.comboBoxDifferenceVector2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDifferenceVector2.Name = "comboBoxDifferenceVector2";
            this.comboBoxDifferenceVector2.Size = new System.Drawing.Size(44, 24);
            this.comboBoxDifferenceVector2.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(619, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "&&";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(619, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "&&";
            // 
            // comboBoxAngleVector2
            // 
            this.comboBoxAngleVector2.FormattingEnabled = true;
            this.comboBoxAngleVector2.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxAngleVector2.Location = new System.Drawing.Point(641, 107);
            this.comboBoxAngleVector2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAngleVector2.Name = "comboBoxAngleVector2";
            this.comboBoxAngleVector2.Size = new System.Drawing.Size(44, 24);
            this.comboBoxAngleVector2.TabIndex = 34;
            // 
            // comboBoxAngleVector1
            // 
            this.comboBoxAngleVector1.FormattingEnabled = true;
            this.comboBoxAngleVector1.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxAngleVector1.Location = new System.Drawing.Point(569, 107);
            this.comboBoxAngleVector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAngleVector1.Name = "comboBoxAngleVector1";
            this.comboBoxAngleVector1.Size = new System.Drawing.Size(44, 24);
            this.comboBoxAngleVector1.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(505, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "between";
            // 
            // buttonAngle
            // 
            this.buttonAngle.Location = new System.Drawing.Point(376, 108);
            this.buttonAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAngle.Name = "buttonAngle";
            this.buttonAngle.Size = new System.Drawing.Size(123, 23);
            this.buttonAngle.TabIndex = 31;
            this.buttonAngle.Text = "Find Angle";
            this.buttonAngle.UseVisualStyleBackColor = true;
            this.buttonAngle.Click += new System.EventHandler(this.buttonAngle_Click);
            // 
            // buttonLength
            // 
            this.buttonLength.Location = new System.Drawing.Point(241, 137);
            this.buttonLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLength.Name = "buttonLength";
            this.buttonLength.Size = new System.Drawing.Size(123, 23);
            this.buttonLength.TabIndex = 36;
            this.buttonLength.Text = "Length of u";
            this.buttonLength.UseVisualStyleBackColor = true;
            this.buttonLength.Click += new System.EventHandler(this.buttonLength_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(619, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "&&";
            // 
            // comboBoxScalarProductVector2
            // 
            this.comboBoxScalarProductVector2.FormattingEnabled = true;
            this.comboBoxScalarProductVector2.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxScalarProductVector2.Location = new System.Drawing.Point(641, 135);
            this.comboBoxScalarProductVector2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxScalarProductVector2.Name = "comboBoxScalarProductVector2";
            this.comboBoxScalarProductVector2.Size = new System.Drawing.Size(44, 24);
            this.comboBoxScalarProductVector2.TabIndex = 40;
            // 
            // comboBoxScalarProductVector1
            // 
            this.comboBoxScalarProductVector1.FormattingEnabled = true;
            this.comboBoxScalarProductVector1.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxScalarProductVector1.Location = new System.Drawing.Point(569, 135);
            this.comboBoxScalarProductVector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxScalarProductVector1.Name = "comboBoxScalarProductVector1";
            this.comboBoxScalarProductVector1.Size = new System.Drawing.Size(44, 24);
            this.comboBoxScalarProductVector1.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(527, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "of";
            // 
            // buttonScalarProduct
            // 
            this.buttonScalarProduct.Location = new System.Drawing.Point(376, 137);
            this.buttonScalarProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonScalarProduct.Name = "buttonScalarProduct";
            this.buttonScalarProduct.Size = new System.Drawing.Size(123, 23);
            this.buttonScalarProduct.TabIndex = 37;
            this.buttonScalarProduct.Text = "Scalar Product";
            this.buttonScalarProduct.UseVisualStyleBackColor = true;
            this.buttonScalarProduct.Click += new System.EventHandler(this.buttonScalarProduct_Click);
            // 
            // buttonDeterminant
            // 
            this.buttonDeterminant.Location = new System.Drawing.Point(241, 165);
            this.buttonDeterminant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeterminant.Name = "buttonDeterminant";
            this.buttonDeterminant.Size = new System.Drawing.Size(123, 48);
            this.buttonDeterminant.TabIndex = 42;
            this.buttonDeterminant.Text = "Determinant of u, v && w";
            this.buttonDeterminant.UseVisualStyleBackColor = true;
            this.buttonDeterminant.Click += new System.EventHandler(this.buttonDeterminant_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(619, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 47;
            this.label18.Text = "&&";
            // 
            // comboBoxCrossProductVector2
            // 
            this.comboBoxCrossProductVector2.FormattingEnabled = true;
            this.comboBoxCrossProductVector2.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxCrossProductVector2.Location = new System.Drawing.Point(641, 164);
            this.comboBoxCrossProductVector2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCrossProductVector2.Name = "comboBoxCrossProductVector2";
            this.comboBoxCrossProductVector2.Size = new System.Drawing.Size(44, 24);
            this.comboBoxCrossProductVector2.TabIndex = 46;
            // 
            // comboBoxCrossProductVector1
            // 
            this.comboBoxCrossProductVector1.FormattingEnabled = true;
            this.comboBoxCrossProductVector1.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxCrossProductVector1.Location = new System.Drawing.Point(569, 164);
            this.comboBoxCrossProductVector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCrossProductVector1.Name = "comboBoxCrossProductVector1";
            this.comboBoxCrossProductVector1.Size = new System.Drawing.Size(44, 24);
            this.comboBoxCrossProductVector1.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(527, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "of";
            // 
            // buttonCrossProduct
            // 
            this.buttonCrossProduct.Location = new System.Drawing.Point(376, 165);
            this.buttonCrossProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrossProduct.Name = "buttonCrossProduct";
            this.buttonCrossProduct.Size = new System.Drawing.Size(123, 23);
            this.buttonCrossProduct.TabIndex = 43;
            this.buttonCrossProduct.Text = "Cross Product";
            this.buttonCrossProduct.UseVisualStyleBackColor = true;
            this.buttonCrossProduct.Click += new System.EventHandler(this.buttonCrossProduct_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 240);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 48;
            this.label20.Text = "Result:";
            // 
            // comboBoxResultOptions
            // 
            this.comboBoxResultOptions.FormattingEnabled = true;
            this.comboBoxResultOptions.Items.AddRange(new object[] {
            "Resultant Vector",
            "Difference",
            "Angle",
            "Length",
            "Scalar Product",
            "Determinant",
            "Cross Product",
            "AltDeterminant"});
            this.comboBoxResultOptions.Location = new System.Drawing.Point(20, 260);
            this.comboBoxResultOptions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxResultOptions.Name = "comboBoxResultOptions";
            this.comboBoxResultOptions.Size = new System.Drawing.Size(160, 24);
            this.comboBoxResultOptions.TabIndex = 49;
            this.comboBoxResultOptions.SelectionChangeCommitted += new System.EventHandler(this.comboBoxResultOptions_SelectionChangeCommitted);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(193, 260);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(492, 22);
            this.textBoxResult.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(619, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 16);
            this.label21.TabIndex = 56;
            this.label21.Text = "&&";
            // 
            // comboBoxAltDeterminantVector2
            // 
            this.comboBoxAltDeterminantVector2.FormattingEnabled = true;
            this.comboBoxAltDeterminantVector2.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxAltDeterminantVector2.Location = new System.Drawing.Point(641, 192);
            this.comboBoxAltDeterminantVector2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAltDeterminantVector2.Name = "comboBoxAltDeterminantVector2";
            this.comboBoxAltDeterminantVector2.Size = new System.Drawing.Size(44, 24);
            this.comboBoxAltDeterminantVector2.TabIndex = 55;
            // 
            // comboBoxAltDeterminantVector1
            // 
            this.comboBoxAltDeterminantVector1.FormattingEnabled = true;
            this.comboBoxAltDeterminantVector1.Items.AddRange(new object[] {
            "u",
            "v",
            "w"});
            this.comboBoxAltDeterminantVector1.Location = new System.Drawing.Point(569, 192);
            this.comboBoxAltDeterminantVector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAltDeterminantVector1.Name = "comboBoxAltDeterminantVector1";
            this.comboBoxAltDeterminantVector1.Size = new System.Drawing.Size(44, 24);
            this.comboBoxAltDeterminantVector1.TabIndex = 54;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(527, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 16);
            this.label22.TabIndex = 53;
            this.label22.Text = "of";
            // 
            // buttonAltDeterminant
            // 
            this.buttonAltDeterminant.Location = new System.Drawing.Point(376, 193);
            this.buttonAltDeterminant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAltDeterminant.Name = "buttonAltDeterminant";
            this.buttonAltDeterminant.Size = new System.Drawing.Size(123, 23);
            this.buttonAltDeterminant.TabIndex = 52;
            this.buttonAltDeterminant.Text = "AltDeterminant";
            this.buttonAltDeterminant.UseVisualStyleBackColor = true;
            this.buttonAltDeterminant.Click += new System.EventHandler(this.buttonAltDeterminant_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(372, 220);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(261, 16);
            this.label23.TabIndex = 57;
            this.label23.Text = "*AltDeterminant does not account for Z-axis";
            // 
            // radioButtonDegrees
            // 
            this.radioButtonDegrees.AutoSize = true;
            this.radioButtonDegrees.Checked = true;
            this.radioButtonDegrees.Location = new System.Drawing.Point(253, 238);
            this.radioButtonDegrees.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDegrees.Name = "radioButtonDegrees";
            this.radioButtonDegrees.Size = new System.Drawing.Size(81, 20);
            this.radioButtonDegrees.TabIndex = 58;
            this.radioButtonDegrees.TabStop = true;
            this.radioButtonDegrees.Text = "Degrees";
            this.radioButtonDegrees.UseVisualStyleBackColor = true;
            this.radioButtonDegrees.CheckedChanged += new System.EventHandler(this.radioButtonDegrees_CheckedChanged);
            // 
            // radioButtonRadians
            // 
            this.radioButtonRadians.AutoSize = true;
            this.radioButtonRadians.Location = new System.Drawing.Point(337, 238);
            this.radioButtonRadians.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRadians.Name = "radioButtonRadians";
            this.radioButtonRadians.Size = new System.Drawing.Size(79, 20);
            this.radioButtonRadians.TabIndex = 59;
            this.radioButtonRadians.Text = "Radians";
            this.radioButtonRadians.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(189, 240);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 16);
            this.label24.TabIndex = 60;
            this.label24.Text = "Angle in:";
            // 
            // checkBoxShowFormVec
            // 
            this.checkBoxShowFormVec.AutoSize = true;
            this.checkBoxShowFormVec.Checked = true;
            this.checkBoxShowFormVec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowFormVec.Location = new System.Drawing.Point(539, 9);
            this.checkBoxShowFormVec.Name = "checkBoxShowFormVec";
            this.checkBoxShowFormVec.Size = new System.Drawing.Size(148, 20);
            this.checkBoxShowFormVec.TabIndex = 61;
            this.checkBoxShowFormVec.Text = "Show List of Vectors";
            this.checkBoxShowFormVec.UseVisualStyleBackColor = true;
            this.checkBoxShowFormVec.CheckedChanged += new System.EventHandler(this.checkBoxShowFormVec_CheckedChanged);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 299);
            this.Controls.Add(this.checkBoxShowFormVec);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.radioButtonRadians);
            this.Controls.Add(this.radioButtonDegrees);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBoxAltDeterminantVector2);
            this.Controls.Add(this.comboBoxAltDeterminantVector1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.buttonAltDeterminant);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.comboBoxResultOptions);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboBoxCrossProductVector2);
            this.Controls.Add(this.comboBoxCrossProductVector1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonCrossProduct);
            this.Controls.Add(this.buttonDeterminant);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxScalarProductVector2);
            this.Controls.Add(this.comboBoxScalarProductVector1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonScalarProduct);
            this.Controls.Add(this.buttonLength);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxAngleVector2);
            this.Controls.Add(this.comboBoxAngleVector1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonAngle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxDifferenceVector2);
            this.Controls.Add(this.comboBoxDifferenceVector1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.tabControlVectors);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCalculator";
            this.Text = "VectorCalculator (3-dimensional)";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.tabControlVectors.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.TabControl tabControlVectors;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_uX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_uY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_uZ;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_vX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_vY;
        private System.Windows.Forms.TextBox textBox_vZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_wZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_wY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_wX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDifferenceVector1;
        private System.Windows.Forms.ComboBox comboBoxDifferenceVector2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxAngleVector2;
        private System.Windows.Forms.ComboBox comboBoxAngleVector1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonAngle;
        private System.Windows.Forms.Button buttonLength;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxScalarProductVector2;
        private System.Windows.Forms.ComboBox comboBoxScalarProductVector1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonScalarProduct;
        private System.Windows.Forms.Button buttonDeterminant;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxCrossProductVector2;
        private System.Windows.Forms.ComboBox comboBoxCrossProductVector1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonCrossProduct;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxAltDeterminantVector2;
        private System.Windows.Forms.ComboBox comboBoxAltDeterminantVector1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonAltDeterminant;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton radioButtonDegrees;
        private System.Windows.Forms.RadioButton radioButtonRadians;
        private System.Windows.Forms.Label label24;
        internal System.Windows.Forms.ComboBox comboBoxResultOptions;
        internal System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.CheckBox checkBoxShowFormVec;
    }
}

