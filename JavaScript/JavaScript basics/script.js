// var firstName = 'John';
// var age = 28; 


// console.log(firstName + " " + age);
// var job, isMarried;
// job = "techer";
// isMarried = false;
// alert(firstName + ' is a ' + age + ' year old ' 
// + job +' Is he married? ' + isMarried); 
// var lastName = prompt('what is his last name?');
// console.log(firstName + ' '+ lastName)
// Basic operators
// var year , yearJohn , yearMark;
// var now = 2018
// var yearJohn = now +2;
// var yearMark = now /10;
// console.log (yearJohn);
// console.log (yearMark);
// var older= yearMark>yearJohn;
// console.log(older);


// //typeof operator
// *************************************************************
// console.log(typeof older);

// var now = 2020
// var yearJohn = 1989
// var fullAge=18

// var isFulAge =now - yearJohn >= fullAge;
// console.log(isFulAge);
// var imie = Robert;
// var jestZonaty = true
// if (jestZonaty) {
//     console.log(imie + 'jest zonaty' );
// } else {console.log(imie + ' nie jest zonaty');
// }


//*************************************************************
// if else 

// var imie = 'Robert';
// var age = 13;
// if (age >= 13 && age<=20){
//     console.log(imie+ ' jest młodziencem')
// }
// else if (age < 13 ) {
//     console.log(imie + ' jest maluchem')
// }
// else if (age > 21 && age <=30 ) {
//     console.log(imie + ' jest chłopakiem')
// }
// else if (age > 31 && age <=40 ) {
// console.log(imie + 'jest Meżczyzną')
// }
// else console.log( imie + ' jest staruchem');



/*******************************************************
Ternary operator

var age = 1

var drink = age >= 18 ? 'beer' : 'juice';
console.log(drink);




*/
/*********************************************************************
Switch stetment
*/
// var role = 'nauczyciel';
// switch (role) {
// case 'nauczyciel' :
//     console.log('nauczyciel uczy w szkole');
//     break;
// case 'lekarz' :
//     console.log('lekarz leczy ');
//     break;
// case 'kontroler' :
//     console.log('kontroler kontroluje');
//     break;
// default : console.log('inny zawód');
// }

// Switch stetment expression ***************************************

// var job = function(praca,firstName) {
//     switch (praca) {
//         case 'nauczyciel' :
//             return firstName + ' uczy w szkole';
    
//         case 'lekarz' :
//         return firstName + 'leczy chorych';
    
//         case 'kontroler' :
//         return firstName + 'kontroluje detale';
    
//         default :
//         return firstName + ' robi inne rzeczy';
//     }
// }
// console.log(job('lekarz', 'Robert '));




// /*************************************************
//  * Functions statment*/
 

// function obliczWiek (dataUrodzenia){
//     return 2020 - dataUrodzenia;
// }
// var ageJohn = obliczWiek(1982);
// var ageRob = obliczWiek(1980);
// var ageAsia = obliczWiek(1983);
// console.log(ageRob);


 
// /* function Expressions*/ ******************************************
// function lataDoEmerytury(year, firstName) {

//     var age = obliczWiek(year);
//     var lataDoEmerytury = 65 -age; 
//     console.log(firstName + ' retires in '+ lataDoEmerytury + ' years');

// }
// lataDoEmerytury(1990, 'John');


// ARRAYS *****************************************************
// var names = ['John', 'rob', ' Jane' ];
// var years = new Array (1990, 1969, 1948); 
// console.log(names[0]);
// console.log(names.length);
// names[1] = 'ben'
// console.log(names);
// names[4] = 'RObus'
// names.push('ostatni');
// names.unshift('pierwszy');
// console.log(names);
// names.pop();
// names.pop();
// console.log(names);
// names.shift();
// console.log(names);
// console.log(names.indexOf("rob"));
// console.log(names);
// names.pop();
// console.log(names);
// działa jako pop
// names[names.length] = 'rob'
// var checkRobPresent = names.indexOf('rob')=== -1 ? "Roberta nie ma na liście" : 'Robert jest na liście';
// console.log(checkRobPresent);
// console.log(names);

// Zadanie 1. Oblicz napiwki dla kelnera w zaleznosci od wydanej kwoty******** 
// var tipForWeiter = function tip (bill){
//     var precentage
//     if (bill < 50) {
//         precentage = 0.2;
//     } else if (bill >= 50  && bill <200 ) {
//         precentage = 0.15;
//     } else {var precentage = 0.1; 
//     }
//     return bill * precentage
// }



// var bill = [124,48,268]
// var tip = [tipForWeiter(bill[0]),
//            tipForWeiter(bill[1]),
//            tipForWeiter(bill[2])];


// var finalValues = [bill[0]+tip[0], bill[1]+tip[1], bill[2]+tip[2]];
// console.log(tip,finalValues)



// Object and methods.*****************************************
// /* var john = {
//     firstName: 'John',
//     mass: 98,
//     height: 190,
//     lastName: 'Smith',
//     birthYear: 1983,
//     family: ['Jane', 'Mark', 'Bob', 'Emily'],
//     job: 'teacher',
//     isMarried: false,
//     calcAge: function(){
//         this.age = 2020 - this.birthYear;
   


//     }
    
// };
// john.calcAge();
// console.log(john); */

// /* // Zadanie 2 porownanie BMI pomiedzy 2 obiektami.******************
// var john = {
//     fullName: 'John Smith',
//     mass: 92,
//     height: 1.95,
//     calcBMI: function(){
//         this.BMI = this.mass /this.height**2;
//         return this.BMI;
//     }
// }

// var mark = {
//     fullName: 'Mark Miller',
//     mass: 78,
//     height: 1.69,
//     calcBMI: function() {
//         this.BMI = this.mass / (this.height * this.height);
//         return this.BMI;
//     }
// }


// if (john.calcBMI() > mark.calcBMI()) {
//     console.log(john.fullName + ' has a higher BMi of ' + john.BMI);
// } else if (mark.BMI> john.BMI) {
//     console.log(mark.fullName + ' has a higher BMI of ' + mark.BMI); 
// } else {
//      console.log('They have the same BMI');
// }
    

// john.calcBMI();
// mark.calcBMI();
// console.log(john.BMI, mark.BMI) */

// // Loops***************************


// var john = ['John', 'Smith', 1990, 'designer', false, 'blue'];

// for (var i = 0; i < john.length; i++ ) {
//     console.log(john[i]);
// }


