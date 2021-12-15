using System;

class NANDGates {
	public static bool NAND(bool input1, bool input2) {
		if (!(input1 && input2)) {
			return true;
		}

		return false;
	}

	public static bool NAND(bool input1, bool input2, bool input3) {
		if (!(input1 && input2 && input3)) {
			return true;
		}

		return false;
	}
	
	public static bool NAND(bool input1, bool input2, bool input3, bool input4) {
		if (!(input1 && input2 && input3 && input4)) {
			return true;
		}

		return false;
	}

	public static bool NAND(bool input1, bool input2, bool input3, bool input4, bool input5) {
		if (!(input1 && input2 && input3 && input4 && input5)) {
			return true;
		}

		return false;
	}

	public static bool NAND(bool input1, bool input2, bool input3, bool input4, bool input5, bool input6) {
		if (!(input1 && input2 && input3 && input4 && input5 && input6)) {
			return true;
		}

		return false;
	}

	public static bool NAND(bool input1, bool input2, bool input3, bool input4, bool input5, bool input6, bool input7) {
		if (!(input1 && input2 && input3 && input4 && input5 && input6 && input7)) {
			return true;
		}

		return false;
	}
}