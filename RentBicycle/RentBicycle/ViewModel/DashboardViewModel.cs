using RentBicycle.Model;
using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace RentBicycle.ViewModel
{
    class DashboardViewModel
    {
        private RentBicycleEntities _database;

        public DashboardViewModel() => _database = new RentBicycleEntities();


        public void Load(Chart chartNumber, Chart chartSalaryMonth)
        {
            int year = DateTime.Now.Year;

            chartSalaryMonth.DataSource = _database.usp_SelectMonthTotalByOrders1(year).ToList();
           
            ObjectResult<usp_SelectProductIdQuanityByYear2_Result> proIdQuantityInYearNow = _database.usp_SelectProductIdQuanityByYear2(year);

            proIdQuantityInYearNow.ToList().ForEach(x => chartNumber.Series["Number"].Points.AddXY("Product Id " + x.ProductId, x.Quantity));

            chartSalaryMonth.Series["Revenue"].XValueMember = "Month";
            chartSalaryMonth.Series["Revenue"].XValueType = ChartValueType.Int32;
            chartSalaryMonth.Series["Revenue"].YValueMembers = "Total";
            chartSalaryMonth.Series["Revenue"].YValueType = ChartValueType.Double;
        }


    }
}
