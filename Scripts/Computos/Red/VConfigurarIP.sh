#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

VConfigurarIP(){
    local continuar=true
    local ip=""
    local tipoRegla=""

    iniciarPantallaNueva
    dibujarTxt "CONFIGURAR IP" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    dibujarTxt "INGRESA IP" 11 11 0
    dibujarEntradaTxt 11 12 20 false

    dibujarTxt "INGRESA MÁSCARA" 11 14 0
    dibujarEntradaTxt 11 15 20 false
    
    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3
}
ejecutarConfigurarIP(){
    VConfigurarIP
}