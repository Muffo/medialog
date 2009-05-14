using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Catalogo;

namespace MediaLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAggiungiCatalogo_Click(object sender, EventArgs e)
        {

            GestoreCatalogo.aggiungiSupporto(comboBoxElencoSorgenti.Text);
           CatalogoSingleton catSing = CatalogoSingleton.getInstance();
           foreach (Supporto sup in catSing.Supporti)
           {
               elencoSupporti.Items.Add(sup.Id);
           }
        }

        private void buttonVisualizzaContenuto_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            
            GestoreCatalogo.visualizzaSupporto(elencoSupporti.SelectedItem.ToString()).GetBulkInit(res);
            dataGridViewContenutoSupporto.Columns.Add("nome file", "nomi contenuti");
            foreach(string file in res)
            dataGridViewContenutoSupporto.Rows.Add(file);
                // DataBindings.Add("root",GestoreCatalogo.visualizzaSupporto(elencoSupporti.SelectedItem.ToString()),"file e direttori");
        }

        private void buttonRimuoviDaCatalogo_Click(object sender, EventArgs e)
        {
            GestoreCatalogo.eliminaSupporto(elencoSupporti.SelectedItem.ToString());
            
        }
    
        
    }
}
