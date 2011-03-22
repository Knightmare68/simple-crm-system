using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Client
{
    public class FormManager
    {
        private Dictionary<String, Form> formlist = new Dictionary<string, Form>();
        private static FormManager formanager = new FormManager();
        private FormManager()
        {

        }
        public static FormManager GetInstance()
        {
            if (formanager == null)
            {
               formanager = new FormManager();
            }
            return formanager;
        }

        public void Add(Form f)
        {
            this.formlist.Add(f.GetType().ToString(),f);
        }
        public Form GetFormByName(String formname)
        {
            Form result = formlist[formname];
            if (result == null)
            {
                throw new Exception("The Form not find!");
            }
            return result;
        }
    }
}
