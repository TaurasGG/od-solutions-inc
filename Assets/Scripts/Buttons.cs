using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void OpenScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
