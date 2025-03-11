## Passo a Passo para Rodar o Projeto em Sua Máquina

1. **Criação do diretório para o projeto:**
   Crie uma pasta onde o back-end e o front-end serão colocados:
   ```bash
   mkdir project
   ```

2. **Acessar o diretório criado:**
   Entre na pasta `project`:
   ```bash
   cd project
   ```

3. **Clonar os repositórios do projeto:**
   Agora, clone os dois repositórios (back-end e front-end):
   ```bash
   git clone https://github.com/norberto-jn/testejrbackend-api.git
   git clone https://github.com/norberto-jn/testejrfrontend-ui.git
   ```

4. **Copiar o arquivo `docker-compose.yaml`:**
   Copie o arquivo `docker-compose.yaml` de um dos repositórios (`testejrbackend-api.git` e `testejrfrontend-ui.git`) e cole-os na raiz do diretório `project`.

5. **Rodar o Docker Compose:**
   Agora, dentro da pasta `project`, execute o comando:
   ```bash
   docker compose up -d
   ```

6. **Instalar Docker Compose (caso necessário):**
   Se você não tem o Docker Compose instalado em sua máquina, siga o tutorial de instalação oficial [aqui](https://docs.docker.com/compose/install/).

7. **Verificar se o projeto está rodando:**
   Após o Docker Compose subir os containers, você pode verificar o status do projeto com:
   ```bash
   docker compose ps
   ```

8. **Acessar a aplicação no navegador:**
   Abra um navegador de sua preferência e acesse a URL:
   ```
   http://localhost:5173/auth/login
   ```

9. **Login:**
   Use as credenciais abaixo para fazer login:
   - **Usuário:** norberto@gmail.com
   - **Senha:** 123

Após seguir esses passos, o seu projeto deve estar rodando corretamente. Se tiver algum problema, me avise!

## INSTRUÇÕES PARA O TESTE TÉCNICO

- Crie um fork deste projeto (https://github.com/CAPYS-IT/TesteJRBackend).
  É preciso estar logado na sua conta Github;
- Quando você começar, faça um commit vazio com a mensagem "Iniciando o teste de tecnologia" e quando terminar, faça o commit com uma mensagem "Finalizado o teste de tecnologia";
- Commit após cada ciclo de refatoração pelo menos;
- Não use branches;
- Você deve prover evidências suficientes de que sua solução está completa indicando, no mínimo, que ela funciona;
- Não há restrição quanto ao uso de bibliotecas de apoio;
- No final envie para o RH o link do seu projeto.
- Uso do Visual Studio 2022

## O TESTE

- Implementar o metodo lstTarefas da classe Tarefas na Tarefascontroller/lstTarefas e retorna a lista de tarefas. **CODE** 200.
- Implementar o metodo InserirTarefa da classe Tarefas na Tarefascontroller/InserirTarefas e retorna a lista de tarefas. **CODE** 200.
- Implementar o metodo DeletarTarefa da classe Tarefas na Tarefascontroller/DeleteTask e retorna a lista de tarefas. **CODE** 200.

---

- Descreva oque esta acontecendo com comentarios em cada linha de codigo do metodo DeletarTarefa da classe Tarefas.

- Faça o tratamento de erro do metodo DeletarTarefa da classe Tarefas. <br/> Parametros:
- O usuario esta tentando deletar a tarefa de codigo 1458.

---

## BÔNUS

- Efetuar tratamento das classes e Controllers com boas praticas seguindo os padrões REST.
- Criar Metodo de Atualizar um item da lista, passando uma objeto e retornando a lista atualizada.
- Criar metodo para pegar um Item da Lista passando um ID e retornando o Objeto da Lista.

---

## PONTOS QUE SERÃO AVALIADOS

- Boas práticas;
- Estrutura de Codigo.
