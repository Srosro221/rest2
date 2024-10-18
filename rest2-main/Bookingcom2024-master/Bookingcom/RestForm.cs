using System;
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
    public partial class RestForm : Form
    {
        public RestForm(string nameRest)
        {
            InitializeComponent();

            Text = nameRest;
            try
            {
                HotelPictureBox.Load("../../Pictures/" + nameRest + ".jpg");
            }
            catch (Exception) { };

            HotelLabel.Text = nameRest; 
        }

        private void RoomPB_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm roomForm = new RoomForm(pb.Tag.ToString());
            roomForm.ShowDialog();
        }

        private void Roomlabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            RoomForm roomForm = new RoomForm(lbl.Text.ToString());
            roomForm.ShowDialog();
        }
    }
}
