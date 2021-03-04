using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GameStore.BLL.DTO;
using GameStore.BLL.Exceptions.ServiceExceptions;
using GameStore.BLL.Interfaces;
using GameStore.DAL.Entities;
using GameStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GameStore.BLL.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public CommentDto Add(CommentDto itemDto)
        {
            var comment = _mapper.Map<Comment>(itemDto);

            if (comment.ParentComment != null)
            {
                comment.GameId = comment.ParentComment.GameId;
                comment.ParentComment = null;
            }

            _unitOfWork.CommentRepository.Add(comment);
            _unitOfWork.Save();

            return _mapper.Map<CommentDto>(comment);
        }

        public CommentDto Update(CommentDto itemDto)
        {
            var comment = _mapper.Map<Comment>(itemDto);

            if (comment.ParentComment != null)
            {
                comment.GameId = comment.ParentComment.GameId;
            }

            _unitOfWork.CommentRepository.Update(comment);
            _unitOfWork.Save();

            return _mapper.Map<CommentDto>(comment);
        }

        public void Delete(int id)
        {
            var result = _unitOfWork.CommentRepository.GetSingle(com => com, predicates: comment => comment.Id == id);

            if (result == null)
            {
                throw new NotFoundException();
            }

            _unitOfWork.CommentRepository.Delete(result);
            _unitOfWork.Save();
        }

        public CommentDto GetById(int id)
        {
            var result = _unitOfWork.CommentRepository
                .GetSingle(com => com, predicates: comment => comment.Id == id, include: commentInclude => commentInclude
                    .Include(comment => comment.Game)
                    .Include(comment => comment.ParentComment));

            if (result == null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<CommentDto>(result);
        }

        public List<CommentDto> GetAll(bool includeIsDeleted = false)
        {
            var result = _unitOfWork.CommentRepository
                .GetAll(commentInclude => commentInclude
                    .Include(comment => comment.Game)
                    .Include(comment => comment.ParentComment),
                    includeIsDeleted).ToList();
            
            return _mapper.Map<List<CommentDto>>(result);
        }

        public List<CommentDto> GetAllByGameKey(string key, bool includeIsDeleted = false)
        {
            var result = _unitOfWork.CommentRepository
                .GetAll(commentInclude => commentInclude
                    .Include(comment => comment.Game)
                    .Include(comment => comment.ParentComment),
                    includeIsDeleted,
                    comment => comment.GameKey.Equals(key)).ToList();

            return _mapper.Map<List<CommentDto>>(result);
        }
    }
}
