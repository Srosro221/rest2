﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FiltrPanel.Height = FiltrButton.Height;
        }

        private void HotelPB_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RestForm hotelForm = new RestForm(pb.Tag.ToString());
            hotelForm.ShowDialog();
        }

        private void HotelLabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            RestForm hotelForm = new RestForm(lbl.Text.ToString());
            hotelForm.ShowDialog();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height > 100)
            {
                FiltrPanel.Height = FiltrButton.Height;
            }
            else
            {
                FiltrPanel.Height = 150;
            }
        }
    }
}
