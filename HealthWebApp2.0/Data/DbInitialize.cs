using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Barangays;
using System.Collections.Generic;
using System.Linq;

namespace HealthWebApp2._0.Data
{
    public static class DbInitialize
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.PhilArea.Any()) 
            {
                var PhilAreas = new List<PhilArea>()
               {
                   new PhilArea {Name = "Luzon"},
                   new PhilArea {Name = "Visayas"},
                   new PhilArea {Name = "Mindanao"}
               };
               context.PhilArea.AddRange(PhilAreas);
               context.SaveChanges();
            }

            if (!context.Region.Any()) 
            {
                var Regions = new List<Region>()
               {
                   new Region {Name = "1", PhilAreaId = 1},
                   new Region {Name = "2", PhilAreaId = 1},
                   new Region {Name = "3", PhilAreaId = 1}
               };
               context.Region.AddRange(Regions);
               context.SaveChanges();
            }
            
            if (!context.Province.Any()) 
            {
                var Provinces = new List<Province>()
               {
                   new Province {Name = "Pangasinan", RegionId = 1},
                   new Province {Name = "San Fernando", RegionId = 1},
                   new Province {Name = "Ilocos Norte", RegionId = 1}
               };
               context.Province.AddRange(Provinces);
               context.SaveChanges();
            }

            if (!context.City.Any())
            {
                var City = new List<CityMunicipality>()
               {
                   new CityMunicipality {Name = "Dagupan City", ProvinceId = 1},
                   new CityMunicipality {Name = "San Carlos City", ProvinceId = 1}
               };
                context.City.AddRange(City);
                context.SaveChanges();
            }

            if (!context.Barangay.Any())
            {
                var barangays = new List<Barangay>()
                {
                    new Barangay {Name = "Bacayao Norte", CityMunicipalityId = 1},
                    new Barangay {Name = "Bacayao Sur", CityMunicipalityId = 1},
                    new Barangay {Name = "Barangay I", CityMunicipalityId = 1},
                    new Barangay {Name = "Barangay II", CityMunicipalityId = 1},
                    new Barangay {Name = "Barangay IV", CityMunicipalityId = 1},
                    new Barangay {Name = "Bolosan", CityMunicipalityId = 1},
                    new Barangay {Name = "Bonuan Binloc", CityMunicipalityId = 1},
                    new Barangay {Name = "Bonuan Boquig", CityMunicipalityId = 1},
                    new Barangay {Name = "Bonuan Gueset", CityMunicipalityId = 1},
                    new Barangay {Name = "Calmay", CityMunicipalityId = 1},
                    new Barangay {Name = "Carael", CityMunicipalityId = 1},
                    new Barangay {Name = "Caranglaan", CityMunicipalityId = 1},
                    new Barangay {Name = "Herrero", CityMunicipalityId = 1},
                    new Barangay {Name = "Lasip Chico", CityMunicipalityId = 1},
                    new Barangay {Name = "Lasip Grande", CityMunicipalityId = 1},
                    new Barangay {Name = "Lomboy", CityMunicipalityId = 1},
                    new Barangay {Name = "Lucao", CityMunicipalityId = 1},
                    new Barangay {Name = "Malued", CityMunicipalityId = 1},
                    new Barangay {Name = "Mamalingling", CityMunicipalityId = 1},
                    new Barangay {Name = "Mangin", CityMunicipalityId = 1},
                    new Barangay {Name = "Mayombo", CityMunicipalityId = 1},
                    new Barangay {Name = "Pantal", CityMunicipalityId = 1},
                    new Barangay {Name = "Poblacion Oeste", CityMunicipalityId = 1},
                    new Barangay {Name = "Pogo Chico", CityMunicipalityId = 1},
                    new Barangay {Name = "Pogo Grande", CityMunicipalityId = 1},
                    new Barangay {Name = "Pugaro Suit", CityMunicipalityId = 1},
                    new Barangay {Name = "Salapingao", CityMunicipalityId = 1},
                    new Barangay {Name = "Salisay", CityMunicipalityId = 1},
                    new Barangay {Name = "Tambac", CityMunicipalityId = 1},
                    new Barangay {Name = "Tapuac", CityMunicipalityId = 1},
                    new Barangay {Name = "Tebeng", CityMunicipalityId = 1}
                };
                context.Barangay.AddRange(barangays);
                context.SaveChanges();
            }

            if (!context.Religion.Any()) 
            {
                var Religions = new List<Religion>()
               {
                   new Religion {Name = "N/A"},
                   new Religion {Name = "Aglipay"},
                   new Religion {Name = "Alliance of Bible Christian Community"},
                   new Religion {Name = "Anglican"},
                   new Religion {Name = "Anglican"},
                   new Religion {Name = "Baptist"},
                   new Religion {Name = "Born Again Christian"},
                   new Religion {Name = "Buddhism"},
                   new Religion {Name = "Catholic"},
                   new Religion {Name = "Church of God"},
                   new Religion {Name = "Evangelical"},
                   new Religion {Name = "Iglesia ni Kristo"},
                   new Religion {Name = "Jehovah's Witness"},
                   new Religion {Name = "Life Renewal Christian Ministry"},
                   new Religion {Name = "Lutheran"},
                   new Religion {Name = "Methodist"},
                   new Religion {Name = "Islam"},
                   new Religion {Name = "Pentecostal"},
                   new Religion {Name = "LDS - Mormons"},
                   new Religion {Name = "Protestants"},
                   new Religion {Name = "Seventh Day Adventist"},
                   new Religion {Name = "UCCP"},
                   new Religion {Name = "Wesleyan"},
                   new Religion {Name = "Christian"}
                   
               };
               context.Religion.AddRange(Religions);
               context.SaveChanges();
            }

            if (!context.Work.Any()) 
            {
                var Works = new List<Work>()
               {
                    new Work {Name = "N/A"},
                   new Work {Name = "Accountant"},
                   new Work {Name = "Actor"}
               };
               context.Work.AddRange(Works);
               context.SaveChanges();
            }

            if (!context.NameTitle.Any())
            {
                var NameTitles = new List<NameTitle>()
               {
                    new NameTitle {Name = "N/A"},
                   new NameTitle {Name = "M.D."},
                   new NameTitle {Name = "Nurse"},
                   new NameTitle {Name = "Engineer"},
                   new NameTitle {Name = "Attorney"},
                   new NameTitle {Name = "Sanitation Inspector"},
                   new NameTitle {Name = "Midwives"},
               };
                context.NameTitle.AddRange(NameTitles);
                context.SaveChanges();
            }

            if (!context.Education.Any()) 
            {
                var Educations = new List<Education>()
               {
                    new Education {ShortName = "N/A"},
                   new Education {ShortName = "Prep"},
                   new Education {ShortName = "Kinder"},
                   new Education {ShortName = "Elementary"},
                   new Education {ShortName = "High School"},
                   new Education {ShortName = "Senior High School"},
                   new Education {ShortName = "Vocational"},
                   new Education {ShortName = "Post Graduate Program"},
                   new Education {ShortName = "Not Applicable"},
                   new Education {ShortName = "No Formal Education"},
                   new Education {ShortName = "Others"},
               };
               context.Education.AddRange(Educations);
               context.SaveChanges();
            }
        }

    }
}
