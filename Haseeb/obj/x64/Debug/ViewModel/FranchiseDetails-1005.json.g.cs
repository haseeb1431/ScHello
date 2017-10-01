// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\FranchiseDetails.json"
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
using __Franchis1__ = global::Haseeb.ViewModel.FranchiseDetails.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrCreateFr__ = global::Haseeb.ViewModel.FranchiseDetails.Input.CreateFranchiseTrigger;
using __FrFranchis__ = global::Haseeb.ViewModel.FranchiseDetails.Input.FranchiseName;
using __FrHtml__ = global::Haseeb.ViewModel.FranchiseDetails.Input.Html;
using __Franchis2__ = global::Haseeb.ViewModel.FranchiseDetails.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Haseeb.ViewModel.FranchiseDetails.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Haseeb.ViewModel.FranchiseDetails;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseDetails_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseDetails : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetails() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetails(__FrSchema__ template) { Template = template; }
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
                FranchiseName = Add<__TString__>("FranchiseName$");
                FranchiseName.DefaultValue = "";
                FranchiseName.Editable = true;
                FranchiseName.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                CreateFranchiseTrigger = Add<__TLong__>("CreateFranchiseTrigger$");
                CreateFranchiseTrigger.DefaultValue = 0L;
                CreateFranchiseTrigger.Editable = true;
                CreateFranchiseTrigger.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__CreateFranchiseTrigger__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__CreateFranchiseTrigger__ = (System.Int64)_v_; }, false);
                CreateFranchiseTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateFranchiseTrigger() { App = (FranchiseDetails)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetails)pup).Handle((Input.CreateFranchiseTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ FranchiseName;
            public __TLong__ CreateFranchiseTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\FranchiseDetails.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\FranchiseDetails.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FranchiseName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FranchiseName {
    #line 3 "ViewModel\FranchiseDetails.json"
        get {
        #line hidden
            return Template.FranchiseName.Getter(this); }
        #line 3 "ViewModel\FranchiseDetails.json"
        set {
        #line hidden
            Template.FranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CreateFranchiseTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateFranchiseTrigger {
    #line 4 "ViewModel\FranchiseDetails.json"
        get {
        #line hidden
            return Template.CreateFranchiseTrigger.Getter(this); }
        #line 4 "ViewModel\FranchiseDetails.json"
        set {
        #line hidden
            Template.CreateFranchiseTrigger.Setter(this, value); } }
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
        public class CreateFranchiseTrigger : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
