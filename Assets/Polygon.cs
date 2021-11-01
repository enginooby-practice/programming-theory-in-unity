using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Polygon : MonoBehaviour {
  // backing fields
  [SerializeField] protected string m_Name;
  [SerializeField] protected float m_EdgeLength;

  // auto property
  public string Name { get; private set; }

  // custom property w/ constraint & validation
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
    Debug.Log("Hi! I'm " + name);
  }

  protected abstract float GetArea();
}
