using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class TimerController : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Timer _timer;
    
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
            _timer.Increase();

            yield return _timerDelay;
        }
    }
}
