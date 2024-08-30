using Lab2Task3;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Task.Run(() =>
{
    Authenticator authenticator1 = Authenticator.GetInstance();
    authenticator1.Authentithicate(1111, 1111);
});

Task.Run(() =>
{
    Authenticator authenticator2 = Authenticator.GetInstance();
    authenticator2.Authentithicate(1234, 5678);
});

Console.ReadLine();