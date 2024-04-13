using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Entity;
using ToDoList.Domain.Filters.Task;
using ToDoList.Domain.Response;
using ToDoList.Domain.ViewModels;

namespace ToDoList.Service.Interfaces
{
    public interface ITaskService
    {
        Task<IBaseResponse<IEnumerable<TaskViewModel>>> CalculateCompletedTask();

        Task<IBaseResponse<IEnumerable<TaskCompletedViewModels>>> GetCompletedTasks();
        
        Task<IBaseResponse<TaskEntity>> Create(CreateTaskViewModel model);

        Task<IBaseResponse<bool>> EndTask(long id);

        Task<IBaseResponse<IEnumerable<TaskViewModel>>> GetTasks(TaskFilter filter);
    }
}
