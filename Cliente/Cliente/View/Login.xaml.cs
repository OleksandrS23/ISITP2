﻿//<Authors> Oleksandr Sierov & Rafael Faria </Authors>
//<Email> a16991@alunos.ipca.pt & 17004@alunos.ipca.pt </Email>
//<Institution> IPCA - Instituto Politecnico do Cávado e do Ave </Institution>
//<Version=4.1/>
//<Date>10/01/2021 <Last Change/></Date>
//<OBS></OBS>
using Nancy.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
using Cliente.Controller;

namespace Cliente.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (User.Text == "" || Pass.Password == "")
            {

            }
            else
            {
                //int resposta = LoginController.login(User.Text.ToString(), Pass.Password.ToString());
                Cliente.Models.AuthResponse resposta = LoginController.login(User.Text.ToString(), Pass.Password.ToString());

               // MessageBox.Show(resposta);
                if (resposta.logedid > 0)
                {

                    int role = LoginController.role(resposta.logedid);
                    switch (role)
                    {
                        case 1:  //utente
                            this.Hide();
                            var Main = new MainWindow(resposta.logedid,resposta.token);
                            Main.Closed += (s, args) => this.Close();
                            Main.Show();
                            break;
                        case 2:  //doutor
                            this.Hide();
                            var Doc = new DocWindow(resposta.logedid, resposta.token);
                            Doc.Closed += (s, args) => this.Close();
                            Doc.Show();
                            break;
                        case 3:   //funcionario
                            this.Hide();
                            //var Func = new FuncWindow(resposta.logedid,resposta.token);
                            //Func.Closed += (s, args) => this.Close();
                            //Func.Show();
                            break;
                        case 4:   //admin
                            this.Hide();
                            // var Adm = new AdminWindow(resposta.logedid,resposta.token);
                            //Adm.Closed += (s, args) => this.Close();
                            //Adm.Show();
                            break;
                        default:
                            MessageBox.Show("Algo errado!");
                            break;
                    }
                }
                else if (resposta.logedid == 0)
                {
                    MessageBox.Show("Sem ligaçao ao Servidor");
                }
                else if (resposta.logedid == -1)
                {
                    MessageBox.Show("Password errada");
                }
                else
                {
                    MessageBox.Show("Utilizador não existe");
                }
            }
        }

        private void ButtonRegistar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Reg = new Registar();
            Reg.Closed += (s, args) => this.Close();
            Reg.Show();
        }
    }

}
