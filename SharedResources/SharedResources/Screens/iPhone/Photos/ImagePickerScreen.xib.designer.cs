// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_SharedResources.Screens.iPhone.Photos {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("ImagePickerScreen")]
	public partial class ImagePickerScreen {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UITableView __mt_tblFeatures;
		
		private UIKit.UIButton __mt_btnChoosePhoto;
		
		private UIKit.UIButton __mt_btnTakePhoto;
		
		private UIKit.UIButton __mt_btnPhotoRoll;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("tblFeatures")]
		private UIKit.UITableView tblFeatures {
			get {
				this.__mt_tblFeatures = ((UIKit.UITableView)(this.GetNativeField("tblFeatures")));
				return this.__mt_tblFeatures;
			}
			set {
				this.__mt_tblFeatures = value;
				this.SetNativeField("tblFeatures", value);
			}
		}
		
		[Foundation.Connect("btnChoosePhoto")]
		private UIKit.UIButton btnChoosePhoto {
			get {
				this.__mt_btnChoosePhoto = ((UIKit.UIButton)(this.GetNativeField("btnChoosePhoto")));
				return this.__mt_btnChoosePhoto;
			}
			set {
				this.__mt_btnChoosePhoto = value;
				this.SetNativeField("btnChoosePhoto", value);
			}
		}
		
		[Foundation.Connect("btnTakePhoto")]
		private UIKit.UIButton btnTakePhoto {
			get {
				this.__mt_btnTakePhoto = ((UIKit.UIButton)(this.GetNativeField("btnTakePhoto")));
				return this.__mt_btnTakePhoto;
			}
			set {
				this.__mt_btnTakePhoto = value;
				this.SetNativeField("btnTakePhoto", value);
			}
		}
		
		[Foundation.Connect("btnPhotoRoll")]
		private UIKit.UIButton btnPhotoRoll {
			get {
				this.__mt_btnPhotoRoll = ((UIKit.UIButton)(this.GetNativeField("btnPhotoRoll")));
				return this.__mt_btnPhotoRoll;
			}
			set {
				this.__mt_btnPhotoRoll = value;
				this.SetNativeField("btnPhotoRoll", value);
			}
		}
	}
}
