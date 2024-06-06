namespace Zoologico_WinForms
{
    partial class FichaAnimal
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
            comboBoxEspecie = new ComboBox();
            checkBoxAlimentado = new CheckBox();
            checkBoxEnfermo = new CheckBox();
            buttonAceptar = new Button();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNombre.Location = new Point(49, 33);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(202, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // comboBoxEspecie
            // 
            comboBoxEspecie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEspecie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEspecie.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEspecie.Items.AddRange(new object[] { "León", "Chimpance", "Aguila Real", "Pío", "Pez Payaso", "Pez Dorado" });
            comboBoxEspecie.Location = new Point(49, 65);
            comboBoxEspecie.Name = "comboBoxEspecie";
            comboBoxEspecie.Size = new Size(202, 23);
            comboBoxEspecie.TabIndex = 5;
            comboBoxEspecie.Tag = "";
            // 
            // checkBoxAlimentado
            // 
            checkBoxAlimentado.AutoSize = true;
            checkBoxAlimentado.BackColor = Color.Transparent;
            checkBoxAlimentado.Location = new Point(49, 125);
            checkBoxAlimentado.Name = "checkBoxAlimentado";
            checkBoxAlimentado.Size = new Size(88, 19);
            checkBoxAlimentado.TabIndex = 8;
            checkBoxAlimentado.Text = "Alimentado";
            checkBoxAlimentado.UseVisualStyleBackColor = false;
            // 
            // checkBoxEnfermo
            // 
            checkBoxEnfermo.AutoSize = true;
            checkBoxEnfermo.BackColor = Color.Transparent;
            checkBoxEnfermo.Location = new Point(49, 97);
            checkBoxEnfermo.Name = "checkBoxEnfermo";
            checkBoxEnfermo.Size = new Size(71, 19);
            checkBoxEnfermo.TabIndex = 7;
            checkBoxEnfermo.Text = "Enfermo";
            checkBoxEnfermo.UseVisualStyleBackColor = false;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAceptar.Location = new Point(212, 153);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 9;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += ButtonAceptar_Click;
            // 
            // FichaAnimal
            // 
            AcceptButton = buttonAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(299, 191);
            Controls.Add(buttonAceptar);
            Controls.Add(checkBoxEnfermo);
            Controls.Add(checkBoxAlimentado);
            Controls.Add(comboBoxEspecie);
            Controls.Add(textBoxNombre);
            Name = "FichaAnimal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ficha Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxNombre;
        private ComboBox comboBoxEspecie;
        private CheckBox checkBoxAlimentado;
        private CheckBox checkBoxEnfermo;
        private Button buttonAceptar;
    }
}