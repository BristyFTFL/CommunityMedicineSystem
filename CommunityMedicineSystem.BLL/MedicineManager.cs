using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class MedicineManager
    {
        MedicineDBGateway aMedicineDBGateway = new MedicineDBGateway();
        CenterDBGateway aCenterGateway = new CenterDBGateway();

        public List<Medicine> GetAllMedicines()
        {
            return aMedicineDBGateway.GetAllMedicines();
        }

        public Medicine Find(string name)
        {
            return aMedicineDBGateway.Find(name);
        }

        public string SendMedicineToCenter(MedicineStockInCenter aMedicineStockInCenter)
        {
            if (aMedicineStockInCenter.CenterId != 0)
            {
                MedicineStockInCenter medicineStockInCenter = aCenterGateway.FindInCenter(aMedicineStockInCenter);

                if (medicineStockInCenter == null)
                {
                    aMedicineDBGateway.InsertInCenter(aMedicineStockInCenter);
                    return "Success.";
                }
                else
                {
                    medicineStockInCenter.Quantity = aMedicineStockInCenter.Quantity;
                    aMedicineDBGateway.UpdateInCenter(medicineStockInCenter);
                    return "Succes.";
                }
            }
            else
            {
                return "Failed";
            }
        }
    }
}
