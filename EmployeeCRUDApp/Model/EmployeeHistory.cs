namespace EmployeeCRUDApp.Model
{
    public class EmployeeHistory
    {
        public int Id { get; set; }
        public string? History { get; set; }
        public virtual Employee Employee { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
