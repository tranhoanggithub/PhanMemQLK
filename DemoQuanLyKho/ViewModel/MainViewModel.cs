using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DemoQuanLyKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //mọi thứ xử lý nằm tỏng này
        public MainViewModel()
        {
            MessageBox.Show("Đã vào trong MainViewModel -> DataContext của main window.xaml");
        }
    }
}
