using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class navigation : MonoBehaviour {

    public void GantiScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Keluar()
    {
        Application.Quit();
    }
}
