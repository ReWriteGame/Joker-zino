using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRules : MonoBehaviour
{
  [SerializeField, Range(0.01f, 1)] private float percentGameScore = 1;
  [SerializeField] private ScoreCounter score;

  public UnityEvent winGameEvent;
  public UnityEvent loseGameEvent;
  
  
  public void GetGameOutcome()
  {
    if((score.MaxScore * percentGameScore) > score.Score )
      loseGameEvent?.Invoke();
    else winGameEvent?.Invoke();
  }
}
