using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
    [SerializeField] 
    private Waffle _wafflePrefab;

    [SerializeField] 
    private GameObject _waffleRoot;

    [SerializeField] 
    private Toaster _toaster;

    private void Start()
    {
        _toaster.TimerIsUp += WaffleSpawn;
    }

    private void WaffleSpawn()
    {
        Instantiate(_wafflePrefab, _waffleRoot.transform);
    }
}