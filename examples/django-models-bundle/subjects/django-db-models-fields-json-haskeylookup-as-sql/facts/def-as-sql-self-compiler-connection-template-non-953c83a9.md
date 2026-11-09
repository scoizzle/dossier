# Fact 953c83a9

Store id: bf64d5cc-cc1c-4807-a579-c07be8a87100

## Text

```text
def as_sql(self, compiler, connection, template=None)
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
- posted_at: `2026-11-09T23:44:50.9657500+00:00`

## Data

```json
{
  "end_line": 230,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 222,
  "symbol": "HasKeyLookup.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":222,"selector":"L222-L230","symbol":"HasKeyLookup.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 230,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 222,
    "symbol": "HasKeyLookup.as_sql"
  },
  "id": "bf64d5cc-cc1c-4807-a579-c07be8a87100",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9657500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 222,
        "selector": "L222-L230",
        "symbol": "HasKeyLookup.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "e549b2cf-6138-4058-b1e0-2a8678ad91a5",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, template=None)"
}
```
