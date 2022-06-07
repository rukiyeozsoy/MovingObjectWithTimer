namespace Quiz
{
    public partial class Form1 : Form
    {
        public byte yon;
        public int boyut;
        public int x, y;
        public int sayac;
        Random rnd= new Random();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            x = 10; y = 10;
            boyut = 30;
            //pictureBox1.Location = new Point(x, y);
            pictureBox1.Size = new Size(boyut, boyut);
            sayac = 0;
            yon = 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Start();
            else
                timer1.Stop();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //yönün olduðu tarafa hareket saðla 
            sayac++;
            switch (yon)
            {
                case 1:
                    x -= 10;
                    break;
                case 2:
                    y += 10;
                    break;
                case 3:
                    y -= 10;
                    break;
                case 4:
                    x += 10;
                    break;
            }
            if (sayac % 10 == 0)
            {
                pictureBox1.BackColor = RasgeleRenk();
            }
            pictureBox1.Location = new Point(x, y);
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
                yon = 1;
            else if (e.KeyChar == 's' || e.KeyChar == 'S')
                yon = 2;
            else if (e.KeyChar == 'w' || e.KeyChar == 'W')
                yon = 3;
            else if (e.KeyChar == 'd' || e.KeyChar == 'D')
                yon = 4;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Color RasgeleRenk()
        {
            switch (rnd.Next(0, 4))
            {
                case 1:
                    return Color.Yellow;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Red;
                case 0:
                    return Color.White;
                default:
                    return Color.Black;
            }
        }

    }
}