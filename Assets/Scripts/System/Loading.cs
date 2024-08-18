using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public enum Scenes
    {
        Lobby,
        CustomLevel,
        Play
    }

    public static void LoadScene(Scenes p_scene)
    {
        SceneManager.LoadScene((int)p_scene);
    }
}
