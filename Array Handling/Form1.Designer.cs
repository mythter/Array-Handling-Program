namespace ArrayHandling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NLabel = new System.Windows.Forms.Label();
            this.NUpDown = new System.Windows.Forms.NumericUpDown();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.AUpDown = new System.Windows.Forms.NumericUpDown();
            this.BUpDown = new System.Windows.Forms.NumericUpDown();
            this.InitArrLabel = new System.Windows.Forms.Label();
            this.InitArrTextBox = new System.Windows.Forms.TextBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ReadF1Btn = new System.Windows.Forms.Button();
            this.WriteF1Btn = new System.Windows.Forms.Button();
            this.WriteF2Btn = new System.Windows.Forms.Button();
            this.GenBtn = new System.Windows.Forms.Button();
            this.OperationsGroup = new System.Windows.Forms.GroupBox();
            this.RadioOp4 = new System.Windows.Forms.RadioButton();
            this.RadioOp3 = new System.Windows.Forms.RadioButton();
            this.RadioOp2 = new System.Windows.Forms.RadioButton();
            this.RadioOp1 = new System.Windows.Forms.RadioButton();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SaveFileDialoge = new System.Windows.Forms.SaveFileDialog();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileDialoge = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUpDown)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.OperationsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NLabel.Location = new System.Drawing.Point(12, 18);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(109, 21);
            this.NLabel.TabIndex = 0;
            this.NLabel.Text = "Array size n =";
            // 
            // NUpDown
            // 
            this.NUpDown.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUpDown.Location = new System.Drawing.Point(127, 16);
            this.NUpDown.Name = "NUpDown";
            this.NUpDown.Size = new System.Drawing.Size(120, 26);
            this.NUpDown.TabIndex = 0;
            this.NUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALabel.Location = new System.Drawing.Point(258, 18);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(34, 21);
            this.ALabel.TabIndex = 2;
            this.ALabel.Text = "A =";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BLabel.Location = new System.Drawing.Point(422, 18);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(34, 21);
            this.BLabel.TabIndex = 3;
            this.BLabel.Text = "B =";
            // 
            // AUpDown
            // 
            this.AUpDown.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AUpDown.Location = new System.Drawing.Point(295, 16);
            this.AUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AUpDown.Name = "AUpDown";
            this.AUpDown.Size = new System.Drawing.Size(120, 26);
            this.AUpDown.TabIndex = 1;
            this.AUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BUpDown
            // 
            this.BUpDown.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BUpDown.Location = new System.Drawing.Point(459, 16);
            this.BUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BUpDown.Name = "BUpDown";
            this.BUpDown.Size = new System.Drawing.Size(120, 26);
            this.BUpDown.TabIndex = 2;
            this.BUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // InitArrLabel
            // 
            this.InitArrLabel.AutoSize = true;
            this.InitArrLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitArrLabel.Location = new System.Drawing.Point(12, 63);
            this.InitArrLabel.Name = "InitArrLabel";
            this.InitArrLabel.Size = new System.Drawing.Size(103, 21);
            this.InitArrLabel.TabIndex = 6;
            this.InitArrLabel.Text = "Initial Array :";
            // 
            // InitArrTextBox
            // 
            this.InitArrTextBox.Location = new System.Drawing.Point(114, 60);
            this.InitArrTextBox.Name = "InitArrTextBox";
            this.InitArrTextBox.ReadOnly = true;
            this.InitArrTextBox.Size = new System.Drawing.Size(463, 27);
            this.InitArrTextBox.TabIndex = 7;
            this.InitArrTextBox.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.CloseBtn);
            this.ControlPanel.Controls.Add(this.ButtonsPanel);
            this.ControlPanel.Controls.Add(this.GenBtn);
            this.ControlPanel.Controls.Add(this.OperationsGroup);
            this.ControlPanel.Location = new System.Drawing.Point(282, 118);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(295, 328);
            this.ControlPanel.TabIndex = 9;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.Location = new System.Drawing.Point(154, 266);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(126, 39);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ButtonsPanel.Controls.Add(this.ReadF1Btn);
            this.ButtonsPanel.Controls.Add(this.WriteF1Btn);
            this.ButtonsPanel.Controls.Add(this.WriteF2Btn);
            this.ButtonsPanel.Location = new System.Drawing.Point(9, 61);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(126, 244);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // ReadF1Btn
            // 
            this.ReadF1Btn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReadF1Btn.Location = new System.Drawing.Point(9, 21);
            this.ReadF1Btn.Name = "ReadF1Btn";
            this.ReadF1Btn.Size = new System.Drawing.Size(106, 50);
            this.ReadF1Btn.TabIndex = 2;
            this.ReadF1Btn.Text = "Read from F1";
            this.ReadF1Btn.UseVisualStyleBackColor = true;
            this.ReadF1Btn.Click += new System.EventHandler(this.ReadF1Btn_Click);
            // 
            // WriteF1Btn
            // 
            this.WriteF1Btn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WriteF1Btn.Location = new System.Drawing.Point(9, 96);
            this.WriteF1Btn.Name = "WriteF1Btn";
            this.WriteF1Btn.Size = new System.Drawing.Size(106, 50);
            this.WriteF1Btn.TabIndex = 1;
            this.WriteF1Btn.Text = "Write to F1";
            this.WriteF1Btn.UseVisualStyleBackColor = true;
            this.WriteF1Btn.Click += new System.EventHandler(this.WriteF1Btn_Click);
            // 
            // WriteF2Btn
            // 
            this.WriteF2Btn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WriteF2Btn.Location = new System.Drawing.Point(9, 171);
            this.WriteF2Btn.Name = "WriteF2Btn";
            this.WriteF2Btn.Size = new System.Drawing.Size(106, 50);
            this.WriteF2Btn.TabIndex = 0;
            this.WriteF2Btn.Text = "Write to F2";
            this.WriteF2Btn.UseVisualStyleBackColor = true;
            this.WriteF2Btn.Click += new System.EventHandler(this.WriteF2Btn_Click);
            // 
            // GenBtn
            // 
            this.GenBtn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenBtn.Location = new System.Drawing.Point(9, 16);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(126, 39);
            this.GenBtn.TabIndex = 1;
            this.GenBtn.Text = "Generate";
            this.GenBtn.UseVisualStyleBackColor = true;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // OperationsGroup
            // 
            this.OperationsGroup.Controls.Add(this.RadioOp4);
            this.OperationsGroup.Controls.Add(this.RadioOp3);
            this.OperationsGroup.Controls.Add(this.RadioOp2);
            this.OperationsGroup.Controls.Add(this.RadioOp1);
            this.OperationsGroup.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OperationsGroup.Location = new System.Drawing.Point(144, 10);
            this.OperationsGroup.Margin = new System.Windows.Forms.Padding(10);
            this.OperationsGroup.Name = "OperationsGroup";
            this.OperationsGroup.Size = new System.Drawing.Size(139, 243);
            this.OperationsGroup.TabIndex = 0;
            this.OperationsGroup.TabStop = false;
            this.OperationsGroup.Text = "Operations";
            // 
            // RadioOp4
            // 
            this.RadioOp4.AutoSize = true;
            this.RadioOp4.Location = new System.Drawing.Point(15, 195);
            this.RadioOp4.Name = "RadioOp4";
            this.RadioOp4.Size = new System.Drawing.Size(121, 25);
            this.RadioOp4.TabIndex = 3;
            this.RadioOp4.TabStop = true;
            this.RadioOp4.Text = "Operation 4";
            this.RadioOp4.UseVisualStyleBackColor = true;
            this.RadioOp4.Click += new System.EventHandler(this.Radio_Click);
            // 
            // RadioOp3
            // 
            this.RadioOp3.AutoSize = true;
            this.RadioOp3.Location = new System.Drawing.Point(15, 145);
            this.RadioOp3.Name = "RadioOp3";
            this.RadioOp3.Size = new System.Drawing.Size(119, 25);
            this.RadioOp3.TabIndex = 2;
            this.RadioOp3.TabStop = true;
            this.RadioOp3.Text = "Operation 3";
            this.RadioOp3.UseVisualStyleBackColor = true;
            this.RadioOp3.Click += new System.EventHandler(this.Radio_Click);
            // 
            // RadioOp2
            // 
            this.RadioOp2.AutoSize = true;
            this.RadioOp2.Location = new System.Drawing.Point(15, 95);
            this.RadioOp2.Name = "RadioOp2";
            this.RadioOp2.Size = new System.Drawing.Size(120, 25);
            this.RadioOp2.TabIndex = 1;
            this.RadioOp2.TabStop = true;
            this.RadioOp2.Text = "Operation 2";
            this.RadioOp2.UseVisualStyleBackColor = true;
            this.RadioOp2.Click += new System.EventHandler(this.Radio_Click);
            // 
            // RadioOp1
            // 
            this.RadioOp1.AutoSize = true;
            this.RadioOp1.Checked = true;
            this.RadioOp1.Location = new System.Drawing.Point(15, 45);
            this.RadioOp1.Name = "RadioOp1";
            this.RadioOp1.Size = new System.Drawing.Size(116, 25);
            this.RadioOp1.TabIndex = 0;
            this.RadioOp1.TabStop = true;
            this.RadioOp1.Text = "Operation 1";
            this.RadioOp1.UseVisualStyleBackColor = true;
            this.RadioOp1.Click += new System.EventHandler(this.Radio_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(13, 484);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(564, 183);
            this.ResultTextBox.TabIndex = 11;
            this.ResultTextBox.Text = "";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(13, 454);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(57, 21);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.Text = "Result";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.ArrColumn});
            this.DataGridView.Location = new System.Drawing.Point(12, 118);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 30;
            this.DataGridView.RowTemplate.Height = 29;
            this.DataGridView.Size = new System.Drawing.Size(253, 328);
            this.DataGridView.TabIndex = 13;
            // 
            // IndexColumn
            // 
            this.IndexColumn.FillWeight = 80F;
            this.IndexColumn.HeaderText = "i";
            this.IndexColumn.MinimumWidth = 6;
            this.IndexColumn.Name = "IndexColumn";
            this.IndexColumn.ReadOnly = true;
            this.IndexColumn.Width = 125;
            // 
            // ArrColumn
            // 
            this.ArrColumn.FillWeight = 80F;
            this.ArrColumn.HeaderText = "a[i]";
            this.ArrColumn.MinimumWidth = 6;
            this.ArrColumn.Name = "ArrColumn";
            this.ArrColumn.ReadOnly = true;
            this.ArrColumn.Width = 125;
            // 
            // OpenFileDialoge
            // 
            this.OpenFileDialoge.FileName = "array.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 678);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.InitArrTextBox);
            this.Controls.Add(this.InitArrLabel);
            this.Controls.Add(this.BUpDown);
            this.Controls.Add(this.AUpDown);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.NUpDown);
            this.Controls.Add(this.NLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(610, 725);
            this.MinimumSize = new System.Drawing.Size(610, 725);
            this.Name = "Form1";
            this.Text = "Array Handling Program";
            ((System.ComponentModel.ISupportInitialize)(this.NUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUpDown)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.OperationsGroup.ResumeLayout(false);
            this.OperationsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NLabel;
        private NumericUpDown NUpDown;
        private Label ALabel;
        private Label BLabel;
        private NumericUpDown AUpDown;
        private NumericUpDown BUpDown;
        private Label InitArrLabel;
        private TextBox InitArrTextBox;
        private Panel ControlPanel;
        private Button CloseBtn;
        private Panel ButtonsPanel;
        private Button ReadF1Btn;
        private Button WriteF1Btn;
        private Button WriteF2Btn;
        private Button GenBtn;
        private GroupBox OperationsGroup;
        private RadioButton RadioOp4;
        private RadioButton RadioOp3;
        private RadioButton RadioOp2;
        private RadioButton RadioOp1;
        private RichTextBox ResultTextBox;
        private Label ResultLabel;
        private SaveFileDialog SaveFileDialoge;
        private DataGridView DataGridView;
        private OpenFileDialog OpenFileDialoge;
        private DataGridViewTextBoxColumn IndexColumn;
        private DataGridViewTextBoxColumn ArrColumn;
    }
}