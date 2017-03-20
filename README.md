#Tim16-Trijak

Smart Greenhouse

##Članovi tima:


1. Dženana Puščul

2. Emina Modrić

3. Neira Pulo



##Opis teme:

U cilju poboljšanja organizacije rada u stakleniku, odlučili smo kreirati aplikaciju Smart Greenhouse. Aplikacija će biti namijenjena kako uzgrajivačima sadnica tako i kupcima istih.
Uz pomoć senzora vlažnosti, temperature, osvijetljenosti i nivoa tečnosti, zemljoradnik jednostavno moći pratiti uslove u stakleniku, te će na osnovu istih imati uvid koje sadnice mogu uspjeti u datim uslovima koje dobiva kao informaciju sa senzora, također zemljoradnik će moći voditi evidenciju o sadnicama koje postoje u stakleniku.
S druge strane kupac će moći birati i naručivati sadnice koje će dobiti posredstvom dostavljača.

##Procesi:

Korisnik aplikacije se treba registrovati na sistem unoseći podatke o sebi:
•	Ime 
•	Prezime
•	Password
Te iz liste bira svoju ulogu:
o	Zemljoradnik
o	Kupac
o	Dostavljač

Sistem prikuplja informacije o stanju u stakleniku sa senzora.  Korisnik registrovan  kao zemljoradnik  ima pristup tim  informacijama, te ukoliko ga aplikacija upozori na nedostatak vlažnosti zemlje, može pokrenuti sistem za navodnjavanje. Također on  ima i mogućnost mijenjanja količine sadnica koje su na raspolaganju za prodaju. Korisnik registrovan kao kupac, bira sadnice pomoću aplikacije te ima opciju plasiranja narudžbe online ili pak na licu mjesta. Ukoliko je kupac plasirao online narudžbu aplikacija obavještava dostavljača o novoj pošiljci. 

##Funkcionalnosti:

•	Preuzimanje informacija o vlažnosti i temperaturi zraka sa DHT-11 senzora
•	Preuzimanje informacija o vlažnosti zemlje 
•	Preuzimanje informacija o osvijetljenosti unutar staklenika sa fotodiode
•	Preuzimanje informacija o nivou vode u rezervoaru sa Funduino senzora
•	Mijenjanje količine dostupnih sadnica
•	Biranje sadnica pomoću aplikacije
•	Plasiranje narudžbe online il na licu mjesta
•	Obaviještavanje zemljoradnika i dostavljača o novoj pošiljci
•	Pokretanje sistema za navodnjavanje

##Akteri

Zemljoradnik – ima mogućnost pristupa potrebnim informacijama  koje sistem prima sa senzora, mijenjanje količine sadnica te pokretanje sistema za navodnjavanje
Kupac – ima pristup asortimanu sadnica koje su dostupne u stakleniku te iste može naručiti
DHT 11 senzor – prikuplja informacije o vlažnosti i temperaturi zraka
Senzor – prikuplja informacije o vlažnosti zemlje
Fotodioda – prikuplja informacije o osvjetljenosti unutar staklenika
Funduino senzor – prikuplja informacije o nivou vode u rezervoaru
Vanjski sistem za navodnjavanje – pokreće sistem za navodnjavanje
Dostavlječ – prima informacije o narudžbi koju treba dostaviti




