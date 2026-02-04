#### Desafios - Respostas

1) Crie um contador que comece em 1 e vá até 10 usando um loop while. Mostre cada número.

```js
let contador = 1;
while (contador <= 10) {
    console.log(contador);
    contador++;
}
```

2) Crie um contador que comece em 10 e vá até 0 usando um loop while. Mostre cada número.

```js
let contador = 10;
while (contador >= 0) {
    console.log(contador);
    contador--;
}
```

3) Crie um programa de contagem regressiva. Peça um número ao usuario e conte deste número até 0, usando um loop while no console do navegador.

```js
let numeroMaximo = prompt("Digite um número para a contagem regressiva:");

while (numeroMaximo >= 0) {
    console.log(numeroMaximo);
    numeroMaximo--;
}

```

4) Crie um programa de contagem progressiva. Peça um número ao usuario e conte de `0` até esté número, usando um loop while no console do navegador.

```js
let numeroMaximo = prompt("Digite um número para a contagem progregressiva:");;
let contador = 0;

while (contador <= numeroMaximo) {
    console.log(contador);
    contador++
}
```
