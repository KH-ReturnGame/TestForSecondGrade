using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManage : MonoBehaviour
{
    public GameObject text;
    public void SceneChange()
    {
        SceneManager.LoadScene("Game");
    }

    public void textvisible()
    {
        Instantiate(text, new Vector2(0, 0), Quaternion.identity);
    }
    public void GameExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
