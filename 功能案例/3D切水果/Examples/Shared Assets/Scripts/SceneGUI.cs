// Shatter Toolkit
// Copyright 2011 Gustav Olsson
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGUI : MonoBehaviour
{
	private int toolbarSelection = 0;
	private System.String[] toolbarLabels = { "Basic scene", "UvMapping scene", "Wall scene" };
	
	public void Awake()
	{
        toolbarSelection = SceneManager.GetActiveScene().buildIndex;
       // SceneManager.LoadScene
	}
	
	public void OnGUI()
	{
		toolbarSelection = GUI.Toolbar(new Rect(10, Screen.height - 30, Screen.width - 20, 20), toolbarSelection, toolbarLabels);
		
		if (GUI.changed)
		{
			SceneManager.LoadScene(toolbarSelection);
		}
	}
}