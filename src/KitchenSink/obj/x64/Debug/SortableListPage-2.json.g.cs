// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "SortableListPage.json"
// Version: 2
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
#pragma warning disable 0108
#pragma warning disable 1591

namespace KitchenSink {
using __SPeLastName__ = global::KitchenSink.SortableListPage.PersonObj.Input.LastName;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __SoHtml__ = global::KitchenSink.SortableListPage.Input.Html;
using __Sortable2__ = global::KitchenSink.SortableListPage.Input;
using __Arr__ = global::Starcounter.Arr<global::KitchenSink.SortableListPage.PersonObj>;
using __Sortable1__ = global::KitchenSink.SortableListPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::KitchenSink.SortableListPage.PersonObj>;
using __SPeItemDrop__ = global::KitchenSink.SortableListPage.PersonObj.Input.ItemDropped;
using __SPeMoveDown__ = global::KitchenSink.SortableListPage.PersonObj.Input.MoveDown;
using __SPeMoveUp__ = global::KitchenSink.SortableListPage.PersonObj.Input.MoveUp;
using __SPeSortOrde__ = global::KitchenSink.SortableListPage.PersonObj.Input.SortOrder;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __SoPersonOb2__ = global::KitchenSink.SortableListPage.PersonObj.Input;
using __SoPersonOb1__ = global::KitchenSink.SortableListPage.PersonObj.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SPeSchema__ = global::KitchenSink.SortableListPage.PersonObj.JsonByExample.Schema;
using __SoPersonOb__ = global::KitchenSink.SortableListPage.PersonObj;
using __TString__ = global::Starcounter.Templates.TString;
using __SoSchema__ = global::KitchenSink.SortableListPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Sortable__ = global::KitchenSink.SortableListPage;
using __SPeFirstNam__ = global::KitchenSink.SortableListPage.PersonObj.Input.FirstName;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class SortableListPage_json : s::TemplateAttribute {
    
    #line hidden
    public class PersonList : s::TemplateAttribute {
    }
    #line default
}
#line default

#line hidden
public partial class SortableListPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SoSchema__ DefaultTemplate = new __SoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableListPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SortableListPage(__SoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SoSchema__ Template { get { return (__SoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Sortable__);
                ClassName = "SortableListPage";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/KitchenSink/SortableListPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Sortable__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Sortable__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                PersonList = Add<__TArray__>("PersonList");
                PersonList.SetCustomGetElementType((arr) => { return __SoPersonOb__.DefaultTemplate;});
                PersonList.SetCustomAccessors((_p_) => { return ((__Sortable__)_p_).__bf__PersonList__; }, (_p_, _v_) => { ((__Sortable__)_p_).__bf__PersonList__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Sortable__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ PersonList;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "SortableListPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "SortableListPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__PersonList__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ PersonList {
    #line 14 "SortableListPage.json"
        get {
        #line hidden
            return Template.PersonList.Getter(this); }
        #line 14 "SortableListPage.json"
        set {
        #line hidden
            Template.PersonList.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Sortable__, __TString__, string> {
        }
        #line default
    }
    #line default
    
    #line hidden
    public partial class PersonObj : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SPeSchema__ DefaultTemplate = new __SPeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PersonObj() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public PersonObj(__SPeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SPeSchema__ Template { get { return (__SPeSchema__)base.Template; } set { base.Template = value; } }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new Person Data { get { return (Person)base.Data; } set { base.Data = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__SoPersonOb__);
                    ClassName = "PersonObj";
                    Properties.ClearExposed();
                    FirstName = Add<__TString__>("FirstName");
                    FirstName.DefaultValue = "";
                    FirstName.SetCustomAccessors((_p_) => { return ((__SoPersonOb__)_p_).__bf__FirstName__; }, (_p_, _v_) => { ((__SoPersonOb__)_p_).__bf__FirstName__ = (System.String)_v_; }, false);
                    LastName = Add<__TString__>("LastName");
                    LastName.DefaultValue = "";
                    LastName.SetCustomAccessors((_p_) => { return ((__SoPersonOb__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__SoPersonOb__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                    SortOrder = Add<__TLong__>("SortOrder");
                    SortOrder.DefaultValue = 0L;
                    SortOrder.SetCustomAccessors((_p_) => { return ((__SoPersonOb__)_p_).__bf__SortOrder__; }, (_p_, _v_) => { ((__SoPersonOb__)_p_).__bf__SortOrder__ = (System.Int64)_v_; }, false);
                    MoveUp = Add<__TLong__>("MoveUp$");
                    MoveUp.DefaultValue = 0L;
                    MoveUp.Editable = true;
                    MoveUp.SetCustomAccessors((_p_) => { return ((__SoPersonOb__)_p_).__bf__MoveUp__; }, (_p_, _v_) => { ((__SoPersonOb__)_p_).__bf__MoveUp__ = (System.Int64)_v_; }, false);
                    MoveUp.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.MoveUp() { App = (PersonObj)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PersonObj)pup).Handle((Input.MoveUp)input); });
                    MoveDown = Add<__TLong__>("MoveDown$");
                    MoveDown.DefaultValue = 0L;
                    MoveDown.Editable = true;
                    MoveDown.SetCustomAccessors((_p_) => { return ((__SoPersonOb__)_p_).__bf__MoveDown__; }, (_p_, _v_) => { ((__SoPersonOb__)_p_).__bf__MoveDown__ = (System.Int64)_v_; }, false);
                    MoveDown.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.MoveDown() { App = (PersonObj)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PersonObj)pup).Handle((Input.MoveDown)input); });
                    ItemDropped = Add<__TLong__>("ItemDropped$");
                    ItemDropped.DefaultValue = 0L;
                    ItemDropped.Editable = true;
                    ItemDropped.SetCustomAccessors((_p_) => { return ((__SoPersonOb__)_p_).__bf__ItemDropped__; }, (_p_, _v_) => { ((__SoPersonOb__)_p_).__bf__ItemDropped__ = (System.Int64)_v_; }, false);
                    ItemDropped.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.ItemDropped() { App = (PersonObj)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PersonObj)pup).Handle((Input.ItemDropped)input); });
                }
                public override object CreateInstance(s.Json parent) { return new __SoPersonOb__(this) { Parent = parent }; }
                public __TString__ FirstName;
                public __TString__ LastName;
                public __TLong__ SortOrder;
                public __TLong__ MoveUp;
                public __TLong__ MoveDown;
                public __TLong__ ItemDropped;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__FirstName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FirstName {
        #line 6 "SortableListPage.json"
            get {
            #line hidden
                return Template.FirstName.Getter(this); }
            #line 6 "SortableListPage.json"
            set {
            #line hidden
                Template.FirstName.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__LastName__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String LastName {
        #line 7 "SortableListPage.json"
            get {
            #line hidden
                return Template.LastName.Getter(this); }
            #line 7 "SortableListPage.json"
            set {
            #line hidden
                Template.LastName.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__SortOrder__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SortOrder {
        #line 8 "SortableListPage.json"
            get {
            #line hidden
                return Template.SortOrder.Getter(this); }
            #line 8 "SortableListPage.json"
            set {
            #line hidden
                Template.SortOrder.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__MoveUp__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 MoveUp {
        #line 9 "SortableListPage.json"
            get {
            #line hidden
                return Template.MoveUp.Getter(this); }
            #line 9 "SortableListPage.json"
            set {
            #line hidden
                Template.MoveUp.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__MoveDown__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 MoveDown {
        #line 10 "SortableListPage.json"
            get {
            #line hidden
                return Template.MoveDown.Getter(this); }
            #line 10 "SortableListPage.json"
            set {
            #line hidden
                Template.MoveDown.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__ItemDropped__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ItemDropped {
        #line 12 "SortableListPage.json"
            get {
            #line hidden
                return Template.ItemDropped.Getter(this); }
            #line 12 "SortableListPage.json"
            set {
            #line hidden
                Template.ItemDropped.Setter(this, value); } }
            #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class FirstName : Input<__SoPersonOb__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class LastName : Input<__SoPersonOb__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class SortOrder : Input<__SoPersonOb__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class MoveUp : Input<__SoPersonOb__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class MoveDown : Input<__SoPersonOb__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class ItemDropped : Input<__SoPersonOb__, __TLong__, long> {
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
