using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAP_SERVICE.Models
{
    [DataContract]
    public class Book
    {
        private int id;
        private string title;
        private string author;

        [DataMember]
        public int Id 
        { 
            get { return id; } 
            set { id = value; } 
        }

        [DataMember]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [DataMember]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }
}