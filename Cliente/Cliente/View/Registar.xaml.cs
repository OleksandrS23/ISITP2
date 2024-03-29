﻿//<Authors> Oleksandr Sierov & Rafael Faria </Authors>
//<Email> a16991@alunos.ipca.pt & 17004@alunos.ipca.pt </Email>
//<Institution> IPCA - Instituto Politecnico do Cávado e do Ave </Institution>
//<Version=4.1/>
//<Date>10/01/2021 <Last Change/></Date>
//<OBS></OBS>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Cliente.Controller;

namespace Cliente.View
{
    /// <summary>
    /// Interaction logic for Registar.xaml
    /// </summary>
    public partial class Registar : Window
    {
        string defaultText;
        public Registar()
        {
            InitializeComponent();
            lblpw.Visibility = Visibility.Hidden;
            lblUser.Visibility = Visibility.Hidden;
            lblNif.Visibility = Visibility.Hidden;
            lblEmail.Visibility = Visibility.Hidden;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int CheckNif;//= RegistarController.CheckifNifExist(int.Parse(Nif.Text));
            int CheckEmail; //= RegistarController.CheckifEmailExist(Email.Text);
            int CheckUser; //= RegistarController.CheckifUserExists(Utilizador.Text);
            if (Email.Text == "" || Utilizador.Text == "" || Nome.Text == "" || Nif.Text == "" || Morada.Text == "" || dataNascimento.Text == "" || Password.Password == "" || Password_Copy.Password == "")
            {
                lblpw.Visibility = Visibility.Hidden;
                MessageBox.Show("Falta Preencher");
            }
            else
            {
                CheckNif = RegistarController.CheckifNifExist(int.Parse(Nif.Text));
                CheckEmail = RegistarController.CheckifEmailExist(Email.Text);
                CheckUser = RegistarController.CheckifUserExists(Utilizador.Text);

                if (CheckUser == 1) //utilizador existe?
                {
                    lblUser.Visibility = Visibility.Visible;
                    //MessageBox.Show("Utilizador Existe");
                }
                else if (CheckNif == 1) //nif exite?
                {
                    lblNif.Visibility = Visibility.Visible;
                    //MessageBox.Show("NIF Existe");
                }
                else if (CheckEmail == 1) //email exite?
                {
                    lblEmail.Visibility = Visibility.Visible;
                    //MessageBox.Show("Email Existe");
                }
                else if (Password.Password != Password_Copy.Password)
                {
                    lblpw.Visibility = Visibility.Visible;
                }
                else if (RegistarController.CheckEmailandNif(Email.Text, int.Parse(Nif.Text)) == true && CheckNif == 0 && CheckUser == 0 && CheckEmail == 0)
                {
                    DateTime d = DateTime.Parse(dataNascimento.Text);

                    lblpw.Visibility = Visibility.Hidden;
                    string i = RegistarController.registar(Utilizador.Text, Nome.Text, int.Parse(Nif.Text), Email.Text, Morada.Text, Contacto.Text, d, Password.Password,1);
                    if (i == "Done")
                    {
                        MessageBox.Show("Registado");
                        this.Hide();
                        var Login = new Login();
                        Login.Closed += (s, args) => this.Close();
                        Login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Someting Wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Email ou NIF invalido");
                }
            }
        }

        #region Focus
        private void Utilizador_GotFocus(object sender, RoutedEventArgs e)
        {
            defaultText = "Utilizador";
            Utilizador.Text = Utilizador.Text == defaultText ? string.Empty : Utilizador.Text;
        }
        
        private void Nome_GotFocus(object sender, RoutedEventArgs e)
        {
            defaultText = "Nome Completo";
            Nome.Text = Nome.Text == defaultText ? string.Empty : Nome.Text;
        }

        private void Nif_GotFocus(object sender, RoutedEventArgs e)
        {
            defaultText = "NIF";
            Nif.Text = Nif.Text == defaultText ? string.Empty : Nif.Text;
        }

        private void Email_GotFocus(object sender, RoutedEventArgs e)
        {
            defaultText = "Email";
            Email.Text = Email.Text == defaultText ? string.Empty : Email.Text;
        }

        private void Morada_GotFocus(object sender, RoutedEventArgs e)
        {
            defaultText = "Morada";
            Morada.Text = Morada.Text == defaultText ? string.Empty : Morada.Text;
        }

        private void Contacto_GotFocus(object sender, RoutedEventArgs e)
        {
            defaultText = "Contacto";
            Contacto.Text = Contacto.Text == defaultText ? string.Empty : Contacto.Text;
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            lbl_pass.Content = "";
        }

        private void Password_Copy_GotFocus(object sender, RoutedEventArgs e)
        {
            lbl_passr.Content = "";
        }
        #endregion

        private void Nif_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

       

        private void Contacto_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("CLIQUEI");
        }

        private void Nome_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
                Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(e.Text)==false) {
                e.Handled=true;
            }
        }

        private void ButtonVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }
    }
}
