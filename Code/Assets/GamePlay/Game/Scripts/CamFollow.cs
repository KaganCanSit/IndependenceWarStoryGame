using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
	#region Variables
	private GameObject target;
	public float y_Offset=4;
	public float z_Offset=10;
	public bool isPlayerConnectedToTumbler=true;
	#endregion

	#region Assign Variables
	void Start()
    {
		target = GameObject.Find("Tumbler"); // The wheel
	}
    #endregion


    void Update()
	{
		if (isPlayerConnectedToTumbler==false) // Eger oyuncu kagniya bagli degilse
		{
			target = GameObject.Find("Player");		// Hedefi oyuncu yap
		}
		//Oyunucyu takip etmeye baþla
		transform.position = new Vector3(target.transform.position.x, target.transform.position.y + y_Offset, target.transform.position.z - z_Offset);
	}
}
