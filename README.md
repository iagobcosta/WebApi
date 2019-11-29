# Configuração
1° Baixe o codigo fone do projeto.

2° Abra o projeto no visual studio.

3° Execute o sistema no botão Run


# WebApi
Api desenvolvida em C#

# Alunos
Iago Barbosa da Costa

Laryssa Rodrigues Batista Braga


# Buscar todos registros com Método de HTTP GET
http://localhost:44328/api/Pessoa

# Buscar pessoa por ID com Método de HTTP GET
http://localhost:44328/api/Pessoa/{ID}

# Buscar pessoa por nome com Método de HTTP GET
http://localhost:44328/api/Pessoa?nome={name}

# Inserir registro com Método de HTTP POST
http://localhost:44328/api/Pessoa
Header
{
  "Id":01,
  "Nome": "Teste",
  "DataNascimento": "2019-10-25",
  "CPF": "111.111.111-11",
  "Email": "exemplo@gmail.com"
}
# Excluir um registro com Método de HTTP REMOVE
http://localhost:44328/api/Pessoa/{ID}

# Editar um registro com Método de HTTP PUT
http://localhost:44328/api/Pessoa/{ID}
Header
{
  "Id":01,
  "Nome": "Teste",
  "DataNascimento": "2019-10-25",
  "CPF": "111.111.111-11",
  "Email": "exemplo@gmail.com"
}
