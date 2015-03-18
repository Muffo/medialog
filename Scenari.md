# Sommario #

Scenari dei casi d'uso pi� significativi:
- Aggiunta supporto al catalogo
-
-
-

# Dettagli #

SCENARIO 1.0
Aggiunta supporto al catalogo:

Attori:
- Utente
-

Pre-condizioni:
- E' inserito un supporto all'interno del computer.

Flusso principale:
1) L'utente seleziona il percorso su cui effetuare la scansione.
2) L'utente comunica il tipo di supporto.
3) Il sistema calcola l'identificativo da assegnare al supporto.
4) Il sistema effettua la scansione del contenuto e lo memorizza.
5) Il sistema comunica l'idenficativo all'utente

Flusso alternativo:
1.a) Percorso non valido -> Il sistema ritorna al punto 1.
4.a) La scansione fallisce -> Il sistema avvisa l'utente. Si esce dallo scenario.

SCENARIO 2.0
Ricerca:

Attori:
- Utente
-

Pre-condizioni:
- Il Catalogo non deve essere vuoto.
-

Flusso principale:
1) Il sistema richiede all'utente di impostare una o pi� chiavi di ricerca [-> 3.0].
2) L'utente avvia la ricerca.
3) Il sistema effettua la ricerca e produce il risultato.
4) Il sistema visualizza il risultato.

Flusso alternativo:
3.a) Nel caso la ricerca abbia risultato vuoto, il sistema lo comunica e ritorna al punto 1.


SCENARIO 3.0
Impostazione chiave di ricerca:

Attori:
- Utente
-

Pre-condizioni:
-
-

Flusso principale:
1) L'utente seleziona le chiavi di ricerca di interesse.
2) L'utente immette i valori per i campi selezionati al punto 2.

Flusso alternativo:
2.a) L'utente lascia il campo vuoto nonostante lo abbia selezionato -> il sistema genera un messaggio d'errore adeguato e ritorna al punto 2.

SCENARIO 4.0
Inserimento di un nuovo prestito:

Attori:
- Utente
-

Pre-condizioni:
- Esiste un supporto in archivio
- Esiste una persona registrata nell'anagrafe

Flusso principale:
1) L'utente fornisce l'identificativo del supporto.
2) L'utente fornisce il nickname della persona ricevente il supporto.
3) Il sistema calcola la data odierna
4) Il sistema memorizza il prestito.

Flusso alternativo:
1.a) Il nome del supporto non � valido -> Il sistema richiede l'inserimento e torna al punto 1.
1.b) Il supporto � gia in prestito -> Il sistema lo comunica e si esce dallo scenario.
2.a) L'utente fornisce un nickname non esistente nell'anagrafe -> Il sistema richiede l'inserimento del nome e torna al punto 2.