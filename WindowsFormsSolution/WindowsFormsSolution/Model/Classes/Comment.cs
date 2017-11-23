using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinFromsSolution.Models
{
    public class Comment : Attachment
    {
        /*public Comment(User owner, string text, bool response) : base(owner)
        {
            Text = text;
            Response = response;
        }*/
        private bool Response { get; set; }
        public string Text { set; get; }

        /*public void AddResponse(User currUser, string text)
        {
            if (Response == false)
            { Responses.Add(new Comment(currUser, text, true)); }
            else
            { throw new Exception("Cannot make a response to a response"); }
        }*/
    }
}
