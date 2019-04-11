using System;
using System.Collections.Generic;
using System.Text;

namespace UniversitySystem.Models.Abstract
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }
    }
}
