using ASPNetCore3.IServices;
using Domain;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ASPNetCore3.ServiceImpl
{
    public class StockCrawlerService : IStockCrawlerService
    {
        //private ChromeDriver driver;
        //List<string> codes = new List<string> { "HAG", "STB", "MBB", "ITA", "HPG", "LPB", "TCH", "POW", "TCB", "ACB", "HQC", "TDH", "HNG", "FLC", "PVD", "SSI", "DXG", "VRE", "GEX", "LDG", "ROS", "KBC", "MSB", "DLG", "SCR", "FIT", "CTG", "HSG", "TTF", "HDB", "HHS", "GVR", "SBT", "HBC", "SJF", "AMD", "HCM", "LCG", "VND", "AGR", "NVL", "DCM", "VOS", "HAI", "GMD", "VPB", "PVT", "DBC", "NKG", "DRH", "AAA", "TPB", "IDI", "ASM", "PDR", "DPM", "GTN", "PET", "VNM", "BSI", "DIG", "CII", "FPT", "MSN", "IJC", "FRT", "HVN", "TNI", "KSB", "FCN", "VHM", "HAR", "BID", "TSC", "CVRE2007", "CRE", "TVB", "TDC", "PHR", "DRC", "CVNM2011", "BVH", "KDC", "HT1", "CVHM2006", "BCG", "MHC", "CTS", "OGC", "VHC", "CTD", "APG", "TTA", "VIC", "FUEVFVND", "HDG", "KDH", "PLX", "VIB", "VIP", "BWE", "MWG", "NT2", "VDS", "CKG", "PAN", "CVRE2011", "CNVL2003", "NTL", "JVC", "TTB", "HAH", "TCM", "PLP", "HAP", "DGC", "NLG", "EVG", "GEG", "FTS", "HDC", "VCG", "AGG", "CTCH2002", "DAH", "VCB", "DCL", "CVRE2012", "GAS", "CVIC2004", "SZC", "BMI", "CHPG2010", "CVNM2010", "CTI", "VPI", "VCI", "DAG", "CMBB2009", "QCG", "CVRE2009", "CMX", "TLH", "FMC", "CSTB2015", "LSS", "VJC", "PPC", "DPG", "CSTB2007", "TLD", "CKDH2003", "PC1", "TNA", "SHI", "HII", "TDG", "BFC", "CFPT2011", "CVNM2008", "PXS", "SKG", "CVHM2009", "VPG", "CHDB2007", "ELC", "CVIC2006", "TGG", "CVRE2015", "CCL", "PNJ", "CVRE2010", "CTCH2001", "CSTB2010", "PXT", "CVRE2008", "CMSN2007", "REE", "VIX", "CTCB2010", "HAX", "EIB", "DHM", "CVIC2005", "HID", "CRC", "CKDH2002", "BCE", "CVNM2013", "QBS", "FTM", "CKDH2001", "SAM", "VPH", "LHG", "HPX", "TNT", "VRC", "DTA", "CTCH2003", "CVHM2010", "CFPT2015", "TDM", "ANV", "PTB", "CSTB2016", "CHPG2018", "VNE", "NHH", "APH", "CVHM2007", "BKG", "E1VFVN30", "HCD", "CVRE2014", "TNH", "D2D", "GIL", "CVJC2006", "TVS", "C32", "CMWG2015", "CSTB2011", "CMBB2010", "KHP", "CFPT2012", "CSTB2013", "CSV", "CHPG2017", "CMWG2017", "DGW", "KMR", "PHC", "C47", "BCM", "TAC", "DHC", "CMSN2013", "CVHM2008", "CFPT2017", "TCL", "CVPB2016", "VSC", "KOS", "SMC", "VGC", "CVNM2016", "CKDH2004", "CSTB2014", "CREE2006", "ABS", "CVJC2004", "CNG", "CHDB2008", "CSBT2007", "CTCB2013", "CSTB2012", "CMSN2009", "CMWG2016", "TV2", "CVPB2011", "ACL", "CMBB2007", "CPNJ2009", "CVNM2012", "CSM", "VNG", "IBC", "TEG", "LGL", "SJS", "HVH", "BMP", "BIC", "APC", "CVNM2015", "SAB", "DQC", "TLG", "CSTB2006", "MSH", "NAF", "ASP", "CVRE2013", "CVIC2007", "HSL", "CVJC2005", "CVPB2017", "CEIB2001", "CMSN2014", "ITD", "FIR", "MCG", "PSH", "CMBB2011", "UDC", "POM", "CTCB2007", "CTCB2012", "CMG", "CHPG2023", "HTN", "CTF", "ITC", "SFG", "CTCB2009", "TIP", "AST", "SBA", "FUESSV30", "CVPB2012", "TMS", "VPS", "CFPT2008", "FUESSVFL", "BMC", "TDP", "TMT", "CVT", "LIX", "ILB", "AGM", "DPR", "VTO", "CHPG2021", "EVE", "CMWG2012", "DMC", "SBV", "SJD", "NNC", "SHA", "TCT", "PXI", "CPNJ2010", "CTCB2011", "CHP", "CNVL2002", "TYA", "SAV", "CSTB2017", "CPNJ2006", "CVPB2015", "CVPB2008", "TCD", "THG", "CVNM2007", "FUESSV50", "ICT", "CHPG2020", "CFPT2016", "DBD", "CVNM2014", "CVPB2014", "HTI", "FUEVN100", "CHPG2015", "IMP", "DVP", "FCM", "SZL", "LCM", "SRC", "PIT", "LBM", "CLC", "CMBB2008", "PGC", "STK", "CIG", "SCS", "YBM", "CHPG2025", "CMWG2010", "YEG", "TBC", "SGR", "SCD", "CHPG2026", "CMSN2006", "NCT", "ASG", "HUB", "ACC", "CVHM2005", "VTB", "BTT", "CPNJ2008", "VSH", "GDT", "GMC", "CFPT2010", "PMG", "DC4", "SFI", "PTL", "FUEMAV30", "HVX", "TRA", "BTP", "PAC", "RDP", "SMB", "CHPG2024", "CHPG2022", "CMSN2011", "VID", "SGN", "CVPB2013", "TPC", "SGT", "VIS", "ADS", "NVT", "DSN", "NBB", "VAF", "NSC", "PGD", "PJT", "DHA", "ST8", "SHP", "CCI", "RAL", "ABT", "CDC", "VNL", "GTA", "CEE", "DXV", "DHG", "KPF", "VPD", "CMWG2013", "DAT", "UIC", "CFPT2013", "VNS", "PGI", "PME", "DBT", "LEC", "SVT", "CHPG2016", "OPC", "HU3", "SMA", "LAF", "DTL", "LM8", "BBC", "DRL", "GAB", "TS4", "CMV", "CFPT2014", "HU1", "CREE2005", "HTV", "RIC", "STG", "L10", "HTL", "S4A", "TRC", "TVT", "FDC", "AAM", "TN1", "VDP", "CLL", "CMSN2010", "FUCVREIT", "CMSN2012", "BHN", "VSI", "CAV", "HRC", "VMD", "HMC", "SRF", "TCO", "CHPG2014", "PDN", "SVC", "CVPB2010", "HAS", "NAV", "SC5", "THI", "SVI", "TCR", "CLW", "COM", "FUCTVGF2", "GSP", "HOT", "MDG", "PNC", "TNC", "VCF", "VFG", "ATG", "BRC", "CHPG2012", "CLG", "DTT", "EMC", "FUCTVGF1", "LGC", "MCP", "PTC", "SFC", "SII", "SPM", "SSC", "TDW", "TIX", "TMP", "TTE", "SHB", "HUT", "KLF", "PVS", "ART", "CEO", "IDC", "NVB", "VIG", "DST", "SHS", "BII", "AMV", "TVC", "MBS", "MBG", "ACM", "TIG", "TNG", "APS", "BVS", "NDN", "PVB", "TDT", "BCC", "TAR", "THD", "VHE", "AAV", "TTH", "MPT", "KVC", "PLC", "IDJ", "DS3", "NHP", "HHP", "PVC", "MST", "C69", "SPI", "SD6", "LIG", "SRA", "CVN", "PVL", "NSH", "FID", "GKM", "VCS", "NRC", "LAS", "HHG", "WSS", "DDG", "DXP", "VKC", "PPE", "DNC", "HBS", "API", "VGS", "LCS", "GIC", "HOM", "CET", "VC3", "MAC", "DTD", "HLD", "CMS", "SHN", "SDT", "BNA", "CTP", "IVS", "NHA", "VNR", "L14", "PTS", "PSD", "KSQ", "PVI", "ITQ", "SVN", "TTZ", "PV2", "PGS", "PVG", "ONE", "NST", "SD5", "VC7", "TA9", "NBC", "DNM", "DZM", "PGN", "SZB", "KDM", "CSC", "BTS", "V21", "IDV", "S99", "EID", "SLS", "PSI", "GLT", "VNT", "VMC", "INN", "HAD", "HMH", "PHP", "TVD", "CIA", "RCL", "NTP", "HCC", "LUT", "TDN", "UNI", "PRE", "SJE", "DC2", "HDA", "SDA", "VIT", "HAT", "EVS", "DHT", "LO5", "NAG", "KTT", "VTV", "PMC", "MCO", "BAX", "ADC", "TTL", "CTC", "NGC", "MVB", "NDX", "SED", "VC9", "LM7", "PPS", "VCC", "PDB", "STC", "TKC", "THT", "TTC", "CTB", "S55", "PHN", "SD4", "LDP", "C92", "VTC", "TMB", "PCT", "BLF", "DP3", "HTC", "CTX", "PTI", "HBE", "SD2", "AME", "TC6", "THB", "LHC", "PPP", "VBC", "GDW", "ICG", "QTC", "NTH", "VE4", "INC", "MAS", "TFC", "CAP", "NET", "PGT", "KKC", "SD9", "SIC", "APP", "DTK", "EBS", "SMN", "TJC", "PBP", "TV4", "PDC", "VSM", "STP", "SHE", "KHS", "TTT", "CMC", "DAE", "MDC", "HVT", "PCE", "DAD", "HTP", "VTJ", "MHL", "SCI", "DNP", "HHC", "VXB", "CLH", "D11", "PCG", "SMT", "DIH", "GMX", "HCT", "MCF", "POT", "TXM", "BBS", "VE1", "SFN", "CDN", "KTS", "PPY", "SDG", "VC6", "WCS", "CKV", "CPC", "L18", "SJ1", "X20", "OCH", "S74", "VDL", "BKC", "PIC", "CAN", "SDN", "AMC", "PMP", "SGC", "TMX", "VC2", "ALT", "BTW", "MED", "MKV", "NBP", "NBW", "PIA", "PJC", "QST", "SEB", "SSM", "VE3", "VSA", "ARM", "ATS", "BCF", "BDB", "BED", "BPC", "BSC", "BST", "BXH", "CAG", "CJC", "CLM", "CTT", "CX8", "DHP", "DL1", "DPC", "DPS", "EBA", "ECI", "GMA", "HEV", "HGM", "HJS", "HKB", "HKT", "HLC", "HLY", "HPM", "KMT", "KSD", "KST", "L35", "L43", "L61", "L62", "LBE", "LCD", "MCC", "MEL", "MIM", "NAP", "NFC", "NHC", "PEN", "PMB", "PMS", "PRC", "PSC", "PSE", "PSW", "PTD", "QHD", "SAF", "SDC", "SDU", "SGD", "SGH", "SJC", "TBX", "TET", "THS", "TKU", "TMC", "TPH", "TPP", "TSB", "TST", "TV3", "V12", "VAT", "VC1", "VCM", "VE2", "VE8", "VGP", "VHL", "VIE", "VIF", "VLA", "VMI", "VMS", "VNC", "VNF", "VTH", "VTL", "VTS", "PVX", "BSR", "AVF", "HVG", "SBS", "OIL", "PVP", "VGI", "BVB", "DCS", "MSR", "AAS", "ABB", "C4G", "PPI", "KSH", "KSK", "VHG", "TOP", "ATA", "VES", "PFL", "VEA", "CDO", "PSG", "QTP", "SPP", "G36", "LTG", "PIV", "DVN", "HLA", "VNH", "DIC", "MIG", "PXL", "DLD", "CTR", "DRI", "PVV", "VNA", "VGT", "NAB", "VOC", "PXM", "HTT", "KHB", "KHL", "VRG", "VCR", "LMH", "BVG", "SGO", "PWA", "VTD", "ASA", "EVF", "QNS", "ACV", "SDD", "TID", "PVM", "ATB", "KLB", "PVE", "TVN", "NTB", "VE9", "SIP", "G20", "POS", "HND", "SSN", "HDO", "AFX", "VTP", "MCH", "ORS", "HSI", "VST", "PAS", "VPC", "MFS", "VVN", "ADG", "VNP", "MPC", "SGP", "PVA", "MML", "NTC", "GTT", "SGB", "MCM", "VCA", "PGB", "SDH", "VTR", "V11", "LMC", "SWC", "S96", "SNZ", "SCL", "VFS", "BOT", "SCJ", "PSP", "ONW", "MLS", "PVO", "XMC", "ABC", "ILA", "V15", "PHH", "HVA", "MTA", "TCW", "HAC", "VCP", "CMT", "PVY", "SAC", "SPV", "STT", "VLC", "VTK", "STH", "VBB", "CC1", "TTN", "VGG", "QNC", "SKN", "PNT", "PGV", "CEN", "VEF", "UDJ", "SZE", "BTD", "BSA", "AIC", "SAS", "M10", "VKD", "VEC", "PSB", "NNG", "RCD", "HAN", "HTM", "TTG", "GHC", "ITS", "NCS", "CMI", "TNS", "XPH", "STL", "DCT", "CAD", "HRT", "DSC", "SD3", "NED", "TGP", "VC5", "HTE", "PXA", "MVC", "FOX", "CNT", "NTW", "FOC", "HNM", "EIN", "HD2", "DDM", "SKH", "SD7", "SKV", "SEA", "L12", "PTE", "PVR", "SP2", "HIG", "NDT", "PSL", "SRB", "EFI", "PRT", "MQN", "BDT", "AGP", "DCF", "VSE", "ABI", "BUD", "NDF", "TNB", "VSN", "DID", "PDV", "CAT", "VGV", "GVT", "LLM", "TCI", "CLX", "VFR", "PCC", "SOV", "PVH", "POV", "DDN", "TLT", "TH1", "VIN", "EPH", "PND", "GND", "HU4", "SDE", "SBD", "VIW", "QHW", "ALV", "DSV", "KHA", "ND2", "CI5", "HEJ", "SD1", "TLP", "C12", "KTL", "TV1", "BT6", "C21", "MH3", "VTE", "ACE", "DNW", "BHK", "VCX", "AGF", "BAB", "APF", "DTC", "ICF", "S12", "IPA", "QSP", "DND", "GGG", "BHC", "CNC", "DRG", "KCB", "NDC", "VLB", "DBH", "DDV", "FRM", "RTS", "TR1", "VNI", "E29", "SRT", "THP", "NHT", "DSP", "IFS", "MTP", "RTH", "SD8", "BHV", "DBM", "DSG", "HNP", "VFC", "BBT", "PMT", "TIS", "DP2", "MKP", "SID", "TDS", "DNY", "TIE", "VSG", "AVC", "CTA", "HD8", "LM3", "POB", "SDX", "BMJ", "CT6", "HD6", "HEM", "HNI", "HPT", "HWS", "NNT", "NS2", "SGS", "ANT", "BDG", "BSL", "PTV", "SDP", "VLG", "DNH", "DPH", "HC3", "MEC", "TMG", "TOT", "GCB", "VET", "CCM", "QPH", "BLI", "HTG", "PPH", "TNW", "VGR", "BWA", "CKD", "CPI", "DVC", "HHV", "HPB", "VNB", "B82", "BSG", "CGV", "DTG", "H11", "HDM", "ICN", "SPC", "VLF", "WSB", "ADP", "BHT", "BWS", "CC4", "DNE", "DTP", "ISH", "KSV", "MGG", "MIC", "PEG", "PTP", "SBH", "ACS", "AMS", "ASD", "BAL", "BHP", "BMF", "BSQ", "BTB", "C71", "CCP", "CHS", "CMN", "CTW", "CYC", "FIC", "FT1", "GSM", "HBD", "HDP", "HKP", "HNE", "HPP", "HSA", "HU6", "ILS", "LIC", "MRF", "NDP", "PBC", "PDT", "PTH", "PTT", "SCC", "SDK", "SPB", "TL4", "TRS", "TUG", "TVA", "TVP", "VTA", "VTX", "VW3", "A32", "ABR", "AC4", "AG1", "AGX", "AMP", "APL", "APT", "AQN", "ATD", "AUM", "BBH", "BBM", "BCB", "BCP", "BDW", "BEL", "BGW", "BHA", "BHG", "BIO", "BKH", "BLN", "BLT", "BLU", "BLW", "BMD", "BMG", "BMN", "BMS", "BMV", "BNW", "BPW", "BQB", "BRR", "BRS", "BSD", "BSH", "BSP", "BT1", "BTG", "BTH", "BTN", "BTR", "BTU", "BTV", "BVN", "BXT", "C22", "C36", "CAB", "CAM", "CBC", "CBI", "CBS", "CCA", "CCH", "CCR", "CCT", "CCV", "CDG", "CDH", "CDP", "CDR", "CE1", "CEC", "CEG", "CFC", "CFV", "CGL", "CH5", "CHC", "CID", "CIP", "CKA", "CKH", "CMD", "CMF", "CMK", "CMP", "CMW", "CNN", "CPA", "CPH", "CPW", "CQN", "CQT", "CSI", "CT3", "CT5", "CTN", "CVH", "CXH", "DAC", "DAP", "DAR", "DAS", "DBW", "DC1", "DCG", "DCH", "DCI", "DCR", "DDH", "DFC", "DGT", "DHB", "DHD", "DHN", "DKC", "DKH", "DLR", "DLT", "DM7", "DNA", "DNB", "DNL", "DNN", "DNR", "DNS", "DNT", "DOC", "DOP", "DP1", "DPP", "DSS", "DT4", "DTB", "DTE", "DTI", "DTV", "DUS", "DVW", "DWS", "DX2", "DXD", "DXL", "E12", "EAD", "EIC", "EME", "EMG", "EMS", "EPC", "FBA", "FBC", "FCC", "FCS", "FDG", "FGL", "FHN", "FHS", "FRC", "FSO", "FTI", "GER", "GLC", "GLW", "GQN", "GTD", "GTH", "GTK", "GTS", "HAB", "HAF", "HAM", "HAV", "HAW", "HBH", "HBW", "HC1", "HCB", "HCI", "HCS", "HDW", "HEC", "HEP", "HES", "HFB", "HFC", "HFS", "HFX", "HGA", "HGC", "HGR", "HGT", "HGW", "HHN", "HHR", "HIZ", "HJC", "HKC", "HLB", "HLE", "HLG", "HLR", "HLS", "HLT", "HMG", "HMS", "HNA", "HNB", "HNF", "HNR", "HNT", "HPD", "HPH", "HPI", "HPU", "HPW", "HRB", "HSM", "HSP", "HTK", "HTR", "HTU", "HTW", "HUG", "HUX", "I10", "IBD", "ICC", "ICI", "IDP", "IFC", "IHK", "IKH", "ILC", "IME", "IN4", "IPH", "IRC", "ISG", "IST", "JOS", "KAC", "KBE", "KCE", "KGM", "KHD", "KHW", "KIP", "KLM", "KSE", "KTB", "KTC", "L44", "L45", "L63", "LAI", "LAW", "LBC", "LCC", "LCW", "LDW", "LG9", "LGM", "LKW", "LMI", "LNC", "LQN", "LTC", "LWS", "MA1", "MBN", "MC3", "MCI", "MCT", "MDA", "MDF", "MDN", "MDT", "MEF", "MEG", "MES", "MGC", "MHP", "MHY", "MIE", "MLC", "MNB", "MND", "MPY", "MQB", "MTB", "MTC", "MTG", "MTH", "MTL", "MTM", "MTS", "MTV", "MVN", "MVY", "MXC", "NAC", "NAS", "NAU", "NAW", "NBE", "NBR", "NBT", "NCP", "NDW", "NHV", "NJC", "NLS", "NMK", "NNB", "NNQ", "NOS", "NQB", "NQN", "NQT", "NS3", "NSG", "NSL", "NSS", "NTF", "NTR", "NTT", "NUE", "NVP", "NWT", "PAI", "PBT", "PCF", "PCM", "PCN", "PEC", "PEQ", "PHS", "PID", "PIS", "PJS", "PKR", "PLA", "PLE", "PLO", "PMJ", "PMW", "PNG", "PNP", "PQN", "PRO", "PSN", "PTG", "PTK", "PTO", "PTX", "PWS", "PX1", "PXC", "PYU", "QBR", "QCC", "QLD", "QLT", "QNT", "QNU", "QNW", "RAT", "RBC", "RCC", "RGC", "RHN", "RLC", "RTB", "S27", "S72", "SAL", "SAP", "SB1", "SBL", "SBM", "SBR", "SCA", "SCO", "SCY", "SDB", "SDJ", "SDV", "SDY", "SEP", "SHC", "SHG", "SHX", "SIG", "SIV", "SJG", "SJM", "SNC", "SON", "SPA", "SPD", "SPH", "SQC", "SSF", "SSG", "SSU", "STS", "STU", "STV", "STW", "SUM", "SVG", "SVH", "SVL", "T12", "TA3", "TA6", "TAG", "TAN", "TAP", "TAW", "TB8", "TBD", "TBT", "TCJ", "TCK", "TDB", "TDF", "TEC", "TEL", "THN", "THR", "THU", "THW", "TKA", "TLI", "TMW", "TNM", "TNP", "TOW", "TPS", "TQN", "TQW", "TRT", "TS3", "TS5", "TSD", "TSG", "TSJ", "TTD", "TTJ", "TTP", "TTS", "TTV", "TVG", "TVH", "TVM", "TVU", "TVW", "TW3", "UCT", "UDL", "UEM", "UMC", "UPC", "UPH", "USC", "USD", "VAV", "VBG", "VBH", "VCE", "VCT", "VCW", "VDB", "VDM", "VDN", "VDT", "VGL", "VHD", "VHF", "VHH", "VHI", "VIH", "VIM", "VIR", "VKP", "VLP", "VLW", "VMA", "VMG", "VNX", "VNY", "VPA", "VPR", "VPW", "VQC", "VSF", "VSP", "VTG", "VTI", "VTM", "VWS", "VXP", "VXT", "WTC", "X26", "X77", "XDH", "XHC", "XLV", "XMD", "YBC", "YRC", "YTC" };
        List<string> codes = new List<string> { "HAG" };
        private IWebHostEnvironment _hostingEnvironment;
        private IRepositoryWrapper _repositoryWrapper;
        private ILogger<StockCrawlerService> _logger;

        public StockCrawlerService(
            IWebHostEnvironment hostingEnvironment,
            IRepositoryWrapper repositoryWrapper,
            ILogger<StockCrawlerService> logger)
        {
            _hostingEnvironment = hostingEnvironment;
            _repositoryWrapper = repositoryWrapper;
            _logger = logger;
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddUserProfilePreference("download.default_directory", @"D:\Workspace\test");
            //chromeOptions.AddUserProfilePreference("intl.accept_languages", "nl");
            //chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");

        }
        public List<string> GetStockList()
        {

            //driver.Navigate().GoToUrl("https://dstock.vndirect.com.vn/tong-quan/HVH");
            //var td = driver.FindElementsByClassName("row-col__text");
            //return td.Select(x => x.Text).ToList();
            return null;
        }

        public void CrawlerVNDirectStockInformation()
        {
            var driver = new ChromeDriver();
            foreach (var code in codes)
            {
                try
                {
                    driver.Navigate().GoToUrl("https://dstock.vndirect.com.vn/tong-quan/" + code);
                    var texts = driver.FindElementsByClassName("row-col__text");
                    var textList = texts.Select(x => x.Text).ToList();
                    var stockIndex = new StockIndex {
                        Code = code,
                        
                       
                        VonHoaThiTruong = long.Parse(textList[6].Replace(" tỷ", ""), System.Globalization.NumberStyles.AllowThousands),

                        SoCPLuuHanh = textList[10],
                        FreeFloat = textList[11] == "N/A" ? 0 : float.Parse(textList[11].Replace("%", "")),

                    TySuatCoTuc = textList[17],

                    };
                    stockIndex.KLGDTrongPhien = long.Parse(textList[0], System.Globalization.NumberStyles.AllowThousands);
                    stockIndex.GiaTran = textList[1] == "N/A" ? 0 : float.Parse(textList[1]);
                    stockIndex.GiaSan = textList[2] == "N/A" ? 0 : float.Parse(textList[2]);
                    stockIndex.GiaMoCua = textList[3] == "N/A" ? 0 : float.Parse(textList[3]);
                    stockIndex.GiaCaoNhat = textList[4] == "N/A" ? 0 : float.Parse(textList[4]);
                    stockIndex.GiaThapNhat = textList[5] == "N/A" ? 0 : float.Parse(textList[5]);
                    stockIndex.KLGDTrungBinh10Phien = long.Parse(textList[7], System.Globalization.NumberStyles.AllowThousands);
                    stockIndex.CaoNhat52Tuan = textList[8] == "N/A" ? 0 : float.Parse(textList[8]);
                    stockIndex.ThapNhat52Tuan = textList[9] == "N/A" ? 0 : float.Parse(textList[9]);
                    stockIndex.EPS = textList[18] == "N/A" ? 0 : float.Parse(textList[18], System.Globalization.NumberStyles.AllowThousands);
                    stockIndex.BVPS = textList[19] == "N/A" ? 0 : float.Parse(textList[19], System.Globalization.NumberStyles.AllowThousands);
                    stockIndex.Beta = textList[12] == "N/A" ? 0 : float.Parse(textList[12]);
                    stockIndex.PE = textList[13] == "N/A" ? 0 : float.Parse(textList[13].Replace("x", ""));
                    stockIndex.PB = textList[14] == "N/A" ? 0 : float.Parse(textList[14].Replace("x", ""));
                    stockIndex.ROAE = textList[15] == "N/A" ? 0 : float.Parse(textList[15].Replace("x", ""));
                    stockIndex.ROAA = textList[16] == "N/A" ? 0 : float.Parse(textList[16].Replace("x", ""));

                    if (_repositoryWrapper.StockIndex.GetStockInformationByCodeAndDate(stockIndex.Code, stockIndex.InforDate) == null)
                        _repositoryWrapper.StockIndex.CreateAsync(stockIndex).ConfigureAwait(false);


                    _repositoryWrapper.SaveChange();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    driver.Close();
                }
            }
        }

        public async Task CrawlerStockGroupInformation()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.cophieu68.vn/categorylist.php#");
                var table = driver.FindElementByXPath(@"//*[@id='begin_header']/table/tbody/tr/td/table[2]");
                IList<IWebElement> tableRows = table.FindElements(By.TagName("tr"));
                IList<IWebElement> tableCells;
                foreach (IWebElement row in tableRows.Skip(1))
                {
                    tableCells = row.FindElements(By.TagName("td"));
                    var name = tableCells[1].Text.Split("\r")[0];
                    var code = tableCells[1].Text.Split("\n")[1];
                    var stockGroup = _repositoryWrapper.StockGroup.GetDBSet().FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
                    if (stockGroup == null)

                        stockGroup = new StockGroup();
                    stockGroup.Name = name;
                    stockGroup.Code = code;
                    stockGroup.AvgEPS = float.Parse(tableCells[3].Text);
                    stockGroup.AvgPE = float.Parse(tableCells[4].Text.Replace("%", ""));
                    stockGroup.AvgROA = float.Parse(tableCells[5].Text.Replace("%", ""));
                    stockGroup.AvgROE = float.Parse(tableCells[6].Text.Replace("%", ""));
                    stockGroup.AvgPrice = float.Parse(tableCells[7].Text);
                    stockGroup.ComparePrice = float.Parse(tableCells[8].Text);
                    stockGroup.AvgPB = float.Parse(tableCells[9].Text.Replace("%", ""));
                    stockGroup.AvgBeta = float.Parse(tableCells[10].Text.Replace("%", ""));
                    stockGroup.TongKL = long.Parse(tableCells[11].Text.Replace("%", ""), System.Globalization.NumberStyles.AllowThousands);
                    stockGroup.NNSoHuu = long.Parse(tableCells[12].Text.Split("\r")[0].Replace("%", ""), System.Globalization.NumberStyles.AllowThousands);
                    stockGroup.VonTT = long.Parse(tableCells[13].Text.Replace("%", ""), System.Globalization.NumberStyles.AllowThousands);

                    await _repositoryWrapper.StockGroup.CreateAsync(stockGroup);
                    //var test = tableCells.Select(x => x.Text).ToList();
                }
            }
        }

        public async Task CrawlerStockInformation()
        {
            //var stockGroups = _stockGroupRepository.GetDBSet().AsNoTracking().ToList();
            //using (var driver = new ChromeDriver())
            //{
            //    foreach (var stockGroup in stockGroups)
            //    {
            //        var url = "https://www.cophieu68.vn/categorylist_detail.php?category=" + stockGroup.Code;
            //        try
            //        {
            //            driver.Navigate().GoToUrl(url);
            //            var table = driver.FindElement(By.XPath(@"/html/body/table/tbody/tr/td/table[2]"));
            //            IList<IWebElement> tableRows = table.FindElements(By.TagName("tr"));
            //            IList<IWebElement> tableCells;
            //            var listStock = new List<StockMainInformation>();
            //            foreach (IWebElement row in tableRows.Skip(1))
            //            {
            //                tableCells = row.FindElements(By.TagName("td"));
            //                var code = tableCells[1].Text;
            //                var stock = _stockMainInformationRepository.GetDBSet().AsNoTracking().FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
            //                var isUpdate = stock != null;
            //                if (stock == null)

            //                    stock = new StockMainInformation();
            //                stock.Code = code;
            //                stock.Group = stockGroup.Code;
            //                stock.AvgEPS = float.Parse(tableCells[3].Text);
            //                stock.AvgPE = float.Parse(tableCells[4].Text.Replace("%", ""));
            //                stock.AvgROA = float.Parse(tableCells[5].Text.Replace("%", ""));
            //                stock.AvgROE = float.Parse(tableCells[6].Text.Replace("%", ""));
            //                //stock.AvgPrice = float.Parse(tableCells[7].Text);
            //                stock.ComparePrice = float.Parse(tableCells[7].Text);
            //                stock.AvgPB = float.Parse(tableCells[8].Text.Replace("%", ""));
            //                stock.AvgBeta = float.Parse(tableCells[9].Text.Replace("%", ""));
            //                stock.TongKL = long.Parse(tableCells[10].Text.Replace("%", ""), System.Globalization.NumberStyles.AllowThousands);
            //                stock.NNSoHuu = long.Parse(tableCells[11].Text.Split("\r")[0].Replace("%", ""), System.Globalization.NumberStyles.AllowThousands);
            //                stock.VonTT = long.Parse(tableCells[12].Text.Replace("%", ""), System.Globalization.NumberStyles.AllowThousands);

            //                listStock.Add(stock);
            //                if (isUpdate)
            //                    await _stockMainInformationRepository.UpdateAsync(stock);
            //                else
            //                    await _stockMainInformationRepository.CreateAsync(stock);
            //            }

            //        }
            //        catch (Exception e)
            //        {

            //        }
            //    }
            //    driver.Close();
            //}
            await CrawlerStockCompanyInformation();
        }

        public async Task CrawlerStockCompanyInformation()
        {
            var stocks = _repositoryWrapper.StockMainInformation.GetDBSet().ToList();
            var parsingText = "";
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                var configFilePath = Path.Combine(_hostingEnvironment.WebRootPath, "crawler", "StockCompany.json");
                var configuration = JObject.Parse(File.ReadAllText(configFilePath));
                var companyNameXPath = configuration.GetValue("groupName")?.Value<string>();
                var groupNameXPath = configuration.GetValue("companyName")?.Value<string>();
                var listedAtXPath = configuration.GetValue("listedAt")?.Value<string>();
                var mainShareholderXPath = configuration.GetValue("mainShareholder")?.Value<string>();
                var leadershipLinkXPath = configuration.GetValue("leadershipLink")?.Value<string>();
                var commonInforClass = configuration.GetValue("commonInforClass")?.Value<string>();
                var groupNameClass = configuration.GetValue("groupNameClass")?.Value<string>();
                foreach (var stock in stocks)
                {
                    var urlHoSoDoanhNghiep = "https://dstock.vndirect.com.vn/ho-so-doanh-nghiep/" + stock.Code;
                    var urlTongQuan = "https://dstock.vndirect.com.vn/tong-quan/" + stock.Code;
                    try
                    {
                        driver.Navigate().GoToUrl(urlHoSoDoanhNghiep);
                        Thread.Sleep(3000);
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver; ;
                        js.ExecuteScript("" +
                            "if (document.getElementById('___reactour') != null)" +
                            "   return document.getElementById('___reactour').remove();" +
                            "else" +
                            "   return;");

                        var company = _repositoryWrapper.StockCompany.GetDBSet().FirstOrDefault(x => x.Code.ToLower() == stock.Code.ToLower());
                        if (company == null)
                            company = new StockCompany();
                        company.Code = stock.Code;
                        company.GroupName = driver.FindElements(By.ClassName(groupNameClass))[0].Text;
                        company.Name = driver.FindElement(By.XPath(groupNameXPath)).Text;
                        company.ListedAt = driver.FindElements(By.ClassName(groupNameClass))[1].Text;

                        driver.Navigate().GoToUrl(urlTongQuan);
                        Thread.Sleep(3000);
                        js.ExecuteScript("" +
                            "if (document.getElementById('___reactour') != null)" +
                            "   return document.getElementById('___reactour').remove();" +
                            "else" +
                            "   return;");

                        ///Get common information
                        ///
                        var commonStockInformation = _repositoryWrapper.StockIndex.GetDBSet().FirstOrDefault(x => x.Code.ToLower() == stock.Code.ToLower());
                        if (commonStockInformation == null)
                            commonStockInformation = new StockIndex() { Code = stock.Code};
                        var texts = driver.FindElementsByClassName("row-col__text").Select(x => x.Text).ToList();
                        parsingText = string.Join(";", texts);
                        commonStockInformation.VonHoaThiTruong = texts[1] == "N/A" ? 0 : long.Parse(texts[6].Replace(" tỷ", ""), System.Globalization.NumberStyles.AllowThousands);

                        commonStockInformation.SoCPLuuHanh = texts[10];
                        commonStockInformation.FreeFloat = texts[11] == "N/A" ? 0 : float.Parse(texts[11].Replace("%", ""));

                        commonStockInformation.TySuatCoTuc = texts[17];
                        commonStockInformation.KLGDTrongPhien = texts[1] == "N/A" ? 0 : long.Parse(texts[0], System.Globalization.NumberStyles.AllowThousands);
                        commonStockInformation.GiaTran = texts[1] == "N/A" ? 0 : float.Parse(texts[1]);
                        commonStockInformation.GiaSan = texts[2] == "N/A" ? 0 : float.Parse(texts[2]);
                        commonStockInformation.GiaMoCua = texts[3] == "N/A" ? 0 : float.Parse(texts[3]);
                        commonStockInformation.GiaCaoNhat = texts[4] == "N/A" ? 0 : float.Parse(texts[4]);
                        commonStockInformation.GiaThapNhat = texts[5] == "N/A" ? 0 : float.Parse(texts[5]);
                        commonStockInformation.KLGDTrungBinh10Phien = texts[1] == "N/A" ? 0 : long.Parse(texts[7], System.Globalization.NumberStyles.AllowThousands);
                        commonStockInformation.CaoNhat52Tuan = texts[8] == "N/A" ? 0 : float.Parse(texts[8]);
                        commonStockInformation.ThapNhat52Tuan = texts[9] == "N/A" ? 0 : float.Parse(texts[9]);
                        commonStockInformation.EPS = texts[18] == "N/A" ? 0 : float.Parse(texts[18], System.Globalization.NumberStyles.AllowThousands);
                        commonStockInformation.BVPS = texts[19] == "N/A" ? 0 : float.Parse(texts[19], System.Globalization.NumberStyles.AllowThousands);
                        commonStockInformation.Beta = texts[12] == "N/A" ? 0 : float.Parse(texts[12]);
                        commonStockInformation.PE = texts[13] == "N/A" ? 0 : float.Parse(texts[13].Replace("x", ""));
                        commonStockInformation.PB = texts[14] == "N/A" ? 0 : float.Parse(texts[14].Replace("x", ""));
                        commonStockInformation.ROAE = texts[15] == "N/A" ? 0 : float.Parse(texts[15].Replace("x", "").Replace("%", ""));
                        commonStockInformation.ROAA = texts[16] == "N/A" ? 0 : float.Parse(texts[16].Replace("x", "").Replace("%", ""));

                        await _repositoryWrapper.StockIndex.UpdateAsync(commonStockInformation);
                        await _repositoryWrapper.SaveChangeAsync();


                    var mainShareholderTbl = driver.FindElement(By.XPath(mainShareholderXPath)).FindElements(By.TagName("tr"));
                        List<StockShareholder> mainShareholder = new List<StockShareholder>();
                        
                        if (mainShareholderTbl != null && mainShareholderTbl.Count > 1)
                        {
                            foreach (var mainShareholderRow in mainShareholderTbl.Skip(1))
                            {
                                var cells = mainShareholderRow.FindElements(By.TagName("td"));
                                mainShareholder.Add(new StockShareholder {
                                    Name = cells[0].Text,
                                    SharePercent = float.Parse(cells[1].Text.Replace("%", ""))
                                });
                            }
                        }
                      

                        driver.Navigate().GoToUrl(urlTongQuan);
                        Thread.Sleep(3000);
                        js.ExecuteScript("" +
                            "if (document.getElementById('___reactour') != null)" +
                            "   return document.getElementById('___reactour').remove();" +
                            "else" +
                            "   return;");

                        driver.FindElement(By.XPath(leadershipLinkXPath)).Click();

                        var leadershipTbl = driver.FindElement(By.XPath(mainShareholderXPath)).FindElements(By.TagName("tr"));
                        List<StockCompanyLeadership> leaderships = new List<StockCompanyLeadership>();
                        if (leadershipTbl != null && leadershipTbl.Count > 1)
                        {
                            foreach (var leadershipRow in leadershipTbl.Skip(1))
                            {
                                var cells = leadershipRow.FindElements(By.TagName("td"));
                                leaderships.Add(new StockCompanyLeadership {
                                    Name = cells[0].Text,
                                    Position = cells[1].Text
                                });
                            }
                        }
                        

                        foreach (var item in company.Leaderships)
                        {
                            company.Leaderships.Remove(item);
                        }

                        foreach (var item in company.MainShareholder)
                        {
                            company.MainShareholder.Remove(item);
                        }

                        company.Leaderships = leaderships;
                        company.MainShareholder = mainShareholder;

                        await _repositoryWrapper.StockCompany.SaveAsync(company);
                        await _repositoryWrapper.SaveChangeAsync();

                        await CrawlerTransactionHistory(company.Code, driver);
                        await _repositoryWrapper.SaveChangeAsync();

                    }
                    catch (Exception e)
                    {
                        _logger.LogError($"fail on update for stock {stock.Code} ======= {parsingText}", e);
                        _logger.LogError(e.Message);
                        _logger.LogError(e.StackTrace);
                    }
                }
                driver.Close();
                driver.Quit();
            }

        }

        public async Task CrawlerTransactionHistory(string code, ChromeDriver driver)
        {
            var url = "https://dstock.vndirect.com.vn/lich-su-gia/" + code;
            var parsingText = "";
            try
            {
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(3000);
                var transactionTbl = driver.FindElement(By.XPath("//*[@id='sub-menu-content']/div/div/div[2]/div[3]/div/div[2]/div/table[2]"));
                var transactionRecord = transactionTbl.FindElement(By.TagName("tbody")).FindElements(By.TagName("tr"));
                foreach (var transaction in transactionRecord)
                {
                    var transactionTexts = transaction.FindElements(By.TagName("td"));
                    parsingText = string.Join(";", transactionTexts.Select(x => x.Text).ToList());
                    var transactionInDb = _repositoryWrapper.StockTransactionHistory.GetByCodeAndDate(code, transactionTexts[1].Text);
                    if (transactionInDb == null)
                        transactionInDb = new StockTransactionHistory {
                            TransactionDate = DateTime.Now,
                            Code = code,
                        };

                    transactionInDb.GiaMoCua = float.Parse(transactionTexts[2].Text);
                    transactionInDb.GiaThapNhat = float.Parse(transactionTexts[3].Text);
                    transactionInDb.GiaCaoNhat = float.Parse(transactionTexts[4].Text);
                    transactionInDb.GiaDongCua = float.Parse(transactionTexts[5].Text);
                    transactionInDb.GiaBinhQuan = float.Parse(transactionTexts[6].Text);
                    transactionInDb.GiaDongCuaDieuChinh = float.Parse(transactionTexts[7].Text);
                    transactionInDb.KhoiLuongKhopLenh = long.Parse(transactionTexts[8].Text, System.Globalization.NumberStyles.AllowThousands);
                    transactionInDb.KhoiLuongThoaThuan  = long.Parse(transactionTexts[9].Text, System.Globalization.NumberStyles.AllowThousands);
                    await _repositoryWrapper.StockTransactionHistory.UpdateAsync(transactionInDb);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"fail on update for stock transaction {code} ======= {parsingText}", ex);
            }
        }
    }
}
