string[] lines = File.ReadAllLines("motorini.csv");
string marche = "";
float media = 0;

for (int i = 1; i < lines.Length; i++)
{
    string[] line = lines[i].Split(",");
    media += float.Parse(line[7]);

    if (!marche.Contains(line[0]))
    {
        marche += line[0] + ",";
    }
}

marche = marche.Substring(marche.Length - 1);
string[] array_marche = marche.Split(",");
int[] num_mot = new int[array_marche.Length];

for (int i = 0; i < lines.Length; i++)
{
    string[] line = lines[i].Split(",");
    
    for (int j = 0; j < array_marche.Length; j++)
    {
        if (line[0] == array_marche[j])
        {
            num_mot[j]++;
        }
    }
}

Console.WriteLine($"la emdia dei prezzi: {media/(lines.Length - 1)}");

for(int i = 0;i < num_mot.Length; i++)
{
    Console.WriteLine($"{array_marche[i]}: {num_mot[i]}");
}

