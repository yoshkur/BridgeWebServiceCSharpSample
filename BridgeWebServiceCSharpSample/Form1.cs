using System;
using System.Windows.Forms;

namespace BridgeWebServiceCSharpSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BridgeServiceReference.BridgeWebServiceClient client = new BridgeServiceReference.BridgeWebServiceClient();
            BridgeServiceReference.bridge[] bridges = client.getBridgeList();

            BindingSource bs = new BindingSource();

            foreach (BridgeServiceReference.bridge bridge in bridges)
            {
                bs.Add(bridge);
            }
            this.dataGridView1.DataSource = bs;
        }
    }
}
