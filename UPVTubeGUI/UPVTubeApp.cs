using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpvTube.BusinessLogic.Services;

namespace UPVTubeGUI
{
    public partial class UPVTubeApp : Form
    {

        public IUPVTubeService service;
    
        public UPVTubeApp(IUPVTubeService Service)
        {
            InitializeComponent();
            this.service = Service;
        }
    }
}
