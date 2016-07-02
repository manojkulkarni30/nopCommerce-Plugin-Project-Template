# nopCommerce Plugin Class Library Project Template
A simple class library to get started quickly with nopCommerce plugin development. This library contains basic content which are required for nopCommerce plugin like Description.txt, plugin configuration file etc.

Download
- [Visual Studio Gallery](https://secure.wikimedia.org/wikipedia/en/wiki/Markdown)

In nopCommerce project, you just need to right click on Plugins folder and select Add => New Project option as shown below. 

![Add New Project](https://github.com/manojkulkarni30/nopCommerce-Plugin-Project-Template/blob/master/nopCommercePluginTemplate/Snapshots/Add-NewProject-Dialog.png)

It will open up the project dialog. Project template is visible under Visual C# => Windows Desktop => nopCommerce menu as shown below. 
![Project Dialog Window](https://github.com/manojkulkarni30/nopCommerce-Plugin-Project-Template/blob/master/nopCommercePluginTemplate/Snapshots/Add-Plugin-Project.png)

Select the nopCommerce Plugin Class Library project and give it a name and click on Ok button. After clicking on Ok button plugin project will be added under Plugins folder. 

This project contains files like Description.txt, default logo image, plugin setting file, a controller, a view and web.config file as shown below.

![Plugin Project Content](https://github.com/manojkulkarni30/nopCommerce-Plugin-Project-Template/blob/master/nopCommercePluginTemplate/Snapshots/ProjectContent.png)

Build path for the project is also set to Nop.Web\Plugins folder and output path is also set for files like Description.txt, logo image, web.config and view. So that when you build a plugin content of the plugin will get copied to Nop.Web\Plugins folder as shown below. 

![Plugin Project Build Output](https://github.com/manojkulkarni30/nopCommerce-Plugin-Project-Template/blob/master/nopCommercePluginTemplate/Snapshots/PluginBuildContent.png)

**Note: You just need to change the version of nopCommerce according to your nopCommerce project version in Description.txt file. By default it is set as 3.70.**

When you run the project and go to Plugins section in admin you will be able to see the plugin in admin section under Misc group as shown below.

![Plugin Project Build Output](https://github.com/manojkulkarni30/nopCommerce-Plugin-Project-Template/blob/master/nopCommercePluginTemplate/Snapshots/Plugin.png)
