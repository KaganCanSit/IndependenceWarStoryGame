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
        Scroll("Savas yillari cile demet demet, hicran gokleri tutmus, gozyasi diz boyu olmus akiyordu. " +
            "Nice sehit analari oglunun aci haberiyle cigerini dagliyor, nice umutlar baharinda solmustu." +
            "Aclik, yokluk, perisanlik kol geziyordu. Umutlarsa bir baska bahara kalmis gibiydi. " +
            "Bir aksam uzeri koyde tellal bagiriyordu;");

        Invoke("AskerFermaniOkur", 12);
    }

    void AskerFermaniOkur()
    {
        Bubble("Asker:\n– Eyyyyy ahali! Duyduk duymadik demeyin. Cuma günü her haneden bir kisi, Inebolu'ya yük tasimak üzere gidecektir." +
            "\n– Eyyyyy ahali! Duyduk duymadik demeyin. Cuma günü her haneden bir kisi, Inebolu'ya yük tasimak üzere gidecektir." +
            "\n– Eyyyyy ahali! Duyduk duymadik demeyin. Cuma günü her haneden bir kisi, Inebolu'ya yük tasimak üzere gidecektir.");

        Invoke("IkinciScrollGelir", 7);
    }

    void IkinciScrollGelir()
    {
        Scroll("Bu haberden sonra herhangi zamanda oldugu gibi tellal bagirmissa, o aksam konunun gorusulmesi icin koy odasinda toplanti yapilirdi. " +
               "Aksam yapilan toplantida Muhtar su aciklamayi yapti:");
        soldiers.SetActive(false);
        Invoke("MuhtarKonusur1", 10);
    }
    void MuhtarKonusur1()
    {
        headman.SetActive(true);
        Bubble("– Ankara'da acilan yeni Meclis ve kurulan hukumet, Anadolu'ya saldiran Yunan askerine son darbeyi vurabilmek icin kis boyunca hazirlik yapiyormus." +
               "Kulaklari cinlasin iki ay kadar once koyumuze gelen M. Akif, camimizde verdigi vaazda:  " +
               "– 'Bir milletin hayat hakki ve varligini surdurme konusunda ustunuze bir görev düserse, yerine getirmekte asla tereddut etmeyiniz. " +
               "Vatani sahiplenmek icin gerekirse her birimiz, topragin koynuna girmeye aday olabilmeliyiz ki, bu vatan bizimdir diyebilelim, ' demisti.");

        Invoke("MuhtarKonusur2", 10);
    }
    void MuhtarKonusur2()
    {
        Bubble("Komsular! Sizin anlayacaginiz, deniz yoluyla Inebolu'ya getirilen cephane ve top mermilerinin cepheye tasinmasi icin butun cevre köylere görev verilmis. " +
            "Adina ister imece, ister salma, ister baska bir sey deyiniz; tasima isi muhakkak halledilmelidir.Bizim köyün tasima sirasi Cuma günü olarak bildirildi." +
            "Inebolu'dan 80 kagni cephane yüklenerek Kastamonu'ya dogru yola cikmamiz gerekiyor.");

        Invoke("SonScroll", 10);
    }

    void SonScroll()
    {
        Scroll("... Cuma Gunu\nTarih, 1921 yilinin son günleriydi.Birdenbire bastiran kar yollari kaplamisti. Sira ile cephaneler yüklendi." +
            "Yüklemesi yapilan kagnilar yola cikiyordu. Serife Gelin, koyde bakacak kimsesi olmadigi icin Elif'i yanina almisti. " +
            "Serife Gelin'in kagnisina top mermileri yuklendi, yol verildi...\n\n" +
            "Serife Gelin, Inebolu cikisinda kagniyi durdurdu. " +
            "Oraya kadar sirtinda tasidigi kizi Elif icin top mermilerinin arasinda bir yer ayarladi.Tek korunma araci yün yorganini da top mermilerini ve " +
            "kizini yagistan korusun diye,kagni uzerine orttu.Sonra tekrar kagni basina gecip 'Bismillah' diyerek kagniyi cekmeye basladi.");

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
