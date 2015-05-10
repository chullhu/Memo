using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Memo.Resources;

namespace Memo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Конструктор
        public MainPage()
        {
            InitializeComponent();
            DrawerLayout.InitializeDrawerLayout();
        }

        private void HambImg_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (DrawerLayout.IsDrawerOpen)
                DrawerLayout.CloseDrawer(); 
            else
                DrawerLayout.OpenDrawer();
        }

        private void MainPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);

            if (DrawerLayout.IsDrawerOpen)
            {
                DrawerLayout.CloseDrawer();
                e.Cancel = true;
            }
        }

        
    }
}