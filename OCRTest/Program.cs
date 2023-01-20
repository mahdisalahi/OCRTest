//// Initialize OCR engine
//var recognitionEngine = new Aspose.OCR.AsposeOcr();
//// Extract text from image
//string result = recognitionEngine.RecognizeImage(@"G:\repository-open-graph-templateTest.png");
//// Display the recognition result
//Console.WriteLine(result);

// NuGet PM> Install-Package IronOcr
using IronOcr;
using OCRTest;

string imageText = new IronTesseract().Read(@"G:\repository-open-graph-templateTest.png").Text;

var fixText = imageText.ToLower();

if (!string.IsNullOrEmpty(fixText) && fixText == Constant.MyText.ToLower())
{
    Console.WriteLine(imageText);
}

Console.ReadKey();