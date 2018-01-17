using System.Threading.Tasks;
using SmtpSender.Data;

namespace ISednders
{
    public interface ISender<T>
    {
        T Data { get; }
        void Send();
    }
}
