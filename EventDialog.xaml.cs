using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// EventDialog.xaml 的交互逻辑
    /// </summary>
    public partial class EventDialog : Window
    {
        public EventDialog(string eventDesc, List<string> optionDescList)
        {
            InitializeComponent();
            this.Desc.Text = eventDesc;

            this.Top = System.Windows.SystemParameters.PrimaryScreenHeight / 2 - 195;//(double)MainWindow.HeightProperty.DefaultMetadata.DefaultValue/2;
            this.Left = System.Windows.SystemParameters.PrimaryScreenWidth / 2 + 520/2;

            foreach (string optionDesc in optionDescList)
            {
                Button button = new Button();

                button.Content = optionDesc;
                option.Children.Add(button);

                button.Click += button_Click;
            }
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
