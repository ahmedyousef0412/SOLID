using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class WebMail : IMessage
    {
        public string Address = "Address";

        public string From = "From Mail";

        public string ToAdress = "To Address";

        public void Send()
        {

        }

    }
}
