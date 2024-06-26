﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Enum;

namespace ToDoList.Domain.ViewModels
{
    public  class CreateTaskViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException(Name, "Введите название задачи");
            }
            if (string.IsNullOrWhiteSpace(Description))
            {
                throw new ArgumentNullException(Description, "Введите описание задачи");
            }
        }
    }
}
