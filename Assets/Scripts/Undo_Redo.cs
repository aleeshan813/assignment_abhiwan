using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Undo_Redo : MonoBehaviour
{
    public TMP_InputField inputField;
    

    // undoStack and redoStack store the previous state

    Stack<string> undoStack = new Stack<string>();
    Stack<string> redoStack = new Stack<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTextChanged(string newText)
    {
        undoStack.Push(newText);
    }

    // UndoFunction 
    public void Undo()
    {
        if (undoStack.Count > 0)
        { 
            redoStack.Push(inputField.text);

            string lastState = undoStack.Pop();
            inputField.text = lastState;
        }
    }

    //RedoFunction
   public void Redo()
    {
        if (redoStack.Count > 0)
        {
            string nextState = redoStack.Pop();
            inputField.text = nextState;
        }
    }
}
