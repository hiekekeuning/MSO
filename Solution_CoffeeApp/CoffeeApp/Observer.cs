using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public interface IMyObserver<T>
    {
        void Notify(T t);
    }

    public interface IMyObservable<T>
    {
        void Register(IMyObserver<T> o);
        void UnRegister(IMyObserver<T> o);
    }

}
