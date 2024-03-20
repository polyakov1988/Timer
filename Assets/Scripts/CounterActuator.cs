using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class CounterActuator : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Counter _counter;
    
    private WaitForSeconds _timerDelay;
    private bool _isActive;

    private void Awake()
    {
        _timerDelay = new(0.5f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_isActive == false)
        {
            Run();
        }
        else
        {
            Pause();
        }
    }

    private void Run()
    {
        _isActive = true;
        
        StartCoroutine(Countdown());
    }
    
    private void Pause()
    {
        _isActive = false;
    }
    
    private IEnumerator Countdown()
    {
        while (_isActive)
        {
            _counter.Increase();

            yield return _timerDelay;
        }
    }
}
