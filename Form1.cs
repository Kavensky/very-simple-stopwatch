﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        int m;
        int s;
        int ms;



        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 500;

            m = 0;
            s = 0;
            ms = 0;

            
              Minuts.Text = "00";
            label2.Text = "00";
            label3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;

                Start.Text = "Пуск";
                Stop.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;

                Start.Text = "Стоп";
                Stop.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            m = 0;
            s = 0;
            ms = 0;

            Minuts.Text = "00";
            label2.Text = "00";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.Visible)
            {
                if (s < 59)
                {
                    s++;
                    if (s < 10)
                        label2.Text = "0" + s.ToString();
                    else
                        label2.Text = s.ToString();
                }
                else
                {
                    if (m < 59)
                    {
                        m++;
                        if (m < 10)
                            Minuts.Text = "0" + m.ToString();
                        else
                            Minuts.Text = m.ToString();
                        s = 0;
                        label2.Text = "00";
                    }
                    else
                    {
                        m = 0;
                        Minuts.Text = "00";
                    }
                }
                label3.Visible = false;
            }
            else
                label3.Visible = true;
        }
    }
}