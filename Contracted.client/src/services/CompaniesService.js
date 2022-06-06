const { AppState } = require("../AppState.js");
const { logger } = require("../utils/Logger.js");
const { api } = require("./AxiosService.js");



class CompaniesService {
    async getAll() {
        const res = await api.get('api/companies')
        logger.log("[COMPANY DATA]", res.data)
        AppState.companies = res.data
    }
}