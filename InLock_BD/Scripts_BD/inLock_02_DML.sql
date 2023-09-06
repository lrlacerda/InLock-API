USE inlock_games_Lucas;
GO

-- Inserir valores na tabela Estudio
INSERT INTO Estudio(Nome)
VALUES 
  ('Blizzard'),
  ('Rockstar Studios'),
  ('Square Enix'),
  ('Ubisoft'),
  ('Electronic Arts'),
  ('Bethesda');
GO

-- Inserir valores na tabela Jogo
INSERT INTO Jogo(IdEstudio, Nome, Descricao, DataLancamento, Valor)
VALUES 
  (1, 'Diablo 3', 'É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã.', '2012-09-24', 99),
  (2, 'Red Dead Redemption II', 'Jogo eletrônico de ação-aventura western.', '2012-09-27', 120),
  (3, 'Assassin''s Creed Valhalla', 'Jogo de ação e aventura ambientado na era dos vikings.', '2020-11-10', 79.99),
  (4, 'FIFA 23', 'Simulador de futebol muito realista.', '2022-09-22', 59.99);
GO

-- Inserir valores na tabela TiposUsuario
INSERT INTO TiposUsuario(Titulo)
VALUES 
  ('Comum'),
  ('Administrador');
GO

-- Inserir valores na tabela Usuario
INSERT INTO Usuario(IdTipoUsuario, Email, Senha)
VALUES 
  (1, 'cliente@cliente.com', 'cliente'),
  (2, 'admin@admin.com', 'admin'),
  (3, 'outrocliente@cliente.com', 'outrasenha'),
  (4, 'moderador@moderador.com', 'moderador123'),
  (4, 'editor@editor.com', 'editor456');
GO


