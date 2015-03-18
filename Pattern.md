# Introduction #

Descrizione pattern utilizzati


# Composite #

"Ogni supporto ha un filesystem strutturato in direttori e file: un direttorio pu� contenere altri direttori e/o files."

Il contenuto dei ogni supporto � quindi strutturato come un albero n-ario che permette di rappresentare il filesystem come una gerarchia di oggetti contenitori/contenuti.

// immagine di una gerarchia di filesystem

Si è quindi deciso di utilizzare il pattern COMPOSITE in modo tale da trattare in modo uniforme oggetti singoli e oggetti composti.

// immagine del pattern

L'elemento Component � il Nodo, la classe astratta che contiene i campi presenti in tutti gli elementi della gerarchia (nel nostro caso il "nome").

L'elemento Leaf � il File che infatti non ha figli nella gerarchia e contiene i campi che lo descrivono ("estensione" e "dimensione")

L'elemento Composite � il Direttorio che descrive gli elementi che possono avere figli. I figli possono essere altri Direttori o File.

Il Client � il Supporto che contiene una lista di Nodo.

La realizzazione della associazioni uno a molti avviene tramite una classe contenitore. Inoltre in Nodo � presente un riferimento opzionale al Direttorio che lo contiene per velocizzare la navigazione all'interno del filesystem; tale riferimento deve essere coerente con la lista di Nodi contenuti nel Direttorio.

# Strategy #

"Il sistema al termine della scansione fornisce all'utente un identificativo generato sulla base del tipo di supporto."

Per generare l'identificativo di un supporto � necessario utilizzare una serie di algoritmi differenti. Ciascuno di questi restituir� una stringa che l'utente pu� scrivere sul supporto per riconoscerlo.

Si utilizza quindi un pattern Strategy che consente di definire un insieme di algoritmi tra loro correlati rendendoli intercambiabili. In questo modo sar� possibile inserire facilmente anche nuovi algoritmi di generazione per identificatori di supporti di nuova generazione.


"La ricerca pu� essere effettuata in base al nome del file, all'estensione oppure alla dimensione."

L'algoritmo di ricerca non � quindi fisso, ma cambia in base al vincolo inserito dall'utente.

Si utilizza quindi un pattern Strategy che consente di definire un insieme di algoritmi tra loro correlati rendendoli intercambiabili. In questo modo sar� possibile inserire facilmente anche nuovi algoritmi di ricerca in futuro.

# Factory #

La classe RicercaFactory si occupa di creare l'istanza corretta dell'oggetto che implementa IRicerca. La factory conosce le classi che deve creare e reperisce da un dizionario le informazioni di associazione tra nome e classe concreta da istanziare: in questo modo si evita di cambiare il metodo getRicerca() quando si vogliono aggiungere ulteriori criteri di ricerca.