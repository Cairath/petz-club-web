using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models.Seeds;

public static class DogBreedsSeed
{
    private static readonly List<BreedEntity> Breeds = new()
    {
        new()
        {
            Name = "Australian Kelpie",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Belgian Shepherd Dog (Groenendael)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Belgian Shepherd Dog (Laekenois)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Belgian Shepherd Dog (Malinois)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Belgian Shepherd Dog (Tervueren)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Schipperke",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Croatian Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Briard",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Pyrenean Sheepdog Longhaired",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Picardy Sheepdog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Pyrenean Sheepdog Smooth Faced",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "German Shepherd Dog (Double Coat)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "German Shepherd Dog (Long and Harsh Outer Coat)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Bearded Collie",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Border Collie",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Collie (Rough)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Collie (Smooth)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Old English Sheepdog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Shetland Sheepdog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Komondor",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Kuvasz",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Mudi",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Puli (pearl-white)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Puli (other colors)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Pumi",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Bergamasco Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Maremma and the Abruzzes Sheepdog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Polish Lowland Sheepdog",
            Group = 1,
            Section = 1
        },
        new() {
            Name = "Tatra Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Portuguese Sheepdog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Romanian Carpathian Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Romanian Mioritic Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "South Russian Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Czechoslovakian Wolfdog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Slovakian Chuvach",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Catalan Sheepdog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Majorca Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "White Swiss Shepherd Dog",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Dutch Schapendoes",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Dutch Shepherd Dog (Short-haired)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Dutch Shepherd Dog (Long Haired)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Dutch Shepherd Dog (Rough haired)",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Saarloos Wolfhond",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Australian Shepherd",
            Group = 1,
            Section = 1
        },
        new()
        {
            Name = "Australian Cattle Dog",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Bouvier Des Ardennes",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Bouvier Des Flandres",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Welsh Corgi (Cardigan)",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Welsh Corgi (Pembroke)",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Australian Stumpy Tailed Cattle Dog",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Lancashire Heeler",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Miniature American Shepherd",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Catahoula Leopard Dog",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Bohemian Shepherd Dog",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "English Shepherd Dog",
            Group = 1,
            Section = 2
        },
        new()
        {
            Name = "Austrian Pinscher",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Danish-Swedish Farmdog",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Affenpinscher",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Dobermann",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "German Pinscher",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Miniature Pinscher",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Giant Schnauzer (Pepper and Salt)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Giant Schnauzer (Black and white)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Giant Schnauzer (Black and silver)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Miniature Schnauzer (Pepper and salt)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Miniature Schnauzer (Black)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Miniature Schnauzer (Black and silver)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Miniature Schnauzer (White)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Schnauzer (Pepper and salt)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Schnauzer (Black)",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Dutch Smoushond",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Russian Black Terrier",
            Group = 2,
            Section = 1
        },
        new()
        {
            Name = "Dogo Argentino",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Fila Brasileiro",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Shar Pei",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Broholmer",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Dogue de Bordeaux",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Boxer",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Great Dane (Fawn and Brindle)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Great Dane (Black and Harlequin)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Great Dane (Blue)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Rottweiler",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Bulldog (English)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Bulldog (American)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Bullmastiff",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Mastiff",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Italian Cane Corso",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Neapolitan Mastiff",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Tosa",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Saint Miguel Cattle Dog (Azores)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Majorca Mastiff",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Presa Canario",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Cimarrón Uruguayo",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Bosnian and Herzegovinian - Croatian Shepherd Dog",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Newfoundland",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Pyrenean Mountain Dog",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Hovawart",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Leonberger",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Landseer (European Continental Type)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Atlas Mountain Dog (Aidi)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Yugoslavian Shepherd Dog - Sharplanina",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Castro Laboreiro Dog",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Estrela Mountain Dog (Short haired)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Estrela Mountain Dog (Long haired)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Rafeiro of Alentejo",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Romanian Bucovina Shepherd",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Caucasian Shepherd Dog",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Central Asia Shepherd Dog",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Karst Shepherd Dog",
            Group = 2,
            Section = 2
        },
        new() {
            Name = "Pyrenean Mastiff",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Spanish Mastiff",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "St. Bernard (Short haired)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "St. Bernard (Long haired)",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Tibetan Mastiff",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Kangal Shepherd Dog",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Anatolian Shepherd Dog",
            Group = 2,
            Section = 2
        },
        new()
        {
            Name = "Appenzell Cattle Dog",
            Group = 2,
            Section = 3
        },
        new()
        {
            Name = "Bernese Mountain Dog",
            Group = 2,
            Section = 3
        },
        new()
        {
            Name = "Entlebuch Cattle Dog",
            Group = 2,
            Section = 3
        },
        new()
        {
            Name = "Great Swiss Mountain Dog",
            Group = 2,
            Section = 3
        },
        new()
        {
            Name = "Continental Bulldog",
            Group = 2,
            Section = 3
        },
        new()
        {
            Name = "Transmontano Mastiff",
            Group = 2,
            Section = 3
        },
        new()
        {
            Name = "Brazilian Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "German Hunting Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Airedale Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Bedlington Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Border Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Fox Terrier (Smooth)",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Fox Terrier (Wire)",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Lakeland Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Manchester Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Parson Russell Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Welsh Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Irish Glen of Imaal Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Irish Soft Coated Wheaten Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Irish Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Kerry Blue Terrier",
            Group = 3,
            Section = 1
        },
        new()
        {
            Name = "Australian Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Cesky Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Cairn Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Dandie Dinmont Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Jack Russell Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Patterdale Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Rat Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Teddy Roosevelt Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Norfolk Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Norwich Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Scottish Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Sealyham Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Skye Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "West Highland White Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Japanese Terrier",
            Group = 3,
            Section = 2
        },
        new()
        {
            Name = "Bull Terrier",
            Group = 3,
            Section = 3
        },
        new()
        {
            Name = "Miniature Bull Terrier",
            Group = 3,
            Section = 3
        },
        new()
        {
            Name = "Staffordshire Bull Terrier",
            Group = 3,
            Section = 3
        },
        new()
        {
            Name = "American Staffordshire Terrier",
            Group = 3,
            Section = 3
        },
        new()
        {
            Name = "Australian Silky Terrier",
            Group = 3,
            Section = 4
        },
        new()
        {
            Name = "Yorkshire Terrier",
            Group = 3,
            Section = 4
        },
        new()
        {
            Name = "English Toy Terrier (Black and tan)",
            Group = 3,
            Section = 4
        },
        new()
        {
            Name = "Valencian Terrier",
            Group = 3,
            Section = 4
        },
        new()
        {
            Name = "Standard Dachshund (Long haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Standard Dachshund (Smooth haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Standard Dachshund (Wire haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Miniature Dachshund (Long haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Miniature Dachshund (Smooth haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Miniature Dachshund (Wire haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Rabbit Dachshund (Long haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Rabbit Dachshund (Smooth haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Rabbit Dachshund (Wire haired)",
            Group = 4,
            Section = 1
        },
        new()
        {
            Name = "Canadian Eskimo Dog",
            Group = 5,
            Section = 1
        },
        new()
        {
            Name = "Greenland Dog",
            Group = 5,
            Section = 1
        },
        new()
        {
            Name = "Samoyed",
            Group = 5,
            Section = 1
        },
        new()
        {
            Name = "Alaskan Malamute",
            Group = 5,
            Section = 1
        },
        new()
        {
            Name = "Siberian Husky",
            Group = 5,
            Section = 1
        },
        new()
        {
            Name = "Finnish Spitz",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Karelian Bear Dog",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Norwegian Elkhound (Black)",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Norwegian Elkhound (Grey)",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Norwegian Lundehund",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "East Siberian Laika",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Russian-European Laika",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "West Siberian Laika",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Jämthund",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Norrbottenspitz",
            Group = 5,
            Section = 2
        },
        new()
        {
            Name = "Finnish Lapponian Dog",
            Group = 5,
            Section = 3
        },
        new()
        {
            Name = "Lapponian Herder",
            Group = 5,
            Section = 3
        },
        new()
        {
            Name = "Icelandic Sheepdog",
            Group = 5,
            Section = 3
        },
        new()
        {
            Name = "Norwegian Buhund",
            Group = 5,
            Section = 3
        },
        new()
        {
            Name = "Swedish Lapphund",
            Group = 5,
            Section = 3
        },
        new()
        {
            Name = "Swedish Vallhund",
            Group = 5,
            Section = 3
        },
        new()
        {
            Name = "American Eskimo Dog",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Keeshond (Wolspitz)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Giant Spitz (White)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Giant Spitz (Brown and black)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Medium size Spitz (White)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Medium size Spitz (Other colours)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Medium size Spitz (Brown and black)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Miniature Spitz (Brown and black)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Miniature Spitz (White)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Miniature Spitz (Other colours)",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Pomeranian",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Italian Volpino",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Alaskan Klee Kai",
            Group = 5,
            Section = 4
        },
        new()
        {
            Name = "Chow Chow",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Eurasian",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Akita",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "American Akita",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Hokkaido",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Japanese Spitz",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Kai",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Kishu",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Shiba",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Shikoku",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Korea Jindo Dog",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Thai Bangkaew Dog",
            Group = 5,
            Section = 5
        },
        new()
        {
            Name = "Basenji",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Canaan Dog",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Pharoah Hound",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Xoloitzcuintle (Miniature)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Xoloitzcuintle (Intermediate)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Xoloitzcuintle (Standard)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Peruvian Hairless Dog (Large)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Peruvian Hairless Dog (Medium)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Peruvian Hairless Dog (Miniature)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "American Hairless Terrier (Hairless)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "American Hairless Terrier (Coated)",
            Group = 5,
            Section = 6
        },
        new()
        {
            Name = "Cirneco Dell'Etna",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Portuguese Podengo Small(Long and wire haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Portuguese Podengo Small(Smooth and short haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Portuguese Podengo Medium(Long and wire haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Portuguese Podengo Medium(Smooth and short haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Portuguese Podengo Large(Long and wire haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Portuguese Podengo Large(Smooth and short haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Canarian Warren Hound",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Ibizan Podenco (Smooth haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Ibizan Podenco (Rough haired)",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Taiwan Dog",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Thai Ridgeback Dog",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Yakutian Laika",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Kintamani-Bali Dog",
            Group = 5,
            Section = 7
        },
        new()
        {
            Name = "Bloodhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Brazilian Tracker",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Billy",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "French Tricolour Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "French White and Black Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "French White and Orange Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Gascon Saintongeois (Great and small)",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Grand Griffon Vendeen",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Great Anglo-French Tricolour Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Great Anglo-French White and Orange Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Great Anglo-French White and Black Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Great Gascony Blue",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Poitevin",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "English Foxhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Otterhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Polish Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "American Foxhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Black and Tan Coonhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Bluetick Coonhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Redbone Coonhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Treeing Walker Coonhound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Plott Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Austrian Black and Tan Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Coarse Haired Styrian Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Tyrolean Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Bosnian Broken Haired Hound - Barak",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Istrian Short Haired Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Istrian Wire Haired Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Posavatz Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Finnish Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Ariegeois",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Artois Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Beagle Harrier",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Blue Gascony Griffon",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Briquet Griffon Vendeen",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Fawn Brittany Griffon",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Griffon Nivernais",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Medium sized Anglo-French Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Porcelaine",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Small Blue Gascony",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Harrier",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Hellenic Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Hungarian Hound - Transylvanian Scent Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Italian Rough Haired Segugio",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Italian Short Haired Segugio",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Montenegrin Mountain Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Halden Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Hygen Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Norwegian Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Polish Hunting Dog",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Serbian Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Serbian Tricolour Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Slovakian Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Spanish Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Hamiltonstövare",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Schillerstövare",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Smålandsstövare",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Dunkerstövare",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Bernese Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Jura Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Lucerne Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Schwyz Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Basset Fauve de Bretagne",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Blue Gascony Basset",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Grand Basset Griffon Vendeen",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Norman Artesien Basset",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Petit Basset Griffon Vendeen",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "German Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Westphalian Dachsbracke",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Basset Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Beagle",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Drever",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Small Swiss Hound",
            Group = 6,
            Section = 1
        },
        new()
        {
            Name = "Alpine Dachsbracke",
            Group = 6,
            Section = 2
        },
        new()
        {
            Name = "Bavarian Mountain Scent Hound",
            Group = 6,
            Section = 2
        },
        new()
        {
            Name = "Hanoverian Scent Hound",
            Group = 6,
            Section = 2
        },
        new()
        {
            Name = "Dalmatian",
            Group = 6,
            Section = 3
        },
        new()
        {
            Name = "Rhodesian Ridgeback",
            Group = 6,
            Section = 3
        },
        new()
        {
            Name = "Estonian Hound",
            Group = 6,
            Section = 3
        },
        new()
        {
            Name = "Segugio Maremmano",
            Group = 6,
            Section = 3
        },
        new()
        {
            Name = "PFM Mutt",
            Group = 6,
            Section = 3
        },
        new()
        {
            Name = "Old Danish Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Ariege Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Auvergne Pointer",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Bourbonnais Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "French Pointing Dog - Gascogne Type",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "French Pointing Dog - Pyrenean Type",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Saint Germain Pointer",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Deutsch Stichelhaar",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "German Short Haired Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "German Wire Haired Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "German Long Haired Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Pudelpointer",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Weimaraner (Short haired)",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Weimaraner (Long haired)",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Hungarian Short Haired Pointer (Vizsla)",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Hungarian Wire Haired Pointer (Vizsla)",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Italian Pointing Dog (Bracco Italiano)",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Portugeuse Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Slovakian Wire Haired Pointer",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Burgos Pointing Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Blue Picardy Spaniel",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Brittany Spaniel",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "French Spaniel",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Picardy Spaniel",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Pont-Audemer Spaniel",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Deutsch Langhaar",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Kleiner Münsterländer",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Large Munsterlander",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Drentsche Partridge Dog",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Stabijhoun",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Bohemian Wire Haired Griffon",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Wire Haired Pointing Griffon Korthals",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "Italian Spinone",
            Group = 7,
            Section = 1
        },
        new()
        {
            Name = "English Pointer",
            Group = 7,
            Section = 2
        },
        new()
        {
            Name = "English Setter",
            Group = 7,
            Section = 2
        },
        new()
        {
            Name = "Gordon Setter",
            Group = 7,
            Section = 2
        },
        new()
        {
            Name = "Irish Red and White Setter",
            Group = 7,
            Section = 2
        },
        new()
        {
            Name = "Irish Red Setter",
            Group = 7,
            Section = 2
        },
        new()
        {
            Name = "Nova Scotia Duck Tolling Retriever",
            Group = 8,
            Section = 1
        },
        new()
        {
            Name = "Curly Coated Retriever",
            Group = 8,
            Section = 1
        },
        new()
        {
            Name = "Flat Coated Retriever",
            Group = 8,
            Section = 1
        },
        new()
        {
            Name = "Golden Retriever",
            Group = 8,
            Section = 1
        },
        new()
        {
            Name = "Labrador Retriever",
            Group = 8,
            Section = 1
        },
        new()
        {
            Name = "Chesapeake Bay Retriever",
            Group = 8,
            Section = 1
        },
        new()
        {
            Name = "German Spaniel (Wachtelhund)",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "Clumber Spaniel",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "English Cocker Spaniel",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "English Springer Spaniel",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "Field Spaniel",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "Sussex Spaniel",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "Welsh Springer Spaniel",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "Nederlandse Kooikerhondje",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "American Cocker Spaniel",
            Group = 8,
            Section = 2
        },
        new()
        {
            Name = "French Water Dog (Barbet)",
            Group = 8,
            Section = 3
        },
        new()
        {
            Name = "Irish Water Spaniel",
            Group = 8,
            Section = 3
        },
        new()
        {
            Name = "Romagna Water Dog (Lagotto Romagnolo)",
            Group = 8,
            Section = 3
        },
        new()
        {
            Name = "Portuguese Water Dog",
            Group = 8,
            Section = 3
        },
        new()
        {
            Name = "Spanish Water Dog",
            Group = 8,
            Section = 3
        },
        new()
        {
            Name = "Frisian Water Dog (Wetterhoun)",
            Group = 8,
            Section = 3
        },
        new()
        {
            Name = "American Water Spaniel",
            Group = 8,
            Section = 3
        },
        new()
        {
            Name = "Bichon Frise",
            Group = 9,
            Section = 1
        },
        new()
        {
            Name = "Maltese",
            Group = 9,
            Section = 1
        },
        new()
        {
            Name = "Havanese",
            Group = 9,
            Section = 1
        },
        new()
        {
            Name = "Bolognese",
            Group = 9,
            Section = 1
        },
        new()
        {
            Name = "Coton de Tulear",
            Group = 9,
            Section = 1
        },
        new()
        {
            Name = "Löwchen (Little Lion Dog)",
            Group = 9,
            Section = 1
        },
        new()
        {
            Name = "Standard Poodle (Brown, black and white)",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Standard Poodle (Grey and fawn)",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Medium Poodle (Brown, black and white)",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Medium Poodle (Grey and fawn)",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Miniature Poodle (Brown, black and white)",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Miniature Poodle (Grey and fawn)",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Toy Poodle",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Multicoloured Poodle",
            Group = 9,
            Section = 2
        },
        new()
        {
            Name = "Griffon Belge",
            Group = 9,
            Section = 3
        },
        new()
        {
            Name = "Griffon Bruxellois",
            Group = 9,
            Section = 3
        },
        new()
        {
            Name = "Petit Brabançon",
            Group = 9,
            Section = 3
        },
        new()
        {
            Name = "Chinese Crested Dog",
            Group = 9,
            Section = 4
        },
        new()
        {
            Name = "Lhasa Apso",
            Group = 9,
            Section = 5
        },
        new()
        {
            Name = "Shih Tzu",
            Group = 9,
            Section = 5
        },
        new()
        {
            Name = "Tibetan Spaniel",
            Group = 9,
            Section = 5
        },
        new()
        {
            Name = "Tibetan Terrier",
            Group = 9,
            Section = 5
        },
        new()
        {
            Name = "Chihuahua (Long haired)",
            Group = 9,
            Section = 6
        },
        new()
        {
            Name = "Chihuahua (Smooth haired)",
            Group = 9,
            Section = 6
        },
        new()
        {
            Name = "Cavalier King Charles Spaniel",
            Group = 9,
            Section = 7
        },
        new()
        {
            Name = "King Charles Spaniel",
            Group = 9,
            Section = 7
        },
        new()
        {
            Name = "Pekingese",
            Group = 9,
            Section = 8
        },
        new()
        {
            Name = "Japanese Chin",
            Group = 9,
            Section = 8
        },
        new()
        {
            Name = "Continental Toy Spaniel (Papillion)",
            Group = 9,
            Section = 9
        },
        new()
        {
            Name = "Continental Toy Spaniel (Phalène)",
            Group = 9,
            Section = 9
        },
        new()
        {
            Name = "Russian Toy (Smooth haired)",
            Group = 9,
            Section = 9
        },
        new()
        {
            Name = "Russian Toy (Long haired)",
            Group = 9,
            Section = 9
        },
        new()
        {
            Name = "Kromfohrländer",
            Group = 9,
            Section = 10
        },
        new()
        {
            Name = "Pug",
            Group = 9,
            Section = 11
        },
        new()
        {
            Name = "French Bulldog",
            Group = 9,
            Section = 11
        },
        new()
        {
            Name = "Boston Terrier",
            Group = 9,
            Section = 11
        },
        new()
        {
            Name = "Prague Ratter",
            Group = 9,
            Section = 11
        },
        new()
        {
            Name = "Afghan Hound",
            Group = 10,
            Section = 1
        },
        new()
        {
            Name = "Saluki",
            Group = 10,
            Section = 1
        },
        new()
        {
            Name = "Borzoi - Russian Hunting Sighthound",
            Group = 10,
            Section = 1
        },
        new()
        {
            Name = "Deerhound",
            Group = 10,
            Section = 2
        },
        new()
        {
            Name = "Irish Wolfhound",
            Group = 10,
            Section = 2
        },
        new()
        {
            Name = "Greyhound",
            Group = 10,
            Section = 3
        },
        new()
        {
            Name = "Whippet",
            Group = 10,
            Section = 3
        },
        new()
        {
            Name = "Hungarian Greyhound",
            Group = 10,
            Section = 3
        },
        new()
        {
            Name = "Azawakh",
            Group = 10,
            Section = 3
        },
        new()
        {
            Name = "Sloughi",
            Group = 10,
            Section = 3
        },
        new()
        {
            Name = "Polish Greyhound",
            Group = 10,
            Section = 3
        },
        new()
        {
            Name = "Spanish Greyhound",
            Group = 10,
            Section = 3
        }
    };

    public static void Seed(ModelBuilder modelBuilder)
    {
        var date = new DateTime(2023, 3, 11);

        var id = 1;
        foreach (var b in Breeds)
        {
            b.Species = Species.Dogz;
            b.Id = id++;
            b.AddedBy = "system";
            b.CreatedDate = date;
        }

        modelBuilder.Entity<BreedEntity>().HasData(Breeds);
    }
}
