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

namespace PixisAirProject
{
    public partial class RonaldForm : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;
        public RonaldForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //make menuForm object
            //menuForm.show(); show menu form
            this.Hide();//hides current form
        }

        private void jobButton_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conn = new iDB2Connection("Datasource=deathstar.gtc.edu");
                conn.Open();
                sql = "Select * From JOBTYPE";
                adapter = new iDB2DataAdapter(sql, conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                jobListBox.Items.Clear();

                foreach (DataRow wRow in dataSet.Tables[0].Rows)
                    jobListBox.Items.Add(wRow[0]+ "    " + wRow[1] + "  " + wRow[2] + "  " + wRow[3] + "  " + wRow[4]);
            }
            catch (Exception ex)
            {
                jobListBox.Items.Add(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void workorderButton_Click(object sender, EventArgs e)
        {
            AddWorkOrder addwd = new AddWorkOrder();
            addwd.Show();
            this.Hide();//hides current form
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            AddTask addt = new AddTask();
            addt.Show();
            this.Hide();//hides current form
        }

        private void RonaldForm_Load(object sender, EventArgs e)
        {

        }
    }
}
