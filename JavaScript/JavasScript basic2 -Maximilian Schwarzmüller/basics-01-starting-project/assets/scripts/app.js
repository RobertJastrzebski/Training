const domyslnaWartosc = 0;
let wynik = domyslnaWartosc;

function getUserNumberInput() {
  return parseInt(userInput.value);
}

function add() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} + ${enteredNum}`;
  wynik = wynik + enteredNum;
  outputResult(wynik, opis);
}

function subtract() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} - ${enteredNum}`;
  wynik = wynik - enteredNum;
  outputResult(wynik, opis);
}

function multiply() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} * ${enteredNum}`;
  wynik = wynik * enteredNum;
  outputResult(wynik, opis);
}

function divide() {
  const enteredNum = getUserNumberInput();
  const opis = `${wynik} / ${enteredNum}`;
  wynik = wynik / enteredNum;
  outputResult(wynik, opis);
}
addBtn.addEventListener("click", add);
subtractBtn.addEventListener("click", subtract);
multiplyBtn.addEventListener("click", multiply);
divideBtn.addEventListener("click", divide);
