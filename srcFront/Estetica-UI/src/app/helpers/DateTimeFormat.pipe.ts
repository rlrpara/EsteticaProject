import { DatePipe } from '@angular/common';
import { Pipe, PipeTransform } from '@angular/core';

import { MyContants } from '../utils/myContants';


@Pipe({
  name: 'DateTimeFormat'
})
export class DateTimeFormatPipe extends DatePipe implements PipeTransform {

  override transform(value: any, args?: any): any {
    return super.transform(value, MyContants.DATE_FMT);
  }

}
