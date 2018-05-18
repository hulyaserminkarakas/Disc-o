using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
    public void OpenLevelLoaderScreen()
    {
        GameObject go = GameObject.FindGameObjectWithTag("MainCamera");
        go.transform.position = new Vector3(1584f, 2f, -1f);
        GUI.backgroundColor = Color.clear;
    }

    public void OpenOptionsScreen()
    {
        GameObject go = GameObject.FindGameObjectWithTag("MainCamera");
        go.transform.position = new Vector3(580f, -1098f, -1f);
        GUI.backgroundColor = Color.clear;
    }

    public void LoadLevel1()
    {
        Application.LoadLevel(1);
    }

    public void MainMenu()
    {
        GameObject go = GameObject.FindGameObjectWithTag("MainCamera");
        go.transform.position = new Vector3(-349f, 6f, -1f);
        GUI.backgroundColor = Color.clear;
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
