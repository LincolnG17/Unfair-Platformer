using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite HoverSprite;
    public Image ButtonImage; 
    public Sprite StationarySprite;
    public string SceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        ButtonImage = GetComponent<Image>();
        StationarySprite = ButtonImage.sprite;
        ButtonImage.enabled = false;
    }

    public void OnPointerEnter (PointerEventData eventData)
    {
        ButtonImage.sprite = HoverSprite;
    }    
   public void OnPointerExit (PointerEventData eventData) 
    {
        ButtonImage.sprite = StationarySprite;
    }
        
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneToLoad);
    }    
}
