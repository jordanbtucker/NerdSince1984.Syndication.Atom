﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NerdSince1984.Syndication.Atom {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NerdSince1984.Syndication.Atom.Errors", typeof(Errors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extension attributes cannot belong to the Atom namespace..
        /// </summary>
        internal static string AttributeAtomNamespace {
            get {
                return ResourceManager.GetString("AttributeAtomNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extension attributes must belong to a namespace..
        /// </summary>
        internal static string AttributeNoNamespace {
            get {
                return ResourceManager.GetString("AttributeNoNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified node cannot be added..
        /// </summary>
        internal static string CannotAddNode {
            get {
                return ResourceManager.GetString("CannotAddNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified node cannot be removed..
        /// </summary>
        internal static string CannotRemoveNode {
            get {
                return ResourceManager.GetString("CannotRemoveNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extension elements cannot belong to the Atom namespace..
        /// </summary>
        internal static string ElementAtomNamespace {
            get {
                return ResourceManager.GetString("ElementAtomNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value cannot be an empty string..
        /// </summary>
        internal static string EmptyString {
            get {
                return ResourceManager.GetString("EmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified XML does not represent an element..
        /// </summary>
        internal static string NotAnElement {
            get {
                return ResourceManager.GetString("NotAnElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified XML does not represent an XHTML div element..
        /// </summary>
        internal static string NotAnXhtmlDiv {
            get {
                return ResourceManager.GetString("NotAnXhtmlDiv", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An {0} must be created from an element with the name {1}..
        /// </summary>
        internal static string WrongElementName {
            get {
                return ResourceManager.GetString("WrongElementName", resourceCulture);
            }
        }
    }
}
