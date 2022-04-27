using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private GameObject player;
    private Player playerScript;
    public Animator anim;


    private GameObject baby;
    private  Baby babyScript;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<Player>();

        baby = GameObject.Find("Baby");
        babyScript = baby.GetComponent<Baby>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScript.currentHealth <= 0.0f || babyScript.currentHunger <= 0.0f)
        {
           Debug.Log("Game Over");
            
           anim.SetBool("is_Dead", true);
           Invoke("Son", 1);
        }
        
    }

    //Menüye döndürüyoruz.
    void Son()
    {
        SceneManager.LoadScene(0);
    }
}
