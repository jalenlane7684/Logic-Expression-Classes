class XORGates {
	public static bool XOR(bool input1, bool input2) {
		if ((input1 && !input2) || (!input1 && input2)) {
			return true;
		}

		return false;
	}

	public static bool XOR(bool input1, bool input2, bool input3) {
		if ((input1 && !input2 && !input3) || (!input1 && input2 && !input3) || (!input1 && !input2 && input3)) {
			return true;
		}

		return false;
	}

	public static bool XOR(bool input1, bool input2, bool input3, bool input4) {
		if ((input1 && !input2 && !input3 && input4) || (!input1 && input2 && !input3 && !input4) || (!input1 && !input2 && input3 && !input4) || (!input1 && !input2 && !input3 && input4)) {
			return true;
		}

		return false;
	}

	public static bool XOR(bool input1, bool input2, bool input3, bool input4, bool input5) {
		if ((input1 && !input2 && !input3 && !input4 && !input5) || (!input1 && input2 && !input3 && !input4 && !input5) || (!input1 && !input2 && input3 && !input4 && !input5) || (!input1 && !input2 && !input3 && input4 && !input5) || (!input1 && !input2 && !input3 && !input4 && input5)) {
			return true;
		}

		return false;
	}

	public static bool XOR(bool input1, bool input2, bool input3, bool input4, bool input5, bool input6) {
		if ((input1 && !input2 && !input3 && !input4 && !input5 && !input6) || (!input1 && input2 && !input3 && !input4 && !input5 && !input6) || (!input1 && !input2 && input3 && !input4 && !input5 && !input6) || (!input1 && !input2 && !input3 && input4 && !input5 && !input6) || (!input1 && !input2 && !input3 && !input4 && input5 && !input6) || (!input1 && !input2 && !input3 && !input4 && !input5 && input6)) {
			return true;
		}

		return false;
	}
}