using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace BuyukDatalarIleCalismak.Base
{
    public class Yardim
    {
        private readonly string logKlasoru = @"C:\Loglar";
        private readonly string logDosyasi = @"C:\Loglar\log.txt";

        public void TryCatchKullan(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                string hataMesaji = $"[{DateTime.Now}] Hata: {ex.Message}{Environment.NewLine}";

                Console.WriteLine(hataMesaji);

                if (!Directory.Exists(logKlasoru))
                {
                    Directory.CreateDirectory(logKlasoru);
                }

                // Dosyaya ekle
                File.AppendAllText(logDosyasi, hataMesaji);
            }
        }
    }
}

