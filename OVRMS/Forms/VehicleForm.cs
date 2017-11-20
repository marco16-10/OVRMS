using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;
using OVRMS.BLL;

namespace OVRMS.Forms
{
    public partial class VehicleForm : Form
    {
        RecordBLL ctr = new RecordBLL();
        OVRMSDCDataContext db = new OVRMSDCDataContext();
        DataGridView defaultDataGridView;
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'ovrmsDataSet.Vehicle' table. You can move, or remove it, as needed.
            //this.vehicleTableAdapter.Fill(this.ovrmsDataSet.Vehicle);
            //// TODO: This line of code loads data into the 'ovrmsDataSet.v_Vehicles' table. You can move, or remove it, as needed.
            //this.v_VehiclesTableAdapter.Fill(this.ovrmsDataSet.v_Vehicles);
            defaultDataGridView = this.vehicleDataGridView;
            resetFormData();
            defaultDataGridView.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#3b547c");
            bindingdefaultDataGridView(false);

        }
        //Fill control data with data retrieved from database
        private void retrieveData(int idVehicle)
        {
            resetFormData();
            Vehicle veh = ctr.getVehicle(idVehicle);
            idVehicleTextBox.Text = veh.IdVehicle.ToString();
            idCategoryTextBox.Text = veh.IdCategory.ToString();
            manufacturerTextBox.Text = veh.Manufacturer;
            modelTextBox.Text = veh.Model;
            registrationNoTextBox.Text = veh.RegistrationNo;
            statusComboBox.Text = veh.Status;
            colorTextBox.Text = veh.Color;
            descriptionTextBox.Text = veh.Description;
            odometerTextBox.Text = veh.Odometer.ToString();
            yearTextBox.Text = veh.Year;
            notesTextBox.Text = veh.Notes;
            imageFilePathTextBox.Text = veh.ImageFilePath;

            string imageFilePath = imageFilePathTextBox.Text;//.Replace("\\","");
            loadImageFromFile(imageFilePath);

        }

        //Fill DataGridView with values retrieved from database
        private void bindingdefaultDataGridView(bool filter)
        {

            if (!filter)
            {
                var vehicleList = from veh in db.v_Vehicles
                                   select new
                                   {
                                       IdVehicle = veh.IdVehicle,
                                       IdCategory = veh.IdCategory,
                                       Manufacturer = veh.Manufacturer,
                                       Model = veh.Model,
                                       RegistrationNo = veh.RegistrationNo,
                                       Status = veh.Status,
                                       Color = veh.Color,
                                       Description = veh.Description,
                                       Odometer = veh.Odometer,
                                       Year = veh.Year,
                                       Notes = veh.Notes,
                                       ImageFilePath = veh.ImageFilePath,
                                       CategoryName = veh.CategoryName,
                                       CategoryDescription=veh.CategoryDescription,
                                       DailyRate=veh.DailyRate
                                   };
                defaultDataGridView.DataSource = vehicleList.Distinct();
            }
            else
            {
                string IdVehicle = idVehicleTextBox.Text;
                string IdCategory = idCategoryTextBox.Text;
                string Manufacturer = manufacturerTextBox.Text;
                string Model = modelTextBox.Text;
                string RegistrationNo = registrationNoTextBox.Text;
                string Status = statusComboBox.Text;
                string Color = colorTextBox.Text;
                string Description = descriptionTextBox.Text;
                string Odometer = odometerTextBox.Text;
                string Year = yearTextBox.Text;
                string Notes = notesTextBox.Text;
                string ImageFilePath = imageFilePathTextBox.Text;



                var vehicleList = from veh in db.v_Vehicles
                                   where SqlMethods.Like(veh.IdVehicle.ToString(), "%" + IdVehicle + "%")
                                    && SqlMethods.Like(veh.IdCategory.ToString(), "%" + IdCategory + "%")
                                    && SqlMethods.Like(veh.Manufacturer, "%" + Manufacturer + "%")
                                    && SqlMethods.Like(veh.Model, "%" + Model + "%")
                                    && SqlMethods.Like(veh.RegistrationNo, "%" + RegistrationNo + "%")
                                    && SqlMethods.Like(veh.Status, "%" + Status + "%")
                                    && SqlMethods.Like(veh.Color, "%" + Color + "%")
                                    && SqlMethods.Like(veh.Description, "%" + Description + "%")
                                    && SqlMethods.Like(veh.Odometer.ToString(), "%" + Odometer + "%")
                                    && SqlMethods.Like(veh.Year, "%" + Year + "%")
                                    && SqlMethods.Like(veh.Notes, "%" + Notes + "%")
                                    && SqlMethods.Like(veh.ImageFilePath, "%" + ImageFilePath + "%")




                                  select new
                                   {
                                      IdVehicle = veh.IdVehicle,
                                      IdCategory = veh.IdCategory,
                                      Manufacturer = veh.Manufacturer,
                                      Model = veh.Model,
                                      RegistrationNo = veh.RegistrationNo,
                                      Status = veh.Status,
                                      Color = veh.Color,
                                      Description = veh.Description,
                                      Odometer = veh.Odometer,
                                      Year = veh.Year,
                                      Notes = veh.Notes,
                                      ImageFilePath = veh.ImageFilePath,
                                      CategoryName = veh.CategoryName,
                                      CategoryDescription = veh.CategoryDescription,
                                      DailyRate = veh.DailyRate
                                  };
                defaultDataGridView.DataSource = vehicleList.Distinct();
            }


        }


        //Validate mandatory textboxes based on Tag value
        private bool validateControls()
        {
            bool missingValues = false;
            foreach (Control co in VehicleDetailGroupBox.Controls)
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

            int IdVehicle = idVehicleTextBox.Text != string.Empty ? Convert.ToInt32(idVehicleTextBox.Text) : 0;
            int IdCategory = idCategoryTextBox.Text != string.Empty ? Convert.ToInt32(idCategoryTextBox.Text) : 0;
            string Manufacturer = manufacturerTextBox.Text;
            string Model = modelTextBox.Text;
            string RegistrationNo = registrationNoTextBox.Text;
            string Status = statusComboBox.Text;
            string Color = colorTextBox.Text;
            string Description = descriptionTextBox.Text;
            int Odometer = odometerTextBox.Text != string.Empty ? Convert.ToInt32(odometerTextBox.Text) : 0;
            string Year = yearTextBox.Text;
            string Notes = notesTextBox.Text;
            string ImageFilePath = imageFilePathTextBox.Text;

            Vehicle veh = new Vehicle();
            veh.IdVehicle=IdVehicle ;
            veh.IdCategory=IdCategory ;
            veh.Manufacturer=Manufacturer ;
            veh.Model=Model;
            veh.RegistrationNo=RegistrationNo;
            veh.Status=Status ;
            veh.Color=Color ;
            veh.Description=Description ;
            veh.Odometer=Odometer ;
            veh.Year=Year ;
            veh.Notes=Notes ;
            veh.ImageFilePath = ImageFilePath; 

            if (!newRecord)
            {
                ctr.updateVehicle(veh);
                return IdVehicle;
            }
            else
            {
                IdVehicle = ctr.addVehicle(veh);
                return IdVehicle;
            }

        }

        //Clear all controls
        private void resetFormData()
        {
            foreach (Control co in VehicleDetailGroupBox.Controls)
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
                if (MessageBox.Show("Are you sure you want to delete Vehicle: " + idVehicleTextBox.Text, "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int IdRecord = Convert.ToInt32(idVehicleTextBox.Text);
                    ctr.deleteVehicle(IdRecord);
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
        private void loadImageFromFile(string filePath)
        {
            try
            {
                if (filePath != string.Empty)
                {
                    Bitmap image1 = (Bitmap)Image.FromFile(@filePath, true);
                    vehiclePictureBox.Image = image1;
                    // If the image is too big, zoom.
                    if ((vehiclePictureBox.Image.Width > vehiclePictureBox.Width) ||
                        (vehiclePictureBox.Image.Height > vehiclePictureBox.Height))
                    {
                        vehiclePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        vehiclePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                }

            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error opening the bitmap." +
                    "Please check the path.");
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            string imageFilePath = imageFilePathTextBox.Text;
            loadImageFromFile(imageFilePath);
        }
    }
}
