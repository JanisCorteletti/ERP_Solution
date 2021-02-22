using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Solution.View
{
    public interface IEmployee
    {
        string IdEmployeeText { get; set; }
        string NameEmployeeText { get; set; }
        string EmailEmployeeText { get; set; }

        bool GenderEmployeeFemale { get; set; }
        bool GenderEmployeeMale { get; set; }
        bool StatusEmployeeActive { get; set; }
        bool StatusEmployeeInactive { get; set; }

        string Created_atEmployeeText { get; set; }
        string Updated_atEmployeeText { get; set; }

        string SearchIdEmployeeText { get; set; }
        string SearchNameEmployeeText { get; set; }
        string SearchEmailEmployeeText { get; set; }

        bool GenderEmployeeFemaleSearch { get; set; }
        bool GenderEmployeeMaleSearch { get; set; }

        bool StatusEmployeeActiveSearch { get; set; }
        bool StatusEmployeeInactiveSearch { get; set; }

        bool BtNewEmployeeEnable { get; set; }
        bool BtCreateEmployeeEnable { get; set; }
        bool BtUpdateEmployeeEnable { get; set; }
        bool BtDeleteEmployeeEnable { get; set; }

        string EmployeeTotalText { get; set; }
        string CurrentPageText { get; set; }
        string PagesTotalText { get; set; }

        bool BtFirstPageEnable { get; set; }
        bool BtPreviousPageEnable { get; set; }
        bool BtNextPageEnable { get; set; }
        bool BtLastPageEnable { get; set; }

        bool SelectionChanged { get; set; }

        object DataSourceGridEmployee { get; set; }
    }
}
