using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public enum FIELDTYPE
{
    lightning, bomb, spell
}
public class DropZone : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private FIELDTYPE _type;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.transform.TryGetComponent<Drag>(out Drag drag))
        {
            Debug.Log(_type.Equals(drag.GetFIELDTYPE()));
            if (_type.Equals(drag.GetFIELDTYPE()))
            {
                Debug.Log("Drop zone: set image to transform: eventData.pointerDrag.transform.position: " + eventData.pointerDrag.transform.position + " ; transform.position : " + transform.position);
                eventData.pointerDrag.transform.position = transform.position;
            }
            else
            {
                drag.ResetPos();
            }
        }
    }
}
