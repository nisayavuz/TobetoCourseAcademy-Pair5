using Business.Abstracts;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }



        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccesDataResult<List<CourseDetailDto>> (_courseDal.GetCourseDetails() , Messages.CourseListed);

        }
    }
}
