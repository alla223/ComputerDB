using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQL
{
    class Controller
    {
        private Form1 form1;
       
        private Model model;
       
        public Controller(Form1 form1)
        {
            this.form1 = form1;
           model = new Model();
        }
        
        public void SELECT()
        {
         
                String strConn = "Server=117.17.142.111;Database=cosmosDB;Uid=cosmosjy;Pwd=1234;Charset=utf8";
                MySqlConnection conn = new MySqlConnection(strConn);
                MySqlDataAdapter adapter;
             
            try
            {
                conn.Open();
              
                string sql = "SELECT * FROM tbl_test";
                adapter = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "member");
               
                form1.dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //public void searchData(string valueToSearch)
        public void searchData(string valueToSearch)
        {
            String strConn = "Server=117.17.142.111;Database=cosmosDB;Uid=cosmosjy;Pwd=1234;Charset=utf8";
            MySqlConnection connection = new MySqlConnection(strConn);
            MySqlDataAdapter adapter;
            MySqlCommand command;
            DataTable table;
            string query = "SELECT *FROM tbl_test WHERE CONCAT(place_Num,IP,CPU,MainBoard,OS,GPU,RAM,HDD,SSD,Monitor,Reference)like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            form1.dataGridView1.DataSource = table;
            
        }

        public void specifyRow_SELECT(int placeNum) //자리 클릭했을때 placeNum에따라 그리드뷰에 나타남
        {

            String strConn = "Server=117.17.142.111;Database=cosmosDB;Uid=cosmosjy;Pwd=1234;Charset=utf8";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlDataAdapter adapter;

            try
            {
                conn.Open();

                string sql = "SELECT * FROM tbl_test where place_Num='" + placeNum + "'";
                adapter = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "member");

                form1.dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
         
    }
}
