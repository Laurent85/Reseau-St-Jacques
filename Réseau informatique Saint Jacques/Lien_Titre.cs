using System.Diagnostics;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    internal class LienTitre : Form
    {
        public void lienTitre(LinkLabel titre)
        {
            if (titre.Text.Contains("172.16.7.251")) Process.Start("http://172.16.7.251");
            if (titre.Text.Contains("172.16.7.252")) Process.Start("http://172.16.7.252");
            if (titre.Text.Contains("172.16.7.253")) Process.Start("http://172.16.7.253");
            if (titre.Text.Contains("172.16.7.254")) Process.Start("http://172.16.7.254");
            if (titre.Text.Contains("172.16.7.244")) Process.Start("http://172.16.7.244");
            if (titre.Text.Contains("172.16.7.245")) Process.Start("http://172.16.7.245");
            if (titre.Text.Contains("172.16.7.242")) Process.Start("IEXPLORE.EXE", "-nomerge http://172.16.7.242");
        }
    }
}