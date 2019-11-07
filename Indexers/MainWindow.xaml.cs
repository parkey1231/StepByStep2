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

namespace Indexers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PhoneBook phoneBook = new PhoneBook();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void findByNameClick(object sender, RoutedEventArgs e)
        {
            string text = this.txtName.Text;
            if (!string.IsNullOrEmpty(text))
            {
                Name personsName = new Name(text);
                PhoneNumber phoneNumber = this.phoneBook[personsName];
                txtPhoneNumber.Text = string.IsNullOrEmpty(phoneNumber.Text) ? "Nof Find" : phoneNumber.Text;
            }

        }

        private void findByPhoneNumberClick(object sender, RoutedEventArgs e)
        {
            string text = txtPhoneNumber.Text;
            if (!string.IsNullOrEmpty(text))
            {
                PhoneNumber phoneNumber = new PhoneNumber(text);
                Name personsName = this.phoneBook[phoneNumber];
                txtName.Text = string.IsNullOrEmpty(personsName.Text) ? "Not Find" : personsName.Text;
            }

        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtName.Text) && !String.IsNullOrEmpty(this.txtPhoneNumber.Text))
            {
                phoneBook.Add(new Name(this.txtName.Text),
                              new PhoneNumber(this.txtPhoneNumber.Text));
                this.txtName.Text = "";
                this.txtPhoneNumber.Text = "";
            }
        }

    }
}
