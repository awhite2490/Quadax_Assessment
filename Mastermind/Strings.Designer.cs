﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mastermind {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mastermind.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Please enter a 4 digit number to guess the secret answer:.
        /// </summary>
        internal static string AwaitingInputText {
            get {
                return ResourceManager.GetString("AwaitingInputText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to MasterMind. Guess the secret 4 digit number (each digit between 1 and 6) in 10 tries or less to win. For each digit that is correct and in the correct position, a + will print. For each digit that is correct but in the wrong position, a - will print. Press Enter to start a game..
        /// </summary>
        internal static string IntroductionText {
            get {
                return ResourceManager.GetString("IntroductionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You lost!.
        /// </summary>
        internal static string LossText {
            get {
                return ResourceManager.GetString("LossText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have {0} tries remaining..
        /// </summary>
        internal static string TriesRemainingText {
            get {
                return ResourceManager.GetString("TriesRemainingText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You win!.
        /// </summary>
        internal static string WinText {
            get {
                return ResourceManager.GetString("WinText", resourceCulture);
            }
        }
    }
}
