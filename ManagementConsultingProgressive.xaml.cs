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

namespace CreatingandLeadingEffectiveOrganizations
{
    /// <summary>
    /// Interaction logic for ManagementConsultingProgressive.xaml
    /// </summary>
    public partial class ManagementConsultingProgressive : Window
    {
        public ManagementConsultingProgressive()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void FinancialAnalysis_Click(object sender, RoutedEventArgs e)
        {
            Financial_Analysis Financial_AnalysisObject = new Financial_Analysis();
            Financial_AnalysisObject.Show();
        }
    }
}
