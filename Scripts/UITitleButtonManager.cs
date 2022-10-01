using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using Photon.Pun;
namespace DefaultNamespace
{

[DisallowMultipleComponent]
public class UITitleButtonManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private Button _connectserver;
    [SerializeField] private Button _joinRoomButton;
    [SerializeField] private Button _createRoomButton;
    [SerializeField] private TMP_InputField _inputField;
     
     private void Awake()
     {
        _connectserver.gameObject.SetActive(true);
        _joinRoomButton.gameObject.SetActive(false);
        _createRoomButton.gameObject.SetActive(false);
        _inputField.interactable = false;
     }

    public override void OnConnectedToMaster()
    {
        _connectserver.gameObject.SetActive(false);
        _joinRoomButton.gameObject.SetActive(true);
        _createRoomButton.gameObject.SetActive(true);
        _inputField.interactable = true;
    }

    public override void OnJoinedRoom()
    {
        _joinRoomButton.gameObject.SetActive(false);
        _createRoomButton.gameObject.SetActive(false);
        _inputField.interactable = false;
    }

}
}
