using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBus.Data
{
    public static class GTFS
    {
        public static string Stops =
@"b36d06f7-6513-4a3d-ab1f-02d4c2a4fea6,BUS120,""Lafayette 7 Theater in Laf Marketplace"",""Lafayette 7 Theater in Laf Marketplace - BUS120"",40.401898,-86.851619,0
e6464035-9c3e-4b96-935d-7539d81d5779,BUS667,""PetSmart in Lafayette Marketplace"",""PetSmart in Lafayette Marketplace - BUS667"",40.400299,-86.852841,0
21afc580-cd45-4e58-9378-906a6f825f89,BUS578,""3rd St & South St (SW Corner)"",""3rd St & South St (SW Corner) - BUS578"",40.4172323892851,-86.8943813082207,0
4bd0ce8e-f4b3-481f-b74c-03b796183407,BUS673,""Dicks at Tippecanoe Mall"",""Dicks at Tippecanoe Mall - BUS673"",40.392557,-86.849441,0
4720bbbb-e8bf-4d36-8472-df293647d2d8,BUS672,""Wendy's at Tippecanoe Mall"",""Wendy's at Tippecanoe Mall - BUS672"",40.393497,-86.848908,0
5446b8a5-38e4-4df7-bdfb-84446a59cbc3,BUS661,""(West of) McGrath Ave & South St"",""(West of) McGrath Ave & South St - BUS661"",40.4173128555603,-86.8837141623327,0
95d83589-ec53-4bf9-9350-b854ea4c4fb0,BUS215,""Depot/Riehle Plaza/Downtown Transfer Center"",""Depot/Riehle Plaza/Downtown Transfer Center - BUS215"",40.4196825873663,-86.8959383306466,0
a946cf70-90a9-4c03-b32b-9d78289e09f6,BUS206,""14th St & South St (SW Corner)"",""14th St & South St (SW Corner) - BUS206"",40.4173343132337,-86.8818580735837,0
6f83be07-38fe-48aa-aa55-3b61add667cd,BUS421SW,""Kingsway Dr & SR 25/38 (SW Corner)"",""(North of) Kingsway Dr & SR 25/38 - BUS421"",40.3940902885252,-86.8486187963854,0
85562c58-fad4-43ce-8d17-907e6a74ae0e,BUS298,""(East of) US 52 & McCarty Ln"",""(East of) US 52 & McCarty Ln - BUS298"",40.4027725996239,-86.8560847256234,0
19730d90-0257-40fe-a38d-cedeab032201,BUS668,""Kmart in Lafayette Marketplace"",""Kmart in Lafayette Marketplace - BUS668"",40.399664,-86.851861,0
c1613230-dbbc-453d-b5a1-cd7a8b5f087b,BUS659,""(West of) 10th St & South St"",""(West of) 10th St & South St - BUS659"",40.4172873745732,-86.886183135878,0
5cb32f6d-9d6f-4ea3-941f-243b1121d9e6,BUS531SW,""Earl Ave & Main St (SW Corner)"",""Earl Ave & Main St (SW Corner) - BUS531SW"",40.4048379006885,-86.8635157861421,0
c816c67d-0774-48ba-bb31-6bd5a7ec1a57,BUS482NW,""Scott St & Main St (NW)"",""Scott St & Main St (NW) - BUS482NW"",40.4138648756662,-86.8750559911165,0
dd9f64b4-df18-4cf7-85e7-8339e15b4ba3,BUS666,""(West of) US 52 & McCarty Ln"",""(West of) US 52 & McCarty Ln - BUS666"",40.4027632118918,-86.8588675176422,0
5fcec367-4992-4278-889c-e3565caa3443,BUS939,""16th St & South St (SW Corner)"",""16th St & South St (SW Corner) - BUS939"",40.417138511964,-86.8785442041483,0
c721ca64-c1fb-43a4-8d80-f43105ec0b14,BUS265,""4th St & South St (SW Corner)"",""4th St & South St (SW Corner) - BUS265"",40.4172578702723,-86.8933057423416,0
9179980d-b50b-415d-9c7e-e1ef8e11b963,BUS664SE,""(Southeast of) 28th St & Main St"",""(Southeast of) 28th St & Main St - BUS664SE"",40.4059255365089,-86.8650580564176,0
ce9a371a-372d-40e2-ac08-bd2712a78d2d,BUS948,""Professional Ct & SR 25/38 (SW Corner)"",""Professional Ct & SR 25/38 (SW Corner) - BUS948"",40.3949217733694,-86.8495159953544,0
2b479ac3-86a4-43e3-991f-1047bdbc0ef5,BUS141,""SR 25/38 @ Shoe Carnival"",""SR 25/38 @ Shoe Carnival - BUS141"",40.3969951210615,-86.8528848500779,0
b6c3461d-8d07-41a3-b592-95d9eaf6ff1a,BUS329,""5th St & South St (SW Corner)"",""5th St & South St (SW Corner) - BUS329"",40.417261893586,-86.8920182819377,0
acd09bf6-78a6-480c-929a-e569ed5b4ed5,BUS373,""Tippecanoe Mall Entrance E"",""Tippecanoe Mall Entrance E - BUS373"",40.391557,-86.849444,0
5f4d852c-e3a6-4986-80c5-a54717997fe4,BUS216W,""(West of) 24th St & Main St"",""(West of) 24th St & Main St - BUS216W"",40.4094513004691,-86.8701421839084,0
bb44c63c-cd33-4ebf-843f-6ffb89c48092,BUS947,""(North of) Main St & Congress St"",""(North of) Main St & Congress St - BUS947"",40.4114079720621,-86.8723187966537,0
20b8f9f0-4b59-465d-996a-ad7ab46119ac,BUS391NW,""Alabama St & Main St (NW Corner)"",""Alabama St & Main St (NW Corner) - BUS391NW"",40.4164840529253,-86.8778428064491,0
8adddae9-20f4-40d7-af36-7f15786abf5a,BUS351,""Tippecanoe Co Public Library on South St"",""Tippecanoe Co Public Library on South St - BUS351"",40.4172645757952,-86.8894339733978,0
32dfbc8e-8a40-42c7-8878-9704e70ffeb7,BUS444SW,""Jackson St & Main St (SW Corner)"",""Jackson St & Main St (SW Corner) - BUS444SW"",40.4151992747306,-86.8764735386654,0
2aae1bda-4d10-4cf7-94f0-5288fe81959e,BUS663SE,""(Southeast) 25th St & Main St"",""(Southeast) 25th St & Main St - BUS663SE"",40.4075455908504,-86.8672963599739,0
5bfba875-739c-4dfe-bb35-f0c803edc5a5,BUS675,""5th St & Columbia St (NE Corner)"",""5th St & Columbia St (NE Corner) - BUS675"",40.4183106373734,-86.8917621309615,0
eb40fc85-81fa-4883-8017-ebcfa5cefc65,BUS528,""King St & 9th St & (SE Corner)"",""King St & 9th St & (SE Corner) - BUS528"",40.4044154527435,-86.8861321739037,0
40aafda6-d676-4336-9ef2-c3bd8679fb2c,BUS807E,""(North of) Manitou Dr & 18th St (East)"",""(North of) Manitou Dr & 18th St - BUS807E"",40.3855394056761,-86.8758874759607,0
7e6bf644-7dc3-49ac-90fb-64b0deb4b0cd,BUS990,""18th St at RRX (at Trailhead)"",""18th St at RRX (at Trailhead) - BUS990"",40.3790149318585,-86.8758418784047,0
785430a5-50b9-4c2f-84fa-60804c4f6dbd,BUS881,""(West of) IFCU Dr & Veterans Mem Pkwy S"",""(West of) IFCU Dr & Veterans Mem Pkwy S - BUS881"",40.3674009661318,-86.8686294179338,0
14c85a6c-def3-435a-8387-6075eba0c8f7,BUS682N,""(West Drive) Edgelea School on Beck Ln (North)"",""(West Drive) Edgelea School on Beck Ln - BUS682N"",40.3883007400215,-86.8793435024824,0
2a0e21b6-9d85-4225-869c-3b1df7f6579f,BUS875NE,""Regal Valley Dr & Veterans Mem Pkwy S"",""Regal Valley Dr & Veterans Mem Pkwy S - BUS875NE"",40.3673848728767,-86.870903931314,0
cd1d6a33-d442-4820-b530-aa2aff9db8f1,BUS327NE,""El Prado Ave & Logan Ave (NE Corner)"",""El Prado Ave & Logan Ave (NE Corner) - BUS327NE"",40.4027229787542,-86.8792268263833,0
aeb97b57-b7d8-46f9-8ad5-c414919b2f7f,BUS918,""Payne Luxury Apts on 18th"",""Payne Luxury Apts on 18th - BUS918"",40.4139440008368,-86.88642051139,0
5d044a02-9535-47b8-957b-80e9bd65429d,BUS544NE,""14th St & Logan Ave (NE Corner)"",""14th St & Logan Ave (NE Corner) - BUS544NE"",40.4026854278258,-86.8811110783286,0
34407126-3258-4a5d-a4e6-a8310fb33be8,BUS697,""Central Ave & 9th St (SE Corner)"",""Central Ave & 9th St (SE Corner) - BUS697"",40.4062541071328,-86.886244826689,0
3ffcdbd3-6f18-4ecb-88e9-d6e165f5dc14,BUS502,""Art Museum on 9th St"",""Art Museum on 9th St - BUS502"",40.4163030038061,-86.8865170709203,0
285a822d-4eb9-4459-bc7f-5d3cd462ad5c,BUS494S,""Fairgrounds on Teal Rd (SW Corner)"",""Fairgrounds on Teal Rd (SW Corner) - BUS494S"",40.3950464960961,-86.8812022734405,0
a58b06ca-dcfb-457f-9a1b-b42af68c29bb,BUS253S,""(South of) Kossuth St & 9th St"",""(South of) Kossuth St & 9th St - BUS253S"",40.4095599299407,-86.8863601616836,0
2db0415c-8cab-4dfd-95f5-a63faae00c50,BUS241,""(East of) 9th St & Logan Ave"",""(East of) 9th St & Logan Ave - BUS241"",40.4026612879432,-86.8857727578743,0
ad0ebd6d-8a11-4d8b-a7b5-5a476ae56236,BUS986N,""(West of) 18th St & Logan Ave"",""(West of) 18th St & Logan Ave - BUS986N"",40.4027873517744,-86.8770850823572,0
6de246d5-1c46-420a-8145-1b9b4eeb09a8,BUS916,""(West of) Braddock Dr & Veterans Mem Pkwy S"",""(West of) Braddock Dr & Veterans Mem Pkwy S-BUS916"",40.3673446397391,-86.8741775676118,0
47a0ab15-9c06-4a71-88a6-2ca52bb4751d,BUS198E,""(North of) JR Hiatt Dr & 18th St"",""(North of) JR Hiatt Dr & 18th St - BUS198E"",40.3977219997479,-86.8762415275718,0
217658fd-6572-4a6b-a567-f5353b4e40b7,BUS865SE,""Eastway St & 18th St (SE Corner)"",""Eastway St & 18th St (SE Corner) - BUS865SE"",40.3831804027069,-86.8758660182873,0
70f1aba3-e666-4a3a-bf4b-1c7c05d565e1,BUS889SE,""Marcastle Dr & Concord Rd (SE Corner)"",""Marcastle Dr & Concord Rd (SE Corner) - BUS889SE"",40.3595568454001,-86.8567901466364,0
c52b6c3f-3ee8-4a02-a248-72816fffa9ac,BUS884,""Summertime Tr & 18th St (SE Corner)"",""Summertime Tr & 18th St (SE Corner) - BUS884"",40.3741950019714,-86.8756930157955,0
3fe35c23-1afc-4e2b-bd46-74aa4af17ebd,BUS888NE,""Doten Dr & Chilton Dr (NE Corner)"",""Doten Dr & Chilton Dr (NE Corner) - BUS888NE"",40.358718655033,-86.8558352801702,0
db25dc60-b85b-4965-8e64-0ba699e079ea,BUS514S,""Crestview Ct & Teal Rd (SW Corner)"",""Crestview Ct & Teal Rd (SW Corner) - BUS514S"",40.3950625893511,-86.8846582999622,0
6328210b-ab63-44ad-ab54-6f33344e5a17,BUS537N,""9th St & Beck Ln (NE Corner)"",""9th St & Beck Ln (NE Corner) - BUS537N"",40.3883235387995,-86.8854079774265,0
0995aa7b-03f0-4eb1-b1d1-4aa1dd766d54,BUS297,""Edgelea Dr & Teal Rd (SW Corner)"",""Edgelea Dr & Teal Rd (SW Corner) - BUS297"",40.395176583241,-86.8789787220346,0
49b0a984-bd79-47cd-b780-655a2e6aa1a9,BUS248,""4th St & Columbia St (NE Corner)"",""4th St & Columbia St (NE Corner) - BUS248"",40.418259675399,-86.8930415447379,0
fc591bec-e0f3-4d7c-941b-6b0f6f529e83,BUS679E,""Bishop Woods on 9th St (East Side)"",""Bishop Woods on 9th St (East Side) - BUS679E"",40.3896995121062,-86.8854294350999,0
4e6f0be3-5e04-48e8-b826-cf23079d32be,BUS354N,""(North of) Brady Ln & 18th St"",""(North of) Brady Ln & 18th St - BUS354N"",40.3820900846773,-86.8759625778176,0
136d0e1d-5124-4602-89ce-768840c49687,BUS887,""(Roundabout) Chilton Park on Chilton Dr"",""(Roundabout) Chilton Park on Chilton Dr - BUS887"",40.358605,-86.853482,0
c4eac7c3-76fe-4971-8a4c-bb28ea7266ee,BUS243N,""7th St & Columbia St (NE Corner)"",""7th St & Columbia St (NE Corner) - BUS243N"",40.418328071733,-86.8885367744289,0
43bd886a-d39f-4a6b-92c5-852f8c92f934,BUS917,""(North of) Troxel Ct & 18th St"",""(North of) Troxel Ct & 18th St - BUS917"",40.3681908767337,-86.8757547066066,0
a944766c-f25c-44b1-9678-68ba86a29ba0,BUS279,""State St & 9th St (SE Corner)"",""State St & 9th St (SE Corner) - BUS279"",40.4126417882825,-86.8863762549386,0
e0817673-6cfc-4234-b2ae-143e6672633f,BUS883,""Bridgewater Cir & 18th St (SE Corner)"",""Bridgewater Cir & 18th St (SE Corner) - BUS883"",40.3707081300442,-86.8757453188744,0
63bbba44-b7b7-4466-a310-f3d6dbb6e04e,BUS674,""6th St & Columbia St (NE Corner)"",""6th St & Columbia St (NE Corner) - BUS674"",40.4183146606871,-86.8905551368329,0
e75a06a3-d9c8-46b7-a254-9318e74ec1c9,BUS890,""Walmart on Concord Rd (SE Corner)"",""Walmart on Concord Rd (SE Corner) - BUS890"",40.3646449962047,-86.8569242570951,0
794c0c79-dd1d-4431-b331-de8e8cd3ca41,BUS693E,""Sarasota Dr & 9th St (SE Corner)"",""Sarasota Dr & 9th St (SE Corner) - BUS693E"",40.3930831189801,-86.8855903676504,0
f4473a46-f0ad-4820-9cdc-28782ec7fef7,BUS891,""(West of) Cougill & Veterans Mem Pkwy S"",""(West of) Cougill & Veterans Mem Pkwy S - BUS891"",40.3673888961904,-86.8610106027729,0
d295cebc-b04f-46ea-9557-d98937b171a3,BUS880,""(West of) Cheryl Ln & Veterans Mem Pkwy S"",""(West of) Cheryl Ln & Veterans Mem Pkwy S - BUS880"",40.3673728029354,-86.8655073264544,0
3655c9e4-1cb9-47f2-ad86-360646500879,BUS870SE,""Southaven Blvd & 18th St (SE Corner)"",""Southaven Blvd & 18th St (SE Corner) - BUS870SE"",40.3768182025443,-86.8757989630579,0
1840e6fe-b7b8-4718-b1c9-2048a48f913c,BUS521NE,""Davis Dr & Beck Ln (NE Corner)"",""Davis Dr & Beck Ln (NE Corner) - BUS521NE"",40.3882605068839,-86.8813725937231,0
8dae9bd5-a823-4d9f-a756-6f2bb29879af,BUS158,""South St & Main St (SE Corner)"",""South St & Main St (SE Corner) - BUS158"",40.4173209021879,-86.8785254286841,0
b1d75203-8055-46f4-9aa6-e6c9d39391a3,BUS191,""Frozen Custard on Main St (at Shelter)"",""Frozen Custard on Main St (at Shelter) - BUS191"",40.4110740370199,-86.8713733179196,0
ae524ae8-cd9b-42f7-8dee-957d12d7b849,BUS677,""(North of) Kingsway Dr & SR 25/38"",""(North of) Kingsway Dr & SR 25/38 - BUS677"",40.3945663806538,-86.8488293498057,0
e85ddd73-4eea-4435-9504-6eec9c04ce92,BUS305,""14th St & Columbia St (NE Corner)"",""14th St & Columbia St (NE Corner) - BUS305"",40.4183481883018,-86.8811741102442,0
1eb0de1a-f9fc-4999-b070-aac686e6d916,BUS663NE,""25th St & Main St (NE Corner)"",""25th St & Main St (NE Corner) - BUS663NE"",40.4080350940248,-86.8677053968731,0
6d111610-6de2-44a6-a12a-ec63c6dd42bb,BUS462,""SR25/38 @ Hollywood Video (Laf Marketplace)"",""SR25/38 @ Hollywood Video (Laf Marketplace) - BUS462"",40.3972767530249,-86.852263918654,0
c6017faf-2c96-4777-87a6-e874c7e58394,BUS216E,""(Northeast of) 24th St & Main St"",""(Northeast of) 24th St & Main St - BUS216E"",40.4095156734893,-86.8695038181248,0
00ed5a07-e9c0-499e-a722-51b56ce28640,BUS408,""(Northeast of) 21st St & Main St"",""(Northeast of) 21st St & Main St - BUS408"",40.4124003894568,-86.8728445096519,0
70abde15-2700-40bc-bf22-57bbf1ce50ed,BUS678,""Main @ House of Saigon (NE Corner)"",""Main @ House of Saigon (NE Corner) - BUS678"",40.4015334189852,-86.8585161482404,0
889a1c5a-b780-4c1f-b09c-d2be171d6302,BUS391NE,""Alabama St & Main St (NE Corner)"",""Alabama St & Main St (NE Corner) - BUS391NE"",40.4165940235015,-86.8776228652968,0
69950ca7-a16c-4424-b7d4-f29b99ce5a63,BUS676,""Sears at Tippecanoe Mall"",""Sears at Tippecanoe Mall - BUS676"",40.391797,-86.848495,0
c557c252-6e2e-4736-9087-cac110797119,BUS482SE,""Scott St & Main St (Southeast Corner)"",""Scott St & Main St (Southeast Corner) - BUS482SE"",40.4136945553836,-86.8742942437109,0
c5afa191-adc1-4387-8a5b-ebcbca21cc47,BUS242,""9th St & Columbia St (NE Corner)"",""9th St & Columbia St (NE Corner) - BUS242"",40.4183186840009,-86.8866940967258,0
b2ff3c5c-0b08-4ede-beec-a87801db73bd,BUS506,""(Southeast of) McCarty Ln & Main St"",""(Southeast of) McCarty Ln & Main St - BUS506"",40.4027109088129,-86.8602609253085,0
d5d2384d-589c-4448-bde6-309da0b15b63,BUS444NE,""(North of) Jackson St & Main St"",""(North of) Jackson St & Main St - BUS444NE"",40.4156552502903,-86.8765070662801,0
658f2e19-e7b1-486c-8971-2cd23ec167b1,BUS309,""12th St & Columbia St (NE Corner)"",""12th St & Columbia St (NE Corner) - BUS309"",40.4183629404523,-86.8837999930263,0
cc677652-b057-4cf9-a253-8c94b61b2f14,BUS664NE,""(Northeast of) 28th St & Main St"",""(Northeast of) 28th St & Main St - BUS664NE"",40.4064941648539,-86.8655958393571,0
5093c99a-6346-4cc7-aeee-f829a666d999,BUS946,""SR 25/38 @ Golden Lion"",""SR 25/38 @ Golden Lion - BUS946"",40.3997121989555,-86.8557440850582,0
d7d795be-b7bd-482c-9d2c-a7f0cc64b833,BUS531NE,""(Northeast of) Earl Ave & Main St"",""(Northeast of) Earl Ave & Main St - BUS531NE"",40.4051584246849,-86.8636633076467,0
86bee514-6f04-4d15-a1e7-638b601e65e3,BUS395SE,""Owen St & 4th St (SE Corner)"",""Owen St & 4th St (SE Corner) - BUS395SE"",40.4049961510298,-86.8927237029507,0
7968dbf0-3855-4a4c-b732-417695176c60,BUS237,""Pay Less on Old US 231 S (at Shelter)"",""Pay Less on Old US 231 S (at Shelter) - BUS237"",40.385567,-86.904553,0
d60cacfe-8f3e-4427-ac9b-58879f0803dc,BUS653SW,""Windy Hill Dr & Old US 231S (SW Corner)"",""Windy Hill Dr & Old US 231S (SW Corner) - BUS653SW"",40.3941586848592,-86.9002969205556,0
e4ff481f-4b78-4544-8e4a-05179fd56fc2,BUS109,""(North of) Romig St & 4th St"",""(North of) Romig St & 4th St - BUS109"",40.4140512892038,-86.8927840526571,0
07fe7eff-398c-42f1-bad3-d4e72fce26dc,BUS228,""(North of) Beck Ln & Old US 231 S"",""(North of) Beck Ln & Old US 231 S - BUS228"",40.3886065118674,-86.9043805840242,0
e7767c82-6447-4c8d-b83e-6a6238416f23,BUS148,""Thise Ct & 4th St (SE Corner)"",""Thise Ct & 4th St (SE Corner) - BUS148"",40.3989048539939,-86.8939052160922,0
7e653c6d-e93f-4ed0-b7e2-6e4eff1e5c56,BUS121SE,""Murphy St & 4th St (SE Corner)"",""Murphy St & 4th St (SE Corner) - BUS121SE"",40.4032580794846,-86.8927840526571,0
8bfc8bc1-9681-46ae-8059-e4e732a4f726,BUS652E,""Saw Mill Dr & 4th St (SE Corner)"",""Saw Mill Dr & 4th St (SE Corner) - BUS652E"",40.3978467224745,-86.8944684800189,0
05e2980a-03b2-41ad-a6c5-e2887939050d,BUS264E,""(North of) Montefiore & 4th St"",""(North of) Montefiore & 4th St - BUS264E"",40.4016125441559,-86.8928269680039,0
fd319f1d-b8aa-476d-b03a-cc5301912bb3,BUS910,""Valley Plaza on 4th St (South Driveway)"",""Valley Plaza on 4th St (South Driveway) - BUS910"",40.3961220619751,-86.895290577131,0
7934821d-5d72-41ee-b7b0-5c39eaab9609,BUS199,""(North of) SR 25 & Old US 231S"",""(North of) SR 25 & Old US 231S - BUS199"",40.3903365367852,-86.9039111974186,0
b7bef13b-216d-40c5-9410-263a804c210f,BUS197,""Village Pantry on 4th St"",""Village Pantry on 4th St - BUS197"",40.40642576852,-86.8926606710351,0
4ccbb634-765b-4c43-8105-2dce5bd598cd,BUS150,""Alabama & 4th St (SE Corner)"",""Alabama & 4th St (SE Corner) - BUS150"",40.4162976393877,-86.8928055103305,0
0b72d2b7-d76a-4d60-8ffc-c4fd8b423f94,BUS258,""(South of) Elston Rd & Old US 231 S"",""(South of) Elston Rd & Old US 231 S - BUS258"",40.3917634720662,-86.9031682254772,0
3f9dea12-472a-4bf8-ad3d-12bd487c7283,BUS907,""Taylor Transmission on Old US 231 S"",""Taylor Transmission on Old US 231 S - BUS907"",40.3952718016667,-86.8967094657844,0
0a38ea30-0e25-4e4f-aef7-5ad69849777b,BUS240,""(South of) Fairmont St & 4th St"",""(South of) Fairmont St & 4th St - BUS240"",40.4084508364469,-86.8926821287085,0
86c94b0b-1847-476f-aff9-320fab9c1262,BUS194,""Fountain St & 4th St (SE Corner)"",""Fountain St & 4th St (SE Corner) - BUS194"",40.412627036132,-86.8927639360883,0
6de644a1-4d2b-4d3e-a4b3-0c350cc911fc,BUS388,""(West of) Gates Rd & State St"",""(West of) Gates Rd & State St - BUS388"",40.4241256668643,-86.9233759893999,0
1a56569d-4ce5-4a2d-af81-3458dca87a87,BUS394,""SW Blackbird Farms Apt Buildings (W)"",""SW Blackbird Farms Apt Buildings (W) - BUS394"",40.4428059126619,-86.9426838721444,0
4bba3bdf-bfd3-462c-a561-c43b945bcee2,BUS403,""Walmart West Lafayette (at Shelter)"",""Walmart West Lafayette (at Shelter) - BUS403"",40.457538,-86.934027,0
8489dc15-134e-4783-89ba-b7d8ac32b45f,BUS135,""Northwestern Ave & Grant St (SE Corner)"",""Northwestern Ave & Grant St (SE Corner) - BUS135"",40.427721168263,-86.9103404528106,0
7f944f17-dff0-4f1e-ba8e-389214745fdc,BUS300,""McCormick Place Apts Lindberg (at Shelter)"",""McCormick Place Apts Lindberg (at Shelter) - BUS300"",40.4461023477377,-86.9435260858253,0
edab3fe9-2987-48e2-bc39-6af6211382ee,BUS375W,""(West of) Lindberg Rd & Northwestern Ave"",""(West of) Lindberg Rd & Northwestern Ave - BUS375W"",40.4460996655285,-86.9222736014291,0
04bd8f2b-2432-4d1b-870f-84c2dffeffd4,BUS922,""Christina & Co Cumberland Ave (SE Corner)"",""Christina & Co Cumberland Ave (SE Corner) - BUS922"",40.4598701274318,-86.9340042432549,0
386987f9-3773-4b88-8d94-b93e1e2bed7f,BUS162,""Neil Armstrong & Northwestern (NW Corner)"",""Neil Armstrong & Northwestern (NW Corner) - BUS162"",40.4518851907185,-86.9266415790702,0
71298f48-4a68-46f4-958b-1d2b28fec3d2,BUS205,""Kestral Blvd & Lindberg Rd (NE Corner)"",""Kestral Blvd & Lindberg Rd (NE Corner) - BUS205"",40.4460983244239,-86.9365054033104,0
535abbec-9af1-4796-acc1-d7ceb1790916,BUS345,""Lilly Hall on State St"",""Lilly Hall on State St - BUS345"",40.424049,-86.917222,0
f38d2674-3fea-4ae4-b637-913916a95d9e,BUS308,""Willowbrook Apts on Lindberg (at Shelter)"",""Willowbrook Apts on Lindberg (at Shelter) - BUS308"",40.4460983244239,-86.9401330912192,0
7f00b83f-7c2a-40ae-be36-80b9f4e3f2e6,BUS897,""(South of) Windsor Dr & Northwestern"",""(South of) Windsor Dr & Northwestern - BUS897"",40.4478927223618,-86.9232043280127,0
e5c2c38b-5163-4f1f-9f0c-c3a9f0e80cf3,BUS313SW,""Marsteller St & State St (SW Corner)"",""Marsteller St & State St (SW Corner) - BUS313SW"",40.4239741220459,-86.9139372953139,0
1168557e-493f-45aa-af2b-2dd6bd959121,BUS950,""Vine St & Wiggins St (SW Corner)"",""Vine St & Wiggins St (SW Corner) - BUS950"",40.4266201213968,-86.908213460935,0
415bc0c5-850b-43f2-84be-81ee85f2a558,BUS251W,""Stadium Ave & McCormick Rd (NW Corner)"",""Stadium Ave & McCormick Rd (NW Corner) - BUS251W"",40.430951889214,-86.9326215644253,0
41b58cd7-81fe-44ea-8e1d-ac39863b9257,BUS161,""Yeager Rd & Northwestern Ave (NW Corner)"",""Yeager Rd & Northwestern Ave (NW Corner) - BUS161"",40.4500451952246,-86.9249008253158,0
e7751ac6-f508-4917-b1f6-cee6adf8fe18,BUS520SW,""Jischke Dr & State St (SW Corner) "",""Jischke Dr & State St (SW Corner) - BUS520SW"",40.4241149380275,-86.9219638062694,0
3a084b76-7d16-43b0-a417-e0a4efdd6d5c,BUS346,""(East of) McCutcheon Dr & State St"",""(East of) McCutcheon Dr & State St - BUS346"",40.4242423429634,-86.9285016911329,0
faa14961-f4c4-4d7f-aa02-cbfafb58d661,BUS402,""Littleton St & Wiggins St"",""Littleton St & Wiggins St - BUS402"",40.4262365654848,-86.9037006439984,0
0509a340-90ee-46c3-b5ba-ff09c8174839,BUS184,""Grissom Hall on Grant St (at Shelter)"",""Grissom Hall on Grant St (at Shelter) - BUS184"",40.42633,-86.91027,0
b5159d8b-1830-4268-934c-c15af6e17ad4,BUS236W,""Blackbird Farms@ McCormick & Kestral"",""Blackbird Farms@ McCormick & Kestral - BUS236W"",40.4449087646549,-86.9439150061556,0
d27057f7-1256-4558-9cbd-dd92fb5e0001,BUS501W,""State St/SR 26 & McCormick Rd"",""State St/SR 26 & McCormick Rd - BUS501W"",40.4255298033672,-86.9308298486966,0
e955d38d-b1e2-447c-a6cf-4b75772dd12a,BUS906W,""Schwartz Tennis Cntr on McCormick (West)"",""Schwartz Tennis Cntr on McCormick - BUS906W"",40.4357530436368,-86.9361258707121,0
5cd10300-9e4f-44f1-b268-258943bfc602,BUS154,""Young Hall on Grant St"",""Young Hall on Grant St - BUS154"",40.423216397954,-86.9102733975812,0
42d08b93-8234-4b2d-a9a6-2240679052e8,BUS770SE,""Creasy Ct & Creasy Ln (SE Corner)"",""Creasy Ct & Creasy Ln (SE Corner) - BUS770SE"",40.3959799048889,-86.8380696677011,0
f331f6a9-0645-42d2-bfd1-1ba62a78bb00,BUS769SE,""Amelia Ave & Creasy Ln (SE Corner)"",""Amelia Ave & Creasy Ln (SE Corner) - BUS769SE"",40.3980063139204,-86.8381554983947,0
91fc981b-37fc-4c10-ac68-59cd55ba116a,BUS781,""(West of) 29th St & Greenbush St"",""(West of) 29th St & Greenbush St - BUS781"",40.4322567839776,-86.8621505416721,0
1eb628ee-d1e2-4bf1-8635-b927dbe1e4d5,BUS919E,""St Elizabeth Hospital on Creasy (NE)"",""St Elizabeth Hospital on Creasy (NE) - BUS919E"",40.3928618367232,-86.8380254112497,0
c1d0d839-9f1a-4348-966e-3767d590cd12,BUS750,""16th St & Greenbush St (NE Corner)"",""16th St & Greenbush St (NE Corner) - BUS750"",40.432170953284,-86.8796975540934,0
e2d8e582-bf26-420d-a46e-5fd04c6ef987,BUS759E,""S Driftwood & Shenandoah Dr (SE Corner)"",""S Driftwood & Shenandoah Dr (SE Corner) - BUS759E"",40.4214622331537,-86.8461484817355,0
c3dcc71d-9575-495f-97fb-9df4b0eec6ed,BUS230N,""Wabash Center on Greenbush St"",""Wabash Center on Greenbush St - BUS230N"",40.43221,-86.87345,0
476f4b4f-de3c-498d-8443-54cbf56d7356,BUS245NW,""Market Square (WEST) on Greenbush St"",""Market Square (WEST) on Greenbush St - BUS245NW"",40.4322152097353,-86.8712378663562,0
adcc8b2d-ce8a-4013-b681-ba0886e96a52,BUS200N,""(West of) Harper Dr & Julia Ln"",""(West of) Harper Dr & Julia Ln - BUS200N"",40.4065907243842,-86.8347102007097,0
0260ae5c-75d7-4430-a4ed-37614f6ccc2f,BUS526NE,""Chauncey Court & Greenbush St (NE Corner)"",""Chauncey Court & Greenbush St (NE Corner) - BUS526NE"",40.4323117692656,-86.8473729102238,0
6c6fbb52-7201-4ca2-bb3c-298fe4dd3e24,BUS539,""Stinger St & Creasy Ln (SE Corner)"",""Stinger St & Creasy Ln (SE Corner) - BUS539"",40.4090234881057,-86.8384384714626,0
c7940c64-5a56-49bc-96fe-9082fffff28d,BUS461,""Sam's Club on Creasy Ln"",""Sam's Club on Creasy Ln - BUS461"",40.4141666241983,-86.8385846518626,0
5ec9cf3b-c84f-4a1e-8ed9-79235e6d0f26,BUS748,""7th St & Brown St (NE Corner)"",""7th St & Brown St (NE Corner) - BUS748"",40.4219571007464,-86.8892757230566,0
b7e42dc1-1473-4c34-b19e-6e6bf248a518,BUS920SE,""Claremont Ln & Shenandoah Dr(SE Corner)"",""Claremont Ln & Shenandoah Dr (SE Corner) - BUS920SE"",40.4228985561668,-86.8469974009393,0
4b8e32d0-6f1f-4f7e-8249-620f602e1cc4,BUS778,""(North of) Amherst Dr & Shenandoah Dr"",""(North of) Amherst Dr & Shenandoah Dr - BUS778"",40.4316224415077,-86.8448234704032,0
6ac312e1-0e76-478f-a2e1-9d35f2fa9d31,BUS775NE,""Stinger St & Harper Dr (NE Corner)"",""Stinger St & Harper Dr (NE Corner) - BUS775NE"",40.4064847771218,-86.8376110099322,0
3b83e7bc-3df0-456c-9d78-600823655826,BUS987NW,""9thSt & Roberts St (NW Corner)"",""9thSt & Roberts St (NW Corner) - BUS987NW"",40.4298883932762,-86.8872238330378,0
704e318c-729b-46ee-94d2-cdd7dcb30a05,BUS763E,""Fortune Dr & Creasy Ln (SE Corner)"",""Fortune Dr & Creasy Ln (SE Corner) - BUS763E"",40.4113556689832,-86.8385336898884,0
63a50927-48b7-49c6-9bf7-1f7a39b6fad1,BUS772,""Village Pantry on Creasy Ln"",""Village Pantry on Creasy Ln - BUS772"",40.3897142642566,-86.8381461106626,0
b5c2de82-9db6-4b8d-a5f2-6c3c1f0c80d3,BUS296,""10th St & Greenbush St (NE Corner)"",""10th St & Greenbush St (NE Corner) - BUS296"",40.4321575422381,-86.885799579966,0
c5895515-9351-495b-bb81-64152af9f376,BUS774S,""Emerald Pines & McCarty Ln"",""Emerald Pines & McCarty Ln - BUS774S"",40.4027256609634,-86.8369337521156,0
e81149c9-803b-4ec0-990f-f1810e226d53,BUS330NE,""18th St & Greenbush St (NE Corner)"",""18th St & Greenbush St (NE Corner) - BUS330NE"",40.4321669299702,-86.8772849069408,0
a7a04b42-16b1-4e7e-8a3e-26adfd4451f5,BUS756E,""Redondo Dr & Shenandoah Dr (SE Corner)"",""Redondo Dr & Shenandoah Dr (SE Corner) - BUS756E"",40.4280564444099,-86.8449119833059,0
f86ee92d-e2a7-45f6-aa74-2fea4bf0f051,BUS492,""4th St & Brown St (NE Corner)"",""4th St & Brown St (NE Corner) - BUS492"",40.4218887044125,-86.8929114575929,0
9090a6cb-d3f7-4311-8a3a-a2fcc492266f,BUS773,""Burberry Place on Creasy Ln (SE Corner)"",""Burberry Place on Creasy Ln (SE Corner) - BUS773"",40.4006496310621,-86.8381890260094,0
67eea8da-ce6c-425e-82bf-5d07fc77b191,BUS437E,""PayLess Supermarket on SR 25/38"",""PayLess Supermarket on SR 25/38 - BUS437E"",40.3914362425468,-86.8439986910819,0
dcedc44c-39b9-44dc-b27a-3ea331dc878a,BUS783NW,""9th St & Cincinnati St (NW Corner)"",""9th St & Cincinnati St (NW Corner) - BUS783NW"",40.4228958739576,-86.8869609765387,0
815a3f5e-fe91-4bca-92a6-0eb94986cb3d,BUS760N,""Executive Dr & Rome Dr (NE Corner)"",""Executive Dr & Rome Dr (NE Corner) - BUS760N"",40.420729990049,-86.8436888959222,0
afbc52e1-fefa-4634-9d5d-d5d9fc9a9703,BUS245NE,""Market Square (EAST) on Greenbush St"",""Market Square (EAST) on Greenbush St - BUS245NE"",40.4322608072913,-86.8691497665137,0
d32a4f81-cef6-425a-9daa-acf5a77e0bff,BUS766E,""(North of) Sickle Ct & McCarty Ln"",""(North of) Sickle Ct & McCarty Ln - BUS766E"",40.4033600034332,-86.8339377244674,0
6d2778a2-e43d-4ee2-8a5b-269316c3466e,BUS765NE,""Julia Ln & Sickle Ct (NE Corner) "",""Julia Ln & Sickle Ct (NE Corner) - BUS765NE"",40.4045804086078,-86.8349153897116,0
8863c4c6-f519-466a-b479-502f01f719fd,BUS380NW,""Salem St & 9th St (NW Corner)"",""Salem St & 9th St (NW Corner) - BUS380NW"",40.4258516684682,-86.8871500722855,0
ad6d433f-7432-43a8-9d5f-2c3d60797c6e,BUS762,""The Pavilions & Creasy Ln"",""The Pavilions & Creasy Ln - BUS762"",40.4160830626537,-86.8386262261049,0
c5a46a3e-d25c-485d-9799-a3ba5691206e,BUS779SE,""Kimberly Dr & Shenandoah Dr (SE Corner)"",""Kimberly Dr & Shenandoah Dr (SE Corner) - BUS779SE"",40.4305254179552,-86.8447792139518,0
4762f7d8-405a-4771-a988-dfeaac341553,BUS278NE,""(East of) Elmwood Ave & Greenbush St"",""(East of) Elmwood Ave & Greenbush St - BUS278NE"",40.4322245974675,-86.8656789878416,0
751ccb06-befe-4bea-b372-fa8d94b1d538,BUS757SE,""S Navarre Dr & Shenandoah Dr (SE Corner)"",""S Navarre Dr & Shenandoah Dr (SE Corner) -BUS757SE"",40.4263559237931,-86.8470282463448,0
7425212f-db99-4683-aaee-beb799f18b1c,BUS220NW,""9th St & Brown St (NW Corner)"",""9th St & Brown St (NW Corner) - BUS220NW"",40.4219061387721,-86.8869797520029,0
845103b7-6bc9-4fa8-b3ed-d168f5694fe9,BUS780,""Hemlock Rd & Greenbush St (NE Corner)"",""Hemlock Rd & Greenbush St (NE Corner) - BUS780"",40.4322648306051,-86.8558379623794,0
767e9208-691c-4a78-b2c7-0daeeea80c7d,BUS231N,""(West of) US 52 & Greenbush St"",""(West of) US 52 & Greenbush St - BUS231N"",40.4322460551409,-86.8589211618257,0
d65e2778-25ee-44cd-86ef-bf3d46e4b87e,BUS777,""Culvers on Rome Dr (North Side)"",""Culvers on Rome Dr (North Side) - BUS777"",40.4209485900967,-86.8395381772243,0
83da7fa7-e715-4ffd-941a-647926e7e64b,BUS193N,""(North of) Creasy Ln & SR 26 (East Side)"",""(North of) Creasy Ln & SR 26 (East Side) - BUS193N"",40.4181148361036,-86.8388126396425,0
b63b2084-a985-4d31-b853-e9b39d805f5e,BUS225NE,""Shenandoah Dr & Rome Dr (NE Corner)"",""Shenandoah Dr & Rome Dr (NE Corner) - BUS225NE"",40.420684392493,-86.8458427098896,0
0d59b570-d79f-442b-ba35-7c8184c86f00,BUS367NW,""Union St & 9th St (NW Corner)"",""Union St & 9th St (NW Corner) - BUS367NW"",40.4248297467726,-86.8870374195002,0
57239b84-6600-4a3a-905b-031ca2535c44,BUS410NE,""6th St & Brown St (NE Corner)"",""6th St & Brown St (NE Corner) - BUS410NE"",40.4218994332492,-86.8904760116622,0
dfd3b71a-a84e-4c5c-96d1-1c521749fc61,BUS292NW,""Hartford St & 9th St (NW Corner)"",""Hartford St & 9th St (NW Corner) - BUS292NW"",40.4278177277933,-86.8872224919333,0
c9235d79-a9e0-4cfd-8297-c1052caad62c,BUS960,""TRW on 9th St"",""TRW on 9th St - BUS960"",40.4313729960545,-86.8872399262929,0
e1fea644-bc22-4f9a-8dbb-31fd3a84257b,BUS508NE,""14th St & Greenbush St (NE Corner)"",""14th St & Greenbush St (NE Corner) - BUS508NE"",40.4321803410161,-86.8821370233379,0
392d6d7e-4b98-47f9-a6b5-7e68e3350fcd,BUS341SE,""Union St & Shenandoah Dr (SE Corner)"",""Union St & Shenandoah Dr (SE Corner) - BUS341SE"",40.4247331872423,-86.8469531444879,0
96a18794-7c6b-4538-a626-dc924d6d37c8,BUS433,""Northwestern Ave & State St (NE Corner)"",""Northwestern Ave & State St (NE Corner) - BUS433"",40.4237769796715,-86.9077869896762,0
65a4d2b4-3d37-4ee7-ab06-8f1ff7ec46c7,BUS251E,""(North of) McCormick Rd & Stadium Ave"",""(North of) McCormick Rd & Stadium Ave - BUS251E"",40.4313367862306,-86.9326845963409,0
7d4afa51-bb92-4011-b772-2323366a0438,BUS501E,""Purdue West on McCormick Rd"",""Purdue West on McCormick Rd - BUS501E"",40.4255418733085,-86.9303242522671,0
318a14d9-3626-4e73-889b-315aceb59e95,BUS906E,""Schwartz Tennis Cntr on McCormick (East)"",""Schwartz Tennis Cntr on McCormick - BUS906E"",40.4359528682204,-86.9356028399231,0
8dcf7681-910c-426a-821a-2ac5e1185bc6,BUS179,""College Station Apts on US52 (at Shelter)"",""College Station Apts on US52 (at Shelter) - BUS179"",40.4674124996312,-86.947381761514,0
c4d59cb0-b66f-44ad-a962-023cc41bd097,BUS137,""University Plaza on Cumberland (NE Corner)"",""University Plaza on Cumberland (NE Corner) - BUS137"",40.4595965420959,-86.9350583514606,0
de800dc2-523d-4db4-b663-4b50c43f81d8,BUS905,""Robin Hood Ln & Lindberg Rd (NE Corner)"",""Robin Hood Ln & Lindberg Rd (NE Corner) - BUS905"",40.4459427562918,-86.9518141121754,0
033fa43d-2eb9-4e7d-bff7-1e79dbaf0c9e,BUS481,""Point West on Klondike Rd (NE Corner)"",""Point West on Klondike Rd (NE Corner) - BUS481"",40.4565374825321,-86.9619099475092,0
9ddac60e-8757-44f0-8d29-a7601df66c6e,BUS236E,""Blackbird Farms@ McCormick & Kestral"",""Blackbird Farms@ McCormick & Kestral - BUS236E"",40.4448189106476,-86.9435166980932,0
54ce36e2-9c78-472e-b091-e639fa3e28cd,BUS566,""Purdue West on State St"",""Purdue West on State St - BUS566"",40.4242946460423,-86.9297864693276,0
b86f38a5-ddd2-4858-88d6-5cb0ddb41a68,BUS304,""Chauncey Ave & State St (SE Corner)"",""Chauncey Ave & State St (SE Corner) - BUS304"",40.4231211795283,-86.9063734654411,0
57c5ea33-f053-4c52-82ec-ef973b8cc100,BUS342,""US 52 & Klondike Rd (SE Corner)"",""US 52 & Klondike Rd (SE Corner) - BUS342"",40.4672515670807,-86.962037352445,0
962e3c6e-b39b-4a00-9599-1bac9c7ab557,BUS127,""(East of) McCormick & US 52"",""(East of) McCormick & US 52 - BUS127"",40.4673521499248,-86.9523103208727,0
35f7dd9e-deb9-4a7c-a249-057949c50a15,BUS170,""(East of) Wyndham & US 52"",""(East of) Wyndham & US 52 - BUS170"",40.4673293511468,-86.9584378277324,0
e876ae5c-974a-4519-85c7-9cfbe81736cf,BUS195,""Klondike Rd & Lindberg Rd (NE Corner)"",""Klondike Rd & Lindberg Rd (NE Corner) - BUS195"",40.4458301035064,-86.9617892480963,0
b720f674-0234-491c-81a6-c33d860aeeb5,BUS393,""SW Blackbird Farms Apt Buildings (E)"",""SW Blackbird Farms Apt Buildings (E) - BUS393"",40.4429802562583,-86.9422815407682,0
4f26bfaa-aadb-421c-9421-a45d6e7f8419,BUS520NE,""Jischke Dr & State St  (NE Corner)"",""Jischke Dr & State St  (NE Corner) - BUS520NE"",40.4243523135395,-86.9215185595464,0
e5f44f2b-ead5-4685-8f9e-165e7624d0ac,BUS547,""Russell St & State St (NE Corner)"",""Russell St & State St (NE Corner) - BUS547"",40.4243201270294,-86.9190375160597,0
82c8950e-d202-4bef-bc79-feb6cf74469c,BUS517,""McCutcheon Hall on State St"",""McCutcheon Hall on State St - BUS517"",40.4243120804019,-86.9273537056061,0
b217e570-781b-448d-9ae4-ba6cdadc6791,BUS904,""Longspur Dr & Lindberg Rd (NE Corner)"",""Longspur Dr & Lindberg Rd (NE Corner) - BUS904"",40.4459373918734,-86.9566005144477,0
9e2684e1-9404-4d35-86ce-7dc620e650d5,BUS898,""First Street Towers on State St"",""First Street Towers on State St - BUS898"",40.4244233920826,-86.9233652605632,0
9e740683-284d-415f-97f2-2b466eec43da,BUS122,""Wabash Landing on State St (Borders)"",""Wabash Landing on State St (Borders) - BUS122"",40.4202820611168,-86.9006576776896,0
dfa10725-7d8f-4cfd-8572-51ff2c3077c0,BUS204,""Lafayette Blind on Klondike Rd"",""Lafayette Blind on Klondike Rd - BUS204"",40.460242954507,-86.9619770027385,0
958426ae-6e37-4f70-bbba-5bf77a1b0379,BUS139,""(North of) University Place on Lindberg Rd"",""(North of) University Place on Lindberg Rd - BUS139"",40.4469955233929,-86.9368956647453,0
f126a251-3ed7-4423-8803-304df73701bc,BUS498,""Wake Robin Dr & Lindberg Rd (NE Corner)"",""Wake Robin Dr & Lindberg Rd (NE Corner) - BUS498"",40.4459347096643,-86.9542053016546,0
aba19f40-69d9-41a9-a683-04c048a2807e,BUS313NE,""Marsteller St & State St (NE Corner)"",""Marsteller St & State St (NE Corner) - BUS313NE"",40.4242222263945,-86.9135939725396,0
829ff5ac-47a5-4911-9014-d93bc891fe2b,BUS271,""Purdue Memorial Union (PMU) on State St"",""Purdue Memorial Union (PMU) on State St - BUS271"",40.424129690178,-86.9110820836474,0
dd5760e3-51ef-4c3a-a2a5-25930f6a1dfa,BUS283,""Hunter Rd & US 52 (SW Corner)"",""Hunter Rd & US 52 (SW Corner) - BUS283"",40.4673749487027,-86.9494028061272,0
bdf01f4a-888b-4aef-aefb-dd9063077982,BUS268,""Copper Beech Apts Klondike (SE Corner)"",""Copper Beech Apts Klondike (SE Corner) - BUS268"",40.4543166133354,-86.9618965364633,0
f6dd6842-239d-443b-bf42-6b25887d836a,BUS221,""(East of) Bethel Dr & US 52"",""(East of) Bethel Dr & US 52 - BUS221"",40.4673789720165,-86.9548651251116,0
573360b8-a2f2-4aa3-8561-ee55cb8f674b,BUS250,""Geddes Way/Cook Medical on US 52"",""Geddes Way/Cook Medical on US 52 - BUS250"",40.4637901761407,-86.9361325762351,0
d62262f8-ec4c-447a-a143-1faf1b523aee,BUS174,""Klondike Storage on Klondike Rd"",""Klondike Storage on Klondike Rd - BUS174"",40.44835,-86.961917,0
fdbdb073-4f95-4442-90dd-4772c82c58e1,BUS464,""Pemberly Cts on Klondike Rd"",""Pemberly Cts on Klondike Rd - BUS464"",40.458101210481,-86.961930064078,0
92d3f94f-d0c2-4867-a461-ecaa31106aa3,BUS156,""Roebuck Dr & State St (NW Corner/Wendy's)"",""Roebuck Dr & State St (NW Corner/Wendy's) - BUS156"",40.4213683558326,-86.9024453701046,0
e0214030-1bf4-4575-89bc-0e993dc97e33,BUS390,""Morehouse Rd & US52 (West of Corner)"",""Morehouse Rd & US52 (West of Corner) - BUS390"",40.4668760577962,-86.9402269685404,0
026e8fc1-ea86-4531-8c3d-814964a9a290,BUS317,""Klondike Schools (SE Corner Center Drive)"",""Klondike Schools (SE Corner Center Drive) - BUS317"",40.464838919928,-86.9619032419862,0
7b9e4f5e-c223-4fe1-8cc9-a44c55fa3747,BUS581,""Littleton St & State St (SE Corner)"",""Littleton St & State St (SE Corner) - BUS581"",40.4225377990328,-86.9052321854372,0
1003b84e-ae61-46a6-a64c-18f01dee0fa4,BUS287,""2nd St & Columbia St (NW Corner)"",""2nd St & Columbia St (NW Corner) - BUS287"",40.4183857392302,-86.8956338999053,0
4631e1f5-706d-4b58-a196-7dfb9d27efec,BUS273,""Waldron St & Stadium Ave "",""Waldron St & Stadium Ave - BUS273"",40.4313287396031,-86.9180169354687,0
34c47551-0742-494a-8bf1-3859b2f9bfe4,BUS366,""Jischke Dr & 3rd St (SW Corner)"",""Jischke Dr & 3rd St (SW Corner) - BUS366"",40.427214230729,-86.9224197818291,0
5a0671c9-7a10-44cc-8948-01d637c0370a,BUS538,""Electrical Engineering"",""Electrical Engineering - BUS538"",40.4287323611219,-86.9114093131667,0
ae8bf685-cec9-42d1-8635-c673bada798f,BUS282NE,""MacArthur Dr & 1st St (at Shelter)"",""MacArthur Dr & 1st St (at Shelter) - BUS282NE"",40.4255311444718,-86.9256987825452,0
7a09dc4c-29b0-40dc-a1f4-a9eac8092d46,BUS557,""Physics (pulloff on Northwestern)"",""Physics - BUS557"",40.4304100829607,-86.913209075523,0
9c84096e-8558-42e9-a750-413535564f41,BUS567,""Ford Hall on Stadium Ave"",""Ford Hall on Stadium Ave - BUS567"",40.4313300807077,-86.9197469603864,0
ecb0ff66-30b0-4844-ba96-f4ff0198bb1d,BUS201E,""Jischke Dr & Stadium Ave (SE Corner)"",""Jischke Dr & Stadium Ave (SE Corner) - BUS201E"",40.4313528794857,-86.9213562858913,0
ba901975-0387-474b-bea5-72594f5625b7,BUS362E,""RSC on Jischke Dr"",""RSC on Jischke Dr - BUS362E"",40.4286384838008,-86.9213147116491,0
c47d0f0d-bb2f-4999-a3a5-3a54cb4f70e1,BUS190,""Armstrong Hall on Stadium Ave"",""Armstrong Hall on Stadium Ave - BUS190"",40.431228156759,-86.9155761251197,0
abade7e7-bc2a-450e-bd0d-6455869b8629,BUS435,""Class of 1950"",""Class of 1950 - BUS435"",40.4259066537563,-86.9147084304516,0
648c710d-9ae3-4b55-afdf-cad855369e1e,BUS568,""Earhart Hall on First St (North Side) "",""Earhart Hall on First St (North Side) - BUS568"",40.4254935935434,-86.9237421109523,0
6f420670-5bf1-4200-ac9e-a3be3d06cd17,BUS448,""Stewart Center"",""Stewart Center - BUS448"",40.425044,-86.913678,0
a8da94e3-c0f6-48ab-a864-4c1327c5e7d0,BUS560NW,""Stone Hall on Oval Dr"",""Stone Hall on Oval Dr - BUS560NW"",40.4243737712129,-86.9149578759049,0
eec4e728-1faf-4fbd-9ce2-8d186fce661d,BUS559,""Fire Station on Northwestern Ave"",""Fire Station on Northwestern Ave - BUS559"",40.4261681691508,-86.9085272794084,0
f5238d86-64fc-43bb-ab4a-20b297608f04,BUS152,""River Walk Apartments on 9th St"",""River Walk Apartments on 9th St - BUS152"",40.4355451724258,-86.8865385285937,0
708ffea2-1e73-43f3-a5a7-0cc50481270c,BUS359,""Littleton St & Fowler Ave (NW Corner)"",""Littleton St & Fowler Ave (NW Corner) - BUS359"",40.4266067103509,-86.9037167372535,0
65318683-3325-40f3-a106-3e9e698c41b1,BUS565S,""University Hall (South Stop)"",""University Hall (South Stop) - BUS565S"",40.4251261308864,-86.9149417826499,0
ae14557e-951d-4806-848d-281b855ca26c,BUS564,""4th St & Wall St (SE Corner)"",""4th St & Wall St (SE Corner) - BUS564"",40.4236535980495,-86.8930455680517,0
6ce43750-6b86-4e46-8d8e-5baf770042e7,BUS519W,""Fannon & Salem St (NW Corner)"",""Fannon & Salem St (NW Corner) - BUS519W"",40.425826187481,-86.8915743763193,0
1b5df649-0162-4433-a941-9fd152b45a57,BUS793,""RRX on Union St (NE Corner)"",""RRX on Union St (NE Corner) - BUS793"",40.4249464228717,-86.854750326559,0
80c1c301-fbfb-40fa-9f5e-bfc9c5ae56e2,BUS523NE,""30th St & Kossuth St (NE Corner)"",""30th St & Kossuth St (NE Corner) - BUS523NE"",40.4102599865353,-86.8626293160098,0
b53f0c6e-3d5e-4711-bc3a-6d180abfb572,BUS196W,""(South of) Earl Ave & Union St"",""(South of) Earl Ave & Union St - BUS196W"",40.4244166865597,-86.8608389413857,0
82a3a3ce-98b5-4eab-ab8e-3c2ca3d9ff62,BUS383W,""(West of) 26th St & Kossuth St"",""(West of) 26th St & Kossuth St - BUS383W"",40.410163427005,-86.8676597993171,0
2c770e8f-fb2e-441b-9988-86f1cdda103f,BUS536,""Park Ave & Ruger St (SE Corner)"",""Park Ave & Ruger St (SE Corner) - BUS536"",40.4144898304039,-86.8686830621173,0
d96bda36-bfde-4fd3-b936-e4d4941f03e1,BUS798NE,""Asher St & Ferry St (NE Corner)"",""Asher St & Ferry St (NE Corner) - BUS798NE"",40.4193888854616,-86.8787882851832,0
7e5adc9d-cbf7-4912-af70-d18fad4c159f,BUS459NW,""Cason St & Earl Ave (NW Corner)"",""Cason St & Earl Ave (NW Corner) - BUS459NW"",40.4206253838912,-86.8607101953453,0
a3542541-d874-45d1-8eef-5691cbebd25b,BUS507W,""Portledge Commons Apts on Earl Ave"",""Portledge Commons Apts on Earl Ave - BUS507W"",40.4220523191722,-86.8607906616206,0
195198fb-0e5c-42fe-ba2f-1ec355f4ab80,BUS370,""Park Ave & Wallace Ave (SE Corner)"",""Park Ave & Wallace Ave (SE Corner) - BUS370"",40.412964994488,-86.8686213713063,0
7e83df40-918c-41fb-8dbb-9ba56aec1127,BUS382N,""(West of) US 52 & Union St"",""(West of) US 52 & Union St - BUS382N"",40.4250188425194,-86.8592765545414,0
7f315da4-af34-47ad-bfd4-684b7a3626ab,BUS280N,""(West of) 19th St & Ferry St"",""(West of) 19th St & Ferry St - BUS280N"",40.4190509271056,-86.8760873005442,0
7fdd56d6-77c6-4d68-a1ce-7e6583dd9939,BUS797N,""(West of) Perrin Ave & Ferry St"",""(West of) Perrin Ave & Ferry St - BUS797N"",40.4201425862397,-86.8821276356058,0
50de9d09-be5e-4bb5-8203-15b342b94894,BUS814,""Brice St & Earl Ave (NW Corner)"",""Brice St & Earl Ave (NW Corner) - BUS814"",40.4116426653649,-86.8607061720315,0
afadfb0d-f45a-49e6-b521-d1472ee9da74,BUS533N,""(West of) 28th St & Kossuth St"",""(West of) 28th St & Kossuth St - BUS533N"",40.4102613276399,-86.8653396883809,0
c8aff0a0-6a9e-43db-9457-e2713cae6ff5,BUS202NW,""Kossuth St & Earl Ave (NW Corner)"",""Kossuth St & Earl Ave (NW Corner) - BUS202NW"",40.4103082663005,-86.8608563757453,0
a1eb8c64-65e8-47d5-8edf-d2a9253b73d3,BUS542,""25th St & Ferry St (NW Corner at Shelter)"",""25th St & Ferry St (NW Corner at Shelter) - BUS542"",40.4191608976818,-86.8688721578641,0
f11bcae2-5b65-4cde-adf1-e7796b8a3cad,BUS377,""International Sq (@ Nanking Restaurant)"",""International Sq (@ Nanking Restaurant) - BUS377"",40.4178332041403,-86.8379261695102,0
9663b906-1811-4d49-8082-cc5feea72613,BUS811,""Target on SR 26 (@ 5th/3rd Bank)"",""Target on SR 26 (@ 5th/3rd Bank) - BUS811"",40.4177031169953,-86.8479978649615,0
f93d8a60-26f2-4064-aeb2-8082220c60ee,BUS193W,""(West of) Creasy Ln & SR 26"",""(West of) Creasy Ln & SR 26 - BUS193W"",40.4177607844925,-86.8395757281527,0
4fd61a2d-5f55-48ac-b7f6-ab7907d0156f,BUS257,""Meijer Store East (West Doors)"",""Meijer Store East (West Doors) - BUS257"",40.41545,-86.81199,0
5f5e632b-f2f2-4c47-aa98-e6ddea57c8e8,BUS302N,""(West of) Executive Dr & SR 26"",""(West of) Executive Dr & SR 26 - BUS302N"",40.4177125047274,-86.843884697192,0
ec1437d2-5e84-49ac-a2d5-def35184c857,BUS552SE,""36th St & Union St (SE Corner)"",""36th St & Union St (SE Corner) - BUS552SE"",40.4246366277121,-86.8503662556628,0
96fabe7d-db67-4e44-9101-cb3075e4d126,BUS806,""(West of) Eastland Dr & SR 26"",""(West of) Eastland Dr & SR 26 - BUS806"",40.4178694139641,-86.8338358005187,0
93465963-4630-4acc-9cb5-2ea18540f32c,BUS406,""Brinker St & SR 26"",""Brinker St & SR 26 - BUS406"",40.4178935538467,-86.8294798928189,0
50197db2-d96c-47ce-8dd2-ecb7fe9457f4,BUS549N,""Fowler House Apts on Ferry St (North)"",""Fowler House Apts on Ferry St - BUS549N"",40.4201653850177,-86.8928081925397,0
f6cee113-16bf-4699-b145-b5ca727571ab,BUS487W,""Ferry St & Earl Ave (NW Corner)"",""Ferry St & Earl Ave (NW Corner) - BUS487W"",40.4192333173295,-86.8609006321967,0
7fd14289-1ba5-4881-bd3c-e2f563fd36d9,BUS386,""(East of) Red Cloud Tr & SR 26"",""(East of) Red Cloud Tr & SR 26 - BUS386"",40.417798335421,-86.8245915665979,0
48430747-af0b-4625-932a-b27902ff78d7,BUS475E,""(North of) 36th St & SR 26"",""(North of) 36th St & SR 26 - BUS475E"",40.4181188594174,-86.8496380358719,0
46d4be33-9525-4201-b3bc-ae7004874365,BUS299,""Meijer Ct & Meijer Dr (NE Corner)"",""Meijer Ct & Meijer Dr (NE Corner) - BUS299"",40.4167965302942,-86.8140008636714,0
082e3bbe-299a-4e83-9a32-3d8f6fec0e0c,BUS813E,""(North of) Coleman Ct & 36th St"",""(North of) Coleman Ct & 36th St - BUS813E"",40.4221354676566,-86.8506626397766,0
649f84f0-d021-4ec3-b62f-d5440c6ccf78,BUS277N,""(East of) Frontage Rd & SR 26"",""(East of) Frontage Rd & SR 26 - BUS277N"",40.4175569365952,-86.8150536307724,0
cc241f3c-511a-476c-89e3-89b5d0ff226e,BUS226NW,""Ruger St & Earl Ave (NW Corner)"",""Ruger St & Earl Ave (NW Corner) - BUS226NW"",40.4147862145177,-86.8608577168499,0
4a52632d-da40-4441-b606-f4308b917682,BUS374NW,""OFerrall St & Earl Ave (NW Corner)"",""OFerrall St & Earl Ave (NW Corner) - BUS374NW"",40.4163365314207,-86.860951594171,0
0ed837fa-1bf3-4eec-931e-b93ca09581ce,BUS545N,""23rd St & Ferry St (NE Corner)"",""23rd St & Ferry St (NE Corner) - BUS545N"",40.4191193234396,-86.8710769338058,0
aae2db9c-8d6c-489b-aa6b-80ebf27d179e,BUS548NE,""21st St & Ferry St (NE Corner)"",""21st St & Ferry St (NE Corner) - BUS548NE"",40.4190804314065,-86.8733541293951,0
faee82e8-15c8-4fe1-827f-0b5acaf983b4,BUS534N,""6th St & Ferry St (NE Corner)"",""6th St & Ferry St (NE Corner) - BUS534N"",40.4201667261223,-86.8904129797466,0
babad9ee-4c49-48e2-831c-e226eb2d79ba,BUS796N,""(West of) Erie St & Ferry St"",""(West of) Erie St & Ferry St - BUS796N"",40.4201372218214,-86.8844893207842,0
480b4b8f-771b-4436-b471-5796e91f5abb,BUS369,""26th St & South St (SE Corner)"",""26th St & South St (SE Corner) - BUS369"",40.4173490653842,-86.867312453229,0
99fe1c26-c8ed-4945-a3a9-8ce84e7c4481,BUS532NE,""8th St & Ferry St (NE Corner)"",""8th St & Ferry St (NE Corner) - BUS532NE"",40.4201305162985,-86.8880606823004,0
d9faa1dd-3770-40ca-b2ed-27926ce405eb,BUS794N,""(West of) 10th St & Ferry St (North)"",""(West of) 10th St & Ferry St (North) - BUS794N"",40.4201747727498,-86.8860074511771,0
f5aa272e-4703-4bfe-bb9c-175e184af09e,BUS385SW,""26th St & Ruger St (SW Corner)"",""26th St & Ruger St (SW Corner) - BUS385SW"",40.4144428917434,-86.867543123218,0
b8febf7f-3f90-414a-b109-e0eea3886dda,BUS645,""Northwestern Ave & State St (NW Corner)"",""Northwestern Ave & State St (NW Corner) - BUS645"",40.4241444423285,-86.908044481757,0
061bfeb1-4361-4b2e-8042-2da859fa70a3,BUS470N,""Hillenbrand Hall on 3rd St (North)"",""Hillenbrand Hall on 3rd St - BUS470N"",40.4275776700722,-86.9261185482811,0
15fa36f8-cb87-4653-91fc-0fe927aa1ce3,BUS217,""Purdue Village Bldg 142"",""Purdue Village Bldg 142 - BUS217"",40.4198703420085,-86.9292433219697,0
5d3112a2-a1ca-44cc-adb3-1cb272871129,BUS486N,""Lawson Hall (at Shelter)"",""Lawson Hall (at Shelter) - BUS486N"",40.427321519096,-86.9170325647016,0
e40fa864-4228-467a-96d3-be014974fe31,BUS491E,""McCutcheon Hall on McCutcheon (at Shelter)"",""McCutcheon Hall on McCutcheon (at Shelter) - BUS491E"",40.4256558671985,-86.9286921279843,0
d4a0df63-db7f-4521-a7e0-6f4c9c38fe76,BUS417NE,""Airport Rd & Nimitz Dr (NE Corner)"",""Airport Rd & Nimitz Dr (NE Corner) - BUS417NE"",40.4224264873521,-86.930259879247,0
e44dd5c3-8fa0-41ef-a3e2-a751a019bc4f,BUS470S,""Hillenbrand Hall on 3rd St (South)"",""Hillenbrand Hall on 3rd St - BUS470S"",40.4272276417749,-86.9261239126994,0
d5f2a420-e299-4ddf-877b-0046836fd907,BUS483N,""Marshall Dr & Nimitz Dr (NE Corner)"",""Marshall Dr & Nimitz Dr (NE Corner) - BUS483N"",40.4218645645299,-86.9273416356648,0
c3b966a8-8df4-41af-bf63-a520b861e97d,BUS543SE,""Gates Rd & Nimitz Dr (SE Corner)"",""Gates Rd & Nimitz Dr (SE Corner) - BUS543SE"",40.4208064330105,-86.922924037154,0
18f23021-b5d2-4ede-91e9-42b29a928df3,BUS332S,""Russell St & 3rd St (SW Corner)"",""Russell St & 3rd St (SW Corner) - BUS332S"",40.4271364466629,-86.9192225884928,0
bf1748b8-9cbc-4077-9b53-3209f9c7bb18,BUS249,""Discovery Parking Lot"",""Discovery Parking Lot - BUS249"",40.41951,-86.924008,0
fe179d34-4d05-48eb-a29d-b40c96ae74bf,BUS486S,""University St & 3rd St (SW Corner)"",""University St & 3rd St (SW Corner) - BUS486S"",40.4270774380611,-86.9167858014575,0
ffe0fb05-0a16-473c-a2cf-229a7dca8077,BUS319N,""Arnold Dr & Nimitz Dr (NE Corner)"",""Arnold Dr & Nimitz Dr (NE Corner) - BUS319N"",40.4208895814949,-86.9246004178882,0
569f232b-3ed9-4463-98b7-4f76ca33521f,BUS272N,""Halsey Dr & Nimitz Dr (NE Corner)"",""Halsey Dr & Nimitz Dr (NE Corner) - BUS272N"",40.4212570441518,-86.9264498011142,0
cf907c23-92fa-4fcb-a3c4-d7f1f16b6ca6,BUS563,""Purdue Univ Student Health Center"",""Purdue Univ Student Health Center - BUS563"",40.4302129405864,-86.916647667685,0
dae3f739-4ac8-445e-95e8-65ac2ace2bd7,BUS491W,""McCutcheon Hall on McCutcheon"",""McCutcheon Hall on McCutcheon - BUS491W"",40.4256437972572,-86.9291802900541,0
47c22255-a133-4602-b12f-4d0c3e52107c,BUS332N,"" (West of) Russell St & 3rd St"","" (West of) Russell St & 3rd St - BUS332N"",40.4274100319988,-86.9196101677186,0
c576c929-3224-4455-bbd3-919fd2e28286,BUS389,""Beering Hall on University St"",""Beering Hall on University St - BUS389"",40.425905,-86.916588,0
d4d018d2-5187-4105-9508-6465dae76cfe,BUS456,""Purdue Village Bldgs149 thru 151"",""Purdue Village Bldgs149 thru 151 - BUS456"",40.4188913356597,-86.9255619898774,0
93cf3a19-d2f0-465c-91dd-b366bd1a0e3b,BUS107,""Jischke Dr & 3rd St (NE Corner)"",""Jischke Dr & 3rd St (NE Corner) - BUS107"",40.4274650172868,-86.9216137779721,0
4c5ee5e7-67e6-4ea9-a039-6aa3c8ce3ae8,BUS417SW,""Airport Rd & Nimitz Dr (SW Corner)"",""Airport Rd & Nimitz Dr (SW Corner) - BUS417SW"",40.4221368087612,-86.9306635517278,0
2a3ff998-e490-4e30-ad8a-1b51458edab4,BUS526SW,""Chauncey Court & Greenbush St (SW Corner)"",""Chauncey Court & Greenbush St (SW Corner) - BUS526SW"",40.4320100207335,-86.8477712182862,0
fa78587c-10a9-4a71-82dd-3b9c9d9b28d7,BUS766W,""McCarty Ln & Sickle Ct (NW Corner)"",""McCarty Ln & Sickle Ct (NW Corner) - BUS766W"",40.4033439101782,-86.8347008129776,0
67e03f88-d88e-4650-8b45-00d53e345089,BUS769NW,""Amelia Ave & Creasy Ln (NW Corner)"",""Amelia Ave & Creasy Ln (NW Corner) - BUS769NW"",40.3984864293627,-86.8387147390076,0
0e5aa90f-ba50-4f96-8f81-ad5d8c6b31ca,BUS200S,""Julia Ln & Harper (SW Corner)"",""Julia Ln & Harper (SW Corner) - BUS200S"",40.4060851279548,-86.8346914252455,0
2fa3e7dc-7af1-4af1-a09b-e95abc9367b3,BUS453,""(East of) 28th St & Greenbush St"",""(East of) 28th St & Greenbush St - BUS453"",40.4320717115445,-86.8635627248026,0
2a1a77e1-1cde-427d-a99a-7bc5398ca5f6,BUS760S,""Executive Dr & Rome Dr (SE Corner)"",""Executive Dr & Rome Dr (SE Corner) - BUS760S"",40.4204403114581,-86.8434206750048,0
e6862e4c-19cc-4278-ad7a-f7d696ae333e,BUS756W,""(South of) Redondo Dr & Shenandoah Dr"",""(South of) Redondo Dr & Shenandoah Dr - BUS756W"",40.4280805842924,-86.8453639355519,0
ee2bf198-a81f-432d-a8ea-6a89727ef1b8,BUS920NW,""Claremont Ln & Shenandoah Dr(NW Corner)"",""Claremont Ln & Shenandoah Dr (NW Corner) - BUS920NW"",40.423239196732,-86.8472763506935,0
93b8a151-16da-4a95-9930-f00ccd5fcafe,BUS921,""Linnwood Park"",""Linnwood Park - BUS921"",40.4319805164326,-86.8799295651871,0
bdc58c9b-d028-4f27-aa54-a310aa68521d,BUS759W,""S Driftwood & Shenandoah Dr (SW Corner) "",""S Driftwood & Shenandoah Dr (SW Corner) - BUS759W"",40.4214541865262,-86.8466259149686,0
e42827af-0751-4fba-82b3-1767c912a2ab,BUS512,""Greenbush St & 9th St (SE Corner)"",""Greenbush St & 9th St (SE Corner) - BUS512"",40.4320730526491,-86.8870682649057,0
655aea15-4b28-4125-b730-923cf98891c3,BUS768,""Creasy Ln (Across from Burberry Dr)"",""Creasy Ln (Across from Burberry Dr) - BUS768"",40.4010318458695,-86.8390044175985,0
59157505-917b-4ab3-9dc0-0d40d1873d3a,BUS508W,""14th St & Greenbush St (SW Corner)"",""14th St & Greenbush St (SW Corner) - BUS508W"",40.4320489127665,-86.8826037277343,0
5d17de1a-7845-49a8-a7a4-265cd252c3a4,BUS499N,""(West of) SR 25/38 & Creasy Ln"",""(West of) SR 25/38 & Creasy Ln - BUS499N"",40.38973572193,-86.8387630187728,0
3702c3cb-05bd-4604-982a-ca7ceb0ffc5f,BUS231S,""US 52 & Greenbush St (SW Corner)"",""US 52 & Greenbush St (SW Corner) - BUS231S"",40.4319778342234,-86.8584759151027,0
bc8c818d-c83b-4324-b69a-1be2ad5a33c2,BUS987SE,""9th St & Roberts St (SE Corner)"",""9th St & Roberts St (SE Corner) - BUS987SE"",40.4296241956725,-86.8868952624139,0
e8f9e9a7-bf8f-4fad-ba38-bac99777b3c8,BUS717,""Guaranteed Transmission on SR 25/38"",""Guaranteed Transmission on SR 25/38 - BUS717"",40.391039275589,-86.8429284896212,0
e6171cff-0d02-4288-8736-47df08a8017d,BUS230S,""Greenbush Crossing Apartments"",""Greenbush Crossing Apartments - BUS230S"",40.4319536943408,-86.8738074227457,0
59e63141-3a52-4aae-8a48-2b2f8695dda4,BUS245SE,""Market Square (EAST) on Greenbush St"",""Market Square (EAST) on Greenbush St - BUS245SE"",40.4319322366674,-86.8692302327889,0
a33a9633-6901-413f-a363-34cc751af058,BUS245SW,""Market Square (WEST) on Greenbush St"",""Market Square (WEST) on Greenbush St - BUS245SW"",40.431949671027,-86.871609352327,0
7003aeac-5fe6-4eb9-9253-9939bc85daa5,BUS499,""(West of) SR 25/38 & Creasy Ln"",""(West of) SR 25/38 & Creasy Ln - BUS499"",40.3894634776988,-86.8392981195031,0
abce20d0-d665-48c3-b4cf-e8bf28851031,BUS376,""Cambridge Estates on SR 25/38"",""Cambridge Estates on SR 25/38 - BUS376"",40.3928806121874,-86.8464126793392,0
f497f9c5-8105-4e30-952c-b8b6ba9a2275,BUS328,""Union St & 6th St (SE Corner)"",""Union St & 6th St (SE Corner) - BUS328"",40.4246527209671,-86.8906651074091,0
d21b1d5d-bc88-47a1-9148-47009ec2545f,BUS919W,""St Elizabeth Hospital on Creasy(NW Corner)"",""St Elizabeth Hospital on Creasy(NW Corner)-BUS919W"",40.3926807876039,-86.8386664592425,0
2020a302-678d-46b8-8d33-70ce51e58ff7,BUS763W,""(South of) Fortune Dr & Creasy Ln"",""(South of) Fortune Dr & Creasy Ln - BUS763W"",40.4110324627776,-86.8390097820169,0
061e421e-e8f0-467f-af05-75e94695a214,BUS775SW,""Stinger St & Harper Dr (SW Corner)"",""Stinger St & Harper Dr (SW Corner) - BUS775SW"",40.4061334077199,-86.8382386468791,0
11af2593-b8dc-4e4c-9969-b27db8f2130b,BUS513,""Shenandoah Dr & Greenbush St (SW Corner)"",""Shenandoah Dr & Greenbush St (SW Corner) - BUS513"",40.4320784170674,-86.8450179305683,0
556f61fa-c315-4a08-a3d7-2c1dbb583bbd,BUS757NW,""S Navarre Dr & Shenandoah Dr (NW Corner)"",""S Navarre Dr & Shenandoah Dr (NW Corner) -BUS757NW"",40.4267381386005,-86.8473179249357,0
30300c14-5a4c-4c55-9e6c-e6a8b3ef2e4c,BUS341NW,""Union St & Shenandoah Dr (NW Corner)"",""Union St & Shenandoah Dr (NW Corner) - BUS341NW"",40.4251475885598,-86.8472857384256,0
c3ca0e31-c1eb-45f6-90d4-2b2f83252ddd,BUS192,""(North of) Creasy Ln & SR 26 (West Side)"",""(North of) Creasy Ln & SR 26 (West Side) - BUS192"",40.4179109882063,-86.839188148927,0
6cff213f-e357-40ca-9e66-b8c182328ba2,BUS779NW,""Kimberly Dr & Shenandoah Dr (NW Corner)"",""Kimberly Dr & Shenandoah Dr (NW Corner) - BUS779NW"",40.4308311898011,-86.8450796213794,0
0a6bef69-c03d-4d71-8ff8-35ffd7943bcb,BUS771,""Starbucks Coffee on Creasy Ln"",""Starbucks Coffee on Creasy Ln - BUS771"",40.4152529189141,-86.8392015599728,0
5db0cd4b-7166-4a61-bd89-2209ff434e22,BUS753,""RRX on Greenbush St (SW Corner)"",""RRX on Greenbush St (SW Corner) - BUS753"",40.4320730526491,-86.8568853650621,0
ec6372a7-57dc-41b6-8b2d-4fd51e776474,BUS770NW,""Creasy Ct & Creasy Ln (NW Corner)"",""Creasy Ct & Creasy Ln (NW Corner) - BUS770NW"",40.3966142473587,-86.8387254678444,0
90a68cb2-3b8e-44f4-870a-747b4e72a865,BUS765NW,""Sickle Ct & Julia Ln (NW Corner)"",""Sickle Ct & Julia Ln (NW Corner) - BUS765NW"",40.4051342848023,-86.8353767296896,0
5c2dd524-4ee6-4042-933a-2bb9a510f8a7,BUS410SW,""6th St & Brown St (SW Corner)"",""6th St & Brown St (SW Corner) - BUS410SW"",40.4217827571501,-86.8908528620513,0
d83a38fc-9b1c-4874-99f0-4ccfff4e56ce,BUS468,""Creasy Ln & Rome Dr (SW Corner)"",""Creasy Ln & Rome Dr (SW Corner) - BUS468"",40.4207219434215,-86.8391666912536,0
d9c7cf0c-e66b-43b9-9a80-59ebaf7b0b34,BUS774N,""Emerald Pines & McCarty Ln (NE Corner)"",""Emerald Pines & McCarty Ln (NE Corner) - BUS774N"",40.4032701494259,-86.8364724121375,0
c0afe646-aed4-4631-95ed-9b39f281f419,BUS278SW,""Elmwood Ave &  Greenbush St (SW Corner)"",""Elmwood Ave &  Greenbush St (SW Corner) - BUS278SW"",40.4320381839298,-86.8664568285022,0
6af81762-6c2a-4a6b-9b8b-a6b2c0bade18,BUS745,""Cincinnati St & 6th St (SE Corner)"",""Cincinnati St & 6th St (SE Corner) - BUS745"",40.4226531340273,-86.8905913466568,0
d175f49e-d3de-4c5b-b8ee-11a2d6d431f5,BUS330SW,""18th St & Greenbush St (SW Corner)"",""18th St & Greenbush St (SW Corner) - BUS330SW"",40.4319671053867,-86.8777556346509,0
f6ad169b-34c7-4354-9913-de0386657454,BUS225SE,""Rome Dr & Shenandoah Dr (at  Shelter)"",""Rome Dr & Shenandoah Dr (at Shelter) - BUS225SE"",40.4204322648306,-86.845642885306,0
44f7b187-4351-47f2-9aae-1b4e33747b10,BUS744,""5th St & Brown St (SW Corner)"",""5th St & Brown St (SW Corner) - BUS744"",40.4217492295354,-86.8919767076955,0
a0de0386-5126-47bf-9d02-549ec2cac28f,BUS746,""Tippecanoe Co. Health Dept. on 6th St"",""Tippecanoe Co. Health Dept. on 6th St - BUS746"",40.4233344151577,-86.8906288975852,0
b6254401-3fd9-4b92-ac89-fe9e4f32193a,BUS380SE,""Salem St & 9th St (SE Corner)"",""Salem St & 9th St (SE Corner) - BUS380SE"",40.425533826681,-86.8867531053277,0
60afc035-1f80-48e9-95c9-628d396c5b89,BUS292SE,""Hartford St & 9th St (SE Corner)"",""Hartford St & 9th St (SE Corner) - BUS292SE"",40.4274864749602,-86.8868215016616,0
13283725-b089-47bc-9601-53a47f9808b8,BUS693W,""Sarasota Dr & 9th St (SW Corner)"",""Sarasota Dr & 9th St (SW Corner) - BUS693W"",40.3931179876994,-86.8864406279588,0
b334570c-ed43-4a4e-8cd1-c7ca08fb3aeb,BUS303,""King St & 14th St (NW Corner)"",""King St & 14th St (NW Corner) - BUS303"",40.404553586516,-86.8815174330185,0
4e6baa28-fa04-4230-86cd-0e766d1c5baa,BUS888SW,""Doten Dr & Chilton Dr (SW Corner)"",""Doten Dr & Chilton Dr (SW Corner) - BUS888SW"",40.3583283935981,-86.8563609931684,0
5b8fb3bb-beb9-4d03-ad56-f9de745beba8,BUS870NW,""Southaven Blvd & 18th St (NW Corner)"",""Southaven Blvd & 18th St (NW Corner) - BUS870NW"",40.3773358689151,-86.8765459583131,0
89eb95b6-b046-471b-ad11-ce5f64064e44,BUS889NW,""Marcastle Dr & Concord Rd (NW Corner)"",""Marcastle Dr & Concord Rd (NW Corner) - BUS889NW"",40.3600771939801,-86.8571763847575,0
23873d16-0704-4580-bf2b-047e833208aa,BUS893,""Walmart on Vet Mem Pkwy S (Main Entrance)"",""Walmart on Vet Mem Pkwy S (Main Entrance) - BUS893"",40.365383,-86.859546,0
95b0f39e-9c7e-48f0-8f05-58df77881a20,BUS381,""Pizza King on Teal Rd"",""Pizza King on Teal Rd - BUS381"",40.3956647453108,-86.8797847258916,0
c3919f8b-eef4-4a3d-9fd7-86c8e750e203,BUS537S,""(East of) 9th St & Beck Ln"",""(East of) 9th St & Beck Ln - BUS537S"",40.3877307705719,-86.8854093185311,0
2e5ddbd2-4838-452a-ab07-f94c9bf43baf,BUS544NW,""Logan Ave & 14th St (NW Corner)"",""Logan Ave & 14th St (NW Corner) - BUS544NW"",40.4028128327616,-86.8816971410332,0
7c562443-24dd-4c92-9a99-688455557e19,BUS876,""Foxfire Apts on Veterans Mem Pkwy S"",""Foxfire Apts on Veterans Mem Pkwy S - BUS876"",40.3667585770344,-86.8686294179338,0
32f27b30-7d77-4621-a7f8-63ebf69bec5c,BUS776,""18th St & Beck Ln (SW Corner)"",""18th St & Beck Ln (SW Corner) - BUS776"",40.3877696626049,-86.8766492233663,0
6d0ab0a3-14f8-425f-98f8-7d7a640817ef,BUS872,""Newsom Dr & 18th St"",""Newsom Dr & 18th St - BUS872"",40.3717220051123,-86.8762267754213,0
49a7690f-a870-415a-bf69-e763139fe4b3,BUS892,""Sprint Store"",""Sprint Store - BUS892"",40.36612,-86.861971,0
47e795f1-2490-4165-a075-3954be9555c7,BUS182,""Central Ave & 14th St (NW Corner)"",""Central Ave & 14th St (NW Corner) - BUS182"",40.4063600543952,-86.8815751005158,0
2828441f-e0a0-4207-ac23-de578bbb9d0c,BUS875SW,""Regal Valley Dr & Veterans Mem Pkwy S"",""Regal Valley Dr & Veterans Mem Pkwy S - BUS875SW"",40.3668484310418,-86.8714189154756,0
f2b7aaa3-7b56-42c0-9bf7-bfade02da026,BUS877,""Promenade Pkwy & Veterans Mem Pkwy S"",""Promenade Pkwy & Veterans Mem Pkwy S - BUS877"",40.3668028334858,-86.863145641276,0
aa99bccb-cc5a-4822-907a-59d1c9c4e493,BUS187NW,""(West of) 18th St & Teal Rd"",""(West of) 18th St & Teal Rd - BUS187NW"",40.395589643454,-86.8769187853884,0
539b19a3-11aa-4506-8c6c-0f7316e38774,BUS698,""Historical Museum on 9th St"",""Historical Museum on 9th St - BUS698"",40.4163539657804,-86.8868617347992,0
7b1a665f-51e0-40f8-a810-7b6c4a336881,BUS210,""Adams St & 14th St (NW Corner)"",""Adams St & 14th St (NW Corner) - BUS210"",40.408190662157,-86.881662272314,0
d24cd572-fd55-41ce-a0a8-fdbdf5e891b8,BUS514N,""Crestview Ct & Teal Rd (NE Corner)"",""Crestview Ct & Teal Rd (NE Corner) - BUS514N"",40.3956231710686,-86.8842827906777,0
be431bd1-97cf-4659-abd5-7c1eae36fd88,BUS986S,""18th St & Logan Ave (SW Corner)"",""18th St & Logan Ave (SW Corner) - BUS986S"",40.4024695099872,-86.8768436835315,0
3095a349-95cc-4bd4-8938-dfb8db07545d,BUS866,""Eagles Lodge on 18th St"",""Eagles Lodge on 18th St - BUS866"",40.3809488046735,-86.8765245006397,0
51e07033-80d1-4945-bb09-c611e8121ff9,BUS108,""14th St & Kossuth St (SW Corner)"",""14th St & Kossuth St (SW Corner) - BUS108"",40.409893864983,-86.8818500269562,0
ca6e1bb4-7d11-4c8f-84fc-ae9a6f42d541,BUS683,""Hitt St & 9th St (NW Corner)"",""Hitt St & 9th St (NW Corner) - BUS683"",40.413400853479,-86.8868858746818,0
13724d1e-3395-4fdd-8892-0a3bef622a81,BUS871,""Ortman Ln & 18th St (NW Corner)"",""Ortman Ln & 18th St (NW Corner) - BUS871"",40.3747971579312,-86.8763756380305,0
216e6410-c404-438d-a66e-10e9b6c8f46c,BUS865NW,""Eastway St & 18th St (NW Corner)"",""Eastway St & 18th St (NW Corner) - BUS865NW"",40.3837664654116,-86.8765312061626,0
f37123f0-639b-443d-9f27-ac0f02000c82,BUS521SW,""Davis Dr & Beck Ln (SW Corner)"",""Davis Dr & Beck Ln (SW Corner) - BUS521SW"",40.387756251559,-86.8818553913746,0
728e82c5-b752-4cf2-9c1b-d3f5e64d667f,BUS873,""Waverly Dr & 18th St (NW Corner)"",""Waverly Dr & 18th St (NW Corner) - BUS873"",40.3695574623082,-86.8761945889112,0
be4e3f25-fe4f-4f0f-9367-c29f501c6f3d,BUS874,""Valley Lakes Center on Veterans Mem Pkwy S"",""Valley Lakes Center on Veterans Mem Pkwy S -BUS874"",40.3668403844142,-86.8741561099384,0
9eb57a82-78d0-4aa5-ac64-65c6a8e660cf,BUS253E,""(East of) 9th St & Kossuth St"",""(East of) 9th St & Kossuth St - BUS253E"",40.4098697251004,-86.886059754256,0
b1859ed0-7088-4d5f-ba66-c8c22dc473ab,BUS494N,""Fairgrounds on Teal Rd (SE Corner)"",""Fairgrounds on Teal Rd (SE Corner) - BUS494N"",40.3956647453108,-86.8812130022772,0
b4b02a8d-9245-4dbc-8b28-c9e0b7436914,BUS682S,""(West Drive) Edgelea School on Beck Ln (South)"",""(West Drive) Edgelea School on Beck Ln - BUS682S"",40.3877066306893,-86.879322044809,0
946311a5-c45d-4d14-b557-74d778125354,BUS288,""11th St & Kossuth St (SW Corner)"",""11th St & Kossuth St (SW Corner) - BUS288"",40.4098616784728,-86.8842653563181,0
28be9c43-4513-4d88-b818-3192277e9880,BUS679W,""Bishop Woods on 9th St (West Side)"",""Bishop Woods on 9th St (West Side) - BUS679W"",40.3897088998383,-86.8862032524468,0
6753c73b-f4f7-4970-8679-6f3a90e693af,BUS327SW,""El Prado Ave & Logan Ave (SW Corner)"",""El Prado Ave & Logan Ave (SW Corner) - BUS327SW"",40.4025097431248,-86.8796895074659,0
e38e9385-5f67-4ecf-8a3e-870614b47337,BUS198W,""JR Hiatt & 18th St (SW Corner)"",""JR Hiatt & 18th St (SW Corner) - BUS198W"",40.3975436328377,-86.8768852577737,0
7fdadf3b-bc62-4b99-8742-e630c7222398,BUS316,""Rosemont St & 9th St (NW Corner)"",""Rosemont St & 9th St (NW Corner) - BUS316"",40.3947849807015,-86.8863762549386,0
ab13ab4c-32c8-430a-a8a8-e709d41b9260,BUS869,""Normandy Dr & 18th St (NW Corner)"",""Normandy Dr & 18th St (NW Corner) - BUS869"",40.3784691022914,-86.8765499816269,0
d95601a4-f7b5-4b58-8c3c-c73039c01b27,BUS807W,""(North of) Manitou Dr & 18th St (West)"",""(North of) Manitou Dr & 18th St - BUS807W"",40.3855394056761,-86.8766814098764,0
c88a3dcc-f95d-41cf-86b5-19c3f86b51d0,BUS183,""Bayley Dr at Crosswinds Apts (West side)"",""Bayley Dr at Crosswinds Apts (West side) - BUS183"",40.3904907638127,-86.8343320092161,0
c6a0d8ca-dc97-4755-a463-8baaf3211969,BUS716NE,""SR 25/38 & Haggerty Ln (NE Corner)"",""SR 25/38 & Haggerty Ln (NE Corner) - BUS716NE"",40.386842959335,-86.833916266794,0
33e68290-4f1f-4cba-b7a2-ff0cace0c446,BUS710N,""Village Pantry on Brady Ln (North)"",""Village Pantry on Brady Ln - BUS710N"",40.3821571399067,-86.8586583053266,0
033ff972-9b17-4729-9068-78652a31d8ae,BUS180,""St. Elizabeth on St. Francis Way (South Side)"",""St. Elizabeth on St. Francis Way (South Side) - BUS180"",40.3922730918093,-86.8343333503206,0
553edd19-2432-4042-80af-d78e36380957,BUS404NE,""US 52 & Creasy Ln (NE Corner)"",""US 52 & Creasy Ln (NE Corner) - BUS404NE"",40.3835317721088,-86.8435132112213,0
355ef47f-a3ea-48e2-b796-83b5da593c07,BUS340N,""9th St & Twyckenham Blvd (NW Corner)"",""9th St & Twyckenham Blvd (NW Corner) - BUS340N"",40.3821356822333,-86.8860289088505,0
29fcf7c0-ebe9-4cc5-be7c-09e74e353aef,BUS703N,""(West of) Poland Hill & Twyckenham"",""(West of) Poland Hill & Twyckenham - BUS703N"",40.3838442494776,-86.8960764644192,0
24b5efdd-3288-488e-911f-947944a03d63,BUS437W,""Pay Less off SR25/38 (East of Shelter)"",""Pay Less off SR25/38 (East of Shelter) - BUS437W"",40.391134,-86.84458,0
74cd9182-5349-46e0-977c-78ae87324d5c,BUS142,""Ivy Tech at Ivy Hall (Roundabout)"",""Ivy Tech at Ivy Hall (Roundabout) - BUS142"",40.3840936949309,-86.8407988155364,0
828bf0c0-c6dd-40fa-bf80-77b9db44b40d,BUS707N,""Pipers Glen Dr & Brady Ln (NE Corner)"",""Pipers Glen Dr & Brady Ln (NE Corner) - BUS707N"",40.3819760907874,-86.8720438702133,0
db36eeb7-b2ef-4206-849c-a946442de91d,BUS941NW,""Bonlou & Creasy Ln (Menards Entrance)"",""Bonlou & Creasy Ln (Menards Entrance) - BUS941NW"",40.3873633079149,-86.8404313528795,0
47578e91-c77c-447d-b142-6f7659903923,BUS720,""Portsmouth Dr W & Brady Ln (NE Corner)"",""Portsmouth Dr W & Brady Ln (NE Corner) - BUS720"",40.3819787729966,-86.8658613780654,0
d0f9907e-e185-4598-b23e-3ec6d062574b,BUS715,""Briarwood Apts on Windemere (NW Corner)"",""Briarwood Apts on Windemere (NW Corner) - BUS715"",40.3904867404989,-86.8361545703503,0
919fd367-ae79-4978-a526-b491e99ecec1,BUS449N,""(East of) Commanche Tr & Brady Ln"",""(East of) Commanche Tr & Brady Ln - BUS449N"",40.3819653619507,-86.8689955394861,0
c0a940c4-2d0f-4064-a0ba-659e2cae9aaa,BUS704N,""Rampart St & Twyckenham (NE Corner)"",""Rampart St & Twyckenham (NE Corner) - BUS704N"",40.3837624420978,-86.8918318684001,0
391f2076-74a1-4c5b-ac9a-3c9fad4589ab,BUS177,""Windemere Dr & Bayley Dr (NW Corner)"",""Windemere Dr & Bayley Dr (NW Corner) - BUS168"",40.388523363383,-86.8343185981702,0
9eb02df7-d553-4a8a-871e-1a12e400bd76,BUS354W,""(West of) Brady Ln & 18th St"",""(West of) Brady Ln & 18th St - BUS354W"",40.3818057705048,-86.876981817304,0
47349ecb-1c41-4249-8d94-08cc080f3fd4,BUS711N,""Imperial Pkwy & Brady Ln (NE Corner)"",""Imperial Pkwy & Brady Ln (NE Corner) - BUS711N"",40.3821893264168,-86.8488816528846,0
7863f25d-a7ae-4ebe-98bc-c5152bf7a9d3,BUS714,""Brampton Apts on Windemere (NW Corner)"",""Brampton Apts on Windemere (NW Corner) - BUS714"",40.3891657524804,-86.8364281556862,0
0d4303f9-2cb4-482b-9169-824735e89715,BUS713S,""Bayley Dr & Windemere Dr (SW Corner)"",""Bayley Dr & Windemere Dr (SW Corner) - BUS713S"",40.3881196909022,-86.8340986570179,0
19d22ace-76f3-4054-90da-bbda9fdc1624,BUS706,""(West of) Hanover Dr & Brady Ln"",""(West of) Hanover Dr & Brady Ln - BUS706"",40.3819439042773,-86.8739871307604,0
f5a093d6-6e3f-4d12-a963-4eb3c0687169,BUS705N,""(East of) Dover Ln & Twyckenham Blvd"",""(East of) Dover Ln & Twyckenham Blvd - BUS705N"",40.382461570648,-86.8870950869974,0
78c26ccc-2a38-4845-993f-4cc0fd01eb04,BUS301N,""Pheasant Run Apts (at Shelter)"",""Pheasant Run Apts (at Shelter) - BUS301N"",40.3821088601416,-86.8610843635252,0
2b9ad8b1-df1c-4cad-b67c-806073d9e06e,BUS178,""Hatke Dr and St. Francis Way (SW Corner)"",""Hatke Dr and St. Francis Way (SW Corner) - BUS178"",40.3922650451818,-86.8330780764269,0
06647a3f-21e9-415b-9950-592ac44c070c,BUS301S,""Pheasant Run Apts (across from Shelter)"",""Pheasant Run Apts (across from Shelter) - BUS301S"",40.3815804649341,-86.8610843635252,0
6c00a838-2966-4eae-bbc7-0c5fd2488d77,BUS724W,""(North of) Congress St & 18th St"",""(North of) Congress St & 18th St - BUS724W"",40.4114938027557,-86.8773774431573,0
b5c429ef-e89e-4a49-aff9-cc24a0d22b84,BUS449S,""(East of) Commanche Tr & Brady Ln"",""(East of) Commanche Tr & Brady Ln - BUS449S"",40.3814624477305,-86.8689646940806,0
ae61cb50-55ae-4526-a0db-7a12250bfa68,BUS142S,""Ivy Tech on Creasy Ln (at Shelter)"",""Ivy Tech on Creasy Ln (at Shelter) - BUS142S"",40.3851826718559,-86.8412789309787,0
fe6e1d7a-a67f-4ebd-b336-ce4bb887de10,BUS725W,""Adams St  & 18th St (NW Corner)"",""Adams St  & 18th St (NW Corner) - BUS725W"",40.4084065799956,-86.8770850823572,0
b00da3e9-817b-48a0-9a11-ff19bb899880,BUS940,""(South of) Larue St & 18th St"",""(South of) Larue St & 18th St - BUS940"",40.4135068007414,-86.8773331867059,0
8e4de682-c464-44aa-bb81-f8b2911524c2,BUS469S,""Georgetown Apts on Shoshone Dr (South)"",""Georgetown Apts on Shoshone Dr - BUS469S"",40.3931984539746,-86.8750331923385,0
d1d76bb1-f220-480b-8b21-c3057cc24a61,BUS495,""Kossuth St & 18th St (NW Corner)"",""Kossuth St & 18th St (NW Corner) - BUS495"",40.4100749141022,-86.8771910296196,0
96081bef-044c-409d-b5c7-024a62ef2c49,BUS735W,""(South of) Shasta Dr & Commanche Tr"",""(South of) Shasta Dr & Commanche Tr - BUS735W"",40.3825326491912,-86.8697264414863,0
d499d38c-68fa-45c9-96ab-3fe1f6c37bb0,BUS708,""Winter St & Brady Ln (SW Corner)"",""Winter St & Brady Ln (SW Corner)  - BUS708"",40.3814825642993,-86.8651425460066,0
c6f01d9a-8412-4743-92a7-cfb6e997167e,BUS404SW,""(West of) US 52 & Brady Ln"",""(West of) US 52 & Brady Ln - BUS404SW"",40.3820914257819,-86.8437707033021,0
988dfedc-931e-4474-bdab-c42b2c6cfece,BUS711S,""Imperial Pkwy & Brady Ln (SW Corner)"",""Imperial Pkwy & Brady Ln (SW Corner) - BUS711S"",40.3816609312094,-86.8493000775158,0
1d2bf8cc-5efc-40ca-866f-61ba2df53750,BUS331,""Marsh Entrance on Teal Rd (NE Corner)"",""Marsh Entrance on Teal Rd (NE Corner) - BUS331"",40.3955118593878,-86.8704117459304,0
5f882bab-45a0-4e73-8458-b14333ce05e4,BUS256S,""(East of) State St & 18th St"",""(East of) State St & 18th St - BUS256S"",40.4058195892465,-86.8764198944819,0
755f891d-a41f-4576-b277-44e58980c642,BUS710S,""Village Pantry on Brady Ln (South)"",""Village Pantry on Brady Ln - BUS710S"",40.3815388906919,-86.8586475764899,0
29e8fa65-d45c-4bb4-a71e-3c745dd5f3b7,BUS378SW,""Earl Ave & State St (SE Corner)"",""Earl Ave & State St (SE Corner) - BUS378SW"",40.4014113784678,-86.8695440512624,0
b34f3d5e-223d-45dd-8efb-77e8c76f1bab,BUS726S,""20th St & State St (SW Corner)"",""20th St & State St (SW Corner) - BUS726S"",40.4044516625674,-86.8744001909733,0
67c16434-43de-4bfb-bb2d-25fe57393ae7,BUS414,""Gregory Ave & 26th St (NW Corner)"",""Gregory Ave & 26th St (NW Corner) - BUS414"",40.3990537166031,-86.8670388678932,0
8ff63c49-0602-4963-b4c1-82d6708c0391,BUS723,""(North of) Center St & 18th St"",""(North of) Center St & 18th St - BUS723"",40.414736593648,-86.8773667143206,0
322ea675-10df-4836-a1d1-d9f016e5d23e,BUS428S,""Summerfield Dr & Iroquois Tr (SW Corner)"",""Summerfield Dr & Iroquois Tr (SW Corner) - BUS428S"",40.3916199738753,-86.8713357669911,0
2368b47b-c0bc-40d4-b646-702ca0091d3d,BUS729,""Iroquois Tr & Osage Dr (NW Corner) "",""Iroquois Tr & Osage Dr (NW Corner) - BUS729"",40.3920316929836,-86.8723214788628,0
bd83d5b9-4cd1-4e7f-963b-15c5daf955ce,BUS963,""(South of) 18th St & Meadow Dr"",""(South of) 18th St & Meadow Dr - BUS963"",40.3945489462941,-86.8767484651058,0
99750941-abd4-4033-a70c-781118ac1895,BUS457,""(South of) Manitou Dr & Commanche Tr"",""(South of) Manitou Dr & Commanche Tr - BUS457"",40.3856453529385,-86.8701046329799,0
6c5d7bac-0473-4ecb-a8a7-336531ed01b7,BUS727,""23rd St & State St (SW Corner)"",""23rd St & State St (SW Corner) - BUS727"",40.402359539411,-86.8711077792113,0
3437c6cc-d535-457e-b175-87eb2f68c070,BUS941SE,""Creasy Ln & Bonlou (SE Corner)"",""Creasy Ln & Bonlou (SE Corner) - BUS941SE"",40.3868670992176,-86.8399807417381,0
b0417b9f-1f09-467d-963b-5c474ab9b118,BUS730,""Hiawatha Ln & Summerfield Dr (NW Corner)"",""Hiawatha Ln & Summerfield Dr (NW Corner) - BUS730"",40.3897223108841,-86.8712821228076,0
6a46edda-531c-4f34-a3f9-b29a74d70bde,BUS315S,""Osage Dr & Shoshone Dr (SW Corner)"",""Osage Dr & Shoshone Dr (SW Corner) - BUS315S"",40.3932065006022,-86.8722584469472,0
c24f7833-91a5-4f67-9c36-19574ece557c,BUS311,""Rural King on 26th St (at Shelter)"",""Rural King on 26th St (at Shelter) - BUS311"",40.39678,-86.86699,0
0f2b32c7-5d0a-40c4-9a37-58e4cd1a6eeb,BUS731W,""(South of) Beck Ln & Commanche Tr"",""(South of) Beck Ln & Commanche Tr - BUS731W"",40.3878353767297,-86.8703165275047,0
592e5ce3-cbb5-4112-af02-a4fbd8a085cf,BUS416,""Beck Ln & Summerfield Dr (NW Corner)"",""Beck Ln & Summerfield Dr (NW Corner) - BUS416"",40.3882497780472,-86.8712928516443,0
1bd9acbe-797e-45aa-ba3c-7ceb3f15c9cd,BUS181,""RRX on Brady Ln (SW Corner)"",""RRX on Brady Ln (SW Corner) - BUS181"",40.3814624477305,-86.867029480161,0
91be64fe-b91b-4e40-beb8-a1aafb7a0036,BUS565N,""University Hall (North Stop)"",""University Hall (North Stop) - BUS565N"",40.4254466548828,-86.9149149605581,0
2bcb20a0-7ce9-4b12-8ddb-2f0c709d3fd8,BUS783SE,""9th St & Cincinnati St (SE Corner)"",""9th St & Cincinnati St (SE Corner) - BUS783SE"",40.4226732505961,-86.886719577713,0
be793c6d-6d2d-4519-a0d8-e78f0c5884d6,BUS353,""(North of) 24th St & Underwood St"",""(North of) 24th St & Underwood St - BUS353"",40.4378089569693,-86.869629881956,0
e20eb9d6-299f-434b-aead-28177b5d52bb,BUS274,""Underwood St & 20th St (SE Corner)"",""Underwood St & 20th St (SE Corner) - BUS274"",40.4377137385436,-86.8744940682944,0
8d1e1b44-0f58-4233-96af-657f358ccd1e,BUS452,""Greenbush St & 17 St  (SE Corner)"",""Greenbush St & 17 St  (SE Corner) - BUS452"",40.4319966096876,-86.8789197134328,0
26f3ac4e-80fd-4311-b32a-82c93d885b5e,BUS488,""17th St & Tippecanoe St (SW Corner)"",""17th St & Tippecanoe St (SW Corner) - BUS488"",40.4264672354738,-86.8789089845961,0
c330f3a3-8187-4beb-bcf2-49838836ceba,BUS255,""(Northeast Corner) 9th St & Ferry St"",""(Northeast Corner) 9th St & Ferry St - BUS255"",40.4202324402471,-86.88671287219,0
5a262ee7-4c91-429f-bb2e-23a2ab4c22bc,BUS842,""Village Pantry on Salem St"",""Village Pantry on Salem St - BUS842"",40.4257966831801,-86.8824427951838,0
58e840a5-ad09-4e72-9c5f-50fba4947745,BUS508SW,""(South of) Greenbush St & 14th St"",""(South of) Greenbush St & 14th St - BUS508SW"",40.4317739863261,-86.8824642528572,0
fa7693fb-f3ab-48a3-bc88-69f23cb2eafc,BUS858,""18th St & Schuyler Ave (NE Corner)"",""18th St & Schuyler Ave (NE Corner) - BUS858"",40.4405461514322,-86.8775651977995,0
02e44c3e-8b54-4b97-8958-35ee392990e9,BUS786,""St Anthony Health Care"",""St Anthony Health Care - BUS786"",40.4291132348247,-86.8823301423985,0
62369c08-67cc-4017-b359-aff8898ec078,BUS227,""20th St & Schuyler Ave (NE Corner)"",""20th St & Schuyler Ave (NE Corner) - BUS227"",40.4418443406728,-86.8744699284118,0
91a2110c-892b-4662-8322-ed9a4856c178,BUS852,""Perrine St & 20th St (SE Corner)"",""Perrine St & 20th St (SE Corner) - BUS852"",40.435801323402,-86.8744846805623,0
f7dfefa9-c807-4cb1-8e3d-c791b28116c1,BUS854,""Albany St & 24th St (SE Corner)"",""Albany St & 24th St (SE Corner) - BUS854"",40.4397857451311,-86.8696419518973,0
035f5518-1478-46d9-be8a-c3b2cfe2e6b7,BUS367SE,""Union St & 9th St (SE Corner)"",""Union St & 9th St (SE Corner) - BUS367SE"",40.4245092227762,-86.8868000439882,0
5eacf1e9-2480-4429-bd5d-1371a16efdcf,BUS549S,""Fowler House Apts on Ferry St (South)"",""Fowler House Apts on Ferry St - BUS549S"",40.4198944818911,-86.892820262481,0
e0306418-50e2-430a-b6c5-760f47b7dec7,BUS451,""Riggs Community Health Clinic (at Shelter)"",""Riggs Community Health Clinic (at Shelter) - BUS451"",40.4285526531072,-86.878922395642,0
6b2cf9af-5f0a-4451-8b3e-81684750a3a8,BUS534S,""6th St & Ferry St (SW Corner)"",""6th St & Ferry St (SW Corner) - BUS534S"",40.4199186217736,-86.8909400338495,0
b53c1ec0-3adc-41ce-9696-77a4f6347377,BUS546W,""14th St & Hartford St (at Shelter)"",""14th St & Hartford St (at Shelter) - BUS546W"",40.4276286320465,-86.8824360896609,0
f07e3a51-63a5-4a16-863b-d82a21caa66c,BUS789SW,""12th St & Hartford St (SW Corner)"",""12th St & Hartford St (SW Corner)  - BUS789SW"",40.4276031510593,-86.8842962017236,0
4636af5d-e0eb-4031-a9a9-3447c76d8806,BUS937,""22nd St & Underwood St (SW Corner)"",""22nd St & Underwood St (SW Corner) - BUS937"",40.4377271495895,-86.8713813645471,0
d1dbc8a6-8fba-48c3-bd52-71e7d026da2e,BUS849,""Howell St & 17th St (SE Corner)"",""Howell St & 17th St (SE Corner) - BUS849"",40.4300506669313,-86.8789438533154,0
527a4f0f-51b8-419b-8729-a601c1e0ec35,BUS546N,""Hartford St &14th St (NW Corner)"",""Hartford St &14th St (NW Corner) - BUS546N"",40.4279156284282,-86.8822845448425,0
c8806913-5c56-49ea-8857-a27972f8dac2,BUS859,""Star Lanes on Schuyler Ave"",""Star Lanes on Schuyler Ave - BUS859"",40.4397723340852,-86.8794507908494,0
fb250068-e368-4c62-8dfd-5854527b20f9,BUS843,""11th St & Salem St (NE Corner)"",""11th St & Salem St (NE Corner) - BUS843"",40.4258342341086,-86.884447746542,0
a5eb7fa7-50a4-49dc-b47a-618c46d64888,BUS348,""Greenbush St & 15th St (NW Corner)"",""Greenbush St & 15th St (NW Corner) - BUS348"",40.4322366674087,-86.8815295029598,0
e62e7655-317a-4f4b-afca-2e3a3520e792,BUS850,""Wabash Center on 20th St (at Shelter)"",""Wabash Center on 20th St (at Shelter)  - BUS850"",40.4324029643776,-86.8743867799274,0
73394cf2-39f2-4fce-b8e1-ff09926d5eaf,BUS246,""(South of) Schuyler Ave & 24th St"",""(South of) Schuyler Ave & 24th St - BUS246"",40.4420857394985,-86.869629881956,0
e3be4638-4d4b-428d-a5f4-d2f021d6cbe1,BUS220SE,""9th St & Brown St (SE Corner)"",""9th St & Brown St (SE Corner) - BUS220SE"",40.4217264307574,-86.8867678574781,0
2acdb1ba-e080-4ec8-954c-4257d9504581,BUS847,""(East of) 14th St & Tippecanoe"",""(East of) 14th St & Tippecanoe - BUS847"",40.4264484600096,-86.8816716600461,0
07ff7f1b-fe73-44fe-99fa-92f519afcef9,BUS862,""Ball St & 15th St (NW Corner)"",""Ball St & 15th St (NW Corner) - BUS862"",40.4332974811374,-86.8814745176717,0
146c4ad7-2c44-435e-be4b-a517ae94910d,BUS787,""Howell St & 14th St (NW Corner)"",""Howell St & 14th St (NW Corner) - BUS787"",40.4304020363332,-86.8824106086737,0
d9a88795-b57d-4844-8e04-79186e283d8b,BUS532SW,""8th St & Ferry St (SW Corner)"",""8th St & Ferry St (SW Corner) - BUS532SW"",40.4199561727021,-86.8885542087885,0
70825e06-c54b-456d-b97e-32b40418be7e,BUS860,""Barbee St & Schuyler Ave (at Shelter)"",""Barbee St & Schuyler Ave (at Shelter) - BUS860"",40.4386431240227,-86.8812653053561,0
2199a6c3-1d7d-463f-a589-725d3baf47fd,BUS851,""Meharry St & 20th St (SE Corner)"",""Meharry St & 20th St (SE Corner) - BUS851"",40.4338325818677,-86.8744659050981,0
90ff6224-a147-47c9-8312-b26fb0d1ba09,BUS861,""Hart St & 15th St (NW Corner)"",""Hart St & 15th St (NW Corner) - BUS861"",40.4362532756479,-86.8815134097048,0
f273b217-cb9b-4c98-9050-7d308d857cdd,BUS863,""21st St & Schuyler Ave (NE Corner)"",""21st St & Schuyler Ave (NE Corner) - BUS863"",40.4424880708747,-86.8726648016372,0
c5db227c-100f-43bd-af95-6a929ff0cdeb,BUS523SW,""30th St & Kossuth St (SW Corner)"",""30th St & Kossuth St (SW Corner) - BUS523SW"",40.4099998122454,-86.8629833676209,0
e253c833-e5e4-4fa2-976e-63c266d7d725,BUS794S,""(West of) 10th St & Ferry St"",""(West of) 10th St & Ferry St - BUS794S"",40.4198690009039,-86.885998063445,0
09324c45-3b3b-4dd9-91d5-a3b88dd78305,BUS796S,""Erie St & Ferry St (SW Corner)"",""Erie St & Ferry St (SW Corner) - BUS796S"",40.4198931407865,-86.8842962017236,0
e1e0be3f-76c6-462e-ae53-6ba0601b5244,BUS374SE,""OFerrall St & Earl Ave (SE Corner)"",""OFerrall St & Earl Ave (SE Corner) - BUS374SE"",40.416017348529,-86.8605331695398,0
b5cad3cd-a901-41fb-8987-5323c19b1be5,BUS302S,""Executive Dr & SR 26 (SE Corner)"",""Executive Dr & SR 26 (SE Corner) - BUS302S"",40.4174509893328,-86.8439276125388,0
d42c5471-b847-4395-9216-e047c8c4f858,BUS487E,""(North of) Ferry St & Earl Ave"",""(North of) Ferry St & Earl Ave - BUS487E"",40.4193231713368,-86.860437951114,0
b7b06df6-73d5-4644-b7f8-923981879c54,BUS808,""Marketplace Blvd & Commerce Dr (NE Corner)"",""Marketplace Blvd & Commerce Dr (NE Corner) - BUS808"",40.4153843471637,-86.8267051474276,0
56bc073b-fae4-4eb0-8fe3-f7ebb0c8847d,BUS969,""(East of) Fairington Ave & Commerce Dr"",""(East of) Fairington Ave & Commerce Dr - BUS969"",40.4156592736041,-86.8310221630944,0
6e5d03b2-8da0-40f5-b0c1-bb996ef36746,BUS503,""Walmart (East Lafayette)"",""Walmart (East Lafayette) - BUS503"",40.4138662167708,-86.8266367510937,0
f9fa55a1-9a14-4b73-9e74-185b38212aaa,BUS244,""26th St & Ferry St (SW Corner)"",""26th St & Ferry St (SW Corner) - BUS244"",40.4188014816523,-86.8677523355336,0
fc7c8833-6ff7-4d85-81f9-cc4d14841a15,BUS970,""Commerce Dr & Park East (SW Corner)"",""Commerce Dr & Park East (SW Corner) - BUS970"",40.4156552502903,-86.8291472988812,0
d7579d97-91e0-4a90-a26a-fe1ccd9fc689,BUS193E,""(East of) Creasy Ln & SR 26"",""(East of) Creasy Ln & SR 26 - BUS193E"",40.4174469660191,-86.8379315339286,0
1cfebe7a-d9ba-43fa-9202-ce44c12aa5fb,BUS383N,""Kossuth St  & 26th St (NW Corner)"",""Kossuth St  & 26th St (NW Corner) - BUS383N"",40.4103122896142,-86.8672252814308,0
448d70f5-4f7c-4ee4-86bc-4daf2fd41d16,BUS552SW,""36th St & Union St (SW Corner)"",""36th St & Union St (SW Corner) - BUS552SW"",40.4248082890993,-86.8508973330794,0
b25f8dc1-70d7-4d40-83c5-1793dc2a35b8,BUS202NE,""(North of) Earl Ave & Kossuth St"",""(North of) Earl Ave & Kossuth St - BUS202NE"",40.4106985277354,-86.860405764604,0
8b4e1c1d-eb67-4fab-abab-fe2fc0805130,BUS475SE,""(East of) 36th St & SR 26"",""(East of) 36th St & SR 26 - BUS475SE"",40.4174027095677,-86.8493081241434,0
23e3ec50-f7db-4378-a656-4af5afb4cdd7,BUS971,""RRX on Union St (SW Corner)"",""RRX on Union St (SW Corner) - BUS971"",40.4247854903213,-86.8555348727426,0
a93ca888-6a73-4eab-9871-e6c87ab19c5a,BUS226SE,""(South of) Ruger St & Earl Ave"",""(South of) Ruger St & Earl Ave - BUS226SE"",40.4143235334351,-86.8604714787287,0
92c79b80-1fae-4bb9-b84f-a55e4e057637,BUS151,""(East of) Progress Dr & SR 26"",""(East of) Progress Dr & SR 26 - BUS151"",40.4174697647971,-86.8251749470934,0
bb4d8af7-6666-46c7-b596-adca9915d5e9,BUS280S,""19th St & Ferry St (SW Corner)"",""19th St & Ferry St (SW Corner) - BUS280S"",40.4187263797955,-86.8760604784525,0
81c7ffe3-9595-4454-94e4-d9f8ef2ef3ef,BUS798SW,""Asher St & Ferry St (SW Corner)"",""Asher St & Ferry St (SW Corner) - BUS798SW"",40.4192266118066,-86.8792228030695,0
ad8289d4-b101-47eb-a260-5ebe1bd10e4a,BUS548SW,""21st St & Ferry St (SW Corner)"",""21st St & Ferry St (SW Corner) - BUS548SW"",40.4187625896193,-86.8736813589144,0
8cc15765-cd58-4c5d-a04d-082b800e2d6f,BUS189,""Wallace Ave & 26th St (NW Corner) "",""Wallace Ave & 26th St (NW Corner) - BUS189"",40.4132519908698,-86.8674385170602,0
a5e7ea89-a424-4053-9bbe-03b64c304044,BUS382S,""(West of) US 52 & Union St"",""(West of) US 52 & Union St - BUS382S"",40.4246688142221,-86.8592765545414,0
f816389a-b84d-45d6-84e6-32596f58c998,BUS797S,""Perrin Ave & Ferry St (SW Corner)"",""Perrin Ave & Ferry St (SW Corner) - BUS797S"",40.4199105751461,-86.8819023300351,0
bab7f2ab-b011-404e-8c8b-4591da99ef34,BUS507E,""Portledge Commons Apts on Earl Ave"",""Portledge Commons Apts on Earl Ave - BUS507E"",40.4220563424859,-86.8603494382113,0
e130d05f-f91a-4837-9256-48b47ba1eb30,BUS277S,""Frontage Rd & SR 26 (SW Corner)"",""Frontage Rd & SR 26 (SW Corner) - BUS277S"",40.4173664997438,-86.8167219648792,0
dcef0c2b-a279-448a-af0f-ed2f3b84af40,BUS813W,""Coleman Ct & 36th St (NW Corner @ Bench)"",""Coleman Ct & 36th St (NW Corner @ Bench) - BUS813W"",40.4221515609116,-86.8511454374281,0
f55417e0-e58b-4c50-b321-27d2e18cd51c,BUS196E,""(South of) Union & Earl (Family Video)"",""(South of) Union & Earl (Family Video) - BUS196E"",40.4244569196974,-86.8603548026296,0
ad8f7079-06d0-4222-860c-52f7b41ec5f2,BUS372,""Meijer Ct & Meijer Dr (SW Corner)"",""Meijer Ct & Meijer Dr (SW Corner) - BUS372"",40.4166570554171,-86.8144353815577,0
196e5318-2000-495c-a68f-6d40a958b34b,BUS459SE,""Cason St & Earl Ave (SE Corner)"",""Cason St & Earl Ave (SE Corner) - BUS459SE"",40.4203115654177,-86.8603708958847,0
ec95231b-f793-4e97-aba6-879ad426c383,BUS533S,""(West of) 28th St & Kossuth St"",""(West of) 28th St & Kossuth St - BUS533S"",40.4099180048655,-86.8651304760653,0
2e1a328a-b4b7-4379-9e0f-db4b8def874c,BUS385NW,""Ruger St & 26th St (NW Corner)"",""Ruger St & 26th St (NW Corner) - BUS385NW"",40.4147942611453,-86.8675645808914,0
31e831d6-2e28-4dc9-b965-dd0bd9034ae8,BUS799,""26th St & OFerrall St (NW Corner)"",""26th St & OFerrall St (NW Corner) - BUS799"",40.4162064442758,-86.8675645808914,0
f8685f34-ce0a-405c-9582-ba3f0d330433,BUS545S,""(East of) 23rd St & Ferry St"",""(East of) 23rd St & Ferry St - BUS545S"",40.4187987994432,-86.8710554761324,0
bcef68fc-59e9-441f-ad83-01e474f2d720,BUS475W,""(North of) 36th & SR 26 (Laf Animal)"",""(North of) 36th & SR 26 (Laf Animal) - BUS475W"",40.4181269060449,-86.8502495795637,0
eb7c0c05-430a-464e-808a-c0367dab0844,BUS540,""China Buffet on Howard Ave"",""China Buffet on Howard Ave - BUS540"",40.4226330174585,-86.9026840867212,0
a1576dfa-9009-4272-835c-2b583274b34b,BUS425N,""Wabash Landing on Brown St"",""Wabash Landing on Brown St - BUS425N"",40.4221555842254,-86.9010600090659,0
c7055e09-f6d2-4a3f-9dce-b3d0b069a44f,BUS560NE,""Stone Hall on State St (NE Corner)"",""Stone Hall on State St (NE Corner) - BUS560NE"",40.4242088153487,-86.9146507629544,0
acbff0ff-409a-4f01-a579-24602427e6be,BUS392,""3rd St & Main St (NE Corner)"",""3rd St & Main St (NE Corner) - BUS392"",40.4191850375644,-86.8941144284078,0
acaeac65-dad2-40b9-a058-e69d34ef8e60,BUS580E,""(South of) River Rd & Howard Ave"",""(South of) River Rd & Howard Ave - BUS580E"",40.4234135403284,-86.9030756892607,0
c8fc2677-6a95-4670-a19d-93f0621f6b38,BUS553,""Circle Pines on David Ross Rd (NW Corner)"",""Circle Pines on David Ross Rd (NW Corner) - BUS553"",40.435235,-86.924962,0
452a52b9-4eaa-45ef-9f91-ec3c9d4375c3,BUS229SE,""Tapawingo Dr & Brown St (SE Corner)"",""Tapawingo Dr & Brown St (SE Corner) - BUS229SE"",40.4218323780198,-86.8990939497408,0
09fc7314-129c-49cd-8faf-c97981350d0a,BUS400E,""Hilton Inn on Tapawingo Dr (NE Corner)"",""Hilton Inn on Tapawingo Dr (NE Corner) - BUS400E"",40.4202123236783,-86.899519079895,0
b85cf261-bf06-47e3-8617-567f1366ec23,BUS350,""6th St & Main St (NE Corner)"",""6th St & Main St (NE Corner) - BUS350"",40.4191944252964,-86.8904880816035,0
04bab094-9d8c-49d0-855b-743444daf828,BUS472N,""Hilltop Dr & Tower Dr (NE Corner)"",""Hilltop Dr & Tower Dr (NE Corner) - BUS472N"",40.433331008752,-86.9230796052861,0
a19829a1-c763-46aa-9af6-2ff749887009,BUS371,""4th St & Main St (NE Corner)"",""4th St & Main St (NE Corner) - BUS371"",40.419195766401,-86.8929570551489,0
cd67e7e5-5ff3-4142-92cc-8bdb69964560,BUS509SE,""Tower Dr & Jischke Dr (SE Corner)"",""Tower Dr & Jischke Dr (SE Corner) - BUS509SE"",40.4328066368584,-86.9212329042693,0
b82b41ff-9e2e-4100-a50c-26f1e59eaca1,BUS562N,""Theta Chi on Tower Dr (North)"",""Theta Chi on Tower Dr - BUS562N"",40.4333135743924,-86.9261762157784,0
2debd970-456f-4ad3-89e2-344dff524ab2,BUS554E,""Alpha Chi on David Ross Rd (East)"",""Alpha Chi on David Ross Rd - BUS554E"",40.4342697819632,-86.9254935935434,0
c7f58bb8-c9b5-40ed-995e-b127f4dc9718,BUS396,""2nd St & Main St (Lafayette Savings Bank)"",""2nd St & Main St (Lafayette Savings Bank) - BUS396"",40.4189530264707,-86.8956338999053,0
b2b598e9-ec06-44c8-a48e-d6ac6d772bd7,BUS355,""Main St & 7th (SE Corner)"",""Main St & 7th (SE Corner) - BUS355"",40.4190750669882,-86.8886226051225,0
09f554b5-9bb5-4a53-aceb-60871ae4d0d5,BUS364,""5th St & Main St (NE Corner)"",""5th St & Main St (NE Corner) - BUS364"",40.4192078363423,-86.8916830057909,0
af490b8e-63c2-4acc-a6a2-0ffe8e6bcd52,BUS362W,""RSC on Jischke Dr"",""RSC on Jischke Dr - BUS362W"",40.4286304371733,-86.9220375670217,0
a2a204d7-01d2-4bd6-8dec-201efb0a7955,BUS201W,""(South of) Jischke Dr & Stadium Ave"",""(South of) Jischke Dr & Stadium Ave - BUS201W"",40.431364949427,-86.9218068970327,0
b4b865a7-084a-4701-a517-25b8ff04a4d9,BUS584NW,""Jischke Dr & 1st St (NW Corner)"",""Jischke Dr & 1st St (NW Corner) - BUS584NW"",40.4254935935434,-86.9222387327098,0
66972e6b-3512-43ca-b08a-89ba5b362f22,BUS509SW,""Jischke Dr & Tower Dr (SW Corner)"",""Jischke Dr & Tower Dr (SW Corner) - BUS509SW"",40.4328280945318,-86.9217264307574,0
a50393c1-dc53-40ae-b003-3ec9fc444216,BUS562S,""Theta Chi on Tower Dr (South)"",""Theta Chi on Tower Dr - BUS562S"",40.4330681522529,-86.9258543506774,0
76122ec7-ab5c-41ef-90d9-6e41c14246d5,BUS425S,""Wabash Landing on Brown St (at Shelter)"",""Wabash Landing on Brown St (at Shelter) - BUS425S"",40.4219047976675,-86.9008119047172,0
102c4082-9877-453c-b352-282f5abb2a8b,BUS400W,""Hilton Inn on Tapawingo Dr  (NW Corner)"",""Hilton Inn on Tapawingo Dr  (NW Corner) - BUS400W"",40.4203705740196,-86.8998838603427,0
8b3c4cd7-339d-4a20-9859-8fe16a138aa0,BUS321,""(West of) Grant St & Wood St"",""(West of) Grant St & Wood St - BUS321"",40.4220938934144,-86.9106274491922,0
6ac9f770-572f-43ae-962d-5b19aec1ca6e,BUS163,""(East of) River Rd & Brown St"",""(East of) River Rd & Brown St - BUS163"",40.4220254970804,-86.9033197702956,0
baceeb2a-e93c-406e-ab91-5fa6e91e20b8,BUS471,""Chauncey Ave & Wood St (SW Corner)"",""Chauncey Ave & Wood St (SW Corner) - BUS471"",40.4220120860345,-86.9076595847404,0
86b6882b-4409-4427-a7b3-e8f8e864e0b1,BUS472S,""Hilltop Dr & Tower Dr (SE Corner)"",""Hilltop Dr & Tower Dr (SE Corner) - BUS472S"",40.4330466945795,-86.9232110335357,0
0faba8d0-c139-40d5-8d9f-3790c2daf640,BUS576,""Hawkins Hall on Wood St (South Side)"",""Hawkins Hall on Wood St (South Side) - BUS576"",40.422111327774,-86.9118411488438,0
f1a016f0-5838-4861-86f7-8e2df54e4860,BUS554W,""Alpha Chi on David Ross Rd (West)"",""Alpha Chi on David Ross Rd - BUS554W"",40.4343837758532,-86.9259750500903,0
befc33c6-a2cf-47c3-8610-4cfbd6fcbe22,BUS229SW,""Tapawingo Dr & Brown St (SW Corner)"",""Tapawingo Dr & Brown St (SW Corner) - BUS229SW"",40.4219343019685,-86.8995284676271,0
7db1d250-a5bb-4a55-90d7-4eba3687b89c,BUS243S,""7th St & Columbia St (SE Corner)"",""7th St & Columbia St (SE Corner) - BUS243S"",40.4180853318027,-86.8885810308803,0
3aaa6aa4-4e45-4ce8-9279-dc9185efa895,BUS530S,""McDonalds on Stadium (South)"",""McDonalds on Stadium - BUS530S"",40.4311597604251,-86.9131849356404,0
e9e3fcce-f472-4947-bfed-23d76e2db9de,BUS637SE,""Salisbury St & Rockland Dr (SE Corner)"",""Salisbury St & Rockland Dr (SE Corner) - BUS637SE"",40.4389113449402,-86.9072760288284,0
707090d9-bf9a-4150-a91f-435f19868663,BUS493,""Happy Hollow School on Salisbury (SE Corner)"",""Happy Hollow School on Salisbury(SE Corner) - BUS493"",40.4373275004224,-86.906149500975,0
2566b419-1833-4cbb-af94-e77416a43fec,BUS333SE,""Robinson St & Salisbury St (SE Corner)"",""Robinson St & Salisbury St (SE Corner) - BUS333SE"",40.4350167772184,-86.9057082775657,0
5a475a54-c246-4235-b44a-e82865882eb1,BUS636SE,""Dehart St & Salisbury St (SE Corner)"",""Dehart St & Salisbury St (SE Corner) - BUS636SE"",40.4324700196069,-86.905590260362,0
95148902-019f-4881-9497-ad7b01a059db,BUS607,""Indian Trail Dr & Navajo St (SW Corner)"",""Indian Trail Dr & Navajo St (SW Corner) - BUS607"",40.4511824519147,-86.9071955625531,0
68332f8b-c21b-4102-8235-2151e460c445,BUS608,""Delaware Dr & Navajo St (SW Corner)"",""Delaware Dr & Navajo St (SW Corner) - BUS608"",40.4513621599294,-86.9096658772031,0
ac302079-6d37-4d1b-ac41-30adf29cbfc8,BUS361SW,""Happy Hollow Rd & Chippewa (SW Corner)"",""Happy Hollow Rd & Chippewa (SW Corner) - BUS361SW"",40.4496254294888,-86.9010720790072,0
2f9ace53-a29b-4465-bd2c-14440ce726ae,BUS606,""Chippewa St & Navajo St (NW Corner)"",""Chippewa St & Navajo St (NW Corner) - BUS606"",40.4492016404391,-86.9035343470296,0
0cab66ff-6446-4e06-a547-5df3fab92535,BUS926,""(North of) Myrtle Dr & Soldiers Home Rd"",""(North of) Myrtle Dr & Soldiers Home Rd - BUS926"",40.4564100775963,-86.9029630364754,0
09d7efc4-53f5-48f7-bb36-baf6fccb156d,BUS365SE,""(South of) Lindberg & Salisbury St"",""(South of) Lindberg Rd/Ave &Salisbury St - BUS365SE"",40.4452802506256,-86.9138487824112,0
2b805d83-09ab-42a6-9c25-3b7cae822767,BUS638,""Creighton Rd & Salisbury St"",""Creighton Rd & Salisbury St - BUS638"",40.4430808391023,-86.9124821968366,0
c1779a25-ac14-4611-9383-2584c03ac7b1,BUS337NE,""Grant St & Salisbury St (NE Corner) "",""Grant St & Salisbury St (NE Corner) - BUS337NE"",40.4419006670654,-86.9107213265134,0
d7770cac-59f1-4906-83bc-d7f026f80a6b,BUS144E,""Sharon Rd & Soldiers Home Rd (NE Corner)"",""Sharon Rd & Soldiers Home Rd (NE Corner) - BUS144E"",40.454441336062,-86.9028678180496,0
0d786e65-0762-465b-8095-3961b44b654b,BUS595E,""Parkway Apts on Happy Hollow"",""Parkway Apts on Happy Hollow - BUS595E"",40.4515365035258,-86.9020604730881,0
878df3d7-e7f8-4e56-a8de-0111852e6e0f,BUS925,""Nighthawk Ln & Navajo St (SW Corner)"",""Nighthawk Ln & Navajo St (SW Corner) - BUS925"",40.4513715476615,-86.9118639476218,0
414df4aa-6486-4cf8-9dd5-4c5a56fd4165,BUS633SE,""Sycamore Ln & Salisbury St (SE Corner)"",""Sycamore Ln & Salisbury St (SE Corner) - BUS633SE"",40.448109981305,-86.9154178747784,0
352e03c1-e35e-47fc-bcf0-a16f1f6be14e,BUS541,""Browning St & Cumberland Ave (NE Corner)"",""Browning St & Cumberland Ave (NE Corner) - BUS541"",40.4607512331457,-86.9209888232344,0
41a9a0f1-2ab4-4cc5-ab86-e0aca967eddf,BUS133N,""Cumberland Pointe on Cumberland(NE Corner)"",""Cumberland Pointe on Cumberland(NE Corner) - BUS133N"",40.4607203877402,-86.9192011308194,0
7bdaf84d-a7c4-4c2e-a787-fe2c09ecedea,BUS643,""Benton St & Cumberland Ave (NE Corner)"",""Benton St & Cumberland Ave (NE Corner) - BUS643"",40.4606291926282,-86.9059684518557,0
7d18e97c-8f62-43fd-a41c-677a3e07f510,BUS138W,""(West of) Salisbury St & Cumberland Ave"",""(West of) Salisbury St & Cumberland Ave - BUS138W"",40.4606855190209,-86.9167267928557,0
499aa0bc-c00b-4203-a7d9-6d2cbda47903,BUS541N,""(Front Door) Friendship House"",""(Front Door) Friendship House - BUS541N"",40.4611924565549,-86.9214810086179,0
b2be40b2-0141-4c53-ac45-e878742808c9,BUS291SW,""Salisbury St & Stadium Ave (SW Corner)"",""Salisbury St & Stadium Ave (SW Corner) - BUS291SW"",40.4306474584727,-86.9058477524428,0
19ab4360-f1a7-49d6-b8cc-99293223a9b9,BUS635SW,""Vine St & Stadium Ave (SW Corner)"",""Vine St & Stadium Ave (SW Corner) - BUS635SW"",40.430682327192,-86.9083784167992,0
47971bea-70bf-42b4-bb21-fa90e1c33b57,BUS634SW,""Grant St & Stadium Ave (SW Corner)"",""Grant St & Stadium Ave (SW Corner) - BUS634SW"",40.4312093812948,-86.9106395191336,0
390220fc-061a-41c0-afa9-31e50bb7f5a4,BUS267N,""(West of) Cumberland & Solders Home"",""(West of) Cumberland & Solders Home - BUS267N"",40.45969712494,-86.9026317836423,0
bf46fc66-1f34-4f66-bb59-3e620bd9a07c,BUS611,""Kent Ave & Cumberland Ave (NW Corner)"",""Kent Ave & Cumberland Ave (NW Corner) - BUS611"",40.4612380541109,-86.9306876916103,0
ed07bcd0-1715-4e73-bc8f-322ffa53b5ed,BUS609,""Sacramento Ave & Navajo St"",,40.4513728887661,-86.9127839453688,0
42192d9e-cf62-4f5f-a974-ff27cae5d260,BUS604,""Marsh Supermarket on Navajo St"",""Marsh Supermarket on Navajo St - BUS604"",40.4515405268395,-86.9146185764443,0
63c746e2-5ce8-40a1-8c01-ca7fba755e46,BUS484,""Park Ridge Dr & Salisbury St (SE Corner)"",""Park Ridge Dr & Salisbury St(SE Corner) - BUS484"",40.450833764722,-86.9155841717472,0
a1a7ae47-4f59-4e41-8147-d7615bb9c120,BUS138SW,""Salisbury St & Cumberland Ave (SW Corner)"",""Salisbury St & Cumberland Ave (SW Corner) - BUS138SW"",40.4603354907236,-86.9163083682244,0
3214fb3d-06a4-40d2-ad14-4dc2f2a8adfc,BUS133S,""(South) Cumberland Pointe on Cumberland"",""(South) Cumberland Pointe on Cumberland - BUS133S"",40.4604172981034,-86.9193245124414,0
6aad413c-cf37-4a55-bd3f-bcf27a7c1a05,BUS593,""Wilshire Ave & Cumberland Ave (NE Corner)"",""Wilshire Ave & Cumberland Ave (NE Corner) - BUS593"",40.4606358981511,-86.9127276189761,0
b2b918a6-8715-4420-bde6-42e31d9db291,BUS591N,""Barlow St & Cumberland Ave (NW)"",""Barlow St & Cumberland Ave (NW) - BUS591N"",40.4606318748374,-86.9091830795516,0
c98bf9cd-3c42-4154-b928-14cdae0b7d7b,BUS641,""White Horse Center"",""White Horse Center - BUS641"",40.45903,-86.937828,0
d743f7ef-dbb6-4791-8702-b7fd746f3845,BUS223,""Lodge Apts on Cumberland Ave (at Shelter)"",""Lodge Apts on Cumberland Ave (at Shelter) - BUS223"",40.4592384671711,-86.9400740826174,0
67cc17a2-3027-4e8e-9ef1-885acb90bfbc,BUS105,""Evergreen St & Northwestern (SE Corner)"",""Evergreen St & Northwestern (SE Corner) - BUS105"",40.4323090870565,-86.9149323949178,0
6cd8d095-9145-4faa-b404-c22b6acdd2c2,BUS415,""Purdue Airport Main Terminal"",""Purdue Airport Main Terminal - BUS415"",40.4164049277547,-86.930915,0
637c1d39-604a-4112-8056-d781fafd1d3f,BUS146,""Aviation Technology Bldg"",""Aviation Technology Bldg - BUS146"",40.4164585719382,-86.9295678692798,0
065cc086-8901-4a1d-9412-7e2554d7802d,BUS125,""Bayley Dr at Crosswinds Apts (East side)"",""Bayley Dr at Crosswinds Apts (East side) - BUS125"",40.3904907638127,-86.833808978427,0
3f1ce6bb-3bbe-4ccc-a7a1-3893279342ee,BUS713N,""Bayley Dr & Windemere Dr (NE Corner)"",""Bayley Dr & Windemere Dr (NE Corner) - BUS713N"",40.3885166578601,-86.8335890372746,0
c40ba000-d5ee-48bc-9ae8-72d25d8af872,BUS705S,""(East of) Dover Ln & Twyckenham Blvd"",""(East of) Dover Ln & Twyckenham Blvd - BUS705S"",40.3818755079434,-86.8874156109938,0
b61626be-7d07-4368-a67f-360bc9248367,BUS340S,""(East of) 9th St & Twyckenham Blvd"",""(East of) 9th St & Twyckenham Blvd - BUS340S"",40.3816314269085,-86.8847494950741,0
3f394503-0232-4cdd-a465-d615e2667154,BUS973,""(Southeast of) Bonlou & SR 25/38"",""(Southeast of) Bonlou & SR 25/38 - BUS973"",40.3878997497499,-86.8366923532899,0
0712480b-c523-411b-8b01-24efc501e98f,BUS707S,""Pipers Glen Dr & Brady Ln (SW Corner)"",""Pipers Glen Dr & Brady Ln (SW Corner) - BUS707S"",40.3814718354626,-86.8726782126831,0
92c5f8e9-e8d1-473d-bcb2-c246ac84240a,BUS164,""St. Elizabeth on St. Francis Way (North side)"",""St. Elizabeth on St. Francis Way (North side) - BUS180"",40.3926110501654,-86.8343346914252,0
be0b48df-a3f0-4107-9006-ba5529d19310,BUS168,""St. Francis Way & Hatke Dr (SE Corner)"",""St. Francis Way & Hatke Dr (SE Corner) - BUS168"",40.392329,-86.8327146370837,0
66a89e25-fc91-44df-9b6a-821502effaa7,BUS701,""Poland Hill Rd & Beck Ln (SW Corner)"",""Poland Hill Rd & Beck Ln (SW Corner) - BUS701"",40.387886338704,-86.8953160581181,0
0cbd9391-6824-4b4a-9c99-b40e2676f9df,BUS354E,""(East of) Brady Ln & 18th St"",""(East of) Brady Ln & 18th St - BUS354E"",40.3814879287176,-86.875340305289,0
cf141a29-4815-40b8-bc7f-214933a4e91c,BUS703S,""(East of) Poland Hill & Twyckenham"",""(East of) Poland Hill & Twyckenham - BUS703S"",40.383274280028,-86.894455068973,0
1480f81e-5501-4f75-ae40-43ff616142b1,BUS336,""Pay Less at Beck Ln. (SW Corner)"",""Pay Less at Beck Ln. (SW Corner) - BUS336"",40.3878554932985,-86.9002620518364,0
5930989d-5e0f-44ce-a8c1-6edae8ac4c4f,BUS716SE,""(North of) Haggerty Ln & SR 25/38"",""(North of) Haggerty Ln & SR 25/38 - BUS716SE"",40.3867772452102,-86.8330995341003,0
3a7a2d1a-4ef2-47a4-8ae3-076e8e3236ba,BUS237N,""Pay Less Access Road"",""Pay Less Access Road - BUS237N"",40.386466,-86.903305,0
4f210afe-1ece-4c68-a528-503b591cc333,BUS704S,""Quarry Dr & Twyckenham (SW Corner)"",""Quarry Dr & Twyckenham (SW Corner) - BUS704S"",40.3831763793931,-86.8927277262644,0
276be048-19dd-4733-a2ec-5c2ba9ba98a9,BUS702,""Poland Hill Rd & Matterhorn (NW Corner)"",""Poland Hill Rd & Matterhorn (NW Corner) - BUS702"",40.3848943343696,-86.8951846298685,0
42bfac77-7098-4c1e-8c31-ae677b7929e4,BUS700,""Limestone &  Beck Ln (SW Corner)"",""Limestone &  Beck Ln (SW Corner) - BUS700"",40.3878903620178,-86.8969240425184,0
f8454670-6702-42fb-aa1f-6c171809ae12,BUS213S,""(South of) Beering Dr & Tower Dr"",""(South of) Beering Dr & Tower Dr - BUS213S"",40.4326269288437,-86.9193245124414,0
73b094ae-6eef-42a3-9f60-14cfee0b31cd,BUS543NE,""Gates Rd & Nimitz Dr (NE Corner)"",""Gates Rd & Nimitz Dr (NE Corner) - BUS543NE"",40.4209418845738,-86.9232566310916,0
2c6899bc-6454-4361-808f-e8ff9a572894,BUS899,""Morgan & Jischke Dr (NW Corner)"",""Morgan & Jischke Dr (NW Corner) - BUS899"",40.4233491673082,-86.9219235731318,0
50d842fa-45ba-4924-a3d3-381f23aa8406,BUS900,""Discovery Learning Center"",""Discovery Learning Center - BUS900"",40.4211282981115,-86.9219986749887,0
9f28ef2b-997c-486c-8c01-e5ac4859f582,BUS726N,""20th St & State St (NE Corner)"",""20th St & State St (NE Corner) - BUS726N"",40.4047534110995,-86.8740354105255,0
812e592e-b38e-4e67-a5cb-c2ec9350a862,BUS467,""(North of) 22nd St & Teal Rd"",""(North of) 22nd St & Teal Rd - BUS467"",40.3958189723384,-86.8714323265214,0
581f27c1-d07f-4ad5-96e3-e53d675894da,BUS339,""(East of) 9th St & Main St"",""(East of) 9th St & Main St - BUS339"",40.4191541921588,-86.8865264586524,0
67e01f34-d869-46a2-9632-79d77e70be1a,BUS469N,""Georgetown Apts on Shoshone Dr (North)"",""Georgetown Apts on Shoshone Dr - BUS469N"",40.3936141963967,-86.8750519678028,0
d7739096-0ba7-4e7e-a5c7-33f0243a1752,BUS725E,""Adams St  & 18th St (SE Corner)"",""Adams St  & 18th St (SE Corner) - BUS725E"",40.4080163185606,-86.8766344712159,0
f37b696a-b082-4ff5-adaa-ce5dd53f9a91,BUS315N,""(West of) Osage Dr & Shoshone Dr"",""(West of) Osage Dr & Shoshone Dr - BUS315N"",40.3936289485472,-86.8722691757839,0
2028ac1f-59b3-443e-bee9-a49a8fe3984b,BUS743,""(West of) Perrin Ave & Main St"",""(West of) Perrin Ave & Main St - BUS743"",40.4191072534983,-86.882705651683,0
e8c3d346-b2f6-41d2-80fe-9210268ee034,BUS397NE,""11th St & Main St (NE Corner)"",""11th St & Main St (NE Corner) - BUS397NE"",40.4191608976818,-86.8848514190228,0
9e643b0a-76cd-4b76-9bca-4190fd2ed6e8,BUS740,""Everett St & 18th St (SE Corner)"",""Everett St & 18th St (SE Corner) - BUS740"",40.4131071515743,-86.8769684062581,0
96fda154-3099-4ab5-93c0-04fed294fd87,BUS187SE,""Teal Rd & 18th St (SE Corner)"",""Teal Rd & 18th St (SE Corner) - BUS187SE"",40.3951269623713,-86.8762200698984,0
4b808426-9b60-4975-8050-4bf2b6f4da3b,BUS466E,""(North of) JR Hiatt Dr & 22nd St"",""(North of) JR Hiatt Dr & 22nd St - BUS466E"",40.3977273641662,-86.8714229387893,0
c036d4d9-c4bf-4b09-92ef-e1b78245e6a9,BUS428N,""(West of) Summerfield Dr & Iroquois Tr"",""(West of) Summerfield Dr & Iroquois Tr - BUS428N"",40.3920330340882,-86.8712553007159,0
f72514fc-5db1-428b-9811-8db61b775996,BUS256N,""State St & 18th St (NE Corner)"",""State St & 18th St (NE Corner) - BUS256N"",40.4063318911989,-86.8766452000526,0
017f0eed-8367-4398-a13e-29ee3a8ca255,BUS378NW,""(West of) Earl Ave & State St"",""(West of) Earl Ave & State St - BUS378NW"",40.4018566251908,-86.8698310476441,0
bc1e776d-5565-48ad-8b09-89956b22a623,BUS942,""Ottawa Dr & Summerfield Dr (SE Corner)"",""Ottawa Dr & Summerfield Dr (SE Corner) - BUS942"",40.3908998007118,-86.8708476049213,0
cb249812-e193-47f2-803a-2748653f2dd4,BUS731E,""(South of) Beck Ln & Commanche Tr"",""(South of) Beck Ln & Commanche Tr - BUS731E"",40.3878273301022,-86.8695641678312,0
b6f62d70-ad52-4581-acb8-d6d52c2159ef,BUS719,""Torchwood Dr & SR 25/38 (SW Corner)"",""Torchwood Dr & SR 25/38 (SW Corner) - BUS719"",40.3899154299447,-86.840868552975,0
44b3984f-3694-4ea2-98c5-25dd58d70c17,BUS736,""Yuma Ave & Commanche Tr (SE Corner)"",""Yuma Ave & Commanche Tr (SE Corner) - BUS736"",40.3847106030411,-86.8693415444697,0
baaadcc2-a55f-42af-86cc-7f691bbacddc,BUS742,""(West of) Tinkler St & Main St"",""(West of) Tinkler St & Main St - BUS742"",40.4186553012523,-86.8809716034515,0
cb48b9ed-ceb4-4775-9ad9-5379a29ca289,BUS739,""18th St & Shoshone Dr (NE Corner)"",""18th St & Shoshone Dr (NE Corner) - BUS739"",40.3936141963967,-86.876191906702,0
347b0fd1-24c9-40ac-86a0-a128f0f04686,BUS724E,""Congress St & 18th St (NE Corner)"",""Congress St & 18th St (NE Corner) - BUS724E"",40.4114938027557,-86.8768852577737,0
40f2d2d7-8b03-4bff-811e-7238cd05a2f9,BUS398,""10th St & Main St (NE Corner)"",""10th St & Main St (NE Corner) - BUS398"",40.4191528510542,-86.8856922915991,0
37e8492c-fb5a-4fe6-b894-36f00095df19,BUS142N,""Ivy Tech on Creasy Ln (across from Shelter)"",""Ivy Tech on Creasy Ln (across from Shelter) - BUS142N"",40.3855085602706,-86.8419132734486,0
7ce24533-02ee-4ec3-9cec-9e585a2a0306,BUS349,""8th St & Main St (NE Corner)"",""8th St & Main St (NE Corner) - BUS349"",40.4191662621001,-86.8877187006306,0
4503e459-c5dd-40fb-9ee1-a71fd554751a,BUS737,""Maumee Pl & Summerfield Dr (SE Corner)"",""Maumee Pl & Summerfield Dr (SE Corner) - BUS737"",40.3886883192472,-86.8707429987635,0
2fab4656-867b-4c5f-b6c6-35773a5cf0f3,BUS735E,""(South of) Shasta Dr & Commanche Tr"",""(South of) Shasta Dr & Commanche Tr - BUS735E"",40.3825085093086,-86.8690169971595,0
753af2ba-1b7b-4453-9e0d-5d4d8211ca61,BUS397SE,""11th St & Main St (at Trolley Station)"",""11th St & Main St (at Trolley Station) - BUS397SE"",40.4187934350248,-86.8848769000099,0
3451dc39-2a04-4a26-8e7e-1e8d6758c48e,BUS574,""First Street Towers on First St"",""First Street Towers on First St - BUS574"",40.4251382008277,-86.9237608864165,0
3122ee7a-b6c9-40cf-ad0d-087e96f61904,BUS587,""Pike St & Salisbury St (NW Corner)"",""Pike St & Salisbury St (NW Corner) - BUS587"",40.4654008427501,-86.9156552502904,0
e81995ac-59c1-4320-9fc5-e726ed2b1534,BUS130,""Westminster Village S & Salisbury (NW)"",""Westminster Village S & Salisbury (NW) - BUS130"",40.4570457611707,-86.915802771795,0
b5b9c1d8-bffa-4f35-897a-816f82b23425,BUS332NW,"" 3rd St & Russell St (NW Corner)"","" 3rd St & Russell St (NW Corner) - BUS332NW"",40.4275052504244,-86.919218565179,0
68c0b055-b94a-4077-83cd-eb402c2ea77a,BUS117SW,""Yeager Rd & Kalberer Rd (SW Corner)"",""Yeager Rd & Kalberer Rd (SW Corner) - BUS117SW"",40.467669991712,-86.9250671222846,0
e946343f-b71d-47b0-b2d3-8b18191d6e0a,BUS138NW,""(North of) Cumberland Ave & Salisbury St"",""(North of) Cumberland Ave & Salisbury St - BUS138NW"",40.4607901251787,-86.9156767079637,0
aa890e45-a19a-48a8-aa87-7ff16ff12e9b,BUS131W,""Westminster Village N & Salisbury (NW)"",""Westminster Village N & Salisbury (NW) - BUS131W"",40.458562550459,-86.9158658037106,0
1bb6c924-caea-4bea-91db-76ca8d3d4395,BUS612,""Kent Ave & Cumberland Ave (NE Corner) "",""Kent Ave & Cumberland Ave (NE Corner) - BUS612"",40.4610757804558,-86.9301512497754,0
ca9196a9-c571-47f8-8af7-5d1aca842faa,BUS644,""(South of) River Market on State St"",""(South of) River Market on State St - BUS644"",40.421565498207,-86.90325673838,0
9f19a341-8df9-463a-9bcb-b20b651d000a,BUS458,""Tapawingo Dr & State St (SW Corner)"",""Tapawingo Dr & State St (SW Corner) - BUS458"",40.4196959984121,-86.9007220507098,0
8cf48cf6-d169-43d1-aca1-7faf2db97f5b,BUS439,""(South of) Russell St & Stadium Ave"",""(South of) Russell St & Stadium Ave - BUS439"",40.4312214512361,-86.919225270702,0
a4a0c8ca-5c2d-4cc2-87b0-99f5d1f8dabe,BUS530N,""McDonalds on Stadium (North)"",""McDonalds on Stadium - BUS530N"",40.4315178353499,-86.9131742068037,0
8c460e09-7e21-4ce5-b337-061af83a1c7b,BUS111,""Lambert Fieldhouse on Stadium Ave"",""Lambert Fieldhouse on Stadium Ave - BUS111"",40.4314306635517,-86.9152529189141,0
a79677a8-3bcc-48a7-8d3c-c2811aec705e,BUS588,""LaGrange St & Salisbury St (NW Corner)"",""LaGrange St & Salisbury St (NW Corner) - BUS588"",40.4627964176414,-86.9156431803491,0
b3b59684-8c54-4175-987f-5df50466f929,BUS333NW,""Meridian St & Salisbury St (NW Corner)"",""Meridian St & Salisbury St (NW Corner) - BUS333NW"",40.4352930447634,-86.9059778395878,0
f527d8f5-d29c-4d8c-a52a-621f9d631d89,BUS365NW,""Lindberg Rd & Salisbury St (NW Corner)"",""Lindberg Rd & Salisbury St (NW Corner) - BUS365NW"",40.4457979169964,-86.9142497726828,0
aa7f1f55-2257-440f-b4df-1872716b070e,BUS924,""(South of) Riley Ln & Salisbury St"",""(South of) Riley Ln & Salisbury St - BUS924"",40.4431854452601,-86.9129985221027,0
f3309b2e-1493-4e22-935f-f4be1d63d892,BUS337S,""(South of) Grant St & Salisbury St"",""(South of) Grant St & Salisbury St - BUS337S"",40.4414688313883,-86.9105161375115,0
3ea98d8a-a41c-4e9d-92b4-e7183dd5b0c5,BUS634NE,""Stadium Ave & Grant St (NE Corner)"",""Stadium Ave & Grant St (NE Corner) - BUS634NE"",40.4309572536324,-86.9101875668876,0
98d55104-2bee-4e96-bd0f-fc802be1230d,BUS149,""Kent Ave & Salisbury St (SW Corner)"",""Kent Ave & Salisbury St (SW Corner) - BUS149"",40.4549134048768,-86.9159087190574,0
b3eb08fe-e33e-48cc-8b2e-c3fc1aa7af9b,BUS635NE,""Vine St & Stadium Ave (NE Corner)"",""Vine St & Stadium Ave (NE Corner) - BUS635NE"",40.4309572536324,-86.9078889136248,0
061dcdae-afaa-4290-98fa-9509e0e4a0b2,BUS637NW,""Rockland Dr & Salisbury St (NW Corner)"",""Rockland Dr & Salisbury St (NW Corner) - BUS637NW"",40.4389515780778,-86.9077816252578,0
52ea0f15-9058-4241-a936-487c0d14dab5,BUS224,""Leslie Ave & Salisbury St (NW Corner)"",""Leslie Ave & Salisbury St (NW Corner) - BUS224"",40.4367454610315,-86.9061012212098,0
344c9ef4-94c0-47b2-9bca-cd3f0f635129,BUS291NW,""Stadium Ave & Salisbury St (NW Corner)"",""Stadium Ave & Salisbury St (NW Corner) - BUS291NW"",40.4310632008948,-86.9058477524428,0
98d717c6-5930-414e-9d4b-6daf791c70a7,BUS293,""(South of) Navajo St & Salisbury St"",""(South of) Navajo St & Salisbury St - BUS293"",40.451639768579,-86.9158389816188,0
82e235da-54de-483d-a83d-5ce5a38de0cd,BUS633NW,""Sycamore Ln & Salisbury St (NW Corner)"",""Sycamore Ln & Salisbury St (NW Corner) - BUS633NW"",40.4479316143949,-86.9160589227712,0
b97042a5-1f80-4b89-b42d-e445e298c163,BUS636NW,""Dehart St & Salisbury St (NW Corner)"",""Dehart St & Salisbury St (NW Corner) - BUS636NW"",40.4328120012767,-86.9059027377309,0
b01f61ea-fa3c-49bd-9f9e-8784232dd76d,BUS104S,""(East of) Anthrop Dr & Yeager (at Shelter)"",""(East of) Anthrop Dr & Yeager (at Shelter) - BUS104S"",40.4517872900836,-86.924022401811,0
15e391ad-a9c5-4961-8c5d-fc388e55d631,BUS476,""Carrolton Blvd & Northwestern (NW Corner)"",""Carrolton Blvd & Northwestern (NW Corner) - BUS476"",40.4417960609076,-86.919202471924,0
730ca5ad-c22a-4b01-a6cf-e9afe7165604,BUS112NE,""Morehouse Rd & Mason Dixon Dr (NE Corner)"",""Morehouse Rd & Mason Dixon Dr (NE Corner) - BUS112NE"",40.4778892086678,-86.9387450479713,0
280e6834-5374-4f93-a50a-0bcc8c11f00b,BUS102NW,""Carlisle Rd & Lindberg Rd (NW Corner)"",""Carlisle Rd & Lindberg Rd (NW Corner) - BUS102NW"",40.4460178581487,-86.9194908094103,0
86a37117-34d8-4e5f-8b9c-f16c185eb4eb,BUS114W,""Country Squire Apts on Morehouse"",""Country Squire Apts on Morehouse - BUS114W"",40.4692001920462,-86.9389730357512,0
de74ae3d-9ab1-44e8-aa67-a45bd359e150,BUS113NW,""Ellison Dr & Morehouse Rd"",""Ellison Dr & Morehouse Rd - BUS113NW"",40.4708054942373,-86.9391031228961,0
cac65603-9c37-42c8-851f-f0323408b8e1,BUS375NE,""(East of) Northwestern & Lindberg"",""(East of) Northwestern & Lindberg - BUS375NE"",40.4461398986661,-86.9210599017775,0
d08156de-30cf-40f9-9712-e2fc706372d7,BUS623NW,""Windsor Dr & Carlisle Rd (NW Corner)"",""Windsor Dr & Carlisle Rd (NW Corner) - BUS623NW"",40.4481180279325,-86.9196678352158,0
81c4971d-2cb8-4938-9ca9-f0f43a7b3887,BUS631W,""Abnaki Dr & Morehouse Rd"",""Abnaki Dr & Morehouse Rd - BUS631W"",40.474560587082,-86.9391567670796,0
287e17e9-a0f5-4d5c-b003-288b1465e8f2,BUS115S,""(East of) Morehouse Rd & Kalberer Rd"",""(East of) Morehouse Rd & Kalberer Rd - BUS115S"",40.4675734321817,-86.9383963607786,0
024af5f4-2201-4510-8b4f-0e710d7dec8f,BUS375SW,""(Southwest of) Northwestern Ave & Lindberg Rd"",""(Southwest of) Northwestern & Lindberg Rd - BUS375SW"",40.4458126691468,-86.921597684717,0
8095c21f-63cb-4eb6-9d26-020ab67a0981,BUS101SW,""Mayfair Village Apts on Sycamore Ln"",""Mayfair Village Apts on Sycamore Ln - BUS101SW"",40.4519187183332,-86.9218712700529,0
19afa57a-5f03-4465-8e16-3bcd93025d85,BUS624W,""(West of) Carlisle Rd & Sycamore Ln"",""(West of) Carlisle Rd & Sycamore Ln - BUS624W"",40.4504810542155,-86.9196517419608,0
343e32bd-ccce-4ef6-bae3-2ce7d0b706f8,BUS632NW,""Garden St & Northwestern Ave (NW Corner)"",""Garden St & Northwestern Ave (NW Corner) - BUS632NW"",40.4427603151059,-86.919647718647,0
e6ed5f6d-6232-40dc-bc04-88e3501233db,BUS945SW,""Kent Ave & Kalberer Rd (SW Corner)"",""Kent Ave & Kalberer Rd (SW Corner) - BUS945SW"",40.4676203708422,-86.9319885630601,0
d525c626-ee6b-4f2e-9cef-a35d72f24a73,BUS169,""Chelsea Rd & Northwestern Ave (West Side)"",""Chelsea Rd & Northwestern Ave (West Side) - BUS169"",40.4346949121174,-86.9154084870463,0
9647c23c-5174-4965-9c37-d87cf3b02ceb,BUS100W,""Beau Jardin Apts on Yeager (at Shelter)"",""Beau Jardin Apts on Yeager Rd (at Shelter) - BUS100W"",40.454594221985,-86.9247318461378,0
2abcf126-35e2-48bd-a219-3ea2b14b0066,BUS431,""(South of) Cherry Ln & Northwestern Ave"",""(South of) Cherry Ln & Northwestern Ave - BUS431"",40.4387973510502,-86.917314196665,0
7ad8b869-acdc-4cae-ae14-fcd94702065e,BUS157,""Shining Armor Ln & Roundtable Dr(SW Corner)"",""Shining Armor Ln & Roundtable Dr(SW Corner) - BUS157"",40.4808450031784,-86.9311771947847,0
eb2add03-3a8e-4317-b911-ca1f22b90958,BUS630,""Military Ct & Mason Dixon Dr (NE Corner)"",""Military Ct & Mason Dixon Dr (NE Corner) - BUS630"",40.4778771387265,-86.936568435226,0
acf15732-648c-4574-9b0a-fad1bf5f2723,BUS944S,""West View Apts on Kalberer Rd (South)"",""West View Apts on Kalberer Rd (South) - BUS944S"",40.4675935487505,-86.9340632518568,0
9aae2fce-2846-4aee-86e6-14bb7b11e403,BUS118NW,""McClure Ave & Yeager Rd (NW Corner)"",""McClure Ave & Yeager Rd (NW Corner) - BUS118NW"",40.4652948954877,-86.9249155774662,0
facd3633-a9f2-45f1-bfa7-4e831a6e2a0c,BUS110NE,""Mason Dixon Dr & Shining Armor(NE Corner)"",""Mason Dixon Dr & Shining Armor(NE Corner) - BUS110NE"",40.4794556188259,-86.9343059917871,0
4105eecb-550d-4bc3-8e80-0308dc29177e,BUS626SW,""Montgomery St & Yeager Rd (SW Corner)"",""Montgomery St & Yeager Rd (SW Corner) - BUS626SW"",40.4584311222095,-86.9248847320607,0
cc381564-9cfc-4de1-9217-3adbb2903d8e,BUS901,""Hillcrest Rd & Northwestern (SE Corner)"",""Hillcrest Rd & Northwestern (SE Corner) - BUS901"",40.4403731489404,-86.9181657980779,0
a12d8422-7d88-41ea-b209-71ec579800f9,BUS626SE,""Montgomery St & Yeager Rd (SE Corner)"",""Montgomery St & Yeager Rd (SE Corner) - BUS626SE"",40.4582849418095,-86.9243469491212,0
ca6e876a-f4dc-4612-831f-46acd454ed59,BUS101NE,""Mayfair Village Apts on Sycamore Ln"",""Mayfair Village Apts on Sycamore Ln - BUS101NE"",40.4521748693094,-86.9216057313446,0
bed6bade-b8a7-43c8-9132-634c3ef5ed09,BUS624E,""Sycamore Ln & Carlisle Rd (SE Corner)"",""Sycamore Ln & Carlisle Rd (SE Corner) - BUS624E"",40.4502047866705,-86.9192748915717,0
1e0d5c66-235d-4980-b1a2-aec6be213bb7,BUS623SE,""Windsor Dr & Carlisle Rd (SE Corner)"",""Windsor Dr & Carlisle Rd (SE Corner) - BUS623SE"",40.4477961628316,-86.9193245124414,0
df471617-7f3e-4e35-89f1-a34317c2b01d,BUS290,""Grant St & Williams St (NE Corner)"",""Grant St & Williams St (NE Corner) - BUS290"",40.418565447245,-86.9101768380509,0
bedba372-2db5-4d9c-a594-630cf5a0f5d1,BUS522,""(West of) Salisbury St & Williams St"",""(West of) Salisbury St & Williams St - BUS522"",40.4184916864927,-86.9080310707111,0
95f1a63d-f6a6-4d5a-b1d8-4d35adaaabce,BUS631E,""Abnaki Dr & Morehouse Rd"",""Abnaki Dr & Morehouse Rd - BUS631E"",40.4745485171406,-86.938716884775,0
586bf2ad-5b91-4bc6-9f1a-42fa2180cc7c,BUS632SE,""Garden St & Northwestern Ave (SE Corner)"",""Garden St & Northwestern Ave (SE Corner) - BUS632SE"",40.4426543678435,-86.919111276812,0
2f1859d9-cb36-46fc-b946-4b9930e779f4,BUS203,""Northridge Dr & Northwestern (SE Corner)"",""Northridge Dr & Northwestern (SE Corner) - BUS203"",40.4367950819013,-86.9154983410536,0
9184f0a6-e386-436a-b5ae-7813597e21fe,BUS284,""Meridian St & Northwestern (SE Corner)"",""Meridian St & Northwestern (SE Corner) - BUS284"",40.4338754972145,-86.9150530943306,0
3ac1a9f2-a203-4013-85f5-e258c083c972,BUS320,""Grant St & Wood St (SE Corner)"",""Grant St & Wood St (SE Corner) - BUS320"",40.4220845056822,-86.9102854675225,0
de20544e-4e12-401a-b6ea-21c99ed1cc93,BUS294,""(South of) Grant St & Harrison St"",""(South of) Grant St & Harrison St - BUS294"",40.4202378046654,-86.9102076834564,0
4f56d398-f906-4dfd-9dcb-25dcb46b8b44,BUS100E,""Beau Jardin Apts on Yeager (SE Corner)"",""Beau Jardin Apts on Yeager Rd (SE Corner) - BUS100E"",40.4543327065905,-86.92436706569,0
7086a1d1-2692-479b-b3ba-6dadf0bb5ba9,BUS113NE,""Ellison Dr & Morehouse Rd"",""Ellison Dr & Morehouse Rd - BUS113NE"",40.470809517551,-86.9386739694282,0
746698f8-e2f9-4713-8c99-e37ef4a2a9a2,BUS110SE,""Shining Armor Ln & Mason Dixon(SE Corner)"",""Shining Armor Ln & Mason Dixon(SE Corner) - BUS110SE"",40.4791793512809,-86.9345259329394,0
3df01643-04ad-454d-8261-55b5f90ec1fa,BUS627,""Vicksburg Ln & Mason Dixon Dr (SW Corner)"",""Vicksburg Ln & Mason Dixon Dr (SW Corner) - BUS627"",40.4776987718164,-86.936246570125,0
ef05efd6-5990-4c7f-a4a7-86c7d5107a19,BUS115N,""(East of) Morehouse Rd & Kalberer Rd"",""(East of) Morehouse Rd & Kalberer Rd - BUS115N"",40.4679636936166,-86.9385452233878,0
97cc4a97-403f-4768-91bb-9b5bb7cf54d6,BUS114E,""Country Squire Apts on Morehouse"",""Country Squire Apts on Morehouse - BUS114E"",40.4692001920462,-86.9385036491456,0
6c820db5-9ceb-4e74-8bc5-8f8746d16bfe,BUS112SE,""(East of) Morehouse Rd on Mason Dixon Dr"",""(East of) Morehouse Rd on Mason Dixon Dr - BUS112SE"",40.4776706086201,-86.9385036491456,0
70660901-9ea5-4ca1-b4c6-d41aa19560cc,BUS628,""Roundtable Dr & Mason Dixon Dr (SE Corner)"",""Roundtable Dr & Mason Dixon Dr (SE Corner) - BUS628"",40.4808329332371,-86.9345540961357,0
d03643db-aa0f-486d-8a10-685598ae35ee,BUS117SE,""(South of) Kalberer Rd & Yeager Rd"",""(South of) Kalberer Rd & Yeager Rd - BUS117SE"",40.4676538984569,-86.9242128386624,0
c970ad79-bb17-4882-bb52-5b3fbaff5234,BUS104N,""Yeager Rd & Anthrop Dr (NE Corner)"",""Yeager Rd & Anthrop Dr (NE Corner) - BUS104N"",40.4521024496616,-86.9243737712129,0
f24f8010-cc38-4494-9776-7b23862663c7,BUS102NE,""(North of) Carlisle Rd & Lindberg Rd"",""(North of) Carlisle Rd & Lindberg Rd - BUS102NE"",40.4460956422147,-86.9191045712891,0
67a6aa6a-36ed-4ce3-8a7d-98d4c616c2ce,BUS375SE,""(East of) Northwestern & Lindberg"",""(East of) Northwestern & Lindberg - BUS375SE"",40.4458193746698,-86.9210813594509,0
2ad6f7eb-6288-4e8f-96fe-9b47c74c0c37,BUS118SW,""McClure Ave & Yeager Rd (SW Corner)"",""McClure Ave & Yeager Rd (SW Corner) - BUS118SW"",40.464692739528,-86.9249477639763,0
2d89e00c-532d-41ef-9ccd-7523418a52cf,BUS126,""(Southeast of) Northwestern & Lindberg Rd"",""(Southeast of) Northwestern & Lindberg Rd - BUS126"",40.4452319708605,-86.9210143042215,0
0e46be42-9d2b-48c7-b21b-d7ca546c1d31,BUS945NE,""Kent Ave & Kalberer Rd (NE Corner)"",""Kent Ave & Kalberer Rd (NE Corner) - BUS945NE"",40.4680119733818,-86.9315392930233,0
450566f0-65cb-4cdf-b1f5-bc169288802a,BUS186,""River Rd & Williams St (NW Corner)"",""River Rd & Williams St (NW Corner) - BUS186"",40.4184822987606,-86.9066094998484,0
6c5b1d3e-8d53-462a-a34f-21ecdb403ec1,BUS489,""Wood St & River Rd (SW Corner)"",""Wood St & River Rd (SW Corner) - BUS489"",40.4203933727976,-86.9055500272244,0
3e4fc535-b4dd-4ec4-8c6d-4cd8ce2fc2fb,BUS944N,""West View Apts on Kalberer Rd (North)"",""West View Apts on Kalberer Rd (North) - BUS944N"",40.4680039267542,-86.9340793451118,0
af4247e4-42bb-454a-ad3b-1e1a8fefd606,BUS617,""(West of) Solders Home Rd & Kalberer Rd"",""(West of) Solders Home Rd & Kalberer Rd BUS617"",40.4688863735727,-86.9003170371244,0
f8e7ff5c-1f0f-411a-85c8-1a9682e61121,BUS936NE,""(North of) Overlook Dr & Soldiers Home"",""(North of) Overlook Dr & Soldiers Home Rd - BUS936NE"",40.4608075595383,-86.900923216398,0
6943277e-bd6f-40eb-92f1-fb3d850f74ae,BUS614,""Indian Rock Dr & Soldiers Home (SE Corner)"",""Indian Rock Dr & Soldiers Home (SE Corner) - BUS614"",40.4645492413371,-86.8994788467574,0
bc448a38-ca06-4ff0-96e5-773f326e261a,BUS153,""Greentree on Kalberer Rd (NE Corner)"",""Greentree on Kalberer Rd (NE Corner) - BUS153"",40.4689681809526,-86.9142631837286,0
352057c7-7411-400b-bbef-8acc01cc4ef4,BUS600N,""(North of) Catherwood Dr & Happy Hollow"",""(North of) Catherwood Dr & Happy Hollow - BUS600N"",40.4371008537472,-86.8993031620564,0
ddb3d513-2b3b-4f2a-84ad-a6462e2b1740,BUS615SE,""Tamiami Tr & Soldiers Home Rd (SE Corner)"",""Tamiami Tr & Soldiers Home Rd (SE Corner) - BUS615SE"",40.4661317447502,-86.8993822872271,0
6b105995-35c1-4655-ab93-2e1a4abd73e8,BUS928SE,""Veterans Home Entrance on Soldiers Home"",""Veterans Home Entrance on Soldiers Home - BUS928SE"",40.4743111416287,-86.8956459698466,0
95d0f752-c29d-4882-bc9a-ec362b7e8bea,BUS927SE,""Broadview Rd & Soldiers Home(SE Corner)"",""Broadview Rd & Soldiers Home (SE Corner) - BUS927SE"",40.4725046737495,-86.8964144227752,0
3d25edb5-f94d-4381-a0d5-a1b483f792ee,BUS613,""Hartman Ct & Soldiers Home Rd (SE Corner)"",""Hartman Ct & Soldiers Home Rd (SE Corner) - BUS613"",40.4594919359381,-86.9014247895136,0
a3a257be-b138-4cb6-8314-9c0e32c0cc8f,BUS616,""Heritage Health Care on Soldiers Home Rd"",""Heritage Health Care on Soldiers Home Rd (NE Corner) - BUS616"",40.4679824690808,-86.8994171559463,0
9746ef91-b178-4ba7-ac04-f30a12e70211,BUS930,""Dehart Hall at Indiana Veterans Home"",""Dehart Hall at Indiana Veterans Home - BUS930"",40.47264,-86.88863,0
23313c2f-8727-45dd-9f84-262753cfe9a0,BUS619,""Cardigan Ln & Kalberer Rd (NE Corner)"",""Cardigan Ln & Kalberer Rd (NE Corner) - BUS619"",40.4689131956645,-86.9050860050372,0
0a95d4d3-0812-4829-b7dc-1de1414c6c7a,BUS618,""Westmorland & Kalberer Rd (NE Corner)"",""Westmorland & Kalberer Rd (NE Corner) - BUS618"",40.4689306300241,-86.9026116670735,0
ef3f5ca0-d6e1-44f7-9f3c-bba2b43f6b62,BUS929,""Lincoln Hall at Indiana Veterans Home"",""Lincoln Hall at Indiana Veterans Home - BUS929"",40.47294,-86.89131,0
3fa1ad97-9415-41f4-adbd-6e314ac6f924,BUS932,""Pyle Hall at Indiana Veterans Home"",""Pyle Hall at Indiana Veterans Home - BUS932"",40.47173,-86.89174,0
e26f0c2b-1c8c-4379-b246-665f907b1bab,BUS621,""Calvary Baptist on Kalberer Rd"",""Calvary Baptist on Kalberer Rd - BUS621"",40.4689279478149,-86.9128054030422,0
31e07cc4-791e-4072-8289-864aa07757ec,BUS599E,""Laurel Dr & Happy Hollow Rd (SE Corner)"",""Laurel Dr & Happy Hollow Rd (SE Corner) - BUS599E"",40.4441014196933,-86.8994064271096,0
bbb10d07-d0d9-4419-9ead-1c88da65057d,BUS145E,""(North Drive) Williamsburg Apts(SE Corner)"",""(North Drive) Williamsburg Apts(SE Corner) - BUS145E"",40.43195637655,-86.8988485276013,0
e37d85ab-ce1f-4402-8546-139be5111457,BUS927NW,""Broadview Rd & Soldiers Home(NW Corner)"",""Broadview Rd & Soldiers Home (NW Corner) - BUS927NW"",40.4728372676872,-86.8968140719422,0
0575b6c9-dff0-4e1e-ba5d-6b00e32af071,BUS931,""Mitchell Hall at Indiana Veterans Home"",""Mitchell Hall at Indiana Veterans Home - BUS931"",40.47079,-86.88993,0
7b4f6912-cdc7-41b9-b1c4-8580e33b680b,BUS928NE,""Veterans Home Entrance (North Side)"",""Veterans Home Entrance (North Side) - BUS928NE"",40.4744372054599,-86.8951685366135,0
e7abd428-3117-4018-aae8-39dcb0fd4b2b,BUS933,""Ingersol Hall at Indiana Veterans Home"",""Ingersol Hall at Indiana Veterans Home - BUS933"",40.473149745056,-86.8924474354057,0
f7d2398c-1540-4d5f-af51-eb83dd415eca,BUS620,""Wakefield/Laporte & Kalberer Rd (NE Corner)"",""Wakefield/Laporte & Kalberer Rd (NE Corner) - BUS620"",40.4689306300241,-86.9096739238306,0
dcfb8954-7705-4958-b47a-f1caef7464d0,BUS123E,""Nobb Hill Apts on Happy Hollow"",""Nobb Hill Apts on Happy Hollow - BUS123E"",40.4395926260706,-86.8990523754986,0
39df1e4b-8242-403f-87d0-f04234ae5296,BUS460,""(South Drive) Williamsburg Apts (SE Corner)"",""(South Drive) Williamsburg Apts (SE Corner) - BUS460"",40.4304945725498,-86.8995700418693,0
b059e195-baba-4377-9f24-b4c8bd5a915d,BUS602E,""(North of) River Rd & Robinson St"",""(North of) River Rd & Robinson St - BUS602E"",40.4282307880062,-86.9006067157153,0
d92544e1-c9ae-4d4d-8269-6676ec9c1569,BUS605,""Happy Hollow Rd & Hollowood Dr (SE Corner)"",""Happy Hollow Rd & Hollowood Dr (SE Corner) - BUS605"",40.4433329667648,-86.8994010626913,0
403a4107-aadc-4322-a425-475df1441f0c,BUS951,""Salisbury St & Wiggins St (SW Corner)"",""Salisbury St & Wiggins St (SW Corner) - BUS951"",40.4265664772133,-86.905704254252,0
42632271-af23-41f3-8470-64e8e791a105,BUS361SE,""Chippewa & Happy Hollow Rd (SE Corner)"",""Chippewa & Happy Hollow Rd (SE Corner) - BUS361SE"",40.4498453706411,-86.9006214678658,0
1a0146b1-c9fb-44e4-a58e-b0caac636196,BUS597E,""Pathway Ln & Happy Hollow Rd (SE Corner)"",""Pathway Ln & Happy Hollow Rd (SE Corner) - BUS597E"",40.4463947085378,-86.8991489350288,0
1003336c-8150-402c-943a-154a47cbcc24,BUS124,"" Quincy St & River Rd (at Shelter)"","" Quincy St & River Rd (at Shelter) - BUS124"",40.427314,-86.901463,0
b55a715e-44cd-403b-b4e4-48b4a2cca718,BUS597W,""(South of) Pathway Ln & Happy Hollow Rd"",""(South of) Pathway Ln & Happy Hollow Rd - BUS597W"",40.4464121428974,-86.8995901584381,0
1131047c-9d85-4b36-8510-249a7d5fabb1,BUS599W,""(South of) Laurel Dr & Happy Hollow Rd"",""(South of) Laurel Dr & Happy Hollow Rd - BUS599W"",40.4441094663208,-86.8998369216822,0
3c9340e0-92cf-4014-8812-b9d7a62e148f,BUS580W,""(South of) Howard Ave & River Rd"",""(South of) Howard Ave & River Rd - BUS580W"",40.4234269513742,-86.9035826267947,0
8a20ce1f-043a-40de-93d5-9350eaea1142,BUS590,""Wilshire Ave & Cumberland Ave (SW Corner)"",""Wilshire Ave & Cumberland Ave (SW Corner) - BUS590"",40.4603140330502,-86.9130655773321,0
597d352a-2c58-4f74-86c1-8839380f3cff,BUS592,""Bristol Ct & Cumberland Ave (SW Corner)"",""Bristol Ct & Cumberland Ave (SW Corner) - BUS592"",40.4596716439528,-86.9039366784058,0
d880e745-5c0b-4d3d-b521-5a37464a4279,BUS595W,""Parkway Apts on Happy Hollow"",""Parkway Apts on Happy Hollow - BUS595W"",40.451317903478,-86.9023729504569,0
1bed3880-2aff-487f-b59c-eca6524ed9d9,BUS602W,""River Rd & Robinson St (NW Corner)"",""River Rd & Robinson St (NW Corner) - BUS602W"",40.4287109034485,-86.900832021286,0
27fbc388-9fe2-4d54-a09e-b55f8c2de5cb,BUS145W,""Williamsburg Apts (North)"",""Williamsburg Apts (North) - BUS145W"",40.4318209249866,-86.8994439780381,0
360aebf1-81fb-467e-9659-e1c678f710a3,BUS361NW,""Chippewa St & Happy Hollow Rd (NW Corner)"",""Chippewa St & Happy Hollow Rd (NW Corner) - BUS361NW"",40.4500720173163,-86.901361757598,0
6f76eb71-2396-4c7a-88fe-b9f80bfda78d,BUS954,""(East of) Arbor Ct & Cumberland Ave"",""(East of) Arbor Ct & Cumberland Ave - BUS954"",40.4593444144335,-86.9027739407285,0
bacc29b3-b802-43cb-86c6-762d09241a14,BUS586,""Henderson St & Cumberland Ave (SW Corner)"",""Henderson St & Cumberland Ave (SW Corner) - BUS586"",40.4603234207823,-86.9068643097201,0
ab22905e-6ce3-4949-a180-93d8aa0062a7,BUS959,""(South of) Linda Ln & Soldiers Home Rd"",""(South of) Linda Ln & Soldiers Home Rd - BUS959"",40.457256314591,-86.9027538241597,0
ef749d27-500d-4225-80c2-5031179c6647,BUS144W,""Parkway Apts on Soldiers Home Rd (at Shelter)"",""Parkway Apts on Soldiers Home Rd (at Shelter) - BUS144W"",40.4544292661207,-86.9033144058772,0
958b7887-5bfd-4ad5-a21d-a3618595eec5,BUS953,""Linda Ln & Cumberland Ave (SW Corner)"",""Linda Ln & Cumberland Ave (SW Corner) - BUS953"",40.4600726342244,-86.905106121606,0
89bf3983-246b-43e5-be0c-419c532bd5aa,BUS600E,""(East of) Catherwood Dr & Happy Hollow Rd"",""Jischke Dr & 1st St (NW Corner) - BUS584NW"",40.4368943236407,-86.8981350599608,0
a0e06e02-f824-4b56-8892-969d1906de04,BUS589,""(West of) Covington St & Cumberland Ave"",""(West of) Covington St & Cumberland Ave - BUS589"",40.4603475606649,-86.9144335040112,0
ad0feb83-6ad0-4671-88c2-a180a355afb6,BUS591S,""Barlow St & Cumberland Ave (SW Corner)"",""Barlow St & Cumberland Ave (SW Corner) - BUS591S"",40.4603019631089,-86.9094083851223,0
1b556dec-e988-4d80-a503-61621c4fbe21,BUS267S,""Soldiers Home Rd & Cumberland"",""Soldiers Home Rd & Cumberland (SW Corner) - BUS267S"",40.459060100261,-86.9018418730403,0
e560bcde-7010-4485-b8bc-f8d5bbc05081,BUS596,""Happy Hollow Rd & Knox Dr (NW Corner)"",""Happy Hollow Rd & Knox Dr (NW Corner) - BUS596"",40.4481622843839,-86.899811440695,0
23029483-fbae-479f-95a4-c89b0ed96301,BUS123W,""Nobb Hill Apts on Happy Hollow"",""Nobb Hill Apts on Happy Hollow - BUS123W"",40.4396060371164,-86.8995311498362,0
f17a1603-4006-4b3d-ac36-4a0ac1517b8b,BUS422W,""(Northwest of) 9th St & Canal Rd"",""(Northwest of) 9th St & Canal Rd - BUS422W"",40.4340726395889,-86.8876824908067,0
a15b5543-c327-4758-add4-42c40eed2fdc,BUS143,""CityBus Offices"",""CityBus Offices - BUS143"",40.429116,-86.891767,0
837173c8-3b59-4a58-a134-cf3ac053dcae,BUS422E,""(Southwest of) 9th St & Canal Rd"",""(Southwest of) 9th St & Canal Rd - BUS422E"",40.4338567217503,-86.8873163692544,0
be2e623f-6ce3-41a0-baab-ef5cdf4ef998,BUS958,""Jeremiah & Elijah (NW Corner)"",""Jeremiah & Elijah (NW Corner) - BUS958"",40.48371,-86.89325,0
6915d831-14f5-46b7-bf4f-5e250bb15912,BUS957,""Jeremiah & Isaiah (NE Corner)"",""Jeremiah & Isaiah (NE Corner) - BUS957"",40.48616,-86.89327,0
564c30ed-ad04-4837-940d-bc9de55bea35,BUS912,""2nd St & Owen St (SW Corner)"",""2nd St & Owen St (SW Corner) - BUS912"",40.405044430795,-86.8953844544521,0
7bbff08d-2b44-4014-bbc7-dcd8a1ec23c0,BUS657,""(South of) Holloway Dr & Washington St"",""(South of) Holloway Dr & Washington St - BUS657"",40.4067369047843,-86.8977152942249,0
5f9a23af-17ff-4c3d-9977-ae67d0565c8a,BUS395SW,""Owen St & 4th St (SW Corner)"",""Owen St & 4th St (SW Corner) - BUS395SW"",40.4049813988794,-86.8932225938572,0
7608fbce-c6ca-43ee-8203-c1d4d9c26d43,BUS911,""Joseph St & Washington St (NW Corner)"",""Joseph St & Washington St (NW Corner) - BUS911"",40.4083073382561,-86.8966920314248,0
37afc646-5783-44fb-8f1d-52bf1a524b9f,BUS658,""CR 10 W & Twyckenham Blvd (SW Corner)"",""CR 10 W & Twyckenham Blvd (SW Corner) - BUS658"",40.3846301367658,-86.906809324432,0
dbad8596-7b02-4404-ba45-083e646719eb,BUS264W,""Montefiore St & 4th St (NW Corner)"",""Montefiore St & 4th St (NW Corner) - BUS264W"",40.4018807650733,-86.8932628269948,0
ece51f97-ede2-43e4-acd9-1fcd39b1de8f,BUS121NW,""Murphy St & 4th St (NW Corner)"",""Murphy St & 4th St (NW Corner) - BUS121NW"",40.4035893323177,-86.8932628269948,0
d0c3e6d8-27d3-4485-8e5b-2bb34290a241,BUS648,""Alabama St & 3rd St (SW Corner)"",""Alabama St & 3rd St (SW Corner) - BUS648"",40.4162654528776,-86.8948426481988,0
2e567210-3d5f-4a55-a75d-85db421d4fae,BUS649,""Fountain St & 3rd St (SW Corner)"",""Fountain St & 3rd St (SW Corner) - BUS649"",40.4126431293871,-86.8943638738611,0
af7bf4bf-ac5d-4125-bbd2-d699f97de6e3,BUS356,""Romig St & 3rd St (SW Corner)"",""Romig St & 3rd St (SW Corner) - BUS356"",40.4138286658424,-86.8944684800189,0
b85432ea-0f90-475f-b37b-a64dc32c3c97,BUS310,""Kossuth St & 3rd St (NW Corner)"",""Kossuth St & 3rd St (NW Corner) - BUS310"",40.41000115335,-86.8944684800189,0
87e40553-f915-44ee-b808-ee450fd409ca,BUS424,""(North of) Holloway Dr & Owen St"",""(North of) Holloway Dr & Owen St - BUS424"",40.405313992817,-86.8977139531204,0
56efcf23-c807-47c1-9995-902d8342ae65,BUS652W,""Williams Ridge/Saw Mill Rd & 4th St"",""Williams Ridge/Saw Mill Rd & 4th St - BUS652W"",40.3990148245701,-86.8943571683381,0
afcd1a80-d4b7-44ff-987d-5b6156ed0cb0,BUS147,""Old Romney Rd & Elston Rd (NE Corner)"",""Old Romney Rd & Elston Rd (NE Corner) - BUS147"",40.393396,-86.913419,0
cef5563b-1785-4a50-b0d4-d05e7524768d,BUS653NE,""Windy Hill Dr & Old US 231S (NE Corner)"",""Windy Hill Dr & Old US 231S (NE Corner) - BUS653NE"",40.3945033487381,-86.9001547634694,0
84d0832c-b75e-4924-a361-0e949772bebe,BUS261,""(North of) Teal Rd & 4th St"",""(North of) Teal Rd & 4th St - BUS261"",40.3963782129513,-86.8956566986833,0
634a4710-c4e2-4f8a-9410-72b5ceedf8a7,BUS211,""(East of) Old Romney Rd & Twyckenham Blvd"",""(East of) Old Romney Rd & Twyckenham Blvd - BUS211"",40.3846743932172,-86.9107360786638,0
90548a56-6eba-45f5-8638-def60bdd6437,BUS159,""Old Romney Rd at SR 25 (NW Corner)"",,40.3891858690492,-86.913033390822,0
fa7a1ffa-1723-4a3b-b66b-870bc00ce12b,BUS654,""Powder House Ln & Elston Rd (NE Corner)"",""Powder House Ln & Elston Rd (NE Corner) - BUS654"",40.3928765888737,-86.9072639588871,0
90b18e49-6b75-4756-8f4f-2af76176cb07,BUS270,""(West of) Beck Ln & Elston Rd"",""(West of) Beck Ln & Elston Rd - BUS270"",40.393181019615,-86.9106904811079,0
6c0dd826-d4e3-4536-827f-f854a0c39d38,BUS212,""Claystone Apts on Old Romney (at Shelter)"",""Claystone Apts on Old Romney (at Shelter) - BUS212"",40.3870012096763,-86.9121241219118,0
8723107b-5764-43b1-ba5f-9524b2fb91d0,BUS254,""Anderson Furniture on Elston Rd"",""Anderson Furniture on Elston Rd - BUS254"",40.3925842280736,-86.9038146378884,0
8fbaeaba-1010-4055-a2bf-58bec43ca0e4,BUS655,""Elston Point Apts on Elston Rd(NE Corner)"",""Elston Point Apts on Elston Rd (NE Corner) - BUS655"",40.393363,-86.91248,0
61e2bc56-e05c-4db9-bce6-0278580cca61,BUS466W,""JR Hiatt Dr & 22nd St (NW Corner)"",""JR Hiatt Dr & 22nd St (NW Corner) - BUS466W"",40.3977836905589,-86.8720505757362,0
6239eb1f-4dca-45b0-8593-5dc90d2bb1c7,BUS132,""Rainbow Dr & Elmwood Ave (SW Corner)"",""Rainbow Dr & Elmwood Ave (SW Corner) - BUS132"",40.4291400569165,-86.8717582149362,0
67aa9eac-3568-4940-bd5d-770793f65115,BUS938,""(West of) 27th St & Elmwood Ave"",""(West of) 27th St & Elmwood Ave - BUS938"",40.4319402832949,-86.8659954885242,0
c86f50e6-bd9c-4dad-bc7e-113f4b45a538,BUS247,""Dollar General at Market Square"",,40.43104,-86.87008,0
a1265a65-093b-489f-bb1e-cc719f0b9d45,BUS839,""(North of) 18th St & Salem St"",""(North of) 18th St & Salem St - BUS839"",40.425894583815,-86.8774082885628,0
43447498-4695-43de-b044-e68b88497534,BUS312,""Greenbush St & Melbourne Rd (at Shelter)"",""Greenbush St & Melbourne Rd (at Shelter) - BUS312"",40.4322903115922,-86.868027261974,0
6724c3b0-2f75-4374-8e48-26ccf752376e,BUS276,""Vinton St & Elmwood Ave  (SE Corner)"",""Vinton St & Elmwood Ave  (SE Corner) - BUS276"",40.434251006499,-86.8636311211366,0
c3a83a1c-03b5-4a9a-8f93-8d4a11b6fa69,BUS822,""(East of) 15th St & Union St"",""(East of) 15th St & Union St - BUS822"",40.4246071234111,-86.8809353936276,0
bd70e5a5-c77e-4530-a594-d9ee8e859824,BUS209,""Underwood St & Elmwood Ave (SE Corner)"",""Underwood St & Elmwood Ave (SE Corner) - BUS209"",40.4377901815051,-86.8621290839987,0
91dfd357-9b73-4711-91e6-7aefcbb63b21,BUS441,""18th St & Union St (SW Corner)"",""18th St & Union St (SW Corner) - BUS441"",40.4246071234111,-86.8774619327463,0
39f230f4-eaaf-4dfb-9690-a9ba9d38a448,BUS821,""12th St & Union St (SW Corner)"",""12th St & Union St (SW Corner) - BUS821"",40.424597735679,-86.884125881441,0
15319035-2db5-42f1-b420-4f292c60ab45,BUS325NE,""21st St & Elmwood Ave (NE Corner)"",""21st St & Elmwood Ave (NE Corner) - BUS325NE"",40.4286612825788,-86.8732548876556,0
f227e0df-a6b4-448b-b656-439d260e5ad6,BUS454,""Stonecrest Apartments (at Shelter)"",""Stonecrest Apartments (at Shelter) - BUS454"",40.4245990767836,-86.8761784956562,0
f2d5aeec-bbf9-4198-b04d-fa1efc99c808,BUS207,""Wayne Terrace & Elmwood Ave (SW Corner) "",""Wayne Terrace & Elmwood Ave (SW Corner) - BUS207"",40.4305656510929,-86.8690532069834,0
bfe7af45-7919-46b1-bc6c-049117e411da,BUS832,""Melbourne Rd & Vinton St (NE Corner)"",""Melbourne Rd & Vinton St (NE Corner) - BUS832"",40.4349322876294,-86.8671568850968,0
41b0ca1a-331c-4a23-b0be-b38d0b64100b,BUS325SE,""Elmwood Ave & 21st St (SE Corner)"",""Elmwood Ave & 21st St (SE Corner) - BUS325SE"",40.4284775512503,-86.8728042765143,0
bc6f3557-3d8c-4212-b477-2fa60eb54a0f,BUS827,""(South of) Elmwood Ave & 27th St"",""(South of) Elmwood Ave & 27th St - BUS827"",40.4332036038162,-86.8652619043149,0
fcfbdd32-c3e6-46a8-b7f5-ee5054df016c,BUS367E,""(East of) 9th St & Union St"",""(East of) 9th St & Union St - BUS367E"",40.4246513798625,-86.8864996365606,0
8567c547-5462-462f-944d-181bdffb61af,BUS830,""(South of) 27th St & Underwood St"",""(South of) 27th St & Underwood St - BUS830"",40.4377311729033,-86.8661751965389,0
47ca0ce3-c004-426f-bb07-6388f3611dc1,BUS818,""8th St & Union St (SW Corner)"",""8th St & Union St (SW Corner) - BUS818"",40.4246607675946,-86.8884120517023,0
1cdb2b37-d352-4b20-aac3-b9a51470e418,BUS825,""Cobblestone Ct & 21st St (SE Corner)"",""Cobblestone Ct & 21st St (SE Corner) - BUS825"",40.4263961569307,-86.8728552384886,0
e8eff5be-2f80-42e5-8762-9dc600adc8c8,BUS840,""(West of) 16th St & Salem St"",""(West of) 16th St & Salem St - BUS840"",40.4256585494076,-86.8812304366368,0
9fb31614-98e3-4efb-afb9-1fdc8881e71b,BUS838,""Speedway on Elmwood Ave (NE Corner)"",""Speedway on Elmwood Ave (NE Corner) - BUS838"",40.4270291582959,-86.8763528392525,0
8427e707-71bb-4401-837e-5f17885f687b,BUS410SE,""6th St & Brown St (SW Corner)"",""6th St & Brown St (SW Corner) - BUS410SE"",40.4216727865739,-86.8905859822384,0
e16ec97f-4cab-4297-b3aa-26e2c587fdc7,BUS835,""Market Square Shopping Center"",""Market Square Shopping Center - BUS835"",40.4304248351112,-86.8706343692919,0
66f75201-99e1-4c41-b84d-4b3a0446f785,BUS401,""14th St & Union St (SW Corner)"",""14th St & Union St (SW Corner) - BUS401"",40.424581642424,-86.8823529411765,0
21b97f50-5ea9-41fc-9136-903f0261cc3d,BUS829,""Prairie Ln & Elmwood Ave (SE Corner)"",""Prairie Ln & Elmwood Ave (SE Corner) - BUS829"",40.4361781737911,-86.8621156729529,0
684c2429-3fed-4df4-9fc6-1c3ba80dd71b,BUS845,""7th & Salem St (NE Corner)"",""7th & Salem St (NE Corner) - BUS845"",40.4258020475985,-86.8893856936327,0
2a76ba04-233d-46b3-895d-f068edc082ef,BUS380NE,""Salem St & 9th St (NE Corner)"",""Salem St & 9th St (NE Corner) - BUS380NE"",40.4258677617232,-86.8867262832359,0
34ceb907-6f06-4cf2-a269-30a14b50d122,BUS519E,""Fannon & Salem St (NE Corner)"",""Fannon & Salem St (NE Corner) - BUS519E"",40.4257537678333,-86.891117059655,0
0cfa7c3c-dd1d-44ad-aafb-4a367077bb4b,BUS360,""Harrison Bridge Ramp at Canal Rd"",""Harrison Bridge Ramp at Canal Rd - BUS360"",40.4247828081121,-86.8940125044592,0
cd249225-e3b6-488f-ab41-d18351d31cf0,BUS213N,""Beering Dr & Tower Dr"",""Beering Dr & Tower Dr - BUS213N"",40.4330145080694,-86.9188953589734,0
cc9c1d77-80f7-4dc5-a748-a16ede43ed33,BUS509NE,""Jischke Dr & Tower Dr (NE Corner)"",""Jischke Dr & Tower Dr (NE Corner) - BUS509NE"",40.4331472774236,-86.9213884724014,0
f471ed77-b77a-4dff-a0ed-fc4f0f582ca9,BUS561,""Lambert Fieldhouse on University St"",""Lambert Fieldhouse on University St - BUS561"",40.4326805730272,-86.9165672014098,0
befe2b89-20db-44af-a194-4f319ad58a17,BUS347,""5th & University St"",""5th & University St - BUS347"",40.4292473452835,-86.9166651020446,0
192d4872-baf3-438f-b5db-0252d3fd87a4,BUS584SW,""Jischke Dr & 1st St (SW Corner)"",""Jischke Dr & 1st St (SW Corner) - BUS584SW"",40.4251167431543,-86.9220482958584,0
45228678-7266-4b8c-8ec0-1e0c8ba2b30a,BUS585,""St. Mary's Church/School on 11th St"",""St. Mary's Church/School on 11th St - BUS585"",40.4175663243274,-86.8847830226888,0
8185286f-ad8d-4406-8db1-aa8f40c0e6b5,BUS219,""3rd St & Ferry St (SW Corner)"",""3rd St & Ferry St (SW Corner) - BUS219"",40.4199816536892,-86.8943276640372,0
c0b32368-3726-4def-8dad-d0b409cd09d9,BUS185,""2nd St & Columbia St (SE Corner)"",""2nd St & Columbia St (SE Corner) - BUS185"",40.4180263232008,-86.8953308102686,0
b70739c9-56fa-43b7-9d74-8320a7b639e7,BUS214,""Ferry St & 2nd St (SE Corner)"",""Ferry St & 2nd St (SE Corner) - BUS214"",40.4199816536892,-86.8954166409622,0
2968db1b-1bd4-4ad9-8fbd-c42004b44ad7,BUS188,""Main St & 2nd St (SE Corner)"",""Main St & 2nd St (SE Corner) - BUS188"",40.4189852129808,-86.8952878949218,0
0765ae17-56b1-472c-b9c7-15c3be39497f,BUS134,""Howarth Center"",""Howarth Center - BUS134"",40.4230152322659,-86.8771990762472,0
6944b647-4101-45bc-8b27-ae194fed061d,BUS314,""Barlow St & Salisbury St (SE Corner)"",""Barlow St & Salisbury St (SE Corner) - BUS314"",40.4564395818972,-86.9154782244848,0
0c311cdf-b0dc-4b66-80a9-12599c026e80,BUS131E,""Westminster Village N & Salisbury (NE)"",""Westminster Village N & Salisbury (NE) - BUS131E"",40.458546457204,-86.9154259214059,0
334fe767-d1ec-4f40-b8c9-2880a5d3fab1,BUS610,""Kent Ave & Salisbury St (SE Corner)"",""Kent Ave & Salisbury St (SE Corner) - BUS610"",40.4545298489648,-86.9155412564004,0
56d3e350-ddc9-4abf-a64f-5d7dc7b3d9ca,LSC001,""Sunnyside School (by request during LSC Calendar)"",,40.4218726111574,-86.8682069699888,0
f8e1e378-a29e-4c39-a8ef-415c8b3b3fa7,BUS426,""Stadium Parking Lot on Victory Dr"",""Stadium Parking Lot on Victory Dr - BUS426"",40.43597030258,-86.9187907528156,0
f1154d16-5dea-43c1-9b5e-b670ca613285,BUS598,""Harrison St & Sheets St (SW Corner)"",""Harrison St & Sheets St (SW Corner) - BUS598"",40.4203088832086,-86.9122126348145,0
cd42172f-3178-4457-9e1d-960b63f46e5f,BUS440,""Russell Dr & Harrison St (SW Corner)"",""Russell Dr & Harrison St (SW Corner) BUS440"",40.4203585040783,-86.9198314499755,0
1a1d3adb-67ef-49d1-a197-86dbdc993f23,BUS324,""Lynn Hall on Harrison St"",""Lynn Hall on Harrison St - BUS324"",40.4203102243131,-86.9150477299123,0
fe363b91-f29a-4e59-8a5e-b4e4efee4b78,BUS106,""Kestral Blvd at Sandpiper (SW Corner)"",""Kestral Blvd at Sandpiper (SW Corner) - BUS106"",40.4438412454034,-86.9382676147382,0
b558654a-0a62-46f0-84f2-afd53b6f7021,BUS103,""Blackbird Farms on Kestral Blvd (at Shelter)"",""Blackbird Farms on Kestral Blvd (at Shelter) - BUS103"",40.4451769855724,-86.9420495296746,0
d76f068a-b954-4aa4-ad68-ee3a5ff42c9a,BUS463,""Lindberg Rd & Kestral Blvd (SE Corner)"",""Lindberg Rd & Kestral Blvd (SE Corner) - BUS463"",40.4458126691468,-86.9366663358609,0
573e437f-4823-44f3-98ec-be6e94978895,BUS175,""E Pine Ave & Klondike Rd"",""E Pine Ave & Klondike Rd - BUS175"",40.4399104678577,-86.9620266236083,0
917e0ddc-4ce1-49c6-bfd5-94f944a01dad,BUS173,""Scarlett & SR 26 (SW Corner)"",""Scarlett & SR 26 (SW Corner) - BUS173"",40.4341987034201,-86.9555718872292,0
1b8c8d43-18cd-4ff5-96c8-043e4670b525,BUS176,""Klondike Rd & SR 26"",""Klondike Rd & SR 26 - BUS176"",40.4370740316554,-86.9619086064046,0
15effe88-7a96-4077-a184-e11c801380aa,BUS903,""Rosewood Dr & Klondike Rd (NW Corner)"",""Rosewood Dr & Klondike Rd (NW Corner) - BUS903"",40.4439297583061,-86.9620453990725,0
5d424876-a229-4b67-b3fd-8ccf11923bc5,BUS902,""Blueberry Ln & Klondike Rd (NW Corner)"",""Blueberry Ln & Klondike Rd (NW Corner) - BUS902"",40.4385291301327,-86.9620158947716,0
4ab02713-6b45-4f1d-be87-fc0aa66b904a,BUS572,""Georgetown Rd & Klondike Rd (NW Corner)"",""Georgetown Rd & Klondike Rd (NW Corner) - BUS572"",40.4417290056782,-86.9620360113404,0
05e9ffdb-07a3-4381-b5f3-6d3a8a20a3b7,BUS136,""Browning St & Cumberland Ave (SW Corner)"",""Browning St & Cumberland Ave (SW Corner) - BUS136"",40.4604307091493,-86.9213857901922,0
5a5e7c4f-ec43-4ac1-b83f-cca955e69a9d,BUS235,""Ahlers Dr & S Russell St (SW Corner)"",""Ahlers Dr & S Russell St (SW Corner) - BUS235"",40.41561,-86.91626,0
f962cacf-3380-4ffc-9ce2-586a6688bbab,BUS357,""Biochemistry on University St"",""Biochemistry on University St - BUS357"",40.4225927843209,-86.9161313424189,0
8e21ec94-1217-44a4-9f85-59ea630d1d92,BUS570,""Pao Hall on Marsteller St"",""Pao Hall on Marsteller St - BUS570"",40.4224761082218,-86.913777703868,0
194a7cd2-ce46-4b07-ba12-97433aca199c,BUS234,""S Russell Dr & Ahlers Dr Parking Lot"",""S Russell Dr & Ahlers Dr Parking Lot - BUS234"",40.41611,-86.91856,0
5a5b3385-7f27-4059-a0d7-d3cb3b12143f,BUS233,""Russell Dr & Harrison St (SE Corner)"",""Russell Dr & Harrison St (SE Corner) - BUS233"",40.4204041016343,-86.9194452118543,0
8dd5d1a7-b7cd-4da4-b160-88bd767e10ea,BUS352,""Martin Jischke Dr, north of Harrison St"",""Martin Jischke Dr, north of Harrison St - BUS352"",40.4214702797812,-86.9215909791941,0
eebe11b9-eac0-4eb8-9861-47f18b7e21a5,BUS529,""Jischke Dr & State St (SE Corner)"",""Jischke Dr & State St (SE Corner) - BUS529"",40.4239432766404,-86.9215453816381,0
b1e3041c-46cd-4346-b1d4-5ff31ba6fe7f,BUS171,""Beering Dr & Tower Dr (NW Corner)"",""Beering Dr & Tower Dr (NW Corner) - BUS171"",40.4331499596327,-86.9193982731937,0";
    }
}
