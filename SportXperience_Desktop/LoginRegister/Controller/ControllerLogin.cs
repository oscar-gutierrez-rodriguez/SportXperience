using DesktopModels.Model;
using LoginRegister.View;
using SportXperience.Controller;
using SportXperience.Model;
using SportXperience.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister.Controller
{
    public class ControllerLogin
    {
        LoginForm loginForm = new LoginForm();
        RegisterForm registerForm = new RegisterForm();
      
            public ControllerLogin()
            {
                Repositori.CreateHttpClient();
                loadData();
                setListeners();
                Application.Run(loginForm);
            }

            void loadData()
            {
                registerForm.comboBoxGenere.DataSource = Repositori.GetGender();
                registerForm.comboBoxGenere.DisplayMember = "name";
                loginForm.textBoxNomCorreu.Text = "pepe";
                loginForm.textBoxContrasenya.Text = "1234";
                
            }

            void setListeners()
            {
                loginForm.buttonIniciSessio.Click += ButtonIniciSessio_Click;
                loginForm.linkLabelRegistrat.Click += LinkLabelRegistrat_Click;
                registerForm.buttonRegistrar.Click += ButtonRegistrar_Click;
                registerForm.dateTimePickerNaixement.ValueChanged += DateTimePickerNaixement_ValueChanged;
                loginForm.buttonShowPassword.Click += ButtonShowPassword_Click;
                registerForm.FormClosed += (s, e) => loginForm.Show();
                loginForm.textBoxNomCorreu.KeyDown += TextBox_KeyDown;
                loginForm.textBoxContrasenya.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ButtonIniciSessio_Click(sender, e); 
            }
        }
        private void ButtonShowPassword_Click(object sender, EventArgs e)
        {
            if (loginForm.textBoxContrasenya.UseSystemPasswordChar)
            {
                loginForm.textBoxContrasenya.UseSystemPasswordChar = false;
                loginForm.buttonShowPassword.Text = "";
                loginForm.buttonShowPassword.Image = Image.FromFile(@"C:\Users\cv\Desktop\PROJECTEFINAL\invisible(1).png"); 
            }
            else
            {
                loginForm.buttonShowPassword.Image = null;
                loginForm.textBoxContrasenya.UseSystemPasswordChar = true;
                loginForm.buttonShowPassword.Text = "👁 Mostrar"; 
            }
        }
        

        private void DateTimePickerNaixement_ValueChanged(object sender, EventArgs e)
        {
            if (registerForm.dateTimePickerNaixement.Value > DateTime.Now)
            {
                MessageBox.Show("La data de naixement no pot ser superior a " + DateTime.Now.ToString("dd/MM/yyyy"));
                registerForm.dateTimePickerNaixement.Value = DateTime.Now;
            }
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {


            User usercorrecteDNI = null;
            User usercorrecteMail = null;
            User usercorrecteUsername = null;

            if (string.IsNullOrEmpty(registerForm.textBoxDNI.Text) ||
            string.IsNullOrEmpty(registerForm.textBoxNom.Text) ||
            string.IsNullOrEmpty(registerForm.textBoxCognoms.Text) ||
            string.IsNullOrEmpty(registerForm.textBoxCorreu.Text) ||
            string.IsNullOrEmpty(registerForm.textBoxNomUsuari.Text) ||
            string.IsNullOrEmpty(registerForm.textBoxContrasenyaReg.Text))
            {
                MessageBox.Show("Has d'omplir tots els camps", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                usercorrecteDNI = Repositori.GetUserByDNI(registerForm.textBoxDNI.Text);
                usercorrecteUsername = Repositori.GetUserByUsername(registerForm.textBoxNomUsuari.Text);
                usercorrecteMail = Repositori.GetUserByMail(registerForm.textBoxCorreu.Text);
                if (usercorrecteDNI.Dni != null)
                {
                    MessageBox.Show("El DNI ya existeix.");
                }
                else if (usercorrecteMail.Dni != null)
                {
                    MessageBox.Show("El mail ya existeix.");
                }
                else if (usercorrecteUsername.Dni != null)
                {
                    MessageBox.Show("El nom d'usuari ya existeix.");
                }
                else
                {
                    User userToInsert = new User
                    {
                        Dni = registerForm.textBoxDNI.Text,
                        FirstName = registerForm.textBoxNom.Text,
                        LastName = registerForm.textBoxCognoms.Text,
                        GenderId = (registerForm.comboBoxGenere.SelectedItem as Gender).GenderId,
                        BirthDate = registerForm.dateTimePickerNaixement.Value,
                        Mail = registerForm.textBoxCorreu.Text,
                        Username = registerForm.textBoxNomUsuari.Text,
                        Password = registerForm.textBoxContrasenyaReg.Text
                    };

                    Repositori.InsUser(userToInsert);
                    MessageBox.Show("T'has registrat correctament");

                    loginForm.Show();
                    registerForm.Hide();
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }

        }

        private void LinkLabelRegistrat_Click(object sender, EventArgs e)
        {
            loginForm.Hide();
            registerForm.ShowDialog();




        }

        private void ButtonIniciSessio_Click(object sender, EventArgs e)
        {
            Repositori.usuari = Repositori.GetUserInici(loginForm.textBoxNomCorreu.Text, loginForm.textBoxContrasenya.Text);
            if (Repositori.usuari.Dni == null)
            {
                MessageBox.Show("Credencials incorrectes");
            }
            else
            {

                loginForm.Hide();
                new ControllerMain();
            }   


        }
    }
}
