using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyKho.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public bool IsLoaded { get; set; } = false;
        public MainViewModel() {
            if (!IsLoaded)
            {
                IsLoaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            }
        }
    }
}
