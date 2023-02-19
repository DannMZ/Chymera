namespace Chymera
{
    public partial class Form1 : Form
    {
        public List<As> Perverts=new List<As>();
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("HotMAN");
            comboBox1.Items.Add("WeAllMan");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = 10;
            switch (comboBox1.TabIndex) {
                case 0:Perverts.Add(new Hotman());
                    listBox1.Items.Add(Perverts[Perverts.Count-1].Name_Of_Character);
                    break;
                case 1:
                    Perverts.Add(new Weallman());
                    listBox1.Items.Add(Perverts[Perverts.Count - 1].Name_Of_Character);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Perverts.Add(Perverts[listBox1.SelectedIndex].Clone_this_Character());
                listBox1.Items.Add(Perverts[Perverts.Count - 1].Name_Of_Character);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                label1.Text = Perverts[listBox1.SelectedIndex].Job_Of_Character;
                textBox1.Text = Perverts[listBox1.SelectedIndex].Name_Of_Character;
                textBox2.Text = Perverts[listBox1.SelectedIndex].Gender_Of_Character;
                pictureBox1.Image = Perverts[listBox1.SelectedIndex].Jak_Vony_Tam();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Perverts[listBox1.SelectedIndex].Set_Image_For_Character(pictureBox1.Image);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
                pictureBox1.Image = pictureBox2.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Perverts[listBox1.SelectedIndex].Set_Name_For_Character(textBox1.Text);
                listBox1.Items[listBox1.SelectedIndex] = Perverts[listBox1.SelectedIndex].Name_Of_Character;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Perverts[listBox1.SelectedIndex].Set_Gender_For_Character(textBox2.Text);
        }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                }
            }
        }
    }
}