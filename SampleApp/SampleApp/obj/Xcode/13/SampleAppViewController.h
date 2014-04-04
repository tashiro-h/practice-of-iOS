// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface SampleAppViewController : UIViewController {
	UILabel *_dispLabel;
	UIButton *_nextButton;
}

@property (nonatomic, retain) IBOutlet UILabel *dispLabel;

@property (nonatomic, retain) IBOutlet UIButton *nextButton;

- (IBAction)goToNext:(id)sender;

@end
