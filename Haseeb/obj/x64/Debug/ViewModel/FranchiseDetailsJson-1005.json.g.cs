// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\FranchiseDetailsJson.json"
// Version: 1005
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
using Haseeb.Models;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Haseeb.ViewModel {
using __Franchis2__ = global::Haseeb.ViewModel.FranchiseDetailsJson.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrSalesTre__ = global::Haseeb.ViewModel.FranchiseDetailsJson.Input.SalesTrend;
using __FrTotalCom__ = global::Haseeb.ViewModel.FranchiseDetailsJson.Input.TotalCommission;
using __FrAverageC__ = global::Haseeb.ViewModel.FranchiseDetailsJson.Input.AverageCommission;
using __FrHouseSol__ = global::Haseeb.ViewModel.FranchiseDetailsJson.Input.HouseSold;
using __FrFranchis__ = global::Haseeb.ViewModel.FranchiseDetailsJson.Input.FranchiseName;
using __FrHtml__ = global::Haseeb.ViewModel.FranchiseDetailsJson.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis1__ = global::Haseeb.ViewModel.FranchiseDetailsJson.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Haseeb.ViewModel.FranchiseDetailsJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Haseeb.ViewModel.FranchiseDetailsJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseDetailsJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseDetailsJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailsJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailsJson(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Haseeb/FranchiseDetailsJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                FranchiseName = Add<__TString__>("FranchiseName");
                FranchiseName.DefaultValue = "";
                FranchiseName.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                HouseSold = Add<__TLong__>("HouseSold", bind:"HouseSold");
                HouseSold.DefaultValue = 0L;
                HouseSold.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HouseSold__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HouseSold__ = (System.Int64)_v_; }, false);
                AverageCommission = Add<__TLong__>("AverageCommission", bind:"AverageCommission");
                AverageCommission.DefaultValue = 0L;
                AverageCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AverageCommission__ = (System.Int64)_v_; }, false);
                TotalCommission = Add<__TLong__>("TotalCommission", bind:"TotalCommission");
                TotalCommission.DefaultValue = 0L;
                TotalCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                SalesTrend = Add<__TLong__>("SalesTrend", bind:"SalesTrend");
                SalesTrend.DefaultValue = 0L;
                SalesTrend.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SalesTrend__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SalesTrend__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ FranchiseName;
            public __TLong__ HouseSold;
            public __TLong__ AverageCommission;
            public __TLong__ TotalCommission;
            public __TLong__ SalesTrend;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\FranchiseDetailsJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\FranchiseDetailsJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FranchiseName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FranchiseName {
    #line 3 "ViewModel\FranchiseDetailsJson.json"
        get {
        #line hidden
            return Template.FranchiseName.Getter(this); }
        #line 3 "ViewModel\FranchiseDetailsJson.json"
        set {
        #line hidden
            Template.FranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__HouseSold__;
    #line default
    #line hidden
    private System.Int64 __bf__AverageCommission__;
    #line default
    #line hidden
    private System.Int64 __bf__TotalCommission__;
    #line default
    #line hidden
    private System.Int64 __bf__SalesTrend__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FranchiseName : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HouseSold : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AverageCommission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalCommission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SalesTrend : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
