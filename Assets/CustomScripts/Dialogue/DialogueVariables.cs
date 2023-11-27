using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
using UnityEditor.Experimental;
using UnityEditor;
using Unity.VisualScripting;

namespace InterDineMension
{
    public class DialogueVariables
    {
        public Dictionary<string, Ink.Runtime.Object> variables {  get; private set; }

        internal Story globalVariablesStory;

        private const string saveVariablesKey = "INK_VARIABLES";
        

        
        public DialogueVariables(Story loadGlobalJSON)
        {
            //compiles the story
            globalVariablesStory = loadGlobalJSON;
            //Initialize dictionary

            if(PlayerPrefs.HasKey(saveVariablesKey))
            {
                string jsonState =PlayerPrefs.GetString(saveVariablesKey);
                globalVariablesStory.state.LoadJson(jsonState);
            }

            variables = new Dictionary<string, Ink.Runtime.Object>();
            foreach(string name in globalVariablesStory.variablesState)
            {
                Ink.Runtime.Object value = globalVariablesStory.variablesState.GetVariableWithName(name);
                variables.Add(name, value);
                /*Debug.Log("Initialized global Dialogue Variable: " + name + " = " + value);*/
            }
        }
        public void QuickSaveVariables()
        {
            PlayerPrefs.SetInt("dayVarT", int.Parse(globalVariablesStory.variablesState["dayVar"].ToString()));
            PlayerPrefs.SetString("weekDayT", globalVariablesStory.variablesState["weekDay"].ToString());


            PlayerPrefs.SetInt("convo_numberCST", int.Parse(globalVariablesStory.variablesState["convo_numberCS"].ToString()));
            PlayerPrefs.SetInt("affectionCST", int.Parse(globalVariablesStory.variablesState["affectionCS"].ToString()));
            PlayerPrefs.SetInt("chaosCST", int.Parse(globalVariablesStory.variablesState["chaosCS"].ToString()));

            PlayerPrefs.SetInt("convo_numberNT", int.Parse(globalVariablesStory.variablesState["convo_numberN"].ToString()));
            PlayerPrefs.SetInt("affectionNT", int.Parse(globalVariablesStory.variablesState["affectionN"].ToString()));
            PlayerPrefs.SetInt("chaosNT", int.Parse(globalVariablesStory.variablesState["chaosN"].ToString()));

            PlayerPrefs.SetInt("convo_numberCCT", int.Parse(globalVariablesStory.variablesState["convo_numberCC"].ToString()));
            PlayerPrefs.SetInt("affectionCCT", int.Parse(globalVariablesStory.variablesState["affectionCC"].ToString()));
            PlayerPrefs.SetInt("chaosCCT", int.Parse(globalVariablesStory.variablesState["chaosCC"].ToString()));

            PlayerPrefs.SetInt("convo_numberMT", int.Parse(globalVariablesStory.variablesState["convo_numberM"].ToString()));
            PlayerPrefs.SetInt("affectionMT", int.Parse(globalVariablesStory.variablesState["affectionM"].ToString()));
            PlayerPrefs.SetInt("chaosMT", int.Parse(globalVariablesStory.variablesState["chaosM"].ToString()));

            PlayerPrefs.SetInt("convo_numberGT", int.Parse(globalVariablesStory.variablesState["convo_numberG"].ToString()));
            PlayerPrefs.SetInt("affectionGT", int.Parse(globalVariablesStory.variablesState["affectionG"].ToString()));
            PlayerPrefs.SetInt("chaosGT", int.Parse(globalVariablesStory.variablesState["chaosG"].ToString()));

            PlayerPrefs.SetInt("convo_numberFT", int.Parse(globalVariablesStory.variablesState["convo_numberF"].ToString()));
            PlayerPrefs.SetInt("affectionFT", int.Parse(globalVariablesStory.variablesState["affectionF"].ToString()));
            PlayerPrefs.SetInt("chaosFT", int.Parse(globalVariablesStory.variablesState["chaosF"].ToString()));

            PlayerPrefs.SetInt("BAMLevel", int.Parse(globalVariablesStory.variablesState["BAMLevel"].ToString()));
            PlayerPrefs.SetInt("TTMLevel", int.Parse(globalVariablesStory.variablesState["TTMLevel"].ToString()));
            PlayerPrefs.SetInt("TBMLevel", int.Parse(globalVariablesStory.variablesState["TBMLevel"].ToString()));



            PlayerPrefs.Save();
        }

        public void clearTempVars()
        {
            PlayerPrefs.DeleteKey("newGame");

            PlayerPrefs.DeleteKey("winStatus");

            PlayerPrefs.DeleteKey("dayVarT");
            PlayerPrefs.DeleteKey("weekDayT");


            PlayerPrefs.DeleteKey("convo_numberCST");
            PlayerPrefs.DeleteKey("affectionCST");
            PlayerPrefs.DeleteKey("chaosCST");

            PlayerPrefs.DeleteKey("convo_numberNT");
            PlayerPrefs.DeleteKey("affectionNT");
            PlayerPrefs.DeleteKey("chaosNT");

            PlayerPrefs.DeleteKey("convo_numberCCT");
            PlayerPrefs.DeleteKey("affectionCCT");
            PlayerPrefs.DeleteKey("chaosCCT");

            PlayerPrefs.DeleteKey("convo_numberMT");
            PlayerPrefs.DeleteKey("affectionMT");
            PlayerPrefs.DeleteKey("chaosMT");

            PlayerPrefs.DeleteKey("convo_numberGT");
            PlayerPrefs.DeleteKey("affectionGT");
            PlayerPrefs.DeleteKey("chaosGT");

            PlayerPrefs.DeleteKey("convo_numberFT");
            PlayerPrefs.DeleteKey("affectionFT");
            PlayerPrefs.DeleteKey("chaosFT");

            PlayerPrefs.DeleteKey("BAMLevel");
            PlayerPrefs.DeleteKey("TTMLevel");
            PlayerPrefs.DeleteKey("TBMLevel");
        }
        public void SaveVariables()
        {
            if(globalVariablesStory != null)
            {
                /*VariablesToStory(globalVariablesStory);
                PlayerPrefs.SetString(saveVariablesKey, globalVariablesStory.state.ToJson());*/

                PlayerPrefs.SetInt("dayVar", int.Parse(globalVariablesStory.variablesState["dayVar"].ToString()));
                PlayerPrefs.SetString("weekDay", globalVariablesStory.variablesState["weekDay"].ToString());


                PlayerPrefs.SetInt("convo_numberCS", int.Parse(globalVariablesStory.variablesState["convo_numberCS"].ToString()));
                PlayerPrefs.SetInt("affectionCS", int.Parse(globalVariablesStory.variablesState["affectionCS"].ToString()));
                PlayerPrefs.SetInt("chaosCS", int.Parse(globalVariablesStory.variablesState["chaosCS"].ToString()));

                PlayerPrefs.SetInt("convo_numberN", int.Parse(globalVariablesStory.variablesState["convo_numberN"].ToString()));
                PlayerPrefs.SetInt("affectionN", int.Parse(globalVariablesStory.variablesState["affectionN"].ToString()));
                PlayerPrefs.SetInt("chaosN", int.Parse(globalVariablesStory.variablesState["chaosN"].ToString()));

                PlayerPrefs.SetInt("convo_numberCC", int.Parse(globalVariablesStory.variablesState["convo_numberCC"].ToString()));
                PlayerPrefs.SetInt("affectionCC", int.Parse(globalVariablesStory.variablesState["affectionCC"].ToString()));
                PlayerPrefs.SetInt("chaosCC", int.Parse(globalVariablesStory.variablesState["chaosCC"].ToString()));

                PlayerPrefs.SetInt("convo_numberM", int.Parse(globalVariablesStory.variablesState["convo_numberM"].ToString()));
                PlayerPrefs.SetInt("affectionM", int.Parse(globalVariablesStory.variablesState["affectionM"].ToString()));
                PlayerPrefs.SetInt("chaosM", int.Parse(globalVariablesStory.variablesState["chaosM"].ToString()));

                PlayerPrefs.SetInt("convo_numberG", int.Parse(globalVariablesStory.variablesState["convo_numberG"].ToString()));
                PlayerPrefs.SetInt("affectionG", int.Parse(globalVariablesStory.variablesState["affectionG"].ToString()));
                PlayerPrefs.SetInt("chaosG", int.Parse(globalVariablesStory.variablesState["chaosG"].ToString()));

                PlayerPrefs.SetInt("convo_numberF", int.Parse(globalVariablesStory.variablesState["convo_numberF"].ToString()));
                PlayerPrefs.SetInt("affectionF", int.Parse(globalVariablesStory.variablesState["affectionF"].ToString()));
                PlayerPrefs.SetInt("chaosF", int.Parse(globalVariablesStory.variablesState["chaosF"].ToString()));

                PlayerPrefs.Save();
            }
            else
            {
                Debug.LogError("There is no instance of the globalVariablesStory");
            }
        }

        public void LoadVariables()
        {
            globalVariablesStory.variablesState["dayVar"] = PlayerPrefs.GetInt("dayVar");
            globalVariablesStory.variablesState["weekDay"] = PlayerPrefs.GetString("weekDay");

            globalVariablesStory.variablesState["convo_numberCS"]=PlayerPrefs.GetInt("convo_numberCS");
            globalVariablesStory.variablesState["affectionCS"]=PlayerPrefs.GetInt("affectionCS");
            globalVariablesStory.variablesState["chaosCS"] = PlayerPrefs.GetInt("chaosCS");

            globalVariablesStory.variablesState["convo_numberN"] = PlayerPrefs.GetInt("convo_numberN");
            globalVariablesStory.variablesState["affectionN"] = PlayerPrefs.GetInt("affectionN");
            globalVariablesStory.variablesState["chaosN"] = PlayerPrefs.GetInt("chaosN");

            globalVariablesStory.variablesState["convo_numberCC"] = PlayerPrefs.GetInt("convo_numberCC");
            globalVariablesStory.variablesState["affectionCC"] = PlayerPrefs.GetInt("affectionCC");
            globalVariablesStory.variablesState["chaosCC"] = PlayerPrefs.GetInt("chaosCC");

            globalVariablesStory.variablesState["convo_numberM"] = PlayerPrefs.GetInt("convo_numberM");
            globalVariablesStory.variablesState["affectionM"] = PlayerPrefs.GetInt("affectionM");
            globalVariablesStory.variablesState["chaosM"] = PlayerPrefs.GetInt("chaosM");

            globalVariablesStory.variablesState["convo_numberG"] = PlayerPrefs.GetInt("convo_numberG");
            globalVariablesStory.variablesState["affectionG"] = PlayerPrefs.GetInt("affectionG");
            globalVariablesStory.variablesState["chaosG"] = PlayerPrefs.GetInt("chaosG"  );

            globalVariablesStory.variablesState["convo_numberF"] = PlayerPrefs.GetInt("convo_numberF");
            globalVariablesStory.variablesState["affectionF"] = PlayerPrefs.GetInt("affectionF");
            globalVariablesStory.variablesState["chaosF"] = PlayerPrefs.GetInt("chaosF");

        }
        public void QuickLoadVariables()
        {
            globalVariablesStory.variablesState["dayVar"] = PlayerPrefs.GetInt("dayVarT");
            globalVariablesStory.variablesState["weekDay"] = PlayerPrefs.GetString("weekDayT");

            globalVariablesStory.variablesState["convo_numberCS"] = PlayerPrefs.GetInt("convo_numberCST");
            globalVariablesStory.variablesState["affectionCS"] = PlayerPrefs.GetInt("affectionCST");
            globalVariablesStory.variablesState["chaosCS"] = PlayerPrefs.GetInt("chaosCST");

            globalVariablesStory.variablesState["convo_numberN"] = PlayerPrefs.GetInt("convo_numberNT");
            globalVariablesStory.variablesState["affectionN"] = PlayerPrefs.GetInt("affectionNT");
            globalVariablesStory.variablesState["chaosN"] = PlayerPrefs.GetInt("chaosNT");

            globalVariablesStory.variablesState["convo_numberCC"] = PlayerPrefs.GetInt("convo_numberCCT");
            globalVariablesStory.variablesState["affectionCC"] = PlayerPrefs.GetInt("affectionCCT");
            globalVariablesStory.variablesState["chaosCC"] = PlayerPrefs.GetInt("chaosCCT");

            globalVariablesStory.variablesState["convo_numberM"] = PlayerPrefs.GetInt("convo_numberMT");
            globalVariablesStory.variablesState["affectionM"] = PlayerPrefs.GetInt("affectionMT ");
            globalVariablesStory.variablesState["chaosM"] = PlayerPrefs.GetInt("chaosMT");

            globalVariablesStory.variablesState["convo_numberG"] = PlayerPrefs.GetInt("convo_numberGT");
            globalVariablesStory.variablesState["affectionG"] = PlayerPrefs.GetInt("affectionGT");
            globalVariablesStory.variablesState["chaosG"] = PlayerPrefs.GetInt("chaosGT");

            globalVariablesStory.variablesState["convo_numberF"] = PlayerPrefs.GetInt("convo_numberFT");
            globalVariablesStory.variablesState["affectionF"] = PlayerPrefs.GetInt("affectionFT");
            globalVariablesStory.variablesState["chaosF"] = PlayerPrefs.GetInt("chaosFT");


            globalVariablesStory.variablesState["BAMLevel"] = PlayerPrefs.GetInt("BAMLevel");
            globalVariablesStory.variablesState["TTMLevel"] = PlayerPrefs.GetInt("TTMLevel");
            globalVariablesStory.variablesState["TBMLevel"] = PlayerPrefs.GetInt("TBMLevel");


        }

        
        public void StartListening(Story story)
        {
            //it is important that this is called before listener
            VariablesToStory(story);
            story.variablesState.variableChangedEvent += VariableChanged;
        }

        public void StopListening(Story story)
        {
            story.variablesState.variableChangedEvent -= VariableChanged;
        }

        private void VariableChanged(string name, Ink.Runtime.Object value)
        {
            /*Debug.Log("Variable changed: " + name + " = " + value);
            EditorApplication.isPaused = true;*/
            //only maintain variables that were initialized from the globals ink file
            if (variables.ContainsKey(name))
            {
                variables.Remove(name);
                variables.Add(name, value);
            }
        }

        internal void VariablesToStory(Story story)
        {
            foreach(KeyValuePair<string, Ink.Runtime.Object> variable in variables)
            {
                story.variablesState.SetGlobal(variable.Key, variable.Value);
            }
        }


    }
}
