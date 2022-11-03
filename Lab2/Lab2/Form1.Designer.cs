namespace Lab2
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
            this.generateButt = new System.Windows.Forms.Button();
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.VectorGrid = new System.Windows.Forms.DataGridView();
            this.xVect = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.JacobiOutput = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterEps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RelaxationGrid = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.omegaInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xVect)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixPlace
            // 
            this.MatrixPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixPlace.ColumnHeadersVisible = false;
            this.MatrixPlace.Location = new System.Drawing.Point(24, 26);
            this.MatrixPlace.Name = "MatrixPlace";
            this.MatrixPlace.RowHeadersVisible = false;
            this.MatrixPlace.RowTemplate.Height = 25;
            this.MatrixPlace.Size = new System.Drawing.Size(480, 177);
            this.MatrixPlace.TabIndex = 1;
            // 
            // generateButt
            // 
            this.generateButt.Location = new System.Drawing.Point(525, 84);
            this.generateButt.Name = "generateButt";
            this.generateButt.Size = new System.Drawing.Size(124, 23);
            this.generateButt.TabIndex = 6;
            this.generateButt.Text = "Generate Matrix";
            this.generateButt.UseVisualStyleBackColor = true;
            this.generateButt.Click += new System.EventHandler(this.generateButt_Click);
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(525, 55);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(120, 23);
            this.Rows.TabIndex = 7;
            this.Rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Rows.ValueChanged += new System.EventHandler(this.Rows_ValueChanged);
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(525, 28);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(120, 23);
            this.Columns.TabIndex = 8;
            this.Columns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Columns.ValueChanged += new System.EventHandler(this.Columns_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Seidel method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VectorGrid
            // 
            this.VectorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VectorGrid.ColumnHeadersVisible = false;
            this.VectorGrid.Location = new System.Drawing.Point(24, 209);
            this.VectorGrid.Name = "VectorGrid";
            this.VectorGrid.RowHeadersVisible = false;
            this.VectorGrid.RowTemplate.Height = 25;
            this.VectorGrid.Size = new System.Drawing.Size(480, 38);
            this.VectorGrid.TabIndex = 13;
            // 
            // xVect
            // 
            this.xVect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xVect.ColumnHeadersVisible = false;
            this.xVect.Location = new System.Drawing.Point(24, 253);
            this.xVect.Name = "xVect";
            this.xVect.RowHeadersVisible = false;
            this.xVect.RowTemplate.Height = 25;
            this.xVect.Size = new System.Drawing.Size(480, 43);
            this.xVect.TabIndex = 14;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(510, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(211, 147);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // JacobiOutput
            // 
            this.JacobiOutput.Location = new System.Drawing.Point(727, 149);
            this.JacobiOutput.Name = "JacobiOutput";
            this.JacobiOutput.Size = new System.Drawing.Size(208, 147);
            this.JacobiOutput.TabIndex = 17;
            this.JacobiOutput.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(781, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Jacobi method";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 19;
            // 
            // enterEps
            // 
            this.enterEps.Location = new System.Drawing.Point(361, 382);
            this.enterEps.Name = "enterEps";
            this.enterEps.Size = new System.Drawing.Size(100, 23);
            this.enterEps.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Eps enter";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 440);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Output Iter Jacobi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Output Iter Seidel";
            // 
            // RelaxationGrid
            // 
            this.RelaxationGrid.Location = new System.Drawing.Point(510, 341);
            this.RelaxationGrid.Name = "RelaxationGrid";
            this.RelaxationGrid.Size = new System.Drawing.Size(208, 147);
            this.RelaxationGrid.TabIndex = 25;
            this.RelaxationGrid.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(510, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Relax";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // omegaInp
            // 
            this.omegaInp.Location = new System.Drawing.Point(361, 323);
            this.omegaInp.Name = "omegaInp";
            this.omegaInp.Size = new System.Drawing.Size(100, 23);
            this.omegaInp.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Omega";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(361, 353);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Relaxation Iter Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.omegaInp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RelaxationGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterEps);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.JacobiOutput);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.xVect);
            this.Controls.Add(this.VectorGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.generateButt);
            this.Controls.Add(this.MatrixPlace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatrixPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xVect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView MatrixPlace;
        private Button generateButt;
        private NumericUpDown Rows;
        private NumericUpDown Columns;
        private Button button1;
        private DataGridView VectorGrid;
        private Button buttVec;
        private DataGridView xVect;
        private RichTextBox richTextBox1;
        private RichTextBox JacobiOutput;
        private Button button2;
        private TextBox textBox1;
        private TextBox enterEps;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private RichTextBox RelaxationGrid;
        private Button button3;
        private TextBox omegaInp;
        private Label label1;
        private TextBox textBox3;
        private Label label5;
    }
}