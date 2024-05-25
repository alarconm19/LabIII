
namespace adoNetDesconectado
{
    partial class Ficha
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNOM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAPEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTIT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFNAC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDIR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(421, 355);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(137, 50);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(257, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textBoxNOM
            // 
            this.textBoxNOM.Location = new System.Drawing.Point(137, 97);
            this.textBoxNOM.Name = "textBoxNOM";
            this.textBoxNOM.Size = new System.Drawing.Size(257, 22);
            this.textBoxNOM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // textBoxAPEL
            // 
            this.textBoxAPEL.Location = new System.Drawing.Point(137, 144);
            this.textBoxAPEL.Name = "textBoxAPEL";
            this.textBoxAPEL.Size = new System.Drawing.Size(257, 22);
            this.textBoxAPEL.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Titulo";
            // 
            // textBoxTIT
            // 
            this.textBoxTIT.Location = new System.Drawing.Point(137, 282);
            this.textBoxTIT.Name = "textBoxTIT";
            this.textBoxTIT.Size = new System.Drawing.Size(257, 22);
            this.textBoxTIT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Nac";
            // 
            // textBoxFNAC
            // 
            this.textBoxFNAC.Location = new System.Drawing.Point(137, 235);
            this.textBoxFNAC.Name = "textBoxFNAC";
            this.textBoxFNAC.Size = new System.Drawing.Size(257, 22);
            this.textBoxFNAC.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Direccion";
            // 
            // textBoxDIR
            // 
            this.textBoxDIR.Location = new System.Drawing.Point(137, 188);
            this.textBoxDIR.Name = "textBoxDIR";
            this.textBoxDIR.Size = new System.Drawing.Size(257, 22);
            this.textBoxDIR.TabIndex = 7;
            // 
            // Ficha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTIT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFNAC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAPEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "Ficha";
            this.Text = "Ficha";
            this.Load += new System.EventHandler(this.Ficha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAPEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTIT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFNAC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDIR;
    }
}