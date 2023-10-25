﻿using MPCobro.BusinessLogic;
using MPCobro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPCobro.desktop
{
    public partial class NuevoRolWF : MaterialSkin.Controls.MaterialForm
    {
        int id = 0;
        public NuevoRolWF()
        {
            InitializeComponent();
          
        }
        public NuevoRolWF(Rol entity)
        {
            InitializeComponent();
          
            txtNombre.Text = entity.Nombre;
            id = entity.RolId;
        }
     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Rol entity = new Rol()
            {
                Nombre = txtNombre.Text
            };
            if (entity != null)
            {
                if (RolBLL.Instance.Insert(entity))
                {
                    MessageBox.Show("El registro se almaceno con exito", "Confirmacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WFRol wFRol = new WFRol();
                   
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            this.Close();
        }
    }
}
