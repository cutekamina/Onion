using Dal.Interface;
using Entity;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel.ViewModel;

namespace Dal.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        public readonly Applicationcontext _Applicationcontext;
        public StudentsRepository(Applicationcontext Applicationcontext)
        {
            _Applicationcontext = Applicationcontext;
        }

        public bool Addstudent(VmStudent obj)
        {
            if (obj != null)
            {
                StudentDetails obj2 = new StudentDetails();
                obj2.Batch = obj.Batch;
                obj2.Name = obj.Name;
                obj2.Email = obj.Email;
                obj2.RollNo = obj.RollNo;
                obj2.Subject = obj.Subject;
                _Applicationcontext.StudentDetails.Add(obj2);
                _Applicationcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteByid(int id)
        {
            var data = _Applicationcontext.StudentDetails.Where(x => x.ID == id).FirstOrDefault();
            if(data!=null)
            {
                _Applicationcontext.StudentDetails.Remove(data);
                _Applicationcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<VmStudent> Get()
        {
            List<StudentDetails> lst2 = new List<StudentDetails>();
            List<VmStudent> lst = new List<VmStudent>();
           lst2 = _Applicationcontext.StudentDetails.ToList();
            foreach (var item in lst2)
            {
                VmStudent obj = new VmStudent();
                obj.Name = item.Name;
                obj.Email = item.Email;
                obj.Batch = item.Batch;
                obj.Subject = item.Subject;
                obj.RollNo = item.RollNo;
                obj.ID = item.ID;
                lst.Add(obj);
            }
            return lst;
        }
    }
}
