using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
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

    public Rigidbody2D w1;
    public Rigidbody2D w2;
    public new AudioSource audio;
    #endregion

    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (isEnabled)
        {
            // tekerlerin itilebilme kolaylýðýný ayarla
            w1.drag = 1;
            w2.drag = 1;

            // sað sol tuþlarýný al
            this.moveHorizontal = Input.GetAxis("Horizontal"); // X-Axis
            this.moveVertical = Input.GetAxis("Vertical"); // Y-Axis
            this.currentVelocity = this.characterRigidBody.velocity;

            if (this.moveHorizontal != 0)            // haraket haline göre yürüme sesi oynat yada durdur
            {
                if (!audio.isPlaying) audio.Play();
            }
            else audio.Stop();
        }
        else
        {
            // tekerlerin itilebilme kolaylýðýný ayarla
            w1.drag = 1000;
            w2.drag = 1000;
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
}
