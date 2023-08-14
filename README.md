# Find Prefabs with Script Tool

The "Find Prefabs with Script" tool is a custom utility for Unity Editor that enables you to locate prefabs containing a specific script. This tool provides a user-friendly interface within the Unity Editor to facilitate the search process.

## Unity Version

This project was created using Unity 2021.3.15f1 LTS.

## Usage

1. Open Unity Editor.
2. Navigate to the "Custom Tools" menu.
3. Select "Find Prefabs with Script" to open the tool's window.
4. In the window, you can do the following:

   - Choose a script: Use the "Script" field to select the script you want to search for.
   - Search in children (optional): Toggle the "Search In Children" option to include child objects in the search.
   - Find: Click the "Find" button to initiate the search.

5. The tool will display a list of prefabs that contain the specified script.

## Features

- Search for prefabs containing a specific script.
- Option to include child objects in the search.
- Visual representation of the search results in a scrollable window.

## Notes

- The tool relies on Unity's AssetDatabase to search for prefabs. It locates prefabs by scanning the project assets.
- The "Search In Children" option determines whether the search should include child objects of prefabs.
- The tool takes advantage of Unity's MonoBehaviour scripting framework.
