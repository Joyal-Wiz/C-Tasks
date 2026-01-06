using JWT_Task.Models;
namespace JWT_Task.Data
{
    public class FakeDb
    {
        public static List<User> Users = new();
        public static List<TaskItem> Tasks=new();
    }
}
