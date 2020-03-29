using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_MVP.View
{
    public interface ILoginPanel
    {
        event EventHandler GirisTiklandi;

        string KullaniciAdi { get; set; }
        string Sifre        { get; set; }
        string GirisDurumu  { get; set; }
    }
}
