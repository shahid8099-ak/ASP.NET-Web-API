﻿namespace EmployeeAdminPortal.Model
{
    public class AddEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public Decimal Salary { get; set; }
    }
}
