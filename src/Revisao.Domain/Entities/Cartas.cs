using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Cartas
    {
        public Cartas(string nome, string endereco, int idade, string textinho)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
            Textinho = textinho;
        }

        [MinLength(3, ErrorMessage = "Minimo de 3 letras.")]
        [MaxLength(255, ErrorMessage = "maximo ....")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O endereço é obrigatorio...")]
        public string Endereco { get; private set; }

        [Range(1, 15)]
        [Required]
        public int Idade { get; private set; }
        [MaxLength(500, ErrorMessage = "maximo ....")]
        [Required]
        public string Textinho { get; private set; }

    }
}
