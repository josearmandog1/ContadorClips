namespace ContadorClicsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnReiniciar;

        private void InitializeComponent()
        {
            this.lblContador = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblContador
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblContador.Location = new System.Drawing.Point(50, 30);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(200, 32);
            this.lblContador.Text = "Clics realizados: 0";

            // btnContar
            this.btnContar.Location = new System.Drawing.Point(53, 90);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(150, 40);
            this.btnContar.Text = "¡Haz Clic Aquí!";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);

            // btnReiniciar
            this.btnReiniciar.Location = new System.Drawing.Point(53, 140);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(150, 40);
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 220);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnReiniciar);
            this.Name = "Form1";
            this.Text = "Contador de Clics";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}