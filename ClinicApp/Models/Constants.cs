using System;

namespace ClinicApp.Models;

public class Doctor
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string NationalId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
}

public static class Constants
{
    public static List<Doctor> Doctors { get; } = new()
    {
        new Doctor
        {
            Id = 101,
            FullName = "Alice Johnson-Doe",
            NationalId = "1987654321",
            Email = "alice.johnson@example.com",
            PhoneNumber = "5551234567",
            DateOfBirth = new DateOnly(1995, 10, 25)
        },
        new Doctor
        {
            Id = 102,
            FullName = "Robert L. Smith",
            NationalId = "2012345678",
            Email = "robert.smith@health.org",
            PhoneNumber = "5559876543",
            DateOfBirth = new DateOnly(1980, 3, 15)
        },
        new Doctor
        {
            Id = 103,
            FullName = "Maria Garcia Rodriguez",
            NationalId = "1700101010",
            Email = "maria.garcia@clinic.net",
            PhoneNumber = "5550001111",
            DateOfBirth = new DateOnly(2005, 7, 1)
        }
    };
}
