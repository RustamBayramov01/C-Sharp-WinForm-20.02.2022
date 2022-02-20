using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            InitializeComponent();

            comboBoxAdd();

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;


        }

        public void comboBoxAdd()
        {
            int i = 13;
            int count = 12;

            while (count != 0)
            {
                i--;

                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
                comboBox3.Items.Add(i);
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
                comboBox6.Items.Add(i);
                comboBox7.Items.Add(i);
                comboBox8.Items.Add(i);

                count--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            label21.Visible = false;
            label22.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Visible = true;
                button3.Visible = true;
                button1.Visible = true;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label21.Text = "Dersin Movzusu";

            if (textBox1.Text.Length != 0)
            {
                label21.Visible = true;
                label22.Visible = true;
                label22.Text = textBox1.Text;
                textBox1.Text = "";
                textBox1.Visible = false;
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label21.Text = "";
            label22.Text = "";
            radioButton1.Checked = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            radioButton9.Checked = true;
            radioButton12.Checked = true;
            radioButton15.Checked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { radioButton3.Checked = false; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            comboBox1.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox1.Items.Add("-");
                else comboBox1.Items.Add(12 - i);
            }
            textBox2.Text = (12 - index).ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;

            comboBox2.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox2.Items.Add("-");
                else comboBox2.Items.Add(12 - i);
            }
            textBox3.Text = (12 - index).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox3.SelectedIndex;

            comboBox3.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox3.Items.Add("-");
                else comboBox3.Items.Add(12 - i);
            }
            textBox4.Text = (12 - index).ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox4.SelectedIndex;

            comboBox4.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox4.Items.Add("-");
                else comboBox4.Items.Add(12 - i);
            }
            textBox5.Text = (12 - index).ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox8.SelectedIndex;

            comboBox8.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox8.Items.Add("-");
                else comboBox8.Items.Add(12 - i);
            }
            textBox6.Text = (12 - index).ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox7.SelectedIndex;

            comboBox7.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox7.Items.Add("-");
                else comboBox7.Items.Add(12 - i);
            }
            textBox7.Text = (12 - index).ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox6.SelectedIndex;

            comboBox6.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox6.Items.Add("-");
                else comboBox6.Items.Add(12 - i);
            }
            textBox8.Text = (12 - index).ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox5.SelectedIndex;

            comboBox5.Items.Clear();

            for (int i = 0; i < 12; i++)
            {
                if (index == i) comboBox5.Items.Add("-");
                else comboBox5.Items.Add(12 - i);
            }
            textBox9.Text = (12 - index).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox7.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;

                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox7.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox7.Enabled = true;

                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox10.Enabled = false;
                    checkBox12.Enabled = false;
                    checkBox7.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox10.Enabled = true;
                    checkBox12.Enabled = true;
                    checkBox7.Enabled = true;

                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                int result = int.Parse(label20.Text);
                result--;
                label20.Text = result.ToString();

                if (label20.Text == "0")
                {
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox8.Enabled = false;
                    checkBox9.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox11.Enabled = false;
                    checkBox12.Enabled = false;
                    checkBox7.Enabled = false;

                }
            }
            else
            {
                int result = int.Parse(label20.Text);
                result++;
                label20.Text = result.ToString();

                if (label20.Text != "0")
                {
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox6.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox8.Enabled = true;
                    checkBox9.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox11.Enabled = true;
                    checkBox12.Enabled = true;
                    checkBox7.Enabled = true;

                }
            }
        }
    }
}
