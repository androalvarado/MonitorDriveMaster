using AutoMapper;
using MonitorDriveAPI.Models.DTO;
using MonitorDriveAPI.Models.Entities;

namespace MonitorDriveAPI.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // User Mapping
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();

            // Driver Mapping
            CreateMap<CreateDriverDto, Driver>().ReverseMap();
            CreateMap<Driver, DriverDto>().ReverseMap();
            CreateMap<UpdateDriverDto, Driver>().ReverseMap();

            // Phone Mapping
            CreateMap<CreatePhoneDto, Phone>().ReverseMap();
            CreateMap<Phone, PhoneDto>().ReverseMap();
            CreateMap<UpdatePhoneDto, Phone>().ReverseMap();

            // Vehicle Mapping
            CreateMap<CreateVehicleDto, Vehicle>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>().ReverseMap();

        }
    }
}
