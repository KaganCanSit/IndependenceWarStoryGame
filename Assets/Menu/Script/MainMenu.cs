using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI output;
    public static string lang="tr";
    public TextMeshProUGUI playGame,selectGame,option,about,quit;
    public TextMeshProUGUI vol, language, difficulty, returnMenu;
    public TextMeshProUGUI about_Header, about_Info, about_returnMenu;

    public void HandleInputData(int val)
    {
        if(val== 1)
        {
            lang = "en";
            Debug.Log("English");
            ChangeTextLang("PLAY GAME","SELECT GAME","OPTION","ABOUT","QUIT",
                           "VOLUME","LANGUAGE","DIFFUCULTY","RETURN MENU", "Story of War of Independence", "This game was made by �mer Faruk Y�lmaz and Ka�an Can �it to enable children to realize our historical values and to keep our values of the War of Independence alive.\n\n It is forbidden to copy, distribute and sell without any commercial goal and direction. It is forward-looking and open to development for us. It will continue as a project.\n\nWe leave our Github accounts below for those who want to contribute and help us learn in this direction.\n\nhttps://github.com/OmerFarukYilmaz-github\nhttps://github.com/KaganCanSit\n\n\n Thank you in advance.", "RETURN MENU");
        }
        else if(val == 2)
        {
            lang = "tr";
            Debug.Log("Turkce");
            ChangeTextLang("OYUNU OYNA", "OYUN SEC", "SECENEKLER", "HAKKINDA", "CIKIS",
                           "SES", "DIL", "ZORLUK", "MENUYE DON", "Kurtulu� Sava�� Hikayeleri", "Bu oyun �mer Faruk Y�lmaz ve Ka�an Can �it taraf�ndan �ocuklar�n tarihi de�erlerimizi fark etmesini sa�lamak ve Kurtulu� Sava�� de�erlerimizi ya�atmak ad�na yap�lm��t�r.\n\nHi� bir ticari hedef ve do�rultusu olmamak ile birlikte izinsiz �ekilde kopyalanmas�, da��t�lmas� ve sat��a sunulmas� yasakt�r.Bizler i�in ileriye d�n�k ve geli�tirmeye a��k bir proje olarak yerine s�rd�rmeye devam edicektir.\nBu do�rultuda katk�da bulunmak ve ��renmemize yard�m etmek isteyenlerin Github hesaplar�m�z� a�a��ya b�rak�yoruz.\n\nhttps://github.com/OmerFarukYilmaz-github\nhttps://github.com/KaganCanSit\n\n\n�imdiden te�ekk�r ederiz.", "MENUYE DON");
        }
    }

    void ChangeTextLang(string playGame, string selectGame, string option, string about, string quit, 
                        string vol, string language, string difficulty, string returnMenu, 
                        string about_Header, string about_Info, string about_returnMenu)
    {
        this.playGame.text = playGame;
        this.selectGame.text = selectGame;
        this.option.text = option;
        this.about.text = about;
        this.quit.text = quit;
        this.vol.text = vol;
        this.language.text = language;
        this.difficulty.text = difficulty;
        this.returnMenu.text = returnMenu;
        this.about_Header.text = about_Header;
        this.about_Info.text = about_Info;
        this.about_returnMenu.text = about_returnMenu;

    }

    //Oyun sahnesine menu �zerinden ge�i?
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame ()
    {
        //Log att?rarak �?k?? i?leminin oldu?una dair bilgi veriyoruz.
        Debug.Log("Now Quit The Game!");
        Application.Quit();
    }


}
