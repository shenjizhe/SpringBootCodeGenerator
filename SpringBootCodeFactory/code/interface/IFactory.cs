using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code
{
    public interface IFactory<T>
    {
        string Create(T t);
    }

    public interface IFactory<T, T2>
    {
        string Create(T t1, T2 t2);
    }
}
