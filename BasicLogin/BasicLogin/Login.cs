using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BasicLogin
{
    class Login
    {
        //decalre properties 
        public string Username { get; set; }
        public string Userpassword { get; set; }

        //intialise  
        public Login(string user, string pass)
        {
            this.Username = user;
            this.Userpassword = pass;
        }
        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }
        public bool IsLoggedIn(string user, string pass)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Unesite korisnicko ime");
                return false;

            }

            if (Username != user)
            {
                MessageBox.Show("Korisnicko ime je pogresno");
                ClearTexts(user, pass);
                return false;
            }
            //check password is empty 
            else
            {
                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Uneiste lozinku");
                    return false;
                }
                
                //check password is correct 
                else if (Userpassword != pass)
                {
                    MessageBox.Show("Lozinka nije ispravnja");
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
    }
}
