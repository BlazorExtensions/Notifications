interface INotificationsManager {
  IsSupported(): boolean;
  RequestPermission(): Promise<string>;
  Create(title: string, options: object): object;
}

export class NotificationsManager implements INotificationsManager {
  public RequestPermission = (): Promise<string> => {
    return new Promise((resolve, reject) => {
      Notification.requestPermission((permission) => {
        resolve(permission);
      });
    });
  }

  public IsSupported = (): boolean => {
    if (("Notification" in window))
      return true;
    return false;
  }

  public Create = (title: string, options: object): object => {
    var note = new Notification(title, options);
    return note;
  }
}
