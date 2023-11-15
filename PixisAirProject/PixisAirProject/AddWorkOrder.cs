using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirProject
{
    public partial class AddWorkOrder : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;
        public AddWorkOrder()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            RonaldForm rForm = new RonaldForm();
            rForm.Show();
            this.Hide();//hides current form
        }

        private void workOrderButton_Click(object sender, EventArgs e)
        {
            string cmdTxt = "INSERT INTO WORKORDER VALUES (@ORDERID, @PLANENO, @TASKID, @STRDAT, @ENDDAT, @WOSTAT, @PARTSLBR, @LBRHOURS)";

            try
            {
                conn = new iDB2Connection("Datasource=deathstar.gtc.edu");
                conn.Open();
                iDB2Command cmd = new iDB2Command(cmdTxt, conn);
                cmd.DeriveParameters();
                cmd.Parameters["@ORDERID"].Value = workOrderIDInput.Text;
                cmd.Parameters["@PLANENO"].Value = planeNumberInput.Text;
                cmd.Parameters["@TASKID"].Value = taskIDInput.Text;
                cmd.Parameters["@STRDAT"].Value = startDateInput.Text;
                cmd.Parameters["@ENDDAT"].Value = endDateInput.Text;
                cmd.Parameters["@WOSTAT"].Value = woStatInput.Text;
                cmd.Parameters["@PARTSLBR"].Value = Convert.ToDecimal(costInput.Text);
                cmd.Parameters["@LBRHOURS"].Value = Convert.ToDecimal(laborInput.Text);
                cmd.ExecuteNonQuery();
                workOrderListBox.Items.Add("item inserted");

                cmdTxt = "Select TASKDESC FROM TASKS WHERE TASKID = '" + taskIDInput.Text + "'";
                adapter = new iDB2DataAdapter(cmdTxt, conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                foreach (DataRow wRow in dataSet.Tables[0].Rows)
                {
                    workOrderListBox.Items.Add(wRow[0]);
                }
            }
            catch (Exception ex)
            {
                workOrderListBox.Items.Add(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
