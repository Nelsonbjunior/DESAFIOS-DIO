let alcohol = 0;
let gasoline = 0;
let diesel = 0;
let tipo = true;


while (tipo) {

const code = Number(gets()); 

 switch (code) {

   case 1:
     alcohol++;
     break;

   case 2:
     gasoline++;
     break;

   case 3:
     diesel++;
     break;

   case 4:

    tipo = false;

     break;

 }

}

console.log("MUITO OBRIGADO");
console.log("Alcool: " + alcohol);
console.log("Gasolina: " + gasoline);
console.log("Diesel: " + diesel);