using System;

public static class PhoneNumber
{
    private static readonly string _dialingCode = "212";
    private static readonly string _fakeCode = "555";
    private static readonly string _separator = "-";

    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var numberParts = phoneNumber.Split(_separator);
        return (
            numberParts[0].Equals(_dialingCode),
            numberParts[1].Equals(_fakeCode),
            numberParts[2]
        );
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) =>
        phoneNumberInfo.IsFake;
}
