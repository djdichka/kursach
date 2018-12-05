using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tours.Dto;
using Tours.BusinessLayer;

namespace Tours
{
    /// <summary>
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
                
        }
        private void tbAdress_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void tbNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Введите имя клиента", "Ошибка");
                return;
            }
            else if (string.IsNullOrEmpty(tbAdress.Text))
            {
                MessageBox.Show("Введите адрес клиента", "Ошибка");
                return;
            }
            else if (string.IsNullOrEmpty(tbNumber.Text))
            {
                MessageBox.Show("Введите номер клиента", "Ошибка");
                return;
            }
            ClientDto client = new ClientDto();
            client.Name = tbName.Text;
            client.Adress = tbAdress.Text;
            client.Number = tbNumber.Text;

            IClientProcess clientProcess = ProcessFactory.GetClientProcess();
            clientProcess.Add(client);

            Close();
        }
    }
}
