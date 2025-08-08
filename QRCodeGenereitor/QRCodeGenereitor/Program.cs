// See https://aka.ms/new-console-template for more information
using QRCoder;

Console.WriteLine("Digite a url para criar um QRCode");
string url = Console.ReadLine();

if (string.IsNullOrEmpty(url))
{
    Console.WriteLine("Formado de url invalida");
    return;
}

try
{
    QRCodeGenerator qRCodeGenerator = new();
    QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
    using(PngByteQRCode qRCode =new PngByteQRCode(qRCodeData))
    {
        byte[] qrCodeImege = qRCode.GetGraphic(20);

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string filePath = Path.Combine(desktopPath, "qrcode.png");
        File.WriteAllBytes(filePath, qrCodeImege);
        Console.WriteLine($"QRCode gerado com sucessso e salvo em: {filePath}");
    }

}
catch (Exception)
{
    throw;
}