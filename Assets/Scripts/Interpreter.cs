using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public enum Instruction
{
    INST_WAIT = 0,
    INST_MOVE_RIGHT = 1,
    INST_MOVE_LEFT = 2,
    INST_MOVE_FWD = 3,
    INST_REG_ATTACK = 4,
    INST_SPELL_ATTACK = 5,
    INST_DEFEND = 6,
    INST_DIE = 7
}

public class Interpreter : MonoBehaviour {

    private void Start()
    {
        Debug.Log(Application.dataPath);
        string[] text = File.ReadAllLines(Application.dataPath + "/Resources/behaviour1.txt");
        int[] behaviour = new int[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            behaviour[i] = int.Parse(text[i]);
        }

        StartCoroutine(Interpret(behaviour));
    }

    IEnumerator Interpret(int[] behaviour)
    {
        for (int i = 0; i < behaviour.Length; i++)
        {
            Instruction instruction = (Instruction)behaviour[i];

            switch (instruction)
            {
                case Instruction.INST_WAIT:
                    Debug.Log("Wait...");
                    break;
                case Instruction.INST_MOVE_RIGHT:
                    Debug.Log("Move Right...");
                    break;
                case Instruction.INST_MOVE_LEFT:
                    Debug.Log("Move Left...");
                    break;
                case Instruction.INST_MOVE_FWD:
                    Debug.Log("Move Forward...");
                    break;
                case Instruction.INST_REG_ATTACK:
                    Debug.Log("Attack...");
                    break;
                case Instruction.INST_SPELL_ATTACK:
                    Debug.Log("Spell Attack...");
                    break;
                case Instruction.INST_DEFEND:
                    Debug.Log("Defend...");
                    break;
                case Instruction.INST_DIE:
                    Debug.Log("Die...");
                    break;
                default:
                    break;
            }
            yield return new WaitForEndOfFrame();
        }
    }
}
