Overview
========
In a default Sitecore installation you do not have much control over the rights to page design - changing the 
presentation details or inserting/removing components from a page.

Users are given access to this by assigning them the `sitecore/Designer` role, but you cannot limit this access to 
individual items or part of the content tree. Sitecore currently isn't build to handle this very well, but it can be 
done although it is a bit "manual" and may stop working or require extra work in future versions.

Implementation
==============
By default, besides looking at write-access, Sitecore checks if you have read access to a `CanDesign` policy item in the
core database to determine if you are able to edit the page presentation details.

This project adds a new access right called **Design** and replaces the `AuthorizationProvider` so it knows about the 
new access right and controls access to the `CanDesign` policy depending on the design access rights on the current context item.

It also extends buttons related to presentation details in the Content Editor and Experience Editor so they also 
listen to this new access right.

> **NOTE**: After installing this you have to allow **Design** explicitly.

![Security Editor](assets/readme/security_editor.png?raw=true)

Limitations
===========
The `__Renderings` standard field it self can still be edited even though the user have not been given access to the new 
**Design** access right.