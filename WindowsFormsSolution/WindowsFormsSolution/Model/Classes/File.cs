using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinFromsSolution.Models
{
    public class File : Attachment
    {
        /*public File(User owner, string name) : base(owner)
        {
            Name = name;
        }*/
        public string Name { get; set; }

        /*public void Download()
        {
            throw new NotImplementedException();
        }

        public void AddComment(User currUser, string text)
        {
            Comments.Add(new Comment(currUser, text, false));
        }*/
    }
}