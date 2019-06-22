using System;
using System.Text;


namespace passwordapp
{
    public class RandomPassword
    {
        private readonly Random _random;
        public RandomPassword()
        {
            _random = new Random();
        }

        public string Generate(int passwordLength)
        {
            var passwordBuilder = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                var charCode = _random.Next(32, 127);
                passwordBuilder.Append((char)charCode); 
            }

            return passwordBuilder.ToString();   
        }
    }
}