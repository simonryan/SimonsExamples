// 'this' means the owner of the function.

// eg
var f = function() {
    alert(this);
};
f(); // gives [Object window]

// eg
var obj = {
    name: 'Simon',
    myFunc: function () {
        log(this.name);
    }
}
obj.myFunc(); // this = obj
