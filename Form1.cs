namespace SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int[] sayilar = new int[6];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(1, 35);

            }
            Array.Sort(sayilar);
            button1.Text = sayilar[0].ToString();
            button2.Text = sayilar[1].ToString();
            button3.Text = sayilar[2].ToString();
            button6.Text = sayilar[3].ToString();
            button5.Text = sayilar[4].ToString();
            button4.Text = sayilar[5].ToString();

            if (sayilar.Distinct().Count() != sayilar.Count())
            {
                button7_Click(sender, e);
            }
        }
    }
}