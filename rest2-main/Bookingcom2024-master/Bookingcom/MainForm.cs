using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bookingcom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            List<string> cities = SQLClass.MySelect("SELECT id, name FROM cities");
            List<string> restorans = SQLClass.MySelect("SELECT id, name, rating, id_city, image FROM restorans");


            for(int i = 0; i<cities.Count; i+=2)
            {
              CityComboBox.Items.Add(cities[i] +". "+ cities[i+1]);
            }
            int x = 50;
            for (int i = 0; i<restorans.Count; i+=5)
            {
                Label lbl = new Label();
                lbl.Text = restorans[i+1];
                lbl.Location = new Point(x, 330);
                lbl.Size = new Size(150, 20);
                lbl.Tag = restorans[i];
                lbl.Click += new EventHandler(HotelLabel_Click);
                MainPanel.Controls.Add(lbl);


                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + restorans[i + 4]);
                }
                catch (Exception) { }

                pb.Location = new Point(x, 50);
                pb.Size = new Size(350, 250);
                MainPanel.Controls.Add(pb);
                
                               
                
                x += 360;
            }








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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
