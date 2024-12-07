namespace WASP.BinaryToBarrelConverter
{
    partial class Form1
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
            textBox1 = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            datapackFormatToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            worldFolderToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            directionToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            instructionCountPerROMAddressToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox2 = new ToolStripTextBox();
            btnStartConverting = new ToolStripButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            progressBar1 = new ProgressBar();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Dock = DockStyle.Fill;
            textBox1.ForeColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(0, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(800, 403);
            textBox1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, btnStartConverting });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.BackColor = Color.FromArgb(64, 64, 64);
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { datapackFormatToolStripMenuItem, worldFolderToolStripMenuItem, directionToolStripMenuItem, instructionCountPerROMAddressToolStripMenuItem });
            toolStripDropDownButton1.ForeColor = Color.FromArgb(224, 224, 224);
            toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton1.ImageTransparentColor = Color.Transparent;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(76, 24);
            toolStripDropDownButton1.Text = "Settings";
            // 
            // datapackFormatToolStripMenuItem
            // 
            datapackFormatToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            datapackFormatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            datapackFormatToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            datapackFormatToolStripMenuItem.Name = "datapackFormatToolStripMenuItem";
            datapackFormatToolStripMenuItem.Size = new Size(320, 26);
            datapackFormatToolStripMenuItem.Text = "Datapack Format";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = Color.FromArgb(64, 64, 64);
            toolStripTextBox1.ForeColor = Color.FromArgb(224, 224, 224);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // worldFolderToolStripMenuItem
            // 
            worldFolderToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            worldFolderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            worldFolderToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            worldFolderToolStripMenuItem.Name = "worldFolderToolStripMenuItem";
            worldFolderToolStripMenuItem.Size = new Size(320, 26);
            worldFolderToolStripMenuItem.Text = "World Folder";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(83, 26);
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // directionToolStripMenuItem
            // 
            directionToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            directionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            directionToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            directionToolStripMenuItem.Name = "directionToolStripMenuItem";
            directionToolStripMenuItem.Size = new Size(320, 26);
            directionToolStripMenuItem.Text = "Direction";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "North", "East", "South", "West" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.TextChanged += toolStripComboBox1_TextChanged;
            // 
            // instructionCountPerROMAddressToolStripMenuItem
            // 
            instructionCountPerROMAddressToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            instructionCountPerROMAddressToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox2 });
            instructionCountPerROMAddressToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            instructionCountPerROMAddressToolStripMenuItem.Name = "instructionCountPerROMAddressToolStripMenuItem";
            instructionCountPerROMAddressToolStripMenuItem.Size = new Size(320, 26);
            instructionCountPerROMAddressToolStripMenuItem.Text = "Instruction count per ROM address";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            toolStripTextBox2.TextChanged += toolStripTextBox2_TextChanged;
            // 
            // btnStartConverting
            // 
            btnStartConverting.Alignment = ToolStripItemAlignment.Right;
            btnStartConverting.BackColor = Color.FromArgb(0, 192, 0);
            btnStartConverting.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnStartConverting.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartConverting.ForeColor = Color.Black;
            btnStartConverting.ImageTransparentColor = Color.Magenta;
            btnStartConverting.Name = "btnStartConverting";
            btnStartConverting.Size = new Size(128, 24);
            btnStartConverting.Text = "Start Converting";
            btnStartConverting.Click += btnStartConverting_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(64, 64, 64);
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.FromArgb(0, 86, 211);
            progressBar1.Location = new Point(0, 430);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 20);
            progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "WASP.BinaryToBarrelConverter";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ToolStrip toolStrip1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem datapackFormatToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripMenuItem worldFolderToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem directionToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem instructionCountPerROMAddressToolStripMenuItem;
        private ToolStripButton btnStartConverting;
        private ProgressBar progressBar1;
        private ToolStripTextBox toolStripTextBox2;
    }
}
