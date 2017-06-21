using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Réseau_informatique_Saint_Jacques
{
    class Pinger_adresse
    {
        public bool Ping_Périphérique(string nameOrAddress)
        {
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 20;
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                if (nameOrAddress != "")
                {
                    PingReply reply = pinger.Send(nameOrAddress, timeout, buffer, options);
                    pingable = reply.Status == IPStatus.Success;
                }
                if (nameOrAddress == "")
                {
                    return true;
                }
            }
            catch (PingException)
            {
                return false;
            }
            return pingable;
        }
    }
}
