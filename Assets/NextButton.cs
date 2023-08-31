using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite hoverSprite;
    private Sprite normalSprite;
    private Image buttonImage;

    private void Start()
    {
        // Get the default sprite from the UI Button's Image component
        buttonImage = GetComponent<Image>();
        normalSprite = buttonImage.sprite;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Change the sprite to the hover sprite when the mouse enters
        buttonImage.sprite = hoverSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Change the sprite back to the normal sprite when the mouse exits
        buttonImage.sprite = normalSprite;
    }
}
