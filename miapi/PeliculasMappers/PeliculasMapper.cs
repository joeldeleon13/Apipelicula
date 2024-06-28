﻿using AutoMapper;
using miapi.Modelos;
using miapi.Modelos.Dtos;

namespace miapi.PeliculasMapper
{
    public class PeliculasMapper : Profile
    {
        public PeliculasMapper()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Categoria, CrearCategoriaDto>().ReverseMap();
            CreateMap<Pelicula, PeliculaDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
           
        }
    }
}
