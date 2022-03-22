using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    private float moveHorizontal;
    private float moveVertical;
    [SerializeField]
    public float movementSpeed = 3f;

    public Rigidbody2D characterRigidBody;
    public Camera mainCamera;
    private Vector2 currentVelocity;
    public bool isEnabled = true;

    public Animator anim;
    private bool is_facingRight = true;
    public bool does_HaveBaby;

    public GameObject cam;
    private CamFollow camFollow;

    public GameObject tumbler;
    private Controller ctrl;

    private SpriteRenderer _renderer;
    private new AudioSource audio;
    #endregion

    #region Assign Variables
    void Start()
    {
        tumbler = GameObject.Find("Tumbler"); // The wheel
        ctrl = tumbler.GetComponent<Controller>();

        cam = GameObject.Find("Main Camera");
        camFollow = cam.GetComponent<CamFollow>();

        _renderer = GetComponent<SpriteRenderer>();
        audio = gameObject.GetComponent<AudioSource>();
    }
    #endregion

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))      //space e basýlýrsa 
        {
            Debug.Log("space key was pressed");
            ctrl.isEnabled = false;                             // kagnýnýn hareketini durdur 
            camFollow.isPlayerConnectedToTumbler = false;       // baglantýlarýný kopar. kamera oyuncuyu kontrole baslasýn
        }

        if (isEnabled)      // kontrol aktifken
        {
            this.moveHorizontal = Input.GetAxis("Horizontal"); // X-Axis
            this.moveVertical = Input.GetAxis("Vertical"); // Y-Axis
            this.currentVelocity = this.characterRigidBody.velocity;
        }

        if(this.moveHorizontal !=0 )            // haraket haline göre yürüme animasyonunu oynat yada durdur
        {
            anim.SetBool("is_walking", true);

            if (!audio.isPlaying) audio.Play();
        }
        else
        {
            anim.SetBool("is_walking", false);
            audio.Stop();
        }

        // gidilen yöne göre oyuncuyu çevir
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            _renderer.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _renderer.flipX = true;
        }

    }

    private void FixedUpdate()
    {
        if (isEnabled)
        {
            if (this.moveHorizontal != 0)
            {
                this.characterRigidBody.velocity = new Vector2(this.moveHorizontal * this.movementSpeed, this.currentVelocity.y);
            }
        }
    }

    void Flip() //Oyuncu resmini saga veya sola cevirir.
    {
        is_facingRight = !is_facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= 1;
        transform.localScale = Scaler;
    }

    public void Set_IdleAnim()     // Dururken animasyona sahip. Eðer bebegi besliyorsa animasyonu durdur, yada tam tersini yap.
    {
        does_HaveBaby = !does_HaveBaby;
        anim.gameObject.GetComponent<Animator>().enabled = !does_HaveBaby;
        anim.SetBool("does_HaveBaby", does_HaveBaby);
    }

}