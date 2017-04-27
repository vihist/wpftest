using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication2.test;
using WpfApplication2.test.entity;

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App appInstance = (App)App.Current;


            date.DataContext = appInstance.mainService.GameData;
            tianming.DataContext = appInstance.mainService.GameData;
            caizheng.DataContext = appInstance.mainService.GameData;
            wubei.DataContext = appInstance.mainService.GameData;

            ObservableCollection<Local> lstLocal = new ObservableCollection<Local>(appInstance.mainService.GameData.ListLocal);
            zhoujunDataGrid.ItemsSource = lstLocal;

            ObservableCollection<Role> lstRole = new ObservableCollection<Role>(appInstance.mainService.GameData.ListRole);
            jiaoseDataGrid.ItemsSource = lstRole;
        }


        void OnWinClosing(object sender, CancelEventArgs e)
        {
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
