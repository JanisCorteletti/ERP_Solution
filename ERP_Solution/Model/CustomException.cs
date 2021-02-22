using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Solution.Model
{
    public class CustomException : System.Exception
    {
        public CustomException() : base() { }
        public CustomException(string message) : base(message)
        {
            MessageBox.Show(message, "Application Message");
        }
    }
}
