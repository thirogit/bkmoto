﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cowbasemock.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("cowbasemock.Properties.Resources", typeof(Resources).Assembly);
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
        
        internal static byte[] CATTLESQL {
            get {
                object obj = ResourceManager.GetObject("CATTLESQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] HENTSSQL {
            get {
                object obj = ResourceManager.GetObject("HENTSSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] HENTTYPESSQL {
            get {
                object obj = ResourceManager.GetObject("HENTTYPESSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO henttypes(henttypeid,henttypename) VALUES(1,&apos;Firma&apos;);
        ///INSERT INTO henttypes(henttypeid,henttypename) VALUES(2,&apos;Indywidualny&apos;);
        ///.
        /// </summary>
        internal static string HENTTYPESSQL_DEF {
            get {
                return ResourceManager.GetString("HENTTYPESSQL_DEF", resourceCulture);
            }
        }
        
        internal static byte[] INDOCSSQL {
            get {
                object obj = ResourceManager.GetObject("INDOCSSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] OUTDOCSSQL {
            get {
                object obj = ResourceManager.GetObject("OUTDOCSSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] REASONSSQL {
            get {
                object obj = ResourceManager.GetObject("REASONSSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO inoutreasons(reasonid,reasoncode,reasonname,inoutreason) VALUES(1,&apos;UR&apos;,&apos;URODZENIE&apos;,1);
        ///INSERT INTO inoutreasons(reasonid,reasoncode,reasonname,inoutreason) VALUES(2,&apos;K&apos;,&apos;KUPNO&apos;,1);
        ///INSERT INTO inoutreasons(reasonid,reasoncode,reasonname,inoutreason) VALUES(3,&apos;I&apos;,&apos;IMPORT&apos;,1);
        ///INSERT INTO inoutreasons(reasonid,reasoncode,reasonname,inoutreason) VALUES(4,&apos;E&apos;,&apos;EXPORT&apos;,-1);
        ///INSERT INTO inoutreasons(reasonid,reasoncode,reasonname,inoutreason) VALUES(5,&apos;SU&apos;,&apos;SPRZEDAŻ W CELU UBOJU&apos;,-1);
        ///INSERT INTO [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string REASONSSQL_DEF {
            get {
                return ResourceManager.GetString("REASONSSQL_DEF", resourceCulture);
            }
        }
        
        internal static byte[] STOCKSSQL {
            get {
                object obj = ResourceManager.GetObject("STOCKSSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        internal static byte[] SYNCLOCKSQL {
            get {
                object obj = ResourceManager.GetObject("SYNCLOCKSQL", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO synclock(lockid,locktime,lock) VALUES(1,GETDATE(),0);
        ///.
        /// </summary>
        internal static string SYNCLOCKSQL_DEF {
            get {
                return ResourceManager.GetString("SYNCLOCKSQL_DEF", resourceCulture);
            }
        }
    }
}