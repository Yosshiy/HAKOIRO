using System.Collections;
using System.Collections.Generic;

public struct ListData<T, V> where T : List<T> where V : List<V>
{
    List<T> list;
    List<V> Vlist;

    public ListData(T iqtem, V a)
    {
        list = iqtem;
        Vlist = a;
    }
}

