import { createSlice, PayloadAction } from "@reduxjs/toolkit"
import { AppThunk } from "./store";

export interface FetchState {
    errors: any;
    weather: any;
}

const  initialState: FetchState = {
    errors: "",
    weather: []
}

export const FetchSlice = createSlice({
    name: 'fetch',
    // `createSlice` will infer the state type from the `initialState` argument
    initialState,
    reducers: {
        setErrors: (state, { payload }: PayloadAction<any>) => {
            state.errors = payload;
        },
        setWeatherList: (state, { payload }: PayloadAction<any>) => {
			state.weather = payload;
		},
    },
});

export const fetchWeatherDetails = (): AppThunk => async (dispatch) => {
    debugger;
    let result = await fetch('weatherforecast')
    .then(response => response.json())
    .then(json => {console.log(json); return json});
    console.log(result,'result');
    dispatch(setWeatherList(result))
};

export const {
    setErrors,
    setWeatherList
} = FetchSlice.actions

export default FetchSlice.reducer;