﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This is for the first nuke ops demo:
public class GUI_NukeOps : MonoBehaviour
{

	private int syndiActive;
	private int nanoActive;

	public Text nukeOpsCount;
	public Text nanoCount;

	public Button nukeOpsbtn;


	void Update()
	{
		//THIS WONT WORK AS SYNDICATE ISNT SYNC'D
		nanoActive = GameManager.Instance.ClientGetNanoTrasenCount();
		UpdateCounts();
		SyndiesAllowed();
	}

	bool SyndiesAllowed()
	{

		if (syndiActive > 6)
		{
			nukeOpsbtn.interactable = false;
			return false;
		}
		else
		{
			nukeOpsbtn.interactable = true;
			return true;
		}
	}

	void UpdateCounts()
	{
		nukeOpsCount.text = "Nukes Ops: " + syndiActive;
		nanoCount.text = "Station Crew: " + nanoActive;
	}

	public void NanoTrasenBtn()
	{
		UIManager.Display.jobSelectWindow.SetActive(true);
		gameObject.SetActive(false);
	}

	public void SyndieBtn()
	{
		gameObject.SetActive(false);
	}
}
