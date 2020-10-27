# confirm-address-for-outlook #

Original "Confirm-Address" by Meatian. https://github.com/Meatian/confirm-address/  
Outlook version ported by Keiji Momose. https://github.com/beatkz/confirm-address-outlook/

# How to create the release package #

## Build with Visual Studio ##

* pfx file is not included, so create a long-term self-signed certificate. Refer to [this blog entry](https://mseeeen.msen.jp/code-signing-certificate/)(in Japanese)
* Open "Confirm-AddressforOutlook.sln".
* Open properties C# project at Solution Explorer.
* Click "Signature", and set created self-signed certificate to ClickOnce Manifest and assembly.
* Set solution config (Debug or Release).
* Select Build -> Publish Confirm-Address for Outlook.
* Set publish folder location and click Finish button.
* Release package will create to specified folder.

# Get involved in Translation #

* This add-on uses resx file for localization.
* Please use "[ResXManager](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager)" for translate and modify messages.
