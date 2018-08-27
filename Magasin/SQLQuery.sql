create database Magasin_M4;

create table Bloc (nom varchar (6) primary key);

create table Cassier (nom varchar(30) primary key , nomBloc varchar(6));

create table Materiel( ref varchar(15) primary key , description varchar(100) , prix float , quantite float , lien varchar(500) , nomFab varchar(20));

create table Fabricant (nom varchar(20) primary key);

alter table Cassier add constraint c1 foreign key(nomBloc) references Bloc(nom);

alter table Materiel add constraint c2 foreign key (nomFab) references Fabricant(nom);

alter table Materiel add constraint c3 check ((prix>=0) or (prix=null));
alter table Materiel drop constraint c3 ;

alter table Materiel add constraint c4 check ((quantite>=0) or (prix=null));
alter table Materiel drop constraint c4 ;


insert into Bloc values ('Bloc A');
insert into Bloc values ('Bloc B');
insert into Bloc values ('Bloc C');
insert into Bloc values ('Bloc D');
insert into Bloc values ('Bloc E');
insert into Bloc values ('Bloc F');
insert into Bloc values ('Bloc G');	
insert into Bloc values ('Bloc H');
insert into Bloc values ('Bloc I');
insert into Bloc values ('Bloc J');
insert into Bloc values ('Bloc K');
insert into Bloc values ('Bloc L');
insert into Bloc values ('Bloc M');
insert into Bloc values ('Bloc N');
insert into Bloc values ('Bloc O');

insert into Cassier values ('B3H Nappes','Bloc B');
insert into Cassier values ('B2B Gain ','Bloc B');

insert into Cassier values('C3H Connecteurs Jaieger','Bloc C');

insert into Cassier values ('D3B Connecteurs sub D','Bloc D');
insert into Cassier	values ('D2H Face avant et accessoires','Bloc D');


insert into Cassier	values ('E3H  Connecteurs c -Grid','Bloc E');
insert into Cassier	values ('E1 Cables électriques ','Bloc E');

insert into Cassier values ('F3H Composant','Bloc F');
insert into Cassier values ('F3B led/ voyant fusible','Bloc F');
insert into Cassier values ('F2B rack alimentation','Bloc F');

insert into Cassier values('G3B composant transistor ci','Bloc G');

insert into Cassier values('H3B cosse et embout','Bloc H');
insert into Cassier values('H2B relais','Bloc H');

insert into Cassier values('I3B FIL Multibrin','Bloc I');

insert into Cassier values('J4 Cordon banane et sonde','Bloc J');
insert into Cassier values('J2B composant Brandt I8','Bloc J');

insert into Cassier values('O1 Cables DVI','Bloc O');

Alter table Materiel add  nomCasier varchar(30);

Alter table Materiel add constraint c5 foreign key(nomCasier) references Cassier(nom); 

insert into Fabricant values('Amphenol');
insert into Fabricant values('RS Pro');
insert into Fabricant values('TE Connectivity');
insert into Fabricant values('3M');
insert into Fabricant values('HellermannTyton');
insert into Fabricant values('Jaeger');
insert into Fabricant values('Harting');
insert into Fabricant values('Molex');
insert into Fabricant values('ITT Cannon');
insert into Fabricant values('Amphenol FCI');
insert into Fabricant values('ASSMANN WSW');
insert into Fabricant values('Bulgin');

select * from Fabricant;
select * from Cassier;
select * from Materiel;
update Fabricant set nom='RS Pro' where nom=' RS Pro';


select * from Fabricant;


select * from Materiel;

insert into Materiel values ('708-2037','50 voies, larg. 31,75 mm, 30 AWG, pas de 0.635mm, Gris, 30m',186.65,5,'https://media.rs-online.com/t_thumb100/R7082024-01.jpg','Amphenol','B3H Nappes');

insert into Materiel values ('289-9896','20 voies, larg. 25,4 mm, 28 AWG, pas de 1.27mm, Gris, 5m',186.65,5,'https://media.rs-online.com/t_thumb100/F2899896-01.jpg',' RS Pro','B3H Nappes');

update Materiel set prix='8.60'

insert into Materiel values ('aa','20 voies, larg. 25,4 mm, 28 AWG, pas de 1.27mm, Gris, 5m','186,65','5','https://media.rs-online.com/t_thumb100/F2899896-01.jpg',' RS Pro','B3H Nappes');

delete Materiel where ref='105-5017';

update Materiel set nomCasier='C3H Connecteurs Jaieger' where ref='307-9699';

select * from Materiel where ref='251-661';