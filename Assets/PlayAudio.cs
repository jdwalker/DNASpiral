using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using VRTK;

public class PlayAudio : MonoBehaviour {

	public UnityEvent triggerEntered;

	private bool hasFired;


	public  VRTK.VRTK_InteractableObject interactible;

	private void OnEnable()
	{
		interactible.InteractableObjectGrabbed += ObjectGrabbed;
	}
	private void OnDisabe()
	{
		interactible.InteractableObjectGrabbed -= ObjectGrabbed;
	}

	private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
	{
		if (!hasFired)
		{
			hasFired = true;
			if (triggerEntered != null)
			{
				triggerEntered.Invoke();
			}
		}
	}
	
}
