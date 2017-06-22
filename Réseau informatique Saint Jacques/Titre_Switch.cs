using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Réseau_informatique_Saint_Jacques
{
    class Titre_Switch : Form
    {
        private Synthèse synthèse = new Synthèse();        
    

    public void titre_switch(LinkLabel titre)
        {
            
            switch (synthèse.Transfert)
            {
                case "SW_SR1_1":
                    titre.Text = "Switch 48 ports - Local Internet : 172.16.7.251";
                    titre.Links.Clear();
                    titre.Links.Add(35, 12, "http://172.16.7.251");
                    break;

                case "SW_SR2_1":
                    titre.Text = "Switch N°1 - 24 ports - Bureau Informatique : 172.16.7.254";
                    titre.Links.Clear();
                    titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_2":
                    titre.Text = "Switch N°2 - 24 ports - Bureau Informatique : 172.16.7.254";
                    titre.Links.Clear();
                    titre.Links.Add(46, 12, "http://172.16.7.254");
                    break;

                case "SW_SR2_3":
                    titre.Text = "Switch N°1 - 48 ports - Bureau Informatique : 172.16.7.253";
                    titre.Links.Clear();
                    titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR2_4":
                    titre.Text = "Switch N°2 - 48 ports - Bureau Informatique : 172.16.7.253";
                    titre.Links.Clear();
                    titre.Links.Add(46, 12, "http://172.16.7.253");
                    break;

                case "SW_SR3_1":
                    titre.Text = "Switch N°1 - 48 ports - Salle Informatique : 172.16.7.252";
                    titre.Links.Clear();
                    titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR3_2":
                    titre.Text = "Switch N°2 - 48 ports - Salle Informatique : 172.16.7.252";
                    titre.Links.Clear();
                    titre.Links.Add(45, 12, "http://172.16.7.252");
                    break;

                case "SW_SR4_1":
                    titre.Text = "Switch 48 ports - Bureau Vie Scolaire : 172.16.7.244";
                    titre.Links.Clear();
                    titre.Links.Add(40, 12, "http://172.16.7.244");
                    break;

                case "SW_SR5_1":
                    titre.Text = "Switch 48 ports - Salle de Sport : 172.16.7.245";
                    titre.Links.Clear();
                    titre.Links.Add(35, 12, "http://172.16.7.245");
                    break;

                case "SW_Cdi":
                    titre.Text = "Switch 5 ports - Cdi";
                    titre.Links.Clear();
                    //Titre.Links.Add(35, 12, "http://172.16.7.245");
                    break;

                case "SW_Laurent":
                    titre.Text = "Switch 28 ports - Bureau Laurent : 172.16.7.242";
                    titre.Links.Clear();
                    titre.Links.Add(35, 12, "http://172.16.7.242");
                    break;
            }

        }

    }
    
}
