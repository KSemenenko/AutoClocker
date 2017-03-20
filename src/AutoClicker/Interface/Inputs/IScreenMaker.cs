﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AutoClicker.Inputs
{
    interface IScreenMaker
    {
        BitmapSource GetBitmapSourceFromScreen();
        Bitmap GetBitmapFromScreen();
    }
}
