using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Effects : MonoBehaviour
{
    #region Variables
    public GameObject warmEffect;
    public SpriteRenderer warm_renderer;

    public GameObject coldEffect;
    public SpriteRenderer cold_renderer;

    private GameObject player;
    private Player playerScript;

    private GameObject baby;
    private Baby babyScript;
    #endregion

    #region Assign Variables
    void Start()
    {
        baby = GameObject.Find("Baby");
        babyScript = baby.GetComponent<Baby>();

        player = GameObject.Find("Player");
        playerScript = player.GetComponent<Player>();
    }
    #endregion

    void Update()
    {
        if (playerScript.currentHealth < 80.0f) //Saglik 80'den asagi dusunce
        {
            coldEffect.SetActive(true);        // Efekti gorunur yap
            cold_renderer.color = new Color(1f, 1f, 1f, 1.0f- (playerScript.currentHealth/80));     //Opakligi Ayarla
        }
    }
}
