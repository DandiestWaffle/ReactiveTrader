import main from './pages/main.vue'
import about from './pages/about.vue'

const routeDefinitions = [
    {name:'main', component: main, menu: {icon: 'fa-line-chart'}},
    {name:'about', component: about,  menu: {icon: 'info'}}
]

export default routeDefinitions