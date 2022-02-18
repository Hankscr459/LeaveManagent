using LeaveManagent.Constants;
using LeaveManagent.contracts;
using LeaveManagent.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagent.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManger;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public LeaveAllocationRepository(ApplicationDbContext context,
            UserManager<Employee> userManger, ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            this.context = context;
            this.userManger = userManger;
            this.leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId
                                                                 && q.LeaveTypeId == leaveTypeId
                                                                 && q.Period == period);
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManger.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;
                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType!.DefaultDays
                });
            }
            await AddRangeAsync(allocations);
        }
    }
}
