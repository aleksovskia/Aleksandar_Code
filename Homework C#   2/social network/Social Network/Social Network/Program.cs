﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SedumnaestaZadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialNetwork SN = new SocialNetwork();
            Console.WriteLine("Hello Social Network");
            User Selda = new FaceBookUser("selda", "Ovaepassword1", "selda@gmail.com", 10, 10, 5);
            Console.WriteLine("Popularity: " + Selda.Popularity());
            User Kaya = new TwitterUser(15, 10);
            Console.WriteLine("Popularity: " + Kaya.Popularity());
            SN.addUser(Selda);
            SN.addUser(Kaya);
            Console.ReadLine();
        }
    }
    public abstract class User
    {
        public string username { get; set; }
        public string password
        {
            get; set;
            //set
            //{
            //    if (CheckPassword(value) == true)
            //        _password = value;
            //}
        }
        public string email { get; set; }
        public abstract double Popularity();
        public bool CheckPassword(string passwordString)
        {
            //var containsBigChar = false;
            //var containsSmallChar = false;
            //var containsNumber = false;
            //foreach(var character in password)
            //{
            //    var isUpperChar = char.IsUpper(character);
            //    var isLowerChar = char.IsLower(character);
            //    var isNumber = char.IsNumber(character);
            //    containsBigChar = containsBigChar || isUpperChar;
            //    containsSmallChar = containsSmallChar || isLowerChar;
            //    containsNumber = containsNumber || isNumber;
            //}
            var containsBigChar = passwordString.Any(char.IsUpper);
            var containsSmallChar = passwordString.Any(char.IsLower);
            var containsNumber = passwordString.Any(char.IsNumber);
            if (containsBigChar && containsSmallChar && containsNumber) return true;
            throw new InvalidPassword();
        }
        public void SetPassword(string passwordString)
        {
            if (CheckPassword(passwordString) == true)
                password = passwordString;
        }
    }
    public class FaceBookUser : User
    {
        public int friends { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
        public FaceBookUser()
        {
            username = "not provided";
            password = "not provided";
            email = "not provided";
            friends = 0;
            likes = 0;
            comments = 0;
        }
        public FaceBookUser(string u, string p, string e, int NewFriends, int NewLikes, int NewComments)
        {
            username = u;
            SetPassword(p);
            email = e;
            friends = NewFriends;
            likes = NewLikes;
            comments = NewComments;
        }
        public override double Popularity()
        {
            double Popularity = friends + likes * 0.1 + comments * 0.5;
            return Popularity;
        }
    }
    public class TwitterUser : User
    {
        public int followers { get; set; }
        public int tweets { get; set; }
        public TwitterUser()
        {
            followers = 0;
            tweets = 0;
        }
        public TwitterUser(int Newfollowers, int NewTweets)
        {
            followers = Newfollowers;
            tweets = NewTweets;
        }
        public override double Popularity()
        {
            double Popularity = followers + tweets * 0.5;
            return Popularity;
        }
    }
    public class SocialNetwork
    {
        public List<User> users { get; set; }
        public int NumberOfCurrentUsers;
        public int MaxNumbersOfUsers = 5;
        public SocialNetwork()
        {
            users = new List<User>();
        }
        public void addUser(User newUser)
        {
            users.Add(newUser);
        }
        public double avgPopularity()
        {
            //double popularity = 0;
            var totalUserPopularity = 0.0;
            //users = [ {user1, user2, user,3}]
            foreach (var user in users)
            {
                totalUserPopularity += user.Popularity();
            }
            return totalUserPopularity / users.Count;
        }
    }
    public class InvalidPassword : Exception
    {
        public InvalidPassword()
        : base("Password is too weak")
        {
        }
    }
}