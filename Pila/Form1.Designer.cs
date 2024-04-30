namespace Pila
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
            lstPila = new ListBox();
            label1 = new Label();
            txtDato = new TextBox();
            cmdInsertar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmdEliminar = new Button();
            cmdBuscar = new Button();
            SuspendLayout();
            // 
            // lstPila
            // 
            lstPila.FormattingEnabled = true;
            lstPila.ItemHeight = 28;
            lstPila.Location = new Point(24, 32);
            lstPila.Name = "lstPila";
            lstPila.Size = new Size(187, 368);
            lstPila.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 28);
            label1.TabIndex = 1;
            label1.Text = "Dato";
            // 
            // txtDato
            // 
            txtDato.Location = new Point(350, 33);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(141, 34);
            txtDato.TabIndex = 2;
            // 
            // cmdInsertar
            // 
            cmdInsertar.Location = new Point(280, 81);
            cmdInsertar.Name = "cmdInsertar";
            cmdInsertar.Size = new Size(211, 53);
            cmdInsertar.TabIndex = 3;
            cmdInsertar.Text = "Insertar";
            cmdInsertar.UseVisualStyleBackColor = true;
            cmdInsertar.Click += cmdInsertar_Click;
            // 
            // cmdEliminar
            // 
            cmdEliminar.Location = new Point(280, 140);
            cmdEliminar.Name = "cmdEliminar";
            cmdEliminar.Size = new Size(211, 53);
            cmdEliminar.TabIndex = 4;
            cmdEliminar.Text = "Eliminar";
            cmdEliminar.UseVisualStyleBackColor = true;
            cmdEliminar.Click += cmdEliminar_Click;
            // 
            // cmdBuscar
            // 
            cmdBuscar.Location = new Point(280, 199);
            cmdBuscar.Name = "cmdBuscar";
            cmdBuscar.Size = new Size(211, 53);
            cmdBuscar.TabIndex = 5;
            cmdBuscar.Text = "Buscar";
            cmdBuscar.UseVisualStyleBackColor = true;
            cmdBuscar.Click += cmdBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 416);
            Controls.Add(cmdBuscar);
            Controls.Add(cmdEliminar);
            Controls.Add(cmdInsertar);
            Controls.Add(txtDato);
            Controls.Add(label1);
            Controls.Add(lstPila);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPila;
        private Label label1;
        private TextBox txtDato;
        private Button cmdInsertar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button cmdEliminar;
        private Button cmdBuscar;
    }
}