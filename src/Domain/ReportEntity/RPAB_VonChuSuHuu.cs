using Domain.Common;
using Domain.ReportEntity.ReportAccountingBalance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ReportEntity
{
    public class RPAB_VonChuSoHuu : BaseEntity
    {

        public Criteria_VonVaCacQuy VonVaCacQuy { get; set; } 
        public Criteria_NguonKinhPhiVanQuyKhac NguonKinhPhiVanQuyKhac { get; set; } 

        public float TongCong { get; set; }
    }
}
