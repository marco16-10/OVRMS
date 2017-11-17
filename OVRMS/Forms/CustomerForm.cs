using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;
using OVRMS.BLL;

namespace OVRMS
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        RecordBLL ctr = new RecordBLL();
        OVRMSDCDataContext db = new OVRMSDCDataContext();

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oVRMSDataSet.v_Rentals' table. You can move, or remove it, as needed.
            this.v_RentalsTableAdapter.Fill(this.oVRMSDataSet.v_Rentals);
            // TODO: This line of code loads data into the 'oVRMSDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.oVRMSDataSet.Customer);
            resetFormData();
            bindingCustomerDataGridView(string.Empty);

        }
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            //LinearGradientBrush brush = new LinearGradientBrush(rect, ColorTranslator.FromHtml("#3b547c"), Color.White, LinearGradientMode.Vertical);
            //g.FillRectangle(brush, rect);
            //brush.Dispose();
        }
        private void retrieveData(int idCustomer)
        {
            Customer cust = ctr.getCustomer(idCustomer);
            idCustomerTextBox.Text = cust.IdCustomer.ToString();
            firstNameTextBox.Text = cust.FirstName;
            lastNameTextBox.Text = cust.LastName;
            addressTextBox.Text = cust.Address;
            licenceNumberTextBox.Text = cust.LicenceNumber;
            dateOfBirthDateTimePicker.Text = cust.DateOfBirth.ToString();
            statusTextBox.Text = cust.Status;
            emailTextBox.Text = cust.Email;
            mobileTextBox.Text = cust.Mobile;
            notesTextBox.Text = cust.Notes;
        }

        private void resetFormData()
        {
            foreach (Control co in CustomerDetailGroupBox.Controls)
            {
                TextBox tb = co as TextBox;
                if (tb != null)
                {
                    co.BackColor = SystemColors.Window;
                    co.Text = string.Empty;
                }
            }
        }


        private int saveRecord (Boolean newRecord)
        {
            
            int idCustomer = idCustomerTextBox.Text!=string.Empty ? Convert.ToInt32(idCustomerTextBox.Text) : 0;
            string fname = firstNameTextBox.Text;
            string lname = lastNameTextBox.Text;
            string address = addressTextBox.Text;
            string licenseNo = licenceNumberTextBox.Text;
            DateTime dateOfBirth = DateTime.Parse(dateOfBirthDateTimePicker.Text);
            string status = statusTextBox.Text;
            string email = emailTextBox.Text;
            string mobile = mobileTextBox.Text;
            string notes = notesTextBox.Text;

            Customer cust = new Customer();
            cust.IdCustomer = idCustomer;
            cust.FirstName = fname;
            cust.LastName = lname;
            cust.Address = address;
            cust.LicenceNumber = licenseNo;
            cust.DateOfBirth = dateOfBirth;
            cust.Status = status;
            cust.Email = email;
            cust.Mobile = mobile;
            cust.Notes = notes;
            if (!newRecord)
            {
                ctr.updateCustomer(cust);
                return 0;
            }
            else
            {
                idCustomer = ctr.addCustomer(cust);
                return idCustomer;
            }
            
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateControls())
                {
                    saveRecord(false);
                    MessageBox.Show("Record Updated!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    resetCustomerDataGridView();}

                }
            catch (Exception ex)
            {
                MessageBox.Show("The record could not be saved!\n The following error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripSaveAsNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateControls())
                {
                    int idCustomer;
                    idCustomer = saveRecord(true);
                    MessageBox.Show("Record Inserted!",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetCustomerDataGridView();

                    foreach (DataGridViewRow row in customerDataGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(idCustomer.ToString()))
                        {
                            customerDataGridView.Rows[row.Index].Selected = true;
                            EnsureVisibleRow(customerDataGridView, row.Index);
                            retrieveData(idCustomer);

                            break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("The record could not be Inserted!\n The following error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete Customer: " + idCustomerTextBox.Text, "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int IdCustomer = Convert.ToInt32(idCustomerTextBox.Text);
                    ctr.deleteCustomer(IdCustomer);
                    MessageBox.Show("Record Deleted!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetFormData();
                    resetCustomerDataGridView();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show("The record could not be Deleted!\n The following error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetCustomerDataGridView()
        {
            //this.customerTableAdapter.Fill(this.oVRMSDataSet.Customer);
            bindingCustomerDataGridView(string.Empty);
            customerDataGridView.ClearSelection();
            customerDataGridView.CurrentCell = null;
        }
        private static void EnsureVisibleRow(DataGridView view, int rowToShow)
        {
            if (rowToShow >= 0 && rowToShow < view.RowCount)
            {
                var countVisible = view.DisplayedRowCount(false);
                var firstVisible = view.FirstDisplayedScrollingRowIndex;
                if (rowToShow < firstVisible)
                {
                    view.FirstDisplayedScrollingRowIndex = rowToShow;
                }
                else if (rowToShow >= firstVisible + countVisible)
                {
                    view.FirstDisplayedScrollingRowIndex = rowToShow - countVisible + 1;
                }
            }
        }

        private void toolStripSearch_Click(object sender, EventArgs e)
        {
            bindingCustomerDataGridView(string.Empty);
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void bindingCustomerDataGridView(string idCustomer)
        {

            if (idCustomer == string.Empty)
            {
                var customerList = from cust in db.Customers
                                   select new
                                   {
                                       IdCustomer = cust.IdCustomer,
                                       FirstName = cust.FirstName,
                                       LastName = cust.LastName,
                                       Address = cust.Address,
                                       LicenseNumber = cust.LicenceNumber,
                                       DateOfBirth = cust.DateOfBirth,
                                       Status = cust.Status,
                                       Email = cust.Email,
                                       Mobile = cust.Mobile,
                                       Notes = cust.Notes
                                   };
                customerDataGridView.DataSource = customerList.Distinct();
            }
            else
            {
                string fname = firstNameTextBox.Text;
                string lname = lastNameTextBox.Text;
                string address = addressTextBox.Text;
                string licenseNo = licenceNumberTextBox.Text;
                string status = statusTextBox.Text;
                string email = emailTextBox.Text;
                string mobile = mobileTextBox.Text;
                string notes = notesTextBox.Text;

                var customerList = from cust in db.Customers
                                   where SqlMethods.Like(cust.IdCustomer.ToString(), "%" + idCustomer + "%")
                                   && SqlMethods.Like(cust.FirstName, "%" + fname + "%")
                                   && SqlMethods.Like(cust.LastName, "%" + lname + "%")
                                   && SqlMethods.Like(cust.Address, "%" + address + "%")
                                   && SqlMethods.Like(cust.LicenceNumber, "%" + licenseNo + "%")
                                   && SqlMethods.Like(cust.Status, "%" + status + "%")
                                   && SqlMethods.Like(cust.Email, "%" + email + "%")
                                   && SqlMethods.Like(cust.Mobile, "%" + mobile + "%")
                                   && SqlMethods.Like(cust.Notes, "%" + notes + "%")
                                   select new
                                   {
                                       IdCustomer = cust.IdCustomer,
                                       FirstName = cust.FirstName,
                                       LastName = cust.LastName,
                                       Address = cust.Address,
                                       LicenseNumber = cust.LicenceNumber,
                                       DateOfBirth = cust.DateOfBirth,
                                       Status = cust.Status,
                                       Email = cust.Email,
                                       Mobile = cust.Mobile,
                                       Notes = cust.Notes
                                   };
                customerDataGridView.DataSource = customerList.Distinct();
            }
            

        }
        private void customerDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int idCustomer = Convert.ToInt32(this.customerDataGridView.CurrentRow.Cells[0].Value.ToString());
                retrieveData(idCustomer);

            }
            catch
            {
                return;
            }
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idCustomer = Convert.ToInt32(this.customerDataGridView.CurrentRow.Cells[0].Value.ToString());
                retrieveData(idCustomer);
            }
            catch
            {
                return;
            }
        }
        private void toolStripReset_Click(object sender, EventArgs e)
        {
            resetFormData();
        }
        private bool validateControls()
        {
            bool missingValues = false;
            foreach (Control co in CustomerDetailGroupBox.Controls)
            {
                TextBox tb = co as TextBox;
                if (tb != null)
                {
                    if ((string)tb.Tag=="mandatory"&& (string)tb.Text==string.Empty)
                    {
                        co.BackColor = Color.Red;
                        missingValues = true;
                    }
                    else
                    {
                        co.BackColor = SystemColors.Window;
                    }
                }
            }
            if (missingValues)
            {
                MessageBox.Show("Please fill in mandatory fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
