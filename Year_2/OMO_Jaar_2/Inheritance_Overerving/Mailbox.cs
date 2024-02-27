using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Mailbox
    {
        protected string _Owner;
        protected List<Mail> mails;

        public Mailbox(string owner) 
        {
            _Owner = owner;
            mails = new List<Mail>();
        }

        public void Post(Mail post)
        {
            mails.Add(post);
            
        }

        public string Open()
        {
            
            if (mails.Count == 0)
            {
                Console.WriteLine("You're mailbox is empty");
            }
            else
            {

                foreach (Mail mail in mails)
                {
                    Console.WriteLine("Mail #" +(mails.IndexOf(mail)+1)+"\t"+ mail.GetMailType()  + "\n\n" + mail.ShowContent());   
                }
                mails.Clear();
            }
            return string.Empty;
        }

        public override string ToString()
        {
            return string.Format("{0}'s Mailbox:\n\n{1}",_Owner,Open());
        }

        


    }
}
