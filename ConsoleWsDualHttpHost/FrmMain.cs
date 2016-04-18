using HzDataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace ConsoleWsDualHttpHost
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OperationContext.Current != null)
            {
                var clients = OperationContext.Current.GetCallbackChannel<IHeart>();
                if (clients != null)
                {
                    Console.WriteLine("call back start");
                    clients.HeartBit(new Random().Next(1, 100));
                    Console.WriteLine("call back finish");
                }
                else
                {
                    Console.WriteLine("no client to call back");
                }
            }
            else
            {
                Console.WriteLine("no client");
            }
        }
    }
}
