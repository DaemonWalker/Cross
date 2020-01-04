using AutoMapper;
using Cross.Dtos;
using Cross.Models;
using System;

namespace Cross.Share
{
    public class CrossAutoMapper : Profile
    {
        public CrossAutoMapper()
        {
            CreateMap<LoginModel, AccountDto>()
                .AfterMap((model, dto) =>
                {
                    dto.Password = model.Password.EncrptPassword();
                });

            CreateMap<object, ResultModel>()
                .AfterMap((obj, result) =>
                {
                    result.Data = obj;
                });
        }
    }
}
