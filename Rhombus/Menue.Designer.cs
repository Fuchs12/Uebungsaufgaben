
namespace Rhombus
{
    partial class Menue
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
            this.btnRhombus = new System.Windows.Forms.Button();
            this.btnSchraffierung = new System.Windows.Forms.Button();
            this.btnSchneckenbau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRhombus
            // 
            this.btnRhombus.Location = new System.Drawing.Point(37, 75);
            this.btnRhombus.Name = "btnRhombus";
            this.btnRhombus.Size = new System.Drawing.Size(145, 63);
            this.btnRhombus.TabIndex = 1;
            this.btnRhombus.Text = "Rhombus";
            this.btnRhombus.UseVisualStyleBackColor = true;
            this.btnRhombus.Click += new System.EventHandler(this.btnRhombus_Click);
            // 
            // btnSchraffierung
            // 
            this.btnSchraffierung.Location = new System.Drawing.Point(204, 75);
            this.btnSchraffierung.Name = "btnSchraffierung";
            this.btnSchraffierung.Size = new System.Drawing.Size(145, 63);
            this.btnSchraffierung.TabIndex = 2;
            this.btnSchraffierung.Text = "Schraffierung";
            this.btnSchraffierung.UseVisualStyleBackColor = true;
            this.btnSchraffierung.Click += new System.EventHandler(this.btnSchraffierung_Click);
            // 
            // btnSchneckenbau
            // 
            this.btnSchneckenbau.Location = new System.Drawing.Point(369, 75);
            this.btnSchneckenbau.Name = "btnSchneckenbau";
            this.btnSchneckenbau.Size = new System.Drawing.Size(145, 63);
            this.btnSchneckenbau.TabIndex = 3;
            this.btnSchneckenbau.Text = "Schneckenbau";
            this.btnSchneckenbau.UseVisualStyleBackColor = true;
            this.btnSchneckenbau.Click += new System.EventHandler(this.btnSchneckenbau_Click);
            // 
            // Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSchneckenbau);
            this.Controls.Add(this.btnSchraffierung);
            this.Controls.Add(this.btnRhombus);
            this.Name = "Menue";
            this.Text = "Übungsaufgabe Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRhombus;
        private System.Windows.Forms.Button btnSchraffierung;
        private System.Windows.Forms.Button btnSchneckenbau;
    }
}