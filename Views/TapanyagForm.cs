using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tapanyagok.Models;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Views
{
    public partial class TapanyagForm : Form, ITapanyagView
    {
        private int id;

        public TapanyagForm()
        {
            InitializeComponent();

            // TODO: default 0
            id = tapanyag.id;
            nevTB.Text = tapanyag.nev;
            energiaNUD.Value = tapanyag.energia;
            feherjeNUD.Value = tapanyag.feherje;
            zsirNUD.Value = tapanyag.zsir;
            szenhidratNUD.Value = tapanyag.szenhidrat;
        }

        public tapanyag tapanyag { get; set; }
    }
}
