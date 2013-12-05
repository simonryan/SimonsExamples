function SmtpClient() { }

SmtpClient.prototype.send = function (msg) {
    if (!msg.hasOwnProperty("to")) {
        msg.toString = "my.address.com";
    }
}

// using jquery - extends
$.extend(defaults, msg);
var to = defaults.to; // if no 'to' value in msg then the default in 'defaults' is used