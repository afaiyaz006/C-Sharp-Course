using System;
namespace AdvancedExercises
{
    class StackOverFlowPost
    {
        private string title = null;
        private string description = null;
        private DateTime? dateTime = null;
        private int Votes = 0;

        public void UpVote()
        {
            Votes += 1;
        }

        public void DownVote()
        {
            Votes -= 1;
        }
        public void SetPost(string title, string content)
        {
            this.title = title;
            this.description = content;
            this.dateTime = DateTime.Now;
        }
        public void GetPost()
        {
            Console.WriteLine("Title: "+this.title + " Description: " + this.description + " Time: " + this.dateTime);
            Console.WriteLine("Votes: " + this.Votes);
        }

    }
    class MainProgram
    {
        static void Main(string[] args)
        {
            var stackPost = new StackOverFlowPost();
            stackPost.SetPost(
                "A",
                "B"
            );
        
            stackPost.GetPost();
            stackPost.UpVote();
            stackPost.UpVote();
            stackPost.UpVote();
            stackPost.DownVote();
            stackPost.GetPost();
        }
    }
}