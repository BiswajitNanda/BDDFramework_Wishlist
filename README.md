<B>The objective of this project is to test add, delete & modify orders from the wishlist of the customer. </B> 

<B>Technical Implementation</B>

This project uses Specflow as the primary test automation tool. Specflow is the .NET  equivalent tool of cucumber in C#. To organise the code, Page Object Model has been implemented as it's importat from coding best practices to reduce code duplication primarily.  

The following folders are specially important in the project. 
<b>Config</b> - Holds all config Data,
<b>Features</b> - Holds all feature files, 
<b>Steps</b> - All step definition files,
<b>Helper</b> - All helper functions 

Product to be added or removed get read from a json file in the project. 
<B> Important note </B>
<u>Sorting could not be implemented because of time constraint and the volatile nature of the web page during test development. But the framework has been developed and tests have been implemented for both Add and delete Products from wishlist.  </u>

<b>Areas of Improvement</b>

Though the framework has been built with the best practices in mind, there are some areas of improvement. 
1. Chromdriver path will need to be tied to the project. 
2. Inheritance of Page classed from base classes(which will provide a reference to IWebDriver) 
