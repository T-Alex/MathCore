﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAlex.MathCore.ExpressionEvaluation.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TAlex.MathCore.ExpressionEvaluation.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The matrix must be square or column vector..
        /// </summary>
        public static string EXC_MATRIX_MUST_BE_SQUARE_OR_VECTOR {
            get {
                return ResourceManager.GetString("EXC_MATRIX_MUST_BE_SQUARE_OR_VECTOR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The matrix can be raised only to integer power..
        /// </summary>
        public static string EXC_MATRIX_NOT_INTEGER_POWER {
            get {
                return ResourceManager.GetString("EXC_MATRIX_NOT_INTEGER_POWER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong type arguments operation &apos;{0}&apos;..
        /// </summary>
        public static string EXC_WRONG_TYPE_ARGUMENTS_OPERATION {
            get {
                return ResourceManager.GetString("EXC_WRONG_TYPE_ARGUMENTS_OPERATION", resourceCulture);
            }
        }
    }
}
