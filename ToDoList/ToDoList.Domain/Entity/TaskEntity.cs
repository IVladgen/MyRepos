﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Enum;

namespace ToDoList.Domain.Entity
{
    public class TaskEntity
    {
        
        [Required]
        public long Id { get; set; }

        public bool IsDone { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set;}

        public Priority Priority { get; set; }
    }
}
