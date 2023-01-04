using SOAP_SERVICE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP_SERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {

        [OperationContract]
        string AddBook(Book book);

        [OperationContract]
        List<Book> GetAllBooks();

        [OperationContract]
        string UpdateBook(Book book);

        [OperationContract]
        string DeleteBook(int Id);


        // TODO: Add your service operations here
    }


    
}
