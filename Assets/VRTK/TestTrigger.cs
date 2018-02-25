using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestTrigger : MonoBehaviour {

	public UnityEvent victoryEvent;

	private int pickedObjects;
	
	// Update is called once per frame
	void OnPickedObject()
	{
		if(pickedObjects > 5)
		{
			victoryEvent.Invoke();
		}
	}
}
