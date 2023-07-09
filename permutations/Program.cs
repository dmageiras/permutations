string[] permute(string word)
{
    List<string> permutations = new List<string>();

    if (word.Length == 1)
    {
        permutations.Add(word);
    }
    else
    {
        for (int i = 0; i < word.Length; i++)
        {
            string[] sub_permuations = permute(word.Remove(i, 1));
            foreach (string permuation in sub_permuations)
            {
                permutations.Add(word[i] + permuation);
            }
        }
    }
    return permutations.ToArray();
}

string w = "hello world";
string[] permutations = permute(w);
foreach (string p in permutations)
{
    Console.WriteLine(p);
}