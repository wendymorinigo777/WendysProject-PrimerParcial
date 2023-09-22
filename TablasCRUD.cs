using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OPTATIVO_III
{
    public class CRUD
    {



//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~INICIO: TABLA - CIUDAD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public void Crear_Ciudad()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("--------Crear Ciudad--------");
            Console.WriteLine("\n");


            Console.WriteLine("Ingrese el nombre de su ciudad: ");
            string CiudadNombre = Console.ReadLine();

            Console.WriteLine("Ingrese su departamento: ");
            string Departamento = Console.ReadLine();

            Console.WriteLine("Ingrese su código postal: ");
            int PostalCode = int.Parse(Console.ReadLine());

            string insertQuery = "INSERT INTO Ciudad (CiudadNombre, Departamento, PostalCode) VALUES('" + CiudadNombre + "','" + Departamento + "'," + PostalCode + ")";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Datos almacenados exitosamente");
    
        }

        public void lista()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            // if (lista_vacia()==true)
            //{
            //Console.WriteLine("No se ha almacenado ningún dato en la lista ");
            //}
            //else
            //{
            //Retrieve
            string displayQuery = "SELECT * FROM Ciudad";
            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataReader dataReader = viewCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("ID: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("Nombre: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Departamento: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Codigo Postal: " + dataReader.GetValue(4).ToString());
            }
            dataReader.Close();

        }

        public void imprimir()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            int u_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea visualizar");
            u_id = int.Parse(Console.ReadLine());
            string dissplayQuery = "SELECT * FROM Ciudad WHERE idCiudad = " + u_id + "";
            SqlCommand updateCommand = new SqlCommand(dissplayQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Entregado con éxito");

        }

        public void Eliminar()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //delete
            int d_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea eliminar");
            d_id = int.Parse(Console.ReadLine());
            string deleteQuery = "DELETE FROM Ciudad WHERE idCiudad = " + d_id + "";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Eliminado con éxito");

        }

        public void Modificar()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //update
            string up_name;
            int up_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea actualizar");
            up_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre que desea cambiar");
            up_name = Console.ReadLine();
            string updateQuery = "UPDATE Ciudad SET CiudadNombre = '" + up_name + "' WHERE idCiudad = " + up_id + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Actualización exitosa ");

 
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~FIN: TABLA - CIUDAD~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~INICIO: TABLA - PERSONA~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        public void Crear_Persona()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("--------Crear Persona--------");
            Console.WriteLine("\n");


            Console.WriteLine("Ingrese el nombre de la persona: ");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido: ");
            string Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el ID de su Ciudad: ");
            int idCiudad = int.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de Documento: ");
            string TipoDocumento = Console.ReadLine();

            Console.WriteLine("Numero de Documento: ");
            string NroDocumento = Console.ReadLine();

            Console.WriteLine("Dirección de Residencia: ");
            string Direccion = Console.ReadLine();

            Console.WriteLine("Teléfono: ");
            string Telefono = Console.ReadLine();

            Console.WriteLine("Correo electronico: ");
            string Correo electronico = Console.ReadLine();

            Console.WriteLine("Estado: ");
            string Estado = Console.ReadLine();

            string insertQuery = "INSERT INTO Persona (idCiudad, Nombre, Apellido, TipoDocumento, NroDocumento, Direccion, Telefono, Correo electronico, Estado) VALUES(" + idCiudad + ",'" + Nombre + "','" + Apellido + "','" + TipoDocumento + "','" + NroDocumento + "','" + Direccion + "','" + Telefono + "','" + Correo electronico + "','" + Estado + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Datos almacenados exitosamente");

        }

        public void lista_Persona()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string displayQuery = "SELECT * FROM Persona";
            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataReader dataReader = viewCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("ID: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("ID Ciudad: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Nombre: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Apellido: " + dataReader.GetValue(4).ToString());
                Console.WriteLine("Tipo de Documento: " + dataReader.GetValue(5).ToString());
                Console.WriteLine("Número de Documento: " + dataReader.GetValue(6).ToString());
                Console.WriteLine("Direccion: " + dataReader.GetValue(7).ToString());
                Console.WriteLine("Teléfono: " + dataReader.GetValue(8).ToString());
                Console.WriteLine("Correo electronico: " + dataReader.GetValue(9).ToString());
                Console.WriteLine("Estado: " + dataReader.GetValue(10).ToString());

            }
            dataReader.Close();

        }

        public void imprimir_Persona()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            int u_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea visualizar");
            u_id = int.Parse(Console.ReadLine());
            string dissplayQuery = "SELECT * FROM Persona WHERE idPersona = " + u_id + "";
            SqlCommand updateCommand = new SqlCommand(dissplayQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Entregado con éxito");

        }

        public void Eliminar_Persona()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //delete
            int d_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea eliminar");
            d_id = int.Parse(Console.ReadLine());
            string deleteQuery = "DELETE FROM Persona WHERE idPersona = " + d_id + "";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Eliminado con éxito");

        }

        public void Modificar_Persona()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //update
            int up_id;
            string up_name;
            string up_apellido;
            int up_idciudad;
            string up_tipodc;
            string up_nro_dc;
            string up_direc;
            string up_tel;
            string up_Correo electronico;
            string up_estado;
            Console.WriteLine("Introduzca el identificador de la entrada que desea actualizar: ");
            up_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre que desea cambiar: ");
            up_name = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            up_apellido = Console.ReadLine();
            Console.WriteLine("Nuevo ID Ciudad: ");
            up_idciudad = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de Documento: ");
            up_tipodc = Console.ReadLine();
            Console.WriteLine("Nro de Documento: ");
            up_nro_dc = Console.ReadLine();
            Console.WriteLine("Direccion");
            up_direc = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            up_tel = Console.ReadLine();
            Console.WriteLine("Correo electronico: ");
            up_Correo electronico = Console.ReadLine();
            Console.WriteLine("Estado: ");
            up_estado = Console.ReadLine();
            string updateQuery = "UPDATE Ciudad SET idCiudad = " + up_idciudad + ",Nombre = '" + up_name + "',Apellido = '" + up_apellido + "',TipoDocumento = '" + up_tipodc + "',NroDocumento = '" + up_nro_dc + "',Direccion = '" + up_direc + "',Telefono = '" + up_tel + "',Correo electronico = '" + up_Correo electronico + "',Estado = '" + up_estado + "' WHERE idPersona = " + up_id + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Actualización exitosa ");


        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~FIN: TABLA - PERSONA~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~INICIO: TABLA CLIENTE~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        public void Crear_Cliente()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("--------Crear Cliente--------");
            Console.WriteLine("\n");


            Console.WriteLine("Ingrese el ID Persona del Cliente: ");
            int idPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("Calficacion: ");
            string Calificacion = Console.ReadLine();


            string insertQuery = "INSERT INTO Cliente (idPersona, Calificacion, Estado) VALUES(" + idPersona + ",'" + Calificacion + "',(Select estado from Persona a where idPersona = " + idPersona + "))";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Datos almacenados exitosamente");

        }

        public void lista_Cliente()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string displayQuery = "SELECT * FROM Cliente";
            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataReader dataReader = viewCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("ID: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("ID Persona: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Fecha de Ingreso: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Calificacion: " + dataReader.GetValue(4).ToString());
                Console.WriteLine("Estado: " + dataReader.GetValue(5).ToString());

            }
            dataReader.Close();

        }

        public void imprimir_Cliente()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            int u_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea visualizar");
            u_id = int.Parse(Console.ReadLine());
            string dissplayQuery = "SELECT * FROM Cliente WHERE idCliente = " + u_id + "";
            SqlCommand updateCommand = new SqlCommand(dissplayQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Entregado con éxito");

        }

        public void Eliminar_Cliente()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //delete
            int d_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea eliminar");
            d_id = int.Parse(Console.ReadLine());
            string deleteQuery = "DELETE FROM Cliente WHERE idCliente = " + d_id + "";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Eliminado con éxito");

        }

        public void Modificar_Cliente()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //update
            int up_id;
            int up_idp;
            string up_calif;
            string up_estado;
 
            Console.WriteLine("Introduzca el identificador de la entrada que desea actualizar: ");
            up_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Id Persona: ");
            up_idp = int.Parse(Console.ReadLine());
            Console.WriteLine("Calificacion: ");
            up_calif = Console.ReadLine();
            Console.WriteLine("Estado: ");
            up_estado = Console.ReadLine();
            string updateQuery = "UPDATE Cliente SET idPersona = " + up_idp + ",Calificacion = '" + up_calif + "',Estado = '" + up_estado + "' WHERE idPersona = " + up_id + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Actualización exitosa ");


        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~FIN: TABLA - CLIENTE~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~INICIO: TABLA - CUENTAS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        public void Crear_Cuenta()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("--------Crear Cuenta--------");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el ID del Cliente: ");
            int idCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de cuenta: ");
            string NroCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de cuenta: ");
            string TipoCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el estado de la cuenta: ");
            string Estado = Console.ReadLine();

            Console.WriteLine("Ingrese el Saldo: ");
            decimal Saldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Numero de Contrato: ");
            string Nro_Contrato = Console.ReadLine();

            Console.WriteLine("Ingrese el Costo de Mantenimiento: ");
            decimal CostoMantenimiento = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Promedio Acreditacion: ");
            string PromedioAcreditacion = Console.ReadLine();

            Console.WriteLine("Moneda: ");
            string Moneda = Console.ReadLine();

            string insertQuery = "INSERT INTO Cuentas (idCliente, NroCuenta, TipoCuenta, Estado, Saldo, Nro_Contrato, CostoMantenimiento, PromedioAcreditacion, Moneda) VALUES(" + idCliente + ",'" + NroCuenta + "','" + TipoCuenta + "','" + Estado + "'," + Saldo + ",'" + Nro_Contrato + "'," + CostoMantenimiento + ",'" + PromedioAcreditacion + "','" + Moneda + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Datos almacenados exitosamente");

        }

        public void lista_Cuenta()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string displayQuery = "SELECT * FROM Cuentas";
            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataReader dataReader = viewCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("ID: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("ID Cliente: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Número de Cuenta: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Fecha Alta: " + dataReader.GetValue(4).ToString());
                Console.WriteLine("Tipo de Cuenta: " + dataReader.GetValue(5).ToString());
                Console.WriteLine("Estado: " + dataReader.GetValue(6).ToString());
                Console.WriteLine("Saldo: " + dataReader.GetValue(7).ToString());
                Console.WriteLine("Número de Contrato: " + dataReader.GetValue(8).ToString());
                Console.WriteLine("Costo de Mantenimiento: " + dataReader.GetValue(9).ToString());
                Console.WriteLine("Promedio de Acreditación: " + dataReader.GetValue(10).ToString());
                Console.WriteLine("Moneda: " + dataReader.GetValue(11).ToString());


            }
            dataReader.Close();

        }

        public void imprimir_Cuenta()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            int u_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea visualizar");
            u_id = int.Parse(Console.ReadLine());
            string dissplayQuery = "SELECT * FROM Cuentas WHERE idCuenta = " + u_id + "";
            SqlCommand updateCommand = new SqlCommand(dissplayQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Entregado con éxito");

        }

        public void Eliminar_Cuenta()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //delete
            int d_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea eliminar");
            d_id = int.Parse(Console.ReadLine());
            string deleteQuery = "DELETE FROM Cuentas WHERE idCuenta = " + d_id + "";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Eliminado con éxito");

        }

        public void Modificar_Cuenta()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //update
            int up_id;
            int up_idc;
            string up_nrocuenta;
            string up_tipocuenta;
            string up_estado;
            decimal up_saldo;
            string up_nro_con;
            decimal up_costo;
            string up_prom;
            string up_moneda;
            Console.WriteLine("Introduzca el identificador de la entrada que desea actualizar: ");
            up_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Id cliente nuevo: ");
            up_idc = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de Cuenta: ");
            up_nrocuenta = Console.ReadLine();
            Console.WriteLine("Tipo de Cuenta: ");
            up_tipocuenta = Console.ReadLine();
            Console.WriteLine("Estado: ");
            up_estado = Console.ReadLine();
            Console.WriteLine("Saldo: ");
            up_saldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Numero de Contrato");
            up_nro_con = Console.ReadLine();
            Console.WriteLine("Costo de Mantenimiento: ");
            up_costo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Promedio de Acreditacion: ");
            up_prom = Console.ReadLine();
            Console.WriteLine("Moenda: ");
            up_moneda = Console.ReadLine();
            string updateQuery = "UPDATE Cuentas SET idCliente = " + up_idc + ",NroCuenta = '" + up_nrocuenta + "',TipoCuenta = '" + up_tipocuenta + "',Estado = '" + up_estado + "',Saldo = " + up_saldo + ",Nro_Contrato = '" + up_nro_con + "',CostoMantenimiento = " + up_costo + ",PromedioAcreditacion = '" + up_prom + "',Moneda = '" + up_moneda + "' WHERE idCuenta = " + up_id + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Actualización exitosa ");


        }



        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~FIN: TABLA - CUENTAS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~INICIO:TABLA - MOVIMIENTOS~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//

        public void Crear_Movimiento()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("--------Crear Movimiento--------");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el ID de la Cuenta: ");
            int idCuenta = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de movimiento: ");
            string TipoMovimiento = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de cuenta: ");
            string TipoCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el Saldo Anterior: ");
            decimal SaldoAnterior = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Saldo Actual: ");
            decimal SaldoActual = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Monto del Movimiento: ");
            decimal MontoMovimiento = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cuenta de origen: ");
            decimal CuentaOrigen = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cuenta destino: ");
            decimal CuentaDestino = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Canal: ");
            decimal Canal = decimal.Parse(Console.ReadLine());

            string insertQuery = "INSERT INTO Movimientos (idCuenta, TipoMovimiento, SaldoAnterior, SaldoActual, MontoMovimiento, CuentaOrigen, CuentaDestino, Canal) VALUES(" + idCuenta + ",'" + TipoMovimiento + "'," + SaldoAnterior + "," + SaldoActual + "," + MontoMovimiento + "," + CuentaOrigen + "," + CuentaDestino + "," + Canal + ")";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Datos almacenados exitosamente");

        }

        public void lista_Movimiento()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string displayQuery = "SELECT * FROM Movimientos";
            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataReader dataReader = viewCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("ID: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("ID Cuenta: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Fecha de Movimiento: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Tipo de Movimiento: " + dataReader.GetValue(4).ToString());
                Console.WriteLine("Saldo Anterior: " + dataReader.GetValue(5).ToString());
                Console.WriteLine("Saldo Actual: " + dataReader.GetValue(6).ToString());
                Console.WriteLine("Monto del Movimiento: " + dataReader.GetValue(7).ToString());
                Console.WriteLine("Cuenta Origen: " + dataReader.GetValue(8).ToString());
                Console.WriteLine("Cuenta Destino: " + dataReader.GetValue(9).ToString());
                Console.WriteLine("Canal: " + dataReader.GetValue(10).ToString());


            }
            dataReader.Close();

        }

        public void imprimir_Movimiento()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            int u_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea visualizar");
            u_id = int.Parse(Console.ReadLine());
            string dissplayQuery = "SELECT * FROM Movimientos WHERE idMovimiento = " + u_id + "";
            SqlCommand updateCommand = new SqlCommand(dissplayQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Entregado con éxito");

        }

        public void Eliminar_Movimiento()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //delete
            int d_id;
            Console.WriteLine("Introduzca el identificador de la entrada que desea eliminar");
            d_id = int.Parse(Console.ReadLine());
            string deleteQuery = "DELETE FROM Movimientos WHERE idMovimiento = " + d_id + "";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Eliminado con éxito");

        }

        public void Modificar_Movimiento()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WendysProject;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //update
            int up_id;
            int up_idc;
            string up_tipomov;
            decimal up_saldoant;
            decimal up_saldoact;
            decimal up_montomov;
            decimal up_cuentaorg;
            decimal up_cuentades;
            decimal up_canal;

            Console.WriteLine("Introduzca el identificador de la entrada que desea actualizar: ");
            up_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Id cuenta nuevo: ");
            up_idc = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo Movimiento: ");
            up_tipomov = Console.ReadLine();
            Console.WriteLine("Saldo Anterior: ");
            up_saldoant = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Saldo Actual: ");
            up_saldoact = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Monto Movimiento: ");
            up_montomov = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Cuenta Origen");
            up_cuentaorg = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Cuenta Destino: ");
            up_cuentades = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Canal: ");
            up_canal = decimal.Parse(Console.ReadLine());

            string updateQuery = "UPDATE Movimientos SET idCuenta = " + up_idc + ",TipoMovimiento = '" + up_tipomov + "',SaldoAnterior = " + up_saldoant + ",SaldoActual = " + up_saldoact + ",MontoMovimiento = " + up_montomov + ",CuentaOrigen = " + up_cuentaorg + ",CuentaDestino = " + up_cuentades + ",Canal = " + up_canal + " WHERE idMovimiento = " + up_id + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Actualización exitosa ");


        }

    }
}
