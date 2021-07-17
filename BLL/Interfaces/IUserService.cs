using BLL.DtoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserSkillModel> GetUserSkills(string email);
        IEnumerable<CourseModel> GetUserCourse(string email);
        IEnumerable<MaterialModel> GetUserMaterials(string email);
        IEnumerable<MaterialModel> GetMaterialsInCourse(int courseId, string email);
        IEnumerable<CourseModel> GetCourseForUser(string email);
        void UserPassesCourse(int courseId, string email);
    }
}
