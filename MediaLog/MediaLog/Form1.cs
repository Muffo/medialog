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
           RefreshSupporti(catSing);
        }

        private void RefreshSupporti(CatalogoSingleton catSing)
        {
            elencoSupporti.Items.Clear();
            foreach (Supporto sup in catSing.Supporti)
            {
                elencoSupporti.Items.Add(sup.Id);
                elencoSupporti.SetItemChecked(0, true);
            }
        }

        private void buttonVisualizzaContenuto_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            dataGridViewContenutoSupporto.Columns.Clear();
            GestoreCatalogo.visualizzaSupporto(elencoSupporti.CheckedItems[0].ToString()).GetBulkInit(res);
            dataGridViewContenutoSupporto.Columns.Add("nome file", "nomi contenuti");
            foreach(string file in res)
            dataGridViewContenutoSupporto.Rows.Add(file);
                // DataBindings.Add("root",GestoreCatalogo.visualizzaSupporto(elencoSupporti.SelectedItem.ToString()),"file e direttori");
        }

        private void buttonRimuoviDaCatalogo_Click(object sender, EventArgs e)
        {
            CatalogoSingleton catSing = CatalogoSingleton.getInstance();
            GestoreCatalogo.eliminaSupporto(elencoSupporti.CheckedItems[0].ToString());
            
            RefreshSupporti(catSing);
        }
    
        
    }
}
