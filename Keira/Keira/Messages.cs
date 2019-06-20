using System;
using System.Collections.Generic;
using System.Text;

namespace Keira
{
    public class Messages
    {
        private string message;
        public Messages()
        {
        }

        public void Add(string arg)
        {
            this.message = arg;
        }

        public string Show()
        {
            return this.message;
        }
    }
}
