namespace EmployeeCRUDApp.Model
{
    public class EmployeeHistory
    {
        public int Id { get; set; }
        public string? History { get; set; }
        public string Employee { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
