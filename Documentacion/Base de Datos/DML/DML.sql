/*
ByteSoft - 2020
DML - Creación de los datos
*/

USE bytesoft_bdd;

/*
Usuario
*/
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("15654523", "8697e8189037e76ce6e1be276be33265def98696e240637666299b38e70ccc1e", "Javier", "Da Silva", "Pérez", "javiGonzales@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("5456234", "4C8B422307AC7BDF38C2C17BAB533EAD4FC28D6DAEC176B195EF8A25A20A53E2", "Gonzalo", "Martinez", "Jara", "martiGon@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("5264558", "AF851605D713D13E19FE0A718409A8F5306C3F148A631239AB24851D6C9B6029", "Nicolás", "Rodriguez", "Jurado", "nicorodriguez97@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("43462946", "F369958093324770D9CE761DE406E5BD90154523C002D20FD681CF101661D9C2", "Juan", "Gutierrez", "Lopez", "juanlopez21@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("6975124", "F24ABC34B13FADE76E805799F71187DA6CD90B9CAC373AE65ED57F143BD664E5", "Pedro", "Pereira", "Machado", "machadopedro7@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("53642362", "E4508DA5D861CB30C0A622A8FB677C436C870F446103DD920B69DFBB5D638750", "Matías", "Padrón", "Macedo", "matipadron777@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("34569836", "B6FECD38E1AF90E1D117BFE6694E0AB54D4C9447DB0C8412FE66DE3BD9E43B9F", "Valentín", "García", "Maldonado", "valegarcia@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("49841235", "95B99B07F44831711AA88715F8E8DE493B9AD51546018580F3140EE49D2EF573", "Alexis", "Rivera", "Navarro", "alexisnavaro666@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("31264984", "A95BEE4EFB70453E61F91D2D59B727BA8F62D3CB39700FD62590D38B9344072A", "Rodrigo", "Oseira", "Ochoa", "roseira990@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("9679359", "50AD41624C25E493AA1DC7F4AB32BDC5A3B0B78ECC35B539936E3FEA7C565AF7", "Mariano", "Ferreira", "Olivera", "marianoolivera63@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("76700056", "7E5DA17A86414D890D579669A82D6226490983468D17387358EE2B63E28B7487", "Lucía", "Pérez", "Olmo", "luperez29@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("39012888", "FD906B13C62DC06F7A42789988ADBEBDDCB171BE2D6B4CAF1E5991A84634BCF1", "Ariana", "Acosta", "Ramos", "ariramos@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("39389695", "F7CDD5E13AC6DA7EF654764199CDA1BA433C93E8440876B89CC704D1AA6DAE0F", "Fernanda", "Acuña", "Pérez", "ferperez4@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("18360276", "2F34B801CB2F8EE28525437FE45DD6E41329578F81E11904B8B35CE95DCC58AD", "Paula", "Falco", "Peralta", "paulaperelta2001@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("24357009", "3DBE378C509A4B1900E24173EF07AAD8C466FE8BEFAE256A85B5B7DBDCDCFB46", "Pablo", "Flores", "Ramírez", "pablitoramirez@gmail.com");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("11111111", "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b", "xd", "xd", "xd", "xd");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("22222222", "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b", "xd", "xd", "xd", "xdd");
INSERT INTO usuario (cedula, contrasena, pNom, pApe, sApe, correo) VALUES ("33333333", "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b", "xd", "xd", "xd", "xddd");

/*
UsuarioTel
*/
INSERT INTO usuarioTel (cedula, telefono) VALUES ("5264558","26280256");
INSERT INTO usuarioTel (cedula, telefono) VALUES ("31264984","26479612");
INSERT INTO usuarioTel (cedula, telefono) VALUES ("49841235","26280259");
INSERT INTO usuarioTel (cedula, telefono) VALUES ("5264558","09865312");
INSERT INTO usuarioTel (cedula, telefono) VALUES ("39389695","097421252");
INSERT INTO usuarioTel (cedula, telefono) VALUES ("24357009","24781256");

/*
Chat
*/
INSERT INTO chat (idChat) VALUES (1);
INSERT INTO chat (idChat) VALUES (2);
INSERT INTO chat (idChat) VALUES (3);
INSERT INTO chat (idChat) VALUES (4);
INSERT INTO chat (idChat) VALUES (5);
INSERT INTO chat (idChat) VALUES (6);

/*
Mensajes
*/
INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES ("9679359", "1","¿Cómo te sentís?", '2020-08-08');
INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES ("34569836", "1","Bien, gracias por preguntar", '2020-08-08');
INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES ("31264984", "2","Buenas tardes", '2020-08-10');
INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES ("76700056", "4","¿Cómo te sentís?", '2020-08-12');
INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES ("15654523", "6","Holaaaa", '2020-08-15');
INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES ("15654523", "6","Cómo está", '2020-08-15');

/*
Gestores
*/
INSERT INTO gestor (cedula) VALUES ("24357009");
INSERT INTO gestor (cedula) VALUES ("6975124");
INSERT INTO gestor (cedula) VALUES ("5264558");
INSERT INTO gestor (cedula) VALUES ("39389695");
INSERT INTO gestor (cedula) VALUES ("22222222");

/*
Pacientes
*/
INSERT INTO paciente (cedula, fecNac, sexo) VALUES ("9679359","1998-10-27","M");
INSERT INTO paciente (cedula, fecNac, sexo) VALUES ("15654523","1976-09-12","M");
INSERT INTO paciente (cedula, fecNac, sexo) VALUES ("34569836","2002-04-16","M");
INSERT INTO paciente (cedula, fecNac, sexo) VALUES ("49841235","1999-07-30","M");
INSERT INTO paciente (cedula, fecNac, sexo) VALUES ("11111111","2001-05-26","M");

/*
Sintomas
*/
INSERT INTO sintoma (nombre, descripcion) VALUES ("Fiebre","La fiebre es el aumento temporal en la temperatura del cuerpo en respuesta a alguna enfermedad o padecimiento."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Comezón","Sensación molesta que se siente en una parte del cuerpo y que provoca la necesidad de rascarse.");
INSERT INTO sintoma (nombre, descripcion) VALUES ("Tos","Las vías respiratorias se hinchan dificultando el paso del aire y la tos puede provocar dolor. Es propio de enfermedades como el resfriado común, la gripe, el asma, neumonía, bronquitis, cáncer de pulmón o fibrosis entre otras.");
INSERT INTO sintoma (nombre, descripcion) VALUES ("Deshidratación","La deshidratación es la alteración o falta de agua y sales minerales en el plasma de un cuerpo, también se puede definir como la pérdida de agua corporal por encima del 3 % .");
INSERT INTO sintoma (nombre, descripcion) VALUES ("Desmayo","Pérdida momentánea del sentido o del conocimiento que sufre una persona."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Mareos","El mareo es un término que a menudo se utiliza para describir dos síntomas diferentes: sensación de mareo y vértigo. El mareo es la sensación de que podría desmayarse."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Náuseas","La náusea es la sensación de tener ganas de vomitar. El vómito es la salida violenta del contenido del estómago a través de la boca.");
INSERT INTO sintoma (nombre, descripcion) VALUES ("Diarrea","Se le llama diarrea a las heces acuosas y blandas. Usted tiene diarrea si evacúa heces sueltas tres o más veces en un día. La diarrea aguda dura un corto tiempo y es un problema común.");
INSERT INTO sintoma (nombre, descripcion) VALUES ("Dolor de garganta","El dolor de garganta es dolor, carraspera o irritación de la garganta que a menudo empeora al tragar.");
INSERT INTO sintoma (nombre, descripcion) VALUES ("Dolor abdominal","Es el dolor que se siente en el área entre el pecho y la ingle, a menudo denominada región estomacal o vientre."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Dolor de cabeza","Es un dolor o molestia en la cabeza, el cuero cabelludo o el cuello. Las causas graves de los dolores de cabeza son raras. La mayoría de las personas con dolores de cabeza se pueden sentir mucho mejor haciendo cambios en su estilo de vida, aprendiendo formas de relajarse y, algunas veces, tomando medicamentos."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Fatiga","La fatiga puede ser una respuesta normal e importante al esfuerzo físico, al estrés emocional, al aburrimiento o a la falta de sueño."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Asma","Es una enfermedad crónica que provoca que las vías respiratorias de los pulmones se hinchen y se estrechen"); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Problemas respiratorios","Los problemas respiratorios se producen cuando el cuerpo es incapaz de adquirir el oxígeno que necesita. Se producen como consecuencia de una nariz tapada o a causa de la realización de ejercicio físico."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Taquicardia","La taquicardia es un tipo frecuente de trastornos del ritmo cardíaco (arritmia) en el que el corazón late más rápido de lo normal cuando está en reposo."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Autolesión","Es el acto de dañarse deliberadamente el propio cuerpo, como cortarse o quemarse. Normalmente, no pretende ser un intento de suicidio. En cambio, este tipo de autolesión es una forma dañina de enfrentar el dolor emocional, la ira intensa y la frustración.");
INSERT INTO sintoma (nombre, descripcion) VALUES ("Cansancio","El cansancio es la falta de fuerzas después de realizar un trabajo físico, intelectual o emocional, o por la falta de descanso. Pero puede ser síntoma de una enfermedad, si no hay una actividad previa que lo justifique."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Conjuntivitis","La conjuntivitis es una de las afecciones del ojo más frecuentes y tratables en el mundo. Puede afectar tanto a niños como adultos. Es una inflamación de la conjuntiva, la membrana fina y transparente que recubre el interior del párpado y la parte blanca del ojo."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Urticaria","La urticaria es una enfermedad de la piel caracterizada por lesiones cutáneas edematosas, de contornos delimitados y con un halo eritematoso, generalmente evanescentes y cambiantes."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Tristeza","Sentimiento de dolor anímico producido por un suceso desfavorable que suele manifestarse con un estado de ánimo pesimista, la insatisfacción y la tendencia al llanto."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Cólicos estomacales","Un cólico es un tipo de dolor abdominal que va variando de intensidad y puede ser muy agudo."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Vómitos","Vomitar es cuando devuelve el contenido del estómago por la boca."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Escalofrios","Se refieren a una sensación de frío después de estar expuesto a un ambiente frío. La palabra también se puede referir a un episodio de temblores junto con palidez y sensación de frío."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Congestión nasal","Una nariz congestionada o tapada se produce cuando los tejidos que la recubren se hinchan. La hinchazón se debe a la inflamación de los vasos sanguíneos. El problema también puede incluir rinorrea o secreción nasal."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Pérdida del olfato","El deterioro del olfato es la pérdida total o parcial o la percepción anormal del sentido del olfato."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Disnea","La disnea es una sensación de falta de aire. Muchas personas con cáncer avanzado pueden experimentarla. Las personas que tienen cáncer en estadios iniciales y tienen otras afecciones que afectan al corazón o los pulmones, como un coágulo sanguíneo, también pueden experimentar disnea."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Hormigeo","Son sensaciones anormales que pueden ocurrir en cualquier parte del cuerpo, pero con frecuencia se sienten en los dedos de las manos, las manos, los pies, los brazos o las piernas."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Sensación de hambre","El hambre es una sensación que se presenta como un recordatorio del cuerpo ante la necesidad de consumir alimentos que permitan funcionar adecuadamente. Sin embargo, el apetito y la sensación de saciedad no están siempre relacionados con la ingesta de comida."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Visión borrosa","La vision borrosa es la pérdida de la agudeza visual, lo que hace que los objetos aparezcan fuera de foco y con opacidad."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Imsomnio","El insomnio es un trastorno del sueño que puede manifestarse como dificultad para conciliar el sueño (insomnio inicial), despertarse frecuentemente durante la noche o despertarse muy temprano por la mañana, antes de lo planeado (insomnio terminal)."); 
INSERT INTO sintoma (nombre, descripcion) VALUES ("Ansiedad","Sentir ansiedad de modo ocasional es una parte normal de la vida. Sin embargo, las personas con trastornos de ansiedad con frecuencia tienen preocupaciones y miedos intensos, excesivos y persistentes sobre situaciones diarias."); 

/*
Patologias
*/
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("COVID-19","","","1");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Gripe","Es una enfermedad infecciosa aguda de las vías respiratorias producida por un virus. Si algo caracteriza a este microorganismo es su elevada capacidad de transmisión. El virus pasa con mucha facilidad de una persona a otra a través de las gotitas de saliva que se expulsan al hablar, toser o estornudar.","Mantener una buena higiene personal y beber mucho líquido, además de dormir las horas necesarias","3");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Diabetes","La diabetes es una enfermedad crónica que se origina porque el páncreas no sintetiza la cantidad de insulina que el cuerpo humano necesita, la elabora de una calidad inferior o no es capaz de utilizarla con eficacia.","El tratamiento de la diabetes se basa en tres pilares: dieta, ejercicio físico y medicación. Tiene como objetivo mantener los niveles de glucosa en sangre dentro de la normalidad para minimizar el riesgo de complicaciones asociadas a la enfermedad.","1");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Cáncer de pulmon","El cáncer de pulmón se produce cuando hay un crecimiento exagerado de células malignas en este órgano. Si no se diagnostica a tiempo se puede producir la metástasis del tiempo, en estos casos las células cancerosas se desplazan hacia otros órganos del cuerpo.","La elección de tratamiento dependerá de la etapa y de la extensión del cáncer, del tamaño del tumor o el tipo de cáncer de pulmón. Las principales opciones son: Cirugía, radioterapia, quimioterapia o imnunoterapia","1");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Depresión","La depresión se presenta como un conjunto de síntomas de predominio afectivo (tristeza patológica, apatía, anhedonia, desesperanza, decaimiento, irritabilidad, sensación subjetiva de malestar e impotencia frente a las exigencias de la vida.","El ambiente que rodea a una persona que sufre depresión es fundamental para lograr su rehabilitación. La comprensión y el cariño de los familiares y allegados es importante, como lo es la paciencia, puesto que la falta de ganas y motivación de los enfermos puede provocar la desesperación.","2");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Ébola","El virus del Ebola se empieza a propagar en poblaciones humanas por contacto estrecho con órganos, sangre, secreciones u otros líquidos corporales de animales infectados, como chimpancés, gorilas, murciélagos frugívoros, monos, antílopes y puercoespines que se encuentran muertos o enfermos en la selva.","No hay ningún tratamiento específico, aunque se están evaluando algunos en fase preclínica y experimental. Algunas de estas terapias son: el plasma de convaleciente (transfusiones de plasma que contienen anticuerpos contra el virus).","2");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Gonorrea","La gonorrea es una infección de transmisión sexual (ITS) causada por una bacteria denominada Neisseria gonorrhoeae, que afecta al tracto genital, la boca y el ano. ","Los antibióticos son el mejor tratamiento para tratar la gonorrea aunque, a veces, algunas infecciones resultan ser resistentes a este tipo de medicamentos, por lo que en algunos casos es más frecuente recetar más de un antibiótico.","2");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Gastroenteritis","La gastroenteritis es una infección o inflamación del revestimiento interno (mucosa) del estómago y el intestino delgado que puede estar causada por agentes infecciosos (virus, bacterias, parásitos), toxinas químicas y fármacos.","La gastroenteritis requiere un reposo alimenticio y reposición de agua con electrolitos con sueros orales. En caso de no poder acudir a la farmacia o al centro de salud, puede recurrirse a las bebidas carbonatadas o agua con bicarbonato y sal para recuperar todo el líquido perdido con los vómitos y las diarreas.","3");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Hepatitis A","La hepatitis A es una enfermedad hepática causada por el virus de la hepatitis A. Este virus se transmite principalmente cuando una persona que no está infectada y no está vacunada come o bebe algo contaminado por heces de una persona infectada por ese virus.","No existe un tratamiento específico para la hepatitis A más allá de las vacunas, pero la mayoría de personas que contraen la hepatitis A se recuperan por sí solas en pocas semanas.","2");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Hepatitis B","La hepatitis B es una infección hepática que está causada por el virus de la hepatitis B. Según la Organización Mundial de la Salud (OMS), esta patología supone un importante problema de salud a nivel mundial, ya que es el tipo más grave de hepatitis viral.","La hepatitis B no necesita un tratamiento específico en la fase aguda. Las medidas se centran en mantener el bienestar y el equilibrio nutricional, que incluye la reposición de los líquidos perdidos por los vómitos y la diarrea.","1");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Meningitis","La meningitis es una enfermedad habitualmente infecciosa provocada por virus o bacterias que provoca la infección e inflamación de las meninges -unas membranas que rodean el cerebro y la médula espinal-.","La mayor parte de las personas que sufre una meningitis viral se cura sin problemas. En la meningitis bacteriana el tratamiento consiste en cuidados específicos en el hospital y terapia intensa con antibióticos.","3");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Malaria","El paludismo o malaria es una enfermedad provocada por el parásito Plasmodium, un parásito unicelular, que se transmite a través de la picadura de mosquitos infectados hembra del género Anopheles.","La malaria requiere hospitalización por lo que una persona susceptible de haber sido infectada que presenta síntomas debe acudir inmediatamente al médico. El tratamiento principal es con cloroquina. Sin embargo, a veces el parásito puede ser resistente a este fármaco y el paciente requerirá otros tratamientos.","2");
INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ("Neumonía","La neumonía es una infección en uno o en los dos pulmones caracterizada por la multiplicación de microorganismos en el interior de los alvéolos, lo que provoca que aparezca una inflamación con daño pulmonar. Puede estar causada por múltiples patógenos (bactrias, hongos y virus).","“Una vez que diagnosticamos la neumonía se indica inmediatamente un tratamiento antibiótico. Cuando hay sospecha de que está presente el virus de la gripe se añade también un tratamiento antivírico (más habitual en invierno).","1");

/*
Médico
*/
INSERT INTO medico (cedula, especializacion) VALUES ("31264984","Oncólogo");
INSERT INTO medico (cedula, especializacion) VALUES ("9679359","Pediatra");
INSERT INTO medico (cedula, especializacion) VALUES ("76700056","Cirujano");
INSERT INTO medico (cedula, especializacion) VALUES ("18360276","General");
INSERT INTO medico (cedula, especializacion) VALUES ("53642362","Cardiólogo");
INSERT INTO medico (cedula, especializacion) VALUES ("33333333","Pediatra");

/*
Patologia contiene síntoma
*/
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (1,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (1,9);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (1,3);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (1,14);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (1,12);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (1,11);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (1,26);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (2,11);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (2,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (2,2);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (2,9);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (2,23);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (2,24);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (3,4);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (3,12);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (3,26);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (3,28);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (3,29);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (4,12);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (4,3);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (4,25);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (5,16);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (5,12);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (5,20);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (5,30);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (5,31);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (6,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (6,2);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (6,9);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (6,10);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (6,11);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (6,8);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (6,22);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (7,10);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (7,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (7,22);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (7,11);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (8,10);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (8,22);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (8,8);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (8,7);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (8,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (8,11);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (9,12);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (9,7);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (9,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (9,21);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (9,8);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (10,12);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (10,7);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (10,22);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (10,10);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (10,8);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (11,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (11,11);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (11,22);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (12,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (12,11);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (12,10);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (12,23);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (12,22);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (13,1);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (13,10);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (13,12);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (13,9);
INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (13,3);

/*
Fin
*/