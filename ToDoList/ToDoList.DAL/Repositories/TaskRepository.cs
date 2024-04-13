using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DAL.Interfaces;
using ToDoList.Domain.Entity;

namespace ToDoList.DAL.Repositories
{
    public class TaskRepository : IBaseRepository<TaskEntity>
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger<TaskRepository> _logger;

        public TaskRepository(AppDbContext appDbContext, ILogger<TaskRepository> logger)
        {
            _appDbContext = appDbContext;
            _logger = logger;
        }
        public async Task Create(TaskEntity entity)
        {
            await _appDbContext.Tasks.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
        }

 

        public IQueryable<TaskEntity> GetAll()
        {
            var tasks = _appDbContext.Tasks;
            _logger.LogInformation($"Retrieved {tasks.Count()} tasks from the database");
            return tasks;
        }

        public async Task Delete(TaskEntity entity)
        {
            _appDbContext.Tasks.Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<TaskEntity> Update(TaskEntity entity)
        {
            _appDbContext.Tasks.Update(entity);

            await _appDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
