# Fact af206613

Store id: e88aa71d-fcee-43bb-a727-c380dfbe5f59

## Text

```text
def as_mysql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.6447870+00:00`

## Data

```json
{
  "end_line": 235,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 232,
  "symbol": "HasKeyLookup.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":232,"selector":"L232-L235","symbol":"HasKeyLookup.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 235,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 232,
    "symbol": "HasKeyLookup.as_mysql"
  },
  "id": "e88aa71d-fcee-43bb-a727-c380dfbe5f59",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6447870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 232,
        "selector": "L232-L235",
        "symbol": "HasKeyLookup.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "80f6b1ee-54a1-4092-89d5-2d1207bb8b90",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
