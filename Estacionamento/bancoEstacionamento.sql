-- Criação do banco de dados
CREATE DATABASE IF NOT EXISTS dbEstacionamento
DEFAULT CHARACTER SET utf8mb4
DEFAULT COLLATE utf8mb4_general_ci;

USE dbEstacionamento;

-- Tabela Estacionamento
CREATE TABLE IF NOT EXISTS Estacionamento (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    cpf VARCHAR(11) NOT NULL,
    endereco VARCHAR(200) NOT NULL
) DEFAULT CHARSET = utf8mb4;

-- Tabela Veiculo
CREATE TABLE IF NOT EXISTS Veiculo (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    placa VARCHAR(10) NOT NULL UNIQUE,
    ano INT NOT NULL
) DEFAULT CHARSET = utf8mb4;

-- Tabela Tabela_Preco
CREATE TABLE IF NOT EXISTS tabela_preco (
    id INT AUTO_INCREMENT PRIMARY KEY,
    data_inicio DATE NOT NULL,
    data_fim DATE,
    valor_inicial DECIMAL(10,2) NOT NULL,
    valor_adicional DECIMAL(10,2) NOT NULL,
    estacionamento_id INT NOT NULL,
    descricao VARCHAR(255),
    status VARCHAR(50) DEFAULT 'ativo',
    inicio_vigencia DATE NOT NULL,
    fim_vigencia DATE,
    CONSTRAINT fk_tabela_preco_estacionamento FOREIGN KEY (estacionamento_id)
        REFERENCES Estacionamento(id)
        ON DELETE CASCADE ON UPDATE CASCADE
) DEFAULT CHARSET = utf8mb4;

-- Tabela Movimentacao
CREATE TABLE IF NOT EXISTS movimentacao (
    id INT AUTO_INCREMENT PRIMARY KEY,
    placa VARCHAR(255),
    duracao DECIMAL(10,2),
    tempo_cobrado DECIMAL(10,2),
    preco_total DECIMAL(10,2),
    data_entrada DATETIME DEFAULT CURRENT_TIMESTAMP,
    data_saida DATETIME,
    CONSTRAINT fk_movimentacao_veiculo FOREIGN KEY (placa)
        REFERENCES Veiculo(placa)
        ON DELETE CASCADE ON UPDATE CASCADE
) DEFAULT CHARSET = utf8mb4;

-- Índice na placa
CREATE INDEX idx_placa ON Veiculo(placa);

-- Consultas úteis
SELECT * FROM Estacionamento;
SELECT * FROM Veiculo;
SELECT * FROM tabela_preco;
SELECT * FROM movimentacao;

-- Consulta para buscar o valor vigente
SELECT valor_inicial, valor_adicional 
FROM tabela_preco 
WHERE CURDATE() BETWEEN inicio_vigencia AND IFNULL(fim_vigencia, CURDATE())
ORDER BY inicio_vigencia DESC
LIMIT 1;

ALTER TABLE tabela_preco DROP FOREIGN KEY fk_tabela_preco_estacionamento;
ALTER TABLE tabela_preco DROP COLUMN estacionamento_id;

ALTER TABLE tabela_preco
ADD UNIQUE KEY unique_periodo (data_inicio, data_fim);



