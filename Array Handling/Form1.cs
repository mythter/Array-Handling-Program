/*
Файл: Form1.cs
Лабораторная робота № 3
Автор: Положий А. С.
Тема: Розробка та дослідження програми обробки масивів
Дата створення: 09.03.2023
*/

using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

namespace ArrayHandling
{
    public partial class Form1 : Form, IView
    {
        #region Caret disabled
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void HideCaret()
        {
            HideCaret(InitArrTextBox.Handle);
            HideCaret(ResultTextBox.Handle);
        }
        #endregion

        int[]? Arr { get; set; }
        Presenter presenter;

        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);

            DataGridView.DataSource = Arr;
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
        }

        public int N { get => (int)NUpDown.Value; set => NUpDown.Value = value; }
        public int A { get => (int)AUpDown.Value; set => AUpDown.Value = value; }
        public int B { get => (int)BUpDown.Value; set => BUpDown.Value = value; }
        public string InitialArr { get => InitArrTextBox.Text; set => InitArrTextBox.Text = value; }
        public bool Op1 { get => RadioOp1.Checked; set => RadioOp1.Checked = value; }
        public bool Op2 { get => RadioOp2.Checked; set => RadioOp2.Checked = value; }
        public bool Op3 { get => RadioOp3.Checked; set => RadioOp3.Checked = value; }
        public bool Op4 { get => RadioOp4.Checked; set => RadioOp4.Checked = value; }
        public int[] Array { get => Arr; set => Arr = value; }
        public string Result { get => ResultTextBox.Text; set => ResultTextBox.Text = value; }
        public SaveFileDialog Save { get => SaveFileDialoge; set => Save = value; }
        public OpenFileDialog Open { get => OpenFileDialoge; set => Open = value; }
        public DataGridView DataGrid { get => DataGridView; set => DataGridView = value; }

        public event EventHandler? GenerateAttempted;
        public event EventHandler? WriteF1Attempted;
        public event EventHandler? WriteF2Attempted;
        public event EventHandler? ReadF1Attempted;
        public event EventHandler RadioCheckChanged;

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            GenerateAttempted?.Invoke(this, EventArgs.Empty);
        }

        private void WriteF1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                WriteF1Attempted?.Invoke(this, EventArgs.Empty);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Array does not exist\n\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void WriteF2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                WriteF2Attempted?.Invoke(this, EventArgs.Empty);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Array does not exist\n\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReadF1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                ReadF1Attempted?.Invoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred\n\n" + ex.ToString, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            HideCaret();
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            RadioCheckChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}