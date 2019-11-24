using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StackExchange.Redis;

namespace winform.RedisApp
{
    public partial class FormConnectServer : Form
    {
        public FormConnectServer()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string strServer = textServer.Text.Trim();
            string strPort = textPort.Text.Trim();
            string strPassword = textPassword.Text.Trim();

            //string configString = GetRedisConfiguration();

            try
            {
                ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(strServer+":"+ strPort);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "错误");
            }

        }
    }
}
