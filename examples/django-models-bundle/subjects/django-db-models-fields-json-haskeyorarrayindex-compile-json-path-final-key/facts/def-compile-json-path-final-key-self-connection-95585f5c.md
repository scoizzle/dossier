# Fact 95585f5c

Store id: 1f2574a5-8c3a-4f5c-9c76-da07b221d41e

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
- posted_at: `2026-11-09T23:44:50.9833090+00:00`

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
  "id": "1f2574a5-8c3a-4f5c-9c76-da07b221d41e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9833090+00:00"
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
  "subject_id": "9e837094-8dbe-4565-a4ed-9ec8612f7ad9",
  "subject_name": "django/db/models/fields/json::HasKeyOrArrayIndex.compile_json_path_final_key",
  "tags": [
    "entity:method"
  ],
  "text": "def compile_json_path_final_key(self, connection, key_transform)"
}
```
