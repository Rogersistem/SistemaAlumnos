use DBA_CIPOST2019
GO

CREATE DATABASE DBA_CIPOST2019
go


create table Usuarios(
id_usuario   int  unique,
nom_usu      varchar(50) not null,
cuenta       varchar(50) not null,
Password     varchar(50) not null,
Status_Admin bit not null,
Foto varchar(300)null
);
go


/* =======direccion de las imagens para insertar a la tabla usuarios
  C:\Users\Lenovo\Desktop\Sistema_CipostUNT\FactuxD\FactuxD\Resources\rogerr.jpg
//C:\Users\Lenovo\Desktop\Sistema_CipostUNT\FactuxD\FactuxD\Resources\Roger.jpg*/

insert into Usuarios values(202011,'Yuri','yuri01',1234,1,'C:\Users\Lenovo\Desktop\Sistema_CipostUNT\FactuxD\FactuxD\Resources\admin.png');
insert into Usuarios values(202012,'Rocio','Rocio02',1234,0,'C:\Users\Lenovo\Desktop\Sistema_CipostUNT\FactuxD\FactuxD\Resources\rocio.png');
select * from Usuarios
go

---procedimineto almacenado para registar usuarios
create proc spRegistrarUsuarios
@idusuario int,
@nombre varchar(50),
@cuenta varchar(50),
@password varchar(50),
@statusAdmin bit,
@foto varchar(300)
as
begin
insert into Usuarios values(@idusuario,@nombre,@cuenta,@password,@statusAdmin,@foto);
end
exec spRegistrarUsuarios 202013,'Yuri','Yuri03',122,1,'C:\Users\Lenovo\Pictures\Camera Roll\admin.jpg'
select * from Usuarios
go
---crear procedimiento almacenADO para recueperar contraseña

create proc SpRecuperarCuenta
@idusuario int
as
begin 
select [cuenta],[Password] from Usuarios
where  id_usuario=@idusuario
end

exec SpRecuperarCuenta 202012
go
select * from Usuarios
--///////////////////////////////////
  --  tabla programa
 create table Programa(
 codPrograma    char(9)  not null primary key,
 Descripcion    varchar(30)  null,
 costoPrograma  numeric(10,2)  null
 );
 go 

/*
alter table Alumno
drop column  Apellido_Materno 
go
alter table Alumno
add AluApellidos varchar(30)
go
*/

Create Table Alumno(
aluCodigo     char(9)     not Null Primary Key,
aluDni        char(8)     not null,
aluApellidos  varchar(30) null,
aluNombres    varchar(30) null,
aluGenero     char(1)     null,
aluCelular    char(9)     null,
aluEmail      varchar(35) null,
aluDireccion  varchar(45) not null,
aluFechaNac   Date       null,
aluPais       varchar(20) null,
Departamento  varchar(20) null,
Distrito      varchar(20) null,
codPrograma    char(9) references Programa
);
Go
 
--tabal Docente
 Create Table Docente(
docCodigo      Char(9)  not  null Primary Key,     
docDni         char(8)      not null,
docApellidos   varchar(40)  not null, 
docNombres     varchar(30)  not null,
docGenero      char(1)  not null,
docCelular     char(9)      null,
docEmail       varchar(30)  not null,
docDireccion   varchar(10)  not null,
pais           varchar(20) not null,
Distrito       varchar(20) not null
 );
 go
 

 
-- 14 Crando La Tabla  Curso


 Create Table Curso(
 codCurso    char(8)  not Null  Primary Key,
 CurNomcurso varchar(30)  null,
 codPrograma char(9)   references Programa,
 docCodigo   char(9)   references Docente,
 years       char(9),
 aula        varchar(20),
 FechaInicio date,
 FechaTermino date
 );
 select * from Curso
 Go


/*
 alter table Curso
 add FechaInicio date,FechaTermino date

 alter table Curso 
 drop column horaInicio,column horaTerminno
 */

  -- 15 tabla Horario
 create table  Horario(
 CodHorario        char(9) not null primary key,
 HoraInicion      SmallDateTime   null ,
 HoraFin          SmallDateTime  null,
 Turno varchar(20)null
 );
 go
 select * from Horario 

 insert into Horario values(5,'5/3/2020 3:30:23','5/3/2020 6:50:0','Grupo A');
 

 Create Table Matricula(
 codMatricula        char(9) Not Null Primary Key,
 tipoMatricula       varchar(20)  not null,
 CodAlumno           char(9)  references Alumno,
 codPrograma       char(9) references Programa,
 codHorario           char(9)  references Horario,
 periodo             nvarchar(20)  Null,
 fechaInicio         date   Null
 );
 Go
 select * from Matricula
 select * from Horario
 go
  
 --- 18 crea tabla pagos

 create table Pago(
 aluCodigo    Char(9) references Alumno,
 fechaPago    date null,
 pagoMonto     decimal(18,2)
 )
  go

 select * from pago
 go

 
  --19 creamos la tabla notas
  
  create table Notas(
  aluCodigo  Char(9)     references Alumno,
  codCurso    char(8)     references Curso,
  Unid_1 numeric(4,2) ,
  Unid_2 numeric(4,2),
  Unid_3 numeric(4,2),
  Unid_4 numeric(4,2) ,
  Unid_5 numeric(4,2),
  );
  go
  select * from Notas


    ---crando la tabla Asistencia 
 
  create   table Asistencia(
  CodCurso char(8) not null references Curso,
  CodDocente char(9) not null references Docente,
  CodHorario char(9)not null references Horario,
  CodAlumno char(9) not null references Alumno,
  fecha date not null
  );
  go
   select * from Asistencia
   go

  --crear la Tabla Evaluacion
  create table Evaluacion(
  CodCurso char(8) not null references Curso,
  CodDocente char(9) not null references Docente,
  CodHorario char(9)not null references Horario,
  CodAlumno char(9) not null references Alumno,
  fecha date not null
  );
  go
  SELECT * FROM Evaluacion
  ----insertar notas 



  --======



  go
  --procedimiento almacenado para registar Notas 
  create procedure SpRegistarNotas
  @codAlumno char(9),
  @codCurso char(8),
  @unida1 numeric(4,2),
  @unida2 numeric(4,2),
  @unida3 numeric(4,2),
  @unida4 numeric(4,2),
  @unida5 numeric(4,2)
  as
  begin
  insert into Notas values(@codAlumno,@codCurso,@unida1,@unida2,@unida3,@unida4,@unida5);
  end
  --exec SpRegistarNotas 
  select * from Notas
   select * from Alumno
   select *from Curso

  go

  --procedimento almacenado actualizar notas 
  create procedure SpActualizaNotas
  @codAlumno char(9),
  @codCurso char(8),
  @unida1 numeric(4,2),
  @unida2 numeric(4,2),
  @unida3 numeric(4,2),
  @unida4 numeric(4,2),
  @unida5 numeric(4,2)
  as
  begin
  update  Notas set [aluCodigo]=@codAlumno,[codCurso]=@codCurso,
  [Unid_1]=@unida1,[Unid_2]=@unida2,[Unid_3]=@unida3,[Unid_4]=@unida4,[Unid_5]=@unida5
  where [aluCodigo]=@codAlumno
  end
  --exec SpActualizaNotas 123,12,'CI0002',11,11,10,8,9
  go

  ---procedimeinto almacendo para Eliminar Notas
  create procedure SpEliminaNotas
  @aluCodigo char(9)
  as
  begin
  delete from Notas
  where aluCodigo=@aluCodigo
  end
  ---exec SpEliminaNotas  
  select *from Notas
  go

  ---procedimiento almacenado sacar promedio de notas 
  create procedure SpPromedioNotas
  as
  begin
  select *,(Unid_1 + Unid_2 + Unid_3 + Unid_4 + Unid_5)/5 as [Promedio Final] from Notas
  END
     exec SpPromedioNotas
   select * from Notas
  GO 

  --procedieminto para notas 
  create procedure SpConsultaNotas
  as
  begin
  select [aluCodigo]as[Cod Alumno],
  [codCurso],[Unid_1],[Unid_2],[Unid_3],[Unid_4],[Unid_5] from Notas
  end
  exec SpConsultaNotas
  go

  --consultar notas alumno
  create  proc SPConsultarNotasAlumno
	as
	begin
	select A.aluCodigo as [Codigo Alumno],A.[aluApellidos]+ ' ' + A.[aluNombres]as [Apellidos y Nombre],
	A.[aluPais]as País,N.Unid_1,N.Unid_2,N.Unid_3,N.Unid_4,N.Unid_5,
	C.[CurNomcurso]as Curso, C.[years]as Año,P.[Descripcion] as Programa
	 from Notas N inner join [dbo].[Alumno] A
	  on (A.aluCodigo=N.aluCodigo) inner join [dbo].[Curso] C
	  on (C.codCurso=N.codCurso) inner join [dbo].[Programa] P
	  on (P.codPrograma=C.codPrograma)
	  end

	  exec SPConsultarNotasAlumno
	  go

  --====================procedimento almacenado para lsta de Evaluacion

 alter procedure SpListaEvaluacion
  as
  begin
  select C.[codCurso]as[Cod-Curso],D.docApellidos + ' '+D.docNombres as Docente,H.[horaInicion],H.[horaFin],
  C.[FechaInicio]as [Fecha Inicio],C.[FechaTermino]as [Fecha Termino],A.[aluApellidos]+ '  ' + A.[aluNombres] as [Alumno],
  N.[Unid_1],N.Unid_2,N.Unid_3,N.Unid_4,N.Unid_5,
 (N.[Unid_1]+N.[Unid_2]+N.[Unid_3]+N.[Unid_4]+N.[Unid_5])/5 as [Promedio Final],convert(nvarchar,E.fecha,100) as Fecha
 from Curso C inner join Notas N
 on N.codCurso=C.codCurso  inner join Alumno A
 on A.aluCodigo=E.CodAlumno inner join Docente D
 on D.docCodigo=E.CodDocente inner join Horario H
 on H.codHorario=E.CodHorario
 end
 exec SpListaEvaluacion
 go
  --procedimeinto para la Asistencia 
  --format(convert(datetime,horaTerminno),'hh:mm:ss')
  --convert(nvarchar,Fecha, 100)as [Fecha]
 
  create procedure SpListaAsistencia
  as
  begin
   select C.CodCurso as [Codigo Curso],C.[FechaInicio]  as [Fecha Incio],C.[FechaTermino] as[Fecha Termino],(D.docApellidos + ' '+D.docNombres)as Docente,H.horaInicion,H.horaFin,
     (A.aluApellidos  + ' ' +A.aluNombres)as [Apellidos Y Nombres],convert(nvarchar,Fecha, 100)as [Fecha] from Asistencia asi inner join Curso C
	 on C.codCurso   = asi.CodCurso   inner join Docente D
	 on D.docCodigo  = asi.CodDocente inner join Horario H
	 on H.codHorario = asi.CodHorario inner join Alumno A
	 on A.aluCodigo=asi.CodAlumno
	 order by [fecha] asc
  end
  exec SpListaAsistencia
   select *from Curso
   go
 ---procedimiento para registrar asitencia
 create proc SpRegistraAsistecias
 @codcurso char(8),
 @codDocente char(9),
 @codHorario char(9),
 @codAlumno char(9),
 @fecha date
 as
 begin
 insert into Asistencia values(@codcurso,@codDocente,@codHorario,@codAlumno,@fecha);
 end
-- exec SpRegistraAsistecias 'CI0002 ',123,00001,12,'12/5/2019'
 select * from Asistencia
 select * from Docente
 go 
 
 --procedure almaceado Actualizar asistencias
 create procedure SpActualizaAsistencia
 @codcurso char(8),
 @codDocente char(9),
 @codHorario char(9),
 @codAlumno char(9),
 @fecha date
 as
 begin
 update Asistencia set [CodCurso]=@codcurso,[CodDocente]=@codDocente,
 [CodHorario]=@codHorario,[CodAlumno]=@codAlumno,[fecha]=@fecha
 where [CodAlumno]=@codAlumno
 end
 --exec SpActualizaAsistencia  'CI0002 ',123,00001,12,'12/3/2020'
 go
 --procedimiento almacenado Eliminar a un aasitencia,sólo si el codigo del curso y el del alumnoson los existentes
 create procedure SpEliminaAsistencias
 @codCurso char(8)
 as
 begin
 delete from Asistencia
 where [CodCurso]=@codCurso 
 end
-- exec SpEliminaAsistencias  'CI0002 '
 go
 select * from Asistencia
 go
 --consultar Asistencias 
 create procedure SpConsultarAsistencias
 as
 begin
 select [CodCurso]as[Codigo Curso],[CodDocente]as[Codigo Docente],[CodHorario]as[Codigo Horario],
 [CodAlumno]as [Codigo Alumno],convert(nvarchar,fecha,100)as [Fecha]from Asistencia
 end
 exec SpConsultarAsistencias
 go
  select * from Curso
  select * from Horario
  select *from Curso
  select *from Docente
  select * from Alumno

  insert  into Asistencia values('CI0002',123,00001, 12,'12/2/2020' ) 
  insert  into Asistencia values('CI0003',123,00001, 12,'12/2/2020' ) 
  insert  into Asistencia values('CI0004',123,00001, 12,'12/2/2020' ) 
  insert  into Asistencia values('CI0005',123,00001, 12,'12/2/2020' ) 
		  
  select * from Asistencia
  select * from Curso
 

 --datos para la tabla programa
 insert into Programa values(2019001,'Ingles',300);
 insert into Programa values(2019002,'Frances',250);
 insert into Programa values(2019003,'Aleman',280);
 insert into Programa values(2019004,'Portuguez',450);
 go 
   select * from Programa
 --Inserciones De Datos 
   insert into Alumno values('C345556', 76543232,'Cabrera Orbegozo','Nancy','F',953610705,'Nancy@gmail.com','av.condor 123','11/7/2019','Peru','La Libertad','Trujillo',2019001);
   insert into Alumno values('C3455576', 71133445,'Magnolia Chavez','Paredes','F',953610705,'Gmacko@gmail.com','av.nico 23','12/5/2019','Peru','La Libertad','Trujillo',2019001);
   insert into Alumno values('C2019345', 87654323,'Paredes Navarro','jesus','M',976434534,'jgpared@gmail.com','av.surco 112','1/4/2019','Brazil','La Libertad','Trujillo',2019002);
   insert into Alumno values('C345557', 76543235,'Cabrera Orbegozo','Roberto','M',953610700,'Roberto@gmail.com','av.sauce 443','11/8/2019','Brazil','La Libertad','Trujillo',2019002);
   insert into Alumno values('C3455578', 71133442,'Carranza Chavez','Sandra','F',953610703,'Sandra@gmail.com','av.arenal 112','10/5/2019','Peru','La Libertad','Trujillo',2019002);
   insert into Alumno values('C2019349', 87654321,'Paredes Carrion','Sebastian','M',976434533,'Sebastian@gmail.com','av.pope 345','23/4/2019','Peru','La Libertad','Trujillo',2019002);
     select * from Alumno
	 go
	
	 --datos para l atabla Docentes
   insert into Docente values(92130,98765432,'Rebaza Sandoval','Ignasio','M',909056732,'rebaza@gmail.com','sinchi 112','Peru','Trujillo');
   select * from Docente

	 --datos para la tabla cursos
	 select * from Curso
	 insert into Curso values('CI0004','Ingles III',2019001,92130,2019,'Ac 201','08:30 am','11:15 am');
	 insert into Curso values('CI0005','Ingles VI',2019001,92130,2019,'Ac 201','09:30 am','01:15 pm');

	 insert into Curso values('CI0006','Ingles II',2019001,92130,2019,'Ac 201','08:30 am','11:15 am');
	 insert into Curso values('CI0007','Ingles I',2019001,92130,2019,'Ac 201','09:30 am','01:15 pm');
	
	 --registros para la tbla Notas
	 insert into Notas values('C2019345','CI0004',19,13,15,16,17);
	 insert into Notas values('C2019349','CI0005',16,14,17,20,17);
	  insert into Notas values('C345556 ','CI0006',12,13,19,17,18);
	   insert into Notas values('C345557 ','CI0007',19,19,19,19,19);
	 select * from Notas
	 select * from Curso
	 select * from Alumno
	-- DELETE FROM Notas WHERE notafinal=26
	--insertar datos para la tabla Horario
	insert into Horario values(1,'5/3/2020 3:30:23','5/3/2020 6:50:0','Grupo A');
	insert into Horario values(2,'2/1/2019 02:05','7/3/2020 05:30','Grupo B');
	insert into Horario values(3,'20/5/2018 02:05','8/4/2020 05:30','Grupo C');
	insert into Horario values(4,'20/6/2017 2:05','9/6/2020 05:30','Grupo D');
	insert into Horario values(5,'20/4/2020 02:05','10/5/2020 05:30','Grupo E');
	insert into Horario values(6,'20/5/2019 02:05','11/1/2020 05:30','Grupo F');

	insert into Horario values(7,'20/5/2018 02:05','12/3/2020 05:30','Grupo G');
	insert into Horario values(8,'20/6/2017 2:05','13/6/2020 05:30','Grupo H');
	insert into Horario values(9,'20/4/2020 02:05','14/7/2020 05:30','Grupo I');
	insert into Horario values(10,'20/5/2019 02:05','15/3/2020 05:30','Grupo J');
	select * from Horario
	

	--insertar datos a la tabla Matricula
	insert into Matricula values(202001,'Presencial','C2019345',2019001,1,'2020I','25/02/2020')
	insert into Matricula values(202002,'Presencial','C2019349',2019002,2,'2020 II','25/02/2020')
	insert into Matricula values(202003,'Presencial','C345556',2019003,3,'2020 III','25/02/2020')
	insert into Matricula values(202004,'Presencial','C345557',2019004,4,'2020IV','25/02/2020')
	insert into Matricula values(202005,'Presencial','C3455576',2019004,5,'2020VI','25/02/2020')
	select * from Matricula
	select * from Programa
	select * from Horario
	select * from Alumno
	go

	--insertar datos a la tabla pagos
	insert into pago values('C2019345','30/01/2020', 210.45);
	insert into pago values('C2019349 ','1/02/2018', 200);
	insert into pago values('C345556','30/01/2020', 210.45);
	insert into pago values('C345557','1/02/2018', 200);
	insert into pago values('C3455576','30/01/2020', 210.45);
	insert into pago values('C3455578','1/02/2018', 200);
	select * from Pago
	select * from Alumno
	go 


  --==================================PROCEDIMIENTOS ALMACENADOS =======================================

  --busqueda de alumno por apellidos y Dni===============

 create procedure  SpBuscarAlporApelliyDni
 @letra varchar(50)
 as
 select  [aluCodigo]as Codigo,[aluDni]as Dni,[aluApellidos]as Apellidos,[aluNombres]as Nombres,[aluGenero] as Genero
 ,[aluCelular]as [Nº Celular],[aluEmail]as Email,[aluDireccion]as Dirección,[aluFechaNac] as [Fecha Nacimiento],
 [aluPais]as Pais,[Departamento],[Distrito],[codPrograma]as[Codigo Programa] from Alumno
 where [aluApellidos] + [aluDni] like '%'+ @letra + '%'

 exec SpBuscarAlporApelliyDni  'Pa'
 select * from Alumno
 go
 --=========================================================================================================
 --=====================================
  --procedimieto almacenado para registrar al docente
  create proc SpRegistrarDocente
 @docCodigo char(9),
 @docDni char(8),
 @docApellidos varchar(40),
 @docNombres varchar(30),
 @genero char(1),
 @celular char(9),
 @gmail nvarchar(30),
 @direcion varchar(10),
 @pais varchar(20),
 @distrito varchar(20)
  as
  begin
  insert into Docente values(@docCodigo,@docDni,@docApellidos,@docNombres,
  @genero,@celular,@gmail,@direcion,@pais,@distrito)
  end
  
  exec SpRegistrarDocente 123,34567,'Rebaza Sisneros','Andrea','F',987654320,'Andrea@gmail.com','av.santa 112','Peru','Ascope'
  select * from Docente 
  go
  --crea procedimeinto almacenado para actualizar Docentes
 
  create proc SpActualizaDocente
 @docCodigo char(9),
 @docDni char(8),
 @docApellidos varchar(40),
 @docNombres varchar(30),
 @genero char(1),
 @celular char(9),
 @gmail nvarchar(30),
 @direcion varchar(10),
 @pais varchar(20),
 @distrito varchar(20)
  as
  begin
  update Docente set docCodigo=@docCodigo,[docDni]=@docDni,[docApellidos]=@docApellidos,[docNombres]=@docNombres,
  [docGenero]=@genero,[docCelular]=@celular,[docEmail]=@gmail,[docDireccion]=@direcion,[pais]=@pais,[Distrito]=@distrito
  where [docCodigo]=@docCodigo
  end
  exec SpActualizaDocente 123,34567,'Rebaza Sisneros','Andrea','F',987654320,'Rebaza@gmail.com','pje Almagro 112','Peru','Ascope'
  select * from Docente 
  go
  --create procedimeto almacenado para eliminar Docente
  create proc SpElimiaDocente
    @docCodigo char(9)
  as
  begin
 delete from Docente
  where [docCodigo]=@docCodigo
  end
 -- exec SpElimiaDocente 123
  select * from Docente
  go
  --procedimiento para consultar Docentes
  create proc SpConsultaDocentres
  as
  begin
  select [docCodigo]as Codigo_Docente,[docDni]as DNI,[docApellidos]AS Apellidos,[docNombres]as Nombres,
  [docGenero]as Género, [docCelular]as Celular,[docEmail]as E_mail,
 [docDireccion]as Dirección,[pais]as Pais,[Distrito] from Docente
  end
  exec SpConsultaDocentres
  go 
  --Procedimientos almcenados para la tabla Cursos
  create proc SpRegistrarCurso
  @codCurso char(8),
  @nombCurso varchar(30),
  @codprogram char(9),
  @codDocente char(9),
  @year char(9),
  @aula varchar(20),
  @FechInicio varchar(10),
  @FechFin varchar(10)
  as
  begin
  insert Into Curso values(@codCurso,@nombCurso,@codprogram,@codDocente,
  @year,@aula,@FechInicio,@FechFin)
  end
  exec SpRegistrarCurso 'CI2020','Frances I',2019002 ,123 ,2020,'BC234','7:00 am','12:30 pm'
   select * from Curso
   select * from Programa
   select * from Docente
  go
  --procedimeinto almacenado para Actualizar Curso
  create proc SpActualizaCurso
  @codCurso char(8),
  @nombCurso varchar(30),
  @codprogram char(9),
  @codDocente char(9),
  @year char(9),
  @aula varchar(20),
  @FechInicio varchar(10),
  @FechFin varchar(10)
  as
  begin
  update Curso set codCurso=@codCurso,[CurNomcurso]=@nombCurso,[codPrograma]=@codprogram,
  [docCodigo]=@codDocente,[years]=@year,[aula]=@aula,[FechaInicio]=@FechInicio,[FechaTermino]=@FechFin
  where [codCurso]=@codCurso
  end
  exec SpActualizaCurso 'CI2020','Frances II',2019002 ,123 ,2020,'BC234','7:00 am','12:30 pm'
  select * from Curso
  go
  --procedimeinto almacenado para elimianr Curso

  create proc SpEliminarCurso
  @codcurso char(8)
  as
  begin
  delete from Curso
  where [codCurso]=@codcurso
  end
  exec SpEliminarCurso 'CI0005'
  select * from Curso
  go
  --procedimiento para mostrar cursos 
  go

  create  proc SpMostrarCursos
  as
  begin
  select[codCurso]as[Codigo Curso],[CurNomcurso]as [Curso],[codPrograma]as[Codigo Programa],
  [docCodigo]as [Cod Docente],[years]as Año,[aula]as Aula,[FechaInicio],[FechaTermino]  from Curso
  end
  exec SpMostrarCursos
  select * from Curso
  go
 --procedimientos almacenados para registar Horario en  la tabla Horarios

 create proc SpRegistrarHorarios
 @codHorario char(9),
 @FechaInicio time,
 @FechaFin time,
 @turno varchar(20)
 as
 begin
 insert into Horario values (@codHorario,@FechaInicio,@FechaFin,@turno)
 end
 exec SpRegistrarHorarios  6,'12/2/2020 7:30:0 ','12/2/2020 10:30:45','Grupo B'
  select * from Horario
  go

  
  --procedimento almacenado para Actualizar el Horario
 
  create proc SpActualizaHorario
 @codHorario char(9),
 @FechaInicio time,
 @FechaFin time,
 @turno varchar(20)
  as
  begin
  update Horario set [codHorario]=@codHorario,[horaInicion]=@FechaInicio,[horaFin]=@FechaFin,Turno=@turno
  where [codHorario]=@codHorario
  end
  
   exec SpActualizaHorario  6,'12/2/2020 7:30:0 ','12/2/2020 10:30:45','Grupo F'
  select * from Horario
  go 
  --procedimeinto almacenado para Eliminar Horario
  create proc SpEliminaHorario
  @codHorario char(9)
  as
  begin
  delete from Horario
  where  [codHorario]=@codHorario
  end
  exec SpEliminaHorario 6
    select * from Horario
  go
  
  --consultar el horario 

  create  proc SpConsultaHorario
  as
  begin
  select  [codHorario] as[Codigo Horario],[horaInicion] as [Hora Inicio],[horaFin]as[Hora Fin],Turno as[Turnos] from Horario
  end
  exec SpConsultaHOrario
	go
	--procedure Pagos Alumnos
	create procedure SpPagosAlumnos
	as
	begin
	select P.[aluCodigo]as [Codigo Alumno], P.[fechaPago]as [Fecha de Pago]
	,P.[pagoMonto]as [Monto Pago],
	(costoPrograma -[pagoMonto]  )as Saldo
	from Pago P inner join [dbo].[Alumno] A
	on A.aluCodigo=P.aluCodigo inner join [dbo].[Programa]Pro
	on pro.codPrograma=A.codPrograma
	end
	exec SpPagosAlumnos
	go
	select * from Pago
	go
	  ---PROCEDIMEINTO ALMACENADO PARA consultar datos de la tbla Pagos
	    ---procedimeinto  para consultar
	  create proc SpConsultarPagos
	  as
	  begin
	  select [aluCodigo]as [Codigo Alumno] ,[fechaPago]as[Fecha Pago],
	  [pagoMonto]as [Monto Pago]from Pago
	  end
	  exec SpConsultarPagos
	  go 
	  select * from Notas
	  go
	  ---creando procedimiento almacenadopara registrar notas
	
	  create proc spReistrarPagos
	  @codAlumno char(9),
	  @fechapago datetime,
	  @MOntoPago decimal(18,2) 
	  as
	  begin
	  insert into Pago values (@codAlumno,@fechapago,@MOntoPago)
	  end
	  go
	  exec spReistrarPagos 'C3455578 ','31/01/2020',150.5
	  select * from Alumno
	  select * from Pago
	  go

	  --crea procedimiento almacenado para actualizar Pagos
	
	   create proc spActualizaPagos
	  @codAlumno char(9),
	  @fechapago date,
	  @MOntoPago decimal(18,2)
	  as
	  begin
	  update  Pago set [aluCodigo]= @codAlumno,[fechaPago]=@fechapago,[pagoMonto]=@MOntoPago
	  where [aluCodigo]=@codAlumno
	  end
	  go
	  exec spActualizaPagos 'C3455578 ','31/01/2020',200.5
	  select * from Pago
	 
	 go

	
	  --crear procedimiento para eliminar pago 
	  create proc SpEliminarPago
	  @aluCodigo char(9)
	  as
	  begin
	   delete from Pago
	  where aluCodigo=@aluCodigo
	  end
	  exec SpEliminarPago 
	  select * from Pago
	  go 
	--procedimento almacenado buscar pagos por  Dni de alumno
	
	create Procedure SpBuscarpagoporDniAlum
	@dni char(8)
	as
	begin
	select P.aluCodigo as[codigo de Pago], (A.aluApellidos+' '+ A.aluNombres)as [Apellidos y Nombre] ,
	convert(nvarchar,[fechaPago],100)as[Fecha de Pago],[pagoMonto]
	from Pago P inner join Alumno A
	on A.aluCodigo=P.aluCodigo
	where [aluDni]  like '%'+ @dni+ '%'
	end
	exec SpBuscarpagoporDniAlum 71133442
	go
	select * from Alumno
	go

	---consultar Programas 

	create  proc  SpConsultaprogramas
	as
	begin
	select [codPrograma] as [Codigo Programa],Descripcion AS Descripción,costoPrograma AS[Costo Programa] from Programa
	end
	exec SpConsultaprogramas
	go
	--============================
	--conulstar Alumnos
	create  procedure SpConsultAlumnos
	as
	begin
	select  [aluCodigo]as Codigo,[aluDni]as Dni,[aluApellidos]as Apellidos,[aluNombres]as Nombres,[aluGenero] as Genero
 ,[aluCelular]as [Nº Celular],[aluEmail]as Email,[aluDireccion]as Dirección,[aluFechaNac] as [Fecha Nacimiento],
 [aluPais]as Pais,[Departamento],[Distrito],[codPrograma]as[Codigo Programa] from Alumno
	end
	exec SpConsultAlumnos
	  go

	   --procedimiento  para mostar notas por id
	   create proc SPmostrarNotasporId
	   @id char(9)
	   as
	   begin
       select C.[codCurso]as[Codigo Curso],C.[CurNomcurso]as [Nombre Curso],N.[Unid_1]as[Unid 1],N.Unid_2 as[Unid 2],
	   N.Unid_3 as[Unid 3],N.Unid_4 as [Unid 4],N.Unid_5 as [Unid 5]
	   from Curso C inner join Notas N 
	   on(N.codCurso=C.codCurso)
	   WHERE [aluCodigo]=@id
	   end
	   exec SPmostrarNotasporId 'C2019345'
	   select * from Notas
	   select * from Curso
	   select * from Alumno
	   go

	---procedimiento almacenado por mostrar notas por dni

	/*
	create  procedure SpConsultNotaporDniAlum
	@Dni char(8)
	as
	begin
	select (A.aluApellidos+' '+ A.aluNombres)as [Apellidos y Nombre] ,
	C.[CurNomcurso] as[Nombre  Cursos],N.[Unid_1]as[Unid 1],N.Unid_2 as[Unid 2],
	   N.Unid_3 as[Unid 3],N.Unid_4 as [Unid 4],N.Unid_5 as [Unid 5]
	from Curso C inner join Notas N
	on N.codCurso=C.codCurso inner join Alumno A
	on A.aluCodigo=N.aluCodigo
	where [aluDni]  like '%'+ @Dni+ '%'
	end
	exec SpConsultNotaporDniAlum   18142449 
	go 
	select * from Notas
	select * from Alumno
	*/
	--//procedimiento almacenado
	go
	create proc SPConsultarMatricula
	as
	begin
	select M.[codMatricula],M.[tipoMatricula],M.[periodo],M.[fechaInicio],AL.aluCodigo, Al.[aluApellidos],AL.[aluNombres],P.[codPrograma],
	P.[Descripcion],H.[codHorario],H.[horaInicion],H.[horaFin] from [dbo].[Matricula] M inner join [dbo].[Alumno] Al
	on al.aluCodigo=M.CodAlumno inner join [dbo].[Horario] H
	on H.codHorario=M.codHorario inner join [dbo].[Programa] P
	on p.codPrograma=M.codPrograma
	end
	exec SPConsultarMatricula
	select * from Matricula
	go

 --create procedimiento  registar Matricula 
 create proc spRegistarMatricula
 @codMatri char(9),
 @tipoMatricula varchar(20),
 @codAlumno char(9),
 @codPrograma char(9),
 @codHorario char(9),
 @periodo nvarchar(20),
 @fecha date
 as
 begin
 insert into Matricula values(@codMatri,@tipoMatricula,@codAlumno,
 @codPrograma,@codHorario,@periodo,@fecha)
 end
 go
 exec spRegistarMatricula 202006,'presencial','C2019345',2019001,1,'2020III','12/10/2020'
  select * from Matricula
  GO

  --PROCEDIMIENTO ALMACENADO QUE ACTUALIZA MATRICULA 
  create proc SpActualizarMatricula
   @codMatri char(9),
 @tipoMatricula varchar(20),
 @codAlumno char(9),
 @codPrograma char(9),
 @codHorario char(9),
 @periodo nvarchar(20),
 @fecha date
  as
  begin
  update Matricula
  set [codMatricula]=@codMatri,[tipoMatricula]=@tipoMatricula,[CodAlumno]=@codAlumno,
  [codPrograma]=@codPrograma,[codHorario]=@codHorario,[periodo]=@periodo,[Fecha]=@fecha
  where [codMatricula]=@codMatri
  end
  
   exec SpActualizarMatricula 202006,'Presencial','C2019345',2019001,1,'2020III','12/10/2020'
  select * from Matricula
  select * from Alumno
  go
  --PROCEDIMIENTO ALMACENADO PARA ELIMINAR MATRICULA
  create proc SpEliminaMatricula
  @codigoMatricula char(9)
  as
  begin
  	delete from Matricula
	where [codMatricula]=@codigoMatricula
  end

  exec SpEliminaMatricula  2019349
  select * from Matricula
  go 

  ---create procedimenito almacenado para hacer una busqueda
 
  create proc SpBuscarCodMatricula
    @codiMat char(9)
  as
  begin
  select[codMatricula],[tipoMatricula],[CodAlumno],[codPrograma],
  [codHorario],[periodo],[fechaInicio]from Matricula
  where codMatricula = @codiMat
  end

  exec SpBuscarCodMatricula 202001
  go 

  --procedimiento almacenado   para buscar  por el codigo el tipo de alumno
  --**
 create proc SPMatricula
 @codMatricula char(9)
 as
 begin
 select M.[tipoMatricula],Al.[aluCodigo],Al.[aluApellidos]as Apellidos,Al.[aluNombres]as Nombres,P.[codPrograma],P.[Descripcion],
 H.[codHorario],H.[horaInicion],H.[horaFin] from Matricula M inner join [dbo].[Horario] H 
 on H.codHorario=M.codHorario inner join [dbo].[Programa] P
 on p.codPrograma=M.codPrograma inner join [dbo].[Alumno] Al
 on Al.aluCodigo=M.CodAlumno 
 where [codMatricula]=@codMatricula
 end
 go 
 exec SPMatricula  202001
 select * from Matricula
 --procedimiento para agregar registros
 go
 CREATE PROC spRegistarAlmunos
 @cod char(9),@dni char(8),
 @apellidos varchar(30),@nombre varchar(30),
 @Genero    char(1),@Celular  char(9),
 @Email     char(35),@Direccion varchar(45),
 @fechNac   Date,@pais varchar(20),
 @Depart varchar(20),@Distrito   varchar(20),
 @codprograma char(9)
 as 
 begin 
 insert into Alumno
 values(@cod,@dni,@apellidos,@nombre,@Genero,@Celular,@Email,@Direccion,@fechNac,@pais,
 @Depart,@Distrito,@codprograma
 )
 end 
 go 
 exec spRegistarAlmunos 'C4019211',73456771,'Barreto Castillo','Diunicio','M',987654324,'Diunic@gmail.com','av.Espeña 440','20-07-2018','Peru','La lbertad','Trujillo',2019001;
go 
select * from Alumno
select * from Programa
go
--procedimiento ACTUALIZAR ALUMNO
 CREATE PROC spActualizarAlmuno
 @cod char(9),@dni char(8),
 @apellidos varchar(30),@nombre varchar(30),
 @Genero    char(1),@Celular  char(9),
 @Email     char(35),@Direccion varchar(45),
 @fechNac   Date,@pais varchar(20),
 @Depart varchar(20),@Distrito   varchar(20),
 @codprograma char(9)
 as 
 begin 
 update Alumno
 set [aluCodigo]=@cod, aluDni=@dni,[aluApellidos]=@apellidos,
 [aluNombres]=@nombre,[aluGenero]=@Genero,[aluCelular]=@Celular,
 [aluEmail]=@Email, [aluDireccion]=@Direccion, [aluFechaNac]=@fechNac,[aluPais]=@pais,[Departamento]=@Depart,
 [Distrito]=@Distrito,[codPrograma]=@codprograma
 where [aluCodigo]=@cod
 end 
 go 
 
 --para actulizar se hace sobre un registro ya registrado  y se modifica todo menos el codigo 
  exec spActualizarAlmuno'C4019211',73456771,'Barreto Carvajal','Diunicio','M',987654324,'Diunic@gmail.com','av.Espeña 440','20-07-2018','Peru','La lbertad','Porvenir',2019001;
 go


   exec spActualizarAlmuno 12312,18142449,' Sanchez Espinola','Nancy','F',987654324,'Nanci@gmail.com','av.Espeña 440','20-07-2018','Peru','La lbertad','Porvenir',2019001;
 go
 select * from Alumno
 go
 --procedimiento para eliminar alumno
 go
 create proc spEliminarAlumno
 @cod char(9)
 as 
 begin 
 delete from Alumno where aluCodigo=@cod
 end 
 go 
 exec spEliminarAlumno 'C4019211'  
 select * from Alumno
 go
 --procedimiento almcenado  para busar alumno por  el apellido
 
 create proc spBuscarporApellido
 @Apellidos varchar(30)
 as
 begin
 select  * from Alumno
 where  [aluApellidos]like @Apellidos + '%'
 end
 go 
 exec spBuscarporApellido 'c'

 go
 select * from Curso
 go
 --procedimiento busqueda por codigo 
 create proc spBuscarAlumnoporCodigo
 @AluCodigo char(9)
 as
 begin
 select  * from Alumno
 where [aluCodigo] =@AluCodigo
 end
 
 exec spBuscarAlumnoporCodigo 'c345556'
 go
 
 --SP que muestre la información de la tabla tbAlumnos ordenado por el Apellido paterno de forma ascendente.
 
 create proc sp_ListarTodosAlumnos
 as
 begin
 select * from Alumno
 order by [aluApellidos]  asc
 end
 go 
 exec sp_ListarTodosAlumnos
 go
 /********************************************/
 create proc spInsertarReg_Almuno
 @cod char(9),@dni char(8),
 @apellidos varchar(30),@nombre varchar(30),
 @Genero    char(1),@Celular  char(9),
 @Email     char(35),@Direccion varchar(45),
 @fechNac   Date,@pais varchar(20),
 @Depart varchar(20),@Distrito   varchar(20),
 @codprograma char(9)
 as 
 if exists(select [aluCodigo] from Alumno where [aluCodigo]=@cod)
 raiserror('ya existe un usurio con ese codigo',16,1)
 else
 insert into Alumno
 values(@cod,@dni,@apellidos,@nombre,@Genero,@Celular,@Email,@Direccion,@fechNac,@pais,
 @Depart,@Distrito,@codprograma)
  go
 exec  spInsertarReg_Almuno 'C3019211',73456771,'Barreto Castillo','Diunicio','M',987654324,'Diunic@gmail.com','av.Espeña 440','20-07-2018','Peru','La lbertad','Trujillo',2019001;

 select * from Alumno
 go
 