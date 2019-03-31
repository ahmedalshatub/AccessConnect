using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acconnect
{
    public partial class Form1 : Form
    {
        public OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StData.accdb ;Persist Security Info=False;");

        public Form1()
        {
            InitializeComponent();
            GetData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void GetData() {
            DataTable TheTable = new DataTable();
            Conn.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from StTable", Conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            TheTable.Load(reader);
            Conn.Close();
            dataGridView1.DataSource = TheTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
         

        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into StTable (Name) Values('"+NameBox.Text.Trim()+"')", Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();
            GetData();
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            int TheUserID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);

            //int TheUserID = 3;
            Conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete * From StTable Where ID="+TheUserID, Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();
            GetData();
        }

    }
}
