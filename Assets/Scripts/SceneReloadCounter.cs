using UnityEngine;

public class SceneReloadCounter : MonoBehaviour
{
    public int reloadCount;

    private void Start()
    {
        // Load the previous reload count from PlayerPrefs
        reloadCount = PlayerPrefs.GetInt("ReloadCount", 0);

        // Display the initial count
        Debug.Log("Scene reload count: " + reloadCount);
    }

    public void ReloadScene()
    {
        // Increment the reload count
        reloadCount++;

        // Save the updated count to PlayerPrefs
        PlayerPrefs.SetInt("ReloadCount", reloadCount);
        PlayerPrefs.Save();

        // Reload the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}