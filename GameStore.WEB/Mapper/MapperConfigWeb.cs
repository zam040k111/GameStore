using AutoMapper;
using GameStore.BLL.DTO;
using GameStore.BLL.Services.Validation;
using GameStore.WEB.Models;

namespace GameStore.WEB.Mapper
{
    public class MapperConfigWeb : Profile
    {
        public MapperConfigWeb()
        {
            CreateMap<GameViewModel, GameDto>();
            CreateMap<GameDto, GameViewModel>();
            CreateMap<GenreViewModel, GenreDto>();
            CreateMap<GenreDto, GenreViewModel>();
            CreateMap<CommentViewModel, CommentDto>();
            CreateMap<CommentDto, CommentViewModel>();
            CreateMap<PlatformTypeDto, PlatformTypeViewModel>();
            CreateMap<PlatformTypeViewModel, PlatformTypeDto>();
            CreateMap<GameGenreDto, GameGenreViewModel>();
            CreateMap<GameGenreViewModel, GameGenreDto>();
            CreateMap<GamePlatformTypeDto, GamePlatformTypeViewModel>();
            CreateMap<GamePlatformTypeViewModel, GamePlatformTypeDto>();
            CreateMap<PublisherViewModel, PublisherDto>();
            CreateMap<PublisherDto, PublisherViewModel>();
            CreateMap<OrderDto, OrderViewModel>();
            CreateMap<OrderViewModel, OrderDto>();
            CreateMap<OrderDetailDto, OrderDetailViewModel>();
            CreateMap<OrderDetailViewModel, OrderDetailDto>();
            CreateMap<Result<GameDto>, Result<GameViewModel>>();
            CreateMap<Result<GenreViewModel>, Result<GameDto>>();
            CreateMap<Result<OrderViewModel>, Result<OrderDto>>();
            CreateMap<Result<OrderDto>, Result<OrderViewModel>>();
            CreateMap<VisaModelDto, VisaViewModel>();
            CreateMap<VisaViewModel, VisaModelDto>();
            CreateMap<GameFilterViewModel, GameFilterDto>();
            CreateMap<GameFilterDto, GameFilterViewModel>();
        }
    }
}
