using System;
using BTDB.KVDBLayer;

namespace BTDB.ServiceLayer
{
    public interface IServiceInternalServer
    {
        AbstractBufferedWriter StartResultMarshaling(uint resultId);
        void FinishResultMarshaling(AbstractBufferedWriter writer);
        void ExceptionMarshaling(uint resultId, Exception ex);
        void VoidResultMarshaling(uint resultId);
    }
}