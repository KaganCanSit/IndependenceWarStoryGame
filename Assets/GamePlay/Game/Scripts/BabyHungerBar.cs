using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyHungerBar : MonoBehaviour
{

	public Slider slider;
	public Image fill;

	public void SetMaxHuger(float hunger) 
	{
		slider.maxValue = hunger;
		slider.value = hunger;

	}

	public void SetHunger(float hunger)
	{
		slider.value = hunger;
	}
}
