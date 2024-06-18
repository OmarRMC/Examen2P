namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            A_Paterno = new DataGridViewTextBoxColumn();
            A_Materno = new DataGridViewTextBoxColumn();
            fecha_nacimiento = new DataGridViewTextBoxColumn();
            Coreo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 42);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 0;
            button1.Text = "Refrescar DB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 1;
            label1.Text = "Ejercicio Uno - Lista de estudiantes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CI, Nombre, A_Paterno, A_Materno, fecha_nacimiento, Coreo });
            dataGridView1.Location = new Point(23, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(732, 214);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CI
            // 
            CI.HeaderText = "CI";
            CI.Name = "CI";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 110;
            // 
            // A_Paterno
            // 
            A_Paterno.HeaderText = "A_Paterno";
            A_Paterno.Name = "A_Paterno";
            A_Paterno.Width = 110;
            // 
            // A_Materno
            // 
            A_Materno.HeaderText = "A_Materno";
            A_Materno.Name = "A_Materno";
            A_Materno.Width = 110;
            // 
            // fecha_nacimiento
            // 
            fecha_nacimiento.HeaderText = "fecha_nacimiento";
            fecha_nacimiento.Name = "fecha_nacimiento";
            // 
            // Coreo
            // 
            Coreo.HeaderText = "Correo";
            Coreo.Name = "Coreo";
            Coreo.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn A_Paterno;
        private DataGridViewTextBoxColumn A_Materno;
        private DataGridViewTextBoxColumn fecha_nacimiento;
        private DataGridViewTextBoxColumn Coreo;
    }
}
