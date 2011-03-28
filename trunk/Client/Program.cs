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
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormManager.GetInstance().Add(new Login());
            FormManager.GetInstance().Add(new Main());
            //Application.Run(new Main());
            Application.Run(FormManager.GetInstance().GetFormByName(typeof(Login).ToString()));
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            object user = GlobalData.GetInstance().ShareData["User"];
            //如果user is null,说明用户压根没登录过
            if (user != null)
            {
                ClientProxy.GetInstance().GetUserService.Logoff(user.ToString());
            }
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
