﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialMediaPosts
{
    class Program
    {
        static Dictionary<string, Dictionary<string, string>> postComments = new Dictionary<string, Dictionary<string, string>>();
        static Dictionary<string, int> postLikes = new Dictionary<string, int>();
        static Dictionary<string, int> postDislikes = new Dictionary<string, int>();

        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] inputTokens = input.Split(' ');
                string command = inputTokens[0];
                string postName = inputTokens[1];

                switch (command)
                {
                    case "post":
                        CreatePost(postName);
                        break;

                    case "like":
                        LikePost(postName);
                        break;

                    case "dislike":
                        DislikePost(postName);
                        break;

                    case "comment":
                        string commentatorName = inputTokens[2];
                        string commentContant = string.Join(" ",inputTokens.Skip(3).ToArray());
                        CommentPost(postName, commentatorName, commentContant);
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var postCommentData in postComments)
            {
                string postName = postCommentData.Key;
                int likes = postLikes[postName];
                int dislikes = postDislikes[postName];
                Dictionary<string, string> commentsData = postCommentData.Value;

                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", postName, likes, dislikes);

                Console.WriteLine("Comments:");
                if (commentsData.Count == 0)
                {
                    Console.WriteLine("None");
                }
                foreach (var commenData in commentsData)
                {
                    string commentatorName = commenData.Key;
                    string commentContent = commenData.Value;

                    Console.WriteLine("*  {0}: {1}", commentatorName, commentContent);
                }
            }
        }

        static void CreatePost(string postName)
        {
            postComments.Add(postName, new Dictionary<string, string>());
            postLikes.Add(postName, 0);
            postDislikes.Add(postName, 0);
        }
        static void LikePost(string postName)
        {
            postLikes[postName]++;
        }
        static void DislikePost(string postName)
        {
            postDislikes[postName]++;
        }
        static void CommentPost(string postName, string commentatorName, string commentContent)
        {
            postComments[postName].Add(commentatorName, commentContent);
        }
    }
}
