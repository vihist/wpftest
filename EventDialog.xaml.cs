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
using WpfApplication2.test;

namespace WpfApplication2
{
    /// <summary>
    /// EventDialog.xaml 的交互逻辑
    /// </summary>
    public partial class EventDialog : Window, IEventDlg
    {
        public EventDialog()
        {
            InitializeComponent();
            
            this.Top = System.Windows.SystemParameters.PrimaryScreenHeight / 2 - 350 / 2 - System.Windows.SystemParameters.CaptionHeight - 8;//(double)MainWindow.HeightProperty.DefaultMetadata.DefaultValue/2;
            this.Left = System.Windows.SystemParameters.PrimaryScreenWidth / 2 + 520/2;


        }

        public void Initialize(string eventDesc, List<string> optionDescList)
        {
            this.Desc.Text = eventDesc;

            foreach (string optionDesc in optionDescList)
            {
                Button button = new Button();

                button.Content = optionDesc;
                option.Children.Add(button);

                button.Click += button_Click;
            }
        }

        public new void Show() 
        {
            this.ShowDialog();
        }

        public void Exit()
        {
            Action closeAction = () =>
            {
                this.Close();
            };

            this.Dispatcher.BeginInvoke(closeAction);
        }

        public string GetSelectedOption()
        {
            return optionDesc;
        }

        void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            optionDesc = (string)btn.Content;

            this.Close();
        }

        private string optionDesc;
    }
}
