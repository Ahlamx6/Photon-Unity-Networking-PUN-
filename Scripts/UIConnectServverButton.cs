using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{

[DisallowMultipleComponent]

public class UIConnectServverButton : MonoBehaviour, IPointerClickHandler
{
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
       NetworkManager.instance.ConnectToServer();
    }
}
}
