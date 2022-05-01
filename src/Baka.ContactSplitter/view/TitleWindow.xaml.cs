﻿using System;
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
using Baka.ContactSplitter.viewModel;

namespace Baka.ContactSplitter.view
{
    /// <summary>
    /// Interaction logic for TitleWindow.xaml
    /// </summary>
    public partial class TitleWindow : BaseWindow<TitleWindowViewModel>
    {
        public TitleWindow(TitleWindowViewModel viewModel): base(viewModel)
        {
            InitializeComponent();
        }
    }
}
