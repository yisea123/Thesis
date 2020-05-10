using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraIPOnvif1
{
	public partial class SettingUART : Form
	{
		public string textIP = "";
		public string textPort= "";
		public SettingUART()
		{
			InitializeComponent();
		}

		private void btnclose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SettingUART_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			textIP = txbModuleIP.Text;
			textPort = txbMuduleport.Text;
		}
	}
}
