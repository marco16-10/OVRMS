using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OVRMS.Forms;

namespace OVRMS
{
    public partial class MDIForm : Form
    {
        private const int GWL_STYLE = -16;
        private const int GWL_EXSTYLE = -20;

        private const int WS_BORDER = 0x00800000;
        private const int WS_EX_CLIENTEDGE = 0x00000200;

        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int Index);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private BorderStyle nicht = BorderStyle.None;
        private int childFormNumber = 0;
        MdiClient mdiClient;
        public MDIForm()
        {
            InitializeComponent();
            //mainToolStrip.Renderer = new ToolStripRenderer();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FormMaster childForm = new FormMaster();
            childForm.MdiParent = this;
            childForm.Text = "New Purchase Order " + childFormNumber++;
            childForm.Changing += ChildForm_Changing;
            childForm.Changed += ChildForm_Changed;
            childForm.Show();
        }

        private void ChildForm_Changed(object sender, MasterChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ChildForm_Changing(object sender, MasterChangingEventArgs e)
        {
            throw new NotImplementedException();
        }

        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void customerToolStripButton_Click(object sender, EventArgs e)
        {
            CustomerForm childForm = new CustomerForm();
            copenMDIChild(childForm);
        }

        private void copenMDIChild(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.AutoScaleMode = AutoScaleMode.Inherit;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void employeeToolStripButton_Click(object sender, EventArgs e)
        {
            EmlpoyeeForm childForm = new EmlpoyeeForm();
            copenMDIChild(childForm);
        }
        private void vehicleToolStripButton_Click(object sender, EventArgs e)
        {
            VehicleForm childForm = new VehicleForm();
            copenMDIChild(childForm);
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {

            mdiClient = null;

            for (int i = 0; i < this.Controls.Count; i++)
            {
                mdiClient = this.Controls[i] as MdiClient;
                if (mdiClient != null)
                {
                    mdiClient.BackColor = Color.Black;
                    SetMDIBorderStyle(nicht);
                }
            }

            CustomerForm cf = new CustomerForm();
            copenMDIChild(cf);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                int WS_EX_CLIENTEDGE = 0x00000200;
                CreateParams cp = base.CreateParams;
                if ((cp.ExStyle & WS_EX_CLIENTEDGE) == WS_EX_CLIENTEDGE)
                    cp.ExStyle -= WS_EX_CLIENTEDGE;

                return cp;
            }
        }
        //protected ov erride void OnMdiChildActivate(EventArgs e)
        //{
        //    saveAsToolStripMenuItem.Enabled = saveToolStripButton.Enabled = saveToolStripMenuItem.Enabled = false;
        //    printToolStripButton.Enabled = printToolStripMenuItem.Enabled = printPreviewToolStripButton.Enabled = printPreviewToolStripMenuItem.Enabled = false;

        //    FormMaster activeChildForm = (FormMaster)this.ActiveMdiChild;
        //    if (activeChildForm != null)
        //    {
        //        printToolStripButton.Enabled = printToolStripMenuItem.Enabled = printPreviewToolStripButton.Enabled = printPreviewToolStripMenuItem.Enabled = true;
        //        saveAsToolStripMenuItem.Enabled = true;
        //        saveToolStripButton.Enabled = saveToolStripMenuItem.Enabled = !activeChildForm.Saved;
        //    }
        //    base.OnMdiChildActivate(e);
        //}

        //private void FormMaster_Changing(object sender, MasterChangingEventArgs e)
        //{

        //}

        //private void FormMaster_Changed(object sender, MasterChangedEventArgs e)
        //{
        //    FormMaster activeChildForm = this.ActiveMdiChild as FormMaster;
        //    FormMaster sendingForm = sender as FormMaster;
        //    if (sendingForm == activeChildForm)
        //    {
        //        saveToolStripButton.Enabled = saveToolStripMenuItem.Enabled = true;
        //    }
        //}

        //private void saveToolStripButton_Click(object sender, EventArgs e)
        //{
        //    FormMaster currentForm = (FormMaster)this.ActiveMdiChild;
        //    if (currentForm.FileName != null)
        //    {
        //        currentForm.Save();
        //    }
        //    else
        //    {
        //        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //        saveFileDialog.Filter = "Purchase Orders (*.pof)|*.pof";
        //        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //        {
        //            String FileName = saveFileDialog.FileName;
        //            currentForm.FileName = FileName;
        //            currentForm.Text = FileName;
        //            currentForm.SaveAs(FileName);
        //        }
        //    }
        //    currentForm.Saved = true;
        //    saveToolStripMenuItem.Enabled = saveToolStripButton.Enabled = false;
        //}

        //private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FormMaster currentForm = (FormMaster)this.ActiveMdiChild;
        //    if (currentForm.FileName != null)
        //    {
        //        currentForm.Save();
        //    }
        //    else
        //    {
        //        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //        saveFileDialog.Filter = "Purchase Orders (*.pof)|*.pof";
        //        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //        {
        //            String FileName = saveFileDialog.FileName;
        //            currentForm.FileName = FileName;
        //            currentForm.Text = FileName;
        //            currentForm.SaveAs(FileName);
        //        }
        //    }
        //    currentForm.Saved = true;
        //    saveToolStripMenuItem.Enabled = saveToolStripButton.Enabled = false;
        //}

        //private void printToolStripButton_Click(object sender, EventArgs e)
        //{
        //    FormMaster currentForm = (FormMaster)this.ActiveMdiChild;
        //    String documentName = currentForm.Text;
        //    PrintDialog printDialog = new PrintDialog();
        //    if (printDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        //    {
        //        PrintDocument printDoc = new PrintDocument();
        //        printDoc.PrinterSettings = printDialog.PrinterSettings;
        //        printDoc.DocumentName = documentName;
        //        printDoc.BeginPrint += printDoc_BeginPrint;
        //        printDoc.PrintPage += printDoc_PrintPage;
        //        printDoc.Print();
        //    }
        //}

        //private List<String> _printLines;
        //private void printDoc_BeginPrint(object sender, PrintEventArgs e)
        //{
        //    // Anything that needs to be done before we start printing goes here
        //    FormMaster currentForm = (FormMaster)this.ActiveMdiChild;
        //    String printText = currentForm.Master.MasterNumber;
        //    String[] lines = printText.Split('\n');
        //    _printLines = new List<String>(lines);
        //}

        //private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    // This is the method that actually renders the document to the printer
        //    // For simplicity sake, and to illustrate the use of PrintDocuments events
        //    // we will simply print 80 lines per page
        //    int linesPerPage = 80;
        //    int printedLineCount = 0;
        //    float y = 25.0f;
        //    Font printFont = new Font("Times New Roman", 10.0f);

        //    while (_printLines.Count > 0 && printedLineCount < linesPerPage)
        //    {
        //        e.Graphics.DrawString(_printLines[0], printFont, Brushes.Black, 25.0f, y);
        //        _printLines.RemoveAt(0);
        //        printedLineCount++;
        //        y += 15.0f;
        //    }

        //    if (_printLines.Count > 0) e.HasMorePages = true;
        //}

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    FormMaster childForm = new FormMaster();
        //    childForm.MdiParent = this;
        //    childForm.Text = "New Purchase Order " + childFormNumber++;
        //    childForm.Changing += Master_Changing;
        //    childForm.Changed += Master_Changed;
        //    childForm.Show();
        //}
        private void SetMDIBorderStyle(BorderStyle value)
        {
            // Get styles using Win32 calls
            int style = GetWindowLong(mdiClient.Handle, GWL_STYLE);
            int exStyle = GetWindowLong(mdiClient.Handle, GWL_EXSTYLE);

            // Add or remove style flags as necessary.
            switch (value)
            {
                case BorderStyle.Fixed3D:
                    exStyle |= WS_EX_CLIENTEDGE;
                    style &= ~WS_BORDER;
                    break;

                case BorderStyle.FixedSingle:
                    exStyle &= ~WS_EX_CLIENTEDGE;
                    style |= WS_BORDER;
                    break;

                case BorderStyle.None:
                    style &= ~WS_BORDER;
                    exStyle &= ~WS_EX_CLIENTEDGE;
                    break;
            }

            // Set the styles using Win32 calls
            SetWindowLong(mdiClient.Handle, GWL_STYLE, style);
            SetWindowLong(mdiClient.Handle, GWL_EXSTYLE, exStyle);

            // Update the non-client area.
            SetWindowPos(mdiClient.Handle, IntPtr.Zero, 0, 0, 0, 0,
                SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
        }



    }
}
