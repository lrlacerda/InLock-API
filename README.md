# InLock-API

1. StoryTelling
Uma empresa do ramo de games, a InLock, deseja realizar a criação de sua base de dados
para armazenar os jogos que são vendidos em sua loja. Além disso, como eles já
possuem um desenvolvedor front-end atuando na empresa, não será necessário
construir a interface com o usuário final. Para isto, deverá ser desenvolvida uma API
(trabalhando com JSON), para que o front-end (seja web ou mobile) realize a construção
com base nas informações fornecidas.

Os jogos deverão ter as seguintes características:
Nome, Descrição, Data de Lançamento e Valor. Além disso, o jogo deverá ter um
estúdio pelo qual foi desenvolvido.

Por exemplo:
O Diablo 3 foi lançado em 15 de maio de 2012, é um jogo que contém bastante ação e é
viciante, seja você um novato ou um fã. Além disso, seu estúdio é a Blizzard. E o jogo
custa R$ 99,00.
Red Dead Redemption II é um jogo eletrônico de ação-aventura western desenvolvido
pela Rockstar Studios. Lançado mundialmente em 26 de outubro de 2018. E o jogo custa
R$ 120,00.
Além disso, somente usuários com o perfil de ADMINISTRADOR poderão cadastrar um
novo jogo. Qualquer usuário autenticado, com o perfil de ADMINISTRADOR ou CLIENTE,
poderá realizar a listagem de jogos.

Roteiro BD
Primeiro arquivo: inlock_01_DDL.sql
• Criar um banco de dados chamado inlock_games_manha/tarde;
• Criar uma tabela de estúdios com os campos de idEstudio e nomeEstudio;
• Criar uma tabela de jogos com os campos idJogo, nomeJogo, descrição,
dataLancamento, valor e idEstudio;
• Criar uma tabela de tipos de usuários contendo os campos idTipoUsuario e
titulo;
• Criar uma tabela de usuários contendo os campos de idUsuario, email, senha e
idTipoUsuario;
Obs.: Atente-se na definição dos tipos de dados.

Segundo arquivo: inlock_02_DML.sql
• Inserir um usuário do tipo ADMINISTRADOR que tenha o e-mail igual a
admin@admin.com e a senha igual a admin;
• Inserir um usuário do tipo CLIENTE que tenha o e-mail igual a
cliente@cliente.com e a senha igual a cliente;
• Inserir três estúdios: um com o nome de Blizzard, outro com o nome de
Rockstar Studios e o último com o nome de Square Enix;
• Inserir um jogo com o nome de: Diablo 3, com data de lançamento de: 15 de
maio de 2012, que contenha a descrição de: é um jogo que contém bastante
ação e é viciante, seja você um novato ou um fã. Seu estúdio é a Blizzard. E o
jogo custa R$ 99,00;
• Inserir um jogo com o nome de: Red Dead Redemption II, com a descrição de: jogo
eletrônico de ação-aventura western. Seu estúdio será a Rockstar Studios. Lançado
mundialmente em 26 de outubro de 2018. E o jogo custa R$ 120,00;
