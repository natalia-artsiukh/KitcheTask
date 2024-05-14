using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    [SerializeField] 
    private GameObject _lampRoot;

    private Lamp[] _lamps;

    private void Start()
    {
        _lamps = _lampRoot.GetComponentsInChildren<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            for (var i = 0; i < _lamps.Length; i++)
            {
                _lamps[i].Interact();
            }
        }
    }
}