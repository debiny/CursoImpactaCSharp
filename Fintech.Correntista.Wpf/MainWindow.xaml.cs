using Fintech.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Windows;


namespace Fintech.Correntista.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Cliente> clientes = new();

        //contrutor é o método que tem o mesmo nome da classe
        public MainWindow()
        {
            InitializeComponent();
            PopularControles();
        }

        //void sao metodos que nao retornam nada
        private void PopularControles()
        {
            sexoComboBox.Items.Add(Sexo.Feminino);
            sexoComboBox.Items.Add(Sexo.Masculino);
            sexoComboBox.Items.Add(Sexo.Outros);

            clienteDataGrid.ItemsSource = clientes;

        }

        private void incluirClienteButton_Click(object sender, RoutedEventArgs e)
        {
            //cliente é do tipo objeto porque ele é originario de uma classe
            var cliente = new Cliente();
            //Cliente cliente = new();

            cliente.CPF = cpfTextBox.Text;
            cliente.DataNascimento = Convert.ToDateTime(dataNascimentoTextBox.Text);

            var endereco = new Endereco();
            endereco.Cep = cepTextBox.Text;
            endereco.Cidade = cidadeTextBox.Text;
            endereco.Logradouro = logradouroTextBox.Text;
            endereco.Numero = numeroLogradouroTextBox.Text;

            cliente.EnderecoResidencial = endereco;

            cliente.Nome = nomeTextBox.Text;
            //Converter o componente Select Item que era objetct para o formato do Sexo usando o Cast
            cliente.Sexo =(Sexo)sexoComboBox.SelectedItem;

            clientes.Add(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso!");
            LimparControlesCliente();
            pesquisaClienteTabItem.Focus();
            clienteDataGrid.Items.Refresh();

        }

        private void LimparControlesCliente()
        {
            cpfTextBox.Clear();
            nomeTextBox.Text = "";
            dataNascimentoTextBox.Text = null;
            sexoComboBox.SelectedIndex = -1;
            cepTextBox.Text = string.Empty;
            cidadeTextBox.Clear();
            logradouroTextBox.Clear();
            numeroLogradouroTextBox.Clear();


        }
    }
}
