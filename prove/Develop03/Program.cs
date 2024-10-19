using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new Dictionary<Reference, string>
        {
            { new Reference("Ether", 12, 9, 10), "Wherefore, ye may also have hope, and be partakers of the gift, if ye will but have faith. Behold it was by faith that they of old were called after the holy order of God." },

            { new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them." },

            { new Reference("Moses", 1, 39), "For behold, this is my work and my glory: to bring to pass the immortality and eternal life of man" },

            { new Reference("Galatians", 5, 22, 23), "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, Meekness, temperance: against such there is no law." },

        };

        Random random = new Random();
        var referenceList = new List<Reference>(scriptures.Keys);
        var randomReference = referenceList[random.Next(referenceList.Count)];
        var randomText = scriptures[randomReference];

        Scripture scripture = new Scripture(randomReference, randomText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("");
                Console.WriteLine("All words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

        }
    }

}