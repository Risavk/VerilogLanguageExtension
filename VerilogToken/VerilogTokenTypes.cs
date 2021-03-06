﻿//***************************************************************************
// 
//  MIT License
//
//  Copyright(c) 2019 gojimmypi
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
//
//***************************************************************************


namespace VerilogLanguage.VerilogToken
{
    public enum VerilogTokenTypes
    {
        Verilog_always,
        Verilog_assign, // assign of reg data types is not supported. But assign on wire data type is supported.
        Verilog_automatic,
        Verilog_begin,
        Verilog_case,
        Verilog_casex,
        Verilog_casez,
        Verilog_cell,
        Verilog_config,
        Verilog_deassign, // Not Supported in Synthesis 
        Verilog_default,
        Verilog_defparam,
        Verilog_design,
        Verilog_disable,
        Verilog_edge,
        Verilog_else,
        Verilog_end,
        Verilog_endcase,
        Verilog_endconfig,
        Verilog_endfunction,
        Verilog_endgenerate,
        Verilog_endmodule,
        Verilog_endprimitive,
        Verilog_endspecify,
        Verilog_endtable,
        Verilog_endtask,
        Verilog_event,
        Verilog_for,
        Verilog_force,
        Verilog_forever,
        Verilog_fork, // Not Supported in Synthesis; Use nonblocking assignments to get same effect.
        Verilog_function,
        Verilog_generate,
        Verilog_genvar,
        Verilog_if,
        Verilog_ifnone,
        Verilog_incdir,
        Verilog_include,
        Verilog_initial, // Used only in test benches.
        Verilog_inout,
        Verilog_input,
        Verilog_instance,
        Verilog_join,  // Not Supported in Synthesis; Use nonblocking assignments to get same effect.
        Verilog_liblist,
        Verilog_library,
        Verilog_localparam,
        Verilog_macromodule,
        Verilog_module,
        Verilog_negedge,
        Verilog_noshowcancelled,
        Verilog_output,
        Verilog_parameter,
        Verilog_posedge,
        Verilog_primitive, // Only gate level primitives are supported.
        Verilog_pulsestyle_ondetect,
        Verilog_pulsestyle_onevent,
        Verilog_reg,
        Verilog_release,
        Verilog_repeat,
        Verilog_scalared,
        Verilog_showcancelled,
        Verilog_signed,
        Verilog_specify,
        Verilog_specparam,
        Verilog_strength,
        Verilog_table, // UDP and tables are not supported.
        Verilog_task,
        Verilog_tri,
        Verilog_tri0,
        Verilog_tri1,
        Verilog_triand,
        Verilog_wand,
        Verilog_trior,
        Verilog_wor,
        Verilog_trireg,
        Verilog_unsigned,
        Verilog_use,
        Verilog_vectored,
        Verilog_wait,
        Verilog_while,
        Verilog_wire,

        Verilog_Directive, // note that all directives are colorized the same

        //
        Verilog_Comment,
        Verilog_Bracket,
        Verilog_Bracket0,
        Verilog_Bracket1,
        Verilog_Bracket2,
        Verilog_Bracket3,
        Verilog_Bracket4,
        Verilog_Bracket5,
        Verilog_BracketContent,
        
        Verilog_Variable,
        Verilog_Variable_input,
        Verilog_Variable_output,
        Verilog_Variable_inout,
        Verilog_Variable_wire,
        Verilog_Variable_reg,
        Verilog_Variable_localparam,
        Verilog_Variable_parameter,
        Verilog_Variable_duplicate, // special highlight value if a duplicate declaration is detected
        Verilog_Variable_module,    // instantiation of modules are handled essentially as typed variables
 
        Verilog_Primitive_and,
        Verilog_Primitive_nand,
        Verilog_Primitive_or,
        Verilog_Primitive_nor,
        Verilog_Primitive_xor,
        Verilog_Primitive_xnor,
        Verilog_Primitive_not,

        Verilog_Value

    }
}
