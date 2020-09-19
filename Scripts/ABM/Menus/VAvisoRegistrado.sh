
. "/Scripts/InterfazGrafica/Control/inicio.sh" 

VAvisoRegistrado(){
    #region args
    # $1 : texto de aviso
    # $2 : foreground del texto
    # $3 : tiempo de espera
    #endregion
    
    iniciarPantallaNueva
    dibujarTxt "$1" 35 10 0 $2 

    if [ "$3" ]; 
    then
        sleep $3
    else
        sleep 2
    fi
}