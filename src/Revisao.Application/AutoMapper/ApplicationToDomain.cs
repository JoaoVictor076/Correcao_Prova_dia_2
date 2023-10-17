using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{
			//Exemplo visto em sala de aula

			CreateMap<CartasViewModel, Cartas>()
			   .ConstructUsing(q => new Cartas(q.Nome, q.Endereco, q.Idade, q.Textinho ));

			CreateMap<NovaCartaViewModel, Cartas>()
			   .ConstructUsing(q => new Cartas(q.Nome, q.Endereco, q.Idade, q.Textinho ));

		}
	}
}
