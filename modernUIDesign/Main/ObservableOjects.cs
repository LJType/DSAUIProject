using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modernUIDesign.Main
{
    internal class ObservableOjects : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberNameAttribute] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
        } 
    }

}
