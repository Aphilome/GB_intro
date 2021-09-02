using System;
using System.Text;

namespace Receipt
{
    public class OrgInfo
    {
        public string Site => "WWW.UNIQLO.COM";
        
        public string Ooo => "OOO \"Юникло (Рус)\"";
        
        public long Inn => 7705878750;
        
        public string FactAddr => "Москва, ул. Земляной Вал, д. 33";
        
        public string PayAddr => "ТРЦ \"Атриум\", м-н \"Юникло\"";
        
        public string ShortPayAddr => "UNIQLO АТРИУМ";
        
        public long ZnKkt => 46003181;
        
        public long RnKkt => 0001322394064672;
        
        public long Fn => 8710000100743732;
        
        public DateTime TranzactionDate => new DateTime(2018, 1, 22, 20, 23, 0);
        
        public int KassirId => 120080;
        
        public string KassirName => "Гончарова Марина Геннадьевна";
        
        public long Telephone => 74995515271;
        
        public long Articul => 2000093507316;
        public string GoodsName => "ЖЕНСКИЙ ТОП";
        
        public double GoodsPrice => 999.0;
    }
    
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WindowWidth = 40;
            
            OrgInfo info = new OrgInfo();
            
            Console.SetCursorPosition((Console.WindowWidth - info.Site.Length) / 2, Console.CursorTop);
            Console.WriteLine(info.Site);
            Console.WriteLine(info.Ooo);
            Console.WriteLine($"ИНН: {info.Inn}");
            Console.WriteLine($"АДРЕС РАСЧЕТОВ: {info.FactAddr}");
            Console.WriteLine($"МЕСТО РАСЧЕТОВ: {info.PayAddr}");
            Console.SetCursorPosition((Console.WindowWidth - "КАССОВЫЙ ЧЕК".Length) / 2, Console.CursorTop);
            Console.WriteLine("КАССОВЫЙ ЧЕК");
            Console.Write($"ЗН KKT: {info.ZnKkt}");
            Console.SetCursorPosition((Console.WindowWidth - info.RnKkt.ToString().Length), Console.CursorTop);
            Console.WriteLine($"РН ККТ: {info.RnKkt}");
            Console.WriteLine($"ФН: {info.Fn}");
            Console.WriteLine(info.TranzactionDate.ToString("dd.MM.yy hh:mm"));
            Console.WriteLine($"КАССИР: {info.KassirId}-{info.KassirName}");
            Console.SetCursorPosition((Console.WindowWidth - ("ПРИХОД").Length) / 2, Console.CursorTop);
            Console.WriteLine("ПРИХОД");
            Console.SetCursorPosition((Console.WindowWidth - info.Ooo.Length) / 2, Console.CursorTop);
            Console.WriteLine(info.Ooo);
            Console.SetCursorPosition((Console.WindowWidth - (info.ShortPayAddr + "магазин ").Length) / 2, Console.CursorTop);
            Console.WriteLine($"магазин {info.ShortPayAddr}");
            Console.SetCursorPosition((Console.WindowWidth - info.PayAddr.Length) / 2, Console.CursorTop);
            Console.WriteLine(info.PayAddr);
            Console.SetCursorPosition((Console.WindowWidth - info.Telephone.ToString().Length - 12) / 2, Console.CursorTop);
            Console.WriteLine($"тел. {info.Telephone:+# (###) ###-##-##}\n");
            Console.WriteLine($"{info.Articul} {info.GoodsName}");
            Console.Write($"1.00*{info.GoodsPrice:0.00}");
            Console.SetCursorPosition((Console.WindowWidth - ((int)info.GoodsPrice).ToString().Length - 4), Console.CursorTop);
            Console.WriteLine($"={info.GoodsPrice:0.00}");
            Console.WriteLine("НДС 18%");
            Console.Write("ИТОГ");
            Console.SetCursorPosition((Console.WindowWidth - ((int)info.GoodsPrice).ToString().Length - 4), Console.CursorTop);
            Console.WriteLine($"={info.GoodsPrice:0.00}");
            Console.Write("СУММА НДС 18%");
            Console.SetCursorPosition((Console.WindowWidth - ((int)info.GoodsPrice).ToString().Length - 4), Console.CursorTop);
            Console.WriteLine($"={(info.GoodsPrice * 0.18):0.00}");
            Console.Write("ЭЛЕКТРОННЫМИ");
            Console.SetCursorPosition((Console.WindowWidth - ((int)info.GoodsPrice).ToString().Length - 4), Console.CursorTop);
            Console.WriteLine($"={(info.GoodsPrice):0.00}");
            Console.SetCursorPosition((Console.WindowWidth - "Номер карты    - ************7645".Length) / 2, Console.CursorTop);
            Console.WriteLine("Номер карты   - ************7645");
        }
    }
}