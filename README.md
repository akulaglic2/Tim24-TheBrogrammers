# Tim-24-TheBrogrammers
![alt text](http://i63.tinypic.com/256uyap.png)


#  Projekat Kino

## Članovi Tima:

* Dino Ćosić

* Zerina Fazlagić

* Ammar Ćesko

## Opis teme
- Ova aplikacija je namijenjena svim osobama koje su ljubitelji filmova, te odlazaka u kino. U sklopu ovog projekta razvijamo aplikaciju koja ce omoguciti svim ljubiteljima kina, dobre zabave i najnovijih naslova da na najlaksi i najefikasniji nacin uzivaju u onome sto vole. Prvobitna ideja jeste da ovaj sistem pomogne svim korisnicima
nase aplikacije. Ostvarenje ove ideje se ogleda u tome sto aplikacija omogucava da se na jednostavan nacin vrsi pregled svega sto je bitno za posjetioce kina. Neke od tih stvari su rezervacija i kupovina karata, pregled filmova i rasporeda prikazivanje te druge stavke koje ce se posebno objasniti kasnije. Mozemo zakljuciti da sistem rjesava problem dosadasnjeg cekanja pri usluzivanju u kinu, dolaska do kina radi pregleda rasporeda prikazivanja filmova i slicnog. Uz nasu aplikaciju nece se nikada javljati takvi problemi.Postoji i druga strana aplikacije, koja je namijenjena uposlenicima.Ona im omogucava da uz logiranje pomocu svojih korisnickih podataka obavljaju svoj posao. Uz sve navedeno, slijedi da je aplikacija namijenjena kinima koja imaju nekoliko dvorana za prikazivanje u gradu,tj. za kina u vecim gradovima.

## Procesi
** Kupovina karata ** - Ovaj proces moguce je obaviti na dva nacina. Prvi nacin je dolazak korisnika prvi put u kino te kupovina ulaznice i placanje direktno novcem. Ovo je najjednostavniji nacin. Drugi nacin je da se karte kupe uz pomoc aplikacije. Prvo korisnik uz pomoc aplikacije, nakon sto se prijavio sa korisnickim imenom i lozinkom, unosi naslov filma, vrijeme prikazivanja i kolicinu karata. Nakon toga biraju se slobodna mjesta u kinu. Iduci korak jeste slanje zahtjeva putem aplikacije, a nakon toga dobija odgovor da li je moguce izvrsiti njegov zahtjev. Ukoliko jeste potrebno je da izvrsi uplatu uz pomoc kreditne kartice, a u suprotnom dobija poruku da nije moguce izvrsiti takvu rezervaciju.

** Prodaja karata ** - Druga strana aplikacije namijenjena je uposlenicima. Uz pomoc svojih korisnickih podataka, potrebno je da im se omoguci prijava. Nakon prijave pomocu određenog interfejsa omogucava im se da rade svoj posao, odnosno prodaju karte, hranu i pice.

** Odabir kino dvorane ** - Korisnik uz pomoc aplikacije na svom smartphone uređaju uz pomoc nekoliko filtera moze odabrati koja mu kino dvorana najvise odgovara.
On unosi naziv filma, te jos neke dodatne atribute. Kao rezultat aplikacija prikazuje najblizu dvoranu za njega, te put do iste.

** Registracija korisnika ** - Moguce je nekoliko razlicitih vrsta registracije. Moguce je izvrsiti registraciju uz uplatu, te na taj nacin postati jedan od "silver" ili "gold"
 clanova kina. Ove uloge naravno omogucavaju neke pogodnosti prilikom posjete.Također, moguca je prijava samo u vidu uloge "gost" koja ima najosnovnije podatke o kinu.

** Registracija uposlenog ** - Administrator aplikacije registruje novog uposlenog, te mu omogucava da se sa svojim korisnickim podacima prijavi pri dolasku na posao. To omogucava administratoru da prati njegov rad.

** Tehnicki pregled opreme ** - Administrator postavlja određeni vremenski period nakon kojeg je potrebno obaviti tehnicki pregled opreme, kako bi se omogucio nesmetan rad kina.(Jedan dio admin panela)

** Ocjena usluge ** - Ovaj proces omogucava korisnicima da napisu sve nedostatke, ideje ili sugestije pomocu nase aplikacije. Također, aplikacija omogucava ocjenjivanje putem ovog procesa.

## Funkcionalnosti

* Registracija novih uposlenih
* Registracija novih korisnika
* Dodavanje novih filmova
* Dodavanje termina tehnickog pregleda opreme, kontrola istih
* Prijava s nalogom gost, prikaz osnovih informacija o kinu
* Prikaz informacija o filmovima koji se prikazuju, najava premijera te pregled svih posebnih ponuda i paketa
* Kupovina ulaznica direktno, te uz pomoc aplikacije
* Kupovina pica i hrane
* Ponistavanje karata pri ulasku
* Kontrolisanje rada uposlenih
* Pregled statistickih podataka(posjecenost i ostali podaci)


## Akteri

* Uposlenici - osobe koje se prijavljuju sa vlastitim korisnickim podacima. Rade na kasi. Zaduzeni su za prodaju karata, hrane i pica.
* Korisnici - osobe koje koriste usluge aplikacije i samog kina. Mogu biti: "silver" i "gold" korisnici.
* Neregistrovani posjetioci - osobe koje koriste usluge aplikacije i kina, ali pri tome nisu registrovani
* Administrator - osoba koja nadgleda cijeli sistem. Zaduzena je za nesmetan rad aplikacije.
