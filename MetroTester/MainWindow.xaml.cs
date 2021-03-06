﻿using MetroRadiance.UI;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MetroTester
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MetroWindow
    {
        public MetroWindow()
        {
            InitializeComponent();

            ThemeService.Current.ChangeTheme(Theme.Dark);
            ThemeService.Current.ChangeAccent(Accent.Blue);
        }


        private void LeftPanelTabControl_OnIsEmptyChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            if (e.NewValue)
                LeftPanelColumnDefinition.Width = GridLength.Auto;
        }
    }
}
