using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.ServiceModel;


namespace GGS
{
    public partial class Default : System.Web.UI.Page
    {
        double result;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtTest.Text += string.Format("{0} | Client has been started.\n", Time());
            }

            var service = CreateService();  
            var result = service.Add(4f, 5f);
        }

        private ICalculator CreateService()
        {
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferPoolSize = 2147483647;
            ChannelFactory<ICalculator> service = new ChannelFactory<ICalculator>(binding, new EndpointAddress("net.tcp://localhost:10730/GGShost/Service/CalculatorService"));
            ICalculator mservice = service.CreateChannel();
            return mservice;
        }

        protected void btnTest_Click(object sender, EventArgs e)
        {
            var service = CreateService();

            if (txtValue1.Text != string.Empty && txtValue2.Text != string.Empty)
            {
                txtTest.Text += string.Format("{0} | Sending data to host: {1} and {2}\n", Time(), txtValue1.Text, txtValue2.Text);

                try
                {
                    result = service.Add(Convert.ToDouble(txtValue1.Text), Convert.ToDouble(txtValue2.Text));
                    txtTest.Text += string.Format("{0} | Received result: {1}\n", Time(), result.ToString());
                }
                catch
                {
                    txtTest.Text += string.Format("{0} | ERROR: {1}", Time(), "error\n");
                }

                try
                {
                    txtTest.Text += DateTime.Now + " | Client closed.\n";
                }
                catch
                {
                    txtTest.Text += DateTime.Now + " | Client couldn't close. Did something go wrong?\n";
                }
            }
            else
            {
                txtTest.Text += DateTime.Now + " | You need to enter two values.\n";
            }
        }

        public string Time()
        {
            string time = DateTime.Now.ToString();
            return time;
        }
    }
}