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
using __CoAllCorpo2__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoCreateFr__ = global::Haseeb.ViewModel.CorporationJson.Input.CreateFranchiseTrigger;
using __CoFranchis__ = global::Haseeb.ViewModel.CorporationJson.Input.FranchiseName;
using __CoCreateCo__ = global::Haseeb.ViewModel.CorporationJson.Input.CreateCorpTrigger;
using __CoCorpName__ = global::Haseeb.ViewModel.CorporationJson.Input.CorpName;
using __CoHtml__ = global::Haseeb.ViewModel.CorporationJson.Input.Html;
using __Corporat2__ = global::Haseeb.ViewModel.CorporationJson.Input;
using __Arr1__ = global::Starcounter.Arr<global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson>;
using __Corporat1__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample;
using __TArray1__ = global::Starcounter.Templates.TArray<global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson>;
using __CAlCorpName__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.Input.CorpName;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __CoAllCorpo1__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __CAlSchema__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.JsonByExample.Schema;
using __CoAllCorpo__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::Haseeb.ViewModel.CorporationJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationJson_json : s::TemplateAttribute {
    
    #line hidden
    public class AllCorporation : s::TemplateAttribute {
    }
    #line default
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
                AllCorporation = Add<__TArray1__>("AllCorporation", bind:"AllCorporation");
                AllCorporation.SetCustomGetElementType((arr) => { return __CoAllCorpo__.DefaultTemplate;});
                AllCorporation.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__AllCorporation__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__AllCorporation__ = (__Arr1__)_v_; }, false);
                FranchiseName = Add<__TString__>("FranchiseName$");
                FranchiseName.DefaultValue = "";
                FranchiseName.Editable = true;
                FranchiseName.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                CreateFranchiseTrigger = Add<__TLong__>("CreateFranchiseTrigger$");
                CreateFranchiseTrigger.DefaultValue = 0L;
                CreateFranchiseTrigger.Editable = true;
                CreateFranchiseTrigger.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__CreateFranchiseTrigger__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__CreateFranchiseTrigger__ = (System.Int64)_v_; }, false);
                CreateFranchiseTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateFranchiseTrigger() { App = (CorporationJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJson)pup).Handle((Input.CreateFranchiseTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CorpName;
            public __TLong__ CreateCorpTrigger;
            public __TArray1__ AllCorporation;
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
    private __Arr1__ __bf__AllCorporation__;
    #line default
    #line hidden
    private System.String __bf__FranchiseName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FranchiseName {
    #line 11 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.FranchiseName.Getter(this); }
        #line 11 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.FranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CreateFranchiseTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateFranchiseTrigger {
    #line 12 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.CreateFranchiseTrigger.Getter(this); }
        #line 12 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.CreateFranchiseTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class AllCorporationElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CAlSchema__ DefaultTemplate = new __CAlSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AllCorporationElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AllCorporationElementJson(__CAlSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CAlSchema__ Template { get { return (__CAlSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CoAllCorpo__);
                    Properties.ClearExposed();
                    CorpName = Add<__TString__>("CorpName");
                    CorpName.DefaultValue = "";
                    CorpName.SetCustomAccessors((_p_) => { return ((__CoAllCorpo__)_p_).__bf__CorpName__; }, (_p_, _v_) => { ((__CoAllCorpo__)_p_).__bf__CorpName__ = (System.String)_v_; }, false);
                    Franchises = Add<__TArray__>("Franchises");
                    Franchises.SetCustomAccessors((_p_) => { return ((__CoAllCorpo__)_p_).__bf__Franchises__; }, (_p_, _v_) => { ((__CoAllCorpo__)_p_).__bf__Franchises__ = (__Arr__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CoAllCorpo__(this) { Parent = parent }; }
                public __TString__ CorpName;
                public __TArray__ Franchises;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__CorpName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CorpName {
        #line 7 "ViewModel\CorporationJson.json"
            get {
            #line hidden
                return Template.CorpName.Getter(this); }
            #line 7 "ViewModel\CorporationJson.json"
            set {
            #line hidden
                Template.CorpName.Setter(this, value); } }
            #line default
        #line hidden
        private __Arr__ __bf__Franchises__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr__ Franchises {
        #line 8 "ViewModel\CorporationJson.json"
            get {
            #line hidden
                return Template.Franchises.Getter(this); }
            #line 8 "ViewModel\CorporationJson.json"
            set {
            #line hidden
                Template.Franchises.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CorpName : Input<__CoAllCorpo__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
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
        
        #line hidden
        public class FranchiseName : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateFranchiseTrigger : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
