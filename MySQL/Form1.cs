using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MySQL
{
    public partial class Form1 : Form
    {

        private Controller cont;
        //private string configurationManager; //searchData

        static String strConn = "Server=117.17.142.111;Database=cosmosDB;Uid=cosmosjy;Pwd=1234;Charset=utf8";
        MySqlConnection connection = new MySqlConnection(strConn);
        MySqlDataAdapter adapter;
        MySqlCommand command;
        DataTable table;


        public Form1()
        {
            InitializeComponent();
            cont = new Controller(this);

        }
        /*
        public void SELECT()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM tbl_test";
                adapter = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "member");
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        */


        private void Form1_Load(object sender, EventArgs e)
        {
            //searchData("");
        }
        /*
        public void searchData(string valueToSearch)
        {
            string query = "SELECT *FROM tbl_test WHERE CONCAT(place_Num,IP,CPU,MainBoard,OS,GPU,RAM,HDD,SSD,Monitor,Reference)like '%" + valueToSearch + "%'";

            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
         * */
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(1);
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            cont.SELECT();
        }

        public string conf { get; set; }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBoxValueToSearch.Text.ToString();
            //searchData(valueToSearch);
            cont.searchData(valueToSearch);
        }

        private void button2_Click(object sender, EventArgs e) //추가
        {

            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into tbl_test values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();
            cont.SELECT();
            MessageBox.Show("삽입 완료");


        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {

            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from tbl_test where place_Num='" + textBox1.Text + "'";
            command.ExecuteNonQuery();
            connection.Close();
            cont.SELECT();
            MessageBox.Show("삭제 완료");
        }



        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(2);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            panel2.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            panel3.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(3);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            panel3.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            panel4.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(4);
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            panel4.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            panel5.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(5);
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            panel5.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            panel6.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(6);
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            panel6.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            panel7.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(7);
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            panel7.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            panel8.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(8);
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            panel8.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            panel9.BackgroundImage = MySQL.Properties.Resources.bnt_down;
            cont.specifyRow_SELECT(9);
        }

        private void panel9_MouseUp(object sender, MouseEventArgs e)
        {
            panel9.BackgroundImage = MySQL.Properties.Resources.bnt_up;
        }
      
    }
}
