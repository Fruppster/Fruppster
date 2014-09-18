using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3_Effective_Damage_Calculator
{
    public partial class Form1 : Form
    {
        float head = 1, shoulder = 1, neck = 1, gloves = 1, chest = 1, bracers = 1, waist = 1, legs = 1, boots = 1, ring1 = 1, ring2 = 1, mainHand = 1, offHand = 1,
            gem1 = 1, gem2 = 1, gem3 = 1, passive1 = 1, passive2 = 1, passive3 = 1, passive4 = 1, other = 1, tempBuff = 1, baseDamage, effectiveDamage, buffedDamage;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            effectiveDamage = head * shoulder * neck * gloves * chest * bracers * waist * legs * boots * ring1 * ring2 * mainHand * offHand *
            gem1 * gem2 * gem3 * passive1 * passive2 * passive3 * passive4 * baseDamage * other;

            buffedDamage = effectiveDamage * tempBuff;

            textBox24.Text = buffedDamage.ToString();
            textBox25.Text = effectiveDamage.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox1.Text, out f);
            head = ((100 + f) / 100);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox2.Text, out f);
            shoulder = ((100 + f) / 100);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox3.Text, out f);
            neck = ((100 + f) / 100);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox4.Text, out f);
            gloves = ((100 + f) / 100);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox5.Text, out f);
            chest = ((100 + f) / 100);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox6.Text, out f);
            bracers = ((100 + f) / 100);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox7.Text, out f);
            waist = ((100 + f) / 100);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox8.Text, out f);
            legs = ((100 + f) / 100);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox9.Text, out f);
            boots = ((100 + f) / 100);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox10.Text, out f);
            ring1 = ((100 + f) / 100);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox11.Text, out f);
            ring2 = ((100 + f) / 100);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox12.Text, out f);
            mainHand = ((100 + f) / 100);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox13.Text, out f);
            offHand = ((100 + f) / 100);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox14.Text, out f);
            gem1 = ((100 + f) / 100);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox15.Text, out f);
            gem2 = ((100 + f) / 100);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox16.Text, out f);
            gem3 = ((100 + f) / 100);
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox17.Text, out f);
            passive1 = ((100 + f) / 100);
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox18.Text, out f);
            passive2 = ((100 + f) / 100);
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox19.Text, out f);
            passive3 = ((100 + f) / 100);
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox20.Text, out f);
            passive4 = ((100 + f) / 100);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox21.Text, out f);
            other = ((100 + f) / 100);
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox22.Text, out f);
            tempBuff = ((100 + f) / 100);
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            float f = 0;
            Single.TryParse(textBox23.Text, out f);
            baseDamage = f;
        }
    }
}
