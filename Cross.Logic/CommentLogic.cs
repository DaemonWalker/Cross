using AutoMapper;
using Cross.Dtos;
using Cross.IRepository;
using Cross.IService;
using Cross.Models;
using System;
using System.Collections.Generic;
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
        public List<CommentShowModel> GetCommentsByItemID(int itemID)
        {
            return _mapper.Map<List<CommentShowModel>>(_commentRepository.GetByItemID(itemID));
        }
        public CommentShowModel Add(CommentModel comment)
        {
            var dto = _mapper.Map<CommentDto>(comment);
            dto = _commentRepository.Insert(dto);
            return _mapper.Map<CommentShowModel>(dto);
        }

        public void Delete(int commentID)
        {
            _commentRepository.Delete(new CommentDto() { ID = commentID });
        }
        public void Modify(CommentModel comment)
        {
            var dto = _mapper.Map<CommentDto>(comment);
            _commentRepository.Update(dto);
        }
    }
}
