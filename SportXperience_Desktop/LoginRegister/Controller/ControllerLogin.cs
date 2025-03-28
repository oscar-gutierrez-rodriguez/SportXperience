using LoginRegister.View;
using SportXperience.Controller;
using SportXperience.View;
using System;
using System.Collections.Generic;
using System.Linq;
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
                loadData();
                setListeners();
                Application.Run(loginForm);
            }

            void loadData()
            {
              
            }

            void setListeners()
            {
                loginForm.buttonIniciSessio.Click += ButtonIniciSessio_Click;
                loginForm.linkLabelRegistrat.Click += LinkLabelRegistrat_Click;
                registerForm.buttonRegistrar.Click += ButtonRegistrar_Click;
                registerForm.FormClosed += (s, e) => loginForm.Show();
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            registerForm.Hide();
        }

        private void LinkLabelRegistrat_Click(object sender, EventArgs e)
        {
            loginForm.Hide();
            registerForm.Show();




        }

        private void ButtonIniciSessio_Click(object sender, EventArgs e)
        {
            loginForm.Hide();
            new ControllerMain();


        }
    }
}
