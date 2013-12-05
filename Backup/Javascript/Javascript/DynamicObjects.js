// creating an object
var customer = {
    name: "Simon Ryan",
    "company name": "Cambridge Assessment",
    address: {
        street: "High Street",
        town: "Stretham",
        postCode: "CB6 3LD"
    }
};

// getting properties
var name = customer.name;
var companyName = customer["company name"];
var street = customer.address.street;

// creating a Javascript class with constructor syntax
function Customer(name, company) {
    this.name = name;
    this.company = company;
}

// create an instance
var cust1 = new Customer("simon", "Cambridge Assessment");

// adding member functions
function Customer2(name, company) {
    this.name = name;
    this.company = company;
    this.sendEmail = function(email) {
        // do stuff here
    };
}

var cust2 = new Customer2("Simon", "Cambridge Assessment");
cust2.sendEmail("someone@somewhere.com");

// creating static members of a class
function Customer3(name, company) {
    this.name = name;
    this.company = company;
}

Customer.mailServer = 'mail.google.com'; // static data available to all instances of Customer.

// Prototypes
// Every object has a prototype object associated to it. The members of the prototype object and available to all instances of 
// of the object it is associated with.

// prototype - sharing a function
function Customer4(name, company) {
    this.name = name;
    this.company = company;
}

Customer4.prototype.mailServer = "mail.google.com";

Customer4.prototype.send = function (email) {
    // do stuff here
    // can access instance members usign this
    email.body = this.name;
    var server = mailServer;
};

var simon = new Customer4("simon", "as");
simon.send("address.com")

