using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class CounterActuator : MonoBehaviour, IPointerClickHandler
{
    [FormerlySerializedAs("_timer")] [SerializeField] private Counter _counter;
    
    private WaitForSeconds _timerDelay;
    private bool _isActive;

    private void Awake()
    {
        _timerDelay = new(0.5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _isActive = !_isActive;
        
        StartCoroutine(StartTimer());
    }
    
    private IEnumerator StartTimer()
    {
        while (_isActive)
        {
            _counter.Increase();

            yield return _timerDelay;
        }
    }
}
