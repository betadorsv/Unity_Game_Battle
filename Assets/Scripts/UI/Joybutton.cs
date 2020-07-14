using UnityEngine;
using UnityEngine.EventSystems;
public class Joybutton : MonoBehaviour ,IPointerUpHandler,IPointerDownHandler
{
    // Start is called before the first frame update

    [HideInInspector]
    public  bool Pressed;


    

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

}
