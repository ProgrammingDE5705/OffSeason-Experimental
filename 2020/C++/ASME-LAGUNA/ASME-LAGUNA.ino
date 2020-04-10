#include <SoftwareSerial.h>

SoftwareSerial Bluetooth(7, 4); // RX, TX

int Lmotor = 10;
int Rmotor = 11;
String value;
void A(), AB(), AC(), AD(), AE(), AF(), AG(), AH(), AI(), AJ(), AK();
void AL(), AM(), AN(), AO(), AP(), AQ(), AR(), AS(), AT(), AU(), AV();
void AW(), AX(), AY(), AZ(), BA(), BB(), BC(), BD(), BE(), BF(), BG();
void BH(), BI(), BJ(), BK(), BL(), BM(), BN(), BO(), BP(), BQ(), BR();
void BS(), BT(), BU(), BV(), BW(), BX(), BY(), BZ();
void CA(), CB(), CC(), CD(), CE(), CF(), CG(), CH(), CI(), CJ(), CK();
void CL(), CM(), CN(), CO(), CP(), CQ(), CR(), CS(), CT(), CU();

void setup(){
  Bluetooth.begin(9600);
  pinMode(Lmotor, OUTPUT);
  pinMode(Rmotor, OUTPUT);
}

void loop() {
  value = Bluetooth.readString();
  switch(value){ case 'A': A(); break;
    case 'AB': AB(); break; case 'AC': AC(); break; case 'AD': AD(); break;
    case 'AE': AE(); break; case 'AF': AF(); break; case 'AG': AG(); break; case 'AH': AH(); break;
    case 'AI': AI(); break; case 'AJ': AJ(); break; case 'AK': AK(); break; case 'AL': AL(); break;
    case 'AM': AM(); break; case 'AN': AN(); break; case 'AO': AO(); break; case 'AP': AP(); break;
    case 'AQ': AQ(); break; case 'AR': AR(); break; case 'AS': AS(); break; case 'AT': AT(); break;
    case 'AU': AU(); break; case 'AV': AV(); break; case 'AW': AW(); break; case 'AX': AX(); break;
    case 'AY': AY(); break; case 'AZ': AZ(); break;
    
    case 'BA': BA();  break; case 'BB': BB(); break; case 'BC': BC(); break; case 'BD': BD(); break;
    case 'BE': BE();  break; case 'BF': BF(); break; case 'BG': BG(); break; case 'BH': BH(); break;
    case 'BI': BI();  break; case 'BJ': BJ(); break; case 'BK': BK(); break; case 'BL': BL(); break;
    case 'BM': BM();  break; case 'BN': BN(); break; case 'BO': BO(); break; case 'BP': BP(); break;
    case 'BQ': BQ();  break; case 'BR': BR(); break; case 'BS': BS(); break; case 'BT': BT(); break;
    case 'BU': BU();  break; case 'BV': BV(); break; case 'BW': BW(); break; case 'BX': BX(); break;
    case 'BY': BY();  break; case 'BZ': BZ(); break;
    
    case 'CA': CA(); break; case 'CB': CB(); break; case 'CC': CC(); break; case 'CD': CD();  break;
    case 'CE': CE(); break; case 'CF': CF(); break; case 'CG': CG(); break; case 'CH': CH();  break;
    case 'CI': CI(); break; case 'CJ': CJ(); break; case 'CK': CK(); break; case 'CL': CL();  break;
    case 'CM': CM(); break; case 'CN': CN(); break; case 'CO': CO(); break; case 'CP': CP();  break;
    case 'CQ': CQ(); break; case 'CR': CR(); break; case 'CS': CS(); break; case 'CT': CT();  break;
    case 'CU': CU(); break; case 'CV': CV(); break; case 'CW': CW(); break; case 'CX': CX();  break;
    case 'CY': CY(); break; case 'CZ': CZ(); break;
    
}


}
//--------------------------------------------------------  AXIS #1  --------------------------------------------------------//
//--------------------------------------------------------  POSITIVO  --------------------------------------------------------//
 void A(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} 
void AB(){ analogWrite(Lmotor, 190); analogWrite(Rmotor, 190);} void AC(){ analogWrite(Lmotor, 193); analogWrite(Rmotor, 193);}
void AD(){ analogWrite(Lmotor, 196); analogWrite(Rmotor, 196);} void AE(){ analogWrite(Lmotor, 199); analogWrite(Rmotor, 199);}
void AF(){ analogWrite(Lmotor, 202); analogWrite(Rmotor, 202);} void AG(){ analogWrite(Lmotor, 205); analogWrite(Rmotor, 205);}
void AH(){ analogWrite(Lmotor, 208); analogWrite(Rmotor, 208);} void AI(){ analogWrite(Lmotor, 211); analogWrite(Rmotor, 211);}
void AJ(){ analogWrite(Lmotor, 214); analogWrite(Rmotor, 214);} void AK(){ analogWrite(Lmotor, 218); analogWrite(Rmotor, 218);}
void AL(){ analogWrite(Lmotor, 222); analogWrite(Rmotor, 222);} void AM(){ analogWrite(Lmotor, 226); analogWrite(Rmotor, 226);}
void AN(){ analogWrite(Lmotor, 230); analogWrite(Rmotor, 230);} void AO(){ analogWrite(Lmotor, 234); analogWrite(Rmotor, 234);}
void AP(){ analogWrite(Lmotor, 238); analogWrite(Rmotor, 238);} void AQ(){ analogWrite(Lmotor, 242); analogWrite(Rmotor, 242);}
void AR(){ analogWrite(Lmotor, 246); analogWrite(Rmotor, 246);} void AS(){ analogWrite(Lmotor, 250); analogWrite(Rmotor, 250);}
//--------------------------------------------------------  NEGATIVO  --------------------------------------------------------//
void AT(){ analogWrite(Lmotor, 175); analogWrite(Rmotor, 175);} void AU(){ analogWrite(Lmotor, 172); analogWrite(Rmotor, 172);}
void AV(){ analogWrite(Lmotor, 169); analogWrite(Rmotor, 169);} void AW(){ analogWrite(Lmotor, 166); analogWrite(Rmotor, 166);}
void AX(){ analogWrite(Lmotor, 163); analogWrite(Rmotor, 163);} void AY(){ analogWrite(Lmotor, 160); analogWrite(Rmotor, 160);}
void AZ(){ analogWrite(Lmotor, 157); analogWrite(Rmotor, 157);} void BA(){ analogWrite(Lmotor, 154); analogWrite(Rmotor, 154);}
void BB(){ analogWrite(Lmotor, 151); analogWrite(Rmotor, 151);} void BC(){ analogWrite(Lmotor, 147); analogWrite(Rmotor, 147);}
void BD(){ analogWrite(Lmotor, 143); analogWrite(Rmotor, 143);} void BE(){ analogWrite(Lmotor, 139); analogWrite(Rmotor, 139);}
void BF(){ analogWrite(Lmotor, 135); analogWrite(Rmotor, 135);} void BG(){ analogWrite(Lmotor, 131); analogWrite(Rmotor, 131);}
void BH(){ analogWrite(Lmotor, 127); analogWrite(Rmotor, 127);} void BI(){ analogWrite(Lmotor, 127); analogWrite(Rmotor, 127);}
void BJ(){ analogWrite(Lmotor, 119); analogWrite(Rmotor, 119);} void BK(){ analogWrite(Lmotor, 115); analogWrite(Rmotor, 115);}


//--------------------------------------------------------  AXIS #2  --------------------------------------------------------//
//--------------------------------------------------------  POSITIVO  --------------------------------------------------------//
void BL(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void BM(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void BN(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void BO(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void BP(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void BQ(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void BR(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void BS(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void BT(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void BU(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void BV(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void BW(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void BX(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void BY(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void BZ(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CA(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CB(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CC(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} 
//--------------------------------------------------------  NEGATIVO  --------------------------------------------------------//
void CD(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CE(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CF(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CG(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CH(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CI(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CJ(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CK(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CL(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CM(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CN(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CO(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CP(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CQ(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CR(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CS(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CT(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CU(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CV(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CW(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CX(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
void CY(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);} void CZ(){ analogWrite(Lmotor, 185); analogWrite(Rmotor, 185);}
