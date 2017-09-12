using Gastronomia.Base.Helpers;
using System;
using System.Windows.Forms;

namespace Gastronomia.Base.Formularios
{
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }

        public virtual void ColorControl_Enter(object sender, EventArgs e)
        {
            if(sender is TextBox)
                ((TextBox)sender).BackColor = ColorControles.RecibeFoco;
        }

        public virtual void ColorControl_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
                ((TextBox)sender).BackColor = ColorControles.PierdeFoco;
        }
    }
}
