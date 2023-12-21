using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IGamerService
    {
        //Operasyonların interfacesini yazıyoruz.
        void Add(Gamer gamer);//Kayıt

        void Update(Update gamer);//Güncelleme

        void Delete(Gamer gamer);//Silmek

    }
}
