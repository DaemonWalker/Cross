using AutoMapper;
using Cross.Dtos;
using Cross.ILogic;
using Cross.IRepository;
using Cross.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cross.Logic
{
    public class CommentLogic : ICommentLogic
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;
        public CommentLogic(ICommentRepository commentRepository, IMapper mapper)
        {
            this._commentRepository = commentRepository;
            this._mapper = mapper;
        }
        public CommentViewModel Add(CommentModel comment)
        {
            var dto = _mapper.Map<CommentDto>(comment);
            dto = _commentRepository.Insert(dto);
            return _mapper.Map<CommentViewModel>(dto);
        }

        public void Delete(int commentID)
        {
            _commentRepository.Delete(new CommentDto() { ID = commentID });
        }
        public CommentViewModel Modify(CommentModel comment)
        {
            var dto = _mapper.Map<CommentDto>(comment);
            return _mapper.Map<CommentViewModel>(_commentRepository.Update(dto));
        }

        public List<CommentViewModel> GetByItemIDOrderByTime(int itemID, int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public List<CommentViewModel> GetByItemIDOrderByUp(int itemID, int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentDto> Get(int itemID, int skip, int take)
        {
            return _commentRepository.GetByItemID(itemID).Skip(skip).Take(take);
        }
    }
}
