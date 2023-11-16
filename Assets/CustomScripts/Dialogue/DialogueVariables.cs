using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
using UnityEditor.Experimental;
using UnityEditor;

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
            Debug.Log(globalVariablesStory.variablesState["dayVar"]);
        }

        public void SaveVariables()
        {
            if(globalVariablesStory != null)
            {
                /*VariablesToStory(globalVariablesStory);
                PlayerPrefs.SetString(saveVariablesKey, globalVariablesStory.state.ToJson());*/

                PlayerPrefs.SetString("dayVar", globalVariablesStory.variablesState["dayVar"].ToString());
                PlayerPrefs.SetString("weekDay", globalVariablesStory.variablesState["weekDay"].ToString());


                PlayerPrefs.SetString("convo_numberCS", globalVariablesStory.variablesState["convo_numberCS"].ToString());
                PlayerPrefs.SetString("affectionCS", globalVariablesStory.variablesState["affectionCS"].ToString());
                PlayerPrefs.SetString("chaosCS", globalVariablesStory.variablesState["chaosCS"].ToString());

                PlayerPrefs.SetString("convo_numberN", globalVariablesStory.variablesState["convo_numberN"].ToString());
                PlayerPrefs.SetString("affectionN", globalVariablesStory.variablesState["affectionN"].ToString());
                PlayerPrefs.SetString("chaosN", globalVariablesStory.variablesState["chaosN"].ToString());

                PlayerPrefs.SetString("convo_numberCC", globalVariablesStory.variablesState["convo_numberCC"].ToString());
                PlayerPrefs.SetString("affectionCC", globalVariablesStory.variablesState["affectionCC"].ToString());
                PlayerPrefs.SetString("chaosCC", globalVariablesStory.variablesState["chaosCC"].ToString());

                PlayerPrefs.SetString("convo_numberM", globalVariablesStory.variablesState["convo_numberM"].ToString());
                PlayerPrefs.SetString("affectionM", globalVariablesStory.variablesState["affectionM"].ToString());
                PlayerPrefs.SetString("chaosM", globalVariablesStory.variablesState["chaosM"].ToString());

                PlayerPrefs.SetString("convo_numberG", globalVariablesStory.variablesState["convo_numberG"].ToString());
                PlayerPrefs.SetString("affectionG", globalVariablesStory.variablesState["affectionG"].ToString());
                PlayerPrefs.SetString("chaosG", globalVariablesStory.variablesState["chaosG"].ToString());

                PlayerPrefs.SetString("convo_numberF", globalVariablesStory.variablesState["convo_numberF"].ToString());
                PlayerPrefs.SetString("affectionF", globalVariablesStory.variablesState["affectionF"].ToString());
                PlayerPrefs.SetString("chaosF", globalVariablesStory.variablesState["chaosF"].ToString());

                PlayerPrefs.Save();
            }
            else
            {
                Debug.LogError("There is no instance of the globalVariablesStory");
            }
        }

        public void LoadVariables()
        {
            globalVariablesStory.variablesState["dayVar"] = PlayerPrefs.GetString("dayVar");
            globalVariablesStory.variablesState["weekDay"] = PlayerPrefs.GetString("weekDay");

            globalVariablesStory.variablesState["convo_numberCS"]=PlayerPrefs.GetString("convo_numberCS");
            globalVariablesStory.variablesState["affectionCS"]=PlayerPrefs.GetString("affectionCS");
            globalVariablesStory.variablesState["chaosCS"] = PlayerPrefs.GetString("chaosCS");

            globalVariablesStory.variablesState["convo_numberN"] = PlayerPrefs.GetString("convo_numberN");
            globalVariablesStory.variablesState["affectionN"] = PlayerPrefs.GetString("affectionN");
            globalVariablesStory.variablesState["chaosN"] = PlayerPrefs.GetString("chaosN");

            globalVariablesStory.variablesState["convo_numberCC"] = PlayerPrefs.GetString("convo_numberCC");
            globalVariablesStory.variablesState["affectionCC"] = PlayerPrefs.GetString("affectionCC");
            globalVariablesStory.variablesState["chaosCC"] = PlayerPrefs.GetString("chaosCC");

            globalVariablesStory.variablesState["convo_numberM"] = PlayerPrefs.GetString("convo_numberM");
            globalVariablesStory.variablesState["affectionM"] = PlayerPrefs.GetString("affectionM");
            globalVariablesStory.variablesState["chaosM"] = PlayerPrefs.GetString("chaosM");

            globalVariablesStory.variablesState["convo_numberG"] = PlayerPrefs.GetString("convo_numberG");
            globalVariablesStory.variablesState["affectionG"] = PlayerPrefs.GetString("affectionG");
            globalVariablesStory.variablesState["chaosG"] = PlayerPrefs.GetString("chaosG"  );

            globalVariablesStory.variablesState["convo_numberF"] = PlayerPrefs.GetString("convo_numberF");
            globalVariablesStory.variablesState["affectionF"] = PlayerPrefs.GetString("affectionF");
            globalVariablesStory.variablesState["chaosF"] = PlayerPrefs.GetString("chaosF");

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
