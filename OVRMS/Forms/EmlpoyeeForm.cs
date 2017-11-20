using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;
using OVRMS.BLL;

namespace OVRMS.Forms
{
    public partial class EmlpoyeeForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        OVRMSDCDataContext db = new OVRMSDCDataContext();
        DataGridView defaultDataGridView;

        public EmlpoyeeForm()
        {
            InitializeComponent();
        }

        //Form Load event handler
        private void Form_Load(object sender, EventArgs e)
        {
            defaultDataGridView = this.employeeDataGridView;
            //this.v_RentalsTableAdapter.Fill(this.oVRMSDataSet.v_Rentals);
            resetFormData();
            defaultDataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#3b547c");
            bindingdefaultDataGridView(false);

        }

        //Fill control data with data retrieved from database
        private void retrieveData(int idEmployee)
        {
            resetFormData();
            Employee emp = ctr.getEmployee(idEmployee);
            idEmployeeTextBox.Text = emp.IdEmp.ToString();
            firstNameTextBox.Text = emp.FirstName;
            lastNameTextBox.Text = emp.LastName;
            idRoleTextBox.Text = emp.IdRole.ToString();
            addressTextBox.Text = emp.Address;
            dateofHireDateTimePicker.Text = emp.DateofHire.ToString();
            employmentTypeTextBox.Text = emp.EmploymentType;
            genderTextBox.Text = emp.Gender;
            hourlyWageTextBox.Text = emp.HourlyWage.ToString();
            passwordTextBox.Text = emp.Password;
            qualificationTextBox.Text = emp.Qualification;
            taxCodeTextBox.Text = emp.TaxCode;
            isKiwiSaverTextBox.Text = emp.IsKiwiSaver.ToString();
            kiwiSaverContrRateTextBox.Text = emp.KiwiSaverContrRate.ToString();
            employerContrRateTextBox.Text = emp.EmployerContrRate.ToString();
            notesTextBox.Text = emp.Notes;
        }

        //Fill DataGridView with values retrieved from database
        private void bindingdefaultDataGridView(bool filter)
        {

            if (!filter)
            {
                var employeeList = from emp in db.Employees
                                       //where SqlMethods.Like(emp.IdEmployee.ToString(), "%" + idEmployee + "%")
                                   select new
                                   {
                                       IdEmp = emp.IdEmp,
                                       FirstName = emp.FirstName,
                                       LastName = emp.LastName,
                                       IdRole = emp.IdRole,
                                       Address = emp.Address,
                                       DateofHire = emp.DateofHire,
                                       EmploymentType = emp.EmploymentType,
                                       Gender = emp.Gender,
                                       HourlyWage = emp.HourlyWage,
                                       Password = emp.Password,
                                       Qualification = emp.Qualification,
                                       TaxCode = emp.TaxCode,
                                       IsKiwiSaver = emp.IsKiwiSaver,
                                       KiwiSaverContrRate = emp.KiwiSaverContrRate,
                                       EmployerContrRate = emp.EmployerContrRate,
                                       Notes = emp.Notes

                                   };
                defaultDataGridView.DataSource = employeeList.Distinct();
            }
            else
            {
                string idEmployee = idEmployeeTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string idRole = idRoleTextBox.Text;
                string address = addressTextBox.Text;
                string employmentType = employmentTypeTextBox.Text;
                string gender = genderTextBox.Text;
                string hourlyWage = hourlyWageTextBox.Text;
                string password = passwordTextBox.Text;
                string qualification = qualificationTextBox.Text;
                string taxCode = taxCodeTextBox.Text;
                string isKiwiSaver = isKiwiSaverTextBox.Text;
                string kiwiSaverContrRate = kiwiSaverContrRateTextBox.Text;
                string employerContrRate = employerContrRateTextBox.Text;
                string notes = notesTextBox.Text;


                var employeeList = from emp in db.Employees
                                   where SqlMethods.Like(emp.FirstName, "%" + firstName + "%")
                                    && SqlMethods.Like(emp.LastName, "%" + lastName + "%")
                                    && SqlMethods.Like(emp.IdRole.ToString(), "%" + idRole + "%")
                                    && SqlMethods.Like(emp.Address, "%" + address + "%")
                                    && SqlMethods.Like(emp.EmploymentType, "%" + employmentType + "%")
                                    && SqlMethods.Like(emp.Gender, "%" + gender + "%")
                                    && SqlMethods.Like(emp.HourlyWage.ToString(), "%" + hourlyWage + "%")
                                    && SqlMethods.Like(emp.Password, "%" + password + "%")
                                    && SqlMethods.Like(emp.Qualification, "%" + qualification + "%")
                                    && SqlMethods.Like(emp.TaxCode, "%" + taxCode + "%")
                                    && SqlMethods.Like(emp.IsKiwiSaver.ToString(), "%" + isKiwiSaver + "%")
                                    && SqlMethods.Like(emp.KiwiSaverContrRate.ToString(), "%" + kiwiSaverContrRate + "%")
                                    && SqlMethods.Like(emp.EmployerContrRate.ToString(), "%" + employerContrRate + "%")
                                    && SqlMethods.Like(emp.Notes, "%" + notes + "%")



                                   select new
                                   {
                                       IdEmp = emp.IdEmp,
                                       FirstName = emp.FirstName,
                                       LastName = emp.LastName,
                                       IdRole = emp.IdRole,
                                       Address = emp.Address,
                                       DateofHire = emp.DateofHire,
                                       EmploymentType = emp.EmploymentType,
                                       Gender = emp.Gender,
                                       HourlyWage = emp.HourlyWage,
                                       Password = emp.Password,
                                       Qualification = emp.Qualification,
                                       TaxCode = emp.TaxCode,
                                       IsKiwiSaver = emp.IsKiwiSaver,
                                       KiwiSaverContrRate = emp.KiwiSaverContrRate,
                                       EmployerContrRate = emp.EmployerContrRate,
                                       Notes = emp.Notes
                                   };
                defaultDataGridView.DataSource = employeeList.Distinct();
            }


        }


        //Validate mandatory textboxes based on Tag value
        private bool validateControls()
        {
            bool missingValues = false;
            foreach (Control co in EmployeeDetailGroupBox.Controls)
            {
                TextBox tb = co as TextBox;
                if (tb != null)
                {
                    if ((string)tb.Tag == "mandatory" && (string)tb.Text == string.Empty)
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
        private int saveRecord(Boolean newRecord)
        {

            int idEmployee = idEmployeeTextBox.Text != string.Empty ? Convert.ToInt32(idEmployeeTextBox.Text) : 0;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            int idRole = idRoleTextBox.Text != string.Empty ? Convert.ToInt32(idRoleTextBox.Text) : 0;
            string address = addressTextBox.Text;
            DateTime dateOfHire = DateTime.Parse(dateofHireDateTimePicker.Text);
            string employmentType = employmentTypeTextBox.Text;
            string gender = genderTextBox.Text;
            int hourlyWage = hourlyWageTextBox.Text != string.Empty ? Convert.ToInt32(hourlyWageTextBox.Text) : 0;
            string password = passwordTextBox.Text;
            string qualification = qualificationTextBox.Text;
            string taxCode = taxCodeTextBox.Text;
            char isKiwiSaver = isKiwiSaverTextBox.Text != string.Empty ? Convert.ToChar(isKiwiSaverTextBox.Text) : Convert.ToChar("N");
            int kiwiSaverContrRate = kiwiSaverContrRateTextBox.Text != string.Empty ? Convert.ToInt32(kiwiSaverContrRateTextBox.Text) : 0;
            int employerContrRate = employerContrRateTextBox.Text != string.Empty ? Convert.ToInt32(employerContrRateTextBox.Text) : 0;
            string notes = notesTextBox.Text;

            Employee emp = new Employee();
            emp.IdEmp = idEmployee;
            emp.FirstName = firstName;
            emp.LastName = lastName;
            emp.IdRole = idRole;
            emp.Address = address;
            emp.DateofHire = dateOfHire;
            emp.EmploymentType = employmentType;
            emp.Gender = gender;
            emp.HourlyWage = hourlyWage;
            emp.Password = password;
            emp.Qualification = qualification;
            emp.TaxCode = taxCode;
            emp.IsKiwiSaver = isKiwiSaver;
            emp.KiwiSaverContrRate = kiwiSaverContrRate;
            emp.EmployerContrRate = employerContrRate;
            emp.Notes = notes;

            if (!newRecord)
            {
                ctr.updateEmployee(emp);
                return idEmployee;
            }
            else
            {
                idEmployee = ctr.addEmployee(emp);
                return idEmployee;
            }

        }

        //Clear all controls
        private void resetFormData()
        {
            foreach (Control co in EmployeeDetailGroupBox.Controls)
            {
                TextBox tb = co as TextBox;
                if (tb != null)
                {
                    co.BackColor = SystemColors.Window;
                    co.Text = string.Empty;
                }
                ComboBox cb = co as ComboBox;
                if (cb != null)
                {
                    cb.BackColor = SystemColors.Window;
                    cb.Text = string.Empty;
                }
                PictureBox pb = co as PictureBox;
                if (pb != null)
                {
                    pb.Image = null;
                }
            }
            foreach (Control co in payslipDetailGroupBox.Controls)
            {
                TextBox tb = co as TextBox;
                if (tb != null)
                {
                    co.BackColor = SystemColors.Window;
                    co.Text = string.Empty;
                }
                ComboBox cb = co as ComboBox;
                if (cb != null)
                {
                    cb.BackColor = SystemColors.Window;
                    cb.Text = string.Empty;
                }
                PictureBox pb = co as PictureBox;
                if (pb != null)
                {
                    pb.Image = null;
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
                if (MessageBox.Show("Are you sure you want to delete Employee: " + idEmployeeTextBox.Text, "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int IdRecord = Convert.ToInt32(idEmployeeTextBox.Text);
                    ctr.deleteEmployee(IdRecord);
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
            }
            catch
            {
                return;
            }
        }
        #endregion
    }
}
