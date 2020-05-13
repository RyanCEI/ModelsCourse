interface IClientViewModel {
  id: number;
  name: string;
  contact: string;
  phone: string;
}

function showClient(vm: IClientViewModel) {
  console.log(vm.name);
}

showClient({
  id: 1,
  name: "foo",
  contact: "Ryan",
  phone: "5551212111"
});
