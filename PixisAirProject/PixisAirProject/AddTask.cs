using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Data.DB2.iSeries;
using System.Windows.Forms;

namespace PixisAirProject
{
    public partial class AddTask : Form
    {
        iDB2Connection conn;
        public AddTask()
        {
            InitializeComponent();
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            string cmdTxt = "INSERT INTO TASKS VALUES (@TASKID, @TASKDESC, @TASKHRS)";

            try
            {
                conn = new iDB2Connection("Datasource=deathstar.gtc.edu");
                conn.Open();
                iDB2Command cmd = new iDB2Command(cmdTxt, conn);
                cmd.DeriveParameters();
                cmd.Parameters["@TASKID"].Value = taskIDInput.Text;
                cmd.Parameters["@TASKDESC"].Value = taskDescInput.Text;
                cmd.Parameters["@TASKHRS"].Value = Convert.ToDecimal(taskHoursInput.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
            finally
            {
                conn.Close();
                errorLabel.Text = "Item inserted";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            RonaldForm rForm = new RonaldForm();
            rForm.Show();
            this.Hide();//hides current form
        }
    }
}
