import { configureStore, Action } from "@reduxjs/toolkit";
import { ThunkAction } from "redux-thunk";
import  rootReducer from "./rootReducer";
import type {RootState} from './rootReducer'
import {logger} from "redux-logger";

export type AppThunk = ThunkAction<void, RootState, unknown, Action<string>>;

export const myAppStore = configureStore({
  reducer: rootReducer,
  middleware: (getDefaultMiddleware) => getDefaultMiddleware().concat(logger),
});

export type AppDispatch = typeof myAppStore.dispatch;

export  default RootState;
