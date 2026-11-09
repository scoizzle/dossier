# Fact d474b60f

Store id: 6ac3e53d-401c-4f96-80f8-42b6f9602860

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
- posted_at: `2026-11-09T22:39:43.6363500+00:00`

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
  "id": "6ac3e53d-401c-4f96-80f8-42b6f9602860",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6363500+00:00"
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
  "subject_id": "be44ff78-21bc-4134-a310-71cddc435615",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.compile_json_path_final_key",
  "tags": [
    "entity:method"
  ],
  "text": "def compile_json_path_final_key(self, connection, key_transform)"
}
```
