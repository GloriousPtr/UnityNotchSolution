<h1 align="center" style="border-bottom: none;">
  <a href="https://github.com/MohitSethi99/UnityNotchSolution/">Unity Notch Solution</a>
</h1>

<p align="center">
  <a href=""><img alt="platforms" src="https://img.shields.io/badge/platform-Unity-blue?style=flat-square%22/></a>
  <img alt="GitHub" src="https://img.shields.io/github/license/MohitSethi99/UnityNotchSolution?color=blue&style=flat-square">
  <a href=""><img alt="size" src="https://img.shields.io/github/repo-size/MohitSethi99/UnityNotchSolution?style=flat-square"/></a>
  <br/>
</p>

Thanks for checking out the project!

> This framework will remain `Open Source`

## Status and prerequisites

Current status at a glance:
```
Unity version: 2019.4.21f1 LTS
Packages	  : Device Simulator (For testing inside editor)
```


## Features

- Easy To Use Notch Solution
- Plug and Play

<p align="center">
    <img height="360" src="Documentation/NotchIssue.jpg" alt="NotchIssue" />
    Notch issue.
</p>

<p align="center">
    <img height="360" src="Documentation/NotchSolution.jpg" alt="NotchSolution" />
    Notch Solution.
</p>


## Setting Up

- Make a new gameObject as the child of Background image in the panel and rename it to SafeAreaHolder.
- Attach The SafeArea Script To SafeAreaHolder gameObject.
- Shift all your UI gameObjects inside the SafeAreaHolder gameObject making them the children of SafeAreaHolder.
- Open device simulator and switch to any of the notched devices to test.
- See the below config for more clarification or open the Demo scene.

<p align="center">
    <img height="360" src="Documentation/Config.jpg" alt="Config" />
    Config.
</p>
