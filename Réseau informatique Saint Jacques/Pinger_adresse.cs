using System.Net.NetworkInformation;
using System.Text;

namespace Réseau_informatique_Saint_Jacques
{
    internal class PingerAdresse
    {
        public bool PingPériphérique(string nameOrAddress)
        {
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 1;
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                if (nameOrAddress != "")
                {
                    PingReply reply;
                    reply = pinger.Send(nameOrAddress, timeout, buffer, options);
                    if (reply != null) pingable = reply.Status == IPStatus.Success;
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