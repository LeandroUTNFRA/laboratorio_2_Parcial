namespace Parcial_Labo
{
    partial class FrmAtencion
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
            btnSalir = new Button();
            btnAtender = new Button();
            Medicos = new Label();
            Pacientes = new Label();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbInfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(854, 475);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(189, 74);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(854, 28);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(189, 75);
            btnAtender.TabIndex = 1;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // Medicos
            // 
            Medicos.AutoSize = true;
            Medicos.Location = new Point(12, 28);
            Medicos.Name = "Medicos";
            Medicos.Size = new Size(65, 20);
            Medicos.TabIndex = 2;
            Medicos.Text = "Medicos";
            // 
            // Pacientes
            // 
            Pacientes.AutoSize = true;
            Pacientes.Location = new Point(431, 28);
            Pacientes.Name = "Pacientes";
            Pacientes.Size = new Size(70, 20);
            Pacientes.TabIndex = 3;
            Pacientes.Text = "Pacientes";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 20;
            lstMedicos.Location = new Point(12, 51);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(384, 264);
            lstMedicos.TabIndex = 4;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 20;
            lstPacientes.Location = new Point(431, 51);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(395, 264);
            lstPacientes.TabIndex = 5;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 348);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(814, 201);
            rtbInfoMedico.TabIndex = 6;
            rtbInfoMedico.Text = "";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 561);
            Controls.Add(rtbInfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(Pacientes);
            Controls.Add(Medicos);
            Controls.Add(btnAtender);
            Controls.Add(btnSalir);
            Name = "FrmAtencion";
            Text = "Atencion de Pacientes";
            FormClosing += FrmAtencion_FormClosing;
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAtender;
        private Label Medicos;
        private Label Pacientes;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbInfoMedico;
    }
}