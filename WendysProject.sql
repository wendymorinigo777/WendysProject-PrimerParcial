USE WendysProject

--Tabla Ciudad
CREATE TABLE dbo.Ciudad (
    idCiudad INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    CiudadNombre VARCHAR(50) NOT NULL,
    Departamento VARCHAR(50) NOT NULL,
    PostalCode INT NOT NULL
);
--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--
--Tabla Persona
CREATE TABLE dbo.Persona (
    idPersona INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idCiudad INT FOREIGN KEY REFERENCES Ciudad(idCiudad) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
	TipoDocumento VARCHAR(10) NOT NULL,
	NroDocumento VARCHAR(10) NOT NULL,
	Direccion VARCHAR(75) NOT NULL,
	Telefono VARCHAR(15) NULL,
	Email VARCHAR(25) NULL,
	Estado VARCHAR(20) NULL
);
--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--
--Tabla Cliente
CREATE TABLE dbo.Cliente (
    idCliente INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idPersona INT FOREIGN KEY REFERENCES Persona(idPersona) NOT NULL,
    FechaIngreso DATETIME NOT NULL DEFAULT(getdate()),
	Calificacion VARCHAR(20) NOT NULL,
	Estado VARCHAR(20) NULL
);
--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--
--Tabla Cuentas
CREATE TABLE dbo.Cuentas(
    idCuenta INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idCliente INT FOREIGN KEY REFERENCES Cliente(idCliente) NOT NULL,
	NroCuenta VARCHAR(50) NOT NULL,
	FechaAlta DATETIME NOT NULL DEFAULT(getdate()),
	TipoCuenta VARCHAR(50) NOT NULL,
	Estado VARCHAR(50) NOT NULL,
    Saldo DECIMAL(10,2) NOT NULL,
	Nro_Contrato VARCHAR(50) NOT NULL,
	CostoMantenimiento DECIMAL(10,2) NOT NULL,
	PromedioAcreditacion VARCHAR(50) NOT NULL,
	Moneda VARCHAR(50) NOT NULL,
);
--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--
--Tabla Movimientos
CREATE TABLE dbo.Movimientos(
    idMovimiento INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    idCuenta INT FOREIGN KEY REFERENCES Cuentas(idCuenta) NOT NULL,
	Fecha_Movimiento DATETIME NOT NULL DEFAULT(getdate()),
	TipoMovimiento VARCHAR(50) NOT NULL,
    SaldoAnterior DECIMAL(10,2) NOT NULL,
	SaldoActual DECIMAL(10,2) NOT NULL,
	MontoMovimiento DECIMAL(10,2) NOT NULL,
	CuentaOrigen DECIMAL(10,2) NOT NULL,
	CuentaDestino DECIMAL(10,2) NOT NULL,
	Canal DECIMAL(10,2) NOT NULL,
);

--~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~--
