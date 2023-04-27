using System.Collections.Generic;

namespace EnqueteWeb.Models
{
    public class Repositorio
    {
        private static List<RespostaUsuario> respostas = new List<RespostaUsuario>();
        public static IEnumerable<RespostaUsuario> Respostas { get { return respostas; } }
        public static void adicionarResposta(RespostaUsuario resposta)
        {
            respostas.Add(resposta);
        }
    }
}