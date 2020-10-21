using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    class PessoaService : GenericService<Pessoa>
    {
        private GenericService<Pessoa> pessoaService;
        
        public override void ListAll(Pessoa entity)
        {
            List<Pessoa> listPessoa = new List<Pessoa>();
            Pessoa people = new Pessoa();
            
            people.PessoaId = 0;
            people.Nome = "Nandi";
            people.Email = "nandi00@gmail.com.br";            
            listPessoa.Add(people);

            people.PessoaId = 1;
            people.Nome = "Enzo";
            people.Email = "enzo01@gmail.com.br";
            listPessoa.Add(people);

            people.PessoaId = 2;
            people.Nome = "Fred";
            people.Email = "fred02@gmail.com.br";
            listPessoa.Add(people);

            people.PessoaId = 3;
            people.Nome = "Scooby";
            people.Email = "scooby03@gmail.com.br";
            listPessoa.Add(people);

            people.PessoaId = 4;
            people.Nome = "Skaarl";
            people.Email = "skaarl04@gmail.com.br";
            listPessoa.Add(people);

            people.PessoaId = 5;
            people.Nome = "Samanta";
            people.Email = "samanta05@gmail.com.br";
            listPessoa.Add(people);

            people.PessoaId = 6;
            people.Nome = "Scooby";
            people.Email = "scooby06@gmail.com.br";
            listPessoa.Add(people);


            //.ListAll(entity);
        }
    }
}
