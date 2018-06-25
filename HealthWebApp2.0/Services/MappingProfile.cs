using AutoMapper;
using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Household;
using HealthWebApp2._0.Models.HouseholdMember;
using HealthWebApp2._0.Models.HouseholdProfile;
using HealthWebApp2._0.Models.Person;

namespace HealthWebApp2._0.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDetailModel>()
                .ForMember(dest => dest.ExtensionName, opt => opt.MapFrom(src => src.ExtensionName.ToString()))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth.ToString("yyyy, MMM-dd")))
                .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex.ToString()))
                .ForMember(dest => dest.CivilStatus, opt => opt.MapFrom(src => src.CivilStatus.ToString()))
                .ForMember(dest => dest.Work, opt => opt.MapFrom(src => src.Work.ToString()))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Address))
                .ForMember(dest => dest.Barangay, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.Name))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.CityMunicipality.Name.ToString()))
                .ForMember(dest => dest.Province, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.CityMunicipality.Province.Name.ToString()))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.HouseholdMember.HouseholdProfile.Barangay.CityMunicipality.Province.Region.Name.ToString()))
                .ForMember(dest => dest.PhilHealthID, opt => opt.MapFrom(src => src.PhilHealth.PhilHealthId))
                .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion.Name));
                //.ForMember(dest => dest.Father, opt => opt.MapFrom(src => src.Father.FullName))
                //.ForMember(dest => dest.Mother, opt => opt.MapFrom(src => src.Mother.FullName));

            //CreateMap<PersonCreateModel, Person>()
            //    .ForMember(dest => dest.NameTitleId, opt => opt.MapFrom(src => src.NameTitleId))
            //    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            //    .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
            //    .ForMember(dest => dest.ExtensionName, opt => opt.MapFrom(src => src.ExtensionName))
            //    .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
            //    .ForMember(dest => dest.Sex, opt => opt.MapFrom(src => src.Sex))
            //    .ForMember(dest => dest.CivilStatus, opt =>
            //;
            CreateMap<PersonCreateModel, Person>();
            CreateMap<Person, PersonEditModel>();
                   // .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.Id));
            CreateMap<PersonEditModel, Person>();
            
            CreateMap< HouseholdMember, HouseholdMemberDetailModel>()
                .ForMember(dest => dest.MemberName, opt => opt.MapFrom(src => src.Person.FullName))
                .ForMember(dest => dest.RelationToHouseholdHead, opt => opt.MapFrom(src => src.RelationToHead.ToString()));

            CreateMap<HouseholdProfile, HouseholdProfileDetailModel>()
                .ForMember(dest => dest.Barangay, opt => opt.MapFrom(src => src.Barangay.Name))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Barangay.CityMunicipality.Name))
                .ForMember(dest => dest.Province, opt => opt.MapFrom(src => src.Barangay.CityMunicipality.Province.Name))
                .ForMember(dest => dest.HouseholdMembers, opt => opt.MapFrom(src => src.HouseholdMembers));
            CreateMap<HouseholdProfileCreateModel, HouseholdProfile>();
               


        }
    }
}
