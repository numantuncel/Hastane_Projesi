using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    internal class Sorgular
    {
        public string sorguMetni;

        // Hasta için sorgular.

        public string Hasta_Giris()
        {
            sorguMetni = "select * from Tbl_Hastalar where hastaTC=@p1 and hastaSİFRE=@p2";
            return sorguMetni;
        }
        public string Hasta_Ad_Soyad_Çekme()
        {
            sorguMetni = "Select hastaAD,hastaSOYAD from Tbl_Hastalar Where hastaTC=@p1";
            return sorguMetni;
        }
        public string Hasta_Randevularım_Görüntüleme()
        {
            sorguMetni = "select randevuID,randevuTARİH,randevuSAAT,randevuBRANS,randevuDOKTOR,HastaŞikayet from Tbl_Randevular where HastaTC=@r1";
            return sorguMetni;
        }
        public string Hasta_DoktoraGöre_AktifRandevular()
        {
            sorguMetni="select  randevuID,randevuTARİH,randevuSAAT from Tbl_Randevular where randevuDoktor=@Ar";
            return sorguMetni;
        }
        public string Hasta_BransaGöre_DoktorAdSoyad()
        {
            sorguMetni = "select doktorAD,doktorSOYAD from Tbl_Doktorlar where doktorBRANS=@p1";
            return sorguMetni;
        }
        public string Sisteme_Hasta_Ekle()
        {
            sorguMetni = "insert into Tbl_Hastalar (hastaAD,hastaSOYAD,hastaTC,hastaTELEFON,hastaSİFRE,hastaCİNSİYET) values (@h1,@h2,@h3,@h4,@h5,@h6)";
            return sorguMetni;
        }
        public string Hasta_Randevu_Olustur()
        {
            sorguMetni = "insert into Tbl_Randevular (randevuTARİH,randevuSAAT,randevuBRANS,randevuDOKTOR,randevuDURUM,HastaAd,HastaSoyad,HastaTC,HastaŞİKAYET)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
            return sorguMetni;
        }
        public string Hasta_Randevu_Güncelle()
        {
            sorguMetni = "Update Tbl_Randevular set randevuTARİH=@p1,randevuSAAT=@p2,randevuBRANS=@p3,randevuDOKTOR=@p4,HastaŞikayet=@p5 where randevuID=@p6";
            return sorguMetni;
        }
        public string Hasta_Randevu_İptal()
        {
            sorguMetni = "delete from Tbl_Randevular where randevuID=@p1";
            return sorguMetni;
        }
        public  string Hasta_Bilgi_Güncelle() {
            sorguMetni = "Update Tbl_Hastalar Set hastaAD=@p1, hastaSOYAD=@p2,hastaTELEFON=@p3,hastaSİFRE=@p4,hastaCİNSİYET=@p5 where hastaTC=@p6";// where şartı mutlaka yazılmalı
            return sorguMetni;
            // update where siz çalışmaz !!!!
        }
        public string Hasta_Bilgi_Düzenle()
        {
            sorguMetni = "select * from Tbl_Hastalar  where hastaTC = @p1";
            return sorguMetni;
        }
        // Sekreter için sorgular.
        public string Sekreter_Giris()
        {
            sorguMetni = "select * from Tbl_Sekreterler where sekreterTC=@p1 and sekreterSİFRE=@p2";
            return sorguMetni;
        }
        public string Sekreter_Detay()
        {
            sorguMetni = "Select sekreterADSOYAD from Tbl_Sekreterler where sekreterTC=@p1";
            return sorguMetni;
        }
        public string Sekreter_Randevu_Oluştur()
        {
            sorguMetni = "insert into Tbl_Randevular (randevuTARİH,randevuSAAT,randevuBRANS,randevuDOKTOR)values(@p1,@p2,@p3,@p4)";
            return sorguMetni;
        }
        // Brans için sorgular.
        public string Brans_Veri_Al()
        {
            sorguMetni = "select * from Tbl_Branslar";
            return sorguMetni;
        }
       
        public string Branş_Adı_Al()
        {
            sorguMetni = "select bransAD from Tbl_Branslar";
            return sorguMetni;
        }
        public string Branş_Ekle()
        {
            sorguMetni = "insert into Tbl_Branslar (bransAD)values(@p1)";
            return sorguMetni;
        }
        public string Branş_Sil()
        {
            sorguMetni = "Delete From Tbl_Branslar where bransID=@p1";
            return sorguMetni;
        }
        public string Branş_Güncelle()
        {
            sorguMetni = "update Tbl_Branslar set bransAD=@p1 where bransID=@p2";
            return sorguMetni;
        }
       // Duyuru için sorgular.
        public string Duyuru_Oluştur()
        {
            sorguMetni = "insert into Tbl_Duyurular (Duyuru)values(@d1)";
            return sorguMetni;
        }
        public string Duyuru_Görüntüle()
        {
            sorguMetni = "Select Duyuru from Tbl_Duyurular";
            return sorguMetni;
        }
       //Randevu için sorgular.
        public string Randevu_Listesi()
        {
            sorguMetni = "select * from Tbl_Randevular";
            return sorguMetni;
        }
        public string Randevu_Güncelle()
        {
            sorguMetni = "update Tbl_Randevular set randevuTARİH=@p1,randevuSAAT=@p2,randevuBRANS=@p3,randevuDOKTOR=@p4,randevuDURUM=@p5,HastaTc=@p6 where randevuID=@p7";
            return sorguMetni;
        }
        // Doktor için sorgular.
        public string Doktor_Giris()
        {
            sorguMetni = "select * from Tbl_Doktorlar where doktorTC=@p1 and doktorSİFRE=@p2";
            return sorguMetni;
        }
        public string Doktor_TCye_GöreAdSoyad_Al()
        {
            sorguMetni = "select doktorAD,doktorSOYAD from Tbl_Doktorlar Where doktorTC=@p1";
            return sorguMetni;
        }
        public string Doktor_RandevuListesi_Görüntüle()
        {
            sorguMetni = "Select randevuTARİH,randevuSAAT,HastaAd,HastaSoyad,HastaTC,HastaŞikayet from Tbl_Randevular where randevuDOKTOR=@Rls1";
            return sorguMetni;
        }
        public string Doktor_Ekle()
        {
            sorguMetni = "insert into Tbl_Doktorlar (doktorAD,doktorSOYAD,doktorBRANS,doktorTC,doktorSİFRE)values(@d1,@d2,@d3,@d4,@d5)";
            return sorguMetni;
        }
        public string Doktor_Veri_Al()
        {
            sorguMetni = "select (doktorAD +' '+doktorSOYAD) as Doktorlar ,doktorBRANS from Tbl_Doktorlar";
            return sorguMetni;
        }
        public string Doktor_Tüm_Verileri_Al()
        {
            sorguMetni = "select * from Tbl_Doktorlar";
            return sorguMetni;
        }
        public string Doktor_Sil()
        {
            sorguMetni = "delete from Tbl_Doktorlar where doktorTC=@dt1";
            return sorguMetni;
        }
        // Bu methodu hem dokktor hem sekreter kullanır.
        public string Doktor_Güncelle()
        {
            sorguMetni = "update Tbl_Doktorlar set doktorAD=@p1,doktorSOYAD=@p2,doktorBRANS=@p3,doktorSİFRE=@p5 where doktorTC=@p4";
            return sorguMetni;
        }
    }
}
