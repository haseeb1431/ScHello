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
using __CAAlEditURL__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.Input.EditURL;
using __Arr__ = global::Starcounter.Arr<global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson>;
using __CoAllCorpo2__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.Input;
using __CAlCorpName__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.Input.CorpName;
using __CAlFranchis__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.Input.FranchisesCount;
using __TArray1__ = global::Starcounter.Templates.TArray<global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson>;
using __Corporat1__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample;
using __Arr1__ = global::Starcounter.Arr<global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson>;
using __Corporat2__ = global::Haseeb.ViewModel.CorporationJson.Input;
using __CoHtml__ = global::Haseeb.ViewModel.CorporationJson.Input.Html;
using __CoCorpName__ = global::Haseeb.ViewModel.CorporationJson.Input.CorpName;
using __CoCreateCo__ = global::Haseeb.ViewModel.CorporationJson.Input.CreateCorpTrigger;
using __CoFranchis__ = global::Haseeb.ViewModel.CorporationJson.Input.FranchiseName;
using __CoCreateFr__ = global::Haseeb.ViewModel.CorporationJson.Input.CreateFranchiseTrigger;
using __CoSortOnTr__ = global::Haseeb.ViewModel.CorporationJson.Input.SortOnTrigger;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __CoAllCorpo1__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson>;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __CAAlSalesTre__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.Input.SalesTrend;
using __Corporat__ = global::Haseeb.ViewModel.CorporationJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CoSchema__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __CoAllCorpo__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson;
using __CAlAllFranc__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson;
using __CAAlSchema__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.JsonByExample.Schema;
using __CAlAllFranc1__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.JsonByExample;
using __CAlAllFranc2__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.Input;
using __CAAlFranchis__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.Input.FranchiseName;
using __CAAlHouseSol__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.Input.HouseSold;
using __CAAlAverageC__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.Input.AverageCommission;
using __CAAlTotalCom__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.AllFranchisesElementJson.Input.TotalCommission;
using __CAlSchema__ = global::Haseeb.ViewModel.CorporationJson.AllCorporationElementJson.JsonByExample.Schema;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationJson_json : s::TemplateAttribute {
    
    #line hidden
    public class AllCorporation : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class AllFranchises : s::TemplateAttribute {
        }
        #line default
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
                SortOnTrigger = Add<__TLong__>("SortOnTrigger$");
                SortOnTrigger.DefaultValue = 0L;
                SortOnTrigger.Editable = true;
                SortOnTrigger.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SortOnTrigger__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SortOnTrigger__ = (System.Int64)_v_; }, false);
                SortOnTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnTrigger() { App = (CorporationJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJson)pup).Handle((Input.SortOnTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CorpName;
            public __TLong__ CreateCorpTrigger;
            public __TArray1__ AllCorporation;
            public __TString__ FranchiseName;
            public __TLong__ CreateFranchiseTrigger;
            public __TLong__ SortOnTrigger;
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
    #line 21 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.FranchiseName.Getter(this); }
        #line 21 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.FranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CreateFranchiseTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateFranchiseTrigger {
    #line 22 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.CreateFranchiseTrigger.Getter(this); }
        #line 22 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.CreateFranchiseTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SortOnTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SortOnTrigger {
    #line 24 "ViewModel\CorporationJson.json"
        get {
        #line hidden
            return Template.SortOnTrigger.Getter(this); }
        #line 24 "ViewModel\CorporationJson.json"
        set {
        #line hidden
            Template.SortOnTrigger.Setter(this, value); } }
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
                    FranchisesCount = Add<__TLong__>("FranchisesCount");
                    FranchisesCount.DefaultValue = 0L;
                    FranchisesCount.SetCustomAccessors((_p_) => { return ((__CoAllCorpo__)_p_).__bf__FranchisesCount__; }, (_p_, _v_) => { ((__CoAllCorpo__)_p_).__bf__FranchisesCount__ = (System.Int64)_v_; }, false);
                    AllFranchises = Add<__TArray__>("AllFranchises");
                    AllFranchises.SetCustomGetElementType((arr) => { return __CAlAllFranc__.DefaultTemplate;});
                    AllFranchises.SetCustomAccessors((_p_) => { return ((__CoAllCorpo__)_p_).__bf__AllFranchises__; }, (_p_, _v_) => { ((__CoAllCorpo__)_p_).__bf__AllFranchises__ = (__Arr__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CoAllCorpo__(this) { Parent = parent }; }
                public __TString__ CorpName;
                public __TLong__ FranchisesCount;
                public __TArray__ AllFranchises;
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
        private System.Int64 __bf__FranchisesCount__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 FranchisesCount {
        #line 8 "ViewModel\CorporationJson.json"
            get {
            #line hidden
                return Template.FranchisesCount.Getter(this); }
            #line 8 "ViewModel\CorporationJson.json"
            set {
            #line hidden
                Template.FranchisesCount.Setter(this, value); } }
            #line default
        #line hidden
        private __Arr__ __bf__AllFranchises__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr__ AllFranchises {
        #line 9 "ViewModel\CorporationJson.json"
            get {
            #line hidden
                return Template.AllFranchises.Getter(this); }
            #line 9 "ViewModel\CorporationJson.json"
            set {
            #line hidden
                Template.AllFranchises.Setter(this, value); } }
            #line default
        
        #line hidden
        public class AllFranchisesElementJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __CAAlSchema__ DefaultTemplate = new __CAAlSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AllFranchisesElementJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AllFranchisesElementJson(__CAAlSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __CAAlSchema__ Template { get { return (__CAAlSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__CAlAllFranc__);
                        Properties.ClearExposed();
                        FranchiseName = Add<__TString__>("FranchiseName");
                        FranchiseName.DefaultValue = "";
                        FranchiseName.SetCustomAccessors((_p_) => { return ((__CAlAllFranc__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__CAlAllFranc__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                        HouseSold = Add<__TLong__>("HouseSold");
                        HouseSold.DefaultValue = 0L;
                        HouseSold.SetCustomAccessors((_p_) => { return ((__CAlAllFranc__)_p_).__bf__HouseSold__; }, (_p_, _v_) => { ((__CAlAllFranc__)_p_).__bf__HouseSold__ = (System.Int64)_v_; }, false);
                        AverageCommission = Add<__TLong__>("AverageCommission");
                        AverageCommission.DefaultValue = 0L;
                        AverageCommission.SetCustomAccessors((_p_) => { return ((__CAlAllFranc__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__CAlAllFranc__)_p_).__bf__AverageCommission__ = (System.Int64)_v_; }, false);
                        TotalCommission = Add<__TLong__>("TotalCommission");
                        TotalCommission.DefaultValue = 0L;
                        TotalCommission.SetCustomAccessors((_p_) => { return ((__CAlAllFranc__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__CAlAllFranc__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                        SalesTrend = Add<__TLong__>("SalesTrend");
                        SalesTrend.DefaultValue = 0L;
                        SalesTrend.SetCustomAccessors((_p_) => { return ((__CAlAllFranc__)_p_).__bf__SalesTrend__; }, (_p_, _v_) => { ((__CAlAllFranc__)_p_).__bf__SalesTrend__ = (System.Int64)_v_; }, false);
                        EditURL = Add<__TString__>("EditURL");
                        EditURL.DefaultValue = "";
                        EditURL.SetCustomAccessors((_p_) => { return ((__CAlAllFranc__)_p_).__bf__EditURL__; }, (_p_, _v_) => { ((__CAlAllFranc__)_p_).__bf__EditURL__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __CAlAllFranc__(this) { Parent = parent }; }
                    public __TString__ FranchiseName;
                    public __TLong__ HouseSold;
                    public __TLong__ AverageCommission;
                    public __TLong__ TotalCommission;
                    public __TLong__ SalesTrend;
                    public __TString__ EditURL;
                }
                #line default
            }
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
            private System.Int64 __bf__HouseSold__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 HouseSold {
            #line 12 "ViewModel\CorporationJson.json"
                get {
                #line hidden
                    return Template.HouseSold.Getter(this); }
                #line 12 "ViewModel\CorporationJson.json"
                set {
                #line hidden
                    Template.HouseSold.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__AverageCommission__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 AverageCommission {
            #line 13 "ViewModel\CorporationJson.json"
                get {
                #line hidden
                    return Template.AverageCommission.Getter(this); }
                #line 13 "ViewModel\CorporationJson.json"
                set {
                #line hidden
                    Template.AverageCommission.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__TotalCommission__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 TotalCommission {
            #line 14 "ViewModel\CorporationJson.json"
                get {
                #line hidden
                    return Template.TotalCommission.Getter(this); }
                #line 14 "ViewModel\CorporationJson.json"
                set {
                #line hidden
                    Template.TotalCommission.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__SalesTrend__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 SalesTrend {
            #line 15 "ViewModel\CorporationJson.json"
                get {
                #line hidden
                    return Template.SalesTrend.Getter(this); }
                #line 15 "ViewModel\CorporationJson.json"
                set {
                #line hidden
                    Template.SalesTrend.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__EditURL__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String EditURL {
            #line 16 "ViewModel\CorporationJson.json"
                get {
                #line hidden
                    return Template.EditURL.Getter(this); }
                #line 16 "ViewModel\CorporationJson.json"
                set {
                #line hidden
                    Template.EditURL.Setter(this, value); } }
                #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class FranchiseName : Input<__CAlAllFranc__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class HouseSold : Input<__CAlAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class AverageCommission : Input<__CAlAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class TotalCommission : Input<__CAlAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class SalesTrend : Input<__CAlAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class EditURL : Input<__CAlAllFranc__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CorpName : Input<__CoAllCorpo__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class FranchisesCount : Input<__CoAllCorpo__, __TLong__, long> {
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
        
        #line hidden
        public class SortOnTrigger : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
