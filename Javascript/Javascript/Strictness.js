// Strictness

// it's easy to introduce bugs into code as js is very loose. ECMAScript v5 introduced a mechanism to make js more strict.

"use strict" // will enable strict mode on modern browsers.
var x = "hello"; // ok
y = "hello" // nope! exception thrown

// exceptions caused by..
y = "hello" // undeclared vars
var person = { name: "simon", name: "george" };  // duplicate properties

var s = "hello";
s.length = 5; // writing to read only property

function () {
    arguments = [] // can't modify the arguments Object
}