namespace MediaLog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.viewCatalogo = new System.Windows.Forms.TabPage();
            this.buttonAggiungiCatalogo = new System.Windows.Forms.Button();
            this.GroupBoxVisualizzaEliminaSupporto = new System.Windows.Forms.GroupBox();
            this.buttonRimuoviDaCatalogo = new System.Windows.Forms.Button();
            this.dataGridViewContenutoSupporto = new System.Windows.Forms.DataGridView();
            this.buttonVisualizzaContenuto = new System.Windows.Forms.Button();
            this.elencoSupporti = new System.Windows.Forms.CheckedListBox();
            this.viewRicerca = new System.Windows.Forms.TabPage();
            this.groupBoxRisultatoRicerca = new System.Windows.Forms.GroupBox();
            this.dataGridViewRisultatoRicerca = new System.Windows.Forms.DataGridView();
            this.groupBoxParametriRicerca = new System.Windows.Forms.GroupBox();
            this.comboBoxDimensione = new System.Windows.Forms.ComboBox();
            this.buttonAvviaRicerca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.viewAnagrafe = new System.Windows.Forms.TabPage();
            this.groupBoxElencoPersone = new System.Windows.Forms.GroupBox();
            this.dataGridViewElencoPersone = new System.Windows.Forms.DataGridView();
            this.groupBoxCancellazionePersone = new System.Windows.Forms.GroupBox();
            this.comboBoxNickname = new System.Windows.Forms.ComboBox();
            this.buttonCancellaPersona = new System.Windows.Forms.Button();
            this.groupBoxInserimentoPersone = new System.Windows.Forms.GroupBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonInserisciModificaPersona = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewPrestiti = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRestituisci = new System.Windows.Forms.Button();
            this.comboBoxElencoSupportiPrestati = new System.Windows.Forms.ComboBox();
            this.groupBoxPrestitiAttivi = new System.Windows.Forms.GroupBox();
            this.dataGridViewElencoPrestiti = new System.Windows.Forms.DataGridView();
            this.groupBoxInserisciPrestito = new System.Windows.Forms.GroupBox();
            this.comboBoxIdSupporti = new System.Windows.Forms.ComboBox();
            this.comboBoxNicknamePrestiti = new System.Windows.Forms.ComboBox();
            this.textBoxNuovoNickname = new System.Windows.Forms.TextBox();
            this.buttonPresta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxElencoSorgenti = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.viewCatalogo.SuspendLayout();
            this.GroupBoxVisualizzaEliminaSupporto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContenutoSupporto)).BeginInit();
            this.viewRicerca.SuspendLayout();
            this.groupBoxRisultatoRicerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisultatoRicerca)).BeginInit();
            this.groupBoxParametriRicerca.SuspendLayout();
            this.viewAnagrafe.SuspendLayout();
            this.groupBoxElencoPersone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElencoPersone)).BeginInit();
            this.groupBoxCancellazionePersone.SuspendLayout();
            this.groupBoxInserimentoPersone.SuspendLayout();
            this.viewPrestiti.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPrestitiAttivi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElencoPrestiti)).BeginInit();
            this.groupBoxInserisciPrestito.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.viewCatalogo);
            this.tabControl1.Controls.Add(this.viewRicerca);
            this.tabControl1.Controls.Add(this.viewAnagrafe);
            this.tabControl1.Controls.Add(this.viewPrestiti);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // viewCatalogo
            // 
            this.viewCatalogo.Controls.Add(this.comboBoxElencoSorgenti);
            this.viewCatalogo.Controls.Add(this.buttonAggiungiCatalogo);
            this.viewCatalogo.Controls.Add(this.GroupBoxVisualizzaEliminaSupporto);
            this.viewCatalogo.Location = new System.Drawing.Point(4, 22);
            this.viewCatalogo.Name = "viewCatalogo";
            this.viewCatalogo.Padding = new System.Windows.Forms.Padding(3);
            this.viewCatalogo.Size = new System.Drawing.Size(506, 354);
            this.viewCatalogo.TabIndex = 0;
            this.viewCatalogo.Text = "Gestione Catalogo";
            this.viewCatalogo.UseVisualStyleBackColor = true;
            // 
            // buttonAggiungiCatalogo
            // 
            this.buttonAggiungiCatalogo.Location = new System.Drawing.Point(146, 13);
            this.buttonAggiungiCatalogo.Name = "buttonAggiungiCatalogo";
            this.buttonAggiungiCatalogo.Size = new System.Drawing.Size(238, 23);
            this.buttonAggiungiCatalogo.TabIndex = 3;
            this.buttonAggiungiCatalogo.Text = "-> aggiungi supporto a catalogo";
            this.buttonAggiungiCatalogo.UseVisualStyleBackColor = true;
            this.buttonAggiungiCatalogo.Click += new System.EventHandler(this.buttonAggiungiCatalogo_Click);
            // 
            // GroupBoxVisualizzaEliminaSupporto
            // 
            this.GroupBoxVisualizzaEliminaSupporto.Controls.Add(this.buttonRimuoviDaCatalogo);
            this.GroupBoxVisualizzaEliminaSupporto.Controls.Add(this.dataGridViewContenutoSupporto);
            this.GroupBoxVisualizzaEliminaSupporto.Controls.Add(this.buttonVisualizzaContenuto);
            this.GroupBoxVisualizzaEliminaSupporto.Controls.Add(this.elencoSupporti);
            this.GroupBoxVisualizzaEliminaSupporto.Location = new System.Drawing.Point(3, 42);
            this.GroupBoxVisualizzaEliminaSupporto.Name = "GroupBoxVisualizzaEliminaSupporto";
            this.GroupBoxVisualizzaEliminaSupporto.Size = new System.Drawing.Size(503, 309);
            this.GroupBoxVisualizzaEliminaSupporto.TabIndex = 1;
            this.GroupBoxVisualizzaEliminaSupporto.TabStop = false;
            this.GroupBoxVisualizzaEliminaSupporto.Text = "Contenuto catalogo";
            // 
            // buttonRimuoviDaCatalogo
            // 
            this.buttonRimuoviDaCatalogo.Location = new System.Drawing.Point(10, 50);
            this.buttonRimuoviDaCatalogo.Name = "buttonRimuoviDaCatalogo";
            this.buttonRimuoviDaCatalogo.Size = new System.Drawing.Size(126, 23);
            this.buttonRimuoviDaCatalogo.TabIndex = 3;
            this.buttonRimuoviDaCatalogo.Text = "Rimozione da catalogo";
            this.buttonRimuoviDaCatalogo.UseVisualStyleBackColor = true;
            this.buttonRimuoviDaCatalogo.Click += new System.EventHandler(this.buttonRimuoviDaCatalogo_Click);
            // 
            // dataGridViewContenutoSupporto
            // 
            this.dataGridViewContenutoSupporto.AllowUserToAddRows = false;
            this.dataGridViewContenutoSupporto.AllowUserToDeleteRows = false;
            this.dataGridViewContenutoSupporto.AllowUserToOrderColumns = true;
            this.dataGridViewContenutoSupporto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContenutoSupporto.Location = new System.Drawing.Point(143, 20);
            this.dataGridViewContenutoSupporto.Name = "dataGridViewContenutoSupporto";
            this.dataGridViewContenutoSupporto.ReadOnly = true;
            this.dataGridViewContenutoSupporto.Size = new System.Drawing.Size(350, 286);
            this.dataGridViewContenutoSupporto.TabIndex = 2;
            // 
            // buttonVisualizzaContenuto
            // 
            this.buttonVisualizzaContenuto.Location = new System.Drawing.Point(10, 21);
            this.buttonVisualizzaContenuto.Name = "buttonVisualizzaContenuto";
            this.buttonVisualizzaContenuto.Size = new System.Drawing.Size(126, 23);
            this.buttonVisualizzaContenuto.TabIndex = 1;
            this.buttonVisualizzaContenuto.Text = "Visualizza Contenuto ->";
            this.buttonVisualizzaContenuto.UseVisualStyleBackColor = true;
            this.buttonVisualizzaContenuto.Click += new System.EventHandler(this.buttonVisualizzaContenuto_Click);
            // 
            // elencoSupporti
            // 
            this.elencoSupporti.FormattingEnabled = true;
            this.elencoSupporti.Location = new System.Drawing.Point(9, 78);
            this.elencoSupporti.Name = "elencoSupporti";
            this.elencoSupporti.Size = new System.Drawing.Size(127, 229);
            this.elencoSupporti.TabIndex = 0;
            // 
            // viewRicerca
            // 
            this.viewRicerca.Controls.Add(this.groupBoxRisultatoRicerca);
            this.viewRicerca.Controls.Add(this.groupBoxParametriRicerca);
            this.viewRicerca.Location = new System.Drawing.Point(4, 22);
            this.viewRicerca.Name = "viewRicerca";
            this.viewRicerca.Padding = new System.Windows.Forms.Padding(3);
            this.viewRicerca.Size = new System.Drawing.Size(506, 354);
            this.viewRicerca.TabIndex = 1;
            this.viewRicerca.Text = "Ricerca File";
            this.viewRicerca.UseVisualStyleBackColor = true;
            // 
            // groupBoxRisultatoRicerca
            // 
            this.groupBoxRisultatoRicerca.Controls.Add(this.dataGridViewRisultatoRicerca);
            this.groupBoxRisultatoRicerca.Location = new System.Drawing.Point(7, 93);
            this.groupBoxRisultatoRicerca.Name = "groupBoxRisultatoRicerca";
            this.groupBoxRisultatoRicerca.Size = new System.Drawing.Size(493, 255);
            this.groupBoxRisultatoRicerca.TabIndex = 3;
            this.groupBoxRisultatoRicerca.TabStop = false;
            this.groupBoxRisultatoRicerca.Text = "RisultatoRicerca";
            // 
            // dataGridViewRisultatoRicerca
            // 
            this.dataGridViewRisultatoRicerca.AllowUserToAddRows = false;
            this.dataGridViewRisultatoRicerca.AllowUserToDeleteRows = false;
            this.dataGridViewRisultatoRicerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRisultatoRicerca.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewRisultatoRicerca.Name = "dataGridViewRisultatoRicerca";
            this.dataGridViewRisultatoRicerca.ReadOnly = true;
            this.dataGridViewRisultatoRicerca.Size = new System.Drawing.Size(475, 230);
            this.dataGridViewRisultatoRicerca.TabIndex = 4;
            // 
            // groupBoxParametriRicerca
            // 
            this.groupBoxParametriRicerca.Controls.Add(this.comboBoxDimensione);
            this.groupBoxParametriRicerca.Controls.Add(this.buttonAvviaRicerca);
            this.groupBoxParametriRicerca.Controls.Add(this.label3);
            this.groupBoxParametriRicerca.Controls.Add(this.textBox2);
            this.groupBoxParametriRicerca.Controls.Add(this.label2);
            this.groupBoxParametriRicerca.Controls.Add(this.label1);
            this.groupBoxParametriRicerca.Controls.Add(this.textBox1);
            this.groupBoxParametriRicerca.Location = new System.Drawing.Point(9, 6);
            this.groupBoxParametriRicerca.Name = "groupBoxParametriRicerca";
            this.groupBoxParametriRicerca.Size = new System.Drawing.Size(491, 80);
            this.groupBoxParametriRicerca.TabIndex = 2;
            this.groupBoxParametriRicerca.TabStop = false;
            this.groupBoxParametriRicerca.Text = "parametri di ricerca file";
            // 
            // comboBoxDimensione
            // 
            this.comboBoxDimensione.FormattingEnabled = true;
            this.comboBoxDimensione.Items.AddRange(new object[] {
            "0      KB - 500   KB",
            "501  KB - 2,5   MB",
            "2,51 MB - 25   MB",
            "25,1 MB - 250 MB",
            "251 MB - 2,5   GB",
            "2,51 GB - 25    GB",
            "oltre i 25 GB"});
            this.comboBoxDimensione.Location = new System.Drawing.Point(316, 16);
            this.comboBoxDimensione.Name = "comboBoxDimensione";
            this.comboBoxDimensione.Size = new System.Drawing.Size(155, 21);
            this.comboBoxDimensione.TabIndex = 5;
            this.comboBoxDimensione.Text = "intervallo dimensione file";
            // 
            // buttonAvviaRicerca
            // 
            this.buttonAvviaRicerca.Location = new System.Drawing.Point(248, 44);
            this.buttonAvviaRicerca.Name = "buttonAvviaRicerca";
            this.buttonAvviaRicerca.Size = new System.Drawing.Size(223, 23);
            this.buttonAvviaRicerca.TabIndex = 0;
            this.buttonAvviaRicerca.Text = "Cerca";
            this.buttonAvviaRicerca.UseVisualStyleBackColor = true;
            this.buttonAvviaRicerca.Click += new System.EventHandler(this.buttonAvviaRicerca_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "dimensione :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "inserisci estensione [jpg;doc,..]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "estensione:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "inserisci nome file";
            // 
            // viewAnagrafe
            // 
            this.viewAnagrafe.Controls.Add(this.groupBoxElencoPersone);
            this.viewAnagrafe.Controls.Add(this.groupBoxCancellazionePersone);
            this.viewAnagrafe.Controls.Add(this.groupBoxInserimentoPersone);
            this.viewAnagrafe.Location = new System.Drawing.Point(4, 22);
            this.viewAnagrafe.Name = "viewAnagrafe";
            this.viewAnagrafe.Size = new System.Drawing.Size(506, 354);
            this.viewAnagrafe.TabIndex = 3;
            this.viewAnagrafe.Text = "Gestione anagrafe";
            this.viewAnagrafe.UseVisualStyleBackColor = true;
            // 
            // groupBoxElencoPersone
            // 
            this.groupBoxElencoPersone.Controls.Add(this.dataGridViewElencoPersone);
            this.groupBoxElencoPersone.Location = new System.Drawing.Point(13, 176);
            this.groupBoxElencoPersone.Name = "groupBoxElencoPersone";
            this.groupBoxElencoPersone.Size = new System.Drawing.Size(483, 166);
            this.groupBoxElencoPersone.TabIndex = 2;
            this.groupBoxElencoPersone.TabStop = false;
            this.groupBoxElencoPersone.Text = "Elenco persone:";
            // 
            // dataGridViewElencoPersone
            // 
            this.dataGridViewElencoPersone.AllowUserToAddRows = false;
            this.dataGridViewElencoPersone.AllowUserToDeleteRows = false;
            this.dataGridViewElencoPersone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElencoPersone.Location = new System.Drawing.Point(10, 19);
            this.dataGridViewElencoPersone.Name = "dataGridViewElencoPersone";
            this.dataGridViewElencoPersone.Size = new System.Drawing.Size(467, 139);
            this.dataGridViewElencoPersone.TabIndex = 3;
            // 
            // groupBoxCancellazionePersone
            // 
            this.groupBoxCancellazionePersone.Controls.Add(this.comboBoxNickname);
            this.groupBoxCancellazionePersone.Controls.Add(this.buttonCancellaPersona);
            this.groupBoxCancellazionePersone.Location = new System.Drawing.Point(13, 117);
            this.groupBoxCancellazionePersone.Name = "groupBoxCancellazionePersone";
            this.groupBoxCancellazionePersone.Size = new System.Drawing.Size(483, 52);
            this.groupBoxCancellazionePersone.TabIndex = 1;
            this.groupBoxCancellazionePersone.TabStop = false;
            this.groupBoxCancellazionePersone.Text = "Cancellazione persona";
            // 
            // comboBoxNickname
            // 
            this.comboBoxNickname.FormattingEnabled = true;
            this.comboBoxNickname.Location = new System.Drawing.Point(10, 16);
            this.comboBoxNickname.Name = "comboBoxNickname";
            this.comboBoxNickname.Size = new System.Drawing.Size(216, 21);
            this.comboBoxNickname.TabIndex = 2;
            this.comboBoxNickname.Text = "Nickname persone esistenti";
            // 
            // buttonCancellaPersona
            // 
            this.buttonCancellaPersona.Location = new System.Drawing.Point(251, 16);
            this.buttonCancellaPersona.Name = "buttonCancellaPersona";
            this.buttonCancellaPersona.Size = new System.Drawing.Size(226, 23);
            this.buttonCancellaPersona.TabIndex = 1;
            this.buttonCancellaPersona.Text = "Cancella persona selezionata";
            this.buttonCancellaPersona.UseVisualStyleBackColor = true;
            this.buttonCancellaPersona.Click += new System.EventHandler(this.buttonCancellaPersona_Click);
            // 
            // groupBoxInserimentoPersone
            // 
            this.groupBoxInserimentoPersone.Controls.Add(this.textBoxTelefono);
            this.groupBoxInserimentoPersone.Controls.Add(this.textBoxEmail);
            this.groupBoxInserimentoPersone.Controls.Add(this.buttonInserisciModificaPersona);
            this.groupBoxInserimentoPersone.Controls.Add(this.label8);
            this.groupBoxInserimentoPersone.Controls.Add(this.label7);
            this.groupBoxInserimentoPersone.Controls.Add(this.textBoxNickname);
            this.groupBoxInserimentoPersone.Controls.Add(this.textBoxCognome);
            this.groupBoxInserimentoPersone.Controls.Add(this.textBoxNome);
            this.groupBoxInserimentoPersone.Controls.Add(this.label6);
            this.groupBoxInserimentoPersone.Controls.Add(this.label5);
            this.groupBoxInserimentoPersone.Controls.Add(this.label4);
            this.groupBoxInserimentoPersone.Location = new System.Drawing.Point(13, 4);
            this.groupBoxInserimentoPersone.Name = "groupBoxInserimentoPersone";
            this.groupBoxInserimentoPersone.Size = new System.Drawing.Size(483, 106);
            this.groupBoxInserimentoPersone.TabIndex = 0;
            this.groupBoxInserimentoPersone.TabStop = false;
            this.groupBoxInserimentoPersone.Text = "inserimento persona:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(302, 42);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(175, 20);
            this.textBoxTelefono.TabIndex = 10;
            this.textBoxTelefono.Text = "inserire telefono (opzionale)";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(302, 17);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(175, 20);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.Text = "inserire e-mail (opzionale)";
            // 
            // buttonInserisciModificaPersona
            // 
            this.buttonInserisciModificaPersona.Location = new System.Drawing.Point(251, 66);
            this.buttonInserisciModificaPersona.Name = "buttonInserisciModificaPersona";
            this.buttonInserisciModificaPersona.Size = new System.Drawing.Size(232, 23);
            this.buttonInserisciModificaPersona.TabIndex = 8;
            this.buttonInserisciModificaPersona.Text = "inserisci/modifica persona";
            this.buttonInserisciModificaPersona.UseVisualStyleBackColor = true;
            this.buttonInserisciModificaPersona.Click += new System.EventHandler(this.buttonInserisciModificaPersona_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "e-mail:";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(69, 68);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(157, 20);
            this.textBoxNickname.TabIndex = 5;
            this.textBoxNickname.Text = "nome univoco (obbligatorio)";
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Location = new System.Drawing.Point(69, 42);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(157, 20);
            this.textBoxCognome.TabIndex = 4;
            this.textBoxCognome.Text = "inserire cognome (opzionale)";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(69, 17);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(157, 20);
            this.textBoxNome.TabIndex = 3;
            this.textBoxNome.Text = "inserire nome (opzionale)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "nickname: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "cognome: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "nome:";
            // 
            // viewPrestiti
            // 
            this.viewPrestiti.Controls.Add(this.groupBox1);
            this.viewPrestiti.Controls.Add(this.groupBoxPrestitiAttivi);
            this.viewPrestiti.Controls.Add(this.groupBoxInserisciPrestito);
            this.viewPrestiti.Location = new System.Drawing.Point(4, 22);
            this.viewPrestiti.Name = "viewPrestiti";
            this.viewPrestiti.Size = new System.Drawing.Size(506, 354);
            this.viewPrestiti.TabIndex = 2;
            this.viewPrestiti.Text = "Presta Supporto";
            this.viewPrestiti.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRestituisci);
            this.groupBox1.Controls.Add(this.comboBoxElencoSupportiPrestati);
            this.groupBox1.Location = new System.Drawing.Point(13, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restituzione prestiti";
            // 
            // buttonRestituisci
            // 
            this.buttonRestituisci.Location = new System.Drawing.Point(299, 17);
            this.buttonRestituisci.Name = "buttonRestituisci";
            this.buttonRestituisci.Size = new System.Drawing.Size(169, 23);
            this.buttonRestituisci.TabIndex = 2;
            this.buttonRestituisci.Text = "Restituzione";
            this.buttonRestituisci.UseVisualStyleBackColor = true;
            this.buttonRestituisci.Click += new System.EventHandler(this.buttonRestituisci_Click);
            // 
            // comboBoxElencoSupportiPrestati
            // 
            this.comboBoxElencoSupportiPrestati.FormattingEnabled = true;
            this.comboBoxElencoSupportiPrestati.Location = new System.Drawing.Point(8, 19);
            this.comboBoxElencoSupportiPrestati.Name = "comboBoxElencoSupportiPrestati";
            this.comboBoxElencoSupportiPrestati.Size = new System.Drawing.Size(145, 21);
            this.comboBoxElencoSupportiPrestati.TabIndex = 1;
            this.comboBoxElencoSupportiPrestati.Text = "Id supporto";
            // 
            // groupBoxPrestitiAttivi
            // 
            this.groupBoxPrestitiAttivi.Controls.Add(this.dataGridViewElencoPrestiti);
            this.groupBoxPrestitiAttivi.Location = new System.Drawing.Point(12, 156);
            this.groupBoxPrestitiAttivi.Name = "groupBoxPrestitiAttivi";
            this.groupBoxPrestitiAttivi.Size = new System.Drawing.Size(484, 186);
            this.groupBoxPrestitiAttivi.TabIndex = 2;
            this.groupBoxPrestitiAttivi.TabStop = false;
            this.groupBoxPrestitiAttivi.Text = "prestiti attivi:";
            // 
            // dataGridViewElencoPrestiti
            // 
            this.dataGridViewElencoPrestiti.AllowUserToAddRows = false;
            this.dataGridViewElencoPrestiti.AllowUserToDeleteRows = false;
            this.dataGridViewElencoPrestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElencoPrestiti.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewElencoPrestiti.Name = "dataGridViewElencoPrestiti";
            this.dataGridViewElencoPrestiti.ReadOnly = true;
            this.dataGridViewElencoPrestiti.Size = new System.Drawing.Size(469, 150);
            this.dataGridViewElencoPrestiti.TabIndex = 1;
            // 
            // groupBoxInserisciPrestito
            // 
            this.groupBoxInserisciPrestito.Controls.Add(this.comboBoxIdSupporti);
            this.groupBoxInserisciPrestito.Controls.Add(this.comboBoxNicknamePrestiti);
            this.groupBoxInserisciPrestito.Controls.Add(this.textBoxNuovoNickname);
            this.groupBoxInserisciPrestito.Controls.Add(this.buttonPresta);
            this.groupBoxInserisciPrestito.Controls.Add(this.label10);
            this.groupBoxInserisciPrestito.Controls.Add(this.label9);
            this.groupBoxInserisciPrestito.Location = new System.Drawing.Point(12, 4);
            this.groupBoxInserisciPrestito.Name = "groupBoxInserisciPrestito";
            this.groupBoxInserisciPrestito.Size = new System.Drawing.Size(484, 79);
            this.groupBoxInserisciPrestito.TabIndex = 1;
            this.groupBoxInserisciPrestito.TabStop = false;
            this.groupBoxInserisciPrestito.Text = "inserimento nuovo prestito";
            // 
            // comboBoxIdSupporti
            // 
            this.comboBoxIdSupporti.FormattingEnabled = true;
            this.comboBoxIdSupporti.Location = new System.Drawing.Point(150, 41);
            this.comboBoxIdSupporti.Name = "comboBoxIdSupporti";
            this.comboBoxIdSupporti.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdSupporti.TabIndex = 7;
            this.comboBoxIdSupporti.Text = "Id supporti";
            // 
            // comboBoxNicknamePrestiti
            // 
            this.comboBoxNicknamePrestiti.FormattingEnabled = true;
            this.comboBoxNicknamePrestiti.Location = new System.Drawing.Point(150, 16);
            this.comboBoxNicknamePrestiti.Name = "comboBoxNicknamePrestiti";
            this.comboBoxNicknamePrestiti.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNicknamePrestiti.TabIndex = 6;
            this.comboBoxNicknamePrestiti.Text = "nickname esistenti";
            // 
            // textBoxNuovoNickname
            // 
            this.textBoxNuovoNickname.Location = new System.Drawing.Point(300, 15);
            this.textBoxNuovoNickname.Name = "textBoxNuovoNickname";
            this.textBoxNuovoNickname.Size = new System.Drawing.Size(178, 20);
            this.textBoxNuovoNickname.TabIndex = 5;
            this.textBoxNuovoNickname.Text = "nuovo nickname";
            // 
            // buttonPresta
            // 
            this.buttonPresta.Location = new System.Drawing.Point(300, 41);
            this.buttonPresta.Name = "buttonPresta";
            this.buttonPresta.Size = new System.Drawing.Size(178, 23);
            this.buttonPresta.TabIndex = 4;
            this.buttonPresta.Text = "Presta!";
            this.buttonPresta.UseVisualStyleBackColor = true;
            this.buttonPresta.Click += new System.EventHandler(this.buttonPresta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nickname persona: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Id supporto:";
            // 
            // comboBoxElencoSorgenti
            // 
            this.comboBoxElencoSorgenti.FormattingEnabled = true;
            this.comboBoxElencoSorgenti.Items.AddRange(new object[] {
            "F:\\",
            "C:\\\\Users\\\\cometspa\\\\Documents\\\\progettoIngSoft"});
            this.comboBoxElencoSorgenti.Location = new System.Drawing.Point(13, 13);
            this.comboBoxElencoSorgenti.Name = "comboBoxElencoSorgenti";
            this.comboBoxElencoSorgenti.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElencoSorgenti.TabIndex = 4;
            this.comboBoxElencoSorgenti.Text = "F:\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 376);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaLog";
            this.tabControl1.ResumeLayout(false);
            this.viewCatalogo.ResumeLayout(false);
            this.GroupBoxVisualizzaEliminaSupporto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContenutoSupporto)).EndInit();
            this.viewRicerca.ResumeLayout(false);
            this.groupBoxRisultatoRicerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRisultatoRicerca)).EndInit();
            this.groupBoxParametriRicerca.ResumeLayout(false);
            this.groupBoxParametriRicerca.PerformLayout();
            this.viewAnagrafe.ResumeLayout(false);
            this.groupBoxElencoPersone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElencoPersone)).EndInit();
            this.groupBoxCancellazionePersone.ResumeLayout(false);
            this.groupBoxInserimentoPersone.ResumeLayout(false);
            this.groupBoxInserimentoPersone.PerformLayout();
            this.viewPrestiti.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxPrestitiAttivi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElencoPrestiti)).EndInit();
            this.groupBoxInserisciPrestito.ResumeLayout(false);
            this.groupBoxInserisciPrestito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage viewCatalogo;
        private System.Windows.Forms.TabPage viewRicerca;
        private System.Windows.Forms.Button buttonAvviaRicerca;
        private System.Windows.Forms.TabPage viewPrestiti;
        private System.Windows.Forms.TabPage viewAnagrafe;
        private System.Windows.Forms.CheckedListBox elencoSupporti;
        private System.Windows.Forms.GroupBox GroupBoxVisualizzaEliminaSupporto;
        private System.Windows.Forms.Button buttonVisualizzaContenuto;
        private System.Windows.Forms.Button buttonAggiungiCatalogo;
        private System.Windows.Forms.Button buttonRimuoviDaCatalogo;
        private System.Windows.Forms.GroupBox groupBoxParametriRicerca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxDimensione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxInserimentoPersone;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.TextBox textBoxCognome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonInserisciModificaPersona;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxCancellazionePersone;
        private System.Windows.Forms.Button buttonCancellaPersona;
        private System.Windows.Forms.GroupBox groupBoxInserisciPrestito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPresta;
        private System.Windows.Forms.TextBox textBoxNuovoNickname;
        private System.Windows.Forms.GroupBox groupBoxPrestitiAttivi;
        private System.Windows.Forms.DataGridView dataGridViewElencoPrestiti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRestituisci;
        private System.Windows.Forms.ComboBox comboBoxElencoSupportiPrestati;
        private System.Windows.Forms.ComboBox comboBoxNicknamePrestiti;
        private System.Windows.Forms.ComboBox comboBoxNickname;
        private System.Windows.Forms.ComboBox comboBoxIdSupporti;
        private System.Windows.Forms.GroupBox groupBoxElencoPersone;
        private System.Windows.Forms.DataGridView dataGridViewElencoPersone;
        private System.Windows.Forms.DataGridView dataGridViewContenutoSupporto;
        private System.Windows.Forms.GroupBox groupBoxRisultatoRicerca;
        private System.Windows.Forms.DataGridView dataGridViewRisultatoRicerca;
        private System.Windows.Forms.ComboBox comboBoxElencoSorgenti;

    }
}

