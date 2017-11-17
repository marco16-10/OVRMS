using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using OVRMS.ObjectBase;

namespace OVRMS
{
    public partial class FormMaster : Form
    {

        private Master _Master;
        private String _fileName;
        private bool _saved;

        public event MasterChangingEventHandler Changing;
        public event MasterChangedEventHandler Changed;

        public FormMaster()
        {
            _saved = false;
            _Master = new Master();
            _Master.Changing += FormMaster_Changing;
            _Master.Changed += FormMaster_Changed;
            InitializeComponent();
            FormMasterBindingSource.DataSource = _Master;
        }

        private void FormMaster_Changed(object sender, MasterChangedEventArgs e)
        {
            _saved = false;
            FormMasterBindingSource.ResetBindings(false);
            OnChanged(e);
        }

        private void FormMaster_Changing(object sender, MasterChangingEventArgs e)
        {
            OnChanging(e);
        }

        public FormMaster(Master Master)
        {
            _saved = true;
            _Master = Master;
            _Master.Changing += FormMaster_Changing;
            _Master.Changed += FormMaster_Changed;
            InitializeComponent();
            FormMasterBindingSource.DataSource = _Master;
            FormMasterBindingSource.ResetBindings(false);
        }

        public Master Master
        {
            get { return _Master; }
            set
            {
                _Master = value;
                _Master.Changing += FormMaster_Changing;
                _Master.Changed += FormMaster_Changed;
                FormMasterBindingSource.DataSource = new FormMaster();
                FormMasterBindingSource.DataSource = value;
                FormMasterBindingSource.ResetBindings(false);
            }
        }

        public String FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public Boolean Saved
        {
            get { return _saved; }
            set { _saved = value; }
        }

        public void Save()
        {
            if (_fileName != null)
            {
                SaveAs(_fileName);
            }
        }

        public void SaveAs(String file)
        {
            try
            {
                using (FileStream stream = File.Create(file))
                {
                    BinaryFormatter serializer = new BinaryFormatter();

                    // Detach event handlers before serialization
                    _Master.Changing -= FormMaster_Changing;
                    _Master.Changed -= FormMaster_Changed;

                    // Serialize
                    serializer.Serialize(stream, _Master);

                    // Attach event handlers back after serialization
                    _Master.Changing += FormMaster_Changing;
                    _Master.Changed += FormMaster_Changed;
                    stream.Close();
                }
                _saved = true;
                _fileName = file;
                this.Text = file;
            }
            catch (IOException exception)
            {
                MessageBox.Show("Error saving file:\n\n" + exception.Message, "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveAsXML(String file)
        {
            try
            {
                using (FileStream stream = File.Create(file))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(FormMaster));
                    xmlSerializer.Serialize(stream, _Master);
                    stream.Close();
                }
                _saved = true;
                _fileName = file;
                this.Text = file;
            }
            catch (IOException exception)
            {
                MessageBox.Show("Error saving file:\n\n" + exception.Message, "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnChanging(MasterChangingEventArgs e)
        {
            if (Changing != null) Changing(this, e);
        }

        private void OnChanged(MasterChangedEventArgs e)
        {
            _saved = false;
            if (Changed != null) Changed(this, e);
        }
    }
}
