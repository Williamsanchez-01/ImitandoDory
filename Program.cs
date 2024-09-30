Console.Clear();

Console.WriteLine("Imitando Dory\n");

Console.Write("Digite uma frase para ser traduzida para baleies : ");
string f = Console.ReadLine()!;

string traducao = f
    .Replace("a", "aaa")
    .Replace("A", "AAA")
    .Replace("e", "eee")
    .Replace("E", "EEE")
    .Replace("i", "iii")
    .Replace("I", "III")
    .Replace("o", "ooo")
    .Replace("O", "OOO")
    .Replace("u", "uuu")
    .Replace("U", "UUU")
;

Console.WriteLine($"Em baleiês: {traducao}");

Console.WriteLine("Pronto agora voce ja sabe como se fala isso em baleies!!");