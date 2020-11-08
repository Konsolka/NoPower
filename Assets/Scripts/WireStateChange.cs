using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WireStateChange : MonoBehaviour
{
	public Material [] material;
	private bool _state;
	Renderer rend;
	private void Start()
	{
		changeMaterial(material[0]);
	}
	private void Update()
	{
		if (gameObject.tag == "Off")
			changeMaterial(material[0]);
		else
			changeMaterial(material[1]);
	}
	void changeMaterial(Material material)
	{
		Renderer rend;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
				Transform child = gameObject.transform.GetChild(i).GetChild(1);
				rend = child.GetComponent<Renderer>();
				rend.sharedMaterial = material;
		}
	}
}
