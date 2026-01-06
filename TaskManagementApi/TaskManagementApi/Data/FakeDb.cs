using TaskManagementApi.Models;

namespace TaskManagementApi.Data
{
    public static class FakeDb
    {
        public static List<User> Users = new();
        public static List<TaskItem> Tasks = new();
    }
}
