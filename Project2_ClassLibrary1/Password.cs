using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project2_ClassLibrary1
{
    public class Password
    {
        public string filePath = "Users.txt";

        private static readonly char[] specialChars = "!#$ % & '  ( ) * + , - . / : ; < = > ? @ [  ] ^ _ ` { | } ~".ToCharArray();
        int NotASpecialChar = -1;

        private string username;

        private string password;

        public string Username { get; set; }
        public string New_password { get; set; }
        

        public Password()
        {

        }

        public Password(string Username, string New_password)
        {
            username = Username;
            password = New_password;
        }
   

        public string Create_MyPassword(string username, string password)
        {

            if (password.Length < 12)
            {
                return "Password skal være på minimum 12 tegn";
            }

            else if (!password.Any(char.IsUpper))
            {
                return "Der skal være mindst et stort bogstav";
            }

            else if (!password.Any(char.IsLower))
            {
                return "Der skal være mindst et lille bogstav";
            }

            else if (!password.Any(char.IsDigit))
            {
                return "Der skal være mindst et tal";
            }

            else if (password.IndexOfAny(specialChars) == NotASpecialChar)
            {
                return "Password skal mindst indeholde et special tegn";
            }

            if (password.Substring(password.Length - 1).Any(char.IsDigit))
            {
                return "Sidste karakter i password må ikke være et tal";
            }

            if (password.Substring(0, 1).Any(char.IsDigit))
            {
                return "Første karakter i password må ikke være et tal";
            }

            if (String.IsNullOrWhiteSpace(password) || String.IsNullOrEmpty(username))
            {
                return "Username and Password må ikke indelholder nul eller mellemrum";
            }

            if (username == password)
            {
                return "Username og password må ikke være ens";
            }
            else
            {
                File.AppendAllText(filePath,(username + " " + password) + Environment.NewLine);
                return "Tillyke - dit nye password er nu oprettet";                
            }
        }

        public bool Login(string username, string password)
        {
            bool result = false;
            string input = File.ReadAllText("Users.txt");


            string[] lines = File.ReadAllLines("Users.txt");


            for (int i = 0; i < lines.Length; i++)
            {
                string[] field = lines[i].Split(' ');
                if (field[0].Equals(username) && field[1].Equals(password))
                {       
                    
                    return result = true;                   
                }
            }
            return result = false;
        }

        public string Change_Password(string old_Password, string new_Password)
        {           
            string input = File.ReadAllText("Users.txt");

            input = input.Replace(old_Password, new_Password);
            File.WriteAllText(filePath, input);
            return "Your password has been changed succesfully";
        }
    }
}
    

        






