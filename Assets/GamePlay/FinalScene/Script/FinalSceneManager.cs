using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalSceneManager : MonoBehaviour
{
    string first_text = "Serife Gelin'in cektigi kagni tekrar durdu. Gozleri kisilmisti. Butun vucut azalari titriyordu. " + 
                        "Hiddetinden dolayi uvendireyi kaldirdi, kaldirdi. Sonra da arka ustu kardan adam gibi gocuverdi.\n\n" + 
                        "Serife Gelin, donmakta oldugunu iste o anda farketti. Yikildigi kar icerisinden cabalayarak kalktiktan sonra, " + 
                        "yine zor bela kagni arabasinin uzerine cikabildi.Elleri ve ayaklari donma noktasina geldigi icin kagniya binerken kac defa kayip " + 
                        "yere dustugunun sayisini bilemiyordu. \n\n Serife Gelin, son bir gayret ile kagniyi son kez cekti." + 
                        "Elif catlayacak gibi aglarken, Serife gelinin kolu kanadi âdeta robotlasiyordu. Kagni sehrin disindaki Kastamonu kislasinin yakinina kadar gelip orada durdu.";
    string second_text ="Kar dinmisti; Elif agliyordu.Anlasilan, butun kuslar Elif'in yasina, onun feryadini dinleyenlere istirak ediyorlardi.\n\n" + 
                        "Iste bu yuzden bu aksam, cumle kuslar suskun, guvercinler sanki tas kesilmis; sigirciklarsa hickirmadan son damla gozyaslarini iclerine " + 
                        "akitiyorlardi. Bu kimsesiz kagninin yanina giden gorevliler karsilastiklari acikli manzarayi soyle not ettiler:";
    string soldier_text = "Asker:\n Kagni uzerinde soguktan donan bir kadinin cesedi vardi. Donmus kadinin cesedini arabadan indirirken, yorganin altinda aglayan bir cocuk sesi isittik...\n\n" + 
                        "Top mermilerinin arasinda, otlara sarili icinde bir kiz cocugu aglamaktan bitkin hale gelmis, boguk ve kisilan sesinin sanki son feryadini ediyordu. Hepimizin ortak kanaati su oldu:\n " + 
                        "Bu Turk anasi canini evladini ve top mermilerini korumak icin kendini feda etmistir.";
    string third_text = "Grup vaktinin kar uzerindeki yansimasi, bu kagninin yanina gelenlerin yanaklarindan suzulen damlaciklari cigdem rengine boyamisti.\n" + 
                        "Batan Gunes ise, Serifeler, Elifler, Zeynepler ve kardelenler icin yeniden dogmak uzere, kizilligini saklarcasina karanligin gogsunde yavas yavas kayboluyordu";

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
