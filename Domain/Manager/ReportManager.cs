using DataAccessLayer;
using DataAccessLayer.DTOs;
using Domain.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Manager
{
    public class ReportManager
    {
        private ReportsDataAccess reportsDataAccess;
        private EmployeeDatabase employeeDataAccess;
        public ReportManager()
        {
            reportsDataAccess = new ReportsDataAccess();
            employeeDataAccess = new EmployeeDatabase();
        }

        /*public void CreateReport(string title, ReportCategory category, string description, Employee createdBy)
        {
            reportsDataAccess.CreateReport(title, category, description, createdBy);
        }

        public List<Report> GetAllReports()
        {
            List<ReportDTO> reportDTOs = reportsDataAccess.GetAllReports();
            List<Report> reports = new List<Report>();

            foreach (var reportDTO in reportDTOs)
            {
                EmployeeDTO createdByDTO = employeeDataAccess.GetEmployeeById(reportDTO.CreatedBy);
                Employee createdBy = EmployeeMapper.MapToEntity(createdByDTO);
                Report report = ReportMapper.MapFromDTO(reportDTO, createdBy);
                reports.Add(report);
            }

            return reports;
        }

        public List<Report> GetReportsByCategory(ReportCategory category)
        {
            List<ReportDTO> reportDTOs = reportsDataAccess.GetReportsByCategory(category.ToString());
            List<Report> reports = new List<Report>();

            foreach (var reportDTO in reportDTOs)
            {
                EmployeeDTO createdByDTO = employeeDataAccess.GetEmployeeById(reportDTO.CreatedBy);
                Employee createdBy = EmployeeMapper.MapToEntity(createdByDTO);
                Report report = ReportMapper.MapFromDTO(reportDTO, createdBy);
                reports.Add(report);
            }

            return reports;
        }

        public Report GetReportById(int id)
        {
            ReportDTO reportDTO = reportsDataAccess.GetReportById(id);
            if (reportDTO == null)
                return null;

            EmployeeDTO createdByDTO = employeeDataAccess.GetEmployeeById(reportDTO.CreatedBy);
            Employee createdBy = EmployeeMapper.MapToEntity(createdByDTO);
            Report report = ReportMapper.MapFromDTO(reportDTO, createdBy);
            return report;
        }*/
    }
}
