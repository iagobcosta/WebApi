# WebApi
Api desenvolvida em C#

# Request Url
Buscar todos registros com o Request GET
http://localhost:44328/api/Pessoa

# Buscar pessoa por ID com o Request GET
http://localhost:44328/api/Pessoa/{ID}

# Buscar pessoa por nome com o Request GET
http://localhost:44328/api/Pessoa?nome={name}

# Inserir registro com o Request POST
http://localhost:44328/api/Pessoa
Header
{
  "Id":01,
  "Nome": "Teste",
  "DataNascimento": "2019-10-25",
  "CPF": "111.111.111-11",
  "Email": "exemplo@gmail.com"
}
# Excluir um registro com o Request REMOVE
http://localhost:44328/api/Pessoa/{ID}

# Editar um registro com o Request PUT
http://localhost:44328/api/Pessoa/{ID}
Header
{
  "Id":01,
  "Nome": "Teste",
  "DataNascimento": "2019-10-25",
  "CPF": "111.111.111-11",
  "Email": "exemplo@gmail.com"
}
