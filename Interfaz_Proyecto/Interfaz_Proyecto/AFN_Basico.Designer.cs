namespace Interfaz_Proyecto
{
    partial class AFN_Basico
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Rango1 = new TextBox();
            Rango2 = new TextBox();
            IdAFN = new TextBox();
            aceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 67);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 0;
            label1.Text = "Rango 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 140);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 1;
            label2.Text = "Rango 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 220);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Id del AFN";
            // 
            // Rango1
            // 
            Rango1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rango1.Location = new Point(193, 63);
            Rango1.Margin = new Padding(3, 4, 3, 4);
            Rango1.Name = "Rango1";
            Rango1.Size = new Size(61, 34);
            Rango1.TabIndex = 3;
            // 
            // Rango2
            // 
            Rango2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rango2.Location = new Point(194, 136);
            Rango2.Margin = new Padding(3, 4, 3, 4);
            Rango2.Name = "Rango2";
            Rango2.Size = new Size(60, 34);
            Rango2.TabIndex = 4;
            // 
            // IdAFN
            // 
            IdAFN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdAFN.Location = new Point(193, 216);
            IdAFN.Margin = new Padding(3, 4, 3, 4);
            IdAFN.Name = "IdAFN";
            IdAFN.Size = new Size(60, 34);
            IdAFN.TabIndex = 5;
            // 
            // aceptar
            // 
            aceptar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aceptar.Location = new Point(366, 117);
            aceptar.Margin = new Padding(3, 4, 3, 4);
            aceptar.Name = "aceptar";
            aceptar.Size = new Size(189, 69);
            aceptar.TabIndex = 6;
            aceptar.Text = "CREAR AFN";
            aceptar.UseVisualStyleBackColor = true;
            aceptar.Click += aceptar_Click;
            // 
            // AFN_Basico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 353);
            Controls.Add(aceptar);
            Controls.Add(IdAFN);
            Controls.Add(Rango2);
            Controls.Add(Rango1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AFN_Basico";
            Text = "AFN_Basico";
            Load += AFN_Basico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Rango1;
        private TextBox Rango2;
        private TextBox IdAFN;
        private Button aceptar;
    }
}