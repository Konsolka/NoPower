using UnityEngine;
using System.Collections;

public class ClickButton : MonoBehaviour
{
	public GameMechanics mechanics;
	public matReturn material;
	public GameObject [] wireLine;
	public bool isOn;
	Renderer rend;

	private void Start()
	{
		rend = gameObject.transform.GetChild(0).GetChild(2).GetComponent<Renderer>();
		rend.enabled = true;
		if (isOn)
		{
			mechanics.changeTag(wireLine, "On");
			rend.sharedMaterial = material.retMatOn();
		}
		else
		{
			mechanics.changeTag(wireLine, "Off");
			rend.sharedMaterial = material.retMatOff();
		}
	}
	private void OnMouseDown()
	{
		if (isOn)
		{
			isOn = false;
			rend.sharedMaterial = material.retMatOff();
			mechanics.changeTag(wireLine, "Off");
		}
		else
		{
			isOn = true;
			rend.sharedMaterial = material.retMatOn();
			mechanics.changeTag(wireLine, "On");
		}
	}
}
