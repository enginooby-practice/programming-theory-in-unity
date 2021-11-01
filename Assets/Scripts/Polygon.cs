using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Polygon : MonoBehaviour {
  // backing fields
  [SerializeField] protected string m_Color;
  [SerializeField] protected float m_EdgeLength;

  // custom property w/ constraint & validation
  public string Color {
    get => m_Color;
    protected set {
      m_Color = value;
    }
  }

  public float EdgeLength {
    get => m_EdgeLength;
    set {
      if (value <= 0) Debug.LogError("Edge length must be positive.");
      else m_EdgeLength = value;
    }
  }

  private void OnMouseDown() {
    Greeting();
    Debug.Log("My area is " + GetArea());
  }

  private void Greeting() {
    Debug.Log("Hi! I'm " + m_Color);
  }

  protected abstract float GetArea();
}
