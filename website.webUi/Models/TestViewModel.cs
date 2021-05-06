using System;
namespace website.webUi.Models
{
    public class TestViewModel
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => _message = value;
        }


        string[] firstnameArray =
    {
        "Matt",
        "Tim",
        "James"
    };

        private string[] _nameArray;
        public string[] NameArray
        {
            get => _nameArray;
            set => _nameArray = firstnameArray;
        }

    }
}
