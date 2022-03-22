using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	#region Variables
	public float maxHealth = 100;
	public float currentHealth;
	public float damage = 1.3f;
	public float heal=2;
	public HealthBar healthBar;
	#endregion

	#region Assign Variables
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}
    #endregion

    // Update is called once per frame
    void Update()
	{
		currentHealth -= damage * Time.deltaTime;
		healthBar.SetHealth(currentHealth);
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if (currentHealth<100 && col.gameObject.tag == "Campfire")  // Kamp alaninda oldugun surece cani yukselt.
		{
			Debug.Log("Campfire");
			currentHealth += heal * Time.deltaTime; //Zamanla sagligini  arttir
		}
	}
}
