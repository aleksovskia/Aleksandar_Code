//Ke go vrati elementot so id demo
document.getElementById("demo")
//JQuery
$("#demo")

//Ke gi vrati elementite so klasa demoClass
document.getElementsByClassName("demoClass")
//JQuery
$(".demoClass")

//Ke gi vrati elementite so klasa demoClass
document.getElementsByClassName("demoClass")
//JQuery
$(".demoClass")

//Ke go vrati elementot so id demo
//innerHtml ke go promeni (пребришува) HTML-ot vo elementot
document.getElementById('demoId').innerHTML = 'Codeacademy'
//Menuva color (CSS), moze da koristite bilo koe property na css
document.getElementById('demoId').style.color = 'red'
//Pisuva na dokumnetot, na celiot html,
//no dokolku htmlot e vekje prikazan ke go prebrise celiot HTML!

// document.write("Aleksandar ")

//Popup modal alert koj ima fokus
// window.alert("Jas sum alert!")
//Pecati vo console (F12 za inspect element i za da otvorite console)
console.log("Hello console world!")


var x, y, z;
x = 5.0;
y = 6;
z = x + y;

// document.write(z);

//se deklarira funkcija
function demoFunction(argument1) {
    console.log(argument1);
}
//se povikuva funkcija
demoFunction("Jas sum argument1")

//se zadava vrednost funkcija na variablata varFunction
var varFunction = function (argumentOdVarFunction) {
    console.log(argumentOdVarFunction);
}
//povikuvame varFunction so eden argument
varFunction("Jas sum argumentOdVarFunction");

//arrow function
var varFunction = (argumentOdVarFunction) => {
    console.log(argumentOdVarFunction);
}

// Traditional Function
function add100(a) {
    return a + 100;
}
// Arrow Function Break Down

// 1. Remove the word "function" and place arrow between the argument and opening body bracket
var add100 = (a) => {
    return a + 100;
}

// 2. Remove the body brackets and word "return" -- the return is implied.
var add100 = (a) => a + 100;

// 3. Remove the argument parentheses
var add100 = a => a + 100;

var dodadi100na111 = add100(111);
console.log(dodadi100na111);

//Konkaterniranje stringovi
var firstName = "Aleksandar";
var lastName = "Tanevski"
var fullName = firstName + " " + lastName;

var fullName1 = "Aleksandar" + " " + "Tanevski" + " " + 3
var fullName2 = "Aleksandar" + " " + "Tanevski" + " " + 3 + 2
var fullName3 = "Aleksandar" + " " + "Tanevski" + " " + (3 + 2)

console.log(fullName1)
console.log(fullName2)
console.log(fullName3)

var a = undefined;
var b = null;
var c = NaN;

console.log(a);
console.log(b);
console.log(c);

var kirilica = "Алекасндар"
console.log(kirilica)

//Do not do it!
var таневски = "123";

/* Ova e multiline
komentar i ke bide komentar se dodeka
ne napiseme */

var tanes = 2;
_self = this;

function testTanes() {
    var tanes = 3;
    console.log(this.tanes)
    function secondFunction() {
        console.log(this.tanes);
    }
    secondFunction();
}

testTanes();

var i = 5;
for (var i = 0; i < 10; i++) {
    // some statements
}
console.log(i);

var i = 5;
for (let i = 0; i < 10; i++) {
    // some statements
}
console.log(i);

var i = 15;
console.log(i);
const PI = 3.14;

console.log("Pi const " + PI);
console.log("This is PI", PI);

var i = 0;
i++;
console.log("i= ", i)

console.log("Ostatok pri delenje", 3 % 2) //3/2 = 1 (i ostatok 1)
console.log("Stepenuvanje", 3 ** 2) //3/2 = 1 (i ostatok 1)

var stringTri = "3";
var brojTri = 3;
var sporedba = stringTri === brojTri;
console.log("Strict equal === na string i int", sporedba)
var razlicno = stringTri != brojTri;
var strictUnequal = stringTri !== brojTri;

var prazna;

console.log("null==undefined", null == undefined);
console.log("null===undefined", null === undefined);
console.log("null==''", null == '');
console.log("undefined==''", undefined == '');

// if (prazna === null || prazna === undefined)
// if (prazna == null)

brojTri += 5;
console.log(brojTri)
console.log(typeof brojTri)
console.log(typeof stringTri)
console.log(typeof [])
console.log(typeof {})
console.log(stringTri instanceof String)

var arr = ["Tanevski"]
arr.push("Aleksandar")
console.log("Array example", arr);
arr.push(3)
console.log("Array example", arr);
arr.push({
    firstName: "Aleksadnar",
    lastName: "Tanevski"
})
console.log("Array example", arr);
arr.push(true)
console.log("Array example", arr);

function fnWOArgs() {
    console.log(123)
}

function myFunction(p1, p2) {
    return p1 * p2;   // The function returns the product of p1 and p2
}

fnWOArgs();
myFunction(3, 4)

var person = {
    firstName: "John",
    lastName: "Doe",
    id: 5566,
    fullName: function () {
        return this.firstName + " " + this.lastName;
    },
    children: [
        {
            firstName: "John",
            lastName: "Doe Junior",
            id: 55667,
            fullName: function () {
                return this.firstName + " " + this.lastName;
            }
        }
    ]
};

console.log(person.fullName())
console.log(person.children[0].fullName())
console.log(person.children[0].fullName)

function displayName() {
    document.getElementById('demo').innerHTML = Date()
}


var exString = '"Aleksandar\\Tanevski\"'
exString = "\"Aleksandar Tanevski\"\nOhrid, 6000"
console.log(exString);
console.log(exString.length)
console.log(arr.length)

var ex1String = "Aleksandar \
Tanevski";
console.log(ex1String);

var multiLineString = `
Aleksandar
Tanevski
This is multiline string
`
console.log(multiLineString);
var str = "Please locate where 'locate' occurs!";
var pos = str.indexOf("locate");
console.log(pos)
console.log(arr.indexOf(3));
var pos = str.lastIndexOf("locate");
console.log(pos)

var pos = str.lastIndexOf("Aleksandar");
console.log(pos)

var str = "Apple, Banana, Kiwi";
var res = str.slice(7, 13);
console.log(res)

var str = "Apple, Banana, Kiwi";
var res = str.slice(-12, -6);
console.log(res)

var str = "Apple, Banana, Kiwi";
var res = str.substr(7, 10);
console.log(res)

var str = "Apple, Banana, Kiwi, Banana";
var res = str.replace("Banana", "Morkov");
console.log(res)

str = "Please visit microsoft and Microsoft!";
var n = str.replace(/Microsoft/gi, "W3Schools");
console.log(n.toUpperCase())

var newStr = str.concat("Hello","World","!");
console.log(newStr)

var str = "       Hello World!        ";
console.log(str.trim());

str = "5";
str = str.padStart(4,0);


var txt = "a,b,c,d,e";   // String
var arrayString = txt.split(",");          // Split on commas

console.log(arrayString)

var x = 100 / "Codeacademy"
console.log(x);

var t = 100 / 0
console.log(t);

var y = x + 10; //Nan + 10 = NaN
console.log(y)

var q = t + 10; //Infinity + 10 = Infinity
console.log(q)

console.log(typeof NaN)

var num = 10240000000;
console.log(num.toString())
console.log("toExponential " + num.toExponential())

console.log(num.toFixed(2))

console.log(parseInt(24.20));
console.log(parseFloat(24.20));
