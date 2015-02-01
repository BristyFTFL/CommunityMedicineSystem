using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.DAL
{
    public class CenterDBGateway:CommonDBGateway
    {
        public List<Center> GetSelectedCenters(int thanaId)
        {
            List<Center> centerList = new List<Center>();
            string query = "SELECT * FROM tbl_center WHERE thana_id='" + thanaId + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();
            Center aCenter;

            while (ASqlDataReader.Read())
            {
                aCenter = new Center();
                aCenter.Id = (int)ASqlDataReader["id"];
                aCenter.Name = ASqlDataReader["name"].ToString();
                aCenter.DistrictId = (int)ASqlDataReader["district_id"];
                aCenter.ThanaId = (int)ASqlDataReader["thana_Id"];

                centerList.Add(aCenter);
            }

            ASqlDataReader.Close();
            ASqlCommand.Dispose();
            ASqlConnection.Close();

            return centerList;
        }

        public MedicineStockInCenter FindInCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            string query = "SELECT * FROM tbl_medicine_stock_center WHERE medicine_id = '" + aMedicineStockInCenter.MedicineId + "' AND center_id='" + aMedicineStockInCenter.CenterId + "'";
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlConnection.Open();
            ASqlDataReader = ASqlCommand.ExecuteReader();

            MedicineStockInCenter medicineStockInCenter;

            if (ASqlDataReader.HasRows)
            {
                medicineStockInCenter = new MedicineStockInCenter();
                ASqlDataReader.Read();
                medicineStockInCenter.Id = (int)ASqlDataReader["id"];
                medicineStockInCenter.CenterId = (int)ASqlDataReader["center_id"];
                medicineStockInCenter.MedicineId = (int)ASqlDataReader["medicine_id"];
                medicineStockInCenter.Quantity = (int)ASqlDataReader["quantity"];

                ASqlDataReader.Close();
                ASqlCommand.Dispose();
                ASqlConnection.Close();
                return medicineStockInCenter;
            }
            else
            {
                ASqlDataReader.Close();
                ASqlCommand.Dispose();
                ASqlConnection.Close();
                return null;
            }
        }
    }
}
