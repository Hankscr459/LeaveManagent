using LeaveManagent.Data;
using LeaveManagent.Models;

namespace LeaveManagent.contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
    }
}
