using System.Diagnostics;
using System.Windows.Forms;

namespace Réseau_informatique_Saint_Jacques
{
    internal class LienTitre : Form
    {
        public void lienTitre(LinkLabel Titre)
        {
            if (Titre.Text.Contains("172.16.7.251")) Process.Start("http://172.16.7.251");
            if (Titre.Text.Contains("172.16.7.252")) Process.Start("http://172.16.7.252");
            if (Titre.Text.Contains("172.16.7.253")) Process.Start("http://172.16.7.253");
            if (Titre.Text.Contains("172.16.7.254")) Process.Start("http://172.16.7.254");
            if (Titre.Text.Contains("172.16.7.244")) Process.Start("http://172.16.7.244");
            if (Titre.Text.Contains("172.16.7.245")) Process.Start("http://172.16.7.245");
            if (Titre.Text.Contains("172.16.7.242")) Process.Start("IEXPLORE.EXE", "-nomerge http://172.16.7.242");
        }
    }
}