using UnityEngine;
using UnityEngine.SceneManagement;

public class PagesManager : MonoBehaviour
{
    void Update()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (Input.GetKey(KeyCode.Escape)){
            if(sceneName == "Game 1")
            {
                SceneManager.LoadScene("Loading");
            }
            else
            {
                Application.Quit();
            }
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
