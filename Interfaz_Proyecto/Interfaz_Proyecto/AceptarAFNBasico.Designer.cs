namespace Interfaz_Proyecto
{
    partial class AceptarAFNBasico
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
            TextAFNok = new Label();
            OK1 = new Button();
            SuspendLayout();
            // 
            // TextAFNok
            // 
            TextAFNok.AutoSize = true;
            TextAFNok.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextAFNok.Location = new Point(56, 51);
            TextAFNok.Name = "TextAFNok";
            TextAFNok.Size = new Size(316, 31);
            TextAFNok.TabIndex = 0;
            TextAFNok.Text = "El AFN se creo exitosamente";
            // 
            // OK1
            // 
            OK1.Location = new Point(180, 114);
            OK1.Name = "OK1";
            OK1.Size = new Size(65, 35);
            OK1.TabIndex = 1;
            OK1.Text = "OK";
            OK1.UseVisualStyleBackColor = true;
            OK1.Click += OK1_Click;
            // 
            // AceptarAFNBasico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 181);
            Controls.Add(OK1);
            Controls.Add(TextAFNok);
            Name = "AceptarAFNBasico";
            Text = "AceptarAFNBasico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextAFNok;
        private Button OK1;
    }
}