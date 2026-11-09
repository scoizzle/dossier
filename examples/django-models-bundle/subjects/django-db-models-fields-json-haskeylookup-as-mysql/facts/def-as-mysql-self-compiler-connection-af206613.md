# Fact af206613

Store id: 41cf7f9a-9274-42de-b767-b0e148c7e6db

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
- posted_at: `2026-11-09T23:31:57.8877380+00:00`

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
  "id": "41cf7f9a-9274-42de-b767-b0e148c7e6db",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8877380+00:00"
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
  "subject_id": "d0c40a73-56f8-432c-aa14-f78fdbb250a9",
  "subject_name": "django/db/models/fields/json::HasKeyLookup.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
