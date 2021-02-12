Create database DBVehiculos;
GO

use DBVehiculos
CREATE TABLE TBL_Sucursales (
    NumeroSucursal VARCHAR(10) Not null PRIMARY KEY,
    CalleSucursal VARCHAR (20),
    NumeroCalleSucursal VARCHAR (10),
    ColoniaSucursal VARCHAR (10),
    EstadoSucursal VARCHAR (15)
);




CREATE TABLE TBL_Clientes(
 
    IDCliente varchar(5), 
    nombre varchar(50) not null, 
    apellidoP varchar(100) not null,
    apellidoM varchar(100) not null,
    RFC VARCHAR (20) not NULL PRIMARY key ,
    celular VARCHAR (15),
    correo varchar(20) not null,
    NumeroSucursal VARCHAR (10),
    CONSTRAINT fk_NumeroSucursal FOREIGN KEY (NumeroSucursal) REFERENCES TBL_Sucursales (NumeroSucursal)
);


CREATE TABLE  TBL_DetalleVenta(

    IDDetalleVenta VARCHAR (10) not NULL PRIMARY KEY,
    NumeroSerie VARCHAR (10),
    Cantidad VARCHAR (100),
    RFC VARCHAR (20),
    fecha VARCHAR (20),

    CONSTRAINT fk_RFC FOREIGN KEY (RFC) REFERENCES TBL_Clientes (RFC)


);

CREATE TABLE  TBL_vehiculos(
    NumeroSerie VARCHAR (50) not NULL PRIMARY KEY,
    Cilindros VARCHAR (10),
    Color VARCHAR (50),
    NumeroEjes VARCHAR (20),
    Estatus VARCHAR (10)
);


CREATE TABLE TBL_Facturacion(
    FolioFactura VARCHAR (50) not NULL PRIMARY KEY,
    IDDetalleVenta VARCHAR (10),
    Fecha VARCHAR (20),
    CONSTRAINT fk_IDDetalleVenta FOREIGN KEY (IDDetalleVenta) REFERENCES TBL_DetalleVenta (IDDetalleVenta)
);

go



-- procedimientosAlmacenados

create procedure proc_insertarTBVL
    
	@NumeroSerie varchar(50), 
    @Cilindros varchar(10),
    @Color varchar(50), 
    @NumeroEjes varchar(20), 
    @Estatus varchar(10)

as
begin
    insert into TBL_vehiculos values (@NumeroSerie, @Cilindros, @Color,@NumeroEjes, @Estatus)
end
go


create procedure proc_actualizarTBVL
    @NumeroSerie varchar(50), 
    @Cilindros varchar(10),
    @Color varchar(50), 
    @NumeroEjes varchar(20), 
    @Estatus varchar(10)
as
begin
    update TBL_vehiculos set  NumeroSerie=@NumeroSerie, Cilindros=@Cilindros, Color=@Color
    where NumeroSerie=@NumeroSerie
 end
go


create procedure proc_consultar
@NumeroSerie varchar(5)
as
begin
    select NumeroSerie, Cilindros, Color, NumeroEjes,Estatus from TBL_vehiculos
    where NumeroSerie = @NumeroSerie
end
go

create procedure proc_listar
as
begin
	select NumeroSerie, Cilindros, Color, NumeroEjes,Estatus from TBL_vehiculos order by 1

end
go

alter procedure proc_eliminar
@NumeroSerie varchar(5)
as
begin
delete from  TBL_vehiculos where NumeroSerie = @NumeroSerie
end