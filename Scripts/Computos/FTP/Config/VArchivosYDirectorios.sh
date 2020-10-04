#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"

VArchivosYDirectorios() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    local permisosArchivosCreados=$(getConfiguracion local_umask 022)
    local permisosArchivosAbiertos=$(getConfiguracion file_open_mode 0666)
    local intentaDirectorio=$(getConfiguracion local_root '(none)')
    local permitirEscritura=$(configuracionEsTrue write_enable = YES)
    local registrarCargaDescarga=$(configuracionEsTrue xferlog_enable = YES)
    local forzarArchivosConPunto=$(configuracionEsTrue force_dot_files = YES)
    local registrarPeticionesFTP=$(configuracionEsTrue log_ftp_protocol = YES)
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "ARCHIVOS Y DIRECTORIOS" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 8 0

    dibujarTxt "PERMISOS ARCHIVOS CREADOS (022)" 11 11 0
    dibujarEntradaTxt 11 12 20 false "$permisosArchivosCreados"
    
    dibujarTxt "PERMISOS ARCHIVOS ABIERTOS (0666)" 11 14 0
    dibujarEntradaTxt 11 15 20 false "$permisosArchivosAbiertos"

    dibujarTxt 'DIRECTORIO HOME ((none) "/home/$USER")' 11 17 0
    dibujarEntradaTxt 11 18 20 false "$intentaDirectorio"

    dibujarTxt "¿HABILITAR ESCRITURA? (NO)" 11 20 0
    dibujarSwitch 11 21 20 1 $permitirEscritura

    dibujarTxt "¿REGISTRO CARGAS Y DESCARGAS? (NO)" 57 11 0
    dibujarSwitch 57 12 20 1 $registrarCargaDescarga
    
    dibujarTxt "¿FORZAR LOS ARCHIVOS CON PUNTO? (NO)" 57 14 0
    dibujarSwitch 57 15 20 1 $forzarArchivosConPunto

    dibujarTxt "¿REGISTRAR PETICIONES FTP? (NO)" 57 17 0
    dibujarSwitch 57 18 20 1 $registrarPeticionesFTP
    
    dibujarBoton "CONFIGURAR" 11 25 40 3
    dibujarBoton "CANCELAR" 51 25 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in
            "0") #PERMISOS ARCHIVOS CREADOS (022)
                if $modificado; then             
                    permisosArchivosCreados="$respuestaGestor"
                fi
                ;;
            "1") #PERMISOS ARCHIVOS ABIERTOS (0666)
                if $modificado; then             
                    permisosArchivosAbiertos="$respuestaGestor"
                fi
                ;;           
            "2") #DIRECTORIO HOME ((none) "/home/$USER")
                if $modificado; then 
                    intentaDirectorio=$respuestaGestor
                fi                
                ;;

            "3") #¿HABILITAR ESCRITURA? (NO)
                if $modificado; then 
                    permitirEscritura=$respuestaGestor
                fi        
                ;;

            "4") #¿REGISTRO CARGAS Y DESCARGAS?
                if $modificado; then 
                    registrarCargaDescarga=$respuestaGestor
                fi        
                ;;

            "5") #¿FORZAR LOS ARCHIVOS CON PUNTO? (NO)
                if $modificado; then 
                    forzarArchivosConPunto=$respuestaGestor
                fi        
                ;;
            "6") #¿REGISTRAR PETICIONES FTP?
                if $modificado; then 
                    registrarPeticionesFTP=$respuestaGestor
                fi        
                ;;
            "7") #CONFIGURAR
                if $respuestaGestor; 
                then
                    if [ -d "${intentaDirectorio/\$USER/}" -o -z "$intentaDirectorio" -o "$intentaDirectorio" = '(none)' ]; then
                        if [ "${permisosArchivosCreados//[0-9]/}" -a "$permisosArchivosCreados" -a ! "$permisosArchivosCreados" = '(none)' ]; then #no es un numero
                            mensajeError "INGRESE PERMISO DE ARCHIVOS CREADOS VÁLIDO EN PERMISOS" 1 37 33 0 1 1                            
                        else # es un numero  
                            if [ "${permisosArchivosAbiertos//[0-9]/}" -a "$permisosArchivosAbiertos" -a ! "$permisosArchivosAbiertos" = '(none)' ]; then #no es un numero
                                mensajeError "INGRESE PERMISO DE ARCHIVOS ABIERTOS VÁLIDO EN PERMISOS" 1 37 33 0 1 1                            
                            else
                                registrarCargaDescarga=$([ $registrarCargaDescarga = true ] && echo YES || echo NO) 
                                forzarArchivosConPunto=$([ $forzarArchivosConPunto = true ] && echo YES || echo NO) 
                                registrarPeticionesFTP=$([ $registrarPeticionesFTP = true ] && echo YES || echo NO)                     
                                permitirEscritura=$([ $permitirEscritura = true ] && echo YES || echo NO) 

                                if [ -d "${intentaDirectorio/\$USER/}" -o "$intentaDirectorio" != '(none)' ]; then
                                    chmod -R 755 "${intentaDirectorio/\$USER/}"
                                fi
                                configuracionArchivosYDirectorios "$permisosArchivosCreados" \
                                    "$permisosArchivosAbiertos" "$intentaDirectorio" \
                                    "$registrarCargaDescarga" "$forzarArchivosConPunto" \
                                    "$registrarPeticionesFTP" "$permitirEscritura"
                                systemctl restart vsftpd
                                continuar=false
                            fi
                        fi
                    else
                       mensajeError "NO SE ENCONTRÓ EL DIRECTORIO" 1 37 33 0 1 1
                    fi
                fi
                ;;          
            "8") #CANCELAR
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;
            *)
                ;;
        esac
    done
}

ejecutarVArchivosYDirectorios() {
    VArchivosYDirectorios
    cerrarPantalla
}
probarFuncionEjecucionLocal ejecutarVArchivosYDirectorios "VArchivosYDirectorios.sh"
