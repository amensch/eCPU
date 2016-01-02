﻿
namespace KDS.e8080
{
    public class i8080Table
    {
        public static OpCodeTable[] opCodes = new OpCodeTable[]
        {
            new OpCodeTable(0x00,"NOP",1),
            new OpCodeTable(0x01,"LXI B,D16",3),
            new OpCodeTable(0x02,"STAX B",1),
            new OpCodeTable(0x03,"INX B",1),
            new OpCodeTable(0x04,"INR B",1),
            new OpCodeTable(0x05,"DCR B",1),
            new OpCodeTable(0x06,"MVI B, D8",2),
            new OpCodeTable(0x07,"RLC",1),
            new OpCodeTable(0x08,"NOP",1),
            new OpCodeTable(0x09,"DAD B",1),
            new OpCodeTable(0x0a,"LDAX B",1),
            new OpCodeTable(0x0b,"DCX B",1),
            new OpCodeTable(0x0c,"INR C",1),
            new OpCodeTable(0x0d,"DCR C",1),
            new OpCodeTable(0x0e,"MVI C,D8",2),
            new OpCodeTable(0x0f,"RRC",1),
            new OpCodeTable(0x10,"NOP",1),
            new OpCodeTable(0x11,"LXI D,D16",3),
            new OpCodeTable(0x12,"STAX D",1),
            new OpCodeTable(0x13,"INX D",1),
            new OpCodeTable(0x14,"INR D",1),
            new OpCodeTable(0x15,"DCR D",1),
            new OpCodeTable(0x16,"MVI D, D8",2),
            new OpCodeTable(0x17,"RAL",1),
            new OpCodeTable(0x18,"NOP",1),
            new OpCodeTable(0x19,"DAD D",1),
            new OpCodeTable(0x1a,"LDAX D",1),
            new OpCodeTable(0x1b,"DCX D",1),
            new OpCodeTable(0x1c,"INR E",1),
            new OpCodeTable(0x1d,"DCR E",1),
            new OpCodeTable(0x1e,"MVI E,D8",2),
            new OpCodeTable(0x1f,"RAR",1),
            new OpCodeTable(0x20,"RIM",1),
            new OpCodeTable(0x21,"LXI H,D16",3),
            new OpCodeTable(0x22,"SHLD adr",3),
            new OpCodeTable(0x23,"INX H",1),
            new OpCodeTable(0x24,"INR H",1),
            new OpCodeTable(0x25,"DCR H",1),
            new OpCodeTable(0x26,"MVI H,D8",2),
            new OpCodeTable(0x27,"DAA",1),
            new OpCodeTable(0x28,"NOP",1),
            new OpCodeTable(0x29,"DAD H",1),
            new OpCodeTable(0x2a,"LHLD adr",3),
            new OpCodeTable(0x2b,"DCX H",1),
            new OpCodeTable(0x2c,"INR L",1),
            new OpCodeTable(0x2d,"DCR L",1),
            new OpCodeTable(0x2e,"MVI L, D8",2),
            new OpCodeTable(0x2f,"CMA",1),
            new OpCodeTable(0x30,"SIM",1),
            new OpCodeTable(0x31,"LXI SP, D16",3),
            new OpCodeTable(0x32,"STA adr",3),
            new OpCodeTable(0x33,"INX SP",1),
            new OpCodeTable(0x34,"INR M",1),
            new OpCodeTable(0x35,"DCR M",1),
            new OpCodeTable(0x36,"MVI M,D8",2),
            new OpCodeTable(0x37,"STC",1),
            new OpCodeTable(0x38,"NOP",1),
            new OpCodeTable(0x39,"DAD SP",1),
            new OpCodeTable(0x3a,"LDA adr",3),
            new OpCodeTable(0x3b,"DCX SP",1),
            new OpCodeTable(0x3c,"INR A",1),
            new OpCodeTable(0x3d,"DCR A",1),
            new OpCodeTable(0x3e,"MVI A,D8",2),
            new OpCodeTable(0x3f,"CMC",1),
            new OpCodeTable(0x40,"MOV B,B",1),
            new OpCodeTable(0x41,"MOV B,C",1),
            new OpCodeTable(0x42,"MOV B,D",1),
            new OpCodeTable(0x43,"MOV B,E",1),
            new OpCodeTable(0x44,"MOV B,H",1),
            new OpCodeTable(0x45,"MOV B,L",1),
            new OpCodeTable(0x46,"MOV B,M",1),
            new OpCodeTable(0x47,"MOV B,A",1),
            new OpCodeTable(0x48,"MOV C,B",1),
            new OpCodeTable(0x49,"MOV C,C",1),
            new OpCodeTable(0x4a,"MOV C,D",1),
            new OpCodeTable(0x4b,"MOV C,E",1),
            new OpCodeTable(0x4c,"MOV C,H",1),
            new OpCodeTable(0x4d,"MOV C,L",1),
            new OpCodeTable(0x4e,"MOV C,M",1),
            new OpCodeTable(0x4f,"MOV C,A",1),
            new OpCodeTable(0x50,"MOV D,B",1),
            new OpCodeTable(0x51,"MOV D,C",1),
            new OpCodeTable(0x52,"MOV D,D",1),
            new OpCodeTable(0x53,"MOV D,E",1),
            new OpCodeTable(0x54,"MOV D,H",1),
            new OpCodeTable(0x55,"MOV D,L",1),
            new OpCodeTable(0x56,"MOV D,M",1),
            new OpCodeTable(0x57,"MOV D,A",1),
            new OpCodeTable(0x58,"MOV E,B",1),
            new OpCodeTable(0x59,"MOV E,C",1),
            new OpCodeTable(0x5a,"MOV E,D",1),
            new OpCodeTable(0x5b,"MOV E,E",1),
            new OpCodeTable(0x5c,"MOV E,H",1),
            new OpCodeTable(0x5d,"MOV E,L",1),
            new OpCodeTable(0x5e,"MOV E,M",1),
            new OpCodeTable(0x5f,"MOV E,A",1),
            new OpCodeTable(0x60,"MOV H,B",1),
            new OpCodeTable(0x61,"MOV H,C",1),
            new OpCodeTable(0x62,"MOV H,D",1),
            new OpCodeTable(0x63,"MOV H,E",1),
            new OpCodeTable(0x64,"MOV H,H",1),
            new OpCodeTable(0x65,"MOV H,L",1),
            new OpCodeTable(0x66,"MOV H,M",1),
            new OpCodeTable(0x67,"MOV H,A",1),
            new OpCodeTable(0x68,"MOV L,B",1),
            new OpCodeTable(0x69,"MOV L,C",1),
            new OpCodeTable(0x6a,"MOV L,D",1),
            new OpCodeTable(0x6b,"MOV L,E",1),
            new OpCodeTable(0x6c,"MOV L,H",1),
            new OpCodeTable(0x6d,"MOV L,L",1),
            new OpCodeTable(0x6e,"MOV L,M",1),
            new OpCodeTable(0x6f,"MOV L,A",1),
            new OpCodeTable(0x70,"MOV M,B",1),
            new OpCodeTable(0x71,"MOV M,C",1),
            new OpCodeTable(0x72,"MOV M,D",1),
            new OpCodeTable(0x73,"MOV M,E",1),
            new OpCodeTable(0x74,"MOV M,H",1),
            new OpCodeTable(0x75,"MOV M,L",1),
            new OpCodeTable(0x76,"HLT",0),
            new OpCodeTable(0x77,"MOV M,A",1),
            new OpCodeTable(0x78,"MOV A,B",1),
            new OpCodeTable(0x79,"MOV A,C",1),
            new OpCodeTable(0x7a,"MOV A,D",1),
            new OpCodeTable(0x7b,"MOV A,E",1),
            new OpCodeTable(0x7c,"MOV A,H",1),
            new OpCodeTable(0x7d,"MOV A,L",1),
            new OpCodeTable(0x7e,"MOV A,M",1),
            new OpCodeTable(0x7f,"MOV A,A",1),
            new OpCodeTable(0x80,"ADD B",1),
            new OpCodeTable(0x81,"ADD C",1),
            new OpCodeTable(0x82,"ADD D",1),
            new OpCodeTable(0x83,"ADD E",1),
            new OpCodeTable(0x84,"ADD H",1),
            new OpCodeTable(0x85,"ADD L",1),
            new OpCodeTable(0x86,"ADD M",1),
            new OpCodeTable(0x87,"ADD A",1),
            new OpCodeTable(0x88,"ADC B",1),
            new OpCodeTable(0x89,"ADC C",1),
            new OpCodeTable(0x8a,"ADC D",1),
            new OpCodeTable(0x8b,"ADC E",1),
            new OpCodeTable(0x8c,"ADC H",1),
            new OpCodeTable(0x8d,"ADC L",1),
            new OpCodeTable(0x8e,"ADC M",1),
            new OpCodeTable(0x8f,"ADC A",1),
            new OpCodeTable(0x90,"SUB B",1),
            new OpCodeTable(0x91,"SUB C",1),
            new OpCodeTable(0x92,"SUB D",1),
            new OpCodeTable(0x93,"SUB E",1),
            new OpCodeTable(0x94,"SUB H",1),
            new OpCodeTable(0x95,"SUB L",1),
            new OpCodeTable(0x96,"SUB M",1),
            new OpCodeTable(0x97,"SUB A",1),
            new OpCodeTable(0x98,"SBB B",1),
            new OpCodeTable(0x99,"SBB C",1),
            new OpCodeTable(0x9a,"SBB D",1),
            new OpCodeTable(0x9b,"SBB E",1),
            new OpCodeTable(0x9c,"SBB H",1),
            new OpCodeTable(0x9d,"SBB L",1),
            new OpCodeTable(0x9e,"SBB M",1),
            new OpCodeTable(0x9f,"SBB A",1),
            new OpCodeTable(0xa0,"ANA B",1),
            new OpCodeTable(0xa1,"ANA C",1),
            new OpCodeTable(0xa2,"ANA D",1),
            new OpCodeTable(0xa3,"ANA E",1),
            new OpCodeTable(0xa4,"ANA H",1),
            new OpCodeTable(0xa5,"ANA L",1),
            new OpCodeTable(0xa6,"ANA M",1),
            new OpCodeTable(0xa7,"ANA A",1),
            new OpCodeTable(0xa8,"XRA B",1),
            new OpCodeTable(0xa9,"XRA C",1),
            new OpCodeTable(0xaa,"XRA D",1),
            new OpCodeTable(0xab,"XRA E",1),
            new OpCodeTable(0xac,"XRA H",1),
            new OpCodeTable(0xad,"XRA L",1),
            new OpCodeTable(0xae,"XRA M",1),
            new OpCodeTable(0xaf,"XRA A",1),
            new OpCodeTable(0xb0,"ORA B",1),
            new OpCodeTable(0xb1,"ORA C",1),
            new OpCodeTable(0xb2,"ORA D",1),
            new OpCodeTable(0xb3,"ORA E",1),
            new OpCodeTable(0xb4,"ORA H",1),
            new OpCodeTable(0xb5,"ORA L",1),
            new OpCodeTable(0xb6,"ORA M",1),
            new OpCodeTable(0xb7,"ORA A",1),
            new OpCodeTable(0xb8,"CMP B",1),
            new OpCodeTable(0xb9,"CMP C",1),
            new OpCodeTable(0xba,"CMP D",1),
            new OpCodeTable(0xbb,"CMP E",1),
            new OpCodeTable(0xbc,"CMP H",1),
            new OpCodeTable(0xbd,"CMP L",1),
            new OpCodeTable(0xbe,"CMP M",1),
            new OpCodeTable(0xbf,"CMP A",1),
            new OpCodeTable(0xc0,"RNZ",1),
            new OpCodeTable(0xc1,"POP B",1),
            new OpCodeTable(0xc2,"JNZ adr",3),
            new OpCodeTable(0xc3,"JMP adr",3),
            new OpCodeTable(0xc4,"CNZ adr",3),
            new OpCodeTable(0xc5,"PUSH B",1),
            new OpCodeTable(0xc6,"ADI D8",2),
            new OpCodeTable(0xc7,"RST 0",1),
            new OpCodeTable(0xc8,"RZ",1),
            new OpCodeTable(0xc9,"RET",1),
            new OpCodeTable(0xca,"JZ adr",3),
            new OpCodeTable(0xcb,"JMP adr",3),
            new OpCodeTable(0xcc,"CZ adr",3),
            new OpCodeTable(0xcd,"CALL adr",3),
            new OpCodeTable(0xce,"ACI D8",2),
            new OpCodeTable(0xcf,"RST 1",1),
            new OpCodeTable(0xd0,"RNC",1),
            new OpCodeTable(0xd1,"POP D",1),
            new OpCodeTable(0xd2,"JNC adr",3),
            new OpCodeTable(0xd3,"OUT D8",2),
            new OpCodeTable(0xd4,"CNC adr",3),
            new OpCodeTable(0xd5,"PUSH D",1),
            new OpCodeTable(0xd6,"SUI D8",2),
            new OpCodeTable(0xd7,"RST 2",1),
            new OpCodeTable(0xd8,"RC",1),
            new OpCodeTable(0xd9,"RET",1),
            new OpCodeTable(0xda,"JC adr",3),
            new OpCodeTable(0xdb,"IN D8",2),
            new OpCodeTable(0xdc,"CC adr",3),
            new OpCodeTable(0xdd,"CALL adr",3),
            new OpCodeTable(0xde,"SBI D8",2),
            new OpCodeTable(0xdf,"RST 3",1),
            new OpCodeTable(0xe0,"RPO",1),
            new OpCodeTable(0xe1,"POP H",1),
            new OpCodeTable(0xe2,"JPO adr",3),
            new OpCodeTable(0xe3,"XTHL",1),
            new OpCodeTable(0xe4,"CPO adr",3),
            new OpCodeTable(0xe5,"PUSH H",1),
            new OpCodeTable(0xe6,"ANI D8",2),
            new OpCodeTable(0xe7,"RST 4",1),
            new OpCodeTable(0xe8,"RPE",1),
            new OpCodeTable(0xe9,"PCHL",1),
            new OpCodeTable(0xea,"JPE adr",3),
            new OpCodeTable(0xeb,"XCHG",1),
            new OpCodeTable(0xec,"CPE adr",3),
            new OpCodeTable(0xed,"CALL adr",3),
            new OpCodeTable(0xee,"XRI D8",2),
            new OpCodeTable(0xef,"RST 5",1),
            new OpCodeTable(0xf0,"RP",1),
            new OpCodeTable(0xf1,"POP PSW",1),
            new OpCodeTable(0xf2,"JP adr",3),
            new OpCodeTable(0xf3,"DI",1),
            new OpCodeTable(0xf4,"CP adr",3),
            new OpCodeTable(0xf5,"PUSH PSW",1),
            new OpCodeTable(0xf6,"ORI D8",2),
            new OpCodeTable(0xf7,"RST 6",1),
            new OpCodeTable(0xf8,"RM",1),
            new OpCodeTable(0xf9,"SPHL",1),
            new OpCodeTable(0xfa,"JM adr",3),
            new OpCodeTable(0xfb,"EI",1),
            new OpCodeTable(0xfc,"CM adr",3),
            new OpCodeTable(0xfd,"CALL adr",3),
            new OpCodeTable(0xfe,"CPI D8",2),
            new OpCodeTable(0xff,"RST 7",1)

        };
    }
}
