namespace Zoologico_WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridViewZoologico = new DataGridView();
            buttonAgregarZoo = new Button();
            buttonModificarZoo = new Button();
            toolStrip = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            comboBoxSelectorDGV = new ComboBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewZoologico).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewZoologico
            // 
            dataGridViewZoologico.AllowUserToAddRows = false;
            dataGridViewZoologico.AllowUserToOrderColumns = true;
            dataGridViewZoologico.AllowUserToResizeRows = false;
            dataGridViewZoologico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewZoologico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewZoologico.BackgroundColor = SystemColors.Control;
            dataGridViewZoologico.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewZoologico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewZoologico.Location = new Point(42, 92);
            dataGridViewZoologico.Margin = new Padding(3, 4, 3, 4);
            dataGridViewZoologico.Name = "dataGridViewZoologico";
            dataGridViewZoologico.RowHeadersWidth = 51;
            dataGridViewZoologico.Size = new Size(600, 385);
            dataGridViewZoologico.TabIndex = 0;
            // 
            // buttonAgregarZoo
            // 
            buttonAgregarZoo.AccessibleDescription = "";
            buttonAgregarZoo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAgregarZoo.Location = new Point(439, 485);
            buttonAgregarZoo.Margin = new Padding(3, 4, 3, 4);
            buttonAgregarZoo.Name = "buttonAgregarZoo";
            buttonAgregarZoo.Size = new Size(98, 39);
            buttonAgregarZoo.TabIndex = 2;
            buttonAgregarZoo.Text = "Agregar";
            buttonAgregarZoo.UseVisualStyleBackColor = true;
            buttonAgregarZoo.Click += ButtonCrearZoo_Click;
            // 
            // buttonModificarZoo
            // 
            buttonModificarZoo.AccessibleDescription = "";
            buttonModificarZoo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonModificarZoo.Location = new Point(544, 485);
            buttonModificarZoo.Margin = new Padding(3, 4, 3, 4);
            buttonModificarZoo.Name = "buttonModificarZoo";
            buttonModificarZoo.Size = new Size(98, 39);
            buttonModificarZoo.TabIndex = 6;
            buttonModificarZoo.Text = "Modificar";
            buttonModificarZoo.UseVisualStyleBackColor = true;
            buttonModificarZoo.Click += ButtonModificarZoo_Click;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(693, 27);
            toolStrip.TabIndex = 12;
            toolStrip.Text = "toolStrip";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(29, 24);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += NewToolStripButton_Click;
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(29, 24);
            openToolStripButton.Text = "&Open";
            openToolStripButton.Click += OpenToolStripButton_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(29, 24);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += SaveToolStripButton_Click;
            // 
            // comboBoxSelectorDGV
            // 
            comboBoxSelectorDGV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSelectorDGV.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectorDGV.FormattingEnabled = true;
            comboBoxSelectorDGV.Items.AddRange(new object[] { "Animales", "Plantas", "Cuidadores" });
            comboBoxSelectorDGV.Location = new Point(510, 53);
            comboBoxSelectorDGV.Margin = new Padding(3, 4, 3, 4);
            comboBoxSelectorDGV.Name = "comboBoxSelectorDGV";
            comboBoxSelectorDGV.Size = new Size(132, 28);
            comboBoxSelectorDGV.TabIndex = 13;
            comboBoxSelectorDGV.SelectedIndexChanged += ComboBoxSelectorDGV_SelectedIndexChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(693, 567);
            Controls.Add(comboBoxSelectorDGV);
            Controls.Add(toolStrip);
            Controls.Add(buttonModificarZoo);
            Controls.Add(buttonAgregarZoo);
            Controls.Add(dataGridViewZoologico);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración del Zoologico";
            ((System.ComponentModel.ISupportInitialize)dataGridViewZoologico).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewZoologico;
        private Button buttonAgregarZoo;
        private Button buttonModificarZoo;
        private ToolStrip toolStrip;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ComboBox comboBoxSelectorDGV;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
