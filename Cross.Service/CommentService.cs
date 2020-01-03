using AutoMapper;
using Cross.Dtos;
using Cross.IRepository;
using Cross.IService;
using Cross.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Service
{
    public class CommentService : ICommentService
    {
        private readonly IBaseRepository<CommentDto> _commentRepository;
        private readonly Mapper _mapper;
        public CommentService(IBaseRepository<CommentDto> commentRepository, Mapper mapper)
        {
            this._commentRepository = commentRepository;
            this._mapper = mapper;
        }
        public CommentModel Add(CommentModel comment)
        {
            var dto = _mapper.Map<CommentDto>(comment);
            return _mapper.Map<CommentModel>(_commentRepository.Insert(dto));
        }

        public bool Delete(CommentModel comment)
        {
            if (_commentRepository.Delete(_mapper.Map<CommentDto>(comment)) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<CommentModel> Get(int itemID)
        {
            return _mapper.Map<IEnumerable<CommentModel>>(_commentRepository.Query(dbSet => dbSet.Where(p => p.ItemID == itemID)));
        }

        public CommentModel Modify(CommentModel comment)
        {
            return _mapper.Map<CommentModel>(_commentRepository.Update(_mapper.Map<CommentDto>(comment)));
        }
    }
}
