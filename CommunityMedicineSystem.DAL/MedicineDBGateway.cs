using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class MedicineDBGateway:CommonDBGateway
    {
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicineList = new List<Medicine>();
            string query = "SELECT * FROM tbl_medicine";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();
            Medicine aMedicine;

            while (ASqlDataReader.Read())
            {
                aMedicine = new Medicine();
                aMedicine.Id = (int)ASqlDataReader["id"];
                aMedicine.Name = ASqlDataReader["name"].ToString();
                aMedicine.Power = Convert.ToDecimal(ASqlDataReader["power"]);
                aMedicine.Type = ASqlDataReader["type"].ToString();

                medicineList.Add(aMedicine);
            }

            ASqlDataReader.Close();
            ASqlCommand.Dispose();
            ASqlConnection.Close();
            return medicineList;
        }

        public Medicine Find(string name)
        {
            string query = "SELECT * FROM tbl_medicine WHERE name='" + name + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();
            Medicine aMedicine;

            if (ASqlDataReader.HasRows)
            {
                aMedicine = new Medicine();
                ASqlDataReader.Read();
                aMedicine.Id = (int)ASqlDataReader["id"];
                aMedicine.Name = ASqlDataReader["name"].ToString();
                aMedicine.Power = Convert.ToDecimal(ASqlDataReader["power"]);
                aMedicine.Type = ASqlDataReader["type"].ToString();

                ASqlDataReader.Close();
                ASqlCommand.Dispose();
                ASqlConnection.Close();
                return aMedicine;
            }
            else
            {
                ASqlDataReader.Close();
                ASqlCommand.Dispose();
                ASqlConnection.Close();
                return null;
            }
        }

        public void InsertInCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            string query = "INSERT INTO tbl_medicine_stock_center VALUES('" + aMedicineStockInCenter.CenterId + "', '" + aMedicineStockInCenter.MedicineId + "', '" + aMedicineStockInCenter.Quantity + "')";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);

            ASqlCommand.ExecuteNonQuery();
            ASqlCommand.Dispose();
            ASqlConnection.Close();
        }

        public void UpdateInCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            string query = "UPDATE tbl_medicine_stock_center SET quantity +='" + aMedicineStockInCenter.Quantity + "' WHERE id='" + aMedicineStockInCenter.Id + "'";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);

            ASqlCommand.ExecuteNonQuery();
            ASqlCommand.Dispose();
            ASqlConnection.Close();
        }
    }
}
