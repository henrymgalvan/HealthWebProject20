using System;
using System.Collections.Generic;
using HealthWebApp2._0.Data.EntityModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HealthWebApp2._0.Data.Interface
{
    public interface INameTitle
    {
        IEnumerable<NameTitle> Getall();
        NameTitle Get(int Id);
        void Add(NameTitle newNameTitle);
        void Update(NameTitle updatedNameTitle);
        void Delete(int Id);
    }
}