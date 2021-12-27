using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class Notification
    {

        #region Dependency Injection Using Constructor
        //private readonly IMessage _mailservice;

        //public Notification(IMessage mailservice)
        //{
        //    _mailservice = mailservice;
        //}
        #endregion


        #region Dependency Injection Using Method
        //public void SendMail(IMessage mailservice)
        //{
        //    mailservice.Send();
        //}
        #endregion

        #region Dependency Injection Using Property


        //private IMessage MailServiceType { get; set; }
        //public void SendMail()
        //{
        //    MailServiceType.Send();
        //}
        #endregion




    }
}
