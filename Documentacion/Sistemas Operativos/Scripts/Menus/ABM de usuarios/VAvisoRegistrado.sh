VAvisoRegistrado(){
    # $1 : texto de aviso
    # $2 : foreground del texto
    # $3 : tiempo de espera
    
    iniciarPantallaNueva
    dibujarTxt "$1" 60 2 0 $2 
    if [ "$3" ]; then
        sleep $3
    else
        sleep 3
    fi
}