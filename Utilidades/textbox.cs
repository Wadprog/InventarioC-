﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public partial class textbox : System.Windows.Forms.TextBox
    {
        public bool Validar
        {
            set;
            get;
        }

        public textbox()
        {
            InitializeComponent();
        }

        public textbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
