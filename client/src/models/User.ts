import Child from "./Child";

 class User {
    constructor(public Tz: string, public FirstName: string, public LastName: string, public BirthDate: Date, public eGender:number,
        public eHmo: number,public children: Child[])
        {}
}
export default User;