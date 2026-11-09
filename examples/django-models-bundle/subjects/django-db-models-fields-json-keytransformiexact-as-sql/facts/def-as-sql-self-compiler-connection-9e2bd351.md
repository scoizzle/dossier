# Fact 9e2bd351

Store id: 89f1f517-7fe9-49a5-b45a-4f8d04442678

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:51.0486770+00:00`

## Data

```json
{
  "end_line": 681,
  "entity_kind": "method",
  "parent": "KeyTransformIExact",
  "start_line": 671,
  "symbol": "KeyTransformIExact.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":671,"selector":"L671-L681","symbol":"KeyTransformIExact.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIExact.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 681,
    "entity_kind": "method",
    "parent": "KeyTransformIExact",
    "start_line": 671,
    "symbol": "KeyTransformIExact.as_sql"
  },
  "id": "89f1f517-7fe9-49a5-b45a-4f8d04442678",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0486770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 671,
        "selector": "L671-L681",
        "symbol": "KeyTransformIExact.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "13ba3ffc-5be5-4f9d-aeb6-8a523f40146a",
  "subject_name": "django/db/models/fields/json::KeyTransformIExact.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
