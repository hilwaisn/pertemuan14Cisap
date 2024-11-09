using MySqlConnector;
using pertemuan14.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan14
{
    public partial class Form1 : Form
    {
        private MahasiswaController mahasiswaController = new MahasiswaController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool showStudent()
        {
            DataGridView_Mahasiswa.DataSource = mahasiswaController.selectStudent(new MySqlCommand("SELECT * FROM mahasiswa"));
            DataGridView_Mahasiswa.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_Mahasiswa.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            return true;
        }

        private void guna2Btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*gif)|*.jpg;*.png;*.gif;";

            if(opf.ShowDialog() == DialogResult.OK)
                guna2PictureBox1.Image = Image.FromFile(opf.FileName);
        }
    }
}
