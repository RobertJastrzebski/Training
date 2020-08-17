const domyslnaWartosc = 0;
let wynik = domyslnaWartosc;
let logEntries = [];

function getUserNumberInput() {
  return parseInt(userInput.value);
}

function writeToLog(operator, wynikPrzed, liczba, wynikPo) {
  const logEntry = {
    operation: operator,
    prevResult: wynikPrzed,
    number: liczba,
    result: wynikPo,
  };
  logEntries.push(logEntry);
  console.log(logEntries);
}

function add() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} + ${enteredNum}`;
  wynikPrzed = wynik;
  wynik += enteredNum;
  outputResult(wynik, opis);
  writeToLog('ADD',wynikPrzed,enteredNum,wynik);
 
  
}

function subtract() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} - ${enteredNum}`;
  wynikPrzed = wynik;
  wynik -= enteredNum;
  outputResult(wynik, opis);
  writeToLog('substract',wynikPrzed,enteredNum,wynik);
}

function multiply() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} * ${enteredNum}`;
  wynikPrzed = wynik;
  wynik *= enteredNum;
  outputResult(wynik, opis);
  writeToLog('multiply',wynikPrzed,enteredNum,wynik);
}

function divide() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} / ${enteredNum}`;
  wynikPrzed = wynik;
  wynik /= enteredNum;
  outputResult(wynik, opis);
  writeToLog('divide',wynikPrzed,enteredNum,wynik);
}
addBtn.addEventListener("click", add);
subtractBtn.addEventListener("click", subtract);
multiplyBtn.addEventListener("click", multiply);
divideBtn.addEventListener("click", divide);
