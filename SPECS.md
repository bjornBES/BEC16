# OVERVIEW
- Name: BEC-16
- 16-bit data width
- 24-bit address bus
- Device communication via dedicated I/O instructions

## REGISTER

### GP Registers

| Register Name | Size | Purpose         | High 8-bit | Low 8-bit |
| ------------- | :--: | --------------- | ---------- | --------- |
| R0            |  16  | General purpose | HR0        | LR0       |
| R1            |  16  | General purpose | HR1        | LR1       |
| R2            |  16  | General purpose | HR2        | LR2       |
| R3            |  16  | General purpose | HR3        | LR3       |
| R4            |  16  | General purpose | HR4        | LR4       |
| R5            |  16  | General purpose | HR5        | LR5       |
| R6            |  16  | General purpose | HR6        | LR6       |
| R7            |  16  | General purpose | HR7        | LR7       |
| R8            |  16  | General purpose | -          | -         |
| R9            |  16  | General purpose | -          | -         |
| R10           |  16  | General purpose | -          | -         |
| R11           |  16  | General purpose | -          | -         |
| R12           |  16  | General purpose | -          | -         |
| R13           |  16  | General purpose | -          | -         |
| R14           |  16  | General purpose | -          | -         |
| R15           |  16  | General purpose | -          | -         |

### Special Purpose Registers

| Register Name | Alias | Size | Purpose         | High 8-bit | Low 8-bit  |
| ------------- | ----- | :--: | --------------- | ---------- | ---------- |
| SPR0          | STP   |  16  | Stack Pointer   | HSPR0/HSTP | LSPR0/LSTP |
| SPR1          | FRP   |  16  | Frame Pointer   | HSPR1/HFRP | LSPR1/LFRP |
| SPR2          | STS   |  16  | Stack Segment   | -          | -          |
| SPR3          | PRS   |  16  | Program Segment | -          | -          |
| SPR4          | DAS   |  16  | Data Segment    | -          | -          |
| SPR5          | PC    |  16  | Program Counter | -          | -          |
| SPR6          | F     |  16  | Flags Register  | -          | -          |

 

## MEMORY


| Start       | End         | Size | Name            | Purpose                         |
| ----------- | ----------- | ---- | --------------- | ------------------------------- |
| `0x00:0000` | `0x00:0000` |      |                 |                                 |
| `0xFF:FF00` | `0xFF:FFFF` | 256  | Reset bootstrap | This is where is program starts |

## INSTRUCTIONS

The instruction set is [Here](https://docs.google.com/spreadsheets/d/1fCc9ESyu2Ck7R39FnHpCwMWISt7gwmUjXfv2CudknnU/edit?usp=sharing)