using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    //references the TextObjUI
    public Text text;
    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom };
    private States myState;
    // Use this for initialization
    void Start()
    {
        myState = States.cell;
    }

    // Update is called once per frame, 
    void Update()
    {
        print(myState);
        if (myState == States.cell)          { state_cell(); }
        else if (myState == States.sheets_0) { state_sheets_0(); }
        else if (myState == States.sheets_0) { state_sheets_1(); }
        else if (myState == States.sheets_0) { state_lock_0(); }
        else if (myState == States.sheets_0) { state_lock_1(); }
        else if (myState == States.sheets_0) { state_mirror(); }
        else if (myState == States.sheets_0) { state_cell_mirror(); }
        else if (myState == States.sheets_0) { state_freedom(); }

    }

    void state_cell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are" +
                "some dirty sheets on the bed, a mirror on the wall, and the door " +
                "is locked from the outside.\n\n" +
                "Press S to view sheets, M to view MIrror and L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }

    }

    void state_sheets_0()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
            "time somebody changed them. The pleasures of prison life " +
            "I guess! \n\n" +
            "Press R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_mirror()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
            "time somebody changed them. The pleasures of prison life " +
            "I guess! \n\n" +
            "Press R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_lock_0()
    {
        text.text = "This is one of those button locks. you have noidea what the" +
            "combination is. Youwish you could somehow see where the dirty " +
            "fingerprints were, maybe that would help.\n\n" +
            "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_cell_mirror()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
            "time somebody changed them. The pleasures of prison life " +
            "I guess! \n\n" +
            "Press R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_sheets_1()
    {
        text.text = "Holding the mirror in your hand doesn't make the sheets look " +
            "any better. \n\n" +
            "Press R to Return to roaming your cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_lock_1()
    {
        text.text = "You carefully put the mirror through the bars, and turn it round " +
            "so you can see the lock. You can just make out the fingerprints around " +
            "the buttons. you press the dirty buttons, and hear a click. \n\n" +
            "Press 0 to Open, or R to return to your cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            myState = States.freedom;
        }
    }

    void state_freedom()
    {

    }
}
