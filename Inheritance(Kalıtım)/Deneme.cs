using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Kalıtım_
{
    class Deneme
    {
        public decimal para { get; set; }
    }
}

#region Inheritance
/* Inheritance(Kalıtım, miras) => Bir sınıfın özelliklerini başka bir sınıfa devretmesidir.
   Bir sınıftan miras almak için : (iki nokta üst üste) operatörü kullanılır.
   Control sınıfı text ve name gibi üyelerini toolbox'taki bütün kontrollere devretmiştir.
   Özelliklerini devreden sınıfa base(temel) denir. Özellikleri devralana derived(türetilmiş)
   sınıf denir.
   Button => Text, Name
   TextBox => Text, Name
   Label => Text, Name
   C#'ta bir sınıf sadece başka bir tane sınıftan miras alabilir.
   Inheritance'de amaç ortak özelliklerin belirlenip bir sınıfta toplanmasıdır.
*/
#endregion