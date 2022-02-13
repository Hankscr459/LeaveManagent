using LeaveManagent.contracts;
using LeaveManagent.Data;

namespace LeaveManagent.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
