// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModel\CorporationJson.json"
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
using __Corporat1__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoCreateCo__ = global::Haseeb.ViewModel.CorporationJson.Input.CreateCorpTrigger;
using __CoCorpName__ = global::Haseeb.ViewModel.CorporationJson.Input.CorpName;
using __CoHtml__ = global::Haseeb.ViewModel.CorporationJson.Input.Html;
using __Corporat2__ = global::Haseeb.ViewModel.CorporationJson.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::Haseeb.ViewModel.CorporationJson;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CorporationJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationJson(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Haseeb/CorporationJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CorpName = Add<__TString__>("CorpName$");
                CorpName.DefaultValue = "";
                CorpName.Editable = true;
                CorpName.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__CorpName__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__CorpName__ = (System.String)_v_; }, false);
                CreateCorpTrigger = Add<__TLong__>("CreateCorpTrigger$");
                CreateCorpTrigger.DefaultValue = 0L;
                CreateCorpTrigger.Editable = true;
                CreateCorpTrigger.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__CreateCorpTrigger__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__CreateCorpTrigger__ = (System.Int64)_v_; }, false);
                CreateCorpTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateCorpTrigger() { App = (CorporationJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJson)pup).Handle((Input.CreateCorpTrigger)input); });
                AllCorporation = Add<__TArray__>("AllCorporation");
                AllCorporation.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__AllCorporation__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__AllCorporation__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CorpName;
            public __TLong__ CreateCorpTrigger;
            public __TArray__ AllCorporation;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CorpName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CorpName {
    #line 3 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.CorpName.Getter(this); }
        #line 3 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.CorpName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CreateCorpTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateCorpTrigger {
    #line 4 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.CreateCorpTrigger.Getter(this); }
        #line 4 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.CreateCorpTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__AllCorporation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ AllCorporation {
    #line 5 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.AllCorporation.Getter(this); }
        #line 5 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.AllCorporation.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CorpName : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateCorpTrigger : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
