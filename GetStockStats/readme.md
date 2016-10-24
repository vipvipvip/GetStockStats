How was this app created:

Tweak the call to the REST API by invoking it directly from the browser.
When desired data is acquired, create a C# from the data by visiting json2csharp.com
Take the classes created and decorate each class with [DataContract] and each field with [DataMember(Name = "<fieldName>")].
W/o this crucial step, you will not be able to serialize the JSON response and see the data.

