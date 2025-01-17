﻿using CSharpDers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDers.DateAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();

    void Add(Course course);
}
