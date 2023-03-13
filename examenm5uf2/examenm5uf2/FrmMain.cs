namespace examenm5uf2
{
    public partial class FrmMain : Form
    {

        Form1 aa;
        Form2 bb;
        Form3 cc;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aa = new Form1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bb = new Form2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cc = new Form3();
        }
    }
}