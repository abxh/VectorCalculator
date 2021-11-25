namespace VectorCalculator
{
    partial class FormVectorListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVectorListBox));
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxVectors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonResultantVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(212, 47);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(133, 28);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxVectors
            // 
            this.listBoxVectors.FormattingEnabled = true;
            this.listBoxVectors.ItemHeight = 16;
            this.listBoxVectors.Location = new System.Drawing.Point(16, 47);
            this.listBoxVectors.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVectors.Name = "listBoxVectors";
            this.listBoxVectors.Size = new System.Drawing.Size(187, 228);
            this.listBoxVectors.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vectors (to add together):";
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(212, 82);
            this.buttonRemoveSelected.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(133, 28);
            this.buttonRemoveSelected.TabIndex = 3;
            this.buttonRemoveSelected.Text = "Remove Selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonResultantVector
            // 
            this.buttonResultantVector.Location = new System.Drawing.Point(211, 118);
            this.buttonResultantVector.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResultantVector.Name = "buttonResultantVector";
            this.buttonResultantVector.Size = new System.Drawing.Size(133, 42);
            this.buttonResultantVector.TabIndex = 4;
            this.buttonResultantVector.Text = "Find Resulting Vector";
            this.buttonResultantVector.UseVisualStyleBackColor = true;
            this.buttonResultantVector.Click += new System.EventHandler(this.buttonResultingVector_Click);
            // 
            // FormVectorListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 299);
            this.Controls.Add(this.buttonResultantVector);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxVectors);
            this.Controls.Add(this.buttonClear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVectorListBox";
            this.Text = "List of vectors";
            this.Load += new System.EventHandler(this.FormVectorListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxVectors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonResultantVector;
    }
}