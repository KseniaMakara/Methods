namespace Lab1
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
            this.MatrixPlace = new System.Windows.Forms.DataGridView();
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            this.output1 = new System.Windows.Forms.RichTextBox();
            this.outputGilb = new System.Windows.Forms.RichTextBox();
            this.generateButt = new System.Windows.Forms.Button();
            this.solButt = new System.Windows.Forms.Button();
            this.determ = new System.Windows.Forms.Button();
            this.detText = new System.Windows.Forms.RichTextBox();
            this.invMatr = new System.Windows.Forms.Button();
            this.InverseGrid = new System.Windows.Forms.DataGridView();
            this.GilbertGrid = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gilbGen = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InverseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GilbertGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixPlace
            // 
            this.MatrixPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixPlace.ColumnHeadersVisible = false;
            this.MatrixPlace.Location = new System.Drawing.Point(26, 12);
            this.MatrixPlace.Name = "MatrixPlace";
            this.MatrixPlace.RowHeadersVisible = false;
            this.MatrixPlace.RowTemplate.Height = 25;
            this.MatrixPlace.Size = new System.Drawing.Size(480, 177);
            this.MatrixPlace.TabIndex = 0;
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(660, 29);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(120, 23);
            this.Rows.TabIndex = 1;
            this.Rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Rows.ValueChanged += new System.EventHandler(this.Rows_ValueChanged_1);
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(660, 58);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(120, 23);
            this.Columns.TabIndex = 2;
            this.Columns.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Columns.ValueChanged += new System.EventHandler(this.Columns_ValueChanged_1);
            // 
            // output1
            // 
            this.output1.Location = new System.Drawing.Point(786, 27);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(176, 100);
            this.output1.TabIndex = 3;
            this.output1.Text = "";
            // 
            // outputGilb
            // 
            this.outputGilb.Location = new System.Drawing.Point(972, 87);
            this.outputGilb.Name = "outputGilb";
            this.outputGilb.Size = new System.Drawing.Size(246, 117);
            this.outputGilb.TabIndex = 4;
            this.outputGilb.Text = "";
            // 
            // generateButt
            // 
            this.generateButt.Location = new System.Drawing.Point(530, 27);
            this.generateButt.Name = "generateButt";
            this.generateButt.Size = new System.Drawing.Size(124, 23);
            this.generateButt.TabIndex = 5;
            this.generateButt.Text = "Generate Matrix";
            this.generateButt.UseVisualStyleBackColor = true;
            this.generateButt.Click += new System.EventHandler(this.generateButt_Click_1);
            // 
            // solButt
            // 
            this.solButt.Location = new System.Drawing.Point(530, 58);
            this.solButt.Name = "solButt";
            this.solButt.Size = new System.Drawing.Size(124, 23);
            this.solButt.TabIndex = 6;
            this.solButt.Text = "Solution";
            this.solButt.UseVisualStyleBackColor = true;
            this.solButt.Click += new System.EventHandler(this.solButt_Click);
            // 
            // determ
            // 
            this.determ.Location = new System.Drawing.Point(530, 87);
            this.determ.Name = "determ";
            this.determ.Size = new System.Drawing.Size(124, 23);
            this.determ.TabIndex = 7;
            this.determ.Text = "Determinant";
            this.determ.UseVisualStyleBackColor = true;
            this.determ.Click += new System.EventHandler(this.determ_Click);
            // 
            // detText
            // 
            this.detText.Location = new System.Drawing.Point(972, 27);
            this.detText.Name = "detText";
            this.detText.Size = new System.Drawing.Size(176, 37);
            this.detText.TabIndex = 8;
            this.detText.Text = "";
            // 
            // invMatr
            // 
            this.invMatr.Location = new System.Drawing.Point(530, 116);
            this.invMatr.Name = "invMatr";
            this.invMatr.Size = new System.Drawing.Size(124, 23);
            this.invMatr.TabIndex = 9;
            this.invMatr.Text = "Inverse Matrix";
            this.invMatr.UseVisualStyleBackColor = true;
            this.invMatr.Click += new System.EventHandler(this.invMatr_Click);
            // 
            // InverseGrid
            // 
            this.InverseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InverseGrid.ColumnHeadersVisible = false;
            this.InverseGrid.Location = new System.Drawing.Point(26, 225);
            this.InverseGrid.Name = "InverseGrid";
            this.InverseGrid.RowHeadersVisible = false;
            this.InverseGrid.RowTemplate.Height = 25;
            this.InverseGrid.Size = new System.Drawing.Size(480, 191);
            this.InverseGrid.TabIndex = 10;
            // 
            // GilbertGrid
            // 
            this.GilbertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GilbertGrid.ColumnHeadersVisible = false;
            this.GilbertGrid.Location = new System.Drawing.Point(563, 225);
            this.GilbertGrid.Name = "GilbertGrid";
            this.GilbertGrid.RowHeadersVisible = false;
            this.GilbertGrid.RowTemplate.Height = 25;
            this.GilbertGrid.Size = new System.Drawing.Size(480, 191);
            this.GilbertGrid.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(608, 432);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Сondition number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 491);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 15;
            // 
            // gilbGen
            // 
            this.gilbGen.Location = new System.Drawing.Point(760, 430);
            this.gilbGen.Name = "gilbGen";
            this.gilbGen.Size = new System.Drawing.Size(124, 23);
            this.gilbGen.TabIndex = 16;
            this.gilbGen.Text = "Fill Gilbert";
            this.gilbGen.UseVisualStyleBackColor = true;
            this.gilbGen.Click += new System.EventHandler(this.gilbGen_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(785, 487);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 645);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gilbGen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.GilbertGrid);
            this.Controls.Add(this.InverseGrid);
            this.Controls.Add(this.invMatr);
            this.Controls.Add(this.detText);
            this.Controls.Add(this.determ);
            this.Controls.Add(this.solButt);
            this.Controls.Add(this.generateButt);
            this.Controls.Add(this.outputGilb);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.MatrixPlace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InverseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GilbertGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView MatrixPlace;
        private NumericUpDown Rows;
        private NumericUpDown Columns;
        private RichTextBox output1;
        private RichTextBox outputGilb;
        private Button generateButt;
        private Button solButt;
        private Button determ;
        private RichTextBox detText;
        private Button invMatr;
        private DataGridView InverseGrid;
        private DataGridView GilbertGrid;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button gilbGen;
        private CheckBox checkBox1;
    }
}