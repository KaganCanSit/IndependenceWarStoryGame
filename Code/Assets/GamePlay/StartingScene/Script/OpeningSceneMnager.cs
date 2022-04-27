using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningSceneMnager : MonoBehaviour
{
    public GameObject bubble;
    public Text bubble_txt;

    public GameObject scroll;
    public Text scroll_txt;


    public GameObject soldiers, headman;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Basladi");
        IlkScrollGelir();
    }
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            OyunaBasla();
        }
    }

    void IlkScrollGelir()
    {
        Scroll("Savaş yılları çile demet demet, gözyaşı diz boyu olmuş akıyordu. " +
            "Nice şehit anaları oğlunun acı haberiyle ciğerini dağlıyor, nice umutlar baharında solmuştu." +
            "Açlık, yokluk, perişanlık kol geziyordu. Umutlarsa bir başka bahara kalmış gibiydi. " +
            "Bir akşam üzeri köyde tellal bağırıyordu;");

        Invoke("AskerFermaniOkur", 12);
    }

    void AskerFermaniOkur()
    {
        Bubble("Asker:" +
            "\n– Eyyyyy ahali! Duyduk duymadık demeyin. Cuma günü her haneden bir kişi, İnebolu'ya yük taşımak üzere gidecektir." +
            "\n– Eyyyyy ahali! Duyduk duymadık demeyin. Cuma günü her haneden bir kişi, İnebolu'ya yük taşımak üzere gidecektir." +
            "\n– Eyyyyy ahali! Duyduk duymadık demeyin. Cuma günü her haneden bir kişi, İnebolu'ya yük taşımak üzere gidecektir.");

        Invoke("IkinciScrollGelir", 7);
    }

    void IkinciScrollGelir()
    {
        Scroll("Bu haberden sonra herhangi zamanda olduğu gibi tellal bağırmışsa, o akşam konunun görüşülmesi için köy odasında toplantı yapılırdı. " +
               "Akşam yapılan toplantıda Muhtar şu açıklamayı yaptı.");
        soldiers.SetActive(false);
        Invoke("MuhtarKonusur1", 10);
    }
    void MuhtarKonusur1()
    {
        headman.SetActive(true);
        Bubble("– Ankara'da açılan yeni Meclis ve kurulan hükümet, Anadolu'ya saldıran Yunan askerine son darbeyi vurabilmek için kış boyunca hazırlık yapıyormuş." +
               "Kulakları çınlasın iki ay kadar önce köyümüze gelen M. Akif, camimizde verdiği vaazda:  " +
               "– 'Bir milletin hayat hakkı ve varlığını sürdürme konusunda üstünüze bir görev düşerse, yerine getirmekte asla tereddüt etmeyiniz." +
               "Vatanı sahiplenmek için gerekirse her birimiz, toprağın koynuna girmeye aday olabilmeliyiz ki, bu vatan bizimdir diyebilelim.' demişti.");

        Invoke("MuhtarKonusur2", 10);
    }
    void MuhtarKonusur2()
    {
        Bubble("Komşular! Sizin anlayacağınız, deniz yoluyla İnebolu'ya getirilen cephane ve top mermilerinin cepheye taşınması için bütün çevre köylere görev verilmiş. " +
            "Taşıma işi muhakkak halledilmelidir. Bizim köyün taşıma sırası Cuma günü olarak bildirildi." +
            "İnebolu'dan 80 kağnı cephane yüklenerek Kastamonu'ya doğru yola çıkmamız gerekiyor.");

        Invoke("SonScroll", 10);
    }

    void SonScroll()
    {
        Scroll("... Cuma Günü\nTarih, 1921 yılının son günleriydi.Birdenbire bastıran kar yolları kaplamıştı. Sıra ile cephaneleri yüklenen kağnılar yola çıkıyordu. " +
            "Şerife Gelin, köyde bakacak kimsesi olmadığı için Elif'i yanına almıştı. Kağnısına top mermileri yüklenmişti, yol verildi...\n\n" +
            "Şerife Gelin, İnebolu çıkışında kağnıyı durdurdu. Oraya kadar sırtında taşıdığı kizi Elif icin top mermilerinin arasında bir yer ayarladı." +
            "Tek korunma aracı yün yorganını da top mermilerini ve kızını yağıştan korusun diye,kağnı üzerine örttü. Sonra tekrar kağnı başına geçip 'Bismillah' diyerek kağnıyı çekmeye başladı.");

        Invoke("OyunaBasla", 12);
    }

    void OyunaBasla()
    {
        SceneManager.LoadScene(2);
    }
    public void MakeBubbleVisible()
    {
        this.bubble.SetActive(true);
    }

    public void MakeBubbleInvisible()
    {
        this.bubble.SetActive(false); ;
    }
    public void MakeScrollVisible()
    {
        this.scroll.SetActive(true);
    }
    public void MakeScrollInvisible()
    {
        this.scroll.SetActive(false); ;
    }

    void Scroll(string txt)
    {
        scroll_txt.text = txt;
        MakeBubbleInvisible();
        MakeScrollVisible();
    }
    void Bubble(string txt)
    {
        bubble_txt.text = txt;
        MakeScrollInvisible();
        MakeBubbleVisible();
    }
}
