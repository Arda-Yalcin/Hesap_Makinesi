namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            int sayi1 = Convert.ToInt32(Number1MaskedTextBox.Text);
            int sayi2 = Convert.ToInt32(Number2MaskedTextBox.Text);

            char selectop = Convert.ToChar(ComboBox.Text);

            if (selectop == '+')
            {
                sonuc = sayi1 + sayi2;
            }
            else if (selectop == '-')
            {
                sonuc = sayi1 - sayi2;
            }
            else if (selectop == '/')
            {
                sonuc = sayi1 / sayi2;
            }
            else if (selectop == '*')
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                MessageBox.Show("Bir Öperatör Seçiniz","Hatalý Giriþ!");
            }
            listBox1.Items.Add(sonuc.ToString());
        }
    }
}
