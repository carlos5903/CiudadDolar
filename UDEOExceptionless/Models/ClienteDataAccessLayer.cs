using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CiudadDollar.Models
{

    public class ClientDataAccessLayer
    {
        string connectionString = @"uid=sa;pwd=;
                            database=DBDollar;
                            server=CARLOSHP";        //To View all employees details    
        public IEnumerable<Cliente> GetAllClient()
        {
            List<Cliente> lstcliente = new List<Cliente>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.CLienteId = Convert.ToInt32(rdr["CLienteId"]);
                    cliente.Nombre = rdr["Nombre"].ToString();
                    cliente.Genero = rdr["Genero"].ToString();
                    cliente.Departamento = rdr["Departamenton"].ToString();
                    cliente.Ciudad = rdr["Ciudad"].ToString();
                    cliente.CLienteId = Convert.ToInt32(rdr["Tipodonacion"]);      
                    lstcliente.Add(cliente);
                }
                con.Close();
            }
            return lstcliente;
        }
        //To Add new employee record    
        public void AddEmployee(Cliente cLiente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", cLiente.Nombre);
                cmd.Parameters.AddWithValue("@Genero", cLiente.Genero);
                cmd.Parameters.AddWithValue("@Departamenton", cLiente.Departamento);
                cmd.Parameters.AddWithValue("@Ciudad", cLiente.Ciudad);
                cmd.Parameters.AddWithValue("@Tipodonacion", cLiente.Tipodonacion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar employee  
        public void UpdateCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLienteId", cliente.CLienteId);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Genero", cliente.Genero);
                cmd.Parameters.AddWithValue("@Departamenton", cliente.Departamento);
                cmd.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                cmd.Parameters.AddWithValue("@Tipodonacion", cliente.Tipodonacion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular employee  
        public Cliente GetClientData(int? id)
        {
            Cliente cliente = new Cliente();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM tblClient WHERE CLienteId= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cliente.CLienteId = Convert.ToInt32(rdr["CLienteId"]);
                    cliente.Nombre = rdr["Nombre"].ToString();
                    cliente.Genero = rdr["Genero"].ToString();
                    cliente.Departamento = rdr["Departamenton"].ToString();
                    cliente.Ciudad = rdr["Ciudad"].ToString();
                    cliente.CLienteId = Convert.ToInt32(rdr["Tipodonacion"]);
                }
            }
            return cliente;
        }
        //To Delete the record on a particular employee  
        public void DeleteClient(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLienteId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}