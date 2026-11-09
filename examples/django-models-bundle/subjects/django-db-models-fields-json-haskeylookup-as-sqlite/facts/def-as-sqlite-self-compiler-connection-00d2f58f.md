# Fact 00d2f58f

Store id: 26029a25-1460-40d7-a2cd-474f9120f39f

## Text

```text
def as_sqlite(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:50.9720860+00:00`

## Data

```json
{
  "end_line": 265,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 262,
  "symbol": "HasKeyLookup.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":262,"selector":"L262-L265","symbol":"HasKeyLookup.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 265,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 262,
    "symbol": "HasKeyLookup.as_sqlite"
  },
  "id": "26029a25-1460-40d7-a2cd-474f9120f39f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9720860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 262,
        "selector": "L262-L265",
        "symbol": "HasKeyLookup.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "4b82a01b-14f3-4fce-9d66-89561e25cdbb",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
