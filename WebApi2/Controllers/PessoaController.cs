using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PessoaController : ApiController
    {
        static readonly IPessoaRepository repositorio = new PessoaRepository();

        public IEnumerable<Pessoa> GetAllPessoas()
        {
            return repositorio.GetAll();
        }

        public Pessoa GetPessoa(int id)
        {
            Pessoa pessoa = repositorio.Get(id);
            if (pessoa == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return pessoa;
        }

        public IEnumerable<Pessoa> GetPessoasPorNome(string nome)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Nome, nome, StringComparison.OrdinalIgnoreCase));
        }

        public HttpResponseMessage PostPessoa(Pessoa pessoa)
        {
            pessoa = repositorio.Add(pessoa);
            var response = Request.CreateResponse<Pessoa>(HttpStatusCode.Created, pessoa);

            string uri = Url.Link("DefaultApi", new { id = pessoa.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutPessoa(int id, Pessoa pessoa)
        {
            pessoa.Id = id;
            if (!repositorio.Update(pessoa))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeletePessoa(int id)
        {
            Pessoa pessoa = repositorio.Get(id);

            if (pessoa == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Remove(id);
        }
    }
}
