namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string abc = "ÀÁÂÃ¥ÄÅªÆÇÈ²¯ÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙŞßÜàáâã´äåºæçè³¿éêëìíîïğñòóôõö÷øùüşÿ '!?ÀÁÂÃ¥ÄÅªÆÇÈ²¯ÉÊËÌÍÎÏĞÑÒÓÔÕÖ×ØÙŞßÜàáâã´äåºæçè³¿éêëìíîïğñòóôõö÷øùüşÿ '!?";


        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text1 = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (text[i] == abc[j])
                    {
                        char x = abc[j + 3];
                        text1 = text1.Insert(i, x.ToString());
                        break;
                    }
                }
            }
            label1.Text = text1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text1 = "";
            int size = abc.Length - 1;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = size; j >= 0; j--)
                {
                    if (text[i] == abc[j])
                    {
                        char x = abc[j - 3];
                        text1 = text1.Insert(i, x.ToString());
                        break;
                    }
                    continue;
                }
            }
            label1.Text = text1;
        }
    }
}