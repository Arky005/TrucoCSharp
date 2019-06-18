using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoCSharp
{
    public partial class Carta : System.Windows.Forms.Label
    {
        public Carta()
        {
            InitializeComponent();
        }

        public Carta(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
