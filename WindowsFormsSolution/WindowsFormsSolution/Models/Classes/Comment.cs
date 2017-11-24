using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsFormsSolution.Models
{
    public class Comment : Attachment
    {
        private bool Response { get; set; }
        public string Text { get; private set; }
        public IList<Comment> Responses { get; private set; }
        public Comment(User owner, string text, bool response) : base(owner)
        {
            Text = text;
            Response = response;
        }
        
        public void AddResponse(User currUser, string text)
        {
            if (Response == false)
            { Responses.Add(new Comment(currUser, text, true)); }
            else
            { throw new Exception("Cannot make a response to a response"); }
        }

        public void RemoveComment()
        {
            throw new NotImplementedException();
        }
    }
}
