using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using log4net;
using System.Threading;
namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormManager.GetInstance().Add(new Login());
            FormManager.GetInstance().Add(new Main());
            //Application.Run(new Main());
            Application.Run(FormManager.GetInstance().GetFormByName(typeof(Login).ToString()));
        }
        private static readonly ILog log = LogManager.GetLogger("ClientApplication");

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            log.Error(e.Exception);
            MessageBox.Show(e.Exception.Message.ToString()+Environment.NewLine+"StackTrace:"+e.Exception.StackTrace);
            //throw new NotImplementedException();
        }
    }
}
