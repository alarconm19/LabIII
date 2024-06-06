namespace Zoologico_WinForms
{
    partial class FichaPlanta
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
            textBoxID = new TextBox();
            comboBoxEspecie = new ComboBox();
            checkBoxHidratada = new CheckBox();
            checkBoxAlimentada = new CheckBox();
            buttonAceptar = new Button();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(46, 38);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(202, 23);
            textBoxID.TabIndex = 0;
            textBoxID.Text = "ID (autogenerada)";
            // 
            // comboBoxEspecie
            // 
            comboBoxEspecie.AccessibleDescription = "";
            comboBoxEspecie.AccessibleName = "";
            comboBoxEspecie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEspecie.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxEspecie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEspecie.Items.AddRange(new object[] { "Planta carnívora" });
            comboBoxEspecie.Location = new Point(46, 67);
            comboBoxEspecie.Name = "comboBoxEspecie";
            comboBoxEspecie.Size = new Size(202, 23);
            comboBoxEspecie.TabIndex = 6;
            comboBoxEspecie.Tag = "";
            comboBoxEspecie.SelectedIndexChanged += ComboBoxEspecie_SelectedIndexChanged;
            // 
            // checkBoxHidratada
            // 
            checkBoxHidratada.AutoSize = true;
            checkBoxHidratada.BackColor = Color.Transparent;
            checkBoxHidratada.Location = new Point(46, 96);
            checkBoxHidratada.Name = "checkBoxHidratada";
            checkBoxHidratada.Size = new Size(78, 19);
            checkBoxHidratada.TabIndex = 8;
            checkBoxHidratada.Text = "Hidratada";
            checkBoxHidratada.UseVisualStyleBackColor = false;
            // 
            // checkBoxAlimentada
            // 
            checkBoxAlimentada.AutoSize = true;
            checkBoxAlimentada.Location = new Point(46, 121);
            checkBoxAlimentada.Name = "checkBoxAlimentada";
            checkBoxAlimentada.Size = new Size(87, 19);
            checkBoxAlimentada.TabIndex = 9;
            checkBoxAlimentada.Text = "Alimentada";
            checkBoxAlimentada.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAceptar.Location = new Point(212, 156);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 10;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += ButtonAceptar_Click;
            // 
            // FichaPlanta
            // 
            AcceptButton = buttonAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(299, 191);
            Controls.Add(buttonAceptar);
            Controls.Add(checkBoxAlimentada);
            Controls.Add(checkBoxHidratada);
            Controls.Add(comboBoxEspecie);
            Controls.Add(textBoxID);
            Name = "FichaPlanta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ficha Planta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxID;
        private ComboBox comboBoxEspecie;
        private CheckBox checkBoxHidratada;
        private CheckBox checkBoxAlimentada;
        private Button buttonAceptar;
    }
}