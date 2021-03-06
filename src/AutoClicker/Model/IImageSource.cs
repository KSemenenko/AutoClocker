﻿using System;
using System.Drawing;
using AutoClicker.Model.Abstraction.Interface;

namespace AutoClicker.Model
{
    public class ImageSource : IImageSource
    {
        private Bitmap _source;

        public Bitmap Source
        {
            get { return _source; }
            set
            {
                if(value != null)
                {
                    _source = value;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }
    }
}