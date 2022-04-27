using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOnTrigger : MonoBehaviour
{
    #region Variables

    private GameObject tutorialUI;
    private Tutorial tutorial;

    private GameObject cam;
    private CamFollow camFollow;

    private GameObject tumbler;
    private Controller ctrl;

    private GameObject player;
    private PlayerController p_Ctrl;

    private GameObject baby;
    private Baby babyScript;

    public SpriteRenderer _renderer;
    public Sprite newSprite;

    string tutorialText_HoldRelase;
    string tutorialText_Campfire;
    string tutorialText_Breastfeed;

    private bool  in_Hold, in_BabyHold;
    #endregion

    #region Assign Variables
    void Start()
    {
        tutorialUI = GameObject.Find("TutorialText");
        tutorial = tutorialUI.GetComponent<Tutorial>();

        tumbler = GameObject.Find("Tumbler"); // The wheel
        ctrl = tumbler.GetComponent<Controller>();

        cam = GameObject.Find("Main Camera");
        camFollow = cam.GetComponent<CamFollow>();

        baby = GameObject.Find("Baby");
        babyScript = baby.GetComponent<Baby>();

        player = GameObject.Find("Player");
        p_Ctrl = player.GetComponent<PlayerController>();

        if (MainMenu.lang == "en")
        {
             tutorialText_HoldRelase = "Press the 'space' button to release the TUMBLER.\nPress the 'backspace' button to hold tumbler back in front of it.";
             tutorialText_Campfire = "The weather is cold and your health constantly declining. So you have to warm yourself and your baby. Campfire areas are what you need.";
             tutorialText_Breastfeed = "Elif baby getting hungry constantly. Press 'b' to embrace her and breastfeed. You can't move while she is feeding. Press 'p' to putting her back.";
        }
        else if(MainMenu.lang == "tr")
        {
            tutorialText_HoldRelase = "Kağnıyı serbest bırakmak için 'space' düğmesine basın.\n Kağnıyı geri tutmak için önüne geldikten sonra 'backspace' düğmesine basın. ";
            tutorialText_Campfire = "Hava çok soğuk ve sağlık değerin durmadan azalıyor. Kendini ve bebeğini ısıtmak için kamp ateşleri tam da ihtiyacın olan şey!";
            tutorialText_Breastfeed = "Elif bebek acıkıyor. Onu kucaklamak ve emzirmek için 'b'ye basın. O beslenirken hareket edemezsiniz. Onu geri koymak için 'p' tuşuna basın.";
        }
    }
    #endregion


    #region Trigger Enter-Exit
    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log("TutorialHR trigger");
        if (col.gameObject.tag == "TutorialHR")
        {
            tutorial.ChangeText(tutorialText_HoldRelase);
            tutorial.MakeVisible();
        }
        if (col.gameObject.tag == "TutorialCf")
        {
            tutorial.ChangeText(tutorialText_Campfire);
            tutorial.MakeVisible();
        }
        if (col.gameObject.tag == "TutorialBf")
        {
            tutorial.ChangeText(tutorialText_Breastfeed);
            tutorial.MakeVisible();
        }
        //Animasyon - Oyuncu kazanma noktasına ulaşırsa son oyun ekranına geçilsin.
        if (col.gameObject.tag == "Win")        SceneManager.LoadScene(3);
        if (col.gameObject.tag == "Hold")       in_Hold = true;
        if (col.gameObject.tag == "BabyHold")   in_BabyHold = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Hold") in_Hold = false;
        if (col.gameObject.tag == "BabyHold") in_BabyHold = false;
    }
    #endregion


    void Update()
    {
        // X tuşuna basılırsa ögeyi düsür.
        // backspace tuşuna basılırsa Tumblerı tut
        if (in_Hold && Input.GetKeyDown("backspace"))
        {
            Debug.Log("Hold Trigger");
            HoldTumbler();
        }
        if (in_BabyHold)
        {
            // B tuşuna basılırsa bebeği kucağına al ve besle
            if (Input.GetKeyDown("b"))
            {
                Debug.Log("b key was pressed oN babyHOLD");
                HoldBaby(true, false);
            }
            // P tuşuna basılırsa bebeği yerine koy harekete devamet.
            else if (Input.GetKeyDown("p"))
            {
                Debug.Log("p key was pressed oN babyHOLD");
                HoldBaby(false, true);
            }
        }

    }

 

    void HoldTumbler()
    {
        Debug.Log("Backspace key was pressed iN HOLD");
        ctrl.isEnabled = true;                          // kağnının hareketini durdur
        camFollow.isPlayerConnectedToTumbler = true;    // kağnıyla oyunucuyu birleştir ve kameranın ikisini tutmasını sağla
    }

    void HoldBaby(bool _is_feeding, bool _is_Enabled)
    {
        babyScript.is_feeding = _is_feeding;  // bebeğin beslenme durmunu güncelle

        p_Ctrl.isEnabled = _is_Enabled;     // oyuncu kontol edilebilme durmunu güncelle
        ctrl.isEnabled = _is_Enabled;       // kağnı kontol edilebilme durmunu güncelle

        _renderer.sprite = newSprite;       // bebek tutan resmi göster
        p_Ctrl.Set_IdleAnim();              // animasyonu durdur-başlat

        babyScript.b_renderer.enabled = _is_Enabled;    //kağnının üstündeki bebeğin görünürlük durmunu güncelle
    }
}
