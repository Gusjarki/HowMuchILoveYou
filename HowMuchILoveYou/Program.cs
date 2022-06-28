//Ваша цель  — определить, какую фразу девушки сказали бы о цветке с заданным количеством лепестков.

Console.WriteLine(Kata.HowMuchILoveYou(int.Parse(Console.ReadLine()))) ;
public class Kata
{
    public static string HowMuchILoveYou(int nb_petals)
    {
        string[] phrases = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
        int result = 0;
        for (int i = 0, j = 0; j < nb_petals; i++, j++)
        {
            if (i % 6 == 0)
                i = 0;
            result = i;
        }
        return phrases[result];

    }
}
