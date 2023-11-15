
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
    public partial class AddCustomer : Form
    {
        iDB2Connection conn;



        public AddCustomer()
        {
            InitializeComponent();
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO GTCSTP VALUES (@CPHONE, @CLNAME, @CFNAME," +
                    " @CSTRET, @CCITY, @CSTAT, @CZIP, @CURBIL, @AMTOWE," +
                    " @PAYDAT, @PAYDATL)";

            /*string sql = "INSERT INTO GTCSTP VALUES (7777777777, 'z', 'z', 'z', 'z', " +
                "'z', 77777, 0.00, 0.00, 20170202, '2017-02-02')";*/

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                conn.Open();       

                 iDB2Command cmd = new iDB2Command(sql, conn);
                 cmd.DeriveParameters();
                 cmd.Parameters["@CPHONE"].Value = Convert.ToDecimal(phoneTb.Text);
                 cmd.Parameters["@CLNAME"].Value = Convert.ToString(lNameTb.Text); 
                 cmd.Parameters["@CFNAME"].Value = Convert.ToString(fNameTb.Text);
                 cmd.Parameters["@CSTRET"].Value = Convert.ToString(streetTb.Text);
                 cmd.Parameters["@CCITY"].Value = Convert.ToString(cityTb.Text);
                 cmd.Parameters["@CSTAT"].Value = Convert.ToString(stateTb.Text);
                 cmd.Parameters["@CZIP"].Value = Convert.ToDecimal(zipTb.Text);
                 cmd.Parameters["@CURBIL"].Value = Convert.ToDecimal(billTb.Text);
                 cmd.Parameters["@AMTOWE"].Value = Convert.ToDecimal(amtOwedTb.Text);
                 cmd.Parameters["@PAYDAT"].Value = Convert.ToDecimal(payDateTb.Text);
                 cmd.Parameters["@PAYDATL"].Value = Convert.ToString(payDateLTb.Text);
                 cmd.ExecuteNonQuery();


                conn.Close();

                String feedback = "Member: " + "\n" + phoneTb.Text + "\n" + fNameTb.Text + "\n" +
                lNameTb.Text + "\n" + streetTb.Text + "\n" + cityTb.Text + "\n" + stateTb.Text + "\n" +
                zipTb.Text + "\n" + labelB.Text + "\n" + amtOwedTb.Text + "\n" + payDateTb.Text + "\n";

                MessageBox.Show(feedback);

            }
            catch (Exception ex)
            {
               label8.Text = ex.Message;    
            }
            finally
            {
                conn.Close();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
