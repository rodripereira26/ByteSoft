#!/bin/bash

. "ElementosTUI/Grafica/disenoVentana.sh" 
. "Menus/menuCrearUsuarios.sh"


function VentanaCrearUsuario(){
    # muestra diseño
    borrarPantalla
    #animacionTitulo "Menus/tituloByteSoft.txt" 5 5
    borrarPantalla
    dibujarTxt "____________________________" 10 1 0 42
    dibujarTxt "Ingresa tu nombre y apellido" 10 2
    dibujarTxt "Primer nombre:" 3 4
    dibujarEntradaTxt 5 5 20 false
    dibujarTxt "Segundo nombre:" 3 6
    dibujarEntradaTxt 5 7 20 false
    dibujarTxt "Primer apellido:" 3 8
    dibujarEntradaTxt 5 9 20 false
    dibujarTxt "Segundo apellido:" 3 10
    dibujarEntradaTxt 5 11 20 false
    dibujarBoton "Aceptar" 5 13 11 1
    dibujarBoton "Cancelar" 18 13 12 1
    dibujarSwitch 30 5 6 1 false

    #ejecuta los tputs y los reads y su interaccion con el diseño 
    while true
    do
        salida=$(siguientePos) # pos 1   
        echo $salida
    done
}
function VentanaCrear(){
    # muestra diseño
    borrarPantalla
    #animacionTitulo "Menus/tituloByteSoft.txt" 5 5
    borrarPantalla
    dibujarTxt "____________________________" 10 1 0 42
    dibujarTxt "Ingresa tu nombre y apellido" 10 2
    dibujarTxt "Primer nombre:" 3 4
    dibujarEntradaTxt 5 5 20 false
    dibujarTxt "Segundo nombre:" 3 6
    dibujarEntradaTxt 5 7 20 false
    dibujarTxt "Primer apellido:" 3 8
    dibujarEntradaTxt 5 9 20 false
    dibujarTxt "Segundo apellido:" 3 10
    dibujarEntradaTxt 5 11 20 false
    dibujarBoton "Aceptar" 5 13 11 1
    dibujarBoton "Cancelar" 18 13 12 1
    dibujarSwitch 30 5 6 1 false

    #ejecuta los tputs y los reads y su interaccion con el diseño 
    while true
    do
        siguientePos # pos 1   
        echo $datoTomado
    done
}

function main(){
    VentanaCrearUsuario
    

}
main
