INSERT INTO `clientes` (`nombre`, `apellido`, `foto`) VALUES ('Luis', 'Garcia', 'Foto');
UPDATE `clientes` SET `nombre`='Luis Alberto', `apellido`='Garcia Ospina', `foto`='Foto1' WHERE  `id`=1;
DELETE FROM `clientes` WHERE  `id`=1;
SELECT * FROM `clientes` LIMIT 1000;