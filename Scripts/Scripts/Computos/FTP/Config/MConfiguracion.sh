#!/bin/bash
#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/Computos/FTP/Config/funcFTP.sh"
. "/Scripts/Computos/FTP/Config/VArchivosYDirectorios.sh"
. "/Scripts/Computos/FTP/Config/VFiltroPorUsuario.sh"
. "/Scripts/Computos/FTP/Config/VFTPAnon.sh"
. "/Scripts/Computos/FTP/Config/VComandos.sh"
. "/Scripts/Computos/FTP/Config/VBanner.sh"
. "/Scripts/Computos/FTP/Config/VPuertosPASV.sh"
. "/Scripts/Computos/FTP/Config/VDelay.sh"
. "/Scripts/Computos/FTP/Config/VMaximos.sh"
. "/Scripts/Computos/FTP/Config/VProtocolo.sh"
#endregion

#necesita root

VConfigFTP() {
    local continuar=true
    #region [rgba(27, 173, 192, 0.10)] tui  

    iniciarPantallaNueva
    dibujarTxt "CONFIGURACION FTP" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 4 0
    dibujarTxt "5 -> ENTER " 11 5 0
    dibujarTxt "6 -> ABAJO" 11 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 7 0
    
    dibujarBoton "ARCHIVOS Y DIRECTORIOS" 11 12 80 3
    dibujarBoton "FILTRO POR USUARIO" 11 15 40 3
    dibujarBoton "FTP ANONIMO" 51 15 40 3
    dibujarBoton "COMANDOS" 11 18 40 3
    dibujarBoton "PUERTOS PASV" 51 18 40 3
    dibujarBoton "BANNER" 11 21 40 3
    dibujarBoton "DELAY" 51 21 40 3
    dibujarBoton "MAXIMOS" 11 24 40 3
    dibujarBoton "PROTOCOLO" 51 24 40 3
    dibujarBoton "VER ARCHIVO CONFIGURACION" 11 27 40 3
    dibujarBoton "VOLVER" 51 27 40 3
    #endregion

    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 

    done

}
ejecutarVConfigFTP() {
    local continuarCiclo=true
    
    #   ARCHIVOS Y DIRECTORIOS - FILTRO POR USUARIO - FTP ANONIMO - PUERTOS PASV - COMANDOS
    #   BANNER - DELAY - MAXIMOS - VER ARCHIVO CONFIGURACION - CONFIGURAR - CANCELAR
    
    while $continuarCiclo; 
    do
        VConfigFTP
        case $texto in 
            "ARCHIVOS Y DIRECTORIOS")
                ejecutarVArchivosYDirectorios
                ;;
            "FILTRO POR USUARIO")
                ejecutarVFiltroPorUsuario
                ;;
            "FTP ANONIMO")
                ejecutarVFTPAnon
                ;;
            "COMANDOS")
                ejecutarVComandos
                ;;
            "PUERTOS PASV")
                ejecutarVPuertosPASV
                ;;
            "BANNER")
                ejecutarVBanner
                ;;
            "DELAY")
                ejecutarVDelay
                ;;
            "MAXIMOS")
                ejecutarVMaximos
                ;;
            "PROTOCOLO")
                ejecutarVProtocolo
                ;;
            "VER ARCHIVO CONFIGURACION")
                tput sgr0
                clear
                grep -vE "^#" /etc/vsftpd/vsftpd.conf | less
                ;;
            "VOLVER")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done
}
probarFuncionEjecucionLocal ejecutarVConfigFTP "MConfiguracion.sh"