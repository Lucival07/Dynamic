1- Baixar Maria DB e instalar não selecionar nenhuma opção,  usuario: root e senha: root </br>
2- Intalar o conector para acessar o banco https://mariadb.com/downloads/connectors/  <<< mudar so o OS para Win 10 e baixar</br>
3- Depois de instalado abri HeidiSQL e Cria um banco de dados chamado mechanics com colação utf8mb4_swedish_ci </br>
4- Execultar o Script abaixo </br>

CREATE TABLE `test` (
	`id` INT(11) NOT NULL AUTO_INCREMENT,
	`nome` VARCHAR(200) NOT NULL COLLATE 'utf8mb4_swedish_ci',
	INDEX `id` (`id`) USING BTREE
)
COLLATE='utf8mb4_swedish_ci'
ENGINE=InnoDB
AUTO_INCREMENT=6;

 </br>
  </br>

5- Execultar o projeto no visual studio e acessar a pagina https://localhost:44390/test </br>
