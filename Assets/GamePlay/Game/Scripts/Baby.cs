using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baby : MonoBehaviour
{
    #region Variables
    public float hunger = 100;
    public float currentHunger;
    public float starvation = 1.4f;
    public float feed = 2;
    public BabyHungerBar hungerBar;
    public bool is_feeding ;
    public SpriteRenderer b_renderer;
    private new AudioSource audio;
    #endregion


    #region Assign Variables
    void Start()
    {
       currentHunger = hunger;
       hungerBar.SetHunger(hunger);
       audio = gameObject.GetComponent<AudioSource>();
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
       currentHunger -= starvation * Time.deltaTime;     // Aclik miktari kadar toklugu dusur.
       hungerBar.SetHunger(currentHunger);               // Aclik barini ayarla.
       
        if(is_feeding)  // besleniyorsa emzir.
        {
            currentHunger += feed * Time.deltaTime; //Toklugu arttir.
        }
        if(currentHunger < 50)
        {
            if (!audio.isPlaying) audio.Play();  
        }
        else
            if (audio.isPlaying) audio.Stop();

    }
}
