namespace Arbol_Binario
{
    partial class Form1
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
            this.BtInsertar = new System.Windows.Forms.Button();
            this.TxDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtInsertar
            // 
            this.BtInsertar.Location = new System.Drawing.Point(24, 51);
            this.BtInsertar.Name = "BtInsertar";
            this.BtInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtInsertar.TabIndex = 0;
            this.BtInsertar.Text = "Insertar";
            this.BtInsertar.UseVisualStyleBackColor = true;
            this.BtInsertar.Click += new System.EventHandler(this.BtInsertar_Click);
            // 
            // TxDato
            // 
            this.TxDato.Location = new System.Drawing.Point(24, 81);
            this.TxDato.Name = "TxDato";
            this.TxDato.Size = new System.Drawing.Size(100, 20);
            this.TxDato.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 374);
            this.Controls.Add(this.TxDato);
            this.Controls.Add(this.BtInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtInsertar;
        private System.Windows.Forms.TextBox TxDato;
    }
}