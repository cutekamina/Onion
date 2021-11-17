using System;
using System.Collections.Generic;
using System.Text;
using ViewModel.ViewModel;

namespace Dal.Interface
{
   public interface IStudentsRepository
    {
        public List<VmStudent> Get();
        public bool  Addstudent(VmStudent obj);
        public bool DeleteByid(int id);
    }
}
