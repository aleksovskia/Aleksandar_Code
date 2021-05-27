// // console.log("Hello Array");


// //Декларирање array
// var arr = [1, "Text", true, {}]
// //Пристап до првиот елемент
// // console.log("Првиот елемент е:", arr[0]);
// // console.log("Првиот елемент е:", arr[1]);

// // arr.push(false);
// // arr.push({ firstName: "Aleksandar", lastName: "Tanevski" })

// // console.log(arr);
// // console.log("Должина на array", arr.length)

// var arrNumbers = [4, 2, 1, 3, 6, 7, 8];
// // console.log("Последниот елемент", arrNumbers[arrNumbers.length - 1]);

// for (let i = 0; i < arrNumbers.length; i++) {
//     const element = arrNumbers[i];
//     //console.log("Елементот на позиција: " + i + " Има вредност " + element)
// }

// arrNumbers.forEach(x => {
//     //console.log("Елемент: " + x)
// });

// arrNumbers.forEach((element, i) => {
//     //console.log("Елементот на позиција: " + i + " Има вредност " + element)
// });

// var functionZaForEach = function (x) {
//     //console.log("Елемент: " + x)
// }

// var functionZaForEach = (element, index) => {
//     //console.log("Елемент: " + element + " Index: " + index)
// }

// //arrNumbers.forEach(functionZaForEach);

// //Доколку дефинирате елемент во низа со индекс поголем од последниот елемент
// //се до тој елемент, елементите ќе бидат undefined
// arrNumbers[10] = 9000;
// // console.log(arrNumbers);

// let person = [];
// person["firstName"] = "John";
// person["lastName"] = "Doe";
// person["age"] = 46;

// //Ќе ги земе сите елементи и ќе ги спои во еден стринг, поделени со ,
// var arrNumbersString = arrNumbers.toString();
// //console.log(arrNumbersString); 

// //Ќе ги земе сите елементи и ќе ги спои во еден стринг, поделени со било што
// var arrNumbersString = arrNumbers.join("^^^");
// //console.log(arrNumbersString); 


// //Извади го последниот елемент од низата
// console.log(arrNumbers.toString());
// var pop = arrNumbers.pop()
// console.log("Попнат елемент",pop);
// console.log(arrNumbers);

// //Додади елемент во низата (на крај)
// arrNumbers.push(10000);
// console.log(arrNumbers);
// console.log("-------------");

// //Извади го првиот елемент од низата
// var shift = arrNumbers.shift();
// console.log(shift);
// console.log(arrNumbers);

// //Додади елемент на почеток од низата
// var fruits = ["Banana", "Orange", "Apple", "Mango"];
// fruits.unshift("Lemon");    // Adds a new element "Lemon" to fruits
// console.log(fruits); //["Lemon", "Banana", "Orange", "Apple", "Mango"];

// fruits[2] = "Grapes";
// console.log(fruits)

// delete fruits[2]
// console.log(fruits)

//# SPLICE!

// //Тука ќе се промени оригиналната листа која што сме ја проследиле како аргумент
// // на функцијата 'funkcijaZaLista'
// var fruits = ["Banana", "Orange", "Apple", "Mango"];
// console.log("Fruits Pred izvrsuvanje na funkcijata " + fruits.toString())

// var funkcijaZaLista = (lista) => {
//     lista[0] = "Tanes"
//     return lista;
// }

// funkcijaZaLista(fruits);

// console.log("Fruits posle izvrsuvanje na funkcijata " +  fruits.toString())


// //Ако не сакам да работам со оригиналната листап, мора да се нарави копија на листата
// //копија може најлесно да направиме со функцијата slice() и тогаш fruits ќе остане непроменета

// var fruits = ["Banana", "Orange", "Apple", "Mango"];
// console.log("Pred izvrsuvanje na funkcijata " + fruits.toString())

// var funkcijaZaLista = (lista) => {
//     var novaLista = lista.splice();
//     novaLista[0] = "Tanes"
//     return novaLista;
// }

// funkcijaZaLista(fruits);

// console.log("Fruits posle izvrsuvanje na funkcijata " +  fruits.toString())


// //За неОБЈКЕТИ (примитивни типови) ова погоре не важи, бидејќи доколку проследите
// //примитивиен тип како аргумент на функција тогаш се проследува вредноста на аргументот
// //и проследениот аргумент нема да биде променет
// var number = 5;
// console.log(number.toString());
// var funkcijaZaNumber = (broj)=>{
//     broj = 10;
// }
// funkcijaZaNumber(number);
// console.log(number.toString());

// var fruits = ["Banana", "Orange", "Apple", "Mango"];
// var deletedElements = fruits.splice(2, 2,"Lemon", "Kiwi");
// console.log(fruits);
// console.log("Deleted elements:", deletedElements);

// var fruits = ["Banana", "Orange", "Apple", "Mango"];
// var deletedElements = fruits.splice(2, 2);
// console.log(fruits);
// console.log("Deleted elements:", deletedElements);


// //#Primer
// var fruits = ["Banana", "Orange", "Apple", "Mango"];
// var fruits1 = ["Grapes", "Lime"];
// var fruits2 = ["Strawberry", "Tomato"];
// var joined = fruits.concat(fruits1,fruits2,"Peter");
// console.log(joined)


//#Slice

// var fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
// var citrus = fruits.slice(2, 3); // врати ги елементите што се на индекс 2 , 3
// // [2,4) ===== 2 , 3 ===== Поголемо и еднакво на 2, но помало од 4 ==== 2, 3
// console.log(fruits)
// console.log(citrus)

// var fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango"];
// var citrus = fruits.slice(3); // почни од индекс 3 (вклучено и 3) до крај на листата
// console.log(fruits)
// console.log(citrus)

// var fruits = ["Banana", "Orange", "Apple", "Mango"];
// console.log(fruits.sort()); // Sorts the elements of fruits

// var fruits = ["Banana", "Orange", "Abpple", "Abcpple", "Mango"];
// console.log(fruits.sort()); // Sorts the elements of fruits

// var fruits = ["Banana", "Orange", "Abpple", "Abcpple", "Mango"];
// console.log(fruits.reverse()); // Sorts the elements of fruits

// var points = [100, 40, 1, 5, 25, 10];
// points.sort(function (a, b) { return a - b });
// console.log(points)

// var customObjects = [
//     {
//         firstName: "Aleksandar",
//         lastName: "Tanevski",
//         age: 28
//     },
//     {
//         firstName: "BViktor",
//         lastName: "Tanevski",
//         age: 20
//     },
//     {
//         firstName: "CLionel",
//         lastName: "Messi",
//         age: 33
//     }
// ];

// //ова е compare функција која ги сортира објектите од најголем до најмал по име
// var customCompareReverseFirstname = (ob1, ob2) => {
//     if (ob1.firstName.toLowerCase() > ob2.firstName.toLowerCase()) return -1;
//     if (ob1.firstName.toLowerCase() == ob2.firstName.toLowerCase()) return 0;
//     if (ob1.firstName.toLowerCase() < ob2.firstName.toLowerCase()) return 1;
// }

// //ова е compare функција која ги сортира објектите од најмлад до најстар по age
// var customCompareAge = (ob1, ob2) => {
//     return ob1.age - ob2.age;
// }

// //ова е compare функција која ги сортира објектите од најстар до најмлад по age
// var customCompareAgeReverse = (ob1, ob2) => {
//     return ob2.age - ob1.age;
// }

// customObjects.sort()
// console.log(customObjects);

// customObjects.sort(customCompareReverseFirstname)
// console.log(customObjects);

// customObjects.sort(customCompareAge)
// console.log(customObjects);

// customObjects.sort(customCompareAgeReverse)
// console.log(customObjects);

//#1704


// var txt = "";

// var numbers = [45, 4, 9, 16, 25];
// numbers.forEach((myFunction));

// function myFunction(value, index, array) {
//   txt = txt + value + "<br>";
// }

// console.log(txt);


// var txt = "";

// var numbers = [45, 4, 9, 16, 25];
// var numbers123 = [];

// numbers.forEach(myFunction);

// function myFunction(value, index, array) {
//   numbers123.push(value * 2);
// }

// console.log(numbers123);


// var numbers1 = [45, 4, 9, 16, 25];
// var numbers2 = numbers1.map(myFunction1);

// function myFunction1(value, index, array) {
//   return value * 2;
// }
// console.log(numbers2);

// var customObjects = [
//     {
//         firstName: "Aleksandar",
//         lastName: "Tanevski",
//         age: 28
//     },
//     {
//         firstName: "BViktor",
//         lastName: "Tanevski",
//         age: 20
//     },
//     {
//         firstName: "CLionel",
//         lastName: "Messi",
//         age: 33
//     }
// ];

// var newCustomObjects = customObjects.map((el, index, array) => {
//     var newAge = el.age + 1;
//     return {
//         firstName: el.firstName,
//         lastName: el.lastName,
//         age: newAge
//     }
// });

// console.log(newCustomObjects)


// var numbers = [45, 4, 9, 16, 25];
// var over18 = numbers.filter(myFunction);

// function myFunction(value, index, array) {
//     return value > 18;
// }

// console.log(over18)


// var newOver18 = [];

// var fun = (el) => {
//     if (el > 18) newOver18.push(el);
// }
// numbers.forEach(fun)
// console.log(newOver18)

// var customObjects = [
//     {
//         firstName: "Aleksandar",
//         lastName: "Tanevski",
//         age: 28
//     },
//     {
//         firstName: "BViktor",
//         lastName: "Tanevski",
//         age: 20
//     },
//     {
//         firstName: "CLionel",
//         lastName: "Messi",
//         age: 33
//     }
// ];

// function myFunction(total, value, index, array) {
//     if(typeof total == 'object')
//         return value.age + total.age;
//     return total + value.age; 
// }
// var sum = customObjects.reduce(myFunction);


// console.log(sum)


//Логичко И
//var numbers = [45, 4, 9, 16, 25];
// function myFunction(value, index, array) {
//     return value > 18;
// }
// var allOver18 = numbers.every(myFunction);

// //Логичко И (пешки)
// var numbers = [45, 4, 9, 16, 25];
// var allOver18 = true;
// numbers.forEach(element => {
//     allOver18 = allOver18 && element > 18
// });
// console.log(allOver18);

// //Логичко ИЛИ
// var numbers = [45, 4, 9, 16, 25];
// function myFunction(value, index, array) {
//     return value > 18;
// }
// var someOver18 = numbers.some(myFunction);

// //Логичко ИЛИ (пешки)
// var numbers = [45, 4, 9, 16, 25];
// var allOver18 = false;
// numbers.forEach(element => {
//     allOver18 = allOver18 || element > 18
// });

// console.log(allOver18);

// var fruits = ["Apple", "Orange", "Apple", "Mango"];
// var indexOfApple = fruits.indexOf("Apple");
// console.log(indexOfApple)


// var fruits = ["Apple", "Orange", "Apple", "Mango"];
// var indexOfApple = fruits.lastIndexOf("Apple");
// console.log(indexOfApple)


// var numbers = [4, 9, 16, 25, 29];
// var first = numbers.find(myFunction);

// function myFunction(value, index, array) {
//   return value > 18;
// }

// console.log(first)


// var d = new Date();
// console.log(d);

// var d = new Date("October 13, 2014 11:13:00");
// console.log(d);

// var dateOdBaza = new Date("October 13, 2014 11:13:00");
// console.log(dateOdBaza.toISOString());

// var d = new Date("2014-10-13T09:13:00.000Z");
// d.getMilliseconds()
// console.log(d)


// var d = new Date(2021,03,16,00,00,00)
// console.log(d)
// d.setHours(22)
// console.log(d)

// console.log(d.toDateString())

//#2004

// var today, someday, text;
// today = new Date();
// someday = new Date();
// someday.setFullYear(2100, 0, 14);

// if (someday > today) {
//   text = "Today is before January 14, 2100.";
// } else {
//   text = "Today is after January 14, 2100.";
// }
// console.log(text);

// console.log(Math.floor(Math.random() * 11))
// console.log(Boolean(1 < 2))

// var voteable = (age < 18) ? "Too young" : "Old enough";

// if (age < 18)
//     voteable = "Too young"
// else voteable = "Old enough"

// var age = Number("tanes");
// console.log(isNaN(age))
// console.log(Boolean(age.toString() == "NaN"))

// switch (3) {
//     case 0:
//       day = "Sunday";
//       break;
//     case 1:
//       day = "Monday";
//       break;
//     case 2:
//        day = "Tuesday";
//       break;
//     case 3:
//       day = "Wednesday";
//       break;
//     case 4:
//       day = "Thursday";
//       break;
//     case 5:
//       day = "Friday";
//       break;
//     default:
//       day = "Saturday";
//   }
//   console.log(day);

// var cars = ["BMW", "Volvo", "Saab", "Ford"];

// for (i = 0, len = cars.length, text = ""; i < len; i++) {
//     text += cars[i] + "<br>";
//     console.log(len);
// }
// console.log(text);

// //Со for/in за објекти итерираме по properties
// //тоа значи дека ќе ни биде вратено името на property а не value
// //со for/in за person1, x ќе ни биде fname, lname, age
// // var person1 = {fname:"John", lname:"Doe", age:25};

// var text = "";
// var x;

// for (x in person1) {
//   console.log(x)
//   console.log(person1[x])
// }


// //Со for/in за листи итерираме по индекс
// //тоа значи дека ќе ни биде вратен индексот а не value-то од листа
// //со for/in за numbers, x ќе ни биде 0, 1, 2 , 3...
// var numbers = [45, 4, 9, 16, 25];

// var txt = "";
// var x;
// for (x in numbers) {
//     console.log(x)
//     console.log(numbers[x])
// }

// //х ќе биде индексот
// var cars = ["BMW", "Volvo", "Mini"];
// var text = "";

// for (let x in cars) {
//   console.log(x)
// }

// //х ќе биде value
// var cars = ["BMW", "Volvo", "Mini"];
// var text = "";

// for (let x of cars) {
//   console.log(x)
// }

// var i = 0;
// while (i < 10) {
//     console.log("The number is " + i);
//     i++;
// }

// var i = 0;
// do {
//     console.log("The number is " + i);
//     i++;
// }
// while (i < 10);

// for (i = 0; i < 10; i++) {
//     if (i === 3) { continue; }
//     console.log("The number is " + i);
// }

// //Ако сакате да знаете повеќе
// "Strict Mode"
// globalnaVarijabla = 5;
// var carName = "Volvo";
// ovaEFunkcija();

// console.log(carName)

// function ovaEFunkcija() {
//     carName = "Volvo";
//     console.log(globalnaVarijabla);
// }

// Array.prototype

//2204

// var globalnaPromenliva = "Hello World"
// function myFunction() {
//     console.log(this.globalnaPromenliva);
// }
// myFunction();

// var person = {
//     firstName: "John",
//     lastName: "Doe",
//     id: 5566,
//     toString: function () {
//         return this.firstName + " " + this.lastName;
//     }
// };

// var person1 = {
//     fullName: function () {
//         return this.firstName + " " + this.lastName;
//     }
// }

// var person2 = {
//     firstName: "John",
//     lastName: "Doe",
// }

// console.log(person1.fullName.call(person2));  // Will return "John Doe"



// class Car {
//     constructor(name, year) {
//         this.name = name;
//         this.year = year;
//     }
// }

// let myCar1 = new Car("Ford", 2014);
// let myCar2 = new Car("Audi", 2019);

// console.log(myCar1)


// class Car {
//     constructor(name, year) {
//         this.name = name;
//         this.year = year;
//     }
//     age() {
//         let date = new Date();
//         return date.getFullYear() - this.year;
//     }
// }

// let myCar = new Car("Ford", 2014);
// let myCar1 = new Car("Opel", 2014);
// let myCar2 = new Car("VW", 2014);

// myCar = {
//     name: "Ford",
//     year: 2014,
//     age() {
//         let date = new Date();
//         return date.getFullYear() - this.year;
//     }
// }

// myCar1 = {
//     name: "Opel",
//     year: 2014,
//     age() {
//         let date = new Date();
//         return date.getFullYear() - this.year;
//     }
// }

// myCar1 = {
//     name: "VW",
//     year: 2014,
//     age() {
//         let date = new Date();
//         return date.getFullYear() - this.year;
//     }
// }

//2404
// var text = '{ "employees" : [' +
//     '{ "firstName":"John" , "lastName":"Doe" },' +
//     '{ "firstName":"Anna" , "lastName":"Smith" },' +
//     '{ "firstName":"Peter" , "lastName":"Jones" } ]}';

// var obj = JSON.parse(text);
// var objToString = JSON.stringify(obj);

// services = {
//     firstName: "John",
//     lastName: "Doe",
//     age: 46
// }

// console.log(services)
// document.getElementById("demo").innerHTML = services.firstName + " " + services.lastName;


// var propertyArray = Object.keys(services);
// var txt = ""
// for (x of propertyArray) {
//     txt += services[x] + " ";
// };
// console.log(txt)

// txt = "";
// for (x in services) {
//     txt += services[x] + " ";
// }
// console.log(txt)


// var jsonString = JSON.stringify(services);
// console.log(jsonString)


// function Person(first, last, age, eyecolor) {
//     this.firstName = first;
//     this.lastName = last;
//     this.age = age;
//     this.eyeColor = eyecolor;
// }

// Person.prototype.name = function () {
//     return this.firstName + " " + this.lastName;
// };

// var jas = new Person("Alesandar", "Tanevski", 28, "brown");
// var studentFilip = new Person("Filip", "Burzevslo", 17, "blue");
// console.log(studentFilip.name());

//Anon function
// (function(){
//     console.log("Hello world anon function;");
//     //ajax povik do vasiot server za da registrirate poseta
// })();

// var funk = function(){

// }
// funk()

// var soberi2Broja = function(a,b){
//     return a + b;
// }

// var zbir = soberi2Broja(2,3)
// console.log(zbir);


// var soberiNepoznatBrojBroevi = function(){
//     var zbir = 0;
//     for (i = 0; i < arguments.length; i++) {
//         zbir += arguments[i];
//       }
//     return zbir;
// }

// var zbir = soberiNepoznatBrojBroevi(2,3,6,7,2,3,4,5,6)
// console.log(zbir);
// var myVar = setInterval(myTimer, 1000);

// function myTimer() {
//   var d = new Date();
//   var t = d.toLocaleTimeString();
//   document.getElementById("demo").innerHTML = t;
// }

// var para = document.createElement("p");
// var node = document.createTextNode("This is a new paragraph.");
// para.appendChild(node);

// var element = document.getElementById("demo3");
// element.appendChild(para);
