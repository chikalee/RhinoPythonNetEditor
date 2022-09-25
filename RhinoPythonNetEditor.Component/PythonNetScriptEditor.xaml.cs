﻿using RhinoPythonNetEditor.View.Pages;
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

namespace RhinoPythonNetEditor.Component
{
    /// <summary>
    /// PythonNetScriptEditor.xaml 的交互逻辑
    /// </summary>
    public partial class PythonNetScriptEditor : Window
    {
        public PythonNetScriptEditor()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Minimized) WindowState = WindowState.Normal;
        }
    }
}
