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
    public partial class UPVTubeBase : Form
    {

        public IUPVTubeService service;

        public UPVTubeBase()
        {
            InitializeComponent();
        }
    
        public UPVTubeBase(IUPVTubeService Service):this()
        {
            this.service = Service;
        }
    }
}
