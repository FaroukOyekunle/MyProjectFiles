namespace OWNER.source.repos.WebApplicationDemo.Interfaces.IRepository
{
    public interface IDepartmentRepository
    {
        Student Create(Student student);

        Student Update(Student student);
        Student Get(int id);
        List<Student> GetAll();
        void Delete(int id);
    }
}