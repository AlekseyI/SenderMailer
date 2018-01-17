using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmtpSender.Data
{
    public interface IData<T>
    {
        T Entity { get; }
    }
}
