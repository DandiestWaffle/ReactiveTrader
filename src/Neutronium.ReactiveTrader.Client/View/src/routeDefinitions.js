import main from './pages/main.vue'
import about from './pages/about.vue'
import blot from './pages/blot.vue'

const routeDefinitions = [
    {name:'main', component: main, menu: {icon: 'fa-line-chart'}},
    {name:'blot', component: blot,  menu: {icon: 'view_list'}},
    {name:'about', component: about,  menu: {icon: 'info'}}
]

export default routeDefinitions