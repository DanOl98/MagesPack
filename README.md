# SG0MPK
Steins Gate 0 MPK UnPack &amp; RePack. Fixed mpk creation with correct mpk structure. 
# Structure

## Header
##### Total 8 bytes
The header of the MPK is

Name | Size | Values |
--- | --- | --- 
**IDENT** | 4 bytes | "MPK"\0
Null Bytes | 2 bytes | \0\0
Two | 2 bytes | 0x2

## File count
##### Total 56 bytes
Name | Size |
--- | --- 
File count | 8 bytes
Null Bytes | 6 * 8 bytes

## File information
##### Total 256 bytes(each)
Repeat this `File count` times

Name | Size |
--- | --- 
isCompressed | 4 bytes
Index | 4 bytes
Position | 8 bytes
Size | 8 bytes
Compressed Size (if not compressed it's the same as Size) | 8 bytes
Null terminated file name | 224 bytes

## Raw data
##### Total n bytes(each)
Repeat this `File count` times

Name | Size |
--- | --- 
Raw data | `Size` bytes from respective info structure
