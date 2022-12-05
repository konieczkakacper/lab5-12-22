namespace savannah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (rozmiar_combo.Text.Equals("2x2")) ff2();
            else if (rozmiar_combo.Text.Equals("3x3")) ff3();
            else if (rozmiar_combo.Text.Equals("4x4")) ff4();
            else if (rozmiar_combo.Text.Equals("5x5")) ff5();
        }
        void ff2()
        {
            form2 form2 = new form2();
            form2.Show();

        }
        void ff3()
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        void ff4()
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        void ff5()
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void typ_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rozmiar_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}