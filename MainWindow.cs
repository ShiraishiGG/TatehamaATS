﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TatehamaATS.DisplayLED;

namespace TatehamaATS
{
    public partial class MainWindow : Form
    {
        private ControlLED controlLED;
        private Relay relay;

        public MainWindow()
        {
            InitializeComponent();
            TrainState.init();
            controlLED = new ControlLED();
            relay = new Relay();
        }

        private void LEDWindowButton_Click(object sender, EventArgs e)
        {
            if (controlLED.isShow)
            {
                controlLED.LEDHide();
            }
            else
            {
                controlLED.LEDShow();
            }
            LEDStatus.Text = controlLED.isShow ? "表　示" : "非表示";
        }

        private void ToL1Button_Click(object sender, EventArgs e)
        {
        }

        private void ToL2Button_Click(object sender, EventArgs e)
        {
        }

        private void ToL3Button_Click(object sender, EventArgs e)
        {
        }
    }
}
