using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        IResult Add(Category category);

        public void Update(Category category);
        public void Delete(Category category);
    }
}
