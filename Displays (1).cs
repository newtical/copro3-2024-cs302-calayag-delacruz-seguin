using System;
namespace ConsoleApp1
{
    public class Story
    {
        public void Display()
        {
            Console.WriteLine ("                                                                  \tTHE DUELS OF DESTINY");
            string story = @"

In this universe, survival is more than just strength—it’s about determination, willpower, and the unbreakable spirit to keep fighting. 
Many have tried to change their fate. Some accepted it. Others didn’t even try. In this endless interstellar battle, warriors from all over the galaxies fight for dominance, honor, and survival. 
Every planet has its own champion, created by the unique environments and cultures that shaped them. These warriors are not just fighters—they represent their planet’s pride and power, carrying the hopes of their people onto the battlefield. 
Across countless galaxies, the universe thrives on conflict, where warriors rise to prove their strength, rewrite their destinies, or protect their way of life. 
Some embrace their fate with honor, while others fight against it, trying to take what they think is rightfully theirs.

Whispers spread throughout the universe—rumors of a lost planet hidden deep in space, where the Seed of Immortality is said to grow. 
An ancient relic, older than the stars themselves, it’s believed to grant eternal life and limitless power. 
For centuries, it was just a myth, a legend passed down by storytellers around the fires of distant worlds. 
But now, the myth is real, and the universe is shaken to its core. Two great forces rise to claim this powerful relic. 
On one side, there are those hungry for conquest. They believe the Seed will give them the power to rule the entire galaxy, to crush all resistance and shape the universe into their image—a place where peace is enforced through fear and domination and everyone is their slaves. 
On the other side are those who want to keep the balance of the universe intact. They know the Seed is too dangerous for anyone to control. 
For them, the Seed must either be protected, hidden, or destroyed, to prevent it from throwing the universe into chaos. 
They understand that too much power in the wrong hands could tear everything apart.

As the race for the Seed begins, alliances are forged and shattered in the blink of an eye. Whole worlds are thrown into chaos as the seed’s existence becomes known. 
Some join the conquerors, hoping to share in their victory. Others align with the defenders of balance, terrified of what might happen if the Seed falls into the wrong hands. 
Across the galaxies, civilizations prepare for a war—not just for territory, but for the very future of the universe. 
The cosmos holds its breath, for the race has started, and the fate of all existence is now in question. 
The Seed of Immortality lies waiting—for the one who will decide the universe’s future.

“Is immortality a myth, or a truth to unfold? In the duels of destiny, only one shall hold”";

            
            TypeWriterEffect(story, 20);
            Console.WriteLine();
            Program.GoBackToMenu();
        }

        private void TypeWriterEffect(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(delay);
            }
            
        }
        public void Display(int choice)
        {
            Console.WriteLine("-----------DUELS OF DESTINY!------------");
            Console.WriteLine("Creators:");
            Console.WriteLine("Dominic Jude Seguin - Leader na Cute na Debugger and Documentation King");
            Console.WriteLine("Julianne Calayag - Aliping Saguiguilid na Brainstorming Queen ");
            Console.WriteLine("Alberto Dela Cruz - Aliping Namamahay na Pro (raw) Mag Code");
            Console.WriteLine("----------------------------------------");
            Program.GoBackToMenu();
        }
    }
}
