using UnityEngine;

public class Shape : MonoBehaviour {
    // Member variables
    private string m_ShapeName;
    private int m_ShapeLife;

    // Encapsulated fields
    public string ShapeName {
        get { return m_ShapeName; }
        set {
            if (string.IsNullOrEmpty(value)) {
                Debug.LogError("The shape name can't be null or empty.");
                m_ShapeName = "Shape Name";
            } else {
                m_ShapeName = value;
            }
        }
    }

    public int ShapeLife {
        get { return m_ShapeLife; }
        set {
            if (value < 0) {
                Debug.LogWarning("The shape life can't be less than 0");
                m_ShapeLife = 0;
            } else {
                m_ShapeLife = value;
            }
        }
    }

    protected virtual void DisplayText() {

    }

    private void Start() {
        
    }

    private void Update() {
        
    }

    private void OnMouseDown() {
        DisplayText();
    }
}
