using System;
using System.Collections.Generic;
using System.Text;
using ViewModel.ViewModel;

namespace Bal.Interface
{
  public  interface IStudents
    {
        public List<VmStudent> Get();
        public bool AddStudent(VmStudent obj);
        public bool DeleteByid(int id );
    }
}
