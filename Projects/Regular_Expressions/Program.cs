using System.Text.RegularExpressions;

string pattern = @"\d";
Regex regex = new Regex(pattern);

Console.WriteLine("Does 2 match pattern: "+regex.IsMatch("2"));
Console.WriteLine("Does a match pattern: "+regex.IsMatch("a"));

string pattern1 = "(the)";
Regex regex1 = new Regex(pattern1);
string text = "the quick brown fox jumped over the lazy dog";
Match match1 = regex.Match(text);
MatchCollection matches = regex.Matches(text);
