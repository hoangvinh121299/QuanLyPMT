using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using DTO;

namespace BUS
{
    public class Benh_BUS
    {
        Benh_DAL benhDAL = new Benh_DAL();
        public DataSet GetData()
        {
            return benhDAL.GetDataSetBenh();
        }
        public void addBenh(Benh benh)
        {
            benhDAL.AddBenh(benh);
        }
        public void updateBenh(Benh benh)
        {
            benhDAL.UpdateBenh(benh);
        }
        public void deleteBenh(Benh benh)
        {
            benhDAL.DeleteBenh(benh);
        }
        public DataSet searchBenh(String tenBenh)
        {
            return benhDAL.SearchBenh(tenBenh);
        }
    }
}
