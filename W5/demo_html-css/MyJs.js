function formSubmitted(e, x) {
  e.preventDefault();
  console.log(`you submitted ${x} form.`);
  console.log(e);
  console.log(e.target[1].value);
}