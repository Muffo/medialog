using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Catalogo;
using System.Collections;

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

            GestoreCatalogo.aggiungiSupporto("F:\\");
           CatalogoSingleton catSing = CatalogoSingleton.getInstance();
           RefreshSupporti(catSing);
           MessageBox.Show("Id supporto: sup" + (CatalogoSingleton.getInstance().Supporti.Count-1));
        }

        private void RefreshSupporti(CatalogoSingleton catSing)
        {
            elencoSupporti.Items.Clear();
            comboBoxIdSupporti.Items.Clear();
            foreach (Supporto sup in catSing.Supporti)
            {
                elencoSupporti.Items.Add(sup.Id);
                comboBoxIdSupporti.Items.Add(sup.Id);
                elencoSupporti.SetItemChecked(0, true);

                elencoSupporti.ColumnWidth = 200;
            }
        }

        private void buttonVisualizzaContenuto_Click(object sender, EventArgs e)
        {
            List<string> res = new List<string>();
            dataGridViewContenutoSupporto.Columns.Clear();
            dataGridViewContenutoSupporto.Columns.Add("nome file", "nome file");

            foreach (IEnumerable ele in elencoSupporti.CheckedItems)
            {
                GestoreCatalogo.visualizzaSupporto(ele.ToString()).GetBulkInit(res);
                
               
            }
            foreach (string file in res)
                dataGridViewContenutoSupporto.Rows.Add(file);
                // DataBindings.Add("root",GestoreCatalogo.visualizzaSupporto(elencoSupporti.SelectedItem.ToString()),"file e direttori");
        }

        private void buttonRimuoviDaCatalogo_Click(object sender, EventArgs e)
        {
            CatalogoSingleton catSing = CatalogoSingleton.getInstance();
            GestoreCatalogo.eliminaSupporto(elencoSupporti.CheckedItems[0].ToString());
            
            RefreshSupporti(catSing);
        }

        private void buttonAvviaRicerca_Click(object sender, EventArgs e)
        {
            dataGridViewRisultatoRicerca.Columns.Clear();
            
            if ((textBox1.Text.Equals("")&& textBox1.Enabled) || (textBox2.Text.Equals("")&& textBox2.Enabled))
            {
                MessageBox.Show("Nessun valore specifico inserito!");
                
            }
            else
            {
                string ext=null;
                string name=null;
                if (textBox2.Text.Equals("inserisci estensione [jpg;doc,..]")) ext = ""; else ext = textBox2.Text;
                if (textBox1.Text.Equals("inserisci nome file")) name = ""; else name = textBox1.Text;
                dataGridViewRisultatoRicerca.Columns.Add("supporto", "supporto");
                dataGridViewRisultatoRicerca.Columns.Add("file", "file");
                dataGridViewRisultatoRicerca.Rows.Add("sup3", name + "." + ext);
            }
        }

        private void buttonInserisciModificaPersona_Click(object sender, EventArgs e)
        {
            if (textBoxNickname.Text.Equals("nome univoco (obbligatorio)"))
            {
                MessageBox.Show("Inserire nickname!!");
                
            }
            else
            {
            this.dataGridViewElencoPersone.Columns.Add("nickname","nickname");
            this.dataGridViewElencoPersone.Columns.Add("nome","nome");
            this.dataGridViewElencoPersone.Columns.Add("cognome","cognome");
            this.dataGridViewElencoPersone.Columns.Add("e-mail","e-mail");
            this.dataGridViewElencoPersone.Columns.Add("telefono","telefono");
            dataGridViewElencoPersone.Rows.Add(textBoxNickname.Text,textBoxNome.Text,textBoxCognome.Text,textBoxEmail.Text,textBoxTelefono.Text);
            comboBoxNickname.Items.Add(textBoxNickname.Text);
            comboBoxNicknamePrestiti.Items.Add(textBoxNickname.Text);
            }
                
           
        }

        private void buttonCancellaPersona_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow ro in dataGridViewElencoPersone.Rows)
            {
                if (ro.Cells[0].Value.Equals(comboBoxNickname.SelectedItem.ToString()))
                {
                    dataGridViewElencoPersone.Rows.Remove(ro);
                    comboBoxNicknamePrestiti.Items.Remove(comboBoxNickname.SelectedItem);
                    comboBoxNickname.Items.Remove(comboBoxNickname.SelectedItem);
                    
                }
            }
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {

            if ((comboBoxNicknamePrestiti.SelectedItem== null) && textBoxNuovoNickname.Text.Equals("nuovo nickname"))
            {
                MessageBox.Show("Seleziona nickname o inserisci nuovo nickname!");
                return;
            }
            if (comboBoxIdSupporti.SelectedItem==null)
            {
                MessageBox.Show("Seleziona un supporto!");
                return;
            }
            {
                string nick=null;
                if (textBoxNuovoNickname.Text.Equals("nuovo nickname")) nick = comboBoxNicknamePrestiti.SelectedItem.ToString();
                else
                {
                    nick = textBoxNuovoNickname.Text;
                    this.dataGridViewElencoPersone.Columns.Add("nickname", "nickname");
                    this.dataGridViewElencoPersone.Columns.Add("nome", "nome");
                    this.dataGridViewElencoPersone.Columns.Add("cognome", "cognome");
                    this.dataGridViewElencoPersone.Columns.Add("e-mail", "e-mail");
                    this.dataGridViewElencoPersone.Columns.Add("telefono", "telefono");
                    comboBoxNickname.Items.Add(nick);
                    dataGridViewElencoPersone.Rows.Add(nick, "modifica", "modifica", "modifica", "modifica");
                    comboBoxNicknamePrestiti.Items.Add(nick);
                }
                dataGridViewElencoPrestiti.Columns.Add("supporto", "supporto");
                dataGridViewElencoPrestiti.Columns.Add("nickname persona", "nickname persona");
                dataGridViewElencoPrestiti.Rows.Add(comboBoxIdSupporti.SelectedItem, nick);
                comboBoxElencoSupportiPrestati.Items.Add(comboBoxIdSupporti.SelectedItem);
                comboBoxIdSupporti.Items.Remove(comboBoxIdSupporti.SelectedItem);
            }

        }

        private void buttonRestituisci_Click(object sender, EventArgs e)
        {
            if ((comboBoxElencoSupportiPrestati.SelectedItem == null))
            {
                MessageBox.Show("seleziona un Supporto");
                return;
            }
            foreach (DataGridViewRow ro in dataGridViewElencoPrestiti.Rows)
            {
                if (ro.Cells[0].Value.Equals(comboBoxElencoSupportiPrestati.SelectedItem))
                {
                    dataGridViewElencoPrestiti.Rows.Remove(ro);
                    comboBoxIdSupporti.Items.Add(comboBoxElencoSupportiPrestati.SelectedItem);
                    comboBoxElencoSupportiPrestati.Items.Remove(comboBoxElencoSupportiPrestati.SelectedItem);
                    
                }
            }
        }

        private void Nome_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = Nome.Checked;
        }

        private void Dimensione_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDimensione.Enabled = Dimensione.Checked;
        }

        private void Estensione_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = Estensione.Checked;
        }

        private void textBoxNome_Enter(object sender, EventArgs e)
        {
            
        }
    
        
    }
}
