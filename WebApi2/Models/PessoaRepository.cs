using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApi.Models
{
    public class PessoaRepository : IPessoaRepository
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        private int _nextId = 1;

        public PessoaRepository()
        {
            Add(new Pessoa { Nome = "Fulano da Silva", DataNascimento = "1994-10-06", CPf = "111.111.111-11", Email = "fulano@fulano.com.br" });
            Add(new Pessoa { Nome = "João Cesar Carlos", DataNascimento = "1982-11-12", CPf = "222.222.222.-22", Email = "Joao@cesar.com.br" });
            Add(new Pessoa { Nome = "Ana Vitoria", DataNascimento = "2000-06-08", CPf = "333.333.333-33", Email = "ana@vitoria.com.br" });
            Add(new Pessoa { Nome = "Jose Costa", DataNascimento = "1982-12-01", CPf = "444.444.444-44", Email = "jose@costa.com.br" });
            Add(new Pessoa { Nome = "Maria Joana", DataNascimento = "1994-10-06", CPf = "555.555.555-55", Email = "maria.joana@gmail.com.br" });
            Add(new Pessoa { Nome = "Jonatham Moreira", DataNascimento = "1965-11-02", CPf = "666.666.666-66", Email = "jonatham.moreira@gmail.com.br" });
            Add(new Pessoa { Nome = "Matheus Campos", DataNascimento = "1985-07-06", CPf = "777.777.777-77", Email = "matheus.campos@gmail.com.br" });
            Add(new Pessoa { Nome = "Gabriel costa", DataNascimento = "1988-02-05", CPf = "888.888.888-88", Email = "gabriel.costa@gmail.com.br" });
            Add(new Pessoa { Nome = "Henrique da Silva", DataNascimento = "1974-01-06", CPf = "999.999.999-99", Email = "henrique.silva@gmail.com.br" });
            Add(new Pessoa { Nome = "Josilino Cavalcante", DataNascimento = "1977-09-08", CPf = "101.101.101-10", Email = "joselino.cavalcante@gmail.com.br" });
            Add(new Pessoa { Nome = "Francisco Edivaldo", DataNascimento = "1999-06-11", CPf = "110.110.110-10", Email = "edvaldo.silva@gmail.com.br" });
            Add(new Pessoa { Nome = "Bruno Henrique", DataNascimento = "1998-05-31", CPf = "001.001.001-01", Email = "bruno.henrique@gmail.com.br" });

        }

        public Pessoa Add(Pessoa item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            pessoas.Add(item);
            return item;
        }

        public Pessoa Get(int id)
        {
            return pessoas.Find(p => p.Id == id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return pessoas;
        }

        public void Remove(int id)
        {
            pessoas.RemoveAll(p => p.Id == id);
        }

        public bool Update(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new ArgumentNullException("pessoa");
            }

            int index = pessoas.FindIndex(p => p.Id == pessoa.Id);

            if (index == -1)
            {
                return false;
            }
            pessoas.RemoveAt(index);
            pessoas.Add(pessoa);
            return true;
        }

    }
}