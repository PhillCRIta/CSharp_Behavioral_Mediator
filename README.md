### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Mediator pattern
 Define a Mediator / object that describe how a set of objects interact with each other. \
 Can be used with observer pattern.

 In our example, the DialogBoxMediator - abstract - will be concretize in PostDialogBox class, dialog box is the center of the system, fileds for all UI component.

Notes:
- group of ui component
- all ui component can be grouped 
- every ui can talk and know its owner
- every single uicomponent need a single mediator owner