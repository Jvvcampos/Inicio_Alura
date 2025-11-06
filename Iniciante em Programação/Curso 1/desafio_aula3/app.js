//1) Crie um contador que comece em 1 e vá até 10 usando um loop while. Mostre cada número.
let contador = 1;
while (contador <=10) {
    alert(contador);
    contador+=1;
}
//2) Crie um contador que comece em 10 e vá até 0 usando um loop while. Mostre cada número.
let contador2 = 10;
while(contador2 >= 0) {
    alert(contador2);
    contador2-=1;
}
//3) Crie um programa de contagem regressiva. Peça um número ao usuario e conte deste número até 0, usando um loop while no console do navegador.
let numeroMaximo = prompt('Digite um número para a contagem regressiva');
let contador3 = numeroMaximo;
while(contador3 >= 0){
    alert(contador3);
    contador3-=1;
}
//4) Crie um programa de contagem progressiva. Peça um número ao usuario e conte de `0` até esté número, usando um loop while no console do navegador.
let numeroMaximo2 = prompt('Digite um número para a contagem progressiva');
let contador4 = 0;
while(contador4 <= numeroMaximo2){
    alert(contador4);
    contador4+=1;
}
