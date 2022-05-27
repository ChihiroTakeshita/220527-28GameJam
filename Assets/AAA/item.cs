using UnityEngine;
using System.Collections;
public class ItemScript : MonoBehaviour
{

	public int healPoint = 20;
	public LifeScript lifeScript;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "player")
		{
			lifeScript.LifeUp(healPoint);
			Destroy(gameObject);
		}
	}
}