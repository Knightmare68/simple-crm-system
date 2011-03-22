using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class GlobalData
    {
        private static GlobalData _instance = new GlobalData();
        public static GlobalData GetInstance()
        {
            if (_instance == null)
            {
                return new GlobalData();
            }
            return _instance;
        }
        public Dictionary<string, Object> ShareData
        {
            get { return sharedata; }
        }
        private Dictionary<String, Object> sharedata = new Dictionary<string, object>();
        private GlobalData()
        {
            
        }
        public void Add(String Key, Object value)
        {
            if (!this.ShareData.ContainsKey(Key))
            {
                this.ShareData.Add(Key, value);

            }
            else
            {
                this.ShareData[Key] = value;
            }
        }
    }
}
