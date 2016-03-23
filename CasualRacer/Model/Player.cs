using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CasualRacer.Model
{
    internal class Player : INotifyPropertyChanged
    {

        private float direction = 0f;

        private Vector position=new Vector();

        public Vector Position
        {
            get { return position; }
            set
            {
                if (position != value)
                {
                    position = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Position"));
                }
            }
        }

        public Player()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
