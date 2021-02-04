 using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    { //ctor(yazıp tab tab yap public list otomatik çıkar) bu constructor dır.
        T[] items;
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; //burada temparray demek ilk referanslar uçmasın diye herşeyi bir attırmakla diğerleride gelsin diye bunu yazdk
            items = new T[items.Length+1]; //items.Length yani dizinin eemen sayısını arttırma denir buna
            for (int i = 0; i <tempArray.Length; i++)//fora tab tab yaptık çünkü diğer elemanları da tut ben ekledikçe onlarıda ver diyeceğiz. tempArray.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

    }
}
