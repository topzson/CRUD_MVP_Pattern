using CRUD_TEST.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_TEST.Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
       

        public PetRepository(string connenctionString) { 
            this.connenctionString = connenctionString;
        }

        public void Add(PetModel petModel)
        {
            using (var connection = new SqlConnection(connenctionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Pet values (@name,@type,@color)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petModel.Name;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = petModel.Type;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = petModel.Color;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connenctionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Pet where Pet_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                command.ExecuteNonQuery();
            }
        }
        public void Edit(PetModel petModel)
        {
            using (var connection = new SqlConnection(connenctionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Pet 
                                        set Pet_Name=@name,Pet_Type=@type,Pet_Colour=@color where Pet_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petModel.Name;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = petModel.Type;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = petModel.Color;
                command.Parameters.Add("@id", SqlDbType.Int).Value = petModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PetModel> GetAll()
        {
           var petList = new List<PetModel>();
           using (var connection = new SqlConnection(connenctionString))
           using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from curd_mvp.dbo.Pet 
                                        order by Pet_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Color = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string petName = value;
            
            using (var connection = new SqlConnection(connenctionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;
                command.CommandText = @"Select *from curd_mvp.dbo.Pet where Pet_Name like @name+'%' order by Pet_Id desc";
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var petModel = new PetModel();
                        petModel.Id = (int)reader[0];
                        petModel.Name = reader[1].ToString();
                        petModel.Type = reader[2].ToString();
                        petModel.Color = reader[3].ToString();
                        petList.Add(petModel);
                    }
                }
            }
            return petList;
        }
    }
}
