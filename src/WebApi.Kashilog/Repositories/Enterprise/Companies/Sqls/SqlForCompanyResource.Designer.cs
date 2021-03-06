﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Kashilog.Repositories.Enterprise.Companies.Sqls {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlForCompanyResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlForCompanyResource() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebApi.Kashilog.Repositories.Enterprise.Companies.Sqls.SqlForCompanyResource", typeof(SqlForCompanyResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   Select
        ///	CompanyId			AS CompanyId,
        ///	CompanyName			AS CompanyName,
        ///	ZipCode				AS ZipCode,
        ///	Country				AS Country,
        ///	City				AS City,
        ///	Address				AS Address,
        ///	TelephoneNumber		AS TelephoneNumber
        ///From
        ///	enterprise.CmnCompany に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindAllCompany {
            get {
                return ResourceManager.GetString("FindAllCompany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Select
        ///	CompanyId			AS CompanyId,
        ///	CompanyName			AS CompanyName,
        ///	ZipCode				AS ZipCode,
        ///	Country				AS Country,
        ///	City				AS City,
        ///	Address				AS Address,
        ///	TelephoneNumber		AS TelephoneNumber
        ///From
        ///	enterprise.CmnCompany
        ///Where
        ///	CompanyId = @Id に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindCompanyById {
            get {
                return ResourceManager.GetString("FindCompanyById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Select
        ///	CompanyId			AS CompanyId,
        ///	CompanyName			AS CompanyName,
        ///	ZipCode				AS ZipCode,
        ///	Country				AS Country,
        ///	City				AS City,
        ///	Address				AS Address,
        ///	TelephoneNumber		AS TelephoneNumber
        ///From
        ///	enterprise.CmnCompany
        ///Where
        ///	CompanyId IN @Ids に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string FindCompanyInIds {
            get {
                return ResourceManager.GetString("FindCompanyInIds", resourceCulture);
            }
        }
    }
}
