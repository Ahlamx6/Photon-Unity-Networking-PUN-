using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{

[DisallowMultipleComponent]
public class UIquitgame : MonoBehaviour, IPointerClickHandler
{

  public void OnPointerClick(PointerEventData eventData) 
  {
    Debug.Log("Quit game.");
    Application.Quit();
  } 
}

}