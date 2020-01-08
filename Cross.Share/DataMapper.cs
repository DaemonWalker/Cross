using AutoMapper;
using Cross.Dtos;
using Cross.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Share
{
    public class DataMapper : Profile
    {
        public DataMapper()
        {
            CreateMap<AccountDto, AccountModel>().AfterMap((dto, model) => { model.Avatar = $"resource/images/avatar/{dto.ID}.png"; });
            CreateMap<LoginModel, AccountDto>().AfterMap((model, dto) => { dto.Password = model.Password.EncrptPassword(); });
            CreateMap<CommentDto, CommentViewModel>()
                .ForMember(model => model.UserInfo, opt => opt.MapFrom(dto => dto.User))
                .AfterMap((dto, model) =>
                {
                    model.Up = dto.CommentVotes.Count(p => p.Point == 1);
                    model.Down = dto.CommentVotes.Count(p => p.Point == -1);
                }).ReverseMap();
            CreateMap<AccountDto, UserModel>().ReverseMap();
            CreateMap<CommentModel, CommentDto>()
                .AfterMap((m, d) =>
                {
                    d.User = new AccountDto() { ID = m.UserID };
                    d.Item = new ItemDto() { ID = m.ItemID };
                }).ReverseMap();
        }
    }
}
