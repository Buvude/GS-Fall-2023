using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.IO;
using UnityEditor.Experimental;

namespace InterDineMension
{
    public class DialogueVariables
    {
        public Dictionary<string, Ink.Runtime.Object> variables {  get; private set; }

        private Story globalVariablesStory;

        private const string saveVariablesKey = "INK_VARIABLES";

        public DialogueVariables(TextAsset loadGlobalJSON)
        {
            //compiles the story
            globalVariablesStory = new Story(loadGlobalJSON.text);
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

        public void SaveVariables()
        {
            if(globalVariablesStory != null)
            {
                VariablesToStory(globalVariablesStory);
                PlayerPrefs.SetString(saveVariablesKey, globalVariablesStory.state.ToJson());
            }
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
            /*Debug.Log("Variable changed: " + name + " = " + value);*/
            //only maintain variables that were initialized from the globals ink file
            if (variables.ContainsKey(name))
            {
                variables.Remove(name);
                variables.Add(name, value);
            }
        }

        private void VariablesToStory(Story story)
        {
            foreach(KeyValuePair<string, Ink.Runtime.Object> variable in variables)
            {
                story.variablesState.SetGlobal(variable.Key, variable.Value);
            }
        }
    }
}
