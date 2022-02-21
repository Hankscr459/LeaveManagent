using LeaveManagent.Data;
using LeaveManagent.Models;

namespace LeaveManagent.contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
    }
}
