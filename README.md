# **Smart Greenhouse**

Članovi tima:


1. Dženana Puščul

2. Emina Modrić

3. Neira Pulo



## **Opis teme:**

U cilju poboljšanja organizacije rada u stakleniku, odlučili smo kreirati aplikaciju Smart Greenhouse. Aplikacija će biti namijenjena uzgrajivačima sadnica odnosno zaposlenicima staklenika.
Uz pomoć senzora vlažnosti, temperature, osvjetljenosti i nivoa tečnosti, zemljoradnik jednostavno će moći pratiti uslove u stakleniku, te će na osnovu istih imati uvid koje sadnice mogu uspjeti u datim uslovima koje dobiva kao informaciju sa senzora, također zemljoradnik će moći voditi evidenciju o sadnicama koje postoje u stakleniku. Dok će direktor kao poslodavac uz pomoć aplikacije jednostavno putem izvještaja imati uvid o poslovanju firme.


### **Procesi:**

• Registracija i prijava korisnika: Račun se dodjeljuje direktoru pri preuzimanju aplikacije. Kreiranje računa zemljoradnicima vrši direktor putem aplikacije. Korisnik aplikacije (direktor ili zemljoradnik) koji posjeduje račun, treba se prijaviti na sistem unoseći podatke o sebi:

  o	 Ime

  o      Prezime

  o      Lozinka

Ukoliko je sistem prepoznao uneseno ime i prezime kao podatke o direktoru, otvara se meni aplikacije za direktora, dok se u suprotnom otvara meni za zemljoradnika.

• Preuzimanje informacija sa senzora: Sistem prikuplja informacije o stanju u stakleniku (vlažnost zemlje, nivo vode u rezervoaru, osvijetljenost, temperatura i vlažnost zraka) pomoću senzora. Korisnik registrovan  kao zemljoradnik  ima pristup tim  informacijama, te ukoliko ga aplikacija upozori na nedostatak vlažnosti zemlje, može pokrenuti sistem za navodnjavanje. 

• Kreiranje narudžbe: Kupac koji posjeti staklenik prijavljuje se zemljoradniku, koji prima od kupca narudžbu i unosi je u sistem. Naručivanje se sastoji od pregleda i izbora dostupnih sadnica, te obračuna i naplačivanja na licu mjesta.Ukoliko se utvrdi da narudžba sadrži više od 50 sadnica, uračunaje se dodatni rabat. Nakon što zemljoradnik unese tražene sadnice i kreira narudžbu, ona je zaključena. 

• Mijenjanje broja i dodavanje asortimana sadnica: Zemljoradnik ima mogućnost mijenjanja količine i asortimana sadnica koje su na raspolaganju za prodaju. Ukoliko vrši dodavanje asortimana unosi naziv nove sadnice, njenu količinu te cijenu.

 
• Izvještaj: Korisnik aplikacije koji je prijavljen kao Direktor ima pristup izvještajima o sadnicama i poslovanju. Korisnik bira koji izvještaj želi: dnevni, sedmični ili mjesečni i unosi datum te u skladu sa izborom dobiva obračun sadnica koje su prodate te onih koje su preostale u stakleniku. Također, na osnovu dnevne, sedmične, odnosno, mjesečne prodaje direktor dobiva obračun odgovarajućeg dohotka kojeg je firma ostvarila.

### **Funkcionalnosti:**

•	Prijava na sistem

•	Kreiranje korisničkog računa 

•	Preuzimanje informacija o vlažnosti i temperaturi zraka sa DHT-11 senzora

•	Preuzimanje informacija o vlažnosti zemlje
 
•	Preuzimanje informacija o osvjetljenosti unutar staklenika sa fotodiode

•	Preuzimanje informacija o nivou vode u rezervoaru sa Funduino senzora

•	Mijenjanje količine dostupnih sadnica

•	Dodavanje asortimana sadnica

•	Kreiranje izvještaja o prodaji sadnica

•	Kreiranje narudžbe

•	Pokretanje sistema za navodnjavanje


### **Akteri:**

Direktor - registruje uposlenika-zemljoradnika te ima pristup izvještajima o poslovanju 

Zemljoradnik – prijavljeje se na sistem te ima mogućnost pristupa potrebnim informacijama  koje sistem prima sa senzora, mijenjanje količine i asortimana sadnica te pokretanje sistema za navodnjavanje

DHT 11 senzor – prikuplja informacije o vlažnosti i temperaturi zraka

Senzor AWR TW – prikuplja informacije o vlažnosti zemlje

Fotodioda – prikuplja informacije o osvjetljenosti unutar staklenika

Funduino senzor – prikuplja informacije o nivou vode u rezervoaru

Vanjski sistem za navodnjavanje – pokreće sistem za navodnjavanje





