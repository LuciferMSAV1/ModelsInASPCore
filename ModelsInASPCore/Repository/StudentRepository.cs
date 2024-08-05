using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSourse();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSourse().Where(x => x.rollNo == id).FirstOrDefault();
        }
        private List<StudentModel> DataSourse()
        {
            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1,Name = "Kumar",Gender="Male", Standard = 10 },
                new StudentModel { rollNo = 2, Name = "Adil",Gender="Male", Standard = 10 },
                new StudentModel { rollNo = 3, Name = "Natasha",Gender="Male", Standard = 11 },
                new StudentModel { rollNo = 4, Name = "Ahmad",Gender="Female", Standard = 12 },
                new StudentModel { rollNo = 5, Name = "Ayesha",Gender="Female", Standard = 9 }
            };
        }
    }
}
