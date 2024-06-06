namespace Zoologico_WinForms
{
    partial class FichaCuidador
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
            textBoxNombre = new TextBox();
            comboBoxTurno = new ComboBox();
            numericUpDownEdad = new NumericUpDown();
            buttonAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).BeginInit();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNombre.Location = new Point(49, 35);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(202, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // comboBoxTurno
            // 
            comboBoxTurno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTurno.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTurno.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            comboBoxTurno.Location = new Point(49, 64);
            comboBoxTurno.Name = "comboBoxTurno";
            comboBoxTurno.Size = new Size(202, 23);
            comboBoxTurno.TabIndex = 6;
            comboBoxTurno.Tag = "";
            // 
            // numericUpDownEdad
            // 
            numericUpDownEdad.Location = new Point(49, 93);
            numericUpDownEdad.Name = "numericUpDownEdad";
            numericUpDownEdad.Size = new Size(80, 23);
            numericUpDownEdad.TabIndex = 7;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAceptar.Location = new Point(212, 120);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 10;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += ButtonAceptar_Click;
            // 
            // FichaCuidador
            // 
            AcceptButton = buttonAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(299, 155);
            Controls.Add(buttonAceptar);
            Controls.Add(numericUpDownEdad);
            Controls.Add(comboBoxTurno);
            Controls.Add(textBoxNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FichaCuidador";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FichaCuidador";
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private ComboBox comboBoxTurno;
        private NumericUpDown numericUpDownEdad;
        private Button buttonAceptar;
    }
}