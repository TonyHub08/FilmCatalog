using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaskoEgotin.UI
{
    public partial class Add_film : Form
    {
        public Add_film()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            int year = int.Parse(textBoxYear.Text);
            string genre = textBoxGenre.Text;

            try
            {
                Film film = new Film();
                film.Title = title;
                film.Description = description;
                film.Year = year;
                film.Genre = genre;

                MessageBox.Show("Successfully added a film.");
                Close();
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}
