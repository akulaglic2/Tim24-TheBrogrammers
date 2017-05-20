using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatKino.Models
{
   public  class DefaultPodaci
    {
        public static void Initialize(KinoDbContext context)
        {
            Proizvod p = new Proizvod(1, "kola", 3, "mala");
            Proizvod p2 = new Proizvod(2, "kokice", 3, "male");
            if (!context.filmovi.Any())
            {
                context.filmovi.AddRange(
                new Film()
                {
                    naziv = "Iron man 3",
                    zanr = "Sci-Fi",
                    duzinaTrajanja = 180,
                    reziser = "Jon Favreau",
                    opisFilma ="neki opis",
                    
                }
                );
                context.SaveChanges();
            }

            if(!context.proizvodi.Any())
            {
                context.proizvodi.AddRange(
                new Proizvod()
                {
                    naziv = "kokice",
                    cijena = 3,
                    vrsta="male",
                }
                );
                context.SaveChanges();
            }
            if (!context.proizvodi.Any())
            {
                context.proizvodi.AddRange(
                new Proizvod()
                {
                    naziv = "kola",
                    cijena = 3,
                    vrsta = "mala",
                }
                );
                context.SaveChanges();
            }

            if (!context.projekcije.Any())
            {
                context.projekcije.AddRange(
                new Projekcija()
                {
                    vrijemePrikazivanja = new DateTime(22, 05, 2017),
                    idKinoDvorane = 1,
                }
                );
                context.SaveChanges();
            }
            if (!context.kinoDvorane.Any())
            {
                context.kinoDvorane.AddRange(
                new KinoDvorana()
                {
                    adresa="Zmajabb",
                    brojMjesta=50,
                }
                );
                context.SaveChanges();
            }
            if (!context.uposlenici.Any())
            {
                context.uposlenici.AddRange(
                new Uposlenik()
                {
                    ime = "Zerina",
                    prezime = "Fazlagic",
                    adresa = "Aleja Lipa ",
                    email = "neki tako",
                    username="zfazlagic1",
                    password="neki",
                    datumRodjenja=new DateTime(22,04,1996),
                    maticniBroj=2204996,
                 }
                );
                context.SaveChanges();
            }

            if (!context.korisnici.Any())
            {
                context.korisnici.AddRange(
                new Korisnik()
                {

                    ime = "Dino",
                    prezime = "Cosic",
                    adresa = "Envera Sehovica ",
                    email = "neki tako",
                    username = "dcosic1",
                    password = "bla",
                    datumRodjenja = new DateTime(08, 12, 1995),
                    brojKreditneKartice=12345678,
                    expDate=new DateTime(13,09,2020),
                    imeVlasnikaKartice="Dino",
                    prezimeVlasnikaKartice="Cosic",
                }
                );
                context.SaveChanges();
            }
            if (!context.posebnePonude.Any())
            {
                context.posebnePonude.AddRange(
                new PosebnePonude()
                {
                  naziv="Mini combo",
                   cijena=10,
                   velicina="veliki",
                }
                );
                context.SaveChanges();
            }
            if (!context.posebnePonude.Any())
            {
                context.posebnePonude.AddRange(
                new PosebnePonude()
                {
                    naziv = "Mini combo",
                    cijena = 10,
                    velicina = "veliki",
                }
                );
                context.SaveChanges();
            }

            if (!context.karte.Any())
            {
                context.karte.AddRange(
                new Karta()
                {
                    cijenaKarte = 4,
                    idProjekcije = 1,
                }
                );
                context.SaveChanges();
            }
        }
    }
}
