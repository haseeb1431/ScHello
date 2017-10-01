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
using System.Linq;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Haseeb.ViewModel {
using __CCAlEditURL__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.Input.EditURL;
using __Arr__ = global::Starcounter.Arr<global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson>;
using __CoCorporat2__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.Input;
using __CCoCorpName__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.Input.CorpName;
using __CCoFranchis__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.Input.FranchisesCount;
using __CCoFranchis1__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.Input.FranchiseName;
using __CCoCreateFr__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.Input.CreateFranchiseTrigger;
using __CCoSortOnTr__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.Input.SortOnTrigger;
using __TArray1__ = global::Starcounter.Templates.TArray<global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise>;
using __Corporat1__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample;
using __Arr1__ = global::Starcounter.Arr<global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise>;
using __Corporat2__ = global::Haseeb.ViewModel.CorporationJson.Input;
using __CoHtml__ = global::Haseeb.ViewModel.CorporationJson.Input.Html;
using __CoCorpName__ = global::Haseeb.ViewModel.CorporationJson.Input.CorpName;
using __CoCreateCo__ = global::Haseeb.ViewModel.CorporationJson.Input.CreateCorpTrigger;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __CoCorporat1__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson>;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __CCAlSalesTre__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.Input.SalesTrend;
using __Corporat__ = global::Haseeb.ViewModel.CorporationJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CoSchema__ = global::Haseeb.ViewModel.CorporationJson.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __CoCorporat__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise;
using __CCoAllFranc__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson;
using __CCAlSchema__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.JsonByExample.Schema;
using __CCoAllFranc1__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.JsonByExample;
using __CCoAllFranc2__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.Input;
using __CCAlFranchis__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.Input.FranchiseName;
using __CCAlHouseSol__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.Input.HouseSold;
using __CCAlAverageC__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.Input.AverageCommission;
using __CCAlTotalCom__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.AllFranchisesSortedElementJson.Input.TotalCommission;
using __CCoSchema__ = global::Haseeb.ViewModel.CorporationJson.CorporationJsonFranchise.JsonByExample.Schema;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationJson_json : s::TemplateAttribute {
    
    #line hidden
    public class AllCorporation : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class AllFranchisesSorted : s::TemplateAttribute {
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
                AllCorporation.SetCustomGetElementType((arr) => { return __CoCorporat__.DefaultTemplate;});
                AllCorporation.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__AllCorporation__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__AllCorporation__ = (__Arr1__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CorpName;
            public __TLong__ CreateCorpTrigger;
            public __TArray1__ AllCorporation;
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
    
    #line hidden
    public partial class CorporationJsonFranchise : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCoSchema__ DefaultTemplate = new __CCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationJsonFranchise() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationJsonFranchise(__CCoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCoSchema__ Template { get { return (__CCoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CoCorporat__);
                    Properties.ClearExposed();
                    CorpName = Add<__TString__>("CorpName");
                    CorpName.DefaultValue = "";
                    CorpName.SetCustomAccessors((_p_) => { return ((__CoCorporat__)_p_).__bf__CorpName__; }, (_p_, _v_) => { ((__CoCorporat__)_p_).__bf__CorpName__ = (System.String)_v_; }, false);
                    FranchisesCount = Add<__TLong__>("FranchisesCount");
                    FranchisesCount.DefaultValue = 0L;
                    FranchisesCount.SetCustomAccessors((_p_) => { return ((__CoCorporat__)_p_).__bf__FranchisesCount__; }, (_p_, _v_) => { ((__CoCorporat__)_p_).__bf__FranchisesCount__ = (System.Int64)_v_; }, false);
                    AllFranchisesSorted = Add<__TArray__>("AllFranchisesSorted", bind:"AllFranchisesSorted");
                    AllFranchisesSorted.SetCustomGetElementType((arr) => { return __CCoAllFranc__.DefaultTemplate;});
                    AllFranchisesSorted.SetCustomAccessors((_p_) => { return ((__CoCorporat__)_p_).__bf__AllFranchisesSorted__; }, (_p_, _v_) => { ((__CoCorporat__)_p_).__bf__AllFranchisesSorted__ = (__Arr__)_v_; }, false);
                    FranchiseName = Add<__TString__>("FranchiseName$");
                    FranchiseName.DefaultValue = "";
                    FranchiseName.Editable = true;
                    FranchiseName.SetCustomAccessors((_p_) => { return ((__CoCorporat__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__CoCorporat__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                    CreateFranchiseTrigger = Add<__TLong__>("CreateFranchiseTrigger$");
                    CreateFranchiseTrigger.DefaultValue = 0L;
                    CreateFranchiseTrigger.Editable = true;
                    CreateFranchiseTrigger.SetCustomAccessors((_p_) => { return ((__CoCorporat__)_p_).__bf__CreateFranchiseTrigger__; }, (_p_, _v_) => { ((__CoCorporat__)_p_).__bf__CreateFranchiseTrigger__ = (System.Int64)_v_; }, false);
                    CreateFranchiseTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateFranchiseTrigger() { App = (CorporationJsonFranchise)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJsonFranchise)pup).Handle((Input.CreateFranchiseTrigger)input); });
                    SortOnTrigger = Add<__TLong__>("SortOnTrigger$");
                    SortOnTrigger.DefaultValue = 0L;
                    SortOnTrigger.Editable = true;
                    SortOnTrigger.SetCustomAccessors((_p_) => { return ((__CoCorporat__)_p_).__bf__SortOnTrigger__; }, (_p_, _v_) => { ((__CoCorporat__)_p_).__bf__SortOnTrigger__ = (System.Int64)_v_; }, false);
                    SortOnTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SortOnTrigger() { App = (CorporationJsonFranchise)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationJsonFranchise)pup).Handle((Input.SortOnTrigger)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __CoCorporat__(this) { Parent = parent }; }
                public __TString__ CorpName;
                public __TLong__ FranchisesCount;
                public __TArray__ AllFranchisesSorted;
                public __TString__ FranchiseName;
                public __TLong__ CreateFranchiseTrigger;
                public __TLong__ SortOnTrigger;
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
        private __Arr__ __bf__AllFranchisesSorted__;
        #line default
        #line hidden
        private System.String __bf__FranchiseName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FranchiseName {
        #line 19 "ViewModel\CorporationJson.json"
            get {
            #line hidden
                return Template.FranchiseName.Getter(this); }
            #line 19 "ViewModel\CorporationJson.json"
            set {
            #line hidden
                Template.FranchiseName.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__CreateFranchiseTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 CreateFranchiseTrigger {
        #line 20 "ViewModel\CorporationJson.json"
            get {
            #line hidden
                return Template.CreateFranchiseTrigger.Getter(this); }
            #line 20 "ViewModel\CorporationJson.json"
            set {
            #line hidden
                Template.CreateFranchiseTrigger.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SortOnTrigger__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SortOnTrigger {
        #line 21 "ViewModel\CorporationJson.json"
            get {
            #line hidden
                return Template.SortOnTrigger.Getter(this); }
            #line 21 "ViewModel\CorporationJson.json"
            set {
            #line hidden
                Template.SortOnTrigger.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class AllFranchisesSortedElementJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __CCAlSchema__ DefaultTemplate = new __CCAlSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AllFranchisesSortedElementJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AllFranchisesSortedElementJson(__CCAlSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __CCAlSchema__ Template { get { return (__CCAlSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            #line default
            
            #line hidden
            public static class JsonByExample {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__CCoAllFranc__);
                        Properties.ClearExposed();
                        FranchiseName = Add<__TString__>("FranchiseName");
                        FranchiseName.DefaultValue = "";
                        FranchiseName.SetCustomAccessors((_p_) => { return ((__CCoAllFranc__)_p_).__bf__FranchiseName__; }, (_p_, _v_) => { ((__CCoAllFranc__)_p_).__bf__FranchiseName__ = (System.String)_v_; }, false);
                        HouseSold = Add<__TLong__>("HouseSold");
                        HouseSold.DefaultValue = 0L;
                        HouseSold.SetCustomAccessors((_p_) => { return ((__CCoAllFranc__)_p_).__bf__HouseSold__; }, (_p_, _v_) => { ((__CCoAllFranc__)_p_).__bf__HouseSold__ = (System.Int64)_v_; }, false);
                        AverageCommission = Add<__TLong__>("AverageCommission");
                        AverageCommission.DefaultValue = 0L;
                        AverageCommission.SetCustomAccessors((_p_) => { return ((__CCoAllFranc__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__CCoAllFranc__)_p_).__bf__AverageCommission__ = (System.Int64)_v_; }, false);
                        TotalCommission = Add<__TLong__>("TotalCommission");
                        TotalCommission.DefaultValue = 0L;
                        TotalCommission.SetCustomAccessors((_p_) => { return ((__CCoAllFranc__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__CCoAllFranc__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                        SalesTrend = Add<__TLong__>("SalesTrend");
                        SalesTrend.DefaultValue = 0L;
                        SalesTrend.SetCustomAccessors((_p_) => { return ((__CCoAllFranc__)_p_).__bf__SalesTrend__; }, (_p_, _v_) => { ((__CCoAllFranc__)_p_).__bf__SalesTrend__ = (System.Int64)_v_; }, false);
                        EditURL = Add<__TString__>("EditURL");
                        EditURL.DefaultValue = "";
                        EditURL.SetCustomAccessors((_p_) => { return ((__CCoAllFranc__)_p_).__bf__EditURL__; }, (_p_, _v_) => { ((__CCoAllFranc__)_p_).__bf__EditURL__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __CCoAllFranc__(this) { Parent = parent }; }
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
            public static class Input {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class FranchiseName : Input<__CCoAllFranc__, __TString__, string> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class HouseSold : Input<__CCoAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class AverageCommission : Input<__CCoAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class TotalCommission : Input<__CCoAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class SalesTrend : Input<__CCoAllFranc__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class EditURL : Input<__CCoAllFranc__, __TString__, string> {
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
            public class CorpName : Input<__CoCorporat__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class FranchisesCount : Input<__CoCorporat__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class FranchiseName : Input<__CoCorporat__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CreateFranchiseTrigger : Input<__CoCorporat__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SortOnTrigger : Input<__CoCorporat__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
