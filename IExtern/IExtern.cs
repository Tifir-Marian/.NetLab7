
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Configuration;

namespace WCFExtern
{
    [ServiceContract]
    interface IExtern
    {
        [OperationContract]
        string SayGoodbye(string msg);
        [OperationContract]
        string ApelGetName();

    }

    public class Extern : IExtern
    {
        string IExtern.SayGoodbye(string msg)
        {
            return "Bye " + msg;
        }

        string IExtern.ApelGetName()
        {

            // aici se apeleaza GetName din serviciul intern  

            using (InternClient ic = new InternClient())
            {
                string msg = ic.GetName();
                return msg;
            }
        }
    }
}