# Fact d474b60f

Store id: 9f33b10a-a2f7-40e7-9f64-d625bd9948ac

## Text

```text
def compile_json_path_final_key(self, connection, key_transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.9611320+00:00`

## Data

```json
{
  "end_line": 188,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 186,
  "symbol": "HasKeyLookup.compile_json_path_final_key"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":186,"selector":"L186-L188","symbol":"HasKeyLookup.compile_json_path_final_key"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.compile_json_path_final_key](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 188,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 186,
    "symbol": "HasKeyLookup.compile_json_path_final_key"
  },
  "id": "9f33b10a-a2f7-40e7-9f64-d625bd9948ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9611320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 186,
        "selector": "L186-L188",
        "symbol": "HasKeyLookup.compile_json_path_final_key"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "4dadec2c-699e-49d3-a2be-ed8ab8f1a378",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.compile_json_path_final_key",
  "tags": [
    "entity:method"
  ],
  "text": "def compile_json_path_final_key(self, connection, key_transform)"
}
```
