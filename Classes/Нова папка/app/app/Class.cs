using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace app
{
    public partial class Class : Component
    {
        public Class()
        {
            InitializeComponent();
        }

        public Class(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
