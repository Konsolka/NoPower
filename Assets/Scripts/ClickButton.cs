using UnityEngine;
using System.Collections;

public class ClickButton : MonoBehaviour
{
	public Material [] material;
	public GameObject [] wireLine;
	public bool isOn;
	Renderer rend;

	private void Start()
	{
		rend = gameObject.transform.GetChild(0).GetChild(1).GetComponent<Renderer>();
		rend.enabled = true;
		if (isOn)
		{
			rend.sharedMaterial = material[1];
			changeTag("On");
		}
		else
		{
			rend.sharedMaterial = material[0];
			changeTag("Off");
		}
	}
	private void OnMouseDown()
	{
		if (isOn)
		{
			isOn = false;
			rend.sharedMaterial = material[0];
			changeTag("Off");
		}
		else
		{
			isOn = true;
			rend.sharedMaterial = material[1];
			changeTag("On");
		}
	}
	void changeTag(string str)
	{
		for (int i = 0; i < wireLine.Length; i++)
			wireLine[i].tag = str;
	}
}
