namespace StockAPP.Views.RegisterForm
{
    public partial class RegisterDialog : Form
    {
        public RegisterDialog()
        {
            InitializeComponent();

            dateTimePickerValidate.Value = DateTime.Now;
            btnRegister.Enabled = false;

            txtBoxEan.KeyPress += OnValidateEan;

            txtBoxEan.TextChanged += OnEnabledButtonRegister;
            txtBoxProductName.TextChanged += OnEnabledButtonRegister;
        }

        public string ProductName { get => txtBoxProductName.Text; }
        public string EAN { get => txtBoxEan.Text;}
        public int Amount { get => ((int)numericAmount.Value);}
        public DateOnly Validate { get => DateOnly.FromDateTime(dateTimePickerValidate.Value);}

        private void OnValidateEan(object sender, KeyPressEventArgs key)
        {
            if(!char.IsDigit(key.KeyChar) && key.KeyChar != (char)Keys.Back)
            {
                key.Handled = true;
            }
        }

        private void OnEnabledButtonRegister(object sender, EventArgs e)
        {
            btnRegister.Enabled = !string.IsNullOrEmpty(txtBoxEan.Text) &&
                !string.IsNullOrEmpty(txtBoxProductName.Text) && txtBoxEan.Text.Count() == 13;
        }
    }
}
