using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REDMIS.Models
{
    public class OldProjectReport
    {
        public string Division_Name { get; set; }
        public string Program_Name { get; set; }
        public string Work_Type_Name { get; set; }
        public string VikasKhand { get; set; }
        public int WorkId { get; set; }
        public int ZoneId { get; set; }
        public int CircleId { get; set; }
        public string Work_NameUnicode { get; set; }
        public string Work_Name { get; set; }
        public decimal Length_QTY { get; set; }
        public decimal Pulia_QTY { get; set; }
        public int ProgramId { get; set; }
        public int DistrictId { get; set; }
        public int WorkTypeId { get; set; }
        public string Sanctioned_Date { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public decimal Sanctioned_Amount { get; set; }
        public decimal FromCost { get; set; }
        public decimal ToCost { get; set; }
        public string Start_Date { get; set; }
        public string Target_Date { get; set; }
        public string Expected_End_Date { get; set; }
        public string Actual_End_Date { get; set; }
        public string Handover_Date { get; set; }
        public string Work_Status { get; set; }
        public decimal mitti { get; set; }
        public decimal puliya { get; set; }
        public decimal g1 { get; set; }
        public decimal g2 { get; set; }
        public decimal g3 { get; set; }
        public decimal lepan { get; set; }
        public decimal khadanja { get; set; }
        public int VikashkhandId { get; set; }
        public int OldID { get; set; }
        public string TransDate { get; set; }
        public string Scheme_Name { get; set; }
        public string Block_Name { get; set; }
        public decimal Estimated_Cost { get; set; }
        public string Sanctioned_LNo { get; set; }
        public decimal Release_Amount { get; set; }
        public string Release_Amount_Date { get; set; }
        public string Release_Amount_LNo { get; set; }
        public string Remark { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string District { get; set; }
        public string Vidhan_Sabha { get; set; }
        public string CMISProjectCode { get; set; }
        public int DepartmentId { get; set; }
        public int ProcId { get; set; }
        public int YearName { get; set; }
        public string MonthName { get; set; }
        public string DepartmentName { get; set; }
        public decimal Available_Amount { get; set; }
        public string RoadStatus { get; set; }
        public string PuliaStatus { get; set; }
        public string BuildingStatus { get; set; }
        public decimal PhysicalProgress { get; set; }
        public decimal Expenses { get; set; }
        public int UserTypeId { get; set; }

    }
}