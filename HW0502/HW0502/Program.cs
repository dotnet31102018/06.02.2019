using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0502
{
    class Program
    {
        static void Main(string[] args)
        {
            Poodle foofoo = new Poodle("foofoo", "bamba", 3);

            /*
             
                Horse[] horses = {
                        new Horse("Jumbo", true),
                        new Horse("George", true),
                        new Horse("Samuel", false)
                };
                */
            Horse jumbo = new Horse("Jumbo", true);
            Horse george = new Horse("George", true);
            Horse samuel = new Horse("Samuel", false);
            Horse[] horses = new Horse[3];
            horses[0] = new Horse("Jumbo", true);
            horses[1] = george;
            horses[2] = samuel;

            Horse[] racingHorses = GetRacingHorses(horses);
        }

        private static Horse[] GetRacingHorses(Horse[] horses)
        {
            Horse[] racingHorses = GetRacingHorsesAmount(horses);

            SetRacingHorsesInArray(horses, racingHorses);

            return racingHorses;
        }

        private static void SetRacingHorsesInArray(Horse[] horses, Horse[] racingHorses)
        {
            int index = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].isRacingHorse)
                {
                    racingHorses[index] = horses[i];
                    index++;
                }
            }
        }

        private static Horse[] GetRacingHorsesAmount(Horse[] horses)
        {
            int numberOfRacinghorses = 0;

            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i].isRacingHorse)
                {
                    numberOfRacinghorses++;
                }

                // stam for fun
                //numberOfRacinghorses = horses[i].isRacingHorse ? numberOfRacinghorses + 1 : numberOfRacinghorses;
            }

            Horse[] racingHorses = new Horse[numberOfRacinghorses];
            return racingHorses;
        }

        static void AnimalSing(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }
        }
    }
}
