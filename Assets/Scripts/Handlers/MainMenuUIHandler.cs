using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuUIHandler : MonoBehaviour {
    public void OpenGitHubURL() {
        Application.OpenURL(GameManager.Instance.gitHubURL);
    }

    public void OpenProjectURL() {
        Application.OpenURL(GameManager.Instance.projectRepositoryURL);
    }

    public void ExitGame() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBGL
            Application.OpenURL(GameManager.Instance.gitHubURL);
        #else
            Application.Quit();
        #endif
    }
}
