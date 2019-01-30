//From Wing S Cho BIT 285 Winter 2019
using System;
namespace bit285assignment1naps.Models
{
    public class PasswordSuggestionService
    {

        public string generatePassword(User user)
        {
            Random random = new Random();

            switch (random.Next(0, 4))
            {

                case 1:
                    return "A"+user.lastName + user.favColor + user.birthYear;
                case 2:
                    return "B"+user.lastName + user.birthYear + user.favColor;
                case 3:
                    return "C"+user.favColor + user.lastName + user.birthYear;
                case 4:
                    return "D"+user.favColor + user.birthYear + user.lastName;
                default:
                    return "E"+"pass" + user.birthYear + "word";
            }

        }

    }
}
