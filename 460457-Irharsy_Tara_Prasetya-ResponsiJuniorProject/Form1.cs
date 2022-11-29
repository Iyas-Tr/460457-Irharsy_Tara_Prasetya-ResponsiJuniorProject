using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _460457_Irharsy_Tara_Prasetya_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            /*
            dgv1 Data.DataSource = null;
            sql = "SELECT * FROM public.departemen;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable;
            NpgsqlDataReader = cmd.ExecuteReader();
            dt.Load(rd);
            dgv1 Data.DataSource = dt;
            */
            conn.Close();
        }

        private void tbNamaKaryawan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDepKaryawan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            /*
            dgv1 Data.DataSource = null;
            sql = "SELECT * FROM public.departemen;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable;
            NpgsqlDataReader = cmd.ExecuteReader();
            dt.Load(rd);
            dgv1 Data.DataSource = dt;
            */
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            /*
            dgv1 Data.DataSource = null;
            sql = "SELECT * FROM public.departemen;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable;
            NpgsqlDataReader = cmd.ExecuteReader();
            dt.Load(rd);
            dgv1 Data.DataSource = dt;
            */
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            /*
            dgv1 Data.DataSource = null;
            sql = "SELECT * FROM public.departemen;";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable;
            NpgsqlDataReader = cmd.ExecuteReader();
            dt.Load(rd);
            dgv1 Data.DataSource = dt;
            */
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void depKaryawan_Click(object sender, EventArgs e)
        {

        }

        private void idDepartemen_Click(object sender, EventArgs e)
        {

        }
    }
}
