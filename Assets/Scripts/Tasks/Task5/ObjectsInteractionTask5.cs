using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    [SerializeField] 
    private Shelf _shelf1;
    [SerializeField] 
    private Shelf _shelf2;

    private void Awake()
    {
        _shelf1.ItemSpawned += ItemsSpawnHandler;
        _shelf2.ItemSpawned += ItemsSpawnHandler;
    }

    private void ItemsSpawnHandler()
    {
        if (_shelf1.ItemsCount > 3)
        {
            _shelf1.Fall();
            _shelf1.ItemSpawned -= ItemsSpawnHandler;
        } 
        if (_shelf2.ItemsCount > 3)
        {
            _shelf2.Fall();
            _shelf2.ItemSpawned -= ItemsSpawnHandler;
        }
    }
}