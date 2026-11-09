# Fact 9dc97428

Store id: 09dd15ef-38b0-484d-9966-8672b43dda3f

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
- posted_at: `2026-11-09T23:31:57.8774150+00:00`

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
  "id": "09dd15ef-38b0-484d-9966-8672b43dda3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8774150+00:00"
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
  "subject_id": "397dd665-22a4-4d45-8e58-5a08e3194b90",
  "subject_name": "django/db/models/fields/json::HasKeyLookup",
  "tags": [
    "entity:class"
  ],
  "text": "class HasKeyLookup(PostgresOperatorLookup)"
}
```
