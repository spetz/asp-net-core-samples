namespace App.Services
{
    public class ValueService : IValueService
    {
        public string Get(int id) => $"Value {id}";
    }
}