# Details #

Prestito - Supporto: abbiamo scelto una associazione unidirezionale per semplificare la gestione dei riferimenti. Mantenere un'associazione bidirezionale richiede infatti particolare attenzione nelle operazioni di modifica che devono essere effettuate in modo atomico sui due riferimenti.
D'altro canto nel caso di ricerca della persona a cui � stato prestato il supporto � necessario scorrere l'intera lista di Prestiti ma si suppone che le dimensioni siano piccole e i tempi di ricerca siano bassi.

