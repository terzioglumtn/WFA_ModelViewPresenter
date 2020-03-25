using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_MVP.Model
{
    public class LoginModel
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public string Bilgi_Kontrol()
        {
            if (KullaniciAdi == "metin")
            {
                if (Sifre == "1234")
                {
                    return "ONAYLANDI";
                }
                else
                {
                    return "ONAYLANMADI";
                }
            }
            else
            {
                return "ONAYLANMADI";
            }
        }
    }
}