using Bal.Interface;
using Dal;
using Dal.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModel.ViewModel;

namespace Bal.Service
{
    public class Students : IStudents
    {
        public readonly IStudentsRepository _IStudentsRepository;
        public Students(IStudentsRepository IStudentsRepository)
        {
            _IStudentsRepository = IStudentsRepository;
        }
        public List<VmStudent> Get()
        {
          return  _IStudentsRepository.Get();
        }

        public bool AddStudent(VmStudent obj)
        {
         return  _IStudentsRepository.Addstudent(obj);
        }

        public bool DeleteByid(int id)
        {
            return _IStudentsRepository.DeleteByid(id);
        }
    }
}
