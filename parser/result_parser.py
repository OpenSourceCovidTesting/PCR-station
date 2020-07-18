from datetime import datetime
import json

class ResultsParser(object):

    def __init__(self, result_file):
        self.original_file = result_file
        self.results = self.deserialize()
        self.preamble = self.get_preamble()
        self.wells = self.get_wells_data()


    def deserialize(self):
        with open("result.json", "rb") as f:
            result_json = json.load(f)
            return result_json

    def get_preamble(self, key=None):
        if key:
            return self.results["data_preamble"][key]
        else:
            return self.results["data_preamble"]

    def get_lab(self):
        return self.preamble["lab_name"]

    def get_pcr_serial(self):
        return self.preamble["pcr_serial"]

    def get_pct_result(self):
        return self.preamble["pct_result"]

    def get_nec_result(self):
        return self.preamble["nec_result"]

    def get_overall_result(self):
        return self.preamble["overall_result"]

    def get_cycles_cnt(self):
        return self.preamble["num_cycles"]

    def get_setpoint_celsius(self):
        return self.preamble["setpoint_celsius"]

    def get_username(self):
        return self.preamble["username"]

    def get_report_datetime(self):
        datetime_str = "{} {}".format(self.preamble["run_date"], self.preamble["run_time"])
        return datetime.strptime(datetime_str, "%d-%m-%Y %H-%M-%S")

    def get_wells_data(self):
        return self.results["wells_data"]

    def get_well_by_position(self, position):
        for well in self.wells:
            if well["well_num"] == position:
                return well

    def get_well_content(self, position):
        for well in self.wells:
            if well["well_num"] == position:
                return well["well_content"]


if __name__ == '__main__':
    rp = ResultsParser("result.json")
    print(rp.get_well_content("A02"))
