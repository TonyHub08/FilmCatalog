using System;
using Business;
using Data.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NaskoEgotin.UI;

namespace NaskoEgotin
{
    public partial class Form1 : Form
    {
        public ProductBusinesss productBusiness = new ProductBusinesss();
        private int editId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Add_film addFilm = new Add_film();
            addFilm.ShowDialog();
        }
    }
}
