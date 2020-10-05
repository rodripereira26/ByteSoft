#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"


VFTPAnon() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    local permitirAnon=$(configuracionEsTrue anonymous_enable = YES)
    local maximoBitsPorSegundo=$(getConfiguracion anon_max_rate '0')
    local permisosArchivosCreados=$(getConfiguracion anon_umask 077)
    local puedeEscribirAnon=$(configuracionEsTrue anon_mkdir_write_enable = YES)
    local puedeSubirArchivos=$(configuracionEsTrue anon_upload_enable = YES)
    local intentaDirectorioAnon=$(getConfiguracion anon_root '(none)')

    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "FTP ANON" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 7 0
    dibujarTxt "HABILITAR ESCRITURA EN 'ARCHIVOS Y DIRECTORIOS':" 11 8 0 

    dibujarTxt "¿PERMITIR USUARIO ANONIMO? (NO)" 11 12 0
    dibujarSwitch 11 13 20 1 $permitirAnon
    
    dibujarTxt "MAXIMOS BITS POR SEGUNDO" 11 15 0
    dibujarTxt "(DEFECTO 0, ES ILIMITADO)" 11 16 0
    dibujarEntradaTxt 11 17 20 false "$maximoBitsPorSegundo"

    dibujarTxt "PERMISOS ARCHIVOS CREADOS (077)" 11 19 0
    dibujarEntradaTxt 11 20 20 false "$permisosArchivosCreados"

    dibujarTxt "¿PUEDE CREAR DIRECTORIOS? (NO)" 55 12 0
    dibujarSwitch 55 13 20 1 $puedeEscribirAnon

    dibujarTxt "¿PUEDE SUBIR ARCHIVOS? (NO)" 55 15 0
    dibujarSwitch 55 16 20 1 $puedeSubirArchivos
   
    dibujarTxt "INTENTA EL DIRECTORIO  ((none))" 55 18 0
    dibujarEntradaTxt 55 19 20 false "$intentaDirectorioAnon"
    

    dibujarBoton "CONFIGURAR" 11 23 40 3
    dibujarBoton "CANCELAR" 50 23 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in
            
            "0") #¿PERMITIR USUARIO ANONIMO? (NO)
                if $modificado;
			    then             
                    permitirAnon=$respuestaGestor
                fi
                ;;
            "1") #MAXIMOS BITS POR SEGUNDO (DEFECTO 0, ES ILIMITADO)
                if $modificado;
			    then 
                    maximoBitsPorSegundo=$respuestaGestor
                fi        
                ;;
            "2") #PERMISOS ARCHIVOS CREADOS (077)
                if $modificado;
			    then             
                    permisosArchivosCreados="$respuestaGestor"
                fi
                ;;
            "3") #¿PUEDE CREAR DIRECTORIOS? (NO)
                if $modificado;
				then 
                    puedeEscribirAnon=$respuestaGestor
                fi                
                ;;
            "4") #¿PUEDE SUBIR ARCHIVOS? (NO)
                if $modificado;
				then 
                    puedeSubirArchivos=$respuestaGestor
                fi                
                ;;
            "5") #INTENTA EL DIRECTORIO  ((none))
                if $modificado;
				then 
                    intentaDirectorioAnon=$respuestaGestor
                fi        
                ;;
            "6") #CONFIGURAR
                if $respuestaGestor; 
                then
                    if [ "${maximoBitsPorSegundo//[0-9]/}" -a "$maximoBitsPorSegundo" -a ! "$maximoBitsPorSegundo" = '(none)' ];
				    then #no es un numero
                        mensajeError "INGRESE UN NUMERO VÁLIDO EN BITS POR SEGUNDO" 1 37 33 0 1 1
                    else
                        if [ "${permisosArchivosCreados//[0-9]/}" -a "$permisosArchivosCreados" -a ! "$permisosArchivosCreados" = '(none)' ];
				        then #no es un numero
                            mensajeError "INGRESE PERMISO DE ARCHIVOS CREADOS VÁLIDO EN PERMISOS" 1 37 33 0 1 1                            
                        else 
                            if [ -d "$intentaDirectorioAnon" -o -z "$intentaDirectorioAnon" -o "$intentaDirectorioAnon" = '(none)' ];
				            then
                                permitirAnon=$([ $permitirAnon = true ] && echo YES || echo NO) 
                                puedeEscribirAnon=$([ $puedeEscribirAnon = true ] && echo YES || echo NO) 
                                puedeSubirArchivos=$([ $puedeSubirArchivos = true ] && echo YES || echo NO) 
                                
                                if [ -d "$intentaDirectorioAnon" ];
				                then 
                                    mkdir "$intentaDirectorioAnon"
                                    chmod 755 "$intentaDirectorioAnon"
                                fi
                                
                                configurarFTPAnon \
                                    "$permitirAnon" "$puedeEscribirAnon" \
                                    "$intentaDirectorioAnon" "$maximoBitsPorSegundo" \
                                    "$permisosArchivosCreados" "$puedeSubirArchivos"           
                                systemctl restart vsftpd
                                continuar=false
                            else
                                mensajeError "NO SE ENCONTRÓ EL DIRECTORIO" 1 37 33 0 1 1
                            fi
                        fi
                    fi
                fi
                ;;          
            "7") #CANCELAR
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

ejecutarVFTPAnon() {
    VFTPAnon
    cerrarPantalla
}
probarFuncionEjecucionLocal ejecutarVFTPAnon "VFTPAnon.sh"
