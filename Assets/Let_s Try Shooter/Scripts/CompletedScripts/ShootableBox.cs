using UnityEngine;
using System.Collections;

public class ShootableBox : MonoBehaviour {
	
	public GameObject 被消失物體;
	public GameObject 會出現物體;

	//The box's current health point total
	public int currentHealth = 3;

	public void Damage(int damageAmount)
	{
		//subtract damage amount when Damage function is called
		currentHealth -= damageAmount;

		//Check if health has fallen below zero
		if (currentHealth <= 0) 
		{
			//if health has fallen below zero, deactivate it 
			
			//gameObject.SetActive (false);
			Destroy(gameObject.transform.gameObject);
			被消失物體.SetActive (false);
			會出現物體.SetActive(true);
		}
	}
}
