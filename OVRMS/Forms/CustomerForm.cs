using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;
using OVRMS.BLL;

namespace OVRMS.Forms
{
    public partial class CustomerForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        OVRMSDCDataContext db = new OVRMSDCDataContext();
        DataGridView defaultDataGridView;

        //Form constructor
        public CustomerForm()
        {
            InitializeComponent();
        }

        //Form Load event handler
        private void Form_Load(object sender, EventArgs e)
        {
            defaultDataGridView = this.customerDataGridView;
            //this.v_RentalsTableAdapter.Fill(this.oVRMSDataSet.v_Rentals);
            resetFormData();
            defaultDataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#3b547c");
            bindingdefaultDataGridView(false);

        }

        //Fill control data with data retrieved from database
        private void retrieveData(int idCustomer)
        {
            resetFormData();
            Customer cust = ctr.getCustomer(idCustomer);
            idCustomerTextBox.Text = cust.IdCustomer.ToString();
            firstNameTextBox.Text = cust.FirstName;
            lastNameTextBox.Text = cust.LastName;
            addressTextBox.Text = cust.Address;
            licenceNumberTextBox.Text = cust.LicenceNumber;
            dateOfBirthDateTimePicker.Text = cust.DateOfBirth.ToString();
            statusComboBox.Text = cust.Status;
            emailTextBox.Text = cust.Email;
            mobileTextBox.Text = cust.Mobile;
            notesTextBox.Text = cust.Notes;
        }

        //Fill DataGridView with values retrieved from database
        private void bindingdefaultDataGridView(bool filter)
        {

            if (!filter)
            {
                var customerList = from cust in db.Customers
                                   //where SqlMethods.Like(cust.IdCustomer.ToString(), "%" + idCustomer + "%")
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
                defaultDataGridView.DataSource = customerList.Distinct();
            }
            else
            {
                string fname = firstNameTextBox.Text;
                string lname = lastNameTextBox.Text;
                string address = addressTextBox.Text;
                string licenseNo = licenceNumberTextBox.Text;
                string status = statusComboBox.Text;
                string email = emailTextBox.Text;
                string mobile = mobileTextBox.Text;
                string notes = notesTextBox.Text;

                var customerList = from cust in db.Customers
                                   where SqlMethods.Like(cust.FirstName, "%" + fname + "%")
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
                defaultDataGridView.DataSource = customerList.Distinct();
            }


        }

        //Fill DataGridView with values retrieved from database
        private void bindingRentalDataGridView(int idCustomer)
        {

                var rentalList = from rent in db.v_Rentals
                                   where SqlMethods.Like(rent.IdCustomer.ToString(), "%" + idCustomer.ToString() + "%")
                                   select new
                                   {
                                       IdRental = rent.IdRental,
                                       IdCustomer = rent.IdCustomer,
                                       IdVehicle = rent.IdVehicle,
                                       RentalExpStartDate = rent.RentalExpStartDate,
                                       RentalExpEndtDate = rent.RentalExpEndtDate,
                                       RentalActStartDate = rent.RentalActStartDate,
                                       RentalActEndDate = rent.RentalActEndDate,
                                       DamagesPenalty = rent.DamagesPenalty,
                                       LowFuelPenalty = rent.LowFuelPenalty,
                                       RoadOffencePenalty = rent.RoadOffencePenalty,
                                       LateReturnPenalty = rent.LateReturnPenalty,
                                       NumberOfKm = rent.NumberOfKm,
                                       NumberOfDays = rent.NumberOfDays,
                                       Notes = rent.Notes,
                                       ModelManufacturer = rent.ModelManufacturer,
                                       Category = rent.Category,
                                       DailyRate = rent.DailyRate
                                   };
                rentalDataGridView.DataSource = rentalList.Distinct();

        }

        //Validate mandatory textboxes based on Tag value
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

        //Save record
        private int saveRecord (Boolean newRecord)
        {
            
            int idCustomer = idCustomerTextBox.Text!=string.Empty ? Convert.ToInt32(idCustomerTextBox.Text) : 0;
            string fname = firstNameTextBox.Text;
            string lname = lastNameTextBox.Text;
            string address = addressTextBox.Text;
            string licenseNo = licenceNumberTextBox.Text;
            DateTime dateOfBirth = DateTime.Parse(dateOfBirthDateTimePicker.Text);
            string status = statusComboBox.Text;
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
                return idCustomer;
            }
            else
            {
                idCustomer = ctr.addCustomer(cust);
                return idCustomer;
            }

        }

        //Clear all controls
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

        #region Toolbar buttons click event handlers
        private void toolStripSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateControls())
                {
                    int idRecord;
                    idRecord = saveRecord(false);
                    MessageBox.Show("Record Updated!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    resetDataGridView(defaultDataGridView);

                    foreach (DataGridViewRow row in defaultDataGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(idRecord.ToString()))
                        {
                            defaultDataGridView.Rows[row.Index].Selected = true;
                            EnsureVisibleRow(defaultDataGridView, row.Index);
                            retrieveData(idRecord);

                            break;
                        }
                    }

                }
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
                    int idRecord;
                    idRecord = saveRecord(true);
                    MessageBox.Show("Record Inserted!",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetDataGridView(defaultDataGridView);

                    foreach (DataGridViewRow row in defaultDataGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(idRecord.ToString()))
                        {
                            defaultDataGridView.Rows[row.Index].Selected = true;
                            EnsureVisibleRow(defaultDataGridView, row.Index);
                            retrieveData(idRecord);

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
                    int IdRecord = Convert.ToInt32(idCustomerTextBox.Text);
                    ctr.deleteCustomer(IdRecord);
                    MessageBox.Show("Record Deleted!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetFormData();
                    resetDataGridView(defaultDataGridView);
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
        private void toolStripSearch_Click(object sender, EventArgs e)
        {
            bindingdefaultDataGridView(true);
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
        private void toolStripReset_Click(object sender, EventArgs e)
        {
            resetFormData();
        }
        #endregion

        #region DataGridView methods and event handlers
        //Reset DataGridView
        private void resetDataGridView(DataGridView dgv)
        {
            bindingdefaultDataGridView(false);
            dgv.ClearSelection();
            dgv.CurrentCell = null;
        }

        //Scroll DataGridView rows to ensure that selected row is visible
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
        private void defaultDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int idRecord = Convert.ToInt32(this.defaultDataGridView.CurrentRow.Cells[0].Value.ToString());
                retrieveData(idRecord);
                bindingRentalDataGridView(idRecord);

            }
            catch
            {
                return;
            }
        }
        private void defaultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idRecord = Convert.ToInt32(this.defaultDataGridView.CurrentRow.Cells[0].Value.ToString());
                retrieveData(idRecord);
                bindingRentalDataGridView(idRecord);
            }
            catch
            {
                return;
            }
        }
        #endregion


    }
}
