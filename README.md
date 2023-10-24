## Sobre a API:

API local que permite o gerenciamento de tarefas e usuários,
onde também é possível relacionar um usuário a uma tarefa específica, 
permitindo um acompanhamento das tarefas atribuídas.

## Métodos Disponíveis:

- **GET /usuarios**: Obtenha todos os usuários.
- **GET /usuarios/{id}**: Obtenha um usuário específico por ID.
- **POST /usuarios**: Crie um novo usuário.
- **PUT /usuarios/{id}**: Atualize um usuário existente.
- **DELETE /usuarios/{id}**: Exclua um usuário.

- **GET /tarefas**: Obtenha todas as tarefas.
- **GET /tarefas/{id}**: Obtenha uma tarefa específica por ID.
- **POST /tarefas**: Crie uma nova tarefa.
- **PUT /tarefas/{id}**: Atualize uma tarefa existente.
- **DELETE /tarefas/{id}**: Exclua uma tarefa.

## Visualizador Swagger:

O Swagger é uma ferramenta que oferece uma documentação dinâmica e organizada da API. 
Ele facilita a compreensão dos métodos, parâmetros necessários e respostas esperadas. 
Além disso, você pode testar os endpoints diretamente por meio do Swagger.

## Ferramentas Utilizadas:

- Visual Studio
- .NET 7.0
- ASP.NET Core Web API
- SQL Server
