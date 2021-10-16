using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FabricaDeTroopers
{
    public partial class FrmPpal : Form
    {

        EjercitoImperial ejercitoImperial;
        /// <summary>
        /// Constructor por defecto del FormPpal
        /// </summary>
        public FrmPpal()
        {
            InitializeComponent();
            this.ejercitoImperial = new EjercitoImperial(10);
            this.ejercitoImperial +=  new TrooperAsalto(Blaster.EC17);
            RefrescarEjercito();
        }
        /// <summary>
        /// Al cargar el formulario lo inicializa con los valores y configuraciones necesarias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPpal_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList; 
            this.cmbTipo.Items.Add("Arena");
            this.cmbTipo.Items.Add("Asalto");
            this.cmbTipo.Items.Add("Explorador");
            this.cmbBlaster.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBlaster.Items.Add("E11");
            this.cmbBlaster.Items.Add("EC17");
            this.cmbBlaster.Items.Add("DLT19");
           //this.cmbBlaster.DataSource = Enum.GetValues(typeof(Biblioteca.Blaster));
        }
        /// <summary>
        /// Agrega un soldado a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool esClon = false;
            if (cbxClon.Checked == true)
                esClon = true;
            if(this.cmbBlaster.Text.Length > 0)
            {
                switch (this.cmbTipo.Text)
                {
                    case "Arena":
                        TrooperArena trooperArena = new TrooperArena((Blaster)this.cmbBlaster.SelectedIndex);
                        trooperArena.EsClon = esClon;
                        this.ejercitoImperial += trooperArena;
                        break;
                    case "Asalto":
                        TrooperAsalto trooperAsalto = new TrooperAsalto((Blaster)this.cmbBlaster.SelectedIndex);
                        trooperAsalto.EsClon = esClon;
                        this.ejercitoImperial += trooperAsalto;
                        break;
                    case "Explorador": //Solo va a dejar cargar el blaster con EC17
                        cmbBlaster.Enabled = true;
                        TrooperExplorador trooperExplorador = new TrooperExplorador("Moto");
                        trooperExplorador.EsClon = esClon;
                        this.ejercitoImperial += trooperExplorador;
                        break;
                }
                RefrescarEjercito();
            }
        }
        /// <summary>
        /// Elimina un soldado de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            switch(this.cmbTipo.Text)
            {
                case "Arena":
                    this.ejercitoImperial -= new TrooperArena(Blaster.EC17);
                    break;
                case "Asalto":
                    this.ejercitoImperial -= new TrooperAsalto(Blaster.E11);
                    break;
                case "Explorador":
                    this.ejercitoImperial -= new TrooperExplorador("Moto");
                    break;
            }
            RefrescarEjercito();
        }
        /// <summary>
        /// Metodo que limpia la listBox para despues mostrar en ella la lista actualizada.
        /// </summary>
        private void RefrescarEjercito()
        {
            this.lstEjercito.Items.Clear();
            foreach (Trooper item in ejercitoImperial.Troopers)
            {
                this.lstEjercito.Items.Add(item.InfoTrooper());
            }
        }
    }
}
