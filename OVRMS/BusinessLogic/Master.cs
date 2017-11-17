using System;

namespace OVRMS.ObjectBase
{
    [Serializable]
    public class Master
    {
        private String _MasterNumber;


        [field: NonSerialized]
        public event MasterChangingEventHandler Changing;
        [field: NonSerialized]
        public event MasterChangedEventHandler Changed;

        public Master()
        {

        }

        public String MasterNumber
        {
            get { return _MasterNumber; }
            set 
            {
                OnChanging(new MasterChangingEventArgs());
                _MasterNumber = value;
                OnChanged(new MasterChangedEventArgs());
            }
        }


        private void OnChanging(MasterChangingEventArgs e)
        {
            if (Changing != null) Changing(this, e);
        }

        private void OnChanged(MasterChangedEventArgs e)
        {
            if (Changed != null) Changed(this, e);
        }
    }
}
