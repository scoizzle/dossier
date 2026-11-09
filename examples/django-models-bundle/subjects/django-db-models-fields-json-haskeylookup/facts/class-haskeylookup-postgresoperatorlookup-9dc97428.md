# Fact 9dc97428

Store id: 1cd4e4ef-af5d-4aaf-8b48-7ce982828956

## Text

```text
class HasKeyLookup(PostgresOperatorLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:43.6344680+00:00`

## Data

```json
{
  "end_line": 265,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 183,
  "symbol": "HasKeyLookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":183,"selector":"L183-L265","symbol":"HasKeyLookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 265,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 183,
    "symbol": "HasKeyLookup"
  },
  "id": "1cd4e4ef-af5d-4aaf-8b48-7ce982828956",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6344680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 183,
        "selector": "L183-L265",
        "symbol": "HasKeyLookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "f1c7f20a-9977-4fb5-adc1-adb0fbd5b11a",
  "subject_name": "django/db/models/fields/json::HasKeyLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeyLookup(PostgresOperatorLookup)"
}
```
