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
using WpfApp1.Model;
using WpfApp1.Model.Repositories;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int ArtistId;

        private ArtisRepository repo = new ArtisRepository();

        public MainWindow()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void ClearText()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAges.Text = "";
        }


        private void PopulateGrid()
        {
            var result = repo.GetList();
            DataGridData.ItemsSource = result;
        }

        private void PopulateFields(Artis obj)
        {
            var result = repo.Get(obj.ArtistID);
            txtFirstName.Text = result.Name;
            txtLastName.Text = result.LastName;
            txtAges.Text = result.Age.ToString();
            this.ArtistId = result.ArtistID;
        }

        private void EditArtist(Artis obj)
        {
            repo.Update(obj);
            repo.SaveChanges();
            var data = repo.Get(obj.ArtistID);
            PopulateGrid(); 
            PopulateFields(data);
           
        }

        private void DataGridData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count != 0)
            {
                Artis seleccionado = e.AddedItems[0] as Artis;
                PopulateFields(seleccionado);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Artis artis = new Artis()
            {
                Name = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = Int32.Parse(txtAges.Text)
            };

            repo.add(artis);
            repo.SaveChanges();

            ClearText();
            PopulateGrid();
            MessageBox.Show("Se a grabado el contenido");
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Artis artis = new Artis()
            {
                ArtistID = ArtistId,
                Name = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = Int32.Parse(txtAges.Text)
            };

            EditArtist(artis);
            
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearText();
            ArtistId = 0;
        }
    }
}