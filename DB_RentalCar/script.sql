-- Tabela de clientes:
CREATE TABLE cliente (
	id_cliente INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    data_nasc DATE NOT NULL,
    cpf VARCHAR(11) NOT NULL
)

-- Tabela de Carros:
CREATE TABLE veiculo(
	placa VARCHAR(7) NOT NULL PRIMARY KEY,
    fabricante VARCHAR(30) NOT NULL,
    modelo VARCHAR(20) NOT NULL,
    ano INT NOT NULL,
    cor VARCHAR(20)
)

-- Tabela de locações que relaciona as duas anteriores (Cliente e Vículo)
CREATE TABLE locacao(
	nr_locacao INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    placa VARCHAR(7) NOT NULL,
    created_at datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
    	CONSTRAINT fk_locacao_veiculo FOREIGN KEY (placa) REFERENCES veiculo(placa),
     	CONSTRAINT fk_locacao_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
);