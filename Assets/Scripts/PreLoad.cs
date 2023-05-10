using UnityEngine;
using UnityEngine.SceneManagement;
public class PreLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SceneLoader", 5);
    }

    // Update is called once per frame
    private void SceneLoader()
    {
        SceneManager.LoadScene("MainMenu");
    }
   

}
