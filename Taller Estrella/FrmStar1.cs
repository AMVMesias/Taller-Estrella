﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Estrella
{
    public partial class FrmStar1 : Form
    {
        private static FrmStar1 _instance = null;
        public FrmStar1()
        {
            InitializeComponent();
        }

        public static FrmStar1 GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmStar1();
            }
            return _instance;
        }

        private void FrmStar1_Load(object sender, EventArgs e)
        {

        }
    }
}
