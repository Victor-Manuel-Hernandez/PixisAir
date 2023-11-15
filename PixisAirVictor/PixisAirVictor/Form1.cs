using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAirVictor
{
    public partial class Form1 : Form
    {

        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;


        public Form1()
        {
            InitializeComponent();
        }

        private void taskBtn_Click(object sender, EventArgs e)
        {
            string sql;

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                conn.Open();
                sql = "Select * FROM TASKS";
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                listBox1.Items.Clear();

                foreach (DataRow wRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(wRow[0] + "    " + wRow[1] + "    " + wRow[2]);
                conn.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string sql;
            string connectionName = "IBMConnectionString";
            string planeNumber = textBox1.Text.ToString(); 

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                conn.Open();
                sql = ("Select * FROM AIRPLANE WHERE PLANENO ='" + @planeNumber + "'");
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                listBox1.Items.Clear();

                foreach (DataRow wRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(wRow[0] + "    " + wRow[1] + "    " + wRow[2] + "    " + wRow[3]
                        + "    " + wRow[4] + "    " + wRow[5] + "    " + 
                        wRow[6] + "    " + wRow[7] + "    " + wRow[8] + "    " + wRow[9] + "    " + wRow[10]
                        + "    " + wRow[11]);
                conn.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void dspCustBtn_Click(object sender, EventArgs e)
        {
            string sql;
            string connectionName = "IBMConnectionString";


            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                conn.Open();
                sql = ("Select * FROM GTCSTP");
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                listBox1.Items.Clear();

                foreach (DataRow wRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(wRow[0] + "    " + wRow[1] + "    " + wRow[2] + "    " + wRow[3]
                        + "    " + wRow[4] + "    " + wRow[5] + "    " +
                        wRow[6] + "    " + wRow[7] + "    " + wRow[8] + "    " + wRow[9] + "    " + wRow[10]
                        );
                conn.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
