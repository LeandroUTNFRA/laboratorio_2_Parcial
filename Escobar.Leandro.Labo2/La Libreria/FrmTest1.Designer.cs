namespace La_Libreria
{
    partial class FrmTest1
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
            btnVender = new Button();
            btnInforme = new Button();
            btnSalir = new Button();
            lstStock = new ListBox();
            rtbInforme = new RichTextBox();
            SuspendLayout();
            // 
            // btnVender
            // 
            btnVender.Location = new Point(12, 368);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(309, 56);
            btnVender.TabIndex = 0;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click_1;
            // 
            // btnInforme
            // 
            btnInforme.Location = new Point(12, 430);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(309, 56);
            btnInforme.TabIndex = 1;
            btnInforme.Text = "Informe";
            btnInforme.UseVisualStyleBackColor = true;
            btnInforme.Click += btnInforme_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 492);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(309, 50);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.ItemHeight = 20;
            lstStock.Location = new Point(12, 13);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(309, 344);
            lstStock.TabIndex = 3;
            // 
            // rtbInforme
            // 
            rtbInforme.Location = new Point(346, 13);
            rtbInforme.Name = "rtbInforme";
            rtbInforme.Size = new Size(442, 529);
            rtbInforme.TabIndex = 4;
            rtbInforme.Text = "";
            // 
            // FrmTest1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(rtbInforme);
            Controls.Add(lstStock);
            Controls.Add(btnSalir);
            Controls.Add(btnInforme);
            Controls.Add(btnVender);
            Name = "FrmTest1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            FormClosing += FrmTest1_FormClosing;
            Load += FrmTest1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVender;
        private Button btnInforme;
        private Button btnSalir;
        private ListBox lstStock;
        private RichTextBox rtbInforme;
    }
}