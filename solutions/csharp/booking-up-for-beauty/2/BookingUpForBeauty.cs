using System;
static class Appointment
{
    public static DateTime Schedule(string appointmentDateString) => DateTime.Parse(appointmentDateString);
    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;
    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour is >= 12 and < 18;
    public static string Description(DateTime appointmentDate) => "You have an appointment on " + appointmentDate.ToString("M/d/yyyy h:mm:ss tt.");
    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);
}