using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace WCFIntern
{
    [ServiceContract]
    interface IIntern
    {
        [OperationContractAttribute]
        string SayHello(string msg);

        [OperationContract]
        string GetName();


    }

    public class Intern : IIntern
    {
        string IIntern.SayHello(string msg)
        {
            return "Hello " + msg; //throw new NotImplementedException();  
        }

        string IIntern.GetName()
        {
            return "Apel GetName"; // throw new NotImplementedException();  
        }
    }
}
