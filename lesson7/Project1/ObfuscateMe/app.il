
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:2:2:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:1:2:0
}
.assembly ObfuscateMe
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 33 2E 31 01 00 54 0E 14   // ersion=v3.1..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 0B 4F 62 66 75 73 63 61 74 65 4D 65 00 00 ) // ...ObfuscateMe..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0B 4F 62 66 75 73 63 61 74 65 4D 65 00 00 ) // ...ObfuscateMe..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0B 4F 62 66 75 73 63 61 74 65 4D 65 00 00 ) // ...ObfuscateMe..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module ObfuscateMe.dll
// MVID: {6E77634A-A809-406D-AFC5-017697CD05E9}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06D50000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit ObfuscateMe.Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       60 (0x3c)
    .maxstack  2
    .locals init (string V_0,
             string V_1,
             bool V_2)
    IL_0000:  nop
    IL_0001:  ldstr      "123456"
    IL_0006:  stloc.0
    IL_0007:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3F 04 30 04 40 04 3E 04 3B 04 4C 04 20 00 34 04   // ?.0.@.>.;.L. .4.
                                    3B 04 4F 04 20 00 34 04 3E 04 41 04 42 04 43 04   // ;.O. .4.>.A.B.C.
                                    3F 04 30 04 3A 00 20 00 )                         // ?.0.:. .
    IL_000c:  call       void [System.Console]System.Console::Write(string)
    IL_0011:  nop
    IL_0012:  call       string [System.Console]System.Console::ReadLine()
    IL_0017:  stloc.1
    IL_0018:  ldloc.1
    IL_0019:  ldloc.0
    IL_001a:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_001f:  stloc.2
    IL_0020:  ldloc.2
    IL_0021:  brtrue.s  IL_0030

    IL_0023:  ldstr      bytearray (14 04 3E 04 31 04 40 04 3E 04 20 00 3F 04 3E 04   // ..>.1.@.>. .?.>.
                                    36 04 30 04 3B 04 3E 04 32 04 30 04 42 04 4C 04 ) // 6.0.;.>.2.0.B.L.
    IL_0028:  call       void [System.Console]System.Console::WriteLine(string)
    IL_002d:  nop
    IL_002e:  br.s       IL_003b

    IL_0030:  ldstr      bytearray (12 04 20 00 34 04 3E 04 41 04 42 04 43 04 3F 04   // .. .4.>.A.B.C.?.
                                    35 04 20 00 3E 04 42 04 3A 04 30 04 37 04 30 04   // 5. .>.B.:.0.7.0.
                                    3D 04 3E 04 )                                     // =.>.
    IL_0035:  call       void [System.Console]System.Console::WriteLine(string)
    IL_003a:  nop
    IL_003b:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class ObfuscateMe.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 D:\Projects\geekbrainscsharp\lesson7\Project1\ObfuscateMe\app.res
