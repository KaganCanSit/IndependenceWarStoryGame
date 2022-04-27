using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalSceneManager : MonoBehaviour
{
    string first_text = "Şerife Gelin'in çektiği kağnı tekrar durdu. Gözleri kısılmıştı. Butun vücut azaları titriyordu. " + 
                        "Üvendiriyi kaldırırken arka üstü kardan adam gibi göçüverdi.\n\n" + 
                        "Donmakta olduğunu işte o anda farketti. Yıkıldığı kar içerisinden çabalayarak kalktıktan sonra, " + 
                        "yine zor bela kağnı arabasının üzerine çıkabildi. Elleri ve ayakları donma noktasına geldiği için kağnıya binerken defalarca düşmüştü.\n\n" +
                        "Serife Gelin, son bir gayret ile kağnıyı son kez çekmeye başladı." + 
                        "Elif çatlayacak gibi ağlarken, Şerife gelinin kolu kanadı âdeta robotlaşıyordu. Şehrin dışındaki Kastamonu kışlasının yakınına kadar gelip orada durdu.";
    string second_text ="Kar dinmişti; Elif ağlıyordu. Anlaşılan, bütün kuşlar Elif'in yasına iştirak ediyorlardi.\n\n" + 
                        "İşte bu yüzden bu akşam, cümle kuşlar suskun, güvercinler sanki taş kesilmiş; sığırcıklarsa hıçkırmadan son damla gözyaşlarını içlerine " + 
                        "akıtıyorlardı. Bu kimsesiz kağnının yanına giden görevliler karşılaştıkları acıklı manzarayı şöyle not ettiler:";
    string soldier_text = "Asker:\n Kağnı üzerinde soğuktan donan ve hayatını kaybeden bir kadın vardı. Kadını arabadan indirirken, yorganın altında ağlayan bir çocuk sesi işittik...\n" + 
                        "Top mermilerinin arasında, otlara sarılı içinde bir kız çocuğu ağlamaktan bitkin hale gelmiş, boğuk ve kısılan sesinin sanki son feryadını ediyordu. Hepimizin ortak kanaati şu oldu:\n " + 
                        "Bu Türk anası canını, evladını ve vatanını korumak için kendini feda etmiştir.";
    string third_text = "Kağnının yanına gelenlerin yanaklarından süzülen damlacıklar tüm karları çiğdem rengine boyamıştı.\n" + 
                        "Batan Güneş ise, Şerifeler, Elifler, Zeynepler ve kardelenler icin yeniden doğmak üzere, kızıllığını saklarcasına karanlığın göğsünde yavaş yavaş kayboluyordu.";

    public GameObject bubble;
    public Text bubble_txt;

    public GameObject scroll;
    public Text scroll_txt;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            OyunaBitir();
        }
    }
    // Start is called before the first frame update
    void Start()
    { 
        Basla();
    }
    void Basla()
    {
        IlkScrollGelir();
    }
    void IlkScrollGelir()
    {
        Scroll(first_text);
        Invoke("IkinciScrollGelir", 25);
    }
    void IkinciScrollGelir()
    {
        Scroll(second_text);
        Invoke("AskerlerKonusur", 15);
    }

    void AskerlerKonusur()
    {
        Bubble(soldier_text);
        Invoke("UcuncuScrollGelir", 15);
    }

    void UcuncuScrollGelir()
    {
        Scroll(third_text);
        Invoke("OyunaBitir", 12);
    }


    void OyunaBitir()
    {
        SceneManager.LoadScene(0);
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
