using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

namespace DefaultNamespace
{

[DisallowMultipleComponent]
public class UIJoinRoom : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TMP_InputField _inputField;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        string text = _inputField.text;

        if (!string.IsNullOrWhiteSpace(text))
           NetworkManager.instance.JoinRoom(text);
        else
           Debug.Log("Must enter a name for text field.");
    }
}
}