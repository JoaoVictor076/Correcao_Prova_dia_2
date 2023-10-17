using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;

namespace Revisao.Data.Repositories
{
    public class CartasRepository : ICartasRepository
    {
        private string _cartasCaminhoArquivo;

        #region - Construtores

        public CartasRepository()
        {
            _cartasCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "cartas.json");

        }
        #endregion

        #region - Funções
        public void AdicionarCartas(Cartas carta)
        {
            {
                var cartas = LerCartasDoArquivo();
                cartas.Add(carta);
                EscreverCartasNoArquivo(cartas);
            }

        }
        public IEnumerable<Cartas> ObterTodos()
        {
            return LerCartasDoArquivo();
        }
        #endregion

        #region - Metodos

        public List<Cartas> LerCartasDoArquivo()
        {
            if (!System.IO.File.Exists(_cartasCaminhoArquivo))
                return new List<Cartas>();
            string json = System.IO.File.ReadAllText(_cartasCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Cartas>>(json);
        }
        public void EscreverCartasNoArquivo(List<Cartas> cartas)
        {
        string json = JsonConvert.SerializeObject(cartas);
        System.IO.File.WriteAllText(_cartasCaminhoArquivo, json);
        }
        #endregion

    }

}

