using AutoMapper;
using Cross.Dtos;
using Cross.ILogic;
using Cross.IRepository;
using Cross.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross.Logic
{
    public class CommentVoteLogic : ICommentVoteLogic
    {
        private readonly ICommentVoteRepository _commentVoteRepository;
        private readonly IMapper _mapper;
        public CommentVoteLogic(ICommentVoteRepository commentVoteRepository, IMapper mapper)
        {
            this._commentVoteRepository = commentVoteRepository;
            this._mapper = mapper;
        }

        public void Vote(CommentVoteModel commentVote)
        {
            Remove(commentVote);

            var vote = _mapper.Map<CommentVoteDto>(commentVote);
            _commentVoteRepository.Insert(vote);
        }


        public void Remove(CommentVoteModel commentVote)
        {
            var vote = _commentVoteRepository.GetByCommentIDAndUserID(commentVote.CommentID, commentVote.UserID);
            if (vote != default(CommentVoteDto))
            {
                _commentVoteRepository.Delete(vote);
            }
        }
    }
}
