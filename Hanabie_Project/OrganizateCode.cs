using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

public class SortableBindingList<T> : BindingList<T>
{
    private bool isSorted;
    private ListSortDirection sortDirection;
    private PropertyDescriptor sortProperty;

    protected override bool SupportsSortingCore => true;
    protected override bool IsSortedCore => isSorted;
    protected override ListSortDirection SortDirectionCore => sortDirection;
    protected override PropertyDescriptor SortPropertyCore => sortProperty;

    public SortableBindingList() : base() { }
    public SortableBindingList(IEnumerable<T> enumerable) : base(enumerable.ToList()) { }
    protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
    {
        List<T> items = this.Items as List<T>;

        if (items != null)
        {
            sortDirection = direction;
            sortProperty = property;

            Comparison<T> comparison = (x, y) =>
            {
                var valueX = property.GetValue(x);
                var valueY = property.GetValue(y);

                if (valueX == null && valueY == null)
                {
                    return 0;
                }
                else if (valueX == null)
                {
                    return direction == ListSortDirection.Ascending ? -1 : 1;
                }
                else if (valueY == null)
                {
                    return direction == ListSortDirection.Ascending ? 1 : -1;
                }
                else
                {
                    return ((IComparable)valueX).CompareTo(valueY);
                }
            };

            items.Sort(direction == ListSortDirection.Ascending ? comparison : (x, y) => -comparison(x, y));

            isSorted = true;
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
        else
        {
            isSorted = false;
        }
    }


    protected override void RemoveSortCore()
    {
        isSorted = false;
        sortDirection = ListSortDirection.Ascending;
        sortProperty = null;
    }
}
