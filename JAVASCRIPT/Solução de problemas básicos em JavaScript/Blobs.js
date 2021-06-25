var n = parseInt(gets());

while (n > 0) { //complete o codigo
 var c = parseFloat(gets());
 let dias = 0; //atribua o valor correto a variavel

 while (c>1) { // complete o while
  c = parseFloat(c/2);
  dias +=1;

 }

 n-=1;

 console.log(dias,'dias'); //complete o código para a saída

}