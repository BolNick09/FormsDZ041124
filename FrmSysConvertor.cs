namespace DZ4
{
    public partial class FrmSysConvertor : Form
    {
        public FrmSysConvertor()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string decimalValue = tb10.Text;
            int number;
            if (int.TryParse(decimalValue, out number))
            {

                string binaryValue = Convert.ToString(number, 2);
                tb2.Text = binaryValue;

                string octalValue = Convert.ToString(number, 8);
                tb8.Text = octalValue;

                string hexValue = Convert.ToString(number, 16);
                tb16.Text = hexValue;
            }
        }
    }
}
