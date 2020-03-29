using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_MVP.View;
using WindowsFormsApp_MVP.Model;

namespace WindowsFormsApp_MVP.Presenter
{
    public class LoginPresenter
    {
        ILoginPanel LoginPanel_View;
        LoginModel  LoginModel = new LoginModel();
        
        public LoginPresenter(ILoginPanel view)
        {
            LoginPanel_View                 = view;
            LoginModel.KullaniciAdi         = LoginPanel_View.KullaniciAdi;
            LoginModel.Sifre                = LoginPanel_View.Sifre;
            LoginPanel_View.GirisTiklandi  += LoginPanel_View_GirisTiklandi;
        }

        private void LoginPanel_View_GirisTiklandi(object sender, EventArgs e)
        {
            if (LoginModel.KullaniciAdi == "metin")
            {
                if (LoginModel.Sifre == "1234")
                {
                    LoginPanel_View.GirisDurumu = "ONAYLANDI";
                }
                else
                {
                    LoginPanel_View.GirisDurumu = "ŞİFRE YANLIŞ";
                }
            }
            else
            {
                LoginPanel_View.GirisDurumu = "KULLANICI ADI YANLIŞ";
            }
        }
    }
}
