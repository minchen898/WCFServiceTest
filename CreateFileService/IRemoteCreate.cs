using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CreateFileService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRemoteCreate" in both code and config file together.
    [ServiceContract]
    public interface IRemoteCreate
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void ChangeFileName(string fileName);

        [OperationContract]
        string GetFileName();
    }
}
