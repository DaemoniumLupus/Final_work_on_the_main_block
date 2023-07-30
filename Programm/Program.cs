
string[] massive = new string[4] { "hello", "-23", "Rupert", "12" };
string[] bufferMassive = new string[massive.Length];
int bufferIndex = 0;

bufferMassive = Extraction(massive, bufferMassive);
PrintMassive(bufferMassive);

string[] Extraction(string[] massive, string[] bufferMassive)
{
  for (int i = 0; i < massive.Length; i++)
  {
    if (massive[i].Length <= 3)
    {
      bufferMassive[bufferIndex] = massive[i];
      bufferIndex++;
      continue;
    }
  }
  return bufferMassive;
}

void PrintMassive(string[] mas)
{
  for (int i = 0; i < mas.Length; i++)
  {
    Console.Write($"{mas[i]} ");
  }
}











