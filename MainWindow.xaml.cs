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

namespace CreatingandLeadingEffectiveOrganizations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Progressive_Click(object sender, RoutedEventArgs e)
        {
            ManagementConsultingProgressive ManagementConsultingProgressiveObject = new ManagementConsultingProgressive();
            ManagementConsultingProgressiveObject.Show();
        }

        private void MgmtConsultingMGM_Click(object sender, RoutedEventArgs e)
        {
            MgmtConsultingMGM MgmtConsultingMGMObject = new MgmtConsultingMGM();
            MgmtConsultingMGMObject.Show();
        }
    }
}
