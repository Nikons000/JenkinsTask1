using System;
using System.Text;

public class RandomUtil
{
    public string login;
    public string GenerateRandomLogin()
    { 
        login = Faker.Name.FullName();
        return login; 
    }

    public string GenerateRandomPassword()
    {
        const string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
        const string numerals = "0123456789";
        const string cyrillicCharacters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        StringBuilder passwordBuilder = new StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            char randomChar;

            if (i == 0)
            {
                randomChar = login[0];
            }
            else if (i == 1)
            {
                randomChar = cyrillicCharacters[new Random().Next(cyrillicCharacters.Length)];
            }
            else if (i == 2)
            {
                randomChar = numerals[new Random().Next(numerals.Length)];
            }
            else if (i == 3)
            {
                randomChar = upperCaseLetters[new Random().Next(upperCaseLetters.Length)];
            }
            else if (i == 4)
            {
                randomChar = lowerCaseLetters[new Random().Next(lowerCaseLetters.Length)];
            }
            else
            {
                string availableChars = lowerCaseLetters + numerals + upperCaseLetters;
                randomChar = availableChars[new Random().Next(availableChars.Length)];
            }
            passwordBuilder.Append(randomChar);
        }
        return passwordBuilder.ToString();
    }
}
