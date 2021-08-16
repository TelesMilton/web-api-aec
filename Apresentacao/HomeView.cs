using System.Collections.Generic;

namespace aec_gama_api.Apresentacao
{
      public class HomeView
      {
          public string Mensagem
          {
              get{ return "Olá seja muito bem vindo a minha api";}
          }

           public List<string> Endpoints
          {
             get
             { 
                 return new List<string>()
             {
                 "/candidatos",
                 "/profissoes",
                 "/swagger"
             };
          }
         }
      }
}