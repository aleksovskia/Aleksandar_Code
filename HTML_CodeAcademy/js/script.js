var a = "Tanes"
a = 4;
var a1 = 4
//console.log(a);

var fun = function () {
    var a = "123"
    console.log(a);
    var b = "Test"
    console.log(b);
}

fun();

console.log(a);

var sobiranje = function (a, b) {
    return a + b;
}

console.log(sobiranje(1, 2));

var sobiranje = function (a, b) {
    return { zbir: a + b };
}

var sobirok = sobiranje(1, 2);

console.log(sobirok);

(function () {
    console.log("Ова е анонимна функција");
})();

var a = {
    ime: "Aleksandar",
    prezime: "Tanevski"
};

let b = {
    ime: "Aleksandar",
    prezime: "Tanevski"
};

const
    c = {
        ime: "Aleksandar",
        prezime: "Tanevski"
    };

a = {
    smartphone: "OnePlus",
    ram: 4
}

b.ime = "Tanes";
c.ime = "nesto drugo";