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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RockstarGamesLauncher.ViewModels;

namespace RockstarGamesLauncher.Views
{
    /// <summary>
    /// Interaction logic for GamesPage.xaml
    /// </summary>
    public partial class GamesView : Page
    {
        public GamesView()
        {
            InitializeComponent();
            DataContext = new GamesViewModel();
        }
    }
}
