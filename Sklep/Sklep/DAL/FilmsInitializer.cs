using Sklep.Models;
using Sklep.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Sklep.DAL
{
    internal class FilmsInitializer : /*DropCreateDatabaseAlways<FilmsContext>*/MigrateDatabaseToLatestVersion<FilmsContext, Configuration>/*DropCreateDatabaseIfModelChanges<FilmsContext>*/
    {
        public static void SeedFilms(FilmsContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ CategoryId = 1, Name = "Horror", Desc = "Strach się bać..." },
                new Category{ CategoryId = 2, Name = "Komedia", Desc = "Śmiechu warte."},
                new Category{ CategoryId = 3, Name = "Dokumnetalny", Desc = "Historia prawdziwa."},
                new Category{ CategoryId = 4, Name = "Thriller", Desc = "Aż ciarki przechodzą..."},
                new Category{ CategoryId = 5, Name = "Sensacyjny", Desc = "Wartka akcja."},
                new Category{ CategoryId = 6, Name = "Historyczny", Desc = "Historia lubi się powtarzać..."}
            };

            foreach (var category in categories)
            {
                context.Categories.AddOrUpdate(category);
            }

            context.SaveChanges();

            var filmy = new List<Film>()
            {
                new Film()
                {
                    FilmId = 1,
                    CategoryId = 1,
                    Title = "Teksańska Masakra Piłą Mechaniczną",
                    Director = "Marcus Nispel",
                    Desc = "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.",
                    Price = 10,
                    ImageName = "Teksanska.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 2,
                    CategoryId = 3,
                    Title = "Numer 23",
                    Director = "Joel Schumacher",
                    Desc = "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.",
                    Price = 14,
                    ImageName = "Numer23.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 3,
                    CategoryId = 3,
                    Title = "Sekretne Okno",
                    Director = "David Koepp",
                    Desc = "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.",
                    Price = 12,
                    ImageName = "SekretneOkno.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 4,
                    CategoryId = 5,
                    Title = "Władca Pierścieni: Drużyna Pierścienia",
                    Director = "Peter Jackson",
                    Desc = "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.",
                    Price = 20,
                    ImageName = "DruzynaPierscienia.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 5,
                    CategoryId = 4,
                    Title = "Red",
                    Director = "Robert Schwentke",
                    Desc = "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.",
                    Price = 11,
                    ImageName = "Red.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 6,
                    CategoryId = 2,
                    Title = "Tylko nie mów nikomu",
                    Director = "Tomasz Sekielski",
                    Desc = "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.",
                    Price = 0,
                    ImageName = "TylkoNieMow.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 7,
                    CategoryId = 5,
                    Title = "Iluzjonista",
                    Director = "Neil Burger",
                    Desc = "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.",
                    Price = 13,
                    ImageName = "Iluzjonista.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 8,
                    CategoryId = 3,
                    Title = "Cube",
                    Director = "Vincenzo Natali",
                    Desc = "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.",
                    Price = 15,
                    ImageName = "Cube.jpg",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 9,
                    CategoryId = 1,
                    Title = "Hellraiser: Wysłannik Piekieł",
                    Director = "Clive Barker",
                    Desc = "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.",
                    Price = 16,
                    ImageName = "Hellraiser.JPG",
                    AddDate = DateTime.Now
                },
                new Film()
                {
                    FilmId = 10,
                    CategoryId = 3,
                    Title = "Milczenie Owiec",
                    Director = "Jonathan Demme",
                    Desc = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.",
                    Price = 17,
                    ImageName = "MilczenieOwiec.jpg",
                    AddDate = DateTime.Now
                }
            };

            foreach (var film in filmy)
            {
                context.Films.AddOrUpdate(film);
            }

            context.SaveChanges();
        }
    }
}