# Fact 95585f5c

Store id: 9c51d532-6817-410a-8526-ebb903ea98c5

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
- posted_at: `2026-11-09T22:39:43.6641200+00:00`

## Data

```json
{
  "end_line": 291,
  "entity_kind": "method",
  "parent": "HasKeyOrArrayIndex",
  "start_line": 290,
  "symbol": "HasKeyOrArrayIndex.compile_json_path_final_key"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":290,"selector":"L290-L291","symbol":"HasKeyOrArrayIndex.compile_json_path_final_key"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyOrArrayIndex.compile_json_path_final_key](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 291,
    "entity_kind": "method",
    "parent": "HasKeyOrArrayIndex",
    "start_line": 290,
    "symbol": "HasKeyOrArrayIndex.compile_json_path_final_key"
  },
  "id": "9c51d532-6817-410a-8526-ebb903ea98c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6641200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 290,
        "selector": "L290-L291",
        "symbol": "HasKeyOrArrayIndex.compile_json_path_final_key"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "8bec93ec-7f64-418d-a587-06a74e08ded2",
  "subject_name": "django/db/models/fields/json::HasKeyOrArrayIndex.compile_json_path_final_key",
  "tags": [
    "entity:method"
  ],
  "text": "def compile_json_path_final_key(self, connection, key_transform)"
}
```
