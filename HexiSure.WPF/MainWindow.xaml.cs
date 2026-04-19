using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
//using HexiSureClassLibrary.DataAccess;
//using HexiSureClassLibrary.Entities.Insurables;
//using HexiSureClassLibrary.Entities.Insurances;

namespace HexiSure.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // TODO:
            //      - verwerk alle gemeentes uit het csv-bestand van municipalities
            //      - sorteer alle gemeentes op alfabetische volgorde (naam) en vervolgens op numerieke (postcode)
            //      - plaats alle gemeentes in de ComboBox

            // TODO stel de ConnectionString in in InsuranceData
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: haal alle verzekering op van het hoofdkantoor (de database) en zet ze in het DataGrid
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            MunicipalityComboBox.SelectedIndex = -1;
            MunicipalityFilterTextBox.Clear();
            AddressTextBox.Clear();
            TypeComboBox.SelectedIndex = -1;
            BuildDatePicker.SelectedDate = null;
            LivingAreaTextBox.Clear();
            MarketValueTextBox.Clear();
            AddFireCheckBox.IsChecked = false;
            AddTheft10KCheckBox.IsChecked = false;
            AddTheft30KCheckBox.IsChecked = false;
            AddLegalAidCheckBox.IsChecked = false;
            BasePremiumTextBox.Clear();
        }

        private void ShowToast(string message)
        {
            TagBorder.Tag = "Visible";
            TagTextBlock.Text = message;
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(2);
            dispatcherTimer.Tick += (sender, e) => {
                TagBorder.Tag = "Hidden"; dispatcherTimer.Stop();
            };
            dispatcherTimer.Start();
        }

        private void CreateHomePolicyButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: controleer of de gegevens geldig zijn
            if (true // TODO
                )
            {
                // TODO:
                //      - maak een Residence object aan op basis van de invulvelden
                //      - voeg het Residence object toe aan de Database met behulp van InsertNewInsurance()
                
                //ShowToast("✓ Nieuwe polis toegevoegd " + homeInsurance.ToString());
                //ClearForm();
            }
            else
            {
                //ShowToast("⚠ Ongeldige gegevens");
            }
        }

        private void MunicipalityFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // TODO: filter en sorteer alle gemeentes en plaats ze in de ComboBox
        }

    }
}