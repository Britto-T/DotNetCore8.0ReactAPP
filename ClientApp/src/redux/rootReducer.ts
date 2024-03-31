import { combineReducers } from '@reduxjs/toolkit';
import FetchSlice from './fetchSlice';

const rootReducer = combineReducers({
   fetchSlice : FetchSlice
});

export  type RootState = ReturnType<typeof rootReducer>;

export default rootReducer;