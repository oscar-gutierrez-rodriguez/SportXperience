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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

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
                loginForm.Shown += (s, e) => loginForm.textBoxNomCorreu.Focus();
                Application.Run(loginForm);
        }

            void loadData()
            {
                registerForm.comboBoxGenere.DataSource = Repositori.GetGender();
                registerForm.comboBoxGenere.DisplayMember = "name";
                loginForm.textBoxNomCorreu.Text = "pedri";
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
                registerForm.buttonShowPasswordRegistrar.Click += ButtonShowPasswordRegistrar_Click;   
            }

        private void ButtonShowPasswordRegistrar_Click(object sender, EventArgs e)
        {
            if (registerForm.textBoxContrasenyaReg.Password)
            {
                registerForm.textBoxContrasenyaReg.Password = false;
                registerForm.buttonShowPasswordRegistrar.Text = "";
                registerForm.buttonShowPasswordRegistrar.Image = Image.FromFile(@"C:\Users\cv\Desktop\PROJECTEFINAL\invisible(1).png");
                registerForm.textBoxContrasenyaReg.Focus();
            }
            else
            {
                registerForm.buttonShowPasswordRegistrar.Image = null;
                registerForm.textBoxContrasenyaReg.Password = true;
                registerForm.buttonShowPasswordRegistrar.Text = "👁 Mostrar";
                registerForm.textBoxContrasenyaReg.Focus();
            }
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
            if (loginForm.textBoxContrasenya.Password)
            {
                loginForm.textBoxContrasenya.Password = false;
                loginForm.buttonShowPassword.Text = "";
                //loginForm.buttonShowPassword.Image = Image.FromFile(@"C:\Users\cv\Desktop\PROJECTEFINAL\invisible(1).png");
                loginForm.textBoxContrasenya.Focus();
            }
            else
            {
                loginForm.buttonShowPassword.Image = null;
                loginForm.textBoxContrasenya.Password = true;
                loginForm.buttonShowPassword.Text = "👁 Mostrar";
                loginForm.textBoxContrasenya.Focus();
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

            string dni = registerForm.textBoxDNI.Text.ToUpper();

            if (!Regex.IsMatch(dni, @"^\d{8}[A-Z]$"))
            {
                MessageBox.Show("El DNI ha de tenir 8 números seguits d'una lletra (ex: 12345678A).", "DNI invàlid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                registerForm.textBoxDNI.Focus();
                return;
            }

            string correu = registerForm.textBoxCorreu.Text;
            if (!Regex.IsMatch(correu, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El format del correu electrònic no és vàlid (ex: nom@domini.com).", "Correu invàlid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                registerForm.textBoxCorreu.Focus();
                return;
            }

            try
            {
                usercorrecteDNI = Repositori.GetUserByDNI(dni);
                usercorrecteUsername = Repositori.GetUserByUsername(registerForm.textBoxNomUsuari.Text);
                usercorrecteMail = Repositori.GetUserByMail(registerForm.textBoxCorreu.Text);

                if (usercorrecteDNI.Dni != null)
                {
                    MessageBox.Show("El DNI ja existeix.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (usercorrecteMail.Dni != null)
                {
                    MessageBox.Show("El correu electrònic ja existeix.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (usercorrecteUsername.Dni != null)
                {
                    MessageBox.Show("El nom d'usuari ja existeix.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(registerForm.textBoxContrasenyaReg.Text);

                User userToInsert = new User
                {
                    Dni = dni,
                    FirstName = registerForm.textBoxNom.Text,
                    LastName = registerForm.textBoxCognoms.Text,
                    GenderId = (registerForm.comboBoxGenere.SelectedItem as Gender)?.GenderId ?? 0,
                    BirthDate = registerForm.dateTimePickerNaixement.Value,
                    Mail = registerForm.textBoxCorreu.Text,
                    Username = registerForm.textBoxNomUsuari.Text,
                    Password = hashedPassword
                };


                Repositori.InsUser(userToInsert);
                MessageBox.Show("T'has registrat correctament", "Registre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loginForm.Show();
                registerForm.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el registre: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkLabelRegistrat_Click(object sender, EventArgs e)
        {
            loginForm.Hide();
            registerForm.ShowDialog();
        }

        private void comprovarContrasenya()
        {
            if (!BCrypt.Net.BCrypt.Verify(loginForm.textBoxContrasenya.Text, Repositori.usuari.Password))
            {
                MessageBox.Show("Credencials incorrectes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                loginForm.Hide();
                new ControllerMain();
            }
        }

        private void ButtonIniciSessio_Click(object sender, EventArgs e)
        {

            User usercorrecteUsername = Repositori.GetUserByUsername(loginForm.textBoxNomCorreu.Text);
            User usercorrecteMail = Repositori.GetUserByMail(loginForm.textBoxNomCorreu.Text);

            if (usercorrecteUsername.Dni != null)
            {
                Repositori.usuari = usercorrecteUsername;    
                comprovarContrasenya();
            }
            else if (usercorrecteMail.Dni != null)
            {
                Repositori.usuari = usercorrecteMail;
                comprovarContrasenya();
            }
            else
            {
                MessageBox.Show("Credencials incorrectes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
  
        }
    }
}
