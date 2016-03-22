using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game
{
    /// <summary>
    /// Interaction logic for DecisionControl.xaml
    /// </summary>
    public partial class DecisionControl : UserControl, INotifyPropertyChanged
    {
        private string _text="DefaultText";

        public string Text
        {
            get { return _text; }
            set
            {
                if (value == _text) return;
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public DecisionControl()
        {
            InitializeComponent();
            TextLabel.DataContext = this;
       }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string varName)
        {
            var propertyChanged = PropertyChanged;
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(varName));
        }
    }
}
