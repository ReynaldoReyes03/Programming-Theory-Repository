using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    [Header("Links")]
    [TextArea(1, 3)] public string gitHubURL = "https://github.com/ReynaldoReyes03";
    [TextArea(1, 3)] public string projectRepositoryURL = "https://github.com/ReynaldoReyes03/Programming-Theory-Repository";

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
