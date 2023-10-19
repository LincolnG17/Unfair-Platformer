using UnityEngine;
using UnityEngine.UI;

public class ReloadCountDisplay : MonoBehaviour
{
    public Text reloadCountText;
    public SceneReloadCounter sceneReloadCounter;

    private void Update()
    {
        if (sceneReloadCounter != null)
        {
            // Update the text with the current reload count
            reloadCountText.text = "Reload Count: " + sceneReloadCounter.reloadCount;
        }
    }
}