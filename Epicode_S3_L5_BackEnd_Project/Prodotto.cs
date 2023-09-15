using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epicode_S3_L5_BackEnd_Project
{
    public class Prodotto
    {
        public int IdProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string DescrizioneDettagliata { get; set; }
        public decimal Prezzo { get; set; }
        public string ImgUrl { get; set; }
    }

    public static class Database
    {
        public static List<Prodotto> GetProdotti()
        {
            List<Prodotto> prodotti = new List<Prodotto>
            {
                new Prodotto
                {
                    IdProdotto = 1,
                    Nome = "MSI Modern 15 B12M-089IT",
                    Descrizione = "Notebook 15.6 Full-HD 60Hz, Intel I5-1235U, Intel Iris Xe, 8GB RAM DDR4 3200MHz, 512GB SSD M.2 PCIe 3, WiFi 6, Win 11 Home",
                    DescrizioneDettagliata = "Design Vivace: Dimentica l'ordinario, abbraccia il moderno. Il suo design unico, sottile ed elegante viene fornito con una finitura liscia con tutto ciò di cui hai bisogno anche prima di aprire il coperchio.\r\nPrestazioni sbalorditive: La serie Modern presenta l'ultimo processore Intel Core i5-1235U di 12a generazione e la grafica Intel Iris Xe, offre prestazioni più elevate in multi-tasking e intrattenimento. Soprattutto con la grafica Intel Iris Xe, fornisce le prestazioni per potenziare la tua produttività quotidiana.\r\nLa serie Modern migliora il tuo flusso di lavoro, con il touchpad ingrandito, inoltre la scocca consente l'apertura fino a 180° e Flip-n-Share ti consente di condividere lo schermo con un clic per uno spazio di lavoro più produttivo. La corsa dei tasti ottimizzata di 1,5 mm rende l'esperienza di digitazione più ergonomica. Grazie a una tastiera retroilluminata di dimensioni standard, puoi lavorare in ambienti bui.\r\nViaggia con facilità: Con lo chassis estremamente portatile e ultra sottile con un peso di 1,7 kg, il Modern 15 è un laptop leggero realizzato per una mobilità estrema e un look elegante ovunque tu vada.\r\nAudio ad alta risoluzione: Immergiti nella tua musica preferita con Modern Series nel cuore della città, sperimenta il suono come dovrebbe essere ascoltato. Con la capacità di supportare un campionamento fino a 24 bit / 192 kHz, sia in studio che dal vivo.\r\nClick e Scorri: La serie Modern mantiene attivo il tuo flusso di lavoro, con un touchpad ingrandito con controllo fluido e reattivo. La funzione 180° lay-flat e Flip-n-Share ti consente di condividere lo schermo con un clic per uno spazio di lavoro più produttivo. La corsa dei tasti ottimizzata di 1,5 mm rende l'esperienza di digitazione più ergonomica. Grazie a una tastiera retroilluminata di dimensioni standard, puoi lavorare in ambienti bui.\r\nI portatili MSI hanno una garanzia di 2 anni, la copertura rimane invariata anche se acquistati con fattura!",
                    Prezzo = 599.99m,
                    ImgUrl = "https://m.media-amazon.com/images/I/718AiQQtJBL._AC_SL1500_.jpg"
                },
                new Prodotto
                {
                    IdProdotto = 2,
                    Nome = "Lemorele Hub USB C",
                    Descrizione = "Hub USB C HDMI 4K@60Hz - 11 en 1 Spazio Alluminio Adattatore USB C Hub a RJ45 Ethernet, 4 USB 3.0, PD 100W, SD/TF, Dati USB-C",
                    DescrizioneDettagliata = "【Plug-Play + Forte Dissipazione del Calore + Dimensioni Portatili】: Lemorele hub usb c plug and play senza driver, impostazioni o software. Microchip intelligente integrato e una varietà di sistemi di protezione per prevenire sovracorrente, sovratensione, cortocircuito e alta temperatura, per garantire la sicurezza del trasferimento e dell'archiviazione dei file. Adattatore usb c dimensioni portatili: 158 * 40 * 14 mm, cavo: 265 mm, adatto per tasca, borsa per laptop, portafoglio.\r\n【10 in 1 Espansione Estrema】: l'hub USB C ha Gigabit Ethernet e supporta 10/100/1000 M, 2 USB 3.0 e 2 USB 2.0(USB3.0 = 5 Gbps / USB 2.0 = 480 Mbps), 10 volte più veloce di USB 2.0); La porta di trasmissione dati USB-C compensa perfettamente le carenze del trasferimento dati USB-A.Sincronizzazione video 3D ad altissima definizione HDMI 4K su TV, monitor o proiettore ad alta definizione; Ricarica rapida PD 100 W, con doppio slot per schede TF e SD Leggi i file ovunque.\r\n【Ampia Compatibilità】: Lemorele adattatore usb c compatibile con tutti i sistemi e dispositivi con porte USB C che supportano l'uscita video; come Switch/Xbox/PS4/Chromecast con Google TV, Mac OS/Windows/Chrome OS/Android/iOS/Linux e compatibile con MacBook Pro/Air M1, iMac, iPad Pro/Air M1, Dell XPS, Asus Zenbook, Huawei, HP, Lenovo , Microsoft Surface. e vari telefoni cellulari, tastiere, mouse e altri dispositivi esterni.\r\n【Gigabit Ethernet + HDMI 4K + USB 3.0 + PD 100W】: La porta Gigabit Ethernet supporta 10/100/1000M; La porta HDMI stabile espande lo schermo e guarda 4K su TV HD, monitor o proiettore multimediale Ultra HD, video con effetti 3D, giochi 3D e presentazioni di conferenze. 4 * USB3.0 incontra contemporaneamente mouse, tastiera, disco U e altre connessioni e trasferisce qualsiasi file in pochi secondi; La ricarica rapida da 100 W veloce come il caricabatterie originale.",
                    Prezzo = 49.99m,
                    ImgUrl = "https://m.media-amazon.com/images/I/61Sm0gsmZyL._AC_SL1500_.jpg"
                },
                new Prodotto
                {
                    IdProdotto = 3,
                    Nome = "UGREEN Nexode Mini 30W Caricatore USB C",
                    Descrizione = "Caricatore USB C GaN, Caricabatterie USB C Compatibile Dji Mini 3 Pro, Google Pixel 7 Pro/6A, iPhone 15 Plus/ 15 Pro Max/14/13/12/11, iPad Pro/Air/Mini, Galaxy S23/S23+/S22/S21",
                    DescrizioneDettagliata = "[Caricatore USB C da 30W] Il caricabatterie USB C supporta la potenza massima di 30W, retrocompatibile con 25W e 20W. Supporta più protocolli di ricarica rapida come PD 3.0, PPS, QC 4+/ 4.0/ 3.0 e SCP, FCP, AFC per essere compatibile con smartphone, tablet, ecc.\r\n[Ricarica Ultra Rapida] L'adattatore di alimentazione USB C da 30W può caricare il tuo iPhone 15 dallo 0% al 60% in soli 30 minuti, caricare il tuo Galaxy S21 Ultra dallo 0% al 100% in soli 60 minuti.\r\n[Tecnologia Avanzata GaN II] Il caricabatterie da 30W ottimizza la tua esperienza di ricarica con la tecnologia GaN come risparmio energetico, dissipazione del calore, dimensioni compatte, ecc. È più piccolo e compatto mentre ti dà ancora più potenza.\r\n[Compatibilità Universale] Il caricabatterie USB C da 30W è compatibile con Dji Mini 3 Pro, iPhone 14/14 Pro/ 14 Pro Max/ SE 2022/ 13/ 13 Pro/ 13 Pro Max/ 12/ 11/ XR/ XS/ 8/ 8+, MacBook Air M1/ M2, iPad Pro/ Air/ mini, Galaxy S23/ S23+/ S22/ S22+/ S22 Ultra/ S21 Ultra/ S21/ S20 FE/ S20+/ S20/ Note 20, Galaxy Tab S7/ S7+/ S6/ S5e, Pixel 7 Pro/7/6a, Xiaomi Redmi Note 11/10, ecc.",
                    Prezzo = 16.59m,
                    ImgUrl = "https://m.media-amazon.com/images/I/51aBi4Ly5JL._AC_SL1500_.jpg"
                },
            };

            return prodotti;
        }

        public static Prodotto GetProdottoById(int productId)
        {
            List<Prodotto> prodotti = GetProdotti();
            return prodotti.FirstOrDefault(p => p.IdProdotto == productId);
        }
    }

    public partial class Carrello
    {
        public List<Prodotto> Prodotti { get; } = new List<Prodotto>();

        public void AggiungiProdotto(Prodotto prodotto)
        {
            Prodotti.Add(prodotto);
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            Prodotti.Remove(prodotto);
        }

        public decimal CalcolaTotale()
        {
            return Prodotti.Sum(prodotto => prodotto.Prezzo);
        }

        public void SvuotaProdotti()
        {
            Prodotti.Clear();
        }
    }
}