import {
  patchState,
  signalStore,
  withMethods,
  withProps,
  withState,
  withHooks,
} from '@ngrx/signals';
const COUNT_BY_VALUES = [1, 3, 5] as const;
type CountByValues = (typeof COUNT_BY_VALUES)[number];

type SignalState = {
  by: CountByValues;
};

export const CounterStore = signalStore(
  withState<SignalState>({
    by: 3,
  }),
  withProps(() => {
    return {
      values: COUNT_BY_VALUES,
    };
  }),
  withMethods((store) => {
    return {
      setCountBy: (by: CountByValues) => patchState(store, { by }),
    };
  }),
  withHooks({
    onInit() {
      console.log('created ');
    },
    OnDestoryed() {
      console.log('destoryed');
    },
  }),
);
